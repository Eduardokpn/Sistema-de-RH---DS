using System;
using Aula02RH.Models;
using Aula02RH.Models.Enuns;

namespace Aula02RH
{
    class Program
    {
        static void Main(string[] args)
        {
           Funcionario func = new Funcionario();

           func.Id = 10;
           func.Nome = "Neymar";
           func.Cpf = "12345678910";
           func.Datadeadimissao = DateTime.Parse("01/01/2000");
           func.Salario = 10000.00M;
           func.Tipofuncionario = TipofuncionarioEnum.clt;

          string mensagem = func.ExibirPeriodoExeperiencia();
          Console.WriteLine("==============================");
          Console.WriteLine(mensagem);
          Console.WriteLine("==============================");
           

    }
}
}
