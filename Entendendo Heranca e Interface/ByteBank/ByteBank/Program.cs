﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("546.879.157-20");

            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de um referencia de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de um referencia de Funcionario: " + robertaTeste.GetBonificacao());



            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificação: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();

        }
    }
}
