using Desafio.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Desafio.Actions
{
    class AutenticacaoActions
    {
        private readonly AutenticacaoPage autenticacaoPage;
        private readonly ProximaTelaPage proximaTelaPage;
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public AutenticacaoActions(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            autenticacaoPage = new AutenticacaoPage(driver);
            proximaTelaPage = new ProximaTelaPage(driver);
        }

        public void TelaAutenticacao(string Url)
        {
            _driver.Navigate().GoToUrl(Url);
        }

        public void PreencherUsuario(string Email)
        {
            autenticacaoPage.InpUser.SendKeys(Email);
        }

        public void PreencherSenha(string Senha)
        {
            autenticacaoPage.InpSenha.SendKeys(Senha);
        }

        public void ClicarBotaoEntrar()
        {
            autenticacaoPage.BtnEntrar.Click();
        }

        public void VerificarProximaTela()
        {

            Assert.True(proximaTelaPage.CampoBusca.Displayed);
        }

        public void VerificaMensagem(string mensagem)
        {
            IWebElement TextoMsg = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(autenticacaoPage.MsgCampoObrig));
            Assert.Equals(mensagem, TextoMsg.Text);
        }
    }
}
