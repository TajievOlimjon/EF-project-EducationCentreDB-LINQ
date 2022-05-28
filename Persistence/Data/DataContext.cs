﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Persistence.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<EducationCentr> EducationCentrs { get; set; }
        public DbSet<ExaminationSystem> ExaminationSystems { get; set; }
        public DbSet<Employe> Employes { get; set; }
    }
}
