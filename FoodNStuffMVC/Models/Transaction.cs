using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodNStuffMVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }//virtual is so the database is set up correctly behind the scenes

        [ForeignKey(nameof(Product))]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }


    }
}