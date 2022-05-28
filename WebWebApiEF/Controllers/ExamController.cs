using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebWebApiEF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExamController : ControllerBase
    {
        private readonly IExaminationSystemService examinationSystem;

        public ExamController(IExaminationSystemService examinationSystem)
        {
            this.examinationSystem = examinationSystem;
        }
        [HttpGet("GetExaminationSystems")]
        public List<ExaminationSystem> GetExaminationSystems()
        {
            return examinationSystem.GetExaminationSystems();
        }

        [HttpPost("Insert")]
        public int Insert(ExaminationSystemDTO examinationdto)
        {
            return examinationSystem.Insert(examinationdto);
        }

        [HttpPut("Update" +
            "")]
        public int Update(ExaminationSystem examination)
        {
            return examinationSystem.Update(examination);
        }

        [HttpDelete("Delete")]
        public int Delete(int Id)
        {
            return examinationSystem.Delete(Id);
        }

        [HttpGet("Avarage")]
        public int Avarage()
        {
            return examinationSystem.Avarage();
        }
    }
}
