using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Finanzas.Models;
using System.Collections;

namespace Finanzas.Controllers
{
    public class MovimientoesController : Controller
    {
        private readonly AppDbContext _context;

        public MovimientoesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Movimientoes
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Movimiento.Include(m => m.Cliente);
            return View(await appDbContext.Where(d => d.Creador == User.Identity.Name).ToListAsync());
        }

        // GET: Movimientoes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimiento = await _context.Movimiento
                .Include(m => m.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movimiento == null)
            {
                return NotFound();
            }

            return View(movimiento);
        }

        // GET: Movimientoes/Create
        public IActionResult Create()
        {
            var TiposMovimientos = new List<Tipo_de_Movmiento>();
            TiposMovimientos.Add(new Tipo_de_Movmiento { Id = 0, Nombre = "Pago" });
            TiposMovimientos.Add(new Tipo_de_Movmiento { Id = 1, Nombre = "Compra" });
            ViewData["Movimientos"] = new SelectList(TiposMovimientos, "Id", "Nombre");
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "DNI");
            return View();
        }

        // POST: Movimientoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Monto,Fecha,ClienteId")] Movimiento movimiento)
        {
            if (ModelState.IsValid&&movimiento.Fecha<DateTime.Now)
            {
                var t = await _context.Clientes.Where(d => d.Id == movimiento.ClienteId).Include(d => d.Credito).Include(d => d.Movimientos).FirstOrDefaultAsync();
                movimiento.Creador = User.Identity.Name;
                if(movimiento.Type==1){
                    if (t.Movimientos != null && t.Movimientos.Count>0)
                    {
                        if (t.Movimientos.Where(d=>d.Type==1).Sum(d => d.Monto)- t.Movimientos.Where(d => d.Type == 0).Sum(d => d.Monto) + movimiento.Monto <= t.Credito.Credito)
                        {
                            movimiento.Id = Guid.NewGuid();
                            _context.Add(movimiento);
                            await _context.SaveChangesAsync();
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            var TiposMovimientos2 = new List<Tipo_de_Movmiento>();
                            TiposMovimientos2.Add(new Tipo_de_Movmiento { Id = 0, Nombre = "Pago" });
                            TiposMovimientos2.Add(new Tipo_de_Movmiento { Id = 1, Nombre = "Compra" });
                            ViewData["Movimientos"] = new SelectList(TiposMovimientos2, "Id", "Nombre", movimiento.Type);
                            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "DNI", movimiento.ClienteId);
                            ViewBag.Error = "Añadiendo este monto se excede la linea de credito";
                            return View(movimiento);
                        }
                    }
                    if (movimiento.Monto <= t.Credito.Credito)
                    {
                        movimiento.Id = Guid.NewGuid();
                        _context.Add(movimiento);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        var TiposMovimientos2 = new List<Tipo_de_Movmiento>();
                        TiposMovimientos2.Add(new Tipo_de_Movmiento { Id = 0, Nombre = "Pago" });
                        TiposMovimientos2.Add(new Tipo_de_Movmiento { Id = 1, Nombre = "Compra" });
                        ViewData["Movimientos"] = new SelectList(TiposMovimientos2, "Id", "Nombre", movimiento.Type);
                        ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "DNI", movimiento.ClienteId);
                        ViewBag.Error = "Añadiendo este monto se excede la linea de credito";
                        return View(movimiento);
                    }
                }
                if (movimiento.Type == 0)
                {
                    if (t.Movimientos != null && t.Movimientos.Count > 0)
                    {
                        if (t.Movimientos.Where(d => d.Type == 1).Sum(d => d.Monto) - t.Movimientos.Where(d => d.Type == 0).Sum(d => d.Monto) - movimiento.Monto >= 0)
                        {
                            movimiento.Id = Guid.NewGuid();
                            _context.Add(movimiento);
                            await _context.SaveChangesAsync();
                            return RedirectToAction(nameof(Index));
                        }
                    }
                    var TiposMovimientos2 = new List<Tipo_de_Movmiento>();
                    TiposMovimientos2.Add(new Tipo_de_Movmiento { Id = 0, Nombre = "Pago" });
                    TiposMovimientos2.Add(new Tipo_de_Movmiento { Id = 1, Nombre = "Compra" });
                    ViewData["Movimientos"] = new SelectList(TiposMovimientos2, "Id", "Nombre", movimiento.Type);
                    ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "DNI", movimiento.ClienteId);
                    ViewBag.Error = "Añadiendo este monto del pago es mayor a la cantidad que se debe";
                    return View(movimiento);

                }
                
            }
            var TiposMovimientos = new List<Tipo_de_Movmiento>();
            TiposMovimientos.Add(new Tipo_de_Movmiento { Id = 0, Nombre = "Pago" });
            TiposMovimientos.Add(new Tipo_de_Movmiento { Id = 1, Nombre = "Compra" });
            ViewData["Movimientos"] = new SelectList(TiposMovimientos, "Id", "Nombre", movimiento.Type);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "DNI", movimiento.ClienteId);
            return View(movimiento);
        }

        // GET: Movimientoes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimiento = await _context.Movimiento.FindAsync(id);
            if (movimiento == null)
            {
                return NotFound();
            }
            var TiposMovimientos = new List<Tipo_de_Movmiento>();
            TiposMovimientos.Add(new Tipo_de_Movmiento { Id = 0, Nombre = "Pago" });
            TiposMovimientos.Add(new Tipo_de_Movmiento { Id = 1, Nombre = "Compra" });
            ViewData["Movimientos"] = new SelectList(TiposMovimientos, "Id", "Nombre", movimiento.Type);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "DNI", movimiento.ClienteId);
            return View(movimiento);
        }
        private class Tipo_de_Movmiento
        {
            public short Id { set; get; }
            public string Nombre { set; get; }
        }
      

        // POST: Movimientoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Type,Monto,Fecha,ClienteId")] Movimiento movimiento)
        {
            if (id != movimiento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid && movimiento.Fecha < DateTime.Now)
            {
                try
                {
                    movimiento.Creador = User.Identity.Name;
                    _context.Update(movimiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovimientoExists(movimiento.Id))
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
            var TiposMovimientos = new List<Tipo_de_Movmiento>();
            TiposMovimientos.Add(new Tipo_de_Movmiento { Id = 0, Nombre = "Pago" });
            TiposMovimientos.Add(new Tipo_de_Movmiento { Id = 1, Nombre = "Compra" });
            ViewData["Movimientos"] = new SelectList(TiposMovimientos, "Id", "Nombre", movimiento.Type);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "DNI", movimiento.ClienteId);
            return View(movimiento);
        }

        // GET: Movimientoes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimiento = await _context.Movimiento
                .Include(m => m.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movimiento == null)
            {
                return NotFound();
            }

            return View(movimiento);
        }

        // POST: Movimientoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var movimiento = await _context.Movimiento.FindAsync(id);
            _context.Movimiento.Remove(movimiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovimientoExists(Guid id)
        {
            return _context.Movimiento.Any(e => e.Id == id);
        }
    }
}
