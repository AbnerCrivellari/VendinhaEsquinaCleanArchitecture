using System;
using System.Collections.Generic;
using System.Text;

namespace VendinhaEsquina.Core.Entities
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public ICollection<Pedido> Pedidos { get; }

        protected Cliente() { }
        public Cliente(string nome, string email, string cpf)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }
    }
}
