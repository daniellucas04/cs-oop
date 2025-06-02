namespace Aula.View
{
    partial class FormLivroSalvar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtTitulo = new TextBox();
            txtDataPublicacao = new DateTimePicker();
            btnSalvar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 14);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Data Publicação";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Right;
            txtTitulo.Location = new Point(124, 6);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(351, 23);
            txtTitulo.TabIndex = 2;
            // 
            // txtDataPublicacao
            // 
            txtDataPublicacao.Anchor = AnchorStyles.Right;
            txtDataPublicacao.Format = DateTimePickerFormat.Short;
            txtDataPublicacao.Location = new Point(124, 40);
            txtDataPublicacao.Name = "txtDataPublicacao";
            txtDataPublicacao.Size = new Size(351, 23);
            txtDataPublicacao.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Right;
            btnSalvar.Location = new Point(400, 92);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormLivroSalvar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 131);
            Controls.Add(btnSalvar);
            Controls.Add(txtDataPublicacao);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLivroSalvar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Livro";
            Load += FormLivroSalvar_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitulo;
        private DateTimePicker txtDataPublicacao;
        private Button btnSalvar;
        private ErrorProvider errorProvider1;
    }
}