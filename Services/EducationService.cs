using Domain.Entities;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EducationService:IEducationService
    {
        private readonly DataContext dataContext;

        public EducationService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public int Delete(int Id)
        {
            var delete = dataContext.EducationCentrs.Find(Id);
            var d=dataContext.EducationCentrs.Remove(delete);
            var save = dataContext.SaveChanges();
            return save;
        }

        public EducationCentr GetEducationCentrById(int Id)
        {
            var d = dataContext.EducationCentrs.Find(Id);
            return d;
        }

        public List<EducationCentr> GetEducationCentrs()
        {
            var list = dataContext.EducationCentrs.ToList();
            return list.ToList();
        }

        public int Insert(EducationCentr education)
        {
            dataContext.EducationCentrs.Add(education);
            var save = dataContext.SaveChanges();
            return save;
        }

        public int Update(EducationCentr education)
        {
            var neweducation = dataContext.EducationCentrs.Find(education.Id);
            neweducation.Name = education.Name;
            var save = dataContext.SaveChanges();
            return save;
        }
    }
}
