using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public required string Email { get; set; }
        public List<RoleUser> RoleUsers { get; set; } = new List<RoleUser>();


    }
}
