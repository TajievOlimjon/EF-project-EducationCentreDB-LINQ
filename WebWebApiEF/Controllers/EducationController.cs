using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebWebApiEF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EducationController : ControllerBase
    {
        private readonly IEducationService educationService;

        public EducationController(IEducationService educationService)
        {
            this.educationService = educationService;
        }
        [HttpGet("GetEducationCentrs")]
        public   List<EducationCentr> GetEducationCentrs()
        {
            return educationService.GetEducationCentrs();
        }

        [HttpGet("GetEducationCentrById")]
        public EducationCentr GetEducationCentrById(int Id)
        {
            return educationService.GetEducationCentrById(Id);
        }

        [HttpPost("Insert")]
        public int Insert(EducationCentr education)
        {
            return educationService.Insert(education);
        }

        [HttpPut("Update")]
        public int Update(EducationCentr education)
        {
            return educationService.Update(education);
        }

        [HttpDelete("Delete")]
        public int Delete(int Id)
        {
            return educationService.Delete(Id);
        }
    }
}
