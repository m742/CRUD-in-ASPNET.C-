using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Web.Security;


public partial class Default2 : System.Web.UI.Page
{


    string constr = ConfigurationManager.ConnectionStrings["conn_chamadosti"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    private bool VerificaLogin(string usuario, string senha)
    {
        
        int retorno = -1; // iniciou a variavel comm -1

        string sql = "SELECT COUNT(*) FROM usuarios where USUA_LOGIN = @USUA_LOGIN AND USUA_PASSWORD = @USUA_PASSWORD";
        // criou uma string com a consulta sql

        MySqlConnection conn = new MySqlConnection(constr);
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.CommandType = CommandType.Text;

        cmd.Parameters.AddWithValue("@USUA_LOGIN", usuario); // passagem de parametros
        cmd.Parameters.AddWithValue("@USUA_PASSWORD", senha); // passagem de parametros

        conn.Open();
        retorno = Convert.ToInt32(cmd.ExecuteScalar()); // converte para inteiro o resultado do meu comando SQL
        conn.Close();
        return retorno > 0; // retorna se é verdadeiro ou falso, devido a função ser booleana

    }





    protected void Button1_Click(object sender, EventArgs e)
    {
        if (VerificaLogin(TextBox1.Text, TextBox2.Text)) // se for verdadeiro executa
        {

            MessageBox1.ShowMessage("Usuario Logado com Sucesso");
            FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, false);
           
        }
        else //  se for falso executa
        {
            MessageBox1.ShowMessage("Usuario Invalido");
            
        }

    }

   








}
















