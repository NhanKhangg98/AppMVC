using AppMVC.Net.Models.Orders;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMVC.Net.Models
{
    public class AppUser : IdentityUser
    {
        [Column(TypeName = "nvarchar(400)")]
        public string HomeAdress { get; set; }

        // [Required]       
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        public List<Order> Orders { get; set; }
    }
}
