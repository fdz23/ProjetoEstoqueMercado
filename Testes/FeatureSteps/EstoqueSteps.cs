using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EstoqueMercado.Testes.FeatureSteps
{
    [Binding]
    class EstoqueSteps
    {
        [Given(@"um nome de categoria")]
        public void DadoUmNomeDeCategoria()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"preencher seu nome corretamente")]
        public void QuandoPreencherSeuNomeCorretamente()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"clico em adicionar categoria")]
        public void QuandoClicoEmAdicionarCategoria()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"a categoria deverá existir no banco de dados")]
        public void EntaoACategoriaDeveraExistirNoBancoDeDados()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"um nome de categoria ja existente")]
        public void DadoUmNomeDeCategoriaJaExistente()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"devo receber uma mensagem de erro")]
        public void EntaoDevoReceberUmaMensagemDeErro()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"um produto")]
        public void DadoUmProduto()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"preencher seus dados corretamente")]
        public void QuandoPreencherSeusDadosCorretamente()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"clico em adicionar produto")]
        public void QuandoClicoEmAdicionarProduto()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"o produto deverá existir no banco de dados")]
        public void EntaoOProdutoDeveraExistirNoBancoDeDados()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"deixar de preencher algum dado")]
        public void QuandoDeixarDePreencherAlgumDado()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
