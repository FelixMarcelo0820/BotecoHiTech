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
    public partial class Alterar : Form
    {
        public Alterar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection cone = new SqlConnection(@"Data Source=DESKTOP-VBS613M\MSSQLSERVER01;Initial Catalog=Buteco;Integrated Security=True");

            SqlCommand comando = new SqlCommand("Update Usuarios set nome=@nome, usuario=@usuario, senha=@senha, endereco=@endereco, email=@email, telefone=@telefone, cpf=@cpf where ID=@ID", cone);

            comando.Parameters.Add("@ID", SqlDbType.VarChar).Value = txtID.Text;

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;

            comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtUsuario.Text;

            comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenha.Text;

            comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtEndereco.Text;

            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;

            comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTelefone.Text;

            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtCpf.Text;

            try
            {

                cone.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Alteração dos valores do ID = " + txtID.Text + " Efetuado com sucesso!");

            }catch(Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
            finally{

                cone.Close();
            
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(@"Data Source=DESKTOP-VBS613M\MSSQLSERVER01;Initial Catalog=Buteco;Integrated Security=True");

            SqlCommand comando = new SqlCommand("delete from Usuarios where ID=@ID", cone);

            comando.Parameters.Add("@ID", SqlDbType.Int).Value = txtID.Text;

            try
            {

                cone.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario deletado");
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
    }
}
