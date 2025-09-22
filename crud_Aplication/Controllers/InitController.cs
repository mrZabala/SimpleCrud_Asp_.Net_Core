using System.Diagnostics;
using crud_Aplication.Data;
using crud_Aplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crud_Aplication.Controllers
{
    public class InitController : Controller
    {

        private readonly AppDbContext _context;

        public InitController(AppDbContext context)
        {
            _context = context; //Llamamos al contexto
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Contacts.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
