using Domain.Entities;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StudentService
    {
        private readonly  DataContext dataContext;

        public StudentService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<StudentDTO> GetStudentsInJoinExam()
        {
            var list=(
                from s in dataContext.Students
                join e in dataContext.ExaminationSystems on s.Id equals e.StudentId
                select new StudentDTO()
                {   StudentId=s.Id,
                    FullName = string.Concat(s.FirstName," " ,s.LastName),
                    WhatIsCourse=s.WhatIsCourse,
                    WhatIsGroup=s.WhatIsGroup,
                    Faculty=s.Faculty,
                    Directions=s.Directions,
                    FirstExam=e.FirstExam,
                    SecondExam=e.SecondExam,
                    ThirdExam=e.ThirdExam,
                    FourthExam=e.FourthExam,
                    FifthExam=e.FifthExam,
                    SicthExam=e.SicthExam,


                }).ToList();    
               
                
                return list;
        }

        public List<StudentNewModel> GetInStudent()
        {
            var list=( 
                from s in dataContext.Students
                select new StudentNewModel()
                {
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Age=s.Age,
                    Email = s.Email,
                    Address=s.Address,
                    BirthDay=s.BirthDay,
                    WhatIsCourse = s.WhatIsCourse,
                    WhatIsGroup = s.WhatIsGroup,
                    Faculty = s.Faculty,
                    Directions = s.Directions,

                }).ToList();
            return list;

           
        }

        public List<Student> GetStudents()
        {
            var list = dataContext.Students.ToList();
            return list;
        }
        public Student GetStudentById(int Id)
        {
            var find= dataContext.Students.Find(Id);
            return find;
        }

        public string Insert(StudentNewModel model)
        {
            Student student = new Student()
            {

                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                Email = model.Email,
                Address = model.Address,
                BirthDay = model.BirthDay,
                WhatIsCourse = model.WhatIsCourse,
                WhatIsGroup = model.WhatIsGroup,
                Faculty = model.Faculty,
                Directions = model.Directions

            };

            dataContext.Students.Add(student);
            var save = dataContext.SaveChanges();
            if (save!=0)return "Saved in database EducationCentre!!!";
            else return "Not Saved ????";
        }

        public string Update(StudentNewModel student)
        {
            var newStudent = dataContext.Students.Find(student.Id);
                newStudent.FirstName = student.FirstName;
                newStudent.LastName = student.LastName;
                newStudent.Age = student.Age;
                newStudent.Email = student.Email;
                newStudent.Address = student.Address;
                newStudent.BirthDay = student.BirthDay;
                newStudent.WhatIsCourse = student.WhatIsCourse;
                newStudent.WhatIsGroup = student.WhatIsGroup;
                newStudent.Faculty = student.Faculty;
                newStudent.Directions = student.Directions;
            var save = dataContext.SaveChanges();
            if (save != 0) return "Update in database EducationCentre!!!";
            else return "Not Update ????";
        }
        public string Delete(int Id)
        {
            var student = dataContext.Students.Find(Id);
            dataContext.Students.Remove(student);
            dataContext.SaveChanges();
            return "Deleted in database EducationCentre !!!";
            
        }

        
    }
}
