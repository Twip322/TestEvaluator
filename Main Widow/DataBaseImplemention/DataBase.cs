using DataBaseImplemention.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseImplemention
{
    public class DataBase:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)   
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-K2U0LTG;Initial Catalog=TOUZDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Tests> Tests { get; set; }
        public virtual DbSet<TestQuestions> TestsQuestions { get; set; }
    }
}
