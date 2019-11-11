using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Seguridad.NuevoCBL;

namespace BL.Seguridad
{
    public class NuevoCBL
    {
        public BindingList<Cliente> ListaClientes { get; set; }

        public NuevoCBL()
        {

            ListaClientes = new BindingList<Cliente>();

            var cliente1 = new Cliente();
            cliente1.Id = 01;
            cliente1.Nombre = "Daniela Posas";
            cliente1.Telefono = "96023502";
            cliente1.Direcion = "ElProgreso";
            ListaClientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Id = 02;
            cliente2.Nombre = "Cristian Padilla";
            cliente2.Telefono = "87945500";
            cliente2.Direcion = "SanPedroSula";
            ListaClientes.Add(cliente2);

            var cliente3 = new Cliente();
            cliente3.Id = 03;
            cliente3.Nombre = "Adriana Gonzales";
            cliente3.Telefono = "95841813";
            cliente3.Direcion = "ElProgreso";
            ListaClientes.Add(cliente3);


        }

        public BindingList<Cliente> ObtenerClientes()
        {
            return ListaClientes;
        }



        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            if (cliente.Id == 0)

            { 
            cliente.Id = ListaClientes.Max(item => item.Id) + 1;

            }

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCliente()
        {
            var nuevocliente = new Cliente();
            ListaClientes.Add(nuevocliente);

        }

        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    return true;
                }


            }

            return false;
        }

        public class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Direcion { get; set; }
        }


        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }


        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(cliente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un nombre";
                resultado.Exitoso = false;
            }

            else if (string.IsNullOrEmpty(cliente.Telefono) == true)
            {
                resultado.Mensaje = "Ingrese un Numero de telefono";
                resultado.Exitoso = false;
            }

            else if (string.IsNullOrEmpty(cliente.Direcion) == true)
            {
                resultado.Mensaje = "Por favor ingrese una direccion ";
                resultado.Exitoso = false;
            }
                return resultado;
            
        }
    }
}



           
  

