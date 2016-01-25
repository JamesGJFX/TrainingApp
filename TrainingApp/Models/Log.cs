using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainingApp.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Review { get; set; }
        public string Workout { get; set; }
        public DateTime Date { get; set; }
    }
}