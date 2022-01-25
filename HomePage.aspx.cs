using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIGDATAUIT
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = "Server=tcp:uittoptop.database.windows.net,1433;Initial Catalog=toptop;Persist Security Info=False;User ID=toptop;Password=0917787421qQ@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            sql = "Select * from BigDataNumber ORDER BY ID DESC";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                var numb = command.ExecuteScalar();
                this.number.Text = numb.ToString();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}