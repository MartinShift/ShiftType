﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.JsonModels
{
    public class ResetPasswordMessage
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
