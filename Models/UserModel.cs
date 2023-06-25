using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecomerce.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
    
        public string Email { get; set; }
        
        public string Password { get; set; }
        public string Category { get; set; }
        public bool IsAdmin { get; set; }
        public List<UserCustomer>? Customer { get; set; }
        public List<UserSeller>? Seller { get; set; }
    }
}
