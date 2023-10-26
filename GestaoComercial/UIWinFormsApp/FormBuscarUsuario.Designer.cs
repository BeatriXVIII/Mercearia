namespace UIWinFormsApp
{
    partial class FormBuscarUsuario
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
            this.textBoxBuscarPor = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSourceUsuario = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBuscarPor
            // 
            this.textBoxBuscarPor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxBuscarPor.Location = new System.Drawing.Point(162, 99);
            this.textBoxBuscarPor.Name = "textBoxBuscarPor";
            this.textBoxBuscarPor.Size = new System.Drawing.Size(317, 27);
            this.textBoxBuscarPor.TabIndex = 0;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(485, 99);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUSCAR POR:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(785, 99);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(94, 29);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(685, 99);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(94, 29);
            this.buttonInserir.TabIndex = 5;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(585, 99);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterar.TabIndex = 6;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(685, 409);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(785, 409);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.AllowUserToAddRows = false;
            this.dataGridViewUsuario.AllowUserToDeleteRows = false;
            this.dataGridViewUsuario.AllowUserToOrderColumns = true;
            this.dataGridViewUsuario.AutoGenerateColumns = false;
            this.dataGridViewUsuario.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.nomeUsuarioDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn});
            this.dataGridViewUsuario.DataSource = this.bindingSourceUsuario;
            this.dataGridViewUsuario.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(3, 141);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.ReadOnly = true;
            this.dataGridViewUsuario.RowHeadersWidth = 51;
            this.dataGridViewUsuario.RowTemplate.Height = 29;
            this.dataGridViewUsuario.Size = new System.Drawing.Size(876, 262);
            this.dataGridViewUsuario.TabIndex = 9;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome usuário";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeUsuarioDataGridViewTextBoxColumn
            // 
            this.nomeUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NomeUsuario";
            this.nomeUsuarioDataGridViewTextBoxColumn.HeaderText = "NomeUsuario";
            this.nomeUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeUsuarioDataGridViewTextBoxColumn.Name = "nomeUsuarioDataGridViewTextBoxColumn";
            this.nomeUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn.Width = 60;
            // 
            // bindingSourceUsuario
            // 
            this.bindingSourceUsuario.DataSource = typeof(Models.Usuario);
            this.bindingSourceUsuario.CurrentChanged += new System.EventHandler(this.bindingSourceUsuario_CurrentChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(885, 76);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar Usuário";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Nome ",
            "Nome de Usuário ",
            "Todos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(3, 99);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(153, 28);
            this.comboBoxBuscarPor.TabIndex = 10;
            this.comboBoxBuscarPor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.dataGridViewUsuario);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscarPor);
            this.Name = "FormBuscarUsuario";
            this.Text = "FormBuscarUsuario";
            this.Load += new System.EventHandler(this.FormBuscarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxBuscarPor;
        private Button buttonBuscar;
        private Label label1;
        private Label label2;
        private Button buttonExcluir;
        private Button buttonInserir;
        private Button buttonAlterar;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private DataGridView dataGridViewUsuario;
        private BindingSource bindingSourceUsuario;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeUsuarioDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private ComboBox comboBoxBuscarPor;
    }
}