using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();

    }
}
