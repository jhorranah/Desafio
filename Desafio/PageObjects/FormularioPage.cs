using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace Desafio.PageObjects
{
    class FormularioPage
    {
        public FormularioPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "administrador")]
        public IWebElement MenuAdm { get; set; }

        [FindsBy(How = How.CssSelector, Using = " a.btn.button.pull-right.button__margin-right")]
        public IWebElement BtnCadastrar { get; set; }

        //------------------------------Informações principais--------------------------------------//

        [FindsBy(How = How.Id, Using = "txt_nome_oferta")]
        public IWebElement InpNome { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.col-md-6.form-group__filter > div > label:nth-child(2)")]
        public IWebElement RadioInativo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "tipo-oferta > div > div > div > label:nth-child(1)")]
        public IWebElement RadioPadrao { get; set; }

        //-----------------------------------------Palavras chaves--------------------------------------------------------------//

        [FindsBy(How = How.Id, Using = "txt_palavra")]
        public IWebElement InpPalavra { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#palavras-inseridas > thead > tr > td > button")]
        public IWebElement BtnAdc { get; set; }

        //--------------------------------------------Vincular Catalogos----------------------------------------\\

        [FindsBy(How = How.CssSelector, Using = "#catalogosUsuario > option")]
        public IList<IWebElement> ListaCatalogo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.col-sm-12.panel__content > div.col-sm-2.form__group-buttons-selection > a:nth-child(2) > i")]
        public IWebElement BtnLadoDireito { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.col-sm-2.form__group-buttons-selection > a:nth-child(3)")]
        public IWebElement BtnLadoEsquerdo { get; set; }

        //-------------------------------------Classificação formulário --------------------------------------//
        [FindsBy(How = How.Id, Using = "NV1")]
        public IWebElement SlcNivel { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#NV1 > option")]
        public IList<IWebElement> ListaNivel { get; set; }

        //-------------------------------Fila----------------------------------------------------------------//
        [FindsBy(How = How.CssSelector, Using = "div.col-sm-6.panel.panel__col-left > div.col-sm-12.panel__content > div:nth-child(1) > div > div > table > thead > tr > td > button")]
        public IWebElement BtnAdcFilaTriagem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.panel__fila-overflow > table > tbody > tr")]
        public IWebElement RadioTriagem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#adiciona-fila-primeiro > div > div > div.modal-body > div.full-width.panel__margin-top > button.btn.button.button__type-confirm.pull-right0")]
        public IWebElement BtnInserirTriagem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.col-sm-6.panel.panel__col-left > div.col-sm-12.panel__content > div:nth-child(2) > div > div > table > thead > tr:nth-child(1) > td > button")]
        public IWebElement BtnAdcFilaAtend { get; set; }

        [FindsBy(How = How.Id, Using = "buscaFilaDemais")]
        public IWebElement InpBuscaViva { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(12) .autocomplete-suggestion")]
        public IList<IWebElement> ListAutoComp { get; set; }

        [FindsBy(How = How.CssSelector, Using = "table:nth-child(2) > tbody > tr > td > button")]
        public IWebElement BtnAdcAtend { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.btn.button.button__margin-right.pull-right.button__type-confirm")]
        public IWebElement BtnInserirAtend { get; set; }

        //-----------------------------------------------------SLA----------------------------------------------//


        [FindsBy(How = How.Id, Using = "idSlaAdicionado")]
        public IWebElement Tipo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#idSlaAdicionado > option")]
        public IList<IWebElement> SlcTipo { get; set; }

        [FindsBy(How = How.Id, Using = "sel_calendario_atendimento")]
        public IWebElement calend { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#sel_calendario_atendimento > option")]
        public IList<IWebElement> SlcCalendario { get; set; }

        //-----------------------------------------------------------------------------------------------------------------//
        [FindsBy(How = How.CssSelector, Using = " div > div > a.btn.button.pull-right.button__margin-right.button__type-confirm")]
        public IWebElement BtnGravar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#modalErrorSuccess #inputSuccess")]
        public IWebElement BtnOk { get; set; }

        public By Msg = By.CssSelector("#modalErrorSuccess #modalText");

        [FindsBy(How = How.CssSelector, Using = "#lista-ofertas > div > div.col-sm-12.panel__content > table > tbody > tr")]
        public IList<IWebElement> ListaForm { get; set; }

    }
}
