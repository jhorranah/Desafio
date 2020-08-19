using Desafio.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace Desafio.Actions
{
    class CatalogoActions
    {
        private readonly CatalogoPage catalogoPage;
        private IWebDriver _driver;
        private WebDriverWait _wait;


        public CatalogoActions(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            catalogoPage = new CatalogoPage(driver);
        }

        public void EntrarTelaCatalogo()
        {
            catalogoPage.MenuAdm.Click();
            catalogoPage.MenuDados.Click();
            catalogoPage.MenuCat.Click();
        }

        public void ClicarCadastrar()
        {
            catalogoPage.BtnCadastrar.Click();

        }
        public void PreencherNome(string Nome)
        {
            catalogoPage.InpNome.SendKeys(Nome);
        }

        public void PreencherDescricao(string Descricao)
        {
            catalogoPage.InpDesc.SendKeys(Descricao);
        }

        public void PreencherFormulario(string formulario)
        {
            string aux = formulario[0..^1];
            catalogoPage.InpForm.SendKeys(aux);

            By ListaAutoComp = By.CssSelector("body > div:nth-child(26)");
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ListaAutoComp));
        }
        public void SelecionarOpcaoNaBusca(string formulário)
        {
            var encontrado = false;
            foreach (var l in catalogoPage.ListaForm)
            {
                if (l.Text.Equals(formulário))
                {
                    l.Click();
                    encontrado = true;
                    break;
                }
                Assert.True(encontrado);
            }

        }
        public void ClicarBotaoAdicionar()
        {
            catalogoPage.BtnAdc.Click();
        }

        public void VerificaInsercaoLista(string Formulario)
        {
            IList<IWebElement> ListaAdc = _driver.FindElements(catalogoPage.ListaFormAdc);
            bool encontrado = false;

            foreach (var linha in ListaAdc)
            {
                var lForm = linha.FindElement(By.XPath("td[1]"));

                if (lForm.Text.Equals(Formulario))
                {

                    encontrado = true;
                    break;
                }
            }
            Assert.True(encontrado);

        }

        public void ClicarBotaoGravar()
        {
            catalogoPage.BtnGravar.Click();
        }

        public void VerificarMensagem(string mensagem)
        {
            IWebElement Msg = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(catalogoPage.Mensagem));
            Assert.Equals(mensagem, Msg.Text);
            catalogoPage.BtnOk.Click();
            Assert.True(MostrarTelaLista());
        }

        public bool MostrarTelaLista()
        {
            return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("modalErrorSuccess")));
        }

        public void VerificaListagem(string Nome)
        {
            var encontrado = false;
            foreach (var lin in catalogoPage.ListaResult)
            {
                var l = lin.FindElement(By.XPath("td[1]"));

                if (l.Text.Equals(Nome))
                {
                    encontrado = true;
                    break;
                }
            }
            Assert.True(encontrado);

        }

    }
}
