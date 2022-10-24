using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Threading;

namespace nopCommerceAuto;

public class Tests
{
    EdgeDriver? driver;
    
    [SetUp]
    public void Setup()
    { 
        this.driver = new EdgeDriver();
        this.driver.Url = "http://192.168.56.3";
    }

    [Test]
    public void Test1()

    {
        IWebElement elem = this.driver.FindElement(By.XPath("//html/body/div[6]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a"));
        elem.Click();                                                   
        elem = this.driver.FindElement(By.XPath("//*[@id='Email']"));
        elem.SendKeys("belski@localnet.ua");
        elem = this.driver.FindElement(By.XPath("//*[@id='Password']"));
        elem.SendKeys("Pa$$w0rd");
        elem.SendKeys(Keys.Enter);

        Thread.Sleep(3000);            
    }

    [TearDown]
    public void TearDown() {
        this.driver.Close();
    }

}