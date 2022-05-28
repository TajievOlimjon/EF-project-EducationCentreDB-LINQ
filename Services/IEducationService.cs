using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public  interface IEducationService
    {
        List<EducationCentr> GetEducationCentrs();
        EducationCentr GetEducationCentrById(int Id);
        int Insert(EducationCentr education);
        int Update(EducationCentr education);
        int Delete(int Id);
    }
}
