using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Mensaje
    {
        public Mensaje()
        {
        }

        public Mensaje(string texto, bool esRobot)
        {
            this.texto = texto;
            this.esRobot = esRobot;
        }



        public string texto { get; set; }

        public bool esRobot { get; set; }

        public string Imagen { get; set; }

        public override string ToString()
        {
            if (esRobot)
                return "Robot \n" + texto;
            else
                return "Usuario \n" + texto;
        }
    }
}
