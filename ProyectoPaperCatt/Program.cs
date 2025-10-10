using ProyectoPaperCatt;


    ApplicationConfiguration.Initialize();

    // 1. Creamos una instancia del formulario de login.
    Login loginForm = new Login();

    // 2. Lo mostramos como un di�logo. El programa se detendr� aqu�
    //    hasta que el formulario de login se cierre.
     if (loginForm.ShowDialog() == DialogResult.OK)
     {
        // 3. Si el resultado fue "OK" (o sea, login exitoso),
        //    entonces iniciamos la aplicaci�n con el men� principal.
        Application.Run(new FormMainMenu());
     }
    // Si el login no fue exitoso, el programa simplemente terminar�.
