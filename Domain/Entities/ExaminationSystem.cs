using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ExaminationSystem
    {
        public int Id { get; set; }
        public int FirstExam { get; set; }
        public int SecondExam { get; set; }
        public int ThirdExam { get; set; }
        public int FourthExam { get; set; }
        public int FifthExam { get; set; }
        public int SicthExam { get; set; }
        public int StudentId { get; set; }
        public Student  Student { get; set; }
       

    }
    public class ExaminationSystemDTO
    {
        public int Id { get; set; }
        public int FirstExam { get; set; }
        public int SecondExam { get; set; }
        public int ThirdExam { get; set; }
        public int FourthExam { get; set; }
        public int FifthExam { get; set; }
        public int SicthExam { get; set; }
        public int StudentId { get; set; }
        


    }

}
