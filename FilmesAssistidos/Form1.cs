using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FilmesAssistidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        public void ResetForm()
        {
            //buttonAdicionar.Enabled = true;
            //buttonSalvar.Visible = false;
            textBoxNome.Text = "";
            textBoxLocal.Text = "";
            comboBoxGenero.SelectedIndex = 0;
            dateTimePickerData.Value = DateTime.Now;
        }

        //edita o item
        public void Editar_Item()
        {
            buttonSalvar.Visible = true;
            buttonAdicionar.Enabled = false;

            // Verifica se foi selecionado algum item do listView
            if (listViewFilmes.SelectedItems.Count != 0)
            {
                // passa o valor da primeira coluna do listView para o textboxNome
                textBoxNome.Text = listViewFilmes.SelectedItems[0].SubItems[0].Text;

                // passa o valor da segunda coluna do listView para o comboBoxGen
                comboBoxGenero.Text = listViewFilmes.SelectedItems[0].SubItems[1].Text;

                // passa o valor da terceira coluna do listView para o textboxLocal
                textBoxLocal.Text = listViewFilmes.SelectedItems[0].SubItems[2].Text;

                // passa o valor da terceira coluna do listview para o dateTimePivkerData, concertendo a string em data
                dateTimePickerData.Value = DateTime.Parse(listViewFilmes.SelectedItems[0].SubItems[3].Text);
            }
        }

        ListViewItem novoItem =  new ListViewItem();

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            // Validação dos campos

            if (textBoxNome.Text == "" || textBoxLocal.Text == "" || comboBoxGenero.SelectedIndex == 0)
                MessageBox.Show("Favor preencher os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                // Cria o novo item
                novoItem = new ListViewItem();
                novoItem.Text = textBoxNome.Text;

                // Cria o primeiro subItem (segunda coluna) campo Gênero
                ListViewItem.ListViewSubItem SubitemGenero = new ListViewItem.ListViewSubItem();
                SubitemGenero.Text = comboBoxGenero.SelectedItem.ToString();

                // Cria o segundo subitem (terceira coluna) campo Local
                ListViewItem.ListViewSubItem SubitemLocal = new ListViewItem.ListViewSubItem();
                SubitemLocal.Text = textBoxLocal.Text;

                // Cria o terceiro subItem (quarta coluna) campo Data
                ListViewItem.ListViewSubItem SubitemData = new ListViewItem.ListViewSubItem();
                string data = dateTimePickerData.Value.Date.ToString();
                // Remove o horario do componente dateTimePicker, deixando apenas a data
                data = data.Remove(10);
                SubitemData.Text = data;

                //Adiciona os subitens ao item 
                novoItem.SubItems.Add(SubitemGenero);
                novoItem.SubItems.Add(SubitemLocal);
                novoItem.SubItems.Add(SubitemData);

                //Adiciona o item ao List View
                listViewFilmes.Items.Add(novoItem);


            }

         }

        private void textBoxLocal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           comboBoxGenero.SelectedIndex = 0;    

        }

        private void listViewFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            //Verifica se o usuario selecionou algum item da lista
            if (listViewFilmes.SelectedItems.Count != 0)
            {
                int posicao = listViewFilmes.SelectedItems.Count;

                //apaga os item selecionados
                for (int i = posicao - 1; i >= 0; i--)
                {
                    //cria uma lista onde é adicionado os itens selecionados
                    ListViewItem ItemSelecionado = listViewFilmes.SelectedItems[i];
                    listViewFilmes.Items.Remove(ItemSelecionado);
                }
            }
            else
            {
                if (listViewFilmes.Items.Count == 0)
                    MessageBox.Show("Impossivel remover!\n Lista vazia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Selecione primeiro um item a ser removido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
             private void buttonEditar_Click(object sender, EventArgs e)
        {
            Editar_Item();
        }

        

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Verifica os campos dos campos
            if (textBoxNome.Text.Trim() == "" || textBoxLocal.Text.Trim() == "" || comboBoxGenero.SelectedIndex ==0)
                MessageBox.Show("Favor preencher todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                // Remove o horario do componente dateTimePicker, deixando apenas a data
                string data = dateTimePickerData.Value.Date.ToString();
                data = data.Remove(10); // Remove os caracteres a partir do 10

                // Altera os valores dos itens da lista
                listViewFilmes.SelectedItems[0].SubItems[0].Text = textBoxNome.Text;
                listViewFilmes.SelectedItems[0].SubItems[1].Text = comboBoxGenero.SelectedItem.ToString();
                listViewFilmes.SelectedItems[0].SubItems[2].Text = textBoxLocal.Text;
                listViewFilmes.SelectedItems[0].SubItems[3].Text = data;
                
                // Reseta o formulario ao padrão
                ResetForm();
                listViewFilmes.SelectedItems[0].Selected = false;
                
            } 
        }

        
        

       
    }
}
