using MediApp_API.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly DataBaseContext _Context;

        public PatientController (DataBaseContext context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatient()
        {
            if(_Context.Patients == null)
            {
                return NotFound();
            }
            return await _Context.Patients.ToListAsync();
        }
    }
}
