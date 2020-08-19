using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace Desafio.PageObjects
{
    class CadastroNivelPage
    {
        public CadastroNivelPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "administrador")]
        public IWebElement MenuAdm { get; set; }

        [FindsBy(How = How.Id, Using = "adminDadosOferta")]
        public IWebElement MenuDadosForm { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#submenu > ul > li:nth-child(1) > ul > li:nth-child(3) > a")]
        public IWebElement MenuClassificação { get; set; }

        [FindsBy(How = How.Id, Using = "show-form")]
        public IWebElement BtnCadastrar { get; set; }

        [FindsBy(How = How.Id, Using = "nivel1")]
        public IWebElement Nivel1 { get; set; }

        [FindsBy(How = How.Id, Using = "nivel2")]
        public IWebElement Nivel2 { get; set; }

        [FindsBy(How = How.Id, Using = "nivel3")]
        public IWebElement Nivel3 { get; set; }

        [FindsBy(How = How.Id, Using = "nivel4")]
        public IWebElement Nivel4 { get; set; }

        [FindsBy(How = How.Id, Using = "nivel5")]
        public IWebElement Nivel5 { get; set; }

        [FindsBy(How = How.Id, Using = "nivel6")]
        public IWebElement Nivel6 { get; set; }

        [FindsBy(How = How.Id, Using = "nome-nivel")]
        public IWebElement InpNivel { get; set; }

        [FindsBy(How = How.Id, Using = "add-nivel")]
        public IWebElement BtnAdcNivel { get; set; }

        [FindsBy(How = How.Id, Using = "btn-enviar")]
        public IWebElement BtnGravar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#modalErrorSuccess #inputSuccess")]
        public IWebElement BtnOk { get; set; }

        public By mensagem = By.CssSelector("#modalErrorSuccess #modalText");

        //--------------------------- filtro -----------------------------------------//

        [FindsBy(How = How.CssSelector, Using = " tr:nth-child(1) > td:nth-child(1) > select")]
        public IWebElement NivelFiltro { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#frm-classificacao > div > button")]
        public IWebElement BtnFiltro { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.col-sm-12.panel__content > table > tbody > tr")]
        public IList<IWebElement> ListaFiltro { get; set; }

    }
}
