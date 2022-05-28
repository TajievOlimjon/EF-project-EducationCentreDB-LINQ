using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public  interface IEmployeService
    {
        List<Employe> GetEmployes();
        Employe GetEmployeById(int id);
        int Insert(Employe model);
        int Update(Employe employe);
        int Delete(int id);
    }
}
