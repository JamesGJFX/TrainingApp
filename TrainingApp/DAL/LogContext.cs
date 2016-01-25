using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrainingApp.Models;

namespace TrainingApp.DAL
{
    public class LogContext : DbContext
    {
        public LogContext() : base("LogContext")
        {

        }
        public DbSet<Log> Logs { get; set; }
    }
}