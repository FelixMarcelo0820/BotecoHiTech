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
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 

           SqlConnection cone = new SqlConnection(@"Data Source=DESKTOP-VBS613M\MSSQLSERVER01;Initial Catalog=Buteco;Integrated Security=True");

                SqlDataAdapter comando = new SqlDataAdapter("Select * from Usuarios where nome Like '%" + txtPesquisa.Text + "%'", cone);

                DataTable tabela = new DataTable();

           comando.Fill(tabela);

           tabela.Columns[0].ColumnName = "ID";

           tabela.Columns[1].ColumnName = "nome";

           tabela.Columns[2].ColumnName = "usuario";

           tabela.Columns[3].ColumnName = "senha";

           tabela.Columns[4].ColumnName = "endereco";

           tabela.Columns[5].ColumnName = "email";

           tabela.Columns[6].ColumnName = "telefone";

           tabela.Columns[7].ColumnName = "cpf";

           dgvPesquisa.DataSource = tabela;

           }
           catch(Exception ex)
           {

               MessageBox.Show(ex.Message);

           }
        }

        private void dgvPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {

        }
    }
}
