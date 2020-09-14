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
    public partial class CadastrarFornecedor : Form
    {
        public CadastrarFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(@"Data Source=DESKTOP-VBS613M\MSSQLSERVER01;Initial Catalog=Buteco;Integrated Security=True");

            SqlCommand comando = new SqlCommand("INSERT INTO Fornecedor(nome,CNPJ,Endereco,Tipo,Telefone) values(@nome,@CNPJ,@Endereco,@Tipo,@Telefone)", cone);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;

            comando.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = mskdCNPJ.Text;

            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;

            comando.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = cbTipoFornecedor.Text;

            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = mskdTelefone.Text;



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
