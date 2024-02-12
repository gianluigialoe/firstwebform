using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstwebform
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 6);

            // Costruisci la chiave corrispondente al numero casuale
            string key = "name and sunrma" + randomNumber;

            // Ottieni il valore dalla configurazione
            string randomName = ConfigurationManager.AppSettings[key];

            // Imposta il testo della Label con il nome casuale
            Label1.Text = "Ciao " + randomName;
        }
    }
}