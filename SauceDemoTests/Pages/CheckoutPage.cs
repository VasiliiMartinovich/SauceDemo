using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SauceDemoTests.Pages;

public class CheckoutPage : BasePage
{
    public CheckoutPage(IWebDriver driver) : base(driver)
    {
    }
    
    private readonly By _firstName = By.Id("first-name");
    private readonly By _lastName = By.Id("last-name");  
    private readonly By _zipcode = By.Id("postal-code");
    private readonly By _continueButton = By.ClassName("submit-button btn btn_primary cart_button btn_action");

    public CheckoutPage SetFirstName(string firstname)
    {
        _driver.FindElement(_firstName).SendKeys(firstname);
        return this;
    }
    
    public CheckoutPage SetLastName(string lastname)
    {
        _driver.FindElement(_lastName).SendKeys(lastname);
        return this;
    }
    
    public CheckoutPage SetZipcode(string zipcode)
    {
        _driver.FindElement(_zipcode).SendKeys(zipcode);
        return this;
    }
    
    // public OverviewPage ClickContinueButton()
    // {
    //     _driver.FindElement(_continueButton).Click();
    //     return new OverviewPage (_driver);
    // }
}
