using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions; // Para condiciones como AutomationId
using FlaUI.UIA3;
using System;
using System.Threading;
using Xunit;
using System.Diagnostics; // Para Application.Launch si no está implícito

public class UnitTest1
{
    [Fact]
    public void Login_Correcto()
    {
        // 1. INICIAR EL MOTOR DE AUTOMATIZACIÓN (UIA3 es la más moderna)
        using (var automation = new UIA3Automation())
        {
            var rutaExe = @"C:\Users\Kocco\Downloads\PaperCatt-main\ProyectoPaperCatt.sln";

            // 2. LANZAR LA APLICACIÓN
            var app = Application.Launch(rutaExe);

            var window = app.GetMainWindow(automation);

            // 4. INTERACTUAR CON CONTROLES
            // NOTA: "txt_user" y "btnIngresar" deben ser los Automation ID de tus controles.
            // Si la aplicación se lanza y esta es la ventana correcta, el código funcionará.
            var userTextBox = window.FindFirstDescendant("txt_user").AsTextBox();
            userTextBox.Text = "admin";

            var passTextBox = window.FindFirstDescendant("txt_pass").AsTextBox();
            passTextBox.Text = "1234";

            var btnIngresar = window.FindFirstDescendant("btnIngresar").AsButton();
            btnIngresar.Invoke();

            // 5. Esperar un poco (para ver resultado)
            Thread.Sleep(2000);

            // 6. Cerrar la app
            app.Close();
        }
    }
}