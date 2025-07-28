namespace AppLogin
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            groupBox = new GroupBox();
            label3 = new Label();
            botCriarConta = new Button();
            botEntrar = new Button();
            botCensuraLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSenhaLogin = new TextBox();
            txtEmailLogin = new TextBox();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(botCriarConta);
            groupBox.Controls.Add(botEntrar);
            groupBox.Controls.Add(botCensuraLogin);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(txtSenhaLogin);
            groupBox.Controls.Add(txtEmailLogin);
            resources.ApplyResources(groupBox, "groupBox");
            groupBox.Name = "groupBox";
            groupBox.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // botCriarConta
            // 
            botCriarConta.Cursor = Cursors.Hand;
            resources.ApplyResources(botCriarConta, "botCriarConta");
            botCriarConta.Name = "botCriarConta";
            botCriarConta.UseVisualStyleBackColor = true;
            botCriarConta.Click += botCriarConta_Click;
            // 
            // botEntrar
            // 
            botEntrar.Cursor = Cursors.Hand;
            resources.ApplyResources(botEntrar, "botEntrar");
            botEntrar.Name = "botEntrar";
            botEntrar.UseVisualStyleBackColor = true;
            botEntrar.Click += botEntrar_Click;
            // 
            // botCensuraLogin
            // 
            botCensuraLogin.Cursor = Cursors.Hand;
            resources.ApplyResources(botCensuraLogin, "botCensuraLogin");
            botCensuraLogin.Name = "botCensuraLogin";
            botCensuraLogin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // txtSenhaLogin
            // 
            resources.ApplyResources(txtSenhaLogin, "txtSenhaLogin");
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.UseSystemPasswordChar = true;
            // 
            // txtEmailLogin
            // 
            resources.ApplyResources(txtEmailLogin, "txtEmailLogin");
            txtEmailLogin.Name = "txtEmailLogin";
            // 
            // TelaLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TelaLogin";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private TextBox txtEmailLogin;
        private Label label1;
        private TextBox txtSenhaLogin;
        private Label label2;
        private Button botCriarConta;
        private Button botEntrar;
        private Button botCensuraLogin;
        private Label label3;
    }
}
