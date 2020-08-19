using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace Desafio.PageObjects
{
    class CatalogoPage
    {
        public CatalogoPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "administrador")]
        public IWebElement MenuAdm { get; set; }

        [FindsBy(How = How.Id, Using = "adminDadosOferta")]
        public IWebElement MenuDados { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li:nth-child(1) > ul > li:nth-child(5) > a")]
        public IWebElement MenuCat { get; set; }

        [FindsBy(How = How.Id, Using = "btn-cadastrar")]
        public IWebElement BtnCadastrar { get; set; }

        [FindsBy(How = How.Id, Using = "CAT_NOME")]
        public IWebElement InpNome { get; set; }

        [FindsBy(How = How.Id, Using = "CAT_DESCRICAO")]
        public IWebElement InpDesc { get; set; }

        [FindsBy(How = How.Id, Using = "inputOferta")]
        public IWebElement InpForm { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(26) > div")]
        public IList<IWebElement> ListaForm { get; set; }

        [FindsBy(How = How.CssSelector, Using = "td.plus > a > span")]
        public IWebElement BtnAdc { get; set; }

        public By ListaFormAdc = By.CssSelector("#ofertas-adicionadas > tbody > tr");

        [FindsBy(How = How.Id, Using = "btn-enviar")]
        public IWebElement BtnGravar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#modalErrorSuccess #inputSuccess")]
        public IWebElement BtnOk { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.col-sm-12.panel__content > table > tbody > tr")]
        public IList<IWebElement> ListaResult { get; set; }

        public By Mensagem = By.CssSelector("#modalErrorSuccess #modalText");

    }
}
