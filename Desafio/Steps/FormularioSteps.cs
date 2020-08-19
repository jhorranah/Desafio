using Desafio.Actions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace Desafio.Steps
{
    [Binding]
    public class FormularioSteps
    {
        private FormularioActions actions;
        ScenarioContext _context;

        public FormularioSteps(ScenarioContext injectedContext, IWebDriver driver, WebDriverWait wait)
        {
            actions = new FormularioActions(driver, wait);
            _context = injectedContext;
        }

        [Given(@"que eu esteja na tela de cadastro de formulário")]
        public void DadoQueEuEstejaNaTelaDeCadastroDeFormulario()
        {
            actions.TelaCadastroFormulario();
        }

        [Given(@"clicar em cadastrar")]
        public void DadoClicarEmCadastrar()
        {
            actions.ClicarCadastrar();
        }

        [Given(@"preencher a tabela de Informações Principais ""(.*)""")]
        public void DadoPreencherATabelaDeInformacoesPrincipais(string Nome)
        {
            _context["Nome"] = Nome;
            actions.PreencherInformacoesprincipais(Nome);
        }

        [Given(@"preencher a tabela Palavras Chave ""(.*)""")]
        public void DadoPreencherATabelaPalavrasChave(string palavra)
        {
            actions.PreencherPalavrasChave(palavra);
        }

        [Given(@"Vincular Catalogos ""(.*)""")]
        public void DadoVincularCatalogos(string catalogos)
        {
            actions.VincularCatalogos(catalogos);
        }

        [Given(@"classisficar catalogos ""(.*)""")]
        public void DadoClassisficarCatalogos(string nivel)
        {
            actions.ClassificaFormulario(nivel);
        }

        [Given(@"Adicionar Fila ""(.*)""")]
        public void DadoAdicionar(string Atendimento)
        {
            actions.AdicionarFilaAtendimentos(Atendimento);
            actions.SelecionaBuscaViva(Atendimento);
        }

        [Given(@"Selecionar SLA ""(.*)""")]
        public void DadoSelecionar(string Sla)
        {
            actions.SelecionarSla(Sla);
        }

        [Given(@"Selecionar o calendário ""(.*)""")]
        public void DadoSelecionarOCalendario(string calendario)
        {
            actions.SelecionarCalendario(calendario);
        }

        [Given(@"clicar em gravar")]
        public void DadoClicarEmGravar()
        {
            actions.ClicarEmGravar();
        }

        [Then(@"o sistema deverá mostrar a mensagem de ""(.*)""")]
        public void EntaoOSistemaDeveraMostrarAMensagemDe(string mensagem)
        {
            actions.VerificaMensagem(mensagem);
        }

        [Then(@"apresentar o formulario cadastrado")]
        public void EntaoApresentarOFormularioCadastrado()
        {
            string Nome = (string)_context["Nome"];
            actions.VerificaListagem(Nome);
        }
    }
}