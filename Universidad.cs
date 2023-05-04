using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio__11
{
    public class Universidad
    {
        string uni;
        List<Alumnos> al;

        public string Uni { get => uni; set => uni = value; }
        public List<Alumnos> Al { get => al; set => al = value; }

        public Universidad()
        {
            al = new List<Alumnos>();
        }
    }
}