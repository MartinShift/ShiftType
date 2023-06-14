using ModelLibrary.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DbModels
{
    public class TestResult
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public string Text { get; set; }
        public int TimeSpent { get; set; }
        public double Wpm { get; set; }
        public int Errors { get; set; }
        public int Accuracy { get; set; }
        public DateTime Date { get; set; }
    }
}
