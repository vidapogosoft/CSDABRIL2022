package StepDefinition;

import org.openqa.selenium.WebElement;
import org.openqa.selenium.remote.DesiredCapabilities;
import io.appium.java_client.windows.WindowsDriver;

import org.junit.*;

import cucumber.api.java.en.And;
import cucumber.api.java.en.Given;
import cucumber.api.java.en.Then;
import cucumber.api.java.en.When;

import java.net.URL;
import java.util.concurrent.TimeUnit;

public class Steps {

    public static WindowsDriver NewSessionExe = null;

    @Given("Abre aplicacion de escritorio en windows$")
    public void open_the_winform() throws Throwable
    {

        DesiredCapabilities capabilities = new DesiredCapabilities();

        capabilities.setCapability("app",
                "D:\\vidapogosoft\\cursos\\2022\\sinergiass\\CSDAbril2022\\herramientas\\AppWinForm1.exe");

        NewSessionExe = new WindowsDriver(new URL("http://127.0.0.1:4723"), capabilities);

    }

    @When("Ingreso Identificacion de la persona 0919172551$")
    public void ingreso_identificacion() throws Throwable
    {
        NewSessionExe.findElementByAccessibilityId("TxtIdentificacion").click();;
        NewSessionExe.findElementByAccessibilityId("TxtIdentificacion").sendKeys("0919172551");

    }

    @And("Ingreso Nombres de la persona Victor Portugal$")
    public void ingreso_nombres() throws Throwable
    {
        NewSessionExe.findElementByAccessibilityId("TxtNombres").click();;
        NewSessionExe.findElementByAccessibilityId("TxtNombres").sendKeys("Victor Portugal");

    }

    @And("Ingreso Direccion de la persona Nor-Oeste Miraflores Ave Principal$")
    public void ingreso_direccion() throws Throwable
    {
        NewSessionExe.findElementByAccessibilityId("TxtDireccion").click();;
        NewSessionExe.findElementByAccessibilityId("TxtDireccion").sendKeys("Nor-Oeste Miraflores Ave Principal");

    }

    @And("Selecciono Estado civil Casado$")
    public void ingreso_estado_civil() throws Throwable
    {
        NewSessionExe.findElementByAccessibilityId("RdCasado").click();
    }

    @And("Presiono Boton de Confirmar Datos$")
    public void confirmar_datos() throws Throwable
    {
        NewSessionExe.findElementByName("Confirmar Datos").click();
    }

    @Then("Visualizo los resultados en la seccion Datos Registrados 0919172551$")
    public void confirmo_resultados() throws Throwable
    {
        String TextIdentificacion = NewSessionExe.findElementByAccessibilityId("LblIdentificacion").getText();

        System.out.println(TextIdentificacion);

        Assert.assertEquals("0919172552",TextIdentificacion);

    }

}
