using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteadorDeNomes
{
    public class Pessoa
    {
        private int indice;
        private string nome;
        private string sexo;

        public int GetIndice()
        {
            return indice;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetSexo()
        {
            return sexo;
        }
        public void SetIndice(int indice)
        {
            this.indice = indice;
        }
        public void SetNome(string nome)
        { 
            this.nome = nome;
        }
        public void SetSexo(string sexo)
        {
            this.sexo = sexo;
        }
    }


}
