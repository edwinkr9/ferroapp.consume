﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FerroApp.Consume.Models
{
    public class Login
    {
        public string Correo { get; set; }

        public string Password { get; set; }

        public bool status { get; set; } = true;
    }
}
