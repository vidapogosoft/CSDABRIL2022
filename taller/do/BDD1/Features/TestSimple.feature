Feature: Funcionalidad de Formulario de registro de datos en app windows
  Scenario: Registro de datos de personas
    Given Abre aplicacion de escritorio en windows
    When Ingreso Identificacion de la persona 0919172551
    And Ingreso Nombres de la persona Victor Portugal
    And Ingreso Direccion de la persona Nor-Oeste Miraflores Ave Principal
    And Selecciono Estado civil Casado
    And Presiono Boton de Confirmar Datos
    Then Visualizo los resultados en la seccion Datos Registrados 0919172551
