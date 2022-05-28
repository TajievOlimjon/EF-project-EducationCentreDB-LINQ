using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ITeacherService
    {
        List<Teacher> GetTeachers();
        Teacher GetTeacherById(int Id);
        string Insert(Teacher teacher);
        string Update(Teacher teacher); 
        string Delete(int Id);


    }
}
