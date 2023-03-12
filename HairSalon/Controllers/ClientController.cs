using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {
    private readonly HairSalonContext _db;
    public ClientController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients
                            .Include(client => client.Stylist)
                            .ToList();      
      return View();
    }
    public ActionResult Create()
      {
        return View();
      }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {

      Client thisClient = _db.Clients
                          .Include(client => client.Stylist)
                          .FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }
    public ActionResult Edit(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      // ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name"); Do I need something like this?
      return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
      _db.Clients.Update(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(Client => Client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(Client => Client.ClientId == id);
      _db.Clients.Remove(thisClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}