using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Desafio.PageObjects
{
    class AutenticacaoPage
    {
        public AutenticacaoPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement InpUser { get; set; }

        [FindsBy(How = How.Id, Using = "inputPassword")]
        public IWebElement InpSenha { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div:nth-child(5) > button")]
        public IWebElement BtnEntrar { get; set; }

        public By MsgCampoObrig = By.CssSelector("#validate > label:nth-child(1)");

        public By MsgUserInvalido = By.CssSelector("#validate > label:nth-child(2)");




    }
}
