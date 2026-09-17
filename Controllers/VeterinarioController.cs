using ClínicaVeterinária.Data;
using ClínicaVeterinária.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ClínicaVeterinária.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinarioController : ControllerBase
    {
        public readonly AppDbContext _context;

        public VeterinarioController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veterinario>>> GetVeterinario()
        {
            return await _context.Veterinarios.ToListAsync();
        }
        [HttpPost]
        public async Task<IActionResult> AddCurso(Veterinario veterinario)
        {
            _context.Veterinarios.Add(veterinario);
            await _context.SaveChangesAsync();
            return Ok("Veterinario cadsastrado sucesso!");
        }
    }
}

