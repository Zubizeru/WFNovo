namespace WFNovo
{
    partial class FrmCadastro
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
            VerCadastro = new Button();
            txtEndereco = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            lblNome = new Label();
            lblEndereco = new Label();
            lblBairro = new Label();
            lblEstado = new Label();
            lblTelefone = new Label();
            cbxEstado = new ComboBox();
            lblCelular = new Label();
            lblEmail = new Label();
            txtBairro = new TextBox();
            txtTelefone = new TextBox();
            txtCelular = new TextBox();
            txtEmail = new TextBox();
            btnGravarCadastro = new Button();
            btnNovoCadastro = new Button();
            SuspendLayout();
            // 
            // VerCadastro
            // 
            VerCadastro.Location = new Point(262, 382);
            VerCadastro.Name = "VerCadastro";
            VerCadastro.Size = new Size(102, 47);
            VerCadastro.TabIndex = 12;
            VerCadastro.Text = "Ver Cadastro";
            VerCadastro.UseVisualStyleBackColor = true;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(150, 118);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '*';
            txtEndereco.Size = new Size(188, 23);
            txtEndereco.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(150, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(188, 23);
            txtNome.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 32);
            label2.Name = "label2";
            label2.Size = new Size(367, 21);
            label2.TabIndex = 14;
            label2.Text = "Preencha os campos e clique em Gravar Dados ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(51, 80);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 15;
            lblNome.Text = "Nome:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 12F);
            lblEndereco.Location = new Point(51, 116);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(77, 21);
            lblEndereco.TabIndex = 16;
            lblEndereco.Text = "Endereço:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 12F);
            lblBairro.Location = new Point(51, 153);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(55, 21);
            lblBairro.TabIndex = 17;
            lblBairro.Text = "Bairro:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F);
            lblEstado.Location = new Point(51, 190);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(59, 21);
            lblEstado.TabIndex = 18;
            lblEstado.Text = "Estado:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 12F);
            lblTelefone.Location = new Point(51, 230);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(70, 21);
            lblTelefone.TabIndex = 19;
            lblTelefone.Text = "Telefone:";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxEstado.Location = new Point(150, 192);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(128, 23);
            cbxEstado.TabIndex = 20;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Font = new Font("Segoe UI", 12F);
            lblCelular.Location = new Point(51, 269);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(62, 21);
            lblCelular.TabIndex = 21;
            lblCelular.Text = "Celular:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(51, 307);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(150, 155);
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '*';
            txtBairro.Size = new Size(188, 23);
            txtBairro.TabIndex = 23;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(150, 228);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '*';
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 25;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(150, 271);
            txtCelular.Name = "txtCelular";
            txtCelular.PasswordChar = '*';
            txtCelular.Size = new Size(100, 23);
            txtCelular.TabIndex = 26;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 309);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '*';
            txtEmail.Size = new Size(188, 23);
            txtEmail.TabIndex = 27;
            // 
            // btnGravarCadastro
            // 
            btnGravarCadastro.Location = new Point(46, 382);
            btnGravarCadastro.Name = "btnGravarCadastro";
            btnGravarCadastro.Size = new Size(102, 47);
            btnGravarCadastro.TabIndex = 28;
            btnGravarCadastro.Text = "Gravar Cadastro";
            btnGravarCadastro.UseVisualStyleBackColor = true;
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.Location = new Point(154, 382);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(102, 47);
            btnNovoCadastro.TabIndex = 29;
            btnNovoCadastro.Text = "Novo Cadastro";
            btnNovoCadastro.UseVisualStyleBackColor = true;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 473);
            Controls.Add(btnNovoCadastro);
            Controls.Add(btnGravarCadastro);
            Controls.Add(txtEmail);
            Controls.Add(txtCelular);
            Controls.Add(txtTelefone);
            Controls.Add(txtBairro);
            Controls.Add(lblEmail);
            Controls.Add(lblCelular);
            Controls.Add(cbxEstado);
            Controls.Add(lblTelefone);
            Controls.Add(lblEstado);
            Controls.Add(lblBairro);
            Controls.Add(lblEndereco);
            Controls.Add(lblNome);
            Controls.Add(label2);
            Controls.Add(VerCadastro);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Name = "FrmCadastro";
            Text = "Cadastro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button VerCadastro;
        private TextBox txtEndereco;
        private TextBox txtNome;
        private Label label2;
        private Label lblNome;
        private Label lblEndereco;
        private Label lblBairro;
        private Label lblEstado;
        private Label lblTelefone;
        private ComboBox cbxEstado;
        private Label lblCelular;
        private Label lblEmail;
        private TextBox txtBairro;
        private TextBox txtTelefone;
        private TextBox txtCelular;
        private TextBox txtEmail;
        private Button btnGravarCadastro;
        private Button btnNovoCadastro;
    }
}