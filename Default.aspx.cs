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
            
            
        }

        private void leer()
        {

        }
    }
}