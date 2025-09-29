using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesRules
{
    public class Clientes
    {
        private int idCliente, no;
        private string nombreCompleto, RFC, CURP, correo, celular, domicilio, codigoPostal, pais,
            estado, ciudad;
        DateTime fechaNacimiento;

        // PROPIEDADES
        /*---------------------------------------------------*/
        public void setIdCliente(int Id)
        {
            this.idCliente = Id;
        }
        public int getIdCliente() { return idCliente; }
        /*---------------------------------------------------*/

        public void setNo(int No)
        {
            this.no = No;
        }
        public int getNo() { return no; }
        /*---------------------------------------------------*/

        public void setNombreCompleto(String Nombre)
        {
            this.nombreCompleto = Nombre;
        }
        public String getNombreCompleto() { return nombreCompleto; }
        /*---------------------------------------------------*/

        public void setRFC(String Rfc)
        {
            this.RFC = Rfc;
        }
        public String getRFC() { return RFC; }
        /*---------------------------------------------------*/

        public void setCURP(String Curp)
        {
            this.CURP = Curp;
        }
        public String getCURP() { return CURP; }
        /*---------------------------------------------------*/

        public void setCorreo(String Correo)
        {
            this.correo = Correo;
        }
        public String getCorreo() { return correo; }
        /*---------------------------------------------------*/

        public void setCelular(String Celular)
        {
            this.celular = Celular;
        }
        public String getCelular() { return celular; }
        /*---------------------------------------------------*/

        public void setDomicilio(String Domicilio)
        {
            this.domicilio = Domicilio;
        }
        public String getDomicilio() { return domicilio; }
        /*---------------------------------------------------*/

        public void setCodigoPostal(String CP)
        {
            this.codigoPostal = CP;
        }
        public String getCodigoPostal() { return codigoPostal; }
        /*---------------------------------------------------*/

        public void setPais(String Pais)
        {
            this.pais = Pais;
        }
        public String getPais() { return pais; }
        /*---------------------------------------------------*/

        public void setEstado(String Estado)
        {
            this.estado = Estado;
        }
        public String getEstado() { return estado; }
        /*---------------------------------------------------*/

        public void setCiudad(String Ciudad)
        {
            this.ciudad = Ciudad;
        }
        public String getCiudad() { return ciudad; }
        /*---------------------------------------------------*/

        public void setFechaNacimiento(DateTime Fecha)
        {
            this.fechaNacimiento = Fecha;
        }
        public DateTime getFechaNacimiento() { return fechaNacimiento; }

        // METODOS
        public Boolean fnGuardar()
        {
            try
            {
                Boolean resultado = false;
                DataCliente vCliente = new DataCliente();
                vCliente.Insertar(getNombreCompleto(), getFechaNacimiento(), getRFC(), getCURP(), getCorreo(),
                    getCelular(), getDomicilio(), getNo(), getCodigoPostal(), getPais(), getEstado(), getCiudad());

                if (vCliente.renglonesAfectados > 0)
                    resultado = true;

                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public Boolean fnActualizar()
        {
            try
            {
                Boolean resultado = false;
                DataCliente vCliente = new DataCliente();
                vCliente.Actualizar(getIdCliente(), getNombreCompleto(), getFechaNacimiento(), getRFC(), getCURP(), getCorreo(),
                    getCelular(), getDomicilio(), getNo(), getCodigoPostal(), getPais(), getEstado(), getCiudad());

                if (vCliente.renglonesAfectados > 0)
                    resultado = true;

                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}
