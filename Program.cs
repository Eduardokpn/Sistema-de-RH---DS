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

           Console.WriteLine("Digite o Id do Funcionario:");
           func.Id = int.Parse(Console.ReadLine());
           
           Console.WriteLine("Digite o nome do funcionairo:");
           func.Nome = Console.ReadLine();
           
           Console.WriteLine("Digite o CPF do Funcionario:");
           func.Cpf = Console.ReadLine();
           
           Console.WriteLine("Data de Adimissâo:");
           func.Datadeadimissao = DateTime.Parse(Console.ReadLine());
           
           Console.WriteLine("Digite o salario:");
           func.Salario = decimal.Parse(Console.ReadLine());
           
           Console.WriteLine("Qual tipo de funcionario: ");
           int opcao = int.Parse(Console.ReadLine());

           //operador ternario
           func.Tipofuncionario = (opcao == 1) ? TipofuncionarioEnum.clt : TipofuncionarioEnum.aprendiz;

                func.Reajustarsalario();
                decimal valorDesconoVT = func.CalcularDescontoVT(6);

           Console.WriteLine("=====================================");
           Console.WriteLine($"O Salario Reajustado é {func.Salario}.\n");
           Console.WriteLine($"O desconto do VT é{valorDesconoVT} .\n");
           

    }
}
}
