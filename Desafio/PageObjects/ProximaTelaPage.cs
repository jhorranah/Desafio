using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Desafio.PageObjects
{
    class ProximaTelaPage
    {
        public ProximaTelaPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "input_buscar")]
        public IWebElement CampoBusca { get; set; }
    }
}
