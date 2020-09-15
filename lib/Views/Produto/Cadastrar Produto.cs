using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BotecoHitech
{
    public partial class Cadastrar_Produto : Form
    {
        public Cadastrar_Produto()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.ResetText();
            txtDescricao.ResetText();
            txtQuantidade.ResetText();
            txtValor.ResetText();
            cbCategoria.Text = "Selecione...";           
            txtNome.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(@"Data Source=DESKTOP-VBS613M\MSSQLSERVER01;Initial Catalog=Buteco;Integrated Security=True");

            SqlCommand comando = new SqlCommand("INSERT INTO Produto(nome,valor,Descricao,Quantidade,Categoria) values(@nome,@valor,@Descricao,@Quantidade,@Categoria)", cone);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;

            comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = txtValor.Text;

            comando.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = txtDescricao.Text;

            comando.Parameters.Add("@Quantidade", SqlDbType.VarChar).Value = txtQuantidade.Text;

            comando.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = cbCategoria.Text;

            

            try
            {

                cone.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!, :D");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {

                cone.Close();

            }
        }
    }
}
