using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebWebApiEF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            this.teacherService = teacherService;
        }

        [HttpGet("GetTeachers")]
        public List<Teacher> GetTeachers()
        {
            return teacherService.GetTeachers();
        }

        [HttpGet("GetTeacherById")]
        public Teacher GetTeacherById(int Id)
        {
            return teacherService.GetTeacherById(Id);
        }

        [HttpPost("Insert")]
        public string Insert(Teacher teacher)
        {
            return teacherService.Insert(teacher);
        }

        [HttpPut("Update")]
        public string Update(Teacher teacher)
        {
            return teacherService.Update(teacher);
        }

        [HttpDelete("Delete")]
        public  string Delete(int Id)
        {
            return teacherService.Delete(Id);
        }
    }
}
