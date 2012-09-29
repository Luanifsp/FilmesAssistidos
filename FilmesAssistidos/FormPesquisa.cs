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
    public partial class FormPesquisa : Form
    {
        public FormPesquisa()
        {
            InitializeComponent();
        }

        

        private void FormPesquisa_Load(object sender, EventArgs e)
        {
            comboBoxGenero.SelectedIndex = 0; 
        }

        private void checkBoxNome_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNome.Enabled = checkBoxNome.Checked;
        }

        private void checkBoxGênero_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGenero.Enabled = checkBoxGênero.Checked;
        }

        private void checkBoxLocal_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLocal.Enabled = checkBoxLocal.Checked;
        }

        private void checkBoxData_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerData.Enabled = checkBoxData.Checked;
            dateTimePickerData2.Enabled = checkBoxData.Checked;
        }
    }
}
