using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BussinesRules
{
    public class Usuarios 
    {
        

        //ATRIBUTOS
        private int Id;
        private String nombre, apellidoP, apellidoM, correo, telefono, userName, password; 
        DateTime fechaRegistro, fechaUltAcces;
        //private Date fecha;
        private int idPerfil, estatus;
        //PROPIEDADES
        /*-------------------------------------------------------*/
        public void setClave(int Valor)
        {
            this.Id = Valor;
        }
        public int getClave() { return Id; }
        /*-------------------------------------------------------*/

        public void setNombre(String Name)
        {
            this.nombre = Name;
        }
        public String getNombre() { return nombre; }
        /*-------------------------------------------------------*/
        public void setApellidoP(String ApP)
        {
            this.apellidoP = ApP;
        }
        public String getApellidoP() { return apellidoP; }
        /*-------------------------------------------------------*/
        public void setApellidoM(String ApM)
        {
            this.apellidoM = ApM;
        }
        public String getApellidoM() { return apellidoM; }
        /*-------------------------------------------------------*/
        public void setCorreo(String Correo)
        {
            this.correo = Correo;
        }
        public String getCorreo() { return correo; }
        /*-------------------------------------------------------*/
        public void setTelefono(String Tel)
        {
            this.telefono = Tel;
        }
        public String getTelefono() { return telefono; }
        /*-------------------------------------------------------*/
        public void setUserN(String UN)
        {
            this.userName = UN;
        }
        public String getUserN() { return userName; }
        /*-------------------------------------------------------*/
        public void setPass(String P)
        {
            this.password = P;
        }
        public String getPass() { return password; }
        /*-------------------------------------------------------*/
        public void setperfil(int Per)
        {
            this.idPerfil = Per;
        }
        public int getperfil() { return idPerfil; }
        /*-------------------------------------------------------*/

        public void setEstatus(int Est)
        {
            this.estatus = Est;
        }
        public int getEstatus() { return estatus; }

        /*-------------------------------------------------------*/

        public void setFechaReg(DateTime fechReg)
        {
            this.fechaRegistro = fechReg;
        }
        public DateTime getFechaReg() { return fechaRegistro; }

        /*-------------------------------------------------------*/

        public void setFechaUltAcceso(DateTime fechaUltAcceso)
        {
            this.fechaUltAcces = fechaUltAcceso;
        }
        public DateTime getFechaUltAcceso() { return fechaUltAcces; }

        /*-------------------------------------------------------*/

        //Metodos

        public Boolean fnValidaLogin()
        {
            try
            {
                Boolean resultado = false;
                //Recoger los datos del login
                DataUsuario mUsuario = new DataUsuario();

                mUsuario.ValidaLogin(userName, password);
                if (mUsuario.renglonesAfectados == 1)
                {
                    resultado = true;
                    Utilerias.G_NombreUsuario = mUsuario.NombreDeUsuario;
                    Utilerias.G_Usuario = mUsuario.username;
                }
                else
                {
                    resultado = false;
                    Utilerias.G_NombreUsuario = "";
                    Utilerias.G_Usuario = "";
                }
                //Conectar BD

                //Validar consulta

                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine("[fnValidaLogin]" + e.ToString());
                return false;
            }
        }
        public Boolean fnGuardar()
        {
            try
            {
                Boolean resultado = false;
                DataUsuario vUsuario = new DataUsuario();
                vUsuario.Insertar(getUserN(), getPass(), getNombre(), getApellidoP(), getApellidoM(), 
                    getCorreo(), getTelefono(), getEstatus(), getperfil(), getFechaReg(), getFechaUltAcceso());
                if (vUsuario.renglonesAfectados > 0)
                    resultado = true;
                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString()); return false;

            }
        }

        //public DataTable getAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public DataTable filter(string name)
        //{
        //    throw new NotImplementedException();
        //}

        //public void processRow(Dictionary<string, object> rowData)
        //{
        //    throw new NotImplementedException();
        //}

        /* public Boolean fnActualizar()
         {

         }

         public Boolean fnBuscar()
         {

         }
         public Boolean fnBuscarPorClave() 
         { 


         }*/
    }
}
