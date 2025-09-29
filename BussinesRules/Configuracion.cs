using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesRules
{
    public class Configuracion
    {
        //ATRIBUTOS
        private int TasaIVA;
        private String nombreEmp, rfcEmp, direccionEmp, nombreSucursal, direccionSucursal, correo, Moneda;
   
        //PROPIEDADES
        
        /*-------------------------------------------------------*/
        public void setNombreEmp(String nom)
        {
            this.nombreEmp = nom;
        }
        public String getNombreEmp() { return nombreEmp; }
        /*-------------------------------------------------------*/
        public void setRFCEmp(String rfc)
        {
            this.rfcEmp = rfc;
        }
        public String getRFCEmp() { return rfcEmp; }
        /*-------------------------------------------------------*/
        public void setDirEmp(String dir)
        {
            this.direccionEmp = dir;
        }
        public String getDirEmp() { return direccionEmp; }
        /*-------------------------------------------------------*/
        public void setNomSucursal(String nomSuc)
        {
            this.nombreSucursal = nomSuc;
        }
        public String getNomSucursal() { return nombreSucursal; }
        /*-------------------------------------------------------*/
        public void setDirSuc(String dirSuc)
        {
            this.direccionSucursal = dirSuc;
        }
        public String getDirSuc() { return direccionSucursal; }
        /*-------------------------------------------------------*/
        public void setCorreo(String correo)
        {
            this.correo = correo;
        }
        public String getCorreo() { return correo; }
        /*-------------------------------------------------------*/
        public void setTasaIVA(int iva)
        {
            this.TasaIVA = iva;
        }
        public int getTasaIVA() { return TasaIVA; }
        /*-------------------------------------------------------*/
        public void setMoneda(String moneda)
        {
            this.Moneda = moneda;
        }
        public String getMoneda() { return Moneda; }
        /*-------------------------------------------------------*/
        //Metodos

        public Boolean fnGuardar()
        {
            try
            {
                Boolean resultado = false;
                DataConfig vConfig = new DataConfig();
                vConfig.Insertar(getNombreEmp(), getRFCEmp(), getDirEmp(), getNomSucursal(), getDirSuc(), getCorreo(),
                    getTasaIVA(), getMoneda());
                if (vConfig.renglonesAfectados > 0)
                    resultado = true;
                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString()); return false;

            }
        }
    }
}
