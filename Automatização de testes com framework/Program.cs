using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

class Program
{
    static void Main(string[] args)
    {
        // Usa o WebDriverManager para configurar o ChromeDriver
        new DriverManager().SetUpDriver(new ChromeConfig());

        // Inicializa o driver do Chrome
        IWebDriver driver = new ChromeDriver();

        // Navega até o Google
        driver.Navigate().GoToUrl("https://www.google.com");

        // Encontra o campo de pesquisa pelo nome
        IWebElement searchBox = driver.FindElement(By.Name("q"));

        // Digita 'Selenium' no campo de pesquisa
        searchBox.SendKeys("Selenium");

        // Envia a pesquisa
        searchBox.Submit();

        // Aguarda alguns segundos para visualizar os resultados
        System.Threading.Thread.Sleep(3000);

        // Fecha o navegador
        driver.Quit();
    }
}