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
    public partial class MostrarDatos : System.Web.UI.Page
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

            if (uu != null) { Label1.Text = uu.Uni; Response.Write("<script>alert('Universidad encontrada')</script>"); Button2.Enabled = true; }
            else { Label1.Text = "No existe"; Response.Write("<script>alert('No existe')</script>"); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string u = Label1.Text; List<Universidad> un = Leer();

            //Buscar universidad
            Universidad uu = un.Find(a => a.Uni == u);
            //Eliminar de la lista
            un.Remove(uu);

            Response.Write("<script>alert('Universidad eliminada')</script>");

            Grabar(un);
        }
    }
}