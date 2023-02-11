using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SalesWebMvc19.Models.Enums;

namespace SalesWebMvc19.Models {
    public class SalesRecord {
        [Key]
        [Column("IdSale")]
        public int Id { get; set; }

        [Column("DateSale")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        public Seller Seller { get; set; }

        public SaleStatus SalesStatus { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2")]
        public double Amount { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus salesStatus, Seller seller )
        {
            Id = id;
            Seller = seller;
            Date = date;
            SalesStatus = salesStatus;
            Amount = amount;
        }
    }
}
