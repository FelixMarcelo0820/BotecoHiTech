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
    public partial class Login : Form
    {
        Thread t1;
        Thread t2;

        public Login()
        {
            InitializeComponent();
            txtUsername.Select();
            
        }

        void Verificar()
        {

            if (txtUsername.Text == "" && txtPassword.Text == "")
            {


                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Select();

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"usuario \ email"))
            {

                txtUsername.Text = "";

            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {

                txtUsername.Text = @"usuario \ email";

            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"senha"))
            {

                txtUsername.Text = "";

            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {

                txtUsername.Text = @"senha";

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VBS613M\MSSQLSERVER01;Initial Catalog=Buteco;Integrated Security=True");
            con.Open();
            SqlCommand CMD = new SqlCommand("Select * from Usuarios where usuario = '" + txtUsername.Text + "' AND senha = '" + txtPassword.Text + "'",con);
            SqlDataReader dr;
            dr = CMD.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {

                count += 1;
            }
            if (count == 1)
            {

                this.Close();
                t2 = new Thread(abrirJanela2);
                t2.SetApartmentState(ApartmentState.STA);
                t2.Start();
                con.Close();

            }else if(count >0){

                MessageBox.Show("Usuario e senha duplicado");

            }
            else
            {
                MessageBox.Show("Usuario e senha errado");

            }

           

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {

            this.Close();
            t1 = new Thread(abrirJanela1);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void abrirJanela1(object obj)
        {

            Application.Run(new Signin());
        }
        private void abrirJanela2(object obj)
        {

            Application.Run(new Boteco());
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
