using System.Linq;

namespace Xperiments.DesignPatterns.TemplateMethod.Models
{
        
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
        return TemDoisItensComMesmoNome(orcamento);
        }
        
        public override double MaximaTaxacao(Orcamento orcamento)
        {
        return orcamento.Valor * 0.13 + 100;
        }
        
        public override double MinimaTaxacao(Orcamento orcamento)
        {
        return (orcamento.Valor * 0.01) * orcamento.Itens.Count;
        }
        
        private bool TemDoisItensComMesmoNome(Orcamento orcamento)
        {
        return orcamento.Itens.GroupBy(o => o.Nome).Where(g => g.Count() > 1).ToList().Count >= 1;
        
        }
        
    }
}