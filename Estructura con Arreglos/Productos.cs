using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_con_Arreglos
{
    class Productos
    {
        private int ban = 0;
        private struct producto{
            public int codigo;
            public string nombre;
            public string descripcion;
            public string cantidad;
            public string costo;
        }
        producto[] prod = new producto[15];


        public void llenar(int codigo, string nombre,
            string descripcion, string cantidad, string costo)
        {
            prod[ban].codigo = codigo;
            prod[ban].nombre = nombre;
            prod[ban].descripcion = descripcion;
            prod[ban].cantidad = cantidad;
            prod[ban].costo = costo;
            ban++;
            ordenar();
        }

        public string buscar(int codigo)
        {
            int code = 0;
            string data = "";
            for(int i = 0; i < 15; i++)
            {
                code = Convert.ToInt16(prod[i].codigo);
                if (code == codigo)
                {
                   data += "Codigo:" + prod[i].codigo + "| Nombre: " + prod[i].nombre
                        + "| Descripcion: " + prod[i].descripcion +"| Cantidad: " + 
                        prod[i].cantidad + "| Precio: $" + prod[i].costo + "\r\n";
                }
            }
            return data;
        }

        public void eliminar(int codigo)
        {
            int code = 0, lugar=0;
            for(int i = 0; i < 15; i++)
            {
                code = Convert.ToInt32(prod[i].codigo);
                if (code == codigo)
                    lugar = i;
            }
            for(int i = lugar; i < 15; i++)
            {
                code = Convert.ToInt32(prod[i].codigo);
                if (i < 14)
                {
                    prod[i] = prod[i + 1];
                }
                else
                {
                    prod[i].codigo = 0;
                    prod[i].nombre = "0";
                    prod[i].descripcion = "0";
                    prod[i].cantidad = "0";
                    prod[i].costo = "0";
                }
            }
        }

        public void insertar(int codigo, string nombre,
            string descripcion, string cantidad, string costo, int pos)
        {
            for (int i = 14; i > pos; i--)
            {
                prod[i] = prod[i - 1];
            }
            prod[pos].codigo = codigo; prod[pos].nombre = nombre; prod[pos].descripcion = descripcion;
            prod[pos].cantidad = cantidad; prod[pos].costo = costo;
        }

        public string Listar()
        {
            string data = "";
            for(int i = 0; i < ban; i++)
            {
                data += i+1 + ".- Codigo:" + prod[i].codigo + "| Nombre: " + prod[i].nombre + "| Descripcion: " + prod[i].descripcion +
                "| Cantidad: " + prod[i].cantidad + "| Precio: $" + prod[i].costo + "\r\n";
            }
            return data;
        }

        public void ordenar()
        {
            producto temp;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15 - 1; j++)
                {
                    if (prod[j].codigo > prod[j + 1].codigo)
                    {
                        temp = prod[j];
                        prod[j] = prod[j + 1];
                        prod[j + 1] = temp;
                    }
                }
            }
        }
    }
}
