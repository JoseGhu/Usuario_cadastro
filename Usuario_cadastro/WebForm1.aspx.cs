using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Usuario_cadastro
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        SqlConnection Con = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            Con.ConnectionString = "Data Source=DESKTOP-97I2A2E;Initial Catalog=TB_usuario;Integrated Security=True";
            Con.Open();
            if (!IsPostBack)
            {
                DataShow();
            }
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            Cmd.CommandText = "Insert into TB_usuario (id,nome,Telefone,CPF)values('" + TextBox1.Text.ToString() + "','" + TxtNome.Text.ToString() + "','" + TxtTelefone.Text.ToString() + "','" + TxtCpf.ToString() + "')";
            Cmd.Connection = Con;
            Cmd.ExecuteNonQuery();
            DataShow();
            
        }
        public void DataShow()
        {
            ds = new DataSet();
            Cmd.CommandText = "Select *From TB_usuario";
            Cmd.Connection = Con;
            sda = new SqlDataAdapter(Cmd);
            sda.Fill(ds);
            Cmd.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Con.Close();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            Cmd.CommandText = "Update TB_Usuario set nome='"+TxtNome.Text.ToString()+"',Telefone='"+TxtTelefone.Text.ToString()+"'where id='"+TextBox1.Text.ToString()+"'";
            Cmd.Connection = Con;
            Cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            Cmd.CommandText = "Delete from TB_usuario where id= '" + TextBox1.Text.ToString() + "'";
            Cmd.Connection = Con;
            Cmd.ExecuteNonQuery();
            DataShow();
        }
    }
}