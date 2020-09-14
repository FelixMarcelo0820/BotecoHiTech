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
using System.Threading;

namespace BotecoHitech
{
    public partial class Signin : Form
    {

        Thread t3;
        public Signin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            SqlConnection cone = new SqlConnection(@"Data Source=DESKTOP-VBS613M\MSSQLSERVER01;Initial Catalog=Buteco;Integrated Security=True");

            SqlCommand comando = new SqlCommand("INSERT INTO Usuarios(nome,usuario,senha,endereco,email,telefone,cpf) values(@nome,@usuario,@senha,@endereco,@email,@telefone,@cpf)", cone);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;

            comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtUser.Text;

            comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenha.Text;

            comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtEndereco.Text;

            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;

            comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = mskdTel.Text;

            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = mskdCpf.Text;

            try
            {

                cone.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!, :D");

            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {

                cone.Close();

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            this.Close();
            t3 = new Thread(abrirJanela1);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }

        private void abrirJanela1(object obj)
        {

            Application.Run(new Login());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtNome.ResetText();
            txtUser.ResetText();
            txtSenha.ResetText();
            txtEndereco.ResetText();
            txtEmail.ResetText();
            mskdTel.ResetText();
            mskdCpf.ResetText();
            txtNome.Focus();
        }
    }
    }
