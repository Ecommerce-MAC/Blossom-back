using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserItem
    {
        public UserItem()
        {
            IsActive = true;
           
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public int IdRol { get; set; }
        public string Email { get; set; }
        private string EncryptedPassword { get; set; }

        public bool IsActive { get; set; }


    }
}
