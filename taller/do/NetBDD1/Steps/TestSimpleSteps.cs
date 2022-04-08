using System;
using TechTalk.SpecFlow;

using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

using NUnit.Framework;

namespace NetBDD1.Steps
{
    [Binding]
    public class TestSimpleSteps
    {
        private WindowsDriver<WindowsElement> _driver;

        [Given(@"Abre aplicacion de escritorio en windows")]
        public void GivenAbreAplicacionDeEscritorioEnWindows()
        {
            var options = new AppiumOptions();
            options.AddAdditionalCapability("app", "D:\\vidapogosoft\\cursos\\2022\\sinergiass\\CSDAbril2022\\herramientas\\AppWinForm1.exe");
            options.AddAdditionalCapability("deviceName", "HP-VPR2");

            _driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [When(@"Ingreso Identificacion de la persona 0919172551")]
        public void WhenIngresoIdentificacionDeLaPersona()
        {
            _driver.FindElementByAccessibilityId("TxtIdentificacion").Click();
            _driver.FindElementByAccessibilityId("TxtIdentificacion").SendKeys("0919172551");
        }
        
        [When(@"Ingreso Nombres de la persona Victor Portugal")]
        public void WhenIngresoNombresDeLaPersonaVictorPortugal()
        {
            _driver.FindElementByAccessibilityId("TxtNombres").Click();
            _driver.FindElementByAccessibilityId("TxtNombres").SendKeys("Victor Portugal");

        }

        [When(@"Ingreso Direccion de la persona Nor-Oeste Miraflores Ave Principal")]
        public void WhenIngresoDireccionDeLaPersonaNor_OesteMirafloresAvePrincipal()
        {
            _driver.FindElementByAccessibilityId("TxtDireccion").Click();
            _driver.FindElementByAccessibilityId("TxtDireccion").SendKeys("Nor-Oeste Miraflores Ave Principal");

        }

        [When(@"Selecciono Estado civil Casado")]
        public void WhenSeleccionoEstadoCivilCasado()
        {
            _driver.FindElementByAccessibilityId("RdCasado").Click();
        }
        
        [When(@"Presiono Boton de Confirmar Datos")]
        public void WhenPresionoBotonDeConfirmarDatos()
        {
            _driver.FindElementByName("Confirmar Datos").Click();
        }
        
        [Then(@"Visualizo los resultados en la seccion Datos Registrados 0919172551")]
        public void ThenVisualizoLosResultadosEnLaSeccionDatosRegistrados()
        {
            string TextIdentificacion = _driver.FindElementByAccessibilityId("LblIdentificacion").Text;

            Assert.AreEqual("0919172551", TextIdentificacion);

        }
    }
}
