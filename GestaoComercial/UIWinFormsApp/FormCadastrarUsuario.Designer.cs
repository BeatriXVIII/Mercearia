namespace UIWinFormsApp
{
    partial class FormCadastrarUsuario
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.bindingSourceCadastro = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxNomeDeUsuário = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelConfigSenha = new System.Windows.Forms.Label();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "Nome", true));
            this.textBoxNome.Location = new System.Drawing.Point(12, 106);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(377, 27);
            this.textBoxNome.TabIndex = 0;
            // 
            // bindingSourceCadastro
            // 
            this.bindingSourceCadastro.DataSource = typeof(Models.Usuario);
            this.bindingSourceCadastro.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // textBoxNomeDeUsuário
            // 
            this.textBoxNomeDeUsuário.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "Nome", true));
            this.textBoxNomeDeUsuário.Location = new System.Drawing.Point(412, 106);
            this.textBoxNomeDeUsuário.Name = "textBoxNomeDeUsuário";
            this.textBoxNomeDeUsuário.Size = new System.Drawing.Size(354, 27);
            this.textBoxNomeDeUsuário.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 83);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome de Usuário";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "Senha", true));
            this.textBoxSenha.Location = new System.Drawing.Point(12, 173);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(167, 27);
            this.textBoxSenha.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(185, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 27);
            this.textBox4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha:";
            // 
            // labelConfigSenha
            // 
            this.labelConfigSenha.AutoSize = true;
            this.labelConfigSenha.Location = new System.Drawing.Point(185, 150);
            this.labelConfigSenha.Name = "labelConfigSenha";
            this.labelConfigSenha.Size = new System.Drawing.Size(166, 20);
            this.labelConfigSenha.TabIndex = 7;
            this.labelConfigSenha.Text = "Configuração da Senha:";
            this.labelConfigSenha.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceCadastro, "Ativo", true));
            this.checkBoxAtivo.Location = new System.Drawing.Point(412, 176);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(66, 24);
            this.checkBoxAtivo.TabIndex = 8;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            this.checkBoxAtivo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cadastrar Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(286, 272);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // FormCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.labelConfigSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxNomeDeUsuário);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormCadastrarUsuario";
            this.Text = "FormCadastrarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxNomeDeUsuário;
        private Label label;
        private Label label2;
        private TextBox textBoxSenha;
        private TextBox textBox4;
        private Label label3;
        private Label labelConfigSenha;
        private CheckBox checkBoxAtivo;
        private Label label1;
        private BindingSource bindingSourceCadastro;
        private Button buttonSalvar;
    }
}