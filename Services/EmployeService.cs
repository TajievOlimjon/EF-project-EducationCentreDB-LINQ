using Domain.Entities;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public  class EmployeService:IEmployeService
    {
        private readonly DataContext dataContext;

        public EmployeService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public int Delete(int id)
        {
            var delete = dataContext.Employes.Find(id);
            var d=dataContext.Employes.Remove(delete);
            var save = dataContext.SaveChanges();
            return save;

        }

        public Employe GetEmployeById(int id)
        {
           var employe = dataContext.Employes.Find(id);
            return employe;
        }

        public List<Employe> GetEmployes()
        {
            var list = dataContext.Employes.ToList();
            return list.ToList();
        }

        public int Insert(Employe employe)
        {
            dataContext.Employes.Add(employe);
            var save = dataContext.SaveChanges();
            return save;
        }

        public int Update(Employe employe)
        {
            var delete = dataContext.Employes.Find(employe.Id);
            delete.FirstName = employe.FirstName;
            delete.lastName = employe.lastName;
            delete.Age = employe.Age;
            delete.PhoneNumber = employe.PhoneNumber;
            var save=dataContext.SaveChanges();
            return save;
        }
    }
}
