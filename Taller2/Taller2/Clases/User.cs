using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Taller2.Clases
{
    class User
    {
        // nos trae el modelo de datos 
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string correo { get; set; }
        public string pas { get; set; }
    }
}