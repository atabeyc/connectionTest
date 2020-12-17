using FirebirdSql.Data.FirebirdClient;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Connection
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["SQ"].ConnectionString);
        FbConnection fbCon = new FbConnection(ConfigurationManager.ConnectionStrings["FB"].ConnectionString);




        private void sqlOpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                sqlStatusLabel.Text = "SQL Connection is OPEN";
                sqlStatusLabel.ForeColor = Color.Green;
            }
            catch (Exception Ex)
            {
                sqlStatusLabel.ForeColor = Color.Red;
                sqlStatusLabel.Text = "Error " + Ex.Message.ToString();
            }
        }
        private void sqlCloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Close();
                sqlStatusLabel.Text = "SQL Connection is CLOSE";
                sqlStatusLabel.ForeColor = Color.Green;
            }
            catch (Exception Ex)
            {
                sqlStatusLabel.ForeColor = Color.Red;
                sqlStatusLabel.Text = "Error " + Ex.Message.ToString();
            }
        }
        private void firebirdOpenButton_Click(object sender, EventArgs e)
        {
            //************************ALTERNATIVE CONNECTION METHOD*****************************///

            //FbConnectionStringBuilder con = new FbConnectionStringBuilder();
            //con.DataSource = "localhost";
            //con.Port = 3056;
            //con.Database = @"firebird database adress";
            //con.UserID = "firebird login username";
            //con.Password = "firebird login password";
            //con.ServerType = FbServerType.Default;
            //FbConnection fbc = new FbConnection(con.ToString());
            try
            {
                fbCon.Open();
                firebirdStatusLabel.Text = "Firebird Connection is OPEN";
                firebirdStatusLabel.ForeColor = Color.Green;
            }
            catch (Exception Ex)
            {
                firebirdStatusLabel.Text = "!! ERROR " + Ex.Message.ToString();
                firebirdStatusLabel.ForeColor = Color.Red;
            }
        }

        private void firebirdCloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                fbCon.Close();
                firebirdStatusLabel.Text = "Firebird Connection is CLOSE";
                firebirdStatusLabel.ForeColor = Color.Green;
            }
            catch (Exception Ex)
            {
                firebirdStatusLabel.Text = "!! ERROR" + Ex.Message.ToString();
                firebirdStatusLabel.ForeColor = Color.Red;
            }
        }


    }
}
