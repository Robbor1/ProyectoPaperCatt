using Xunit;
using BussinesRules;
using System;

namespace Tests
{
    public class UsuariosTests
    {
        [Fact]
        public void SetAndGetNombre_ShouldReturnCorrectValue()
        {
            // Arrange
            var usuario = new Usuarios();
            string nombreEsperado = "Juan";

            // Act
            usuario.setNombre(nombreEsperado);
            var nombreObtenido = usuario.getNombre();

            // Assert
            Assert.Equal(nombreEsperado, nombreObtenido);
        }

        [Fact]
        public void SetAndGetClave_ShouldReturnCorrectValue()
        {
            var usuario = new Usuarios();
            int claveEsperada = 123;

            usuario.setClave(claveEsperada);
            var claveObtenida = usuario.getClave();

            Assert.Equal(claveEsperada, claveObtenida);
        }

        [Fact]
        public void SetAndGetFechaReg_ShouldReturnCorrectValue()
        {
            var usuario = new Usuarios();
            DateTime fecha = DateTime.Now;

            usuario.setFechaReg(fecha);
            var fechaObtenida = usuario.getFechaReg();

            Assert.Equal(fecha, fechaObtenida);
        }
    }
}