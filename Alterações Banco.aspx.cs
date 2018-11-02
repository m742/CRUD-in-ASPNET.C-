using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page
{

    string constr = ConfigurationManager.ConnectionStrings["conn_chamadosti"].ConnectionString;
  

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!this.IsPostBack)
        {



            

        }






    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Tela_Banco.aspx");

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        ChamaInsert();
    }


    
    


    protected void ChamaInsert()
    {
        

        if (Page.IsValid)
             {
                
                 string sql =  "INSERT INTO usuarios (USUA_LOGIN,USUA_NOME,USUA_PASSWORD) VALUES (@USUA_LOGIN,@USUA_NOME,@USUA_PASSWORD)";



                 MySqlConnection conn = new MySqlConnection(constr);
                 MySqlCommand cmd = new MySqlCommand(sql, conn);
                 cmd.CommandType = CommandType.Text;
                 cmd.Parameters.AddWithValue("@USUA_LOGIN", Login.Text);
                 cmd.Parameters.AddWithValue("@USUA_NOME", Nome.Text);
                 cmd.Parameters.AddWithValue("@USUA_PASSWORD", Senha.Text);
                


            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Login.Text = String.Empty;
                Nome.Text = String.Empty;
                Senha.Text = String.Empty;
                
               
            }
            catch (Exception ex)
            {
               

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Tela_Delete.aspx");
        
    }
}
