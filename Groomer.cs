using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Groomer
    {
        [Key]
        public int GroomerID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateofBirth { get; set; }
        public int PhoneNumber { get; set; }

        public double HourlyRate { get; set; }


    }
}