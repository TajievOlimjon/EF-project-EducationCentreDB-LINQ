using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebWebApiEF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentService studentService;

        public StudentController(StudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet("GetStudentsInJoinExam")]
        public List<StudentDTO> GetStudentsInJoinExam()
        {
            return studentService.GetStudentsInJoinExam();
        }

        [HttpGet("GetInStudent")]
        public List<StudentNewModel> GetInStudent()
        {
            return  studentService.GetInStudent();
        }

        [HttpGet("GetStudents")]
        public List<Student> GetStudents()
        {
            return this.studentService.GetStudents();
        }
        [HttpGet("GetStudentById")]
        public Student GetStudentById(int Id)
        {
            return this.studentService.GetStudentById(Id);
        }

        [HttpPost("Insert")]
        public string Insert(StudentNewModel model)
        {
            return studentService.Insert(model);
        }

        [HttpPut("Update")]
        public string Update(StudentNewModel student)
        {
            return studentService.Update(student);
        }

        [HttpDelete("Delete")]
        public string Delete(int Id)
        {
            return studentService.Delete(Id);
        }
    }
}
