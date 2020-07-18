using System;
using System.Collections.Generic;
using System.Text;

namespace VendinhaEsquina.Core.Entities
{
    public class Pedido : BaseEntity
    {
        public decimal ValorTotal { get; private set; }
        public int ClienteID { get; private set; }
        public Cliente Cliente { get; private set; }

        protected Pedido() { }
        public Pedido(int clienteId, decimal valorTotal, Cliente cliente)
        {
            ClienteID = clienteId;
            ValorTotal = valorTotal;
            Cliente = cliente;
        }
    }
}
