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
    public class TutorController : ControllerBase
    {
        public readonly AppDbContext _context;

        public TutorController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tutor>>> GetTutor()
        {
            return await _context.Tutores.ToListAsync();
        }
        [HttpPost]
        public async Task<IActionResult> AddCurso(Tutor tutor)
        {
            _context.Tutores.Add(tutor);
            await _context.SaveChangesAsync();
            return Ok("Tutor cadastrado sucesso");
        }
    }
}

