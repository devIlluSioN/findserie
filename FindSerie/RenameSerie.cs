using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindSerie
{
    public partial class RenameSerie : Form
    {
        public RenameSerie()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            this.ReturnValue = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btn_valider_Click(sender, e);
        }
    }
}
