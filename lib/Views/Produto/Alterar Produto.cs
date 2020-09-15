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
    public partial class Alterar_Produto : Form
    {
        public Alterar_Produto()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(@"Data Source=DESKTOP-VBS613M\MSSQLSERVER01;Initial Catalog=Buteco;Integrated Security=True");

            SqlCommand comando = new SqlCommand("update Produto set nome=@nome, valor=@valor, Descricao=@Descricao, Quantidade=@Quantidade, Categoria=@Categoria where ID=@ID", cone);

            comando.Parameters.Add("@ID", SqlDbType.VarChar).Value = txtID.Text;

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;

            comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = txtValor.Text;

            comando.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = txtDescricao.Text;

            comando.Parameters.Add("@Quantidade", SqlDbType.VarChar).Value = txtQuantidade.Text;

            comando.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = cbCategoria.Text;


            try
            {

                cone.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Alteração dos valores do ID = " + txtID.Text + " Efetuado com sucesso!");

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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(@"Data Source=DESKTOP-VBS613M\MSSQLSERVER01;Initial Catalog=Buteco;Integrated Security=True");

            SqlCommand comando = new SqlCommand("delete from Produto where ID=@ID", cone);

            comando.Parameters.Add("@ID", SqlDbType.Int).Value = txtID.Text;

            try
            {

                cone.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto deletado");
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

        private void button3_Click(object sender, EventArgs e)
        {
            txtNome.ResetText();
            txtDescricao.ResetText();
            txtQuantidade.ResetText();
            txtValor.ResetText();
            cbCategoria.Text = "Selecione...";
            txtNome.Focus();
        }
    }
}
