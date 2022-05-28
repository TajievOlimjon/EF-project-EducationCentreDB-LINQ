using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IExaminationSystemService
    {
        List<ExaminationSystem> GetExaminationSystems();
        ExaminationSystem GetExaminationSystemById(int id);
        int Insert(ExaminationSystemDTO examinationdto);
        int Update(ExaminationSystem examination);
        int Delete(int Id);
        int Avarage();
        //int AvarageA(Examination examination);
       // List<Examination> Avarage(int Id);
    }
}
