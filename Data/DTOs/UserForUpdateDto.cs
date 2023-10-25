using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTOs
{
    public  class UserForUpdateDto
    {
        public string Name { get; set; }

        public string Dni { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }

        //public string? Role { get; set; }
    }
}
