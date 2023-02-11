using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace GuiaDidactica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Empleado empleado = new Empleado();
            Inmueble inmueble = new Inmueble();
            Plazos plazos = new Plazos();

            

            //menu principal
            Console.WriteLine("------------ Bienvenido ------------");
            Console.WriteLine("Porfavor seleccione una opcion de su agrado de acuerdo al inmueble que necesite: ");
            Console.WriteLine("1. Casa \n" + "2. Carro \n " + "3.Parcela \n" + "4. Fabrica \n");
            inmueble.opcion = Convert.ToInt32(Console.ReadLine());

            //pedir datos personales del cliente
            Console.WriteLine("Escriba sus datos personales para completar el pedido: ");
            Console.WriteLine("Nombre: ");
            cliente.nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            cliente.apellido = Console.ReadLine();
            Console.WriteLine("Telefono: ");
            cliente.telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dui");
            cliente.duiC = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("*** PROCESANDO DATOS *** \n \n");
            Console.WriteLine("En cuantas cuotas desea pagar el total por el inmueble solicitado(1 cuota equivale a un mes): ");
            plazos.meses = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            //datos de empleado //

            Console.WriteLine("Escriba los datos de empleado : ");
            Console.WriteLine("Nombre: ");
            empleado.nombreE = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            empleado.apellidoE = Console.ReadLine();
            Console.WriteLine("Telefono: ");
            empleado.telefonoE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ide");
            empleado.idE = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("*** PROCESANDO DATOS *** \n \n");
            Console.Clear();

            //crear recibo
            inmueble.Recibo();
            cliente.MostrarC();
            plazos.plazo();
            empleado.DatosE();
            Console.WriteLine("--- GRACIAS POR SU COMPRA ---");
            Console.WriteLine("--- VUELVA PRONTO ---");
            Console.ReadLine();


        }

    }


    class TipoInmueble
    {
        public string tipo;
    }

    abstract class Persona
    {
        public string nombre;
        public string apellido;
        public int telefono;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }   
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }

    class Cliente : Persona
    {
        
        public string duiC;

        public void MostrarC()
        {
            Console.WriteLine("*** DATOS CLIENTE ***");
            Console.WriteLine("Nombre: " + nombre +
                              "\nApellido: " + apellido +
                              "\nTelefono: " + telefono +
                              "\nDui: " + duiC);
            Console.WriteLine("\n");
        }

    }

    abstract class Emple
    {
        public string nombreE;
        public string apellidoE;
        public int telefonoE;

        public string Nombre
        {
            get { return nombreE; }
            set { nombreE = value; }
        }

        public string Apellido
        {
            get { return apellidoE; }
            set { apellidoE = value; }
        }

        public int Telefono
        {
            get { return telefonoE; }
            set { telefonoE = value; }
        }


    }

    class Empleado : Emple
    {
        public string idE;

        public void DatosE()
        {
            Console.WriteLine("*** DATOS Empleado ***");
            Console.WriteLine("Nombre: " + nombreE +  "\nApellido: " + apellidoE +  "\nTelefono: " + telefonoE + "\nidE: " + idE);
            Console.WriteLine("\n");
        }
    }

    class Plazos
    {
        public int meses;

        public void plazo()
        {
            Console.WriteLine("*** CUOTAS ***");
            Console.WriteLine("Usted ha escogida realizar el pago del total en: " + meses + " cuotas");
            Console.WriteLine("Recuerde que 1 cuota, es equivalente a un mes, y de retrasarse en el pago de estas" +
                              " debera cancelar intereses extras. \n");
        }
    }

    class Inmueble : TipoInmueble
    {
        public int opcion;

        public void Recibo()
        {
            Console.WriteLine(" ----- DATOS RECIBO ----- ");
            if (opcion == 1)
            {
                tipo = "Casa";
                Console.WriteLine("El tipo de inmueble que selecciono es: " + tipo);
                Console.WriteLine("Descripcion: ");
                Console.WriteLine("casa de 5 habitaciones , 2 Baños, sala, comedor ,cocina, mil metros cuadrados \n");

            }
            if (opcion == 2)
            {
                tipo = "Carro";
                Console.WriteLine("El tipo de inmueble que selecciono es: " + tipo);
                Console.WriteLine("Descripcion: ");
                Console.WriteLine("Carro año 2022, color rojo, cuatro puertas , toyota, modelo Hilux \n");
            }
            if (opcion == 3)
            {
                tipo = "Parcela";
                Console.WriteLine("El tipo de inmueble que selecciono es: " + tipo);
                Console.WriteLine("Descripcion: ");
                Console.WriteLine("Porcion de terreno de 1000 varas cuadradas \n");
            }
            if (opcion == 4)
            {
                tipo = "Fabrica";
                Console.WriteLine("El tipo de inmueble que selecciono es: " + tipo);
                Console.WriteLine("Descripcion: ");
                Console.WriteLine("Maquila con una extencion de terreno de 5 manzanas de terreno \n");
            }
        }

    }
}
