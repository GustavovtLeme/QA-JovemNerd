using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerdcast.Driver
{
    class Drivers
    {
        public static IWebDriver driver;
        int contador = 0;
        
        public static IWebDriver iniciarNavegador()
        {
            ChromeOptions options = new ChromeOptions();
            var path = "C:\\Users\\Windslasher\\source\\repos\\Nerdcast\\Nerdcast\\Driver";
            options.AddArguments("-start-maximized", "-incognito");
            driver = new ChromeDriver(@path, options);
            return driver;
        }

        public void abrirPagina(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void encerrarNavegador()
        {
            driver.Close();
            driver.Quit();
        }

        public void screenshot()
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("C:\\Users\\Windslasher\\source\\repos\\Nerdcast\\Screenshot\\teste_" + contador + ".jpeg", ScreenshotImageFormat.Jpeg);

            contador++;
        }


    }
}
