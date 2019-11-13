using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    class Funcionario : Pessoa 
    {
        public int Id { get; set; }
        public DateTime  DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public decimal Salario { get; set; }
        public string Cracha { get; set; }
        public Cargos Cargo { get; set; }
    }

    public enum Cargos
    { 
         Faxineira,
         Recepcionista,
         OperadorCaixa,
         Atendente,
         Vendedor,
         Tosador,
         Repositor,
         Veterinario,
         Motorista,
         Estagiario,
         Trainee,
         Gerente,
    }
}
