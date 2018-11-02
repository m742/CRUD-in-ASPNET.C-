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
        if (!this.IsPostBack)
        {
            this.BindGrid(); // executa a função BindGrid
            MultiView1.ActiveViewIndex = 0; // redireciona para a multiview = 0


        }



    }



    private void BindGrid()
    {

        // parte do codigo exclusiva para criação da gridview e população dela com o datareader

        using (MySqlConnection con = new MySqlConnection(constr))
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT USUA_LOGIN, USUA_NOME, IF (USUA_STATUS = 1,'Ativo','Inativo')  USUA_STATUS  , USUA_CODIGO FROM usuarios "))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }

    }


    protected void ChamaInsert1()
    {



        // função de chamada insert do banco de dados

        string sql = "INSERT INTO usuarios (USUA_LOGIN,USUA_NOME,USUA_STATUS) VALUES (@USUA_LOGIN,@USUA_NOME,@USUA_STATUS)";



        MySqlConnection conn = new MySqlConnection(constr);
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.CommandType = CommandType.Text;
        int valor = int.Parse(DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@USUA_LOGIN", txtlogin.Text);
        cmd.Parameters.AddWithValue("@USUA_NOME", txtnome.Text);
        cmd.Parameters.AddWithValue("@USUA_STATUS", valor);



        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox2.ShowMessage("Salvo com Sucesso");




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



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["teste"] = GridView1.SelectedValue; // dentro da opção datakey value na gridview, tem setado o valor da chave primaria e cada clique e mudança de tela ira receber o valor da chave primaria correspondente
        MultiView1.ActiveViewIndex = 1;
        // essa função determina as ações que vão ser realizadas após click dentro da gridview
        MySqlConnection con = new MySqlConnection(constr); // cria uma string para conexão



        string sql6 = "SELECT USUA_LOGIN, USUA_NOME, USUA_STATUS FROM usuarios WHERE USUA_CODIGO =@USUA_CODIGO"; // campos que vão
        // aparecer na janela com a multiview 1

        MySqlCommand cmd = new MySqlCommand(sql6, con); // cria um commando do tipo MySqlCommand
        
        cmd.Parameters.AddWithValue("@USUA_CODIGO", Session["teste"]); // passagem de parametro da chave para o @USUA_CODIGO
        
         

        try
        {
            con.Open(); //  abre a conexão
            MySqlDataReader reader = cmd.ExecuteReader(); // executa o comando do MySqlCommand
           
           

            if (reader.Read()) // se for executado o datareader faça
            {
                txtlogin.Text = reader["USUA_LOGIN"].ToString(); // cada campo .Text vai receber essa informação do campo do banco
                txtnome.Text = reader["USUA_NOME"].ToString();
                

            }

            reader.Close(); // encerra a execução do comando

            
        }
        catch (MySqlException ex)
        {
           
        }
        finally
        {
            con.Close();

        }

    }


    protected void ChamaUpdate1()
    {
        string sql2 = "UPDATE usuarios SET USUA_LOGIN = @USUA_LOGIN, USUA_NOME = @USUA_NOME, USUA_STATUS = @USUA_STATUS WHERE USUA_CODIGO = @USUA_CODIGO";



        // faz a opção update do banco de dados

        MySqlConnection conn = new MySqlConnection(constr);
        MySqlCommand cmd = new MySqlCommand(sql2, conn);
        cmd.CommandType = CommandType.Text;
        int valor = int.Parse(DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@USUA_LOGIN", txtlogin.Text);
        cmd.Parameters.AddWithValue("@USUA_NOME", txtnome.Text);
        cmd.Parameters.AddWithValue("@USUA_STATUS", valor);
        cmd.Parameters.AddWithValue("@USUA_CODIGO", Session["teste"]);
       




        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();


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




    protected void ButtonNovo_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        Session["teste"] = "0"; // ação ao clicar no botão novo, cria a session e a  preenche com 0
        txtlogin.Text = String.Empty; // ao clicar no novo, ele limpa o conteudo dos campos que foram preenchidos no botão editar, caracteristica do field
        txtnome.Text = String.Empty; // ao clicar no novo, ele limpa o conteudo dos campos que foram preenchidos no botão editar, caracteristica do field


    }
    protected void ButtonSave_Click(object sender, EventArgs e)
    {

        if (Session["teste"] != "0") // se a session for diferente de 0 ele vai fazer o update
        {
            ChamaUpdate1();
            MessageBox2.ShowMessage("Salvo com Sucesso");
           
        }
        else // caso não ele irá fazer o insert
        {
            ChamaInsert1();
        }

        
       
        // ação do botão salvar da multiview 1
        

    }

    private void ChamaDelete()
    {

        // criação do comando delete

        string sql1 = "DELETE FROM usuarios WHERE USUA_CODIGO = @USUA_CODIGO";
        MySqlConnection conn = new MySqlConnection(constr);
        MySqlCommand cmd = new MySqlCommand(sql1, conn);
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@USUA_CODIGO", Session["teste"]);

        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox2.ShowMessage("USUARIO Excluido com sucesso");
            


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
        MultiView1.ActiveViewIndex = 0;
        // ação do botão voltar da mmultiview 1
        this.BindGrid(); // executa novamente a função bindgrid para efetuar a atualização da tela
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ChamaDelete();
        // chamada do botão delete
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        BindGrid();
        GridView1.PageIndex = e.NewPageIndex; // trata a paginação da grid, é essencial essa função para a tratativa
        GridView1.DataBind();
        

    }

   
}



















