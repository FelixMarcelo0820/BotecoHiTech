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
using BotecoHitech.lib.Views.Produto;
using BotecoHitech.lib.Views.Fornecedor;
#pragma warning disable 0649

namespace BotecoHitech
{
    public partial class Boteco : Form
    {
        public Boteco()
        {
            InitializeComponent();
        }

        

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvPesquisa.Controls.Clear();
            Signin sigFrm = new Signin();
            sigFrm.TopLevel = false;
            dgvPesquisa.Controls.Add(sigFrm);
            sigFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sigFrm.Dock = DockStyle.Fill;
            sigFrm.Show();

            
        }

        private void Boteco_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                var resultado = MessageBox.Show(this,"Você deseja realmente sair?","Confirmação", MessageBoxButtons.YesNo);
                if (resultado != DialogResult.Yes)
                {

                    e.Cancel = true;

                }

            }
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dgvPesquisa.Controls.Clear();
            Pesquisa psqFrm = new Pesquisa();
            psqFrm.TopLevel = false;
            dgvPesquisa.Controls.Add(psqFrm);
            psqFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            psqFrm.Dock = DockStyle.Fill;
            psqFrm.Show();
        }

        private void Boteco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) 
            {

                this.Close();

            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este sistema foi projetado para auxiliar na gestão de um Boteco!\nAutor:Marcelo Felix\nDisciplina:LP2A4\nData: 9/2020\n" +
                "Contato: marcelo06silva@hotmail.com\nCópias somente com autorização!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvPesquisa.Controls.Clear();
            Alterar altFrm = new Alterar();
            altFrm.TopLevel = false;
            dgvPesquisa.Controls.Add(altFrm);
            altFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            altFrm.Dock = DockStyle.Fill;
            altFrm.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dgvPesquisa.Controls.Clear();
            Cadastrar_Produto cadFrm = new Cadastrar_Produto();
            cadFrm.TopLevel = false;
            dgvPesquisa.Controls.Add(cadFrm);
            cadFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cadFrm.Dock = DockStyle.Fill;
            cadFrm.Show();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dgvPesquisa.Controls.Clear();
            Alterar_Produto alt2frm = new Alterar_Produto();
            alt2frm.TopLevel = false;
            dgvPesquisa.Controls.Add(alt2frm);
            alt2frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            alt2frm.Dock = DockStyle.Fill;
            alt2frm.Show();
        }

        private void visualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dgvPesquisa.Controls.Clear();
            Pesquisar_produto pesq2frm = new Pesquisar_produto();
            pesq2frm.TopLevel = false;
            dgvPesquisa.Controls.Add(pesq2frm);
            pesq2frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pesq2frm.Dock = DockStyle.Fill;
            pesq2frm.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvPesquisa.Controls.Clear();
            CadastrarFornecedor cad2Frm = new CadastrarFornecedor();
            cad2Frm.TopLevel = false;
            dgvPesquisa.Controls.Add(cad2Frm);
            cad2Frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cad2Frm.Dock = DockStyle.Fill;
            cad2Frm.Show();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvPesquisa.Controls.Clear();
            AlterarFornecedor alt3Frm = new AlterarFornecedor();
            alt3Frm.TopLevel = false;
            dgvPesquisa.Controls.Add(alt3Frm);
            alt3Frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            alt3Frm.Dock = DockStyle.Fill;
            alt3Frm.Show();
        }

        private void visualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvPesquisa.Controls.Clear();
            PesquisarFornecedor pesq3Frm = new PesquisarFornecedor();
            pesq3Frm.TopLevel = false;
            dgvPesquisa.Controls.Add(pesq3Frm);
            pesq3Frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pesq3Frm.Dock = DockStyle.Fill;
            pesq3Frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void relatórioDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvPesquisa.Controls.Clear();
            Relatorio impfrm = new Relatorio();
            impfrm.TopLevel = false;
            dgvPesquisa.Controls.Add(impfrm);
            impfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            impfrm.Dock = DockStyle.Fill;
            impfrm.Show();
        }

        private void relatórioDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvPesquisa.Controls.Clear();
            RelatorioF imp2frm = new RelatorioF();
            imp2frm.TopLevel = false;
            dgvPesquisa.Controls.Add(imp2frm);
            imp2frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            imp2frm.Dock = DockStyle.Fill;
            imp2frm.Show();
        }
    }
    }

