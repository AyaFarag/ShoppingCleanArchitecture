using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.DTOs
{
    public class RoleDto
    {
        public string? RoleName { get; set; }
        public List<string>? Permissions { get; set; }
    }
}
