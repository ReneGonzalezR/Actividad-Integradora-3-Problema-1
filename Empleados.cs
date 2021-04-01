using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora_3_Problema_1
{
    class Empleados
    {
        private string area;
        private string sueldo;
        private string nombre;

        public Empleados() { }

        public void setArea(string value){ area = value; }
        public string getArea(){ return area; }
        public void setNombre(string value) { nombre = value; }
        public string getNombre() { return nombre; }
        public void setSueldo(string value) { sueldo = value; }
        public string getSueldo() { return sueldo; }
    }
}
