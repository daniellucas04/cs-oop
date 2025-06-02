using Aula.Controller;
using Aula.Model;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula.View
{
    public partial class FormLivroPesquisar : Form
    {
        public FormLivroPesquisar()
        {
            InitializeComponent();
        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            FormLivroSalvar form = new FormLivroSalvar();
            form.ShowDialog();

            if (form.atualizar)
            {
                Pesquisar();
            }
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int id = ((Livro)dataGridView1.SelectedRows[0].DataBoundItem).Id;

            FormLivroSalvar f = new FormLivroSalvar(id);
            f.ShowDialog();

            if (f.atualizar)
                Pesquisar();
        }

        private void recortarToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            DialogResult resultado = MessageBox.Show(
                "Deseja realmente excluir o livro selecionado?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    LivroController.Excluir((Livro)dataGridView1.SelectedRows[0].DataBoundItem);
                    MessageBox.Show("Livro excluido com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pesquisar();
                }
                catch (Exception ex) {
                    MessageBox.Show("Não foi possível excluir este livro!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormLivroPesquisar_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        public void Pesquisar()
        {
            //List<Livro> lista = LivroController.Listar();
            List<Livro> lista = LivroController.PesquisarPorTitulo(txtTitulo.Text.Trim());

            dataGridView1.DataSource = lista;
        }
    }
}
