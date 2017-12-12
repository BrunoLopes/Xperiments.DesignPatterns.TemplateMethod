namespace Xperiments.DesignPatterns.TemplateMethod.Models
{
        
    public class BRL : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
        return orcamento.Valor >= 500;
        }
        
        public override double MaximaTaxacao(Orcamento orcamento)
        {
        return orcamento.Valor * 0.7;
        }
        
        public override double MinimaTaxacao(Orcamento orcamento)
        {
        return orcamento.Valor * 0.05;
        }
        
    }
}