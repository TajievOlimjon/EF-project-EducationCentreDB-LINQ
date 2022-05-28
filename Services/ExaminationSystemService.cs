using Domain.Entities;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ExaminationSystemService:IExaminationSystemService
    {
        private readonly DataContext dataContext;

        public ExaminationSystemService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

       

      

        public List<ExaminationSystem> GetExaminationSystems()
        {
            var list = dataContext.ExaminationSystems.ToList();
            return list.ToList();
        }

        public ExaminationSystem GetExaminationSystemById(int id)
        {
            var res = dataContext.ExaminationSystems.Find(id);
            return res;
        }

        public int Insert(ExaminationSystemDTO examinationdto)
        {
            ExaminationSystem examination = new ExaminationSystem()
            {
                FirstExam = examinationdto.FirstExam,
                SecondExam = examinationdto.SecondExam,
                ThirdExam = examinationdto.ThirdExam,
                FourthExam = examinationdto.FourthExam,
                FifthExam = examinationdto.FifthExam,
                SicthExam = examinationdto.SicthExam,
                StudentId = examinationdto.StudentId,

            };
            dataContext.ExaminationSystems.Add(examination);
            var save = dataContext.SaveChanges();
            return save;
        }

        public int Update(ExaminationSystem examination)
        {
            var newExam = dataContext.ExaminationSystems.Find(examination.Id);
                newExam.FifthExam = examination.FifthExam;
                newExam.SecondExam = examination.SecondExam;
                newExam.ThirdExam = examination.ThirdExam;
                newExam.FourthExam= examination.FourthExam;
                newExam.FifthExam = examination.FifthExam;
                newExam.SicthExam = examination.SicthExam;
            var save = dataContext.SaveChanges();
            return save;
        }
        public int Delete(int Id)
        {
            var delete = dataContext.ExaminationSystems.Find(Id);
            var d = dataContext.ExaminationSystems.Remove(delete);
            var save = dataContext.SaveChanges();
            return save;
        }

        public int Avarage()
        {
            var list = dataContext.ExaminationSystems.ToList();
             
            var avg = 0;
            int l = 0;

            foreach (var item in list.ToList())
            {
                avg = (item.FifthExam + item.SecondExam + item.ThirdExam + item.FourthExam + item.FifthExam + item.SicthExam);
                
                l = avg /= 6;
            }
            return l;

        }

        //public int AvarageA(Examination examination,int Id)
        //{
        //    var f = dataContext.ExaminationSystems.Find(examination.Id);
        //    List<Examination> list;
        //    if (!f.Equals(null))
            
        //     list=  dataContext.ExaminationSystems.ToList();
            
            
        //}

        
    }
}
