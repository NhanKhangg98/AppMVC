﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMVC.Net.Models.Contacts
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Phải nhập {0}")]
        [Display(Name = "Họ tên")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Phải là địa chỉ Email")]
        [Display(Name = "Địa chỉ email")]
        public string Email { get; set; }

        public DateTime DateSent{ get; set; }

        [Display(Name = "Nội dung")]
        public string Message { get; set; }

        [StringLength(50)]
        [Phone(ErrorMessage = "Phải là số điện thoại")]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
    }
}
