using ProyectoPaperCatt;


    ApplicationConfiguration.Initialize();

    // 1. Creamos una instancia del formulario de login.
    Login loginForm = new Login();

    // 2. Lo mostramos como un diálogo. El programa se detendrá aquí
    //    hasta que el formulario de login se cierre.
     if (loginForm.ShowDialog() == DialogResult.OK)
     {
        // 3. Si el resultado fue "OK" (o sea, login exitoso),
        //    entonces iniciamos la aplicación con el menú principal.
        Application.Run(new FormMainMenu());
     }
    // Si el login no fue exitoso, el programa simplemente terminará.
