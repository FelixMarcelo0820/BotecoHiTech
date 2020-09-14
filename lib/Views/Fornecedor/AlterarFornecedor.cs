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
    public partial class AlterarFornecedor : Form
    {
        public AlterarFornecedor()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(@"Data Source=DESKTOP-VBS613M\MSSQLSERVER01;Initial Catalog=Buteco;Integrated Security=True");

            SqlCommand comando = new SqlCommand("update Fornecedor set nome=@nome,CNPJ=@CNPJ,Endereco=@Endereco,Tipo=@Tipo,Telefone=@Telefone where ID=@ID", cone);

            comando.Parameters.Add("@ID", SqlDbType.VarChar).Value = txtID.Text;

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;

            comando.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = mskdCNPJ.Text;

            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;

            comando.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = cbTipoFornecedor.Text;

            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = mskdTelefone.Text;


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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(@"Data Source=DESKTOP-VBS613M\MSSQLSERVER01;Initial Catalog=Buteco;Integrated Security=True");

            SqlCommand comando = new SqlCommand("delete from Fornecedor where ID=@ID", cone);

            comando.Parameters.Add("@ID", SqlDbType.Int).Value = txtID.Text;

            try
            {

                cone.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Fornecedor deletado");
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.ResetText();
            mskdCNPJ.ResetText();
            txtEndereco.ResetText();
            cbTipoFornecedor.ResetText();
            mskdTelefone.Text = "Selecione...";
            txtNome.Focus();
        }
    }
}
