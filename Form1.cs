using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImportaDados.Bll;

namespace ImportaDados
{
    public partial class Form1 : Form
    {
        PassagemBll objPassagemBll = new PassagemBll();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private string caminho;

        private void FormataGrid()
        {
            try
            {
                dgvDados.Columns[0].HeaderText = "Placa";
                dgvDados.Columns[0].Width = 60;
                dgvDados.Columns[1].HeaderText = "Data";
                dgvDados.Columns[1].Width = 90;
                dgvDados.Columns[2].HeaderText = "Hora";
                dgvDados.Columns[2].Width = 90;
                dgvDados.Columns[3].HeaderText = "Equipamento";
                dgvDados.Columns[3].Width = 90;
                dgvDados.Columns[4].HeaderText = "Faixa";
                dgvDados.Columns[4].Width = 90;
            }
            catch
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados.");
            }
        }
        private void AtualizaGrid()
        {
            try
            {
                dgvDados.DataSource = objPassagemBll.lista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados.");
            }
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.caminho = fbd.SelectedPath.ToString();
                MessageBox.Show("Diretório selecionado.");
                btnImportaDados.Enabled = true;
            }
            else { MessageBox.Show("Selecione um diretório."); }
        }
                
        private void btnImportaDados_Click(object sender, EventArgs e)
        {
            try
            {
                objPassagemBll.ImportaDados(this.caminho);
                MessageBox.Show("Dados importados com sucesso.");
            }
            catch
            {
                MessageBox.Show(objPassagemBll.Mensagem);
            }
        }

        private void btnListaDados_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
    }
}
