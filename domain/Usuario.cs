using System;
using System.Collections.Generic;
using System.Text;

namespace domain
{
    class Usuario
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        public Usuario (string nome, string email, string senha) 
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }
}
