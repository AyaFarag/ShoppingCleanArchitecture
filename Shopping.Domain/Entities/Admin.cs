﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Entities
{
    public class Admin
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}