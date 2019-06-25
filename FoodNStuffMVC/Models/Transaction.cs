using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodNStuffMVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        
        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }

        public int ProductID { get; set; }


    }
}