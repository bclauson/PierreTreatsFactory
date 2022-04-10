using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PierreTreatsFactory.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierreTreatsFactory.Controllers
{
  public class TreatsController : Controller
  {
    private readonly PierreTreatsFactoryContext _db;

    public TreatsController(PierreTreatsFactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }

  }
}