using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebWebApiEF.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EmpoyeController : ControllerBase
    {
        private readonly IEmployeService employeService;

        public EmpoyeController(IEmployeService employeService)
        {
            this.employeService = employeService;
        }

        [HttpGet("GetEmployes")]
        public  List<Employe> GetEmployes()
        {
            return employeService.GetEmployes();
        }
        [HttpGet("GetEmployeById")]
        public  Employe GetEmployeById(int id)
        {
            return employeService.GetEmployeById(id);
        }
        [HttpPost("Insert")]
        public int Insert(Employe employe)
        {
            return employeService.Insert(employe);
        }
        [HttpPut("Update")]
        public int Update(Employe employe)
        {
            return  employeService.Update(employe);
        }
        [HttpDelete("Delete")]
        public int Delete(int id)
        {
            return employeService.Delete(id); 
        }
    }
}
