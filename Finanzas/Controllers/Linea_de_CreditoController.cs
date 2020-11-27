using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Finanzas.Models;

namespace Finanzas.Controllers
{
    public class Linea_de_CreditoController : Controller
    {
        private readonly AppDbContext _context;

        public Linea_de_CreditoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Linea_de_Credito
        public async Task<IActionResult> Index()
        {
            return View(await _context.LineasDeCredito.Where(d=>d.Creador==User.Identity.Name).ToListAsync());
        }

        // GET: Linea_de_Credito/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linea_de_Credito = await _context.LineasDeCredito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (linea_de_Credito == null)
            {
                return NotFound();
            }

            return View(linea_de_Credito);
        }

        // GET: Linea_de_Credito/Create
        public IActionResult Create()
        {
            var TiposMovimientos = new List<TiposAños>();
            TiposMovimientos.Add(new TiposAños { Id = 0, Nombre = "Ordinario" });
            TiposMovimientos.Add(new TiposAños { Id = 1, Nombre = "Biciesto" });
            ViewData["TiposAño"] = new SelectList(TiposMovimientos, "Id", "Nombre");

            var TiposMovimientos3 = new List<TiposTasa>();
            TiposMovimientos3.Add(new TiposTasa { Id = 0, Nombre = "Nominal" });
            TiposMovimientos3.Add(new TiposTasa { Id = 1, Nombre = "Simple" });
            TiposMovimientos3.Add(new TiposTasa { Id = 2, Nombre = "Efectiva" });
            ViewData["TiposTasa"] = new SelectList(TiposMovimientos3, "Id", "Nombre");
            var TiposMovimientos4 = new List<TiposDeCapitalizacion>();
            TiposMovimientos4.Add(new TiposDeCapitalizacion { Id = 0, Nombre = "Diaria" });
            TiposMovimientos4.Add(new TiposDeCapitalizacion { Id = 1, Nombre = "Quincenal" });
            TiposMovimientos4.Add(new TiposDeCapitalizacion { Id = 2, Nombre = "Mensual" });
            ViewData["Capitalizacion"] = new SelectList(TiposMovimientos4, "Id", "Nombre");

            var TiposMovimientos2 = new List<TiposDePeriodo>();
            TiposMovimientos2.Add(new TiposDePeriodo { Id = 0, Nombre = "Mensual" });
            TiposMovimientos2.Add(new TiposDePeriodo { Id = 1, Nombre = "Bimestral" });
            ViewData["TiposPeriodo"] = new SelectList(TiposMovimientos2, "Id", "Nombre");
            return View();
        }
        public class TiposAños
        {
            public short Id { set; get; }
            public string Nombre {set;get;}
        }
        public class TiposTasa
        {
            public short Id { set; get; }
            public string Nombre { set; get; }
        }
        public class TiposDePeriodo
        {
            public short Id { set; get; }
            public string Nombre { set; get; }
        }
        public class TiposDeCapitalizacion
        {
            public short Id { set; get; }
            public string Nombre { set; get; }
        }

        // POST: Linea_de_Credito/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Interes,NombrePaquete,Tasa,Periodo,Credito,Year,Capitalizacion")] Linea_de_Credito linea_de_Credito)
        {
            if (ModelState.IsValid)
            {
                linea_de_Credito.Id = Guid.NewGuid();
                linea_de_Credito.Creador = User.Identity.Name;
                _context.Add(linea_de_Credito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var TiposMovimientos = new List<TiposAños>();
            TiposMovimientos.Add(new TiposAños { Id = 0, Nombre = "Ordinario" });
            TiposMovimientos.Add(new TiposAños { Id = 1, Nombre = "Biciesto" });
            ViewData["TiposAño"] = new SelectList(TiposMovimientos, "Id", "Nombre",linea_de_Credito.Year);

            var TiposMovimientos3 = new List<TiposTasa>();
            TiposMovimientos3.Add(new TiposTasa { Id = 0, Nombre = "Nominal" });
            TiposMovimientos3.Add(new TiposTasa { Id = 1, Nombre = "Simple" });
            TiposMovimientos3.Add(new TiposTasa { Id = 2, Nombre = "Efectiva" });
            ViewData["TiposTasa"] = new SelectList(TiposMovimientos3, "Id", "Nombre",linea_de_Credito.Tasa);
            var TiposMovimientos4 = new List<TiposDeCapitalizacion>();
            TiposMovimientos4.Add(new TiposDeCapitalizacion { Id = 0, Nombre = "Diaria" });
            TiposMovimientos4.Add(new TiposDeCapitalizacion { Id = 1, Nombre = "Quincenal" });
            TiposMovimientos4.Add(new TiposDeCapitalizacion { Id = 2, Nombre = "Mensual" });
            ViewData["Capitalizacion"] = new SelectList(TiposMovimientos4, "Id", "Nombre", linea_de_Credito.Capitalizacion);

            var TiposMovimientos2 = new List<TiposDePeriodo>();
            TiposMovimientos2.Add(new TiposDePeriodo { Id = 0, Nombre = "Mensual" });
            TiposMovimientos2.Add(new TiposDePeriodo { Id = 1, Nombre = "Bimestral" });
            ViewData["TiposPeriodo"] = new SelectList(TiposMovimientos2, "Id", "Nombre",linea_de_Credito.Periodo);
            return View(linea_de_Credito);
        }

        // GET: Linea_de_Credito/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linea_de_Credito = await _context.LineasDeCredito.FindAsync(id);
            if (linea_de_Credito == null)
            {
                return NotFound();
            }
            var TiposMovimientos = new List<TiposAños>();
            TiposMovimientos.Add(new TiposAños { Id = 0, Nombre = "Ordinario" });
            TiposMovimientos.Add(new TiposAños { Id = 1, Nombre = "Biciesto" });
            ViewData["TiposAño"] = new SelectList(TiposMovimientos, "Id", "Nombre", linea_de_Credito.Year);

            var TiposMovimientos3 = new List<TiposTasa>();
            TiposMovimientos3.Add(new TiposTasa { Id = 0, Nombre = "Nominal" });
            TiposMovimientos3.Add(new TiposTasa { Id = 1, Nombre = "Simple" });
            TiposMovimientos3.Add(new TiposTasa { Id = 2, Nombre = "Efectiva" });
            ViewData["TiposTasa"] = new SelectList(TiposMovimientos3, "Id", "Nombre", linea_de_Credito.Tasa);
            var TiposMovimientos4 = new List<TiposDeCapitalizacion>();
            TiposMovimientos4.Add(new TiposDeCapitalizacion { Id = 0, Nombre = "Diaria" });
            TiposMovimientos4.Add(new TiposDeCapitalizacion { Id = 1, Nombre = "Quincenal" });
            TiposMovimientos4.Add(new TiposDeCapitalizacion { Id = 2, Nombre = "Mensual" });
            ViewData["Capitalizacion"] = new SelectList(TiposMovimientos4, "Id", "Nombre", linea_de_Credito.Capitalizacion);
            var TiposMovimientos2 = new List<TiposDePeriodo>();
            TiposMovimientos2.Add(new TiposDePeriodo { Id = 0, Nombre = "Mensual" });
            TiposMovimientos2.Add(new TiposDePeriodo { Id = 1, Nombre = "Bimestral" });
            ViewData["TiposPeriodo"] = new SelectList(TiposMovimientos2, "Id", "Nombre", linea_de_Credito.Periodo);
            return View(linea_de_Credito);
        }

        // POST: Linea_de_Credito/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,NombrePaquete,Interes,Tasa,Periodo,Credito,Year,Capitalizacion")] Linea_de_Credito linea_de_Credito)
        {
            if (id != linea_de_Credito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    linea_de_Credito.Creador = User.Identity.Name;
                    _context.Update(linea_de_Credito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Linea_de_CreditoExists(linea_de_Credito.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            var TiposMovimientos = new List<TiposAños>();
            TiposMovimientos.Add(new TiposAños { Id = 0, Nombre = "Ordinario" });
            TiposMovimientos.Add(new TiposAños { Id = 1, Nombre = "Biciesto" });
            ViewData["TiposAño"] = new SelectList(TiposMovimientos, "Id", "Nombre", linea_de_Credito.Year);

            var TiposMovimientos3 = new List<TiposTasa>();
            TiposMovimientos3.Add(new TiposTasa { Id = 0, Nombre = "Nominal" });
            TiposMovimientos3.Add(new TiposTasa { Id = 1, Nombre = "Simple" });
            TiposMovimientos3.Add(new TiposTasa { Id = 2, Nombre = "Efectiva" });
            ViewData["TiposTasa"] = new SelectList(TiposMovimientos3, "Id", "Nombre", linea_de_Credito.Tasa);
            var TiposMovimientos4 = new List<TiposDeCapitalizacion>();
            TiposMovimientos4.Add(new TiposDeCapitalizacion { Id = 0, Nombre = "Diaria" });
            TiposMovimientos4.Add(new TiposDeCapitalizacion { Id = 1, Nombre = "Quincenal" });
            TiposMovimientos4.Add(new TiposDeCapitalizacion { Id = 2, Nombre = "Mensual" });
            ViewData["Capitalizacion"] = new SelectList(TiposMovimientos4, "Id", "Nombre", linea_de_Credito.Capitalizacion);
            var TiposMovimientos2 = new List<TiposDePeriodo>();
            TiposMovimientos2.Add(new TiposDePeriodo { Id = 0, Nombre = "Mensual" });
            TiposMovimientos2.Add(new TiposDePeriodo { Id = 1, Nombre = "Bimestral" });
            ViewData["TiposPeriodo"] = new SelectList(TiposMovimientos2, "Id", "Nombre", linea_de_Credito.Periodo);
            return View(linea_de_Credito);
        }

        // GET: Linea_de_Credito/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linea_de_Credito = await _context.LineasDeCredito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (linea_de_Credito == null)
            {
                return NotFound();
            }

            return View(linea_de_Credito);
        }

        // POST: Linea_de_Credito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var linea_de_Credito = await _context.LineasDeCredito.FindAsync(id);
            _context.LineasDeCredito.Remove(linea_de_Credito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Linea_de_CreditoExists(Guid id)
        {
            return _context.LineasDeCredito.Any(e => e.Id == id);
        }
    }
}
