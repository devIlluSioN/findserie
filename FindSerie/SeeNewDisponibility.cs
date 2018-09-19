using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FindSerie
{
    public partial class SeeNewDisponibility : Form
    {
        public SeeNewDisponibility()
        {
            InitializeComponent();
        }

        private void SND_btn_Validation_Click(object sender, EventArgs e)
        {
        }
        
        private void load_Serie(string DirectoryPath)
        {
            SND_TB_Directory_Path.Text = DirectoryPath;
            string[] tabfiles;
            int i = 0;
            try
            {
                tabfiles = Directory.GetFiles(DirectoryPath, "*", SearchOption.AllDirectories);
                string[] tabserie = new string[tabfiles.Length];
                foreach (string file in tabfiles)
                {
                    if (Code.isSerie(Fonction.OnlyFileName(file)))
                    {
                        tabserie[i] = file;
                        i++;
                    }
                }
                tabserie = tabserie.Where(episode => !string.IsNullOrEmpty(episode)).ToArray();
                Array.Sort(tabserie);
            }
            catch (Exception expt)
            {
                MessageBox.Show("L'erreur suivante s'est declaree :" + expt.Message);
            }
        }
    }
}
