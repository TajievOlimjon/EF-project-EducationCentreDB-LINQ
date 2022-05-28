using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string? LastName { get; set; }
        public int Age { get; set; }

        public string? Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Address { get; set; }
        public DateTime BirthDay { get; set; }
        public int WhatIsCourse { get; set; }
        public string? WhatIsGroup { get; set; }
        [Required]
        [MaxLength(60)]
        public string? Faculty { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Directions { get; set; }
        public List<ExaminationSystem> ExaminationSystems { get; set; }

    }
    public class StudentNewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string? LastName { get; set; }
        public int Age { get; set; }

        public string? Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Address { get; set; }
        public DateTime BirthDay { get; set; }
        public int WhatIsCourse { get; set; }
        public string? WhatIsGroup { get; set; }
        [Required]
        [MaxLength(60)]
        public string? Faculty { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Directions { get; set; }


    }
    public class StudentDTO
    {
        public int StudentId { get; set; }
        public string? FullName { get; set; }       
        public int WhatIsCourse { get; set; }
        public string? WhatIsGroup { get; set; }
        public string? Faculty { get; set; }
        public string? Directions { get; set; }
        public int FirstExam { get; set; }
        public int SecondExam { get; set; }
        public int  ThirdExam { get; set; }
        public int FourthExam { get; set; }
        public int  FifthExam { get; set; }
        public int SicthExam { get; set; }

       

    }
}
