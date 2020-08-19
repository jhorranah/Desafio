using Desafio.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Desafio.Actions
{
    class FormularioActions
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        private readonly FormularioPage formularioPage;

        public FormularioActions(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            formularioPage = new FormularioPage(driver);
        }

        public void TelaCadastroFormulario()
        {
            formularioPage.MenuAdm.Click();
        }
        public void ClicarCadastrar()
        {
            formularioPage.BtnCadastrar.Click();
        }

        public void PreencherInformacoesprincipais(string Nome)
        {
            formularioPage.InpNome.SendKeys(Nome);
            formularioPage.RadioInativo.Click();
            formularioPage.RadioPadrao.Click();
        }

        public void PreencherPalavrasChave(string palavra)
        {
            formularioPage.InpPalavra.SendKeys(palavra);
            formularioPage.BtnAdc.Click();
        }
        public void VincularCatalogos(string catalogos)
        {
            formularioPage.BtnLadoDireito.Click();

            bool encontrado = false;
            foreach (var l in formularioPage.ListaCatalogo)
            {
                // var lin = l.FindElement(By.XPath("option[1]"));

                if (l.Text.Equals(catalogos))
                {
                    l.Click();
                    encontrado = true;
                    break;
                }
            }
            Assert.True(encontrado);

            formularioPage.BtnLadoEsquerdo.Click();
        }
        //-----------------------------------Classificãção Formulário----------------------------------------//
        public void ClassificaFormulario(string nivel)
        {
            formularioPage.SlcNivel.Click();

            //_wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By)formularioPage.ListaNivel));
            //SelectElement nvl = new SelectElement((IWebElement)formularioPage.ListaNivel);

            bool encontrado = false;
            foreach (var slc in formularioPage.ListaNivel)
            {
                if (slc.Text.Equals(nivel))
                {
                    slc.Click();
                    encontrado = true;
                    break;
                }
            }
            Assert.True(encontrado);

        }
        //--------------------------------------------------------------------------------------------------//

        public void AdicionarFilaAtendimentos(string Atendimento)
        {
            formularioPage.BtnAdcFilaAtend.Click();

            string aux = Atendimento[0..^1];
            formularioPage.InpBuscaViva.SendKeys(aux);

            By Auto = By.CssSelector("body > div:nth-child(12)");
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(Auto));
        }

        public void SelecionaBuscaViva(string Atendimento)
        {
            bool encontrado = false;
            foreach (var cont in formularioPage.ListAutoComp)
            {
                if (cont.Text.Equals(Atendimento))
                {
                    cont.Click();
                    encontrado = true;
                    break;
                }
            }
            Assert.True(encontrado);

            formularioPage.BtnAdcAtend.Click();
            formularioPage.BtnInserirAtend.Click();
        }
        //-----------------------------------------------------SLA----------------------------------------------------------//
        public void SelecionarSla(string Sla)
        {
            formularioPage.Tipo.Click();

            bool encontrado = false;
            foreach (var T in formularioPage.SlcTipo)
            {
                if (T.Text.Equals(Sla))
                {
                    T.Click();
                    encontrado = true;
                    break;
                }
            }
            Assert.True(encontrado);
        }

        public void SelecionarCalendario(string calendario)
        {
            formularioPage.calend.Click();

            bool encontrado = false;
            foreach (var cal in formularioPage.SlcCalendario)
            {
                if (cal.Text.Equals(calendario))
                {
                    cal.Click();
                    encontrado = true;
                    break;
                }
            }
            Assert.True(encontrado);
        }


        //-----------------------------------------------------------------------------------------------------------------//
        public void ClicarEmGravar()
        {
            formularioPage.BtnGravar.Click();
        }

        public void VerificaMensagem(string Mensagem)
        {
            IWebElement mensagem = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(formularioPage.Msg));
            Assert.Equals(Mensagem, mensagem.Text);
            formularioPage.BtnOk.Click();
            Assert.True(AparecerTela());

        }

        public bool AparecerTela()
        {
            return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("modalErrorSuccess")));
        }

        public void VerificaListagem(string Nome)
        {
            bool encontrado = false;
            foreach (var linha in formularioPage.ListaForm)
            {
                var l = linha.FindElement(By.XPath("td[1]"));

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
