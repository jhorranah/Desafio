using Desafio.Actions;
using Desafio.DataModels;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Desafio.Features
{
    [Binding]
    public class AutenticacaoSteps
    {

        private readonly string Url = ("https://demohelpdesk.luxfacta.com/login");
        private readonly AutenticacaoActions actions;
        private IWebDriver _driver;

        public AutenticacaoSteps(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            actions = new AutenticacaoActions(driver, wait);
        }

        [Given(@"que eu esteja na tela de autenticação")]
        public void DadoQueEuEstejaNaTelaDeAutenticacao()
        {
            actions.TelaAutenticacao(Url);
        }

        [When(@"eu preencher os campos de usuário e senha")]
        public void QuandoEuPreencherOsCamposDeUsuarioESenha(Table table)
        {

            Usuario usuario = table.CreateInstance<Usuario>();
            actions.PreencherUsuario(usuario.Email);
            actions.PreencherSenha(usuario.Senha);

        }

        [When(@"clicar no botão para entrar")]
        public void QuandoClicarNoBotaoParaEntrar()
        {
            actions.ClicarBotaoEntrar();
        }

        [Then(@"o sistema deverá apresentar a próxima tela")]
        public void EntaoOSistemaDeveraApresentarAProximaTela()
        {

            actions.VerificarProximaTela();
        }
        //--------------------------------Autenticação invalida-----------------------------------------------------------//

        [When(@"eu preencher o campo de usuário com (.*)")]
        public void QuandoEuPreencherOCampoDeUsuario(string usuario)
        {
            actions.PreencherUsuario(usuario);
        }

        [When(@"eu preencher o campo de senha com (.*)")]
        public void QuandoEuPreencherOCampoDeSenhaCom(string senha)
        {
            actions.PreencherSenha(senha);
        }

        [Then(@"o sistema deverá apresentar a mensagem de (.*)")]
        public void EntaoOSistemaDeveraApresentarAMensagemDe(string mensagem)
        {
            actions.VerificaMensagem(mensagem);
        }

    }
}
