using System;

namespace SalesWebMvc19.Services.Exceptions {
    public class DbConcurrencyExcption : ApplicationException {
        public DbConcurrencyExcption(string message) : base(message)
        {
        }
    }
}
