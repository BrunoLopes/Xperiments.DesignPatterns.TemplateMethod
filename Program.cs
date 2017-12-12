using System;
using Xperiments.DesignPatterns.TemplateMethod.Models;

namespace Xperiments.DesignPatterns.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeImpostos calculadora = new CalculadoraDeImpostos();
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto ibb = new IBB();
            Imposto brl = new BRL();
            Imposto ihit = new IHIT();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItens(new Item("Caneta", 20));
            orcamento.AdicionaItens(new Item("Lápis", 15));
            orcamento.AdicionaItens(new Item("Borracha", 3));
            orcamento.AdicionaItens(new Item("Caneta", 300));
            //orcamento.AdicionaItens(new Item("Mochila", 200));
            //orcamento.AdicionaItens(new Item("6º elemento", 1));

            calculadora.RealizaCalculo(orcamento, iss);
            calculadora.RealizaCalculo(orcamento, icms);
            calculadora.RealizaCalculo(orcamento, ibb);
            calculadora.RealizaCalculo(orcamento, brl);
            calculadora.RealizaCalculo(orcamento, ihit);


            //double desconto = calculadora.Calcula(orcamento);
            //Console.WriteLine(desconto);
            
        }
    }
}
