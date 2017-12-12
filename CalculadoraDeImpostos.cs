using System;
using Xperiments.DesignPatterns.TemplateMethod.Models;

namespace Xperiments.DesignPatterns.TemplateMethod
{

    public class CalculadoraDeImpostos
    {    public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            var x = imposto.Calcula(orcamento);
            Console.WriteLine(x);
            
        }

    }

}