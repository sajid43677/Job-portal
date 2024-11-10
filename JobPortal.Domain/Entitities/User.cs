using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Domain.Entitities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; } 
        public DateTime DateCreated { get; set; }

        public JobSeeker JobSeeker { get; set; }
        public Recruiter Recruiter { get; set; }
    }

    public enum UserType
    {
        JobSeeker = 10,
        Recruiter = 20
    }
}

