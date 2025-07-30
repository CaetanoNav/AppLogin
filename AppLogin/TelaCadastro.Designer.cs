namespace AppLogin
{
    partial class TelaCadastro
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
            txtNome = new TextBox();
            txtEmaiCadastro = new TextBox();
            txtTelefone = new MaskedTextBox();
            txtCPF = new MaskedTextBox();
            txtSenhaCastro = new TextBox();
            txtConfirmaSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            botSenhaCensura = new Button();
            botConfSenhaCensura = new Button();
            txtSobrenome = new TextBox();
            label7 = new Label();
            botCadastrar = new Button();
            linkVoltar = new LinkLabel();
            label8 = new Label();
            botGerarSenha = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(40, 41);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(187, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmaiCadastro
            // 
            txtEmaiCadastro.Location = new Point(40, 151);
            txtEmaiCadastro.MaxLength = 75;
            txtEmaiCadastro.Name = "txtEmaiCadastro";
            txtEmaiCadastro.Size = new Size(270, 23);
            txtEmaiCadastro.TabIndex = 1;
            txtEmaiCadastro.Validated += txtEmaiCadastro_Validated;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(331, 100);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(93, 23);
            txtTelefone.TabIndex = 2;
            txtTelefone.MaskInputRejected += txtTelefone_MaskInputRejected;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(39, 99);
            txtCPF.Mask = "000,000,000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(89, 23);
            txtCPF.TabIndex = 3;
            txtCPF.MaskInputRejected += txtCPF_MaskInputRejected;
            // 
            // txtSenhaCastro
            // 
            txtSenhaCastro.Location = new Point(41, 200);
            txtSenhaCastro.MaxLength = 50;
            txtSenhaCastro.Name = "txtSenhaCastro";
            txtSenhaCastro.Size = new Size(163, 23);
            txtSenhaCastro.TabIndex = 4;
            txtSenhaCastro.UseSystemPasswordChar = true;
            txtSenhaCastro.TextChanged += txtSenhaCastro_TextChanged;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(331, 201);
            txtConfirmaSenha.MaxLength = 50;
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.Size = new Size(163, 23);
            txtConfirmaSenha.TabIndex = 5;
            txtConfirmaSenha.UseSystemPasswordChar = true;
            txtConfirmaSenha.TextChanged += txtConfirmaSenha_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 23);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 81);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 7;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 81);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 8;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 136);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 9;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 183);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 10;
            label5.Text = "Senha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(333, 182);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 11;
            label6.Text = "Confirme sua senha";
            // 
            // botSenhaCensura
            // 
            botSenhaCensura.Cursor = Cursors.Hand;
            botSenhaCensura.Location = new Point(210, 200);
            botSenhaCensura.Name = "botSenhaCensura";
            botSenhaCensura.Size = new Size(75, 23);
            botSenhaCensura.TabIndex = 12;
            botSenhaCensura.Text = "Mostrar";
            botSenhaCensura.UseVisualStyleBackColor = true;
            botSenhaCensura.Click += botSenhaCensura_Click;
            // 
            // botConfSenhaCensura
            // 
            botConfSenhaCensura.Cursor = Cursors.Hand;
            botConfSenhaCensura.Location = new Point(500, 201);
            botConfSenhaCensura.Name = "botConfSenhaCensura";
            botConfSenhaCensura.Size = new Size(75, 23);
            botConfSenhaCensura.TabIndex = 13;
            botConfSenhaCensura.Text = "Motrar";
            botConfSenhaCensura.UseVisualStyleBackColor = true;
            botConfSenhaCensura.Click += botConfSenhaCensura_Click;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(331, 41);
            txtSobrenome.MaxLength = 50;
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(188, 23);
            txtSobrenome.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 23);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 15;
            label7.Text = "Sobrenome";
            // 
            // botCadastrar
            // 
            botCadastrar.Cursor = Cursors.Hand;
            botCadastrar.Location = new Point(263, 325);
            botCadastrar.Name = "botCadastrar";
            botCadastrar.Size = new Size(90, 27);
            botCadastrar.TabIndex = 16;
            botCadastrar.Text = "Cadastre-se";
            botCadastrar.UseVisualStyleBackColor = true;
            botCadastrar.Click += botCadastrar_Click;
            // 
            // linkVoltar
            // 
            linkVoltar.AutoSize = true;
            linkVoltar.Cursor = Cursors.Hand;
            linkVoltar.Location = new Point(555, 352);
            linkVoltar.Name = "linkVoltar";
            linkVoltar.Size = new Size(37, 15);
            linkVoltar.TabIndex = 17;
            linkVoltar.TabStop = true;
            linkVoltar.Text = "Voltar";
            linkVoltar.LinkClicked += linkVoltar_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 277);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 18;
            label8.Text = "Gere uma senha forte";
            // 
            // botGerarSenha
            // 
            botGerarSenha.Location = new Point(42, 295);
            botGerarSenha.Name = "botGerarSenha";
            botGerarSenha.Size = new Size(86, 23);
            botGerarSenha.TabIndex = 19;
            botGerarSenha.Text = "Gerar Senha";
            botGerarSenha.UseVisualStyleBackColor = true;
            botGerarSenha.Click += botGerarSenha_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 226);
            label9.Name = "label9";
            label9.Size = new Size(124, 15);
            label9.TabIndex = 20;
            label9.Text = "- Uma letra minuscula";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 241);
            label10.Name = "label10";
            label10.Size = new Size(123, 15);
            label10.TabIndex = 21;
            label10.Text = "- Uma letra maíuscula";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 254);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 22;
            label11.Text = "- Um número";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(180, 226);
            label12.Name = "label12";
            label12.Size = new Size(130, 15);
            label12.TabIndex = 23;
            label12.Text = "- Um caractere especial";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(180, 241);
            label13.Name = "label13";
            label13.Size = new Size(122, 15);
            label13.TabIndex = 24;
            label13.Text = "- Mínimo 8 caracteres";
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 376);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(botGerarSenha);
            Controls.Add(label8);
            Controls.Add(linkVoltar);
            Controls.Add(botCadastrar);
            Controls.Add(label7);
            Controls.Add(txtSobrenome);
            Controls.Add(botConfSenhaCensura);
            Controls.Add(botSenhaCensura);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConfirmaSenha);
            Controls.Add(txtSenhaCastro);
            Controls.Add(txtCPF);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmaiCadastro);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TelaCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmaiCadastro;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtCPF;
        private TextBox txtSenhaCastro;
        private TextBox txtConfirmaSenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button botSenhaCensura;
        private Button botConfSenhaCensura;
        private TextBox txtSobrenome;
        private Label label7;
        private Button botCadastrar;
        private LinkLabel linkVoltar;
        private Label label8;
        private Button botGerarSenha;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}