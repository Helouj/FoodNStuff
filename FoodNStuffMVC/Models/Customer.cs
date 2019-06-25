using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodNStuffMVC.Models
{
    public class Customer
    {
        [Key]

        public int CustomerID { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string FullName
        {

            get
            {
                //public string FullName => $"{FirstName} {LastName}";
                return $"{FirstName} {LastName}";
                

            }

        }


    }
}