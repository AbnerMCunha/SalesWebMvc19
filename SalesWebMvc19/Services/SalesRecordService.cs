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
        public int MyProperty { get; set; }

        public SalesRecordService(SalesWebMvc19Context context)
        {
            _context = context;
        }

        public async Task<SalesRecord> FindById(int? id)
        {
            return await _context.SalesRecord.FindAsync(id);
        }

        public async Task<List<SalesRecord>> FindAll()
        {
            return await _context.SalesRecord.Include(obj => obj.Seller).OrderByDescending(x => x.Date).ToListAsync();
        }


    }
}
