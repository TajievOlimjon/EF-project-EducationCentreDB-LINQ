using Domain.Entities;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TeacherService:ITeacherService
    {
        private readonly DataContext dataContext;

        public TeacherService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }


        public List<Teacher> GetTeachers()
        {
            var list = dataContext.Teachers.ToList();
            return list.ToList();
        }
        public Teacher GetTeacherById(int Id)
        {
            var ById = dataContext.Teachers.Find(Id);
            return ById;
        }

       

        public string Insert(Teacher teacher)
        {
            dataContext.Teachers.Add(teacher);
            var save=dataContext.SaveChanges();
            if (!save.Equals(null)) return "Saved 1 records in database EducationCentre!!!";
            else return "Not Saved .....";
            
        }

        public string Update(Teacher teacher)
        {
            var newTeacher = dataContext.Teachers.Find(teacher.Id);
                newTeacher.FirstName = teacher.FirstName;
                newTeacher.LastName = teacher.LastName;
                newTeacher.Age = teacher.Age;
                newTeacher.Email = teacher.Email;
                newTeacher.Address = teacher.Address;
                newTeacher.Position = teacher.Position;
                newTeacher.Salary = teacher.Salary;
            var save = dataContext.SaveChanges();
            if (!save.Equals(null)) return "1 records updated in database EducationCentre!!!";
            else return "Not updated.....";
        }
        public string Delete(int Id)
        {
            var teacherId = dataContext.Teachers.Find(Id);
            var delete = dataContext.Teachers.Remove(teacherId);
            var save = dataContext.SaveChanges();
            return "1 records [ Deleted ] in database EducationCentre!!!";
        }
    }
}
