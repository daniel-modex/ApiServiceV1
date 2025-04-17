using AppServices.DAL.RegisterationDAL;
using AppServices.Models.Patient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppApiService.Controllers.Registeration
{
    [Route("api/v1")]
    [ApiController]
    public class PatientRegisterController : ControllerBase
    {
        [HttpPost]
        [Route("Register")]
        public ActionResult<object> RegisterPatient(RegisterPatient Data)
        {
            return Ok(PatientRegisteration.NewPatientRegister(Data));
        }
    }
}
