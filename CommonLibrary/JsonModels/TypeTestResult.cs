using ModelLibrary.JsonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeClient.Models;

namespace CommonLibrary.JsonModels
{
    public class TypeTestResult
    {
        public JsonClient Client { get; set; }
        public string Text { get; set; }
        public int TimeSpent { get; set; }
        public int Wpm { get; set; }
        public int Errors { get; set; }
        public int Accuracy { get; set; }
        public DateTime Date { get; set; }
        public int Raw { get => Wpm + Errors; }
    }
}

