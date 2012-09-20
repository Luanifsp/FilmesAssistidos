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

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            // Validação dos campos

            if (textBoxNome.Text == "" || textBoxLocal.Text == "" || comboBoxGen.SelectedIndex == 0)
                MessageBox.Show("Favor preencher os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else 
            {
                // Cria o novo item (primeira coluna) campo Nome
                novoItem = new ListViewItem();
                novoItem.Text = textBoxNome.Text;

                // Cria o primeiro subItem (segunda coluna) campo Gênero
                ListViewItem.ListViewSubItem SubitemGenero = new ListViewItem.ListViewSubItem();
                SubitemGenero.Text = comboBoxGen.SelectedItem.ToString();

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

        private void textBoxLocal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
