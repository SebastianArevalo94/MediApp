using MediApp_API.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalReservesController : Controller
    {
        private readonly DataBaseContext context;

        public MedicalReservesController(DataBaseContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<MedicalReserve>>> GetAll()
        {
            if (context.MedicalReserves == null)
            {
                return NotFound();
            }
            return await context.MedicalReserves.ToListAsync();
        }

    }
}
