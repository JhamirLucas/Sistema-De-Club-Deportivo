using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemadeClubDeportivo.Contexto;
using SistemadeClubDeportivo.Models;

namespace SistemadeClubDeportivo.Controllers
{
    public class PagosController : Controller
    {
        private readonly MyContexto _context;

        public PagosController(MyContexto context)
        {
            _context = context;
        }

        // GET: Pagos
        public async Task<IActionResult> Index()
        {
            var myContexto = _context.Pagos.Include(p => p.Cliente).Include(p => p.Usuario);
            return View(await myContexto.ToListAsync());
        }

        // GET: Pagos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pago = await _context.Pagos
                .Include(p => p.Cliente)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pago == null)
            {
                return NotFound();
            }

            return View(pago);
        }

        // GET: Pagos/Create
        public IActionResult Create()
        {
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ID", "Nombre");
            ViewData["UsuarioID"] = new SelectList(_context.Usuarios, "ID", "Email");
            return View();
        }

        // POST: Pagos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,NroRecibo,Dia,Mes,Anio,Total,UsuarioID,ClienteID")] Pago pago)
        {
            if (ModelState.IsValid)
            {
                pago.NroRecibo = GetNumero();
                _context.Add(pago);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteID"] = new SelectList(_context.Clientes, "ID", "Nombre", pago.ClienteID);
            ViewData["UsuarioID"] = new SelectList(_context.Usuarios, "ID", "Email", pago.UsuarioID);
            return View(pago);
        }
         private int GetNumero()
        {
            if (_context.Pagos.ToList().Count > 0)
                return _context.Pagos.Max(i => i.NroRecibo) + 1;
            return 1;
        }
       
    }
}
