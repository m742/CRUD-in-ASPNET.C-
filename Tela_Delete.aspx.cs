using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class _Default : System.Web.UI.Page
{
    string constr = ConfigurationManager.ConnectionStrings["conn_chamadosti"].ConnectionString;
  
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ChamaDelete()
    {


        string sql1 = "DELETE FROM usuarios WHERE USUA_LOGIN = @USUA_LOGIN";
        MySqlConnection conn = new MySqlConnection(constr);
        MySqlCommand cmd = new MySqlCommand(sql1, conn);
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@USUA_LOGIN", TextBox1.Text);

        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox1.ShowMessage("USUARIO Excluido com sucesso");
           

        }
        catch (Exception e)
        {

        }
        finally
        {
            conn.Close();
            conn.Dispose();
            
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ChamaDelete();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}