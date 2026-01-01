using System.Threading.Tasks;
using dotnet_store.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace dotnet_store.Controllers;

[Authorize(Roles = "Admin")]
public class UrunController : Controller
{

    private readonly DataContext _context;
    public UrunController(DataContext context)
    {
        _context = context;
    }
    public ActionResult Index(int? kategori)
    {
        var query = _context.Urunler.AsQueryable();

        if(kategori != null)
        {
            query = query.Where(i => i.KategoriId == kategori);
        }

        var urunler = query.Select(i => new UrunGetModel
        {
            Id = i.Id,
            UrunAd = i.UrunAd,
            Fiyat = i.Fiyat,
            Resim = i.Resim,
            Active = i.Active,
            Anasayfa = i.Anasayfa,
            KategoriAdi = i.Kategori.KategoriAdi
        }).ToList();
        
        // ViewData["Kategoriler"] = _context.Kategoriler.ToList();
        ViewBag.kategoriler = new SelectList(_context.Kategoriler.ToList(),"Id","KategoriAdi",kategori);
        return View(urunler);
    }

    [AllowAnonymous]
    public ActionResult List(string url, string q)
    {

        var query = _context.Urunler.Where(i => i.Active);
        if (!string.IsNullOrEmpty(url))
        {
            query = query.Where(i => i.Kategori.Url == url);
        }

        if (!string.IsNullOrEmpty(q))
        {
            query = query.Where(i => i.UrunAd.ToLower().Contains(q.ToLower()));
            
            ViewData["q"] = q;
        }

        return View(query.ToList());
    }

    [AllowAnonymous]
    public ActionResult Details(int id)
    {
        var urun = _context.Urunler.FirstOrDefault(i => i.Id == id);
        if (urun == null)
        {
            return RedirectToAction("index", "Home");
        }

        ViewData["BenzerUrunler"] = _context.Urunler.Where(i => i.Active && i.KategoriId == urun.KategoriId && i.Id != id).Take(4).ToList();
        return View(urun);
    }
    public ActionResult Create()
    {
        ViewData["Kategoriler"] = _context.Kategoriler.ToList();
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(UrunCreateModel model)
    {
        
        if(model.Resim == null || model.Resim.Length == 0)
        {
            ModelState.AddModelError("Resim", "Resim seçmelisiniz.");
        }

        if (ModelState.IsValid)
        {
            var fileName = Path.GetRandomFileName() + ".jpg";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await model.Resim!.CopyToAsync(stream);
            }

            var Entity = new Urun
            {
                UrunAd = model.UrunAd,
                Fiyat = model.Fiyat ?? 0,
                Resim = fileName,
                Aciklama = model.Aciklama,
                Active = model.Active,
                Anasayfa = model.Anasayfa,
                KategoriId = (int)model.KategoriId!
            };

            _context.Urunler.Add(Entity);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        ViewData["Kategoriler"] = _context.Kategoriler.ToList();
        return View(model);
    }

    public ActionResult Edit(int id)
    {
        var entity = _context.Urunler.Select(i => new UrunEditModel
        {
            Id = i.Id,
            UrunAd = i.UrunAd,
            Fiyat = i.Fiyat,
            ResimAdi = i.Resim,
            Aciklama = i.Aciklama,
            Active = i.Active,
            Anasayfa = i.Anasayfa,
            KategoriId = i.KategoriId
        }).FirstOrDefault(i => i.Id == id);

        ViewData["Kategoriler"] = _context.Kategoriler.ToList();
        return View(entity);
    }
    
    [HttpPost]
    public async Task<ActionResult> Edit(int id, UrunEditModel model)
    {
        if (id != model.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            
            var entity = _context.Urunler.FirstOrDefault(i => i.Id == model.Id); 
            if(entity != null)
            {
                if(model.Resim != null)
                {
                    var fileName = Path.GetRandomFileName() + ".jpg";
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.Resim!.CopyToAsync(stream);
                    }

                    entity.Resim = fileName;
                }

                entity.Id = model.Id;
                entity.UrunAd = model.UrunAd;
                entity.Fiyat = model.Fiyat ?? 0;
                entity.Aciklama = model.Aciklama;
                entity.Active = model.Active;
                entity.Anasayfa = model.Anasayfa;
                entity.KategoriId = (int)model.KategoriId!;

                _context.SaveChanges();

                TempData["Message"] = $"{entity.UrunAd} urunu guncellendi";
                return RedirectToAction("Index");
            };
        }

        ViewData["Kategoriler"] = _context.Kategoriler.ToList();
        return View(model);
    }

    public ActionResult Delete(int? id)
    {
        if(id == null)
        {
            return RedirectToAction("Index");
        }

        var entity = _context.Urunler.FirstOrDefault(i => i.Id == id);

        if(entity != null)
        {
           return View(entity);
        }
        return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteConfirm(int? id)
    {
        if(id == null)
        {
            return RedirectToAction("Index");
        }

        var entity = _context.Urunler.FirstOrDefault(i => i.Id == id);

        if(entity != null)
        {
            _context.Urunler.Remove(entity);
            _context.SaveChanges();
            TempData["Message"] = $"{entity.UrunAd} isimli urun silindi";
        }
        return RedirectToAction("Index");
    }
}