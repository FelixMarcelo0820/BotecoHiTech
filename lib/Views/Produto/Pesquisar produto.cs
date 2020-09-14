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
    public partial class Pesquisar_produto : Form
    {
        public Pesquisar_produto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cone = new SqlConnection(@"Data Source=DESKTOP-VBS613M\MSSQLSERVER01;Initial Catalog=Buteco;Integrated Security=True");

                SqlDataAdapter comando = new SqlDataAdapter("select * from Produto ORDER BY nome", cone);

                DataTable tabela = new DataTable();

                comando.Fill(tabela);

                tabela.Columns[0].ColumnName = "ID";

                tabela.Columns[1].ColumnName = "nome";

                tabela.Columns[2].ColumnName = "valor";

                tabela.Columns[3].ColumnName = "Descricao";

                tabela.Columns[4].ColumnName = "Quantidade";

                tabela.Columns[5].ColumnName = "Categoria";


                dgvPesquisa.DataSource = tabela;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void dgvPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
