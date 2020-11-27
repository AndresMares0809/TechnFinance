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
    public class ClientesController : Controller
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Clientes.Include(c => c.Credito);
            return View(await appDbContext.Where(d => d.Creador == User.Identity.Name).ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appDbContext = _context.Movimiento.Where(d=>d.ClienteId==id).Include(m => m.Cliente).ThenInclude(d=>d.Credito).OrderBy(d=>d.Fecha);
            var cliente = await _context.Clientes
                .Include(c => c.Credito)
                .FirstOrDefaultAsync(m => m.Id == id);
            ViewBag.Cliente = cliente;
            if (cliente == null)
            {
                return NotFound();
            }
            return View(await appDbContext.ToListAsync());

        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            ViewData["CreditoId"] = new SelectList(_context.LineasDeCredito, "Id", "NombrePaquete");
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DNI,Direccion,Firstname,Lastname,CreditoId")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.Creador = User.Identity.Name;
                cliente.Id = Guid.NewGuid();
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CreditoId"] = new SelectList(_context.LineasDeCredito, "Id", "NombrePaquete", cliente.CreditoId);
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            ViewData["CreditoId"] = new SelectList(_context.LineasDeCredito, "Id", "NombrePaquete", cliente.CreditoId);
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,DNI,Direccion,Firstname,Lastname,CreditoId")] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var t = await _context.Clientes.Where(d => d.Id == cliente.Id).FirstOrDefaultAsync();
                    t.DNI = cliente.DNI ?? t.DNI;
                    t.Direccion = cliente.Direccion ?? t.Direccion;
                    t.Firstname = cliente.Firstname ?? t.Firstname;
                    t.Lastname = cliente.Lastname ?? t.Lastname;
                    t.CreditoId = cliente.CreditoId;
                    t.Creador = User.Identity.Name;
                    _context.Update(t);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
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
            ViewData["CreditoId"] = new SelectList(_context.LineasDeCredito, "Id", "NombrePaquete", cliente.CreditoId);
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .Include(c => c.Credito)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(Guid id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
