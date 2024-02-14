using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _14FebbraioEs
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Database"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            

            try
            {
                conn.Open();
                SqlCommand cmdInsert = new SqlCommand($"INSERT INTO TABELLA(Nome, Cognome, Sala, TipoBiglietto) VALUES(@Nome, @Cognome, @Sala, @TipoBiglietto)", conn);
                cmdInsert.Parameters.AddWithValue("@Nome", Nome.Text);
                cmdInsert.Parameters.AddWithValue("@Cognome", Cognome.Text);
                cmdInsert.Parameters.AddWithValue("@Sala", SalaDropDown.Text);
                cmdInsert.Parameters.AddWithValue("@TipoBiglietto", BigliettoDropDown.Text);



                int affetctedRow =cmdInsert.ExecuteNonQuery();

                if ( affetctedRow != 0 )
                {
                    Response.Write("Ok");
                }
            }
            catch
            {
                Response.Write("Not ok");
            }
            finally { conn.Close(); }
        }
    }
}