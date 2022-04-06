using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Herencia
{
    public class Persona
    {
        private string _name;
        private string _apellido;

        /*
        public string Name
        {
            get { return _name; }
            set { 
                _name = value.ToUpper(); // joRge JORGE jorge
            }
        }*/
        public int Edad { get; set; }
        public string Name => $"{_name} {_apellido}";
        public Persona(string name, string ape)
        {
            _name = name;
            _apellido = ape;
        }
    }
}
