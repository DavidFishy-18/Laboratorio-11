using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio__11
{
    public class Alumnos
    {
        string nC;
        string nombre;
        string dir;
        string fn;
        List<Curso> c;

        public string NC { get => nC; set => nC = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dir { get => dir; set => dir = value; }
        public List<Curso> C { get => c; set => c = value; }
        public string Fn { get => fn; set => fn = value; }

        public Alumnos()
        {
            c = new List<Curso>();
        }
    }
}