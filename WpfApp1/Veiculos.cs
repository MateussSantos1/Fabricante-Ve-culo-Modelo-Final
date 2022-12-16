using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Veiculos
    {
        private string nome;
        private string modelo;
        private double preco;
        public Veiculos(string nome, string modelo, double preco)
        {
            if (nome != "") this.nome = nome;
            if (modelo != "") this.modelo = modelo;
            if (preco >= 0) this.preco = preco;
        }
        public void SetNome(string n)
        {
            if (n != "") nome = n;
        }
        public void SetModelo(string a)
        {
            if (a != "") modelo = a;
        }
        public void SetPreco(double p)
        {
            if (p >= 0) preco = p;
        }
        public double GetPreco()
        {
            return preco;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetModelo()
        {
            return modelo;
        }

        public override string ToString()
        {
            return $"Nome: {nome} | Modelo: {modelo} | Valor = {preco}";
        }
    }
}
