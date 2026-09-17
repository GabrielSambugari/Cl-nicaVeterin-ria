using ClínicaVeterinária.Data;
using ClínicaVeterinária.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace ClínicaVeterinária.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ConsultaController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable> GetConsultas()
        {
            return await _context.Consultas.ToListAsync();
        }
        [HttpPost]
        public async Task<IActionResult> AddConsulta(Consulta consulta)
        {
            _context.Consultas.Add(consulta);
            await _context.SaveChangesAsync();
            return Ok("Consulta adicionada com sucesso!");
        }



    }
}
