using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc19.Models {
    public class Department {
        [Key]                           //Definindo a chave para criacao do BD pelo provider MySql do EntityFramework
        [Column("IdDepartment")]        //Definindo o nome da coluna da tabela Department no banco de dados
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void addSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final) 
        {
            return Sellers.Sum(x => x.TotalSales(initial, final));
        }

    }
}
