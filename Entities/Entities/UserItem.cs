using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserItem
    {
        public UserItem(string email)
        {
            IsActive = true;
            Email = email;
            
        }
        public int Id { get; set; }
        public string Email { get; set; }
        private string EncryptedPassword { get; set; }

        public bool IsActive { get; set; }


    }
}
