using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio__11
{
    public partial class Actualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Universidad> u = Leer();
            Universidad uu = u.Find(a => a.Uni == TextBox1.Text);

            if(uu != null)
            {
                Response.Write("<script>alert('Universidad encontrada')</script>"); TextBox2.Enabled = true; Button2.Enabled = true;
            }
            else Response.Write("<script>alert('No existe')</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<Universidad> u = Leer();

            for (int i = 0; i < u.Count; i++) if(u[i].Uni.Equals(TextBox1.Text)) {u[i].Uni = TextBox2.Text; i = u.Count; }

            Response.Write("<script>alert('Nombre actualizado correctamente')</script>");

            Grabar(u);
        }
    }
}