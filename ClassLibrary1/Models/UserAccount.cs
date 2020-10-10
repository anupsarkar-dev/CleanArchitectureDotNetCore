using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class UserAccount
    {
        [Key]
        public string Uid { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public bool IsDelete { get; set; }

        public DateTime? CreatedAt { get; set; }

    }
}
