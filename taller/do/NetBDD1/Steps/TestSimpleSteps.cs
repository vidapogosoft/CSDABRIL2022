using System;
using TechTalk.SpecFlow;

namespace NetBDD1.Steps
{
    [Binding]
    public class TestSimpleSteps
    {
        [Given(@"Abre aplicacion de escritorio en windows")]
        public void GivenAbreAplicacionDeEscritorioEnWindows()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Ingreso Identificacion de la persona (.*)")]
        public void WhenIngresoIdentificacionDeLaPersona(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Ingreso Nombres de la persona Victor Portugal")]
        public void WhenIngresoNombresDeLaPersonaVictorPortugal()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Ingreso Direccion de la persona Nor-Oeste Miraflores Ave Principal")]
        public void WhenIngresoDireccionDeLaPersonaNor_OesteMirafloresAvePrincipal()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Selecciono Estado civil Casado")]
        public void WhenSeleccionoEstadoCivilCasado()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Presiono Boton de Confirmar Datos")]
        public void WhenPresionoBotonDeConfirmarDatos()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Visualizo los resultados en la seccion Datos Registrados (.*)")]
        public void ThenVisualizoLosResultadosEnLaSeccionDatosRegistrados(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
