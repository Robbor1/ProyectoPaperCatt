using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesRules
{
    public class Productos
    {
        int idProducto, Stock, Costo, Venta;
        string Nombre, Proveedor, Imagen, UnidadMedida;
        DateTime fechaReg;

        // PROPIEDADES
        /*---------------------------------------------------*/
        public void setIdProducto(int Id)
        {
            this.idProducto = Id;
        }
        public int getIdProducto() { return idProducto; }
        /*---------------------------------------------------*/

        public void setStock(int stock)
        {
            this.Stock = stock;
        }
        public int getStock() { return Stock; }
        /*---------------------------------------------------*/

        public void setCosto(int costo)
        {
            this.Costo = costo;
        }
        public int getCosto() { return Costo; }
        /*---------------------------------------------------*/

        public void setVenta(int venta)
        {
            this.Venta = venta;
        }
        public int getVenta() { return Venta; }
        /*---------------------------------------------------*/

        public void setNombre(String nombre)
        {
            this.Nombre = nombre;
        }
        public String getNombre() { return Nombre; }
        /*---------------------------------------------------*/
        public void setProveedor(String proveedor)
        {
            this.Proveedor = proveedor;
        }
        public String getProveedor() { return Proveedor; }
        /*---------------------------------------------------*/
        public void setImagen(String img)
        {
            this.Imagen = img;
        }
        public String getImagen() { return Imagen; }
        /*---------------------------------------------------*/
        public void setUnidadMedida(String unidad)
        {
            this.UnidadMedida = unidad;
        }
        public String getUnidadMedida() { return UnidadMedida; }
        /*---------------------------------------------------*/

        public void setFechaReg(DateTime Fecha)
        {
            this.fechaReg = Fecha;
        }
        public DateTime getFechaReg() { return fechaReg; }
        /*---------------------------------------------------*/

        // METODOS
        public Boolean fnGuardar()
        {
            try
            {
                Boolean resultado = false;
                DataProducto vProducto = new DataProducto();
                vProducto.Insertar(getNombre(), getCosto(), getVenta(), getUnidadMedida(), getProveedor(),
                    getFechaReg(), getStock(), getImagen());

                if (vProducto.renglonesAfectados > 0)
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
                DataProducto vProducto = new DataProducto();
                vProducto.Actualizar(getIdProducto(), getNombre(), getCosto(), getVenta(), getUnidadMedida(), getProveedor(),
                    getFechaReg(), getStock(), getImagen());

                if (vProducto.renglonesAfectados > 0)
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
