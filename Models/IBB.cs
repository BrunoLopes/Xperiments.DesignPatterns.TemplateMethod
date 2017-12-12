namespace Xperiments.DesignPatterns.TemplateMethod.Models
{
        
    public class IBB : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
        return orcamento.Valor > 500 && TemItemMaiorQueCemReais(orcamento);
        }
        
        public override double MaximaTaxacao(Orcamento orcamento)
        {
        return orcamento.Valor * 0.1;
        }
        
        public override double MinimaTaxacao(Orcamento orcamento)
        {
        return orcamento.Valor * 0.06;
        }
        
        private bool TemItemMaiorQueCemReais(Orcamento orcamento)
        {
        foreach(Item item in orcamento.Itens)
        {
            if(item.Valor > 100)
            return true;
        }
        return false;
        }

    }
}