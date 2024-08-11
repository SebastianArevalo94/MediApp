using MediApp_API.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicController : ControllerBase
    {
        private readonly DataBaseContext _Context;

        public ClinicController (DataBaseContext context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<Clinic>>> GetClinic()
        {
            if (_Context.Clinics == null)
            {
                return NotFound();
            }
            return await _Context.Clinics.ToListAsync();
        }
    }
}
