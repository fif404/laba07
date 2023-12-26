using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace laba7
{
    [TestFixture]
    public class Tests
    {
        IWebDriver webDriver = new ChromeDriver();
        [TestCase]
        public void mainTitle()
        {
            webDriver.Url = "https://mail.ru";
            Assert.AreEqual("Mail.ru: почта, поиск, новости, прогноз погоды, гороскоп, программа передач", webDriver.Title);
            webDriver.Close();
        }
        [TearDown]
        public void tearEnd()
        {
            webDriver.Quit();
        }
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestSuccessfulBooking()
        {
            driver.Navigate().GoToUrl("https://mail.ru");
            IWebElement button = driver.FindElement(By.ClassName("ph-project ph-project__register svelte-ibessq"));
            string buttonText = button.Text;
            Assert.AreEqual("Регистрация", buttonText);

        }

        [Test]
        public void TestEventSearch()
        {
            driver.Navigate().GoToUrl("https://mail.ru");

        }


        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }

}