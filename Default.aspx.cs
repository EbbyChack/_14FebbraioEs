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
            string connectionString = ConfigurationManager.ConnectionStrings["Database"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                //stampare
                SqlCommand cmdSelect = new SqlCommand("SELECT Sala, TipoBiglietto, COUNT(*) AS Num FROM Tabella group by sala, TipoBiglietto", conn);
                SqlDataReader rdr = cmdSelect.ExecuteReader();

                string displayData = "";
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        displayData +=  $"<li>Sala: {rdr["Sala"]}, Tipo biglietto: {rdr["TipoBiglietto"]}, Quantità {rdr["Num"]}</li>" ;
                    }
                    prenotazioni.InnerHtml = displayData;
                }

            }
            catch
            {
                Response.Write("Not ok2");
            }
            finally { conn.Close(); }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Database"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);



            try
            {
                conn.Open();
                //per inserire 
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO TABELLA(Nome, Cognome, Sala, TipoBiglietto) VALUES(@Nome, @Cognome, @Sala, @TipoBiglietto)", conn);
                cmdInsert.Parameters.AddWithValue("@Nome", Nome.Text);
                cmdInsert.Parameters.AddWithValue("@Cognome", Cognome.Text);
                cmdInsert.Parameters.AddWithValue("@Sala", SalaDropDown.Text);
                cmdInsert.Parameters.AddWithValue("@TipoBiglietto", BigliettoDropDown.Text);



                int affetctedRow = cmdInsert.ExecuteNonQuery();

                


            }
            catch
            {
                Response.Write("Not ok");
            }
            finally { conn.Close(); }
            try
            {
                conn.Open();

                //stampare
                SqlCommand cmdSelect = new SqlCommand("SELECT Sala, TipoBiglietto, COUNT(*) AS Num FROM Tabella group by sala, TipoBiglietto", conn);
                SqlDataReader rdr = cmdSelect.ExecuteReader();

                string displayData = "";
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        displayData += $"<li>Sala: {rdr["Sala"]}, Tipo biglietto: {rdr["TipoBiglietto"]}, Quantità {rdr["Num"]}</li>";
                    }
                    prenotazioni.InnerHtml = displayData;
                }

            }
            catch
            {
                Response.Write("Not ok2");
            }
            finally { conn.Close(); }
        }
        protected void SubmitButton_Click2(object sender, EventArgs e)
        {
            
        }
    }



}