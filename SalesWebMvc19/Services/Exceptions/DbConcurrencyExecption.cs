using System;

namespace SalesWebMvc19.Services.Exceptions {
    public class DbConcurrencyExecption : ApplicationException {
        public DbConcurrencyExecption(string message) : base(message)
        {
        }
    }
}
