using MediApp_API.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly Doctor _Context;

        public DoctorController (Doctor context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctor()
        {
            if(_Context.doctors == null)
            {
                return NotFound();
            }
            return await _Context.doctors.ToListAsync();
        }


    }
}
