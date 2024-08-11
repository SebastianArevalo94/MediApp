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
        private readonly DataBaseContext _Context;

        public DoctorController (DataBaseContext context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctor()
        {
            if (_Context.Doctors == null)
            {
                return NotFound();
            }
            return await _Context.Doctors.ToListAsync();
        }

    }
}
