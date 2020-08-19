using Desafio.DataModels;
using Desafio.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Desafio.Actions
{
    class CadastroNivelActions
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        private readonly CadastroNivelPage cadastroNivelPage;

        public CadastroNivelActions(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            cadastroNivelPage = new CadastroNivelPage(driver);
        }

        public void TelaCadastroClassificação()
        {
            cadastroNivelPage.MenuAdm.Click();
            cadastroNivelPage.MenuDadosForm.Click();
            cadastroNivelPage.MenuClassificação.Click();
        }

        public void ClicarCadastrar()
        {
            cadastroNivelPage.BtnCadastrar.Click();
        }

        public void SelecionarNivel(int Nivel, Niveis Nvs)
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel1));
            SelectElement Nv = new SelectElement(cadastroNivelPage.Nivel1);

            if (Nivel == 1)
            {
                Nv.SelectByText("Inserir nesse nível");
            }
            else if (Nivel == 2)
            {

                Nv.SelectByText(Nvs.nivel1);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel2));
                Nv = new SelectElement(cadastroNivelPage.Nivel2);
                Nv.SelectByText("Inserir nesse nível");
            }
            else if (Nivel == 3)
            {
                Nv.SelectByText(Nvs.nivel1);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel2));
                Nv = new SelectElement(cadastroNivelPage.Nivel2);
                Nv.SelectByText(Nvs.nivel2);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel3));
                Nv = new SelectElement(cadastroNivelPage.Nivel3);
                Nv.SelectByText("Inserir nesse nível");
            }
            else if (Nivel == 4)
            {
                Nv.SelectByText(Nvs.nivel1);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel2));
                Nv = new SelectElement(cadastroNivelPage.Nivel2);
                Nv.SelectByText(Nvs.nivel2);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel3));
                Nv = new SelectElement(cadastroNivelPage.Nivel3);
                Nv.SelectByText(Nvs.nivel3);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel4));
                Nv = new SelectElement(cadastroNivelPage.Nivel4);
                Nv.SelectByText("Inserir nesse nível");

            }
            else if (Nivel == 5)
            {
                Nv.SelectByText(Nvs.nivel1);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel2));
                Nv = new SelectElement(cadastroNivelPage.Nivel2);
                Nv.SelectByText(Nvs.nivel2);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel3));
                Nv = new SelectElement(cadastroNivelPage.Nivel3);
                Nv.SelectByText(Nvs.nivel3);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel4));
                Nv = new SelectElement(cadastroNivelPage.Nivel4);
                Nv.SelectByText(Nvs.nivel4);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel5));
                Nv = new SelectElement(cadastroNivelPage.Nivel5);
                Nv.SelectByText("Inserir nesse nível");

            }
            else if (Nivel == 6)
            {
                Nv.SelectByText(Nvs.nivel1);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel2));
                Nv = new SelectElement(cadastroNivelPage.Nivel2);
                Nv.SelectByText(Nvs.nivel2);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel3));
                Nv = new SelectElement(cadastroNivelPage.Nivel3);
                Nv.SelectByText(Nvs.nivel3);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel4));
                Nv = new SelectElement(cadastroNivelPage.Nivel4);
                Nv.SelectByText(Nvs.nivel4);

                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cadastroNivelPage.Nivel5));
                Nv = new SelectElement(cadastroNivelPage.Nivel5);
                Nv.SelectByText(Nvs.nivel5);

            }
        }

        public void CadastrarNomeNivel(string Nome)
        {
            cadastroNivelPage.InpNivel.SendKeys(Nome);
        }


        public void ClicarEmAdicionar()
        {
            cadastroNivelPage.BtnAdcNivel.Click();
        }

        public void ClicarEmGravar()
        {
            cadastroNivelPage.BtnGravar.Click();
        }

        public void VerificaMensagem(string mensagem)
        {
            IWebElement Msg = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(cadastroNivelPage.mensagem));
            Assert.True(Msg.Text.Equals(mensagem));

            cadastroNivelPage.BtnOk.Click();

        }


   
        

    }
}
