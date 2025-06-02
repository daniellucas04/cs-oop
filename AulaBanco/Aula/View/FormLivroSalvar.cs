using Aula.Controller;
using Aula.Model;
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
    public partial class FormLivroSalvar : Form
    {
        public bool atualizar = false;
        private int? id = null;
        public bool salvar { get; set; }
        

        public FormLivroSalvar(int? _id = null)
        {
            InitializeComponent();
            id = _id;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtTitulo.Text.Trim() == "")
                errorProvider1.SetError(txtTitulo, "O titulo do livro é obrigatório");

            if (txtDataPublicacao.Value.Date > DateTime.Today)
                errorProvider1.SetError(txtDataPublicacao, "A data de publicação deve ser uma data inferior ou igual a data atual");

            if (!errorProvider1.HasErrors)
            {
                Livro livro = new Livro();
                livro.Titulo = txtTitulo.Text.Trim();
                livro.DataPublicacao = txtDataPublicacao.Value;

                try
                {
                    if (id == null)
                    {
                        LivroController.Salvar(livro);
                    } else
                    {
                        livro.Id = id.Value;
                        LivroController.Atualizar(livro);
                    }

                    MessageBox.Show("Livro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizar = true;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o livro!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormLivroSalvar_Load(object sender, EventArgs e)
        {
            txtDataPublicacao.MaxDate = DateTime.Today;

            if (id != null)
            {
                try
                {
                    Livro livro = LivroController.Obter(new Livro { Id = id.Value });
                    txtTitulo.Text = livro.Titulo;
                    txtDataPublicacao.Value = livro.DataPublicacao;
                }
                catch (Exception ex) { 
                    MessageBox.Show("Erro ao buscar o livro informado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }
    }
}
