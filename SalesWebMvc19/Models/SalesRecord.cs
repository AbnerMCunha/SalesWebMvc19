using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SalesWebMvc19.Models.Enums;

namespace SalesWebMvc19.Models {
    public class SalesRecord {
        [Key]                       //Definindo a chave para criacao do BD pelo provider MySql do EntityFramework
        [Column("IdSale")]          //Definindo nome da Coluna na tabela correspondente
        public int Id { get; set; }

        [Column("DateSale")]        //Definindo nome da Coluna na tabela correspondente
        [DataType(DataType.Date)]   //Definindo tipo de dado do campo
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]    //Definindo formatação do campo
        public DateTime Date { get; set; }

        public Seller Seller { get; set; }

        public SaleStatus SalesStatus { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2")] //Definindo formatação de Dinheiro com 2 decimais
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
