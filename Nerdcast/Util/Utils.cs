using Nerdcast.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerdcast.Util
{
    class Utils : Drivers
    {
        public IWebElement element;
        public static IWebDriver driver = iniciarNavegador();
        public WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        
        public bool fillElement(string xpath, string valor, int timeout)
        {
            //int timeout = 10;
            int cont = 0;
            do
            {
                try
                {
                    element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
                    if (!element.Displayed)
                    {
                        return false;
                    }
                    else
                    {
                        element.Clear();
                        element.SendKeys(valor);
                        Console.WriteLine("Elemnto preenchido com sucesso");
                        return true;
                    }
                }
                catch (Exception e)
                {
                    cont++;
                    Console.WriteLine("Exceção encontrada: " + e);
                    Console.WriteLine("Tentativa " + cont);
                }
            } while (cont < timeout);
            return false;
        }

        public string armazenarTexto(string xpath, int timeout)
        {
            string armazenarTexto = "";
            element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            armazenarTexto = element.Text;
            return armazenarTexto;
        }

        public void enterKey(string xpath)
        {

            element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            element.SendKeys(Keys.Enter);
        }

        public bool clickElement(string xpath, int timeout)
        {
            int cont = 0;
            do
            {
                try
                {
                    element = wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                    if (!element.Displayed)
                    {
                        return false;
                    }
                    else
                    {
                        element.Click();
                        Console.WriteLine("Elemento clicado com sucesso");
                        return true;
                    }
                }
                catch (Exception e)
                {
                    cont++;
                    Console.WriteLine("Exceção encontrada: " + e);
                    Console.WriteLine("Tentativa " + cont);
                }
            } while (cont < timeout);

            return false;
        }

        public void pdfCreator()
        {

            var document = new PdfDocument();
            int width = 800;
            string Folder = "C:\\Users\\Windslasher\\source\\repos\\Nerdcast\\Screenshot";
            foreach (string F in System.IO.Directory.GetFiles(Folder, "*.jpeg"))
            {
                PdfPage page = document.AddPage();
                using (XImage img = XImage.FromFile(F))
                {
                    //Calculate new height to keep image ratio
                    var height = (int)(((double)width / (double)img.PixelWidth) * img.PixelHeight);

                    // Change PDF Page size to match image
                    page.Width = width;
                    page.Height = height;

                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    gfx.DrawImage(img, 0, 0, width, height);
                }
                document.Save("C:\\Users\\Windslasher\\source\\repos\\Nerdcast\\Screenshot\\Relatório01.pdf");

            }
        }
        
    }
    

}