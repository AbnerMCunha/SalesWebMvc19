﻿using System;


namespace SalesWebMvc19.Services.Exceptions {
    public class NotFoundException : ApplicationException {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
