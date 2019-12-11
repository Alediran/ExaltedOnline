using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(1024)]
        public byte[] PasswordHash { get; set; }
        [Required]
        [MaxLength(1024)]
        public byte[] PasswordSalt { get; set; }
        public int UserRole { get; set; }
        [StringLength(50)]
        public string SignatureFirst { get; set; }
    }
}
