using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc19.Data;
using SalesWebMvc19.Models;


namespace SalesWebMvc19.Services {
    public class SalesRecordService {

        private readonly SalesWebMvc19Context _context;

        public SalesRecordService(SalesWebMvc19Context context)
        {
            _context = context;
        }

        public async Task<SalesRecord> FindById(int? id)
        {
            return await _context.SalesRecord.FindAsync(id);
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            //Operacao linq para atribuir lista de registros de SalesRecord
            var result = from obj in _context.SalesRecord select obj;

            //havendo parametros, habilitar condições
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate);
            }
            //Retornando consulta assincronamente com join em Seller e Departamento, e ordenando descrescemente por data.
            return await result.Include(x => x.Seller).
                Include(x=> x.Seller.Department).
                OrderByDescending(x => x.Date).
                ToListAsync();
        }




    }
}
