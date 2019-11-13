using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        //se colocar int ele não irá considerar o zero, portanto deve ser em string
        public string CPF { get; set; }
        public string Email { get; set; }

        private int _idade;

        public int Idade
        {
            get 
            {
                string sobrenome = "Gameiro";

                if (sobrenome == "Gameiro")
                    nome1 = "Nina";
                else
                    nome1 = "Não conheco";

                Operador ternario

                string nome = sobrenome == "Gameiro" ? "Nina" : "Não Conheco";


                int _idade = DateTime.Today.Year - DataNascimento.Year;
                return DataNascimento.AddYears(_idade) > DateTime.Today ?
                    _idade-- : _idade;  
          
            }
        }

    }
}
