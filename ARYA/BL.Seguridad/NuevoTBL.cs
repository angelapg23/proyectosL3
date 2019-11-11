using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Seguridad
{
    public class NuevoTBL
    {
        public BindingList<Tecnico> ListaTecnicos { get; set; } 

        public NuevoTBL()
        {
            ListaTecnicos = new BindingList<Tecnico>();

            var tecnico1 = new Tecnico();
            tecnico1.Id = 01;
            tecnico1.Nombre = "Lucrecio Perez";
            tecnico1.Especialidad = "Reparacion de Computadoras";
            tecnico1.Direccion = "ElProgreso";
            tecnico1.Telefono = "98654811";
            ListaTecnicos.Add(tecnico1);

            var tecnico2 = new Tecnico();
            tecnico2.Id = 02;
            tecnico2.Nombre = "Anastacio Lopez";
            tecnico2.Especialidad = "Reparacion de Celulares";
            tecnico2.Direccion = "Sanpedrosula";
            tecnico2.Telefono = "33245500";
            ListaTecnicos.Add(tecnico2);

            var tecnico3 = new Tecnico();
            tecnico3.Id = 03;
            tecnico3.Nombre = "Pankracio Cerrafino";
            tecnico3.Especialidad = "Impresoras";
            tecnico3.Direccion = "ElProgreso";
            tecnico3.Telefono = "39883774";
            ListaTecnicos.Add(tecnico3);
        }

        public BindingList<Tecnico> SeleccionarTecnico()
        {
            return ListaTecnicos;
        }

        public Resultado GuardarTecnico(Tecnico tecnico)
        {
            var resultado = Validar(tecnico);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            if (tecnico.Id ==0)
            {
                tecnico.Id = ListaTecnicos.Max(item => item.Id) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarTecnico()
        {
            var nuevoTecnico = new Tecnico();
            ListaTecnicos.Add(nuevoTecnico);
        }

        public bool EliminarTecnico(int id)
        {
            foreach (var tecnico in ListaTecnicos)
            {
                if (tecnico.Id == id)
                {
                    ListaTecnicos.Remove(tecnico);
                    return true;
                }
            

            }

            return false;
        }

        private Resultado Validar(Tecnico tecnico)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(tecnico.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un nombre";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(tecnico.Telefono) == true)
            {
                resultado.Mensaje = "Ingrese un Numero de telefono";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(tecnico.Direccion) == true)
            {
                resultado.Mensaje = "Por favor ingrese una direccion ";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(tecnico.Especialidad) == true)
            {
                resultado.Mensaje = "Por favor ingrese una especialidad";
                resultado.Exitoso = false;
            }



            return resultado;
        }

           
        }


        public class Tecnico
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Especialidad { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
        }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }

    }




