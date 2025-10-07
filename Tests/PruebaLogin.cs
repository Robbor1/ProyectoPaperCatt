using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using Xunit;

public class PruebaLogin
{
    [Fact]
    public void Login_Correcto()
    {
        // Supongamos que la ruta del exe compilado es así:
        var rutaExe = @"C:\Users\Kocco\Downloads\PaperCatt-main\ProyectoPaperCatt\bin\Debug\net8.0-windows\ProyectoPaperCatt.exe";
        var app = Application.Launch(rutaExe);

        // Título de la ventana de login (ajústalo a tu ventana real)
        var window = app.GetWindow("Login", InitializeOption.NoCache);

        // Interactuar con controles
        window.Get<TextBox>("txt_user").Text = "admin";
        window.Get<TextBox>("txt_pass").Text = "1234";
        window.Get<Button>("btnIngresar").Click();

        // Verificar resultado
        var mensaje = window.Get<Label>("lblMensaje").Text;
        Assert.Equal("Bienvenido", mensaje);

        app.Close();
    }
}
