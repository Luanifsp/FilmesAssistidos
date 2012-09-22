namespace FilmesAssistidos
{
    partial class Form1
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNomeFilme = new System.Windows.Forms.Label();
            this.labelDataAssitido = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelLocal = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.listViewFilmes = new System.Windows.Forms.ListView();
            this.ColumnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(15, 74);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(227, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelNomeFilme
            // 
            this.labelNomeFilme.AutoSize = true;
            this.labelNomeFilme.Location = new System.Drawing.Point(12, 55);
            this.labelNomeFilme.Name = "labelNomeFilme";
            this.labelNomeFilme.Size = new System.Drawing.Size(65, 13);
            this.labelNomeFilme.TabIndex = 5;
            this.labelNomeFilme.Text = "Nome Filme:";
            // 
            // labelDataAssitido
            // 
            this.labelDataAssitido.AutoSize = true;
            this.labelDataAssitido.Location = new System.Drawing.Point(275, 98);
            this.labelDataAssitido.Name = "labelDataAssitido";
            this.labelDataAssitido.Size = new System.Drawing.Size(77, 13);
            this.labelDataAssitido.TabIndex = 6;
            this.labelDataAssitido.Text = "Data Assistido:";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(275, 52);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 13);
            this.labelGenero.TabIndex = 7;
            this.labelGenero.Text = "Gênero:";
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(12, 97);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(36, 13);
            this.labelLocal.TabIndex = 8;
            this.labelLocal.Text = "Local:";
            // 
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
            this.comboBoxGenero.Location = new System.Drawing.Point(278, 73);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(130, 21);
            this.comboBoxGenero.TabIndex = 10;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(15, 118);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(225, 20);
            this.textBoxLocal.TabIndex = 11;
            this.textBoxLocal.TextChanged += new System.EventHandler(this.textBoxLocal_TextChanged);
            // 
            // listViewFilmes
            // 
            this.listViewFilmes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderNome,
            this.columnHeaderLocal,
            this.columnHeaderGenero,
            this.columnHeaderData});
            this.listViewFilmes.FullRowSelect = true;
            this.listViewFilmes.GridLines = true;
            this.listViewFilmes.Location = new System.Drawing.Point(12, 167);
            this.listViewFilmes.Name = "listViewFilmes";
            this.listViewFilmes.Size = new System.Drawing.Size(768, 255);
            this.listViewFilmes.TabIndex = 12;
            this.listViewFilmes.UseCompatibleStateImageBehavior = false;
            this.listViewFilmes.View = System.Windows.Forms.View.Details;
            // 
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
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(214, 13);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 37);
            this.buttonPesquisar.TabIndex = 13;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(15, 12);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 37);
            this.buttonAdicionar.TabIndex = 14;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(116, 12);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 37);
            this.buttonEditar.TabIndex = 15;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(320, 12);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 37);
            this.buttonDeletar.TabIndex = 17;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(278, 117);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(230, 20);
            this.dateTimePickerData.TabIndex = 18;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(433, 13);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 36);
            this.buttonSalvar.TabIndex = 19;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 434);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.listViewFilmes);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelDataAssitido);
            this.Controls.Add(this.labelNomeFilme);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Form1";
            this.Text = "Filmes Assistidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNomeFilme;
        private System.Windows.Forms.Label labelDataAssitido;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.ListView listViewFilmes;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.ColumnHeader ColumnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderLocal;
        private System.Windows.Forms.ColumnHeader columnHeaderGenero;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.Button buttonSalvar;

    }
}

