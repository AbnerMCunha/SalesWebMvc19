using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;    //para importar biblioteca de metodos assincronos
using System.Threading.Tasks;           //Para impotar o tipo Task que encapsula metodos assincornosusing SalesWebMvc19.Data;
using SalesWebMvc19.Models;
using SalesWebMvc19.Services.Exceptions;

namespace SalesWebMvc19.Services {
    public class SellerService {
        private readonly SalesWebMvc19Context _context;

        public SellerService(SalesWebMvc19Context context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()  //Fazendo operação assincronamente
        {
            //Include realiza o Join dos Models Seller e Department
            return await _context.Seller.Include(x => x.Department).ToListAsync();
        }

        public async Task InsertAsync(Seller seller)
        {
            //1. Gambiarra para não dar erro de chave primaria
            //seller.Department = _context.Department.FirstOrDefault();
            //2. Não mais necessária já que o SellerFormViewModel carrega os dados de departamentos ao funcionadio

            _context.AddAsync(seller);          //Essa operação linq não necessida ter o await pois nao executa a pesquisa, apenas deixa pronta
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            //FirstOrDefault: Caso não encontre, devolve um valor padrao
            //Eager loading: fazendo o join de tabelas relacionadas, no caso, departamento. já feito no metodo FindALl()
            return await _context.Seller.Include(x => x.Department).
                FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task RemoveSellerAsync(int sellerId)
        {
            try { 
                var seller = await _context.Seller.FindAsync(sellerId);
                 _context.Seller.Remove(seller);        //Essa operação linq não necessida ter o await pois nao executa a pesquisa, apenas deixa pronta
                await _context.SaveChangesAsync();
            }catch(DbUpdateException e) //Capturando exceção de integridade referencial do sistema 
            {
                throw new IntegrityException(e.Message);    //e inserindo a nossa exceção, personalizada. Remetendo ao de volta controller.
            }
        }

        public async Task UpdateSellerAsync(Seller obj)
        {
            bool HasCorrectId = _context.Seller.Any(x => x.Id == obj.Id);
            if (!HasCorrectId)
            {
                throw new NotFoundException("Seller Id not Found");
            }

            //Segregando exceções de camadas de excção de camada de servico e camada de acesso a dados.
            try
            {
                _context.Seller.Update(obj);            //Essa operação linq não necessida ter o await pois nao executa a pesquisa, apenas deixa pronta
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                //Interceptando exceção de nivel de acesso a dados e relançando para o controller, a exceção personalizada da camada de serviço.
                throw new DbConcurrencyExecption(e.Message);
            }
        }

    }
}
