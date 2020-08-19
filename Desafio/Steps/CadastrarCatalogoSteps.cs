using Desafio.Actions;
using Desafio.DataModels;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Desafio.Steps
{
    [Binding]
    public class CadastrarCatalogoSteps
    {
        private CatalogoActions actions;
        private ScenarioContext _context;

        public CadastrarCatalogoSteps(IWebDriver driver, WebDriverWait wait, ScenarioContext injectedContext)

        {
            actions = new CatalogoActions(driver, wait);
            _context = injectedContext;
        }

        [Given(@"que eu esteja na tela de cadastro de catálogo")]
        public void DadoQueEuEstejaNaTelaDeCadastroDeCatalogo()
        {
            actions.EntrarTelaCatalogo();
        }

        [When(@"eu clicar em cadastrar")]
        public void QuandoEuClicarEmCadastrar()
        {
            actions.ClicarCadastrar();
        }

        [When(@"preencher os campos Nome do Catalogo e Descrição")]
        public void QuandoPreencherOsCamposNomeDoCatalogoEDescricao(Table table)
        {

            Catalogo catalogo = table.CreateInstance<Catalogo>();
            actions.PreencherNome(catalogo.Nome);
            actions.PreencherDescricao(catalogo.Descricao);
            _context["Nome"] = catalogo.Nome;


        }

        [When(@"Selecionar um formulário")]
        public void QuandoSelecionarUmFormulario(Table table)
        {
            IEnumerable<Catalogo2> catal = table.CreateSet<Catalogo2>();
            foreach (Catalogo2 cat in catal)
            {
                actions.PreencherFormulario(cat.formulario);
                actions.SelecionarOpcaoNaBusca(cat.formulario);
                actions.ClicarBotaoAdicionar();

            }
        }

        [When(@"clicar no botão gravar")]
        public void QuandoClicarNoBotaoGravar()
        {
            actions.ClicarBotaoGravar();
        }

        [Then(@"o sistema deverá apresentar a mensagem ""(.*)""")]
        public void EntaoOSistemaDeveraApresentarAMensagem(string mensagem)
        {
            actions.VerificarMensagem(mensagem);
        }

        [Then(@"mostrar o catalogo adicionado na listagem")]
        public void EntaoMostrarOCatalogoAdicionadoNaListagem()
        {
            string Nome = (string)_context["Nome"];
            actions.VerificaListagem(Nome);
        }
    }
}
