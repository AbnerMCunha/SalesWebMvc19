using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc19.Models {
    public class Seller {
        [Key]                                                   //Definindo a chave na tabela a ser criada com base na classe
        [Column("IdSeller")]                                    //Definindo o nome da coluna no Banco de dados
        public int Id { get; set; }

        [Column("Name")]
        [Required(ErrorMessage = "{0} required")]               //Validação: Definindo como not null
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]  //Definiçoes de Limitações para o campo, {0} pega o nome do atributo, {1} o tamanho maximo no primeiro argumento , {2} o tamanho minimo no segundo argumento
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Enter a valid email")]    //Validação de email
        [DataType(DataType.EmailAddress)]                       //Definindo o Tipo do dado com email, gerando um link do endereço
        public string Email { get; set; }

        [Display(Name = "Date Birth")]                          //Nome a ser exibido no label do Campo
        [DataType(DataType.Date)]                               //Define o Tipo de do campo
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]    //Defini a formatação a ser exibido o campo
        public DateTime DateBirth { get; set; }

        [Display(Name = "Base Salary")]
        [DataType(DataType.Currency)]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be between {1} and {2}!")]
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime dateBirth, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            DateBirth = dateBirth;
            BaseSalary = baseSalary;
            Department = department;
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.Amount);
        }

        public void addSales(SalesRecord sale)
        {
            Sales.Add(sale);
        }
        public void Removesales(SalesRecord sale)
        {
            Sales.Remove(sale);
        }

    }
}
