using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Fabricante : object
    {
        private string nome;
        private Veiculos[] vetor = new Veiculos[10];
        private int k;
        private List<Veiculos> lista = new List<Veiculos>();
        public Fabricante(string nome)
        {
            this.nome = nome;
        }
        public void Inserir(Veiculos c)
        {
            vetor[k] = c;
            k++;
            lista.Add(c);
        }
        public void SetNome(string n)
        {
            if (n != "") nome = n;
        }
        public string GetNome()
        {
            return nome;
        }
        public Veiculos[] Listar()
        {
            return vetor;
        }
        public List<Veiculos> Listar2()
        {
            return lista;
        }
        public override string ToString()
        {
            return $"Nome da Fabricante = {nome}";
        }
    }
}
