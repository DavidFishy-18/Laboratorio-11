using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebGrease.Activities;

namespace Laboratorio__11
{
    public partial class _Default : Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Curso c = new Curso();

            c.Nombre = TextBox5.Text;
            c.Nota = Convert.ToInt32(TextBox6.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<Universidad> u = new List<Universidad>();

            u = Leer();

            if (u == null) u = new List<Universidad>();

            Universidad uni = u.Find(a => a.Uni == DropDownList1.SelectedValue);

            if (uni == null)
            {
                Universidad uniN = new Universidad();

                uniN.Uni = DropDownList1.SelectedValue;

                Alumnos al = new Alumnos();
                al.NC = TextBox1.Text;
                al.Nombre = TextBox2.Text;
                al.Dir = TextBox3.Text;
                al.Fn = TextBox4.Text;

                Curso cu = new Curso();
                cu.Nombre = TextBox5.Text;
                cu.Nota = Convert.ToInt32(TextBox6.Text);

                al.C.Add(cu);

                uniN.Al.Add(al);
                u.Add(uniN);
            }
            else
            {
                int aux = 0; bool bl = true;
                for(int i = 0; i < u.Count && bl; i++)
                {
                    if (DropDownList1.SelectedValue.Equals(u[i].Uni)) { aux = i; bl = false; }
                }

                Alumnos al = new Alumnos();
                al.NC = TextBox1.Text;
                al.Nombre = TextBox2.Text;
                al.Dir = TextBox3.Text;
                al.Fn = TextBox4.Text;

                Curso cu = new Curso();
                cu.Nombre = TextBox5.Text;
                cu.Nota = Convert.ToInt32(TextBox6.Text);

                al.C.Add(cu);
                u[aux].Al.Add(al);
            }

            Grabar(u);
        }

        private List<Universidad> Leer()
        {
            List<Universidad> lista = new List<Universidad>();
            string archivo = Server.MapPath("Datos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            lista = JsonConvert.DeserializeObject<List<Universidad>>(json);

            return lista;
        }

        private void Grabar(List<Universidad> u)
        {
            string json = JsonConvert.SerializeObject(u);
            string archivo = Server.MapPath("Datos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
    }
}