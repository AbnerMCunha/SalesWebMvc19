using System;

namespace SalesWebMvc19.Models {
    public class ErrorViewModel {
        public int Id { get; set; }
        public string RequestId { get; set; }
        public string Message { get; set; }

        //Opção de mostrar ou nao o Id do Registro
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}