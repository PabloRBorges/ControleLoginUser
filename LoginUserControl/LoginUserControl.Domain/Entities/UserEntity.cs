﻿namespace LoginUserControl.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
