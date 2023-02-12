using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc19.Data;
using SalesWebMvc19.Models;

namespace SalesWebMvc19.Services {
    public class SellerService {
        private readonly SalesWebMvc19Context _context;

        public SellerService(SalesWebMvc19Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            //Include realiza o Join dos Models Seller e Department
            return _context.Seller.Include(x => x.Department).ToList();
        }

        public void Insert(Seller seller)
        {
            //1. Gambiarra para não dar erro de chave primaria
            //seller.Department = _context.Department.FirstOrDefault();
            //2. Não mais necessária já que o SellerFormViewModel carrega os dados de departamentos ao funcionadio

            _context.Add(seller);
            _context.SaveChanges();
        }

    }
}
