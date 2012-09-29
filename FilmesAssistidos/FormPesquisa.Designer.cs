namespace FilmesAssistidos
{
    partial class FormPesquisa
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
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.listViewPesquisa = new System.Windows.Forms.ListView();
            this.ColumnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelDataAssitido = new System.Windows.Forms.Label();
            this.labelNomeFilme = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelAte = new System.Windows.Forms.Label();
            this.dateTimePickerData2 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.labelMetodoPesquisa = new System.Windows.Forms.Label();
            this.checkBoxLocal = new System.Windows.Forms.CheckBox();
            this.checkBoxNome = new System.Windows.Forms.CheckBox();
            this.checkBoxGênero = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(278, 128);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(230, 20);
            this.dateTimePickerData.TabIndex = 27;
            // 
            // listViewPesquisa
            // 
            this.listViewPesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderNome,
            this.columnHeaderLocal,
            this.columnHeaderGenero,
            this.columnHeaderData});
            this.listViewPesquisa.FullRowSelect = true;
            this.listViewPesquisa.GridLines = true;
            this.listViewPesquisa.Location = new System.Drawing.Point(12, 166);
            this.listViewPesquisa.Name = "listViewPesquisa";
            this.listViewPesquisa.Size = new System.Drawing.Size(768, 255);
            this.listViewPesquisa.TabIndex = 26;
            this.listViewPesquisa.UseCompatibleStateImageBehavior = false;
            this.listViewPesquisa.View = System.Windows.Forms.View.Details;
           
            // ColumnHeaderNome
            // 
            this.ColumnHeaderNome.Text = "Nome Filme";
            this.ColumnHeaderNome.Width = 189;
            // 
            // columnHeaderLocal
            // 
            this.columnHeaderLocal.Text = "Local";
            this.columnHeaderLocal.Width = 210;
            // 
            // columnHeaderGenero
            // 
            this.columnHeaderGenero.Text = "Genero";
            this.columnHeaderGenero.Width = 184;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.Width = 181;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(15, 129);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(225, 20);
            this.textBoxLocal.TabIndex = 25;
           
            // comboBoxGenero
            // 
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Selecione....",
            "Ação",
            "Aventura",
            "Comédia",
            "Terror",
            "Suspense",
            "Documentário",
            "Infantil",
            "Romance",
            "Ficção-científica;"});
            this.comboBoxGenero.Location = new System.Drawing.Point(278, 84);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(130, 21);
            this.comboBoxGenero.TabIndex = 24;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(12, 108);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(43, 13);
            this.labelLocal.TabIndex = 23;
            this.labelLocal.Text = "* Local:";
           
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(275, 63);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(52, 13);
            this.labelGenero.TabIndex = 22;
            this.labelGenero.Text = "* Gênero:";
            // 
            // labelDataAssitido
            // 
            this.labelDataAssitido.AutoSize = true;
            this.labelDataAssitido.Location = new System.Drawing.Point(275, 109);
            this.labelDataAssitido.Name = "labelDataAssitido";
            this.labelDataAssitido.Size = new System.Drawing.Size(77, 13);
            this.labelDataAssitido.TabIndex = 21;
            this.labelDataAssitido.Text = "Data Assistido:";
            // 
            // labelNomeFilme
            // 
            this.labelNomeFilme.AutoSize = true;
            this.labelNomeFilme.Location = new System.Drawing.Point(12, 66);
            this.labelNomeFilme.Name = "labelNomeFilme";
            this.labelNomeFilme.Size = new System.Drawing.Size(75, 13);
            this.labelNomeFilme.TabIndex = 20;
            this.labelNomeFilme.Text = "* Nome Filme :";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(15, 85);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(227, 20);
            this.textBoxNome.TabIndex = 19;
            // 
            // labelAte
            // 
            this.labelAte.AutoSize = true;
            this.labelAte.Location = new System.Drawing.Point(514, 136);
            this.labelAte.Name = "labelAte";
            this.labelAte.Size = new System.Drawing.Size(23, 13);
            this.labelAte.TabIndex = 28;
            this.labelAte.Text = "Até";
            // 
            // dateTimePickerData2
            // 
            this.dateTimePickerData2.Location = new System.Drawing.Point(550, 130);
            this.dateTimePickerData2.Name = "dateTimePickerData2";
            this.dateTimePickerData2.Size = new System.Drawing.Size(230, 20);
            this.dateTimePickerData2.TabIndex = 29;
            // 
            // checkBoxData
            // 
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxData.Checked = true;
            this.checkBoxData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxData.Location = new System.Drawing.Point(325, 36);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(49, 17);
            this.checkBoxData.TabIndex = 39;
            this.checkBoxData.Text = "Data";
            this.checkBoxData.UseVisualStyleBackColor = false;
            this.checkBoxData.CheckedChanged += new System.EventHandler(this.checkBoxData_CheckedChanged);
            // 
            // labelMetodoPesquisa
            // 
            this.labelMetodoPesquisa.AutoSize = true;
            this.labelMetodoPesquisa.Location = new System.Drawing.Point(12, 9);
            this.labelMetodoPesquisa.Name = "labelMetodoPesquisa";
            this.labelMetodoPesquisa.Size = new System.Drawing.Size(107, 13);
            this.labelMetodoPesquisa.TabIndex = 38;
            this.labelMetodoPesquisa.Text = "Método de Pesquisa:";
            // 
            // checkBoxLocal
            // 
            this.checkBoxLocal.AutoSize = true;
            this.checkBoxLocal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxLocal.Checked = true;
            this.checkBoxLocal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLocal.Location = new System.Drawing.Point(227, 36);
            this.checkBoxLocal.Name = "checkBoxLocal";
            this.checkBoxLocal.Size = new System.Drawing.Size(52, 17);
            this.checkBoxLocal.TabIndex = 37;
            this.checkBoxLocal.Text = "Local";
            this.checkBoxLocal.UseVisualStyleBackColor = false;
            this.checkBoxLocal.CheckedChanged += new System.EventHandler(this.checkBoxLocal_CheckedChanged);
            // 
            // checkBoxNome
            // 
            this.checkBoxNome.AutoSize = true;
            this.checkBoxNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxNome.Checked = true;
            this.checkBoxNome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNome.Location = new System.Drawing.Point(15, 36);
            this.checkBoxNome.Name = "checkBoxNome";
            this.checkBoxNome.Size = new System.Drawing.Size(54, 17);
            this.checkBoxNome.TabIndex = 36;
            this.checkBoxNome.Text = "Nome";
            this.checkBoxNome.UseVisualStyleBackColor = false;
            this.checkBoxNome.CheckedChanged += new System.EventHandler(this.checkBoxNome_CheckedChanged);
            // 
            // checkBoxGênero
            // 
            this.checkBoxGênero.AutoSize = true;
            this.checkBoxGênero.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxGênero.Checked = true;
            this.checkBoxGênero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGênero.Location = new System.Drawing.Point(120, 36);
            this.checkBoxGênero.Name = "checkBoxGênero";
            this.checkBoxGênero.Size = new System.Drawing.Size(61, 17);
            this.checkBoxGênero.TabIndex = 35;
            this.checkBoxGênero.Text = "Gênero";
            this.checkBoxGênero.UseVisualStyleBackColor = false;
            this.checkBoxGênero.CheckedChanged += new System.EventHandler(this.checkBoxGênero_CheckedChanged);
            // 
            // FormPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 431);
            this.Controls.Add(this.checkBoxData);
            this.Controls.Add(this.labelMetodoPesquisa);
            this.Controls.Add(this.checkBoxLocal);
            this.Controls.Add(this.checkBoxNome);
            this.Controls.Add(this.checkBoxGênero);
            this.Controls.Add(this.dateTimePickerData2);
            this.Controls.Add(this.labelAte);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.listViewPesquisa);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelDataAssitido);
            this.Controls.Add(this.labelNomeFilme);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormPesquisa";
            this.Text = "FormPesquisa";
            this.Load += new System.EventHandler(this.FormPesquisa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.ListView listViewPesquisa;
        private System.Windows.Forms.ColumnHeader ColumnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderLocal;
        private System.Windows.Forms.ColumnHeader columnHeaderGenero;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelDataAssitido;
        private System.Windows.Forms.Label labelNomeFilme;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelAte;
        private System.Windows.Forms.DateTimePicker dateTimePickerData2;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.Label labelMetodoPesquisa;
        private System.Windows.Forms.CheckBox checkBoxLocal;
        private System.Windows.Forms.CheckBox checkBoxNome;
        private System.Windows.Forms.CheckBox checkBoxGênero;
    }
}