using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class clsDatos
    {
    }

    public class persona
    {
         int id;
        string nombre;
        string apellido;
        DateTime Fecha_nacimiento;
        string direccion;
        string genero;
        string estado_civil;
        string movil;
        string telefono;
        string correo_electronico;

        public persona(int id, string nombre, string apellido, DateTime fecha_nacimiento, string direccion, string genero, string estado_civil, string movil, string telefono, string correo_electronico)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            Fecha_nacimiento = fecha_nacimiento;
            this.direccion= direccion;
            this.genero = genero;
            this.estado_civil = estado_civil;
            this.movil = movil;
            this.telefono = telefono;
            this.correo_electronico = correo_electronico;
        }


        public persona()
        {
 
        }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Fecha_nacimiento1 { get => Fecha_nacimiento; set => Fecha_nacimiento = value; }

        public string Direccion { get => direccion; set => direccion = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Estado_civil { get => estado_civil; set => estado_civil = value; }
        public string Movil { get => movil; set => movil = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo_electronico { get => correo_electronico; set => correo_electronico = value; }
    }
}
