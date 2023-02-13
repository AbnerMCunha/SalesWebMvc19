using Microsoft.EntityFrameworkCore;
using SalesWebMvc19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc19.Services {
    public class DepartmentService {
        private readonly SalesWebMvc19Context _context;

        public DepartmentService(SalesWebMvc19Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
