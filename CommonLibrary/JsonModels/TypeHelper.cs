using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.JsonModels
{
    public static class TypeHelper
    {
        public static int CountErrors(string input,string check)
        {
            var errors = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (check[i] != input[i])
                {
                    errors++;
                }
            }
            return errors;
        }
        public static int CountWPM(string input,string check, int SecondsSpent) 
        {
            return (int)(((double)input.Length - CountErrors(input, check))/5 / ((double)SecondsSpent/60));
        }
    }
}
