﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Entities
{
    public class RoleUser
    {
        public int Id { get; set; }

        public int RoleId { get; set; }
        public Role? Role { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
