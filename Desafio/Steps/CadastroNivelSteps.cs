using Desafio.Actions;
using Desafio.DataModels;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Desafio.Steps
{
    [Binding]
    public class CadastroNivelSteps
    {
        private CadastroNivelActions actions;
        private ScenarioContext _context;

        public CadastroNivelSteps(ScenarioContext injectedContext, IWebDriver driver, WebDriverWait wait)
        {
            actions = new CadastroNivelActions(driver, wait);
            _context = injectedContext;
        }

        [Given(@"que eu esteja na tela de cadastro de Classificação")]
        public void DadoQueEuEstejaNaTelaDeCadastroDeClassificacao()
        {
            actions.TelaCadastroClassificação();
        }

        [When(@"eu clicar no botão cadastrar")]
        public void QuandoEuClicarNoBotaoCadastrar()
        {
            actions.ClicarCadastrar();
        }

        [When(@"selecionar o nível (.*)")]
        public void QuandoSelecionarONivel(int Nivel, Table table)
        {
            Niveis nv = table.CreateInstance<Niveis>();
            actions.SelecionarNivel(Nivel, nv);
            _context["Nivel"] = nv.nivel1;
        }

        [When(@"preencher o campo Nível ""(.*)""")]
        public void QuandoPreencherOCampoNivel(string Nome)
        {
            actions.CadastrarNomeNivel(Nome);
        }

        [When(@"clicar em adicionar nível")]
        public void QuandoClicarEmAdicionarNivel()
        {
            actions.ClicarEmAdicionar();
        }

        [When(@"clicar em gravar")]
        public void QuandoClicarEmGravar()
        {
            actions.ClicarEmGravar();
        }

        [Then(@"o sistema deverá apresentar ""(.*)""")]
        public void EntaoOSistemaDeveraApresentar(string mensagem)
        {
            actions.VerificaMensagem(mensagem);
        }

       
    }
}
