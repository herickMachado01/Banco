using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class Conta
    {
        public int numero;
        public Cliente titular;
        private double saldo;
        private string erro;

        public string getErro() 
        {
            return this.erro;
        }

        public double getSaldo() 
        {
            return this.saldo;
        }

        public bool depositar(double valor) 
        {
            if (valor > 0) 
            {
                this.saldo += (valor-0.01);
                return true;
            }
            this.erro = "Valor do deposito não pode ser negativo!";
            return false;
        }

        public bool sacar(double valor) 
        {
            if (valor > 0) 
            {
                if (this.saldo >= (valor+0.01)) 
                {
                    this.saldo -= (valor+0.01);
                    return true;
                }
                this.erro = "Saldo insuficiente!";
                return false;
            }
            this.erro = "Valor do saque não pode ser negativo!";
            return false;
        }

        public bool transferir(double valor, Conta destino) 
        {
            if (this.sacar(valor)) 
            {
                destino.depositar(valor);
                return true;
            }
            return false;
        }
    }
}
