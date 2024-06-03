using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class Agencia
    {
        public string erro { get; private set; }
        private List<Cliente> clientes = new List<Cliente>();


        public Cliente consultarPorCPF(string cpf)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.cpf == cpf)
                {
                    return cliente;
                }
            }
            this.erro = "Cliente não encontrado";
            return null;
        }

        public bool addCliente(Cliente novoCliente)
        {
            if (consultarPorCPF(novoCliente.cpf) == null)
            {
                clientes.Add(novoCliente);
                return true;
            }
            this.erro = "Cliente já cadastrado";
            return false;
        }

        public bool removerCliente(string cpf)
        {
            Cliente cliente = consultarPorCPF(cpf);
            return clientes.Remove(cliente);
        }

        public Cliente[] exibirClientes(string filtro = "")
        {
            return clientes.ToArray();
        }

        public bool alterarcliente(string cpf)
        {
            Cliente cliente = consultarPorCPF(cpf);
            return clientes.Remove(cliente);
        }


    }
}
