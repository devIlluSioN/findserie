using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using parameter = FindSerie.Properties.Settings;

namespace FindSerie
{
    public partial class Form1 : Form
    {
        bool rnm_deleting = false;
        bool cpy_deleting = false;

        public Form1()
        {
            InitializeComponent();
            loadParameter();
        }

        // ------------------------------- SANS CATEGORIE -------------------------------

        private void loadParameter()
        {
            //PART COPY
            //Source
            stg_cpy_ck_default_sources.Checked = Properties.Settings.Default.cpy_default_bool_src;
            stg_cpy_TB_default_sources.Text = Properties.Settings.Default.cpy_default_src;
            if (Properties.Settings.Default.cpy_default_bool_src)
            {
                cpy_tb_sourcepath.Text = Properties.Settings.Default.cpy_default_src;
            }
            //Destination
            stg_cpy_ck_default_destination.Checked = Properties.Settings.Default.cpy_default_bool_dst;
            stg_cpy_TB_default_destination.Text = Properties.Settings.Default.cpy_default_dst;
            if (Properties.Settings.Default.cpy_default_bool_dst)
            {
                cpy_tb_DestinationPath.Text = Properties.Settings.Default.cpy_default_dst;
            }
            //Option
            stg_cpy_ck_active_rename.Checked = parameter.Default.cpy_bool_rename_file;
            if (parameter.Default.cpy_bool_rename_file)
            {
                cpy_checkrename.Checked = true;
            }
            stg_cpy_ck_Active_Create_Folder.Checked = parameter.Default.cpy_bool_create_tree;
            if (parameter.Default.cpy_bool_create_tree)
            {
                cpy_checkcreate.Checked = true;
            }
            //PART RENAME
            //SOURCE
            stg_rnm_ck_Default_Source.Checked = Properties.Settings.Default.rnm_default_bool_src;
            stg_rnm_tb_Default_Source.Text = Properties.Settings.Default.rnm_default_src;
            if(parameter.Default.rnm_default_bool_src)
            {
                rnm_TB_Directory_Path.Text = parameter.Default.rnm_default_src;
            }
        }

        private void logbox_addtext(string texte)
        {
            logBox.Text = texte + Environment.NewLine + logBox.Text;
        }


        //FIN SANS CATEGORIE

        // ------------------------------ COPIE ---------------------------------------

        //Code pour BOUTON

        private void cpy_btn_Parcourir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogParcourir.ShowDialog() == DialogResult.OK)
            {
                cpy_tb_sourcepath.Text = folderBrowserDialogParcourir.SelectedPath;
                cpy_load_series(folderBrowserDialogParcourir.SelectedPath);
            }
        }

        private void cpy_btn_RemoveSelectedEpisode_Click(object sender, EventArgs e)
        {
            cpy_deleting = true;
            DataTable temp = (DataTable)cpy_list_episode.DataSource;
            this.cpy_list_episode.SelectedItems.Cast<DataRowView>().ToList()
            .ForEach(item =>
            {
                item.Delete(); 
                //or
                //this.AllPairs.Tables[0].Rows.Remove(item.Row);
            });
            for (int i = cpy_list_episode_renommer.SelectedIndices.Count - 1; i >= 0; i--)
            {
                cpy_list_episode_renommer.Items.RemoveAt(cpy_list_episode_renommer.SelectedIndices[i]);
            }
            cpy_list_episode.DataSource = temp;
            cpy_list_episode.ClearSelected();
            cpy_list_episode_renommer.ClearSelected();
            cpy_deleting = false;
        }

        private void cpy_btn_WaitList_Click(object sender, EventArgs e)
        {
            if (cpy_list_episode.Items.Count != 0)
            {
                if (cpy_destinationPath())
                {
                    string path = cpy_tb_DestinationPath.Text;
                    string selectedserie = "";
                    string Number = "";
                    selectedserie = Code.nameserie(cpy_list_episode_renommer.Items[0].ToString());
                    Number = cpy_cb_SeasonNumber.SelectedItem.ToString();

                    if (cpy_checkcreate.Checked == true)
                    {
                        path = path + "\\" + selectedserie + "\\" + Number;

                        Directory.CreateDirectory(path);
                    }

                    if (cpy_checkrename.Checked == true)
                    {
                        for (int i = 0; i < cpy_list_episode.Items.Count; i++)
                        {
                            DataRowView ItemRow = (DataRowView)cpy_list_episode.Items[i];
                            string source = ItemRow.Row.ItemArray[0].ToString();
                            this.wl_dataGridView.Rows.Add("Copy", source, path + "\\" + cpy_list_episode_renommer.Items[i].ToString());


                            //this.wl_dataGridView.Rows.Add("Copy", cpy_list_episode.SelectedValue, path + "\\" + cpy_list_episode_renommer.Items[i].ToString());
                        }

                    }
                    else
                    {
                        for (int i = 0; i < cpy_list_episode.Items.Count; i++)
                        {
                            this.wl_dataGridView.Rows.Add("Copy", cpy_list_episode.Items[i].ToString(), path + "\\" + Fonction.OnlyFileName(cpy_list_episode.Items[i].ToString()));
                            this.Invoke(new Action(() =>
                            {
                                logbox_addtext("Fichier copié : " + Fonction.OnlyFileName(cpy_list_episode.Items[i].ToString()));
                            }));
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas d'episode a traiter", "Veuillez selectioner des episodes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cpy_btn_go_Click(object sender, EventArgs e)
        {
            if (cpy_tb_sourcepath.Text != "" && cpy_sourcePath())
            {
                cpy_load_series(cpy_tb_sourcepath.Text);
            }
        }

        private void cpy_btn_verify_presence_Click(object sender, EventArgs e)
        {
            if (cpy_list_episode.Items.Count != 0)
            {
                if (cpy_destinationPath())
                {
                    string path = cpy_tb_DestinationPath.Text;
                    string selectedserie = "";
                    string Number = "";
                    List<int> removeindex = new List<int>();
                    selectedserie = Code.nameserie(cpy_list_episode_renommer.Items[0].ToString());
                    Number = cpy_cb_SeasonNumber.SelectedItem.ToString();

                    if (cpy_checkcreate.Checked == true)
                    {
                        path = path + "\\" + selectedserie + "\\" + Number;
                    }

                    if (cpy_checkrename.Checked == true)
                    {
                        for (int i = 0; i < cpy_list_episode.Items.Count; i++)
                        {
                            if (File.Exists(path + "\\" + cpy_list_episode_renommer.Items[i].ToString()))
                            {
                                cpy_list_episode.Items.RemoveAt(i);
                                cpy_list_episode_renommer.Items.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < cpy_list_episode.Items.Count; i++)
                        {
                            if (File.Exists(path + "\\" + cpy_list_episode.Items[i].ToString()))
                            {
                                cpy_list_episode.Items.RemoveAt(i);
                                cpy_list_episode_renommer.Items.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas d'episode a traiter", "Veuillez selectioner des episodes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cpy_btn_ValidationCopy_Click(object sender, EventArgs e)
        {
            if (cpy_destinationPath())
            {
                cpy_btn_WaitList_Click(sender, e);
                wl_btn_ValideWaitLIst_Click(sender, e);
            }
        }

        private void cpy_btn_modnameserie_Click(object sender, EventArgs e)
        {
            RenameSerie form = new RenameSerie();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string newname = form.ReturnValue;
                string[] oldline = cpy_list_episode_renommer.Items.OfType<string>().ToArray();
                cpy_list_episode_renommer.Items.Clear();
                foreach (string line in oldline)
                {
                    string newline = newname + " S" + Code.numberSeason(line) + "E" + Code.numberEpisode(line);
                    char[] c = line.ToCharArray();
                    int l = c.Length - 4; //place le curseur sur le point de .mkv
                    while (l < c.Length)
                    {
                        newline += c[l];
                        l++;
                    }
                    cpy_list_episode_renommer.Items.Add(newline);

                }

            }
        }

        private void cpy_btn_findTitle_Click(object sender, EventArgs e)
        {
            if(IcanWork())
            {
                try
                {
                    int idSerie = MovieDB.getIDofSerie(Code.nameserie(cpy_list_episode_renommer.Items[0].ToString()));
                    if (idSerie != -1)
                    {
                        var MsgBResult = MessageBox.Show("J'ai aasocié la serie selectionnée à : " + MovieDB.getTvShow(idSerie).Name +
                            "\nEst-ce la bonne serie ?", "Recherche Titre", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        switch (MsgBResult)
                        {
                            case DialogResult.Yes:
                                cpy_btn_findTitle.Enabled = false;
                                cpy_add_title(idSerie);
                                break;
                            case DialogResult.No:

                                MovieDbSelectSerie SearchSerie = new MovieDbSelectSerie(cpy_cb_Serie.SelectedItem.ToString());
                                var SelectSerie = SearchSerie.ShowDialog();
                                if (SelectSerie == DialogResult.OK)
                                {
                                    cpy_add_title(SearchSerie.idSerie);
                                }
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucun resultat pour la serie : " + Code.nameserie(cpy_list_episode_renommer.Items[0].ToString()) + ".\nVerfier le nom.", "FindSerie : Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    var result = MessageBox.Show("Une Erreur est survenue verifier votre connection Internet", "FindSerie : Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry)
                    {
                        cpy_btn_findTitle_Click(sender, e);
                    }
                }
            }
  
        }

        private void cpy_btn_addFinal_Click(object sender, EventArgs e)
        {
            int i = cpy_list_episode_renommer.Items.Count - 1;

            while (i >= 0)
            {
                string currentfile = cpy_list_episode_renommer.Items[cpy_list_episode_renommer.Items.Count - 1].ToString();
                string currentserie = Code.nameserie(currentfile);
                int currentseason = int.Parse(Code.numberSeason(currentfile));
                int currentepisode = int.Parse(Code.numberEpisode(currentfile));
                if (MovieDB.getFinalNumberEpispdeTV(currentserie, currentseason) == currentepisode)
                {
                    int y = 0;
                    char[] c = currentfile.ToCharArray();
                    while (y < c.Length)
                    {
                        if ((y > 6) && Fonction.IsNumeric(c[y]) && Fonction.IsNumeric(c[y - 1]) && Fonction.IsNumeric(c[y - 3]) && Fonction.IsNumeric(c[y - 4]) && ((c[y - 5] == (char)83 || c[y - 5] == (char)115) && (c[y - 2] == (char)69 || c[y - 2] == (char)101)))
                        {
                            currentfile = currentfile.Insert(y + 1, " FiNAL");
                            break;
                        }
                        y++;
                    }
                    //currentfile = currentfile.Insert(currentfile.Length - 4, " Final");
                    cpy_list_episode_renommer.Items.RemoveAt(i);
                    cpy_list_episode_renommer.Items.Insert(i, currentfile);
                    return;
                }
                i--;
            }
            logbox_addtext("L'episode final n'est pas present");

        }

        private void cpy_btn_SelectDestinationPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserEnregister.ShowDialog() == DialogResult.OK)
            {
                cpy_tb_DestinationPath.Text = folderBrowserEnregister.SelectedPath;
            }
        }


        //Code pour COMBOBOX

        private void cpy_cb_Serie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] saisons = new string[Code.tabepisodeserie.Length];
            int i = 0;
            string tmp;
            cpy_cb_SeasonNumber.Enabled = true;
            cpy_cb_SeasonNumber.Items.Clear();
            if (cpy_cb_Serie.SelectedIndex != 0)
            {
                foreach (string file in Code.tabepisodeserie)
                {
                    tmp = Code.RenameSerie(Fonction.OnlyFileName(file));
                    if (Code.nameserie(tmp) == cpy_cb_Serie.SelectedItem.ToString())
                    {
                        saisons[i] = Code.numberSeason(tmp);
                        i++;
                    }
                }
                saisons = saisons.Distinct().ToArray();
                saisons = saisons.Where(episode => !string.IsNullOrEmpty(episode)).ToArray();
                Array.Sort(saisons);
                foreach (string s in saisons)
                {
                    cpy_cb_SeasonNumber.Items.Add(s);
                }
                if (saisons.Length == 1)
                {
                    cpy_cb_SeasonNumber.SelectedIndex = 0;
                }
                else
                {
                    cpy_cb_SeasonNumber.SelectedIndex = 0;
                }
            }
        }

        private void cpy_cb_SeasonNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tmp;
            DataTable EpisodeTable = new DataTable();
            EpisodeTable.Columns.Add("Path");
            EpisodeTable.Columns.Add("Display");
            cpy_list_episode.Enabled = true;
            cpy_list_episode_renommer.Enabled = true;
            cpy_list_episode.DataSource = null;
            cpy_list_episode.Items.Clear();
            cpy_list_episode_renommer.Items.Clear();
            foreach (string file in Code.tabepisodeserie)
            {
                DataRow OneEpisode = EpisodeTable.NewRow(); 
                tmp = Code.RenameSerie(Fonction.OnlyFileName(file));
                if (Code.nameserie(tmp) == cpy_cb_Serie.SelectedItem.ToString() && Code.numberSeason(tmp) == cpy_cb_SeasonNumber.SelectedItem.ToString())
                {
                    OneEpisode["Path"] = file;
                    OneEpisode["Display"] = file.Replace(cpy_tb_sourcepath.Text, ".");
                    EpisodeTable.Rows.Add(OneEpisode);
                    //cpy_list_episode.Items.Add(file);
                    if (cpy_checkrename.Checked == true)
                        cpy_list_episode_renommer.Items.Add(tmp);
                }
            }
            cpy_list_episode.DataSource = EpisodeTable;
            cpy_list_episode.DisplayMember = "Display";
            cpy_list_episode.ValueMember = "Path";
            cpy_btn_findTitle.Enabled = true;
        }

        //Code pour LISTBOX

        private void cpy_list_episode_renommer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cpy_deleting == false)
            {
                int i = 0;
                while (i < cpy_list_episode_renommer.Items.Count)
                {
                    cpy_list_episode.SelectedIndexChanged -= cpy_list_episode_SelectedIndexChanged;
                    cpy_list_episode.SetSelected(i, cpy_list_episode_renommer.GetSelected(i));
                    cpy_list_episode.SelectedIndexChanged += cpy_list_episode_SelectedIndexChanged;
                    i++;
                }
            }
        }

        private void cpy_list_episode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cpy_deleting == false)
            {
                int i = 0;
                while (i < cpy_list_episode.Items.Count)
                {
                    cpy_list_episode_renommer.SelectedIndexChanged -= cpy_list_episode_renommer_SelectedIndexChanged;
                    cpy_list_episode_renommer.SetSelected(i, cpy_list_episode.GetSelected(i));
                    cpy_list_episode_renommer.SelectedIndexChanged += cpy_list_episode_renommer_SelectedIndexChanged;
                    i++;
                }
            }

        }

        //Travaille Arriere Plan

        private void back_Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            int nbrows = wl_dataGridView.Rows.Count;
            string source = "";
            string destination = "";
            foreach (DataGridViewRow row in wl_dataGridView.Rows)
            {
                try
                {
                    source = Fonction.pathCreator(row.Cells[1].Value.ToString());
                    destination = Fonction.pathCreator(row.Cells[2].Value.ToString());
                    switch (row.Cells[0].Value)
                    {
                        case "Copy":
                            File.Copy(source, destination);
                            //File.Copy(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(),false);
                            this.Invoke(new Action(() =>
                            {
                                logbox_addtext("Fichier copié : " + row.Cells[2].Value.ToString());
                            }));
                            break;

                        case "CopyDelete":
                            File.Copy(source, destination);
                            this.Invoke(new Action(() =>
                            {
                                logbox_addtext("Fichier copié : " + row.Cells[2].Value.ToString());
                            }));
                            File.SetAttributes(source, FileAttributes.Normal);
                            File.Delete(source);
                            this.Invoke(new Action(() =>
                            {
                                logbox_addtext("Fichier supprimer : " + row.Cells[2].Value.ToString());
                            }));
                            break;

                        case "Rename":
                            File.Move(source, destination);//File.Move ne fonctionne pas comme pour cpoy pour faire ;archer les chemin long 
                            //File.Move(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());
                            this.Invoke(new Action(() =>
                            {
                                logbox_addtext(Fonction.OnlyFileName(row.Cells[1].Value.ToString()) + " --TO-> " + Fonction.OnlyFileName(row.Cells[2].Value.ToString()));
                            }));
                            break;

                    }
                }
                catch (Exception ex)
                {
                    this.Invoke(new Action(() =>
                    {
                        logbox_addtext("ERREUR : " + ex.Message);
                    }));
                }
                back_Worker.ReportProgress((i + 1) * 100 / nbrows);
                i++;
            }
        }

        private void back_Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void back_Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            wl_dataGridView.Rows.Clear();
        }

        private void backCopy_DoWork(object sender, DoWorkEventArgs e)
        {

            string path = folderBrowserEnregister.SelectedPath;
            try
            {
                string selectedserie = "";
                string Number = "";
                this.Invoke(new Action(() =>
                {
                    selectedserie = Code.nameserie(cpy_list_episode_renommer.Items[0].ToString());
                    Number = cpy_cb_SeasonNumber.SelectedItem.ToString();

                }));
                if (cpy_checkcreate.Checked == true)
                {
                    path = path + "\\" + selectedserie + "\\" + Number;
                    Directory.CreateDirectory(path);
                }

                if (cpy_checkrename.Checked == true)
                {
                    for (int i = 0; i < cpy_list_episode.Items.Count; i++)
                    {
                        File.Copy(cpy_list_episode.Items[i].ToString(), path + "\\" + cpy_list_episode_renommer.Items[i].ToString(), false);
                        this.Invoke(new Action(() =>
                        {
                            logBox.Text += "Fichier copié : " + cpy_list_episode_renommer.Items[i].ToString() + Environment.NewLine;
                        }));
                        backCopy.ReportProgress((i + 1) * 100 / cpy_list_episode.Items.Count);


                    }
                }
                else
                {
                    for (int i = 0; i < cpy_list_episode.Items.Count; i++)
                    {
                        File.Copy(cpy_list_episode.Items[1].ToString(), path + "\\" + Fonction.OnlyFileName(cpy_list_episode.Items[i].ToString()), false);
                        this.Invoke(new Action(() =>
                        {
                            logBox.Text += "Fichier copié : " + Fonction.OnlyFileName(cpy_list_episode.Items[i].ToString()) + Environment.NewLine;
                        }));
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Erreur : " + exp.Message);
            }

            this.Invoke(new Action(() =>
            {
                changed_enable(true);
            }));

        }

        private void backCopy_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backCopy_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cpy_btn_ValidationCopy.Text = "Valider";
        }

        //Menu Contextuel

        private void cpy_CMenu_btn_WaitList_CopyDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-Vous sure de vouloir supprimer les Episodes ?", Path.GetFileNameWithoutExtension(AppDomain.CurrentDomain.FriendlyName), MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (cpy_list_episode.Items.Count != 0)
                {
                    if (cpy_destinationPath())
                    {
                        string path = cpy_tb_DestinationPath.Text;
                        string selectedserie = "";
                        string Number = "";
                        selectedserie = Code.nameserie(cpy_list_episode_renommer.Items[0].ToString());
                        Number = cpy_cb_SeasonNumber.SelectedItem.ToString();

                        if (cpy_checkcreate.Checked == true)
                        {
                            path = path + "\\" + selectedserie + "\\" + Number;
                        }

                        if (cpy_checkrename.Checked == true)
                        {
                            for (int i = 0; i < cpy_list_episode.Items.Count; i++)
                            {
                                this.wl_dataGridView.Rows.Add("CopyDelete", cpy_list_episode.Items[i].ToString(), path + "\\" + cpy_list_episode_renommer.Items[i].ToString());
                            }
                        }
                        else
                        {
                            for (int i = 0; i < cpy_list_episode.Items.Count; i++)
                            {
                                this.wl_dataGridView.Rows.Add("CopyDelete", cpy_list_episode.Items[i].ToString(), path + "\\" + Fonction.OnlyFileName(cpy_list_episode.Items[i].ToString()));
                                this.Invoke(new Action(() =>
                                {
                                    logbox_addtext("Fichier copié : " + Fonction.OnlyFileName(cpy_list_episode.Items[i].ToString()));
                                }));
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas d'episode a traiter", "Veuillez selectioner des episodes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cpy_CMenu_btn_WaitList_Normal_Copy_Click(object sender, EventArgs e)
        {
            cpy_btn_WaitList_Click(sender, e);
        }

        private void cpy_CMenu_btn_ValidationCopy_Copy_Click(object sender, EventArgs e)
        {
            cpy_btn_ValidationCopy_Click(sender, e);
        }

        private void cpy_CMenu_btn_ValidationCopy_CopyDelete_Click(object sender, EventArgs e)
        {
            cpy_destinationPath();

            cpy_CMenu_btn_WaitList_CopyDelete_Click(sender, e);
            wl_btn_ValideWaitLIst_Click(sender, e);


        }

        //Fonction Speciale

        void cpy_load_series(string DirectoryPath)
        {
            cpy_tb_sourcepath.Text = DirectoryPath;
            string[] tabfiles;
            int i = 0;
            try
            {
                tabfiles = Directory.GetFiles(DirectoryPath, "*", SearchOption.AllDirectories);
                string[] tabserie = new string[tabfiles.Length];
                cpy_cb_Serie.Enabled = true;
                foreach (string file in tabfiles)
                {
                    if (Code.isSerie(Fonction.OnlyFileName(file)))
                    {
                        tabserie[i] = file;
                        i++;
                    }
                }

                cpy_list_episode.DataSource = null;

                cpy_list_episode.Items.Clear();
                cpy_cb_Serie.Items.Clear();
                cpy_cb_SeasonNumber.Items.Clear();
                cpy_list_episode_renommer.Items.Clear();

                tabserie = tabserie.Where(episode => !string.IsNullOrEmpty(episode)).ToArray();
                Array.Sort(tabserie);

                i = 0;
                string[] tabepisoderename = new string[tabserie.Length];
                foreach(string episode in tabserie)
                {
                    tabepisoderename[i] = Code.RenameSerie(Fonction.OnlyFileName(tabserie[i]));
                    i++;
                }
                Code.tabepisodeserie = tabserie;
                Code.tabepisodeserierename = tabepisoderename;
                Code.remplirlisteSerie(tabserie);


            }
            catch (Exception expt)
            {
                MessageBox.Show("L'erreur suivante s'est declaree :" + expt.Message);
            }
        }

        void cpy_add_title(int id_Serie)
        {
            logbox_addtext("Recherche des titres sur TheMovieDB ...");
            int i = 0;
            while (i < cpy_list_episode_renommer.Items.Count)
            {
                string newfilename = Code.addTitleToEpisode(cpy_list_episode_renommer.Items[i].ToString(), idSerie:id_Serie);
                int a = cpy_list_episode_renommer.Items.IndexOf(cpy_list_episode_renommer.Items[i].ToString());
                cpy_list_episode_renommer.Items.RemoveAt(a);
                cpy_list_episode_renommer.Items.Insert(a, newfilename);
                i++;
            }
            logbox_addtext("Recherche terminee");
        }

        private bool cpy_destinationPath(string path = "") //S'occupe de verifier ou de faire re;plir le chemin de destination
        {
            if(path == "")
            {
                path = cpy_tb_DestinationPath.Text;
            }
            if (path != "" && Directory.Exists(path))
            {
                cpy_tb_DestinationPath.Text = path;
                return true;

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Le chemin choisi n'aboutie pas\nVoulez-vous en selectionner un ?", "Erreur chemin dossier", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return false;
                }
            }
            if (folderBrowserEnregister.ShowDialog() == DialogResult.OK)
            {
                return(cpy_destinationPath(folderBrowserEnregister.SelectedPath));
            }
            else
            {
                return (false);
            }
        }

        private bool cpy_sourcePath(string path = "") //Verifie ou fait remplir la source
        {
            if (path == "")
            {
                path = cpy_tb_sourcepath.Text;
            }

            if (path != "" && Directory.Exists(path))
            {
                cpy_tb_sourcepath.Text = path;
                return true;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Le chemin choisi n'aboutie pas\nVoulez-vous en selectionner un ?", "Erreur chemin dossier", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return false;
                }
            }
            if (folderBrowserDialogParcourir.ShowDialog() == DialogResult.OK)
            {
                return (cpy_sourcePath(folderBrowserDialogParcourir.SelectedPath));
            }
            else
            {
                return (false);
            }
        }

        private void changed_enable(bool boolean)
        {
            cpy_list_episode.Enabled = boolean;
            cpy_list_episode_renommer.Enabled = boolean;
            cpy_btn_Parcourir.Enabled = boolean;
            cpy_btn_RemoveSelectedEpisode.Enabled = boolean;
            cpy_checkcreate.Enabled = boolean;
            cpy_checkrename.Enabled = boolean;
            cpy_btn_findTitle.Enabled = boolean;
        }

        private bool IcanWork()
        {
            if (cpy_list_episode_renommer.Items.Count > 0)
                return true;
            else
            {
                MessageBox.Show("Il n'y a pas d'épisodes à traiter", "FindSerie : Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        //---------------------------------- FIN COPIE ----------------------------------- 

        // ----------------------------------- RENAME ------------------------------------

        //BOUTON

        private void rnm_btn_actualiser_Click(object sender, EventArgs e)
        {
            if (rnm_src_path())
            {
                string[] tabfiles;
                if (sousdossier.Checked == true)
                    tabfiles = Directory.GetFiles(rnm_TB_Directory_Path.Text, "*", SearchOption.AllDirectories);
                else
                    tabfiles = Directory.GetFiles(rnm_TB_Directory_Path.Text);
                rnm_listBox1.Items.Clear();
                rnm_listBox2.Items.Clear();
                progressBar2.Maximum = tabfiles.Length;
                progressBar2.Step = 100;
                if (checkBox1.Checked == true)
                {
                    foreach (string file in tabfiles)
                    {
                        progressBar2.PerformStep();
                        if (Code.isSerie(Fonction.OnlyFileName(file)))
                        {
                            if ((Code.RenameSerie(Fonction.OnlyFileName(file)) != Fonction.OnlyFileName(file)) && Code.isBlackListed(@file) == false)
                                rnm_listBox1.Items.Add(file);
                        }
                    }
                }
                else
                {
                    foreach (string file in tabfiles)
                    {
                        if (Code.isSerie(Fonction.OnlyFileName(file)))
                        {
                            progressBar2.PerformStep();
                            rnm_listBox1.Items.Add(file);
                        }
                    }
                }
                if (rnm_listBox1.Items.Count == 0)
                {
                    MessageBox.Show("Aucune serie n'a ete trouvee");
                }
                else
                {
                    foreach (string path in rnm_listBox1.Items)
                    {
                        string newname = Code.RenameSerie(Fonction.OnlyFileName(path));
                        rnm_listBox2.Items.Add(newname);
                        progressBar2.PerformStep();
                    }
                }
                progressBar2.Value = 0;
            }
        }

        private void rnm_btn_BlackList_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"D:\Mes Fichiers\Documents\RenameSerie\BlackList.txt", true);

                foreach (string a in rnm_listBox1.SelectedItems)
                {
                    sw.WriteLine(a);
                    logbox_addtext(a + "                   post in BLACK LIST ");

                }
                sw.Close();
            }
            catch (Exception c)
            {
                logbox_addtext("Erreur: " + c.Message);
            }
            for (int i = rnm_listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                rnm_listBox2.Items.RemoveAt(rnm_listBox1.SelectedIndices[i]);
                rnm_listBox1.Items.RemoveAt(rnm_listBox1.SelectedIndices[i]);
            }
        }

        private void rnm_btn_selectiondelete_Click(object sender, EventArgs e)
        {
            rnm_deleting = true;
            for (int i = rnm_listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                rnm_listBox2.Items.RemoveAt(rnm_listBox1.SelectedIndices[i]);
                rnm_listBox1.Items.RemoveAt(rnm_listBox1.SelectedIndices[i]);
            }
            rnm_deleting = false;
        }

        private void rnm_btn_WaitList_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rnm_listBox2.Items.Count; i++)
            {
                string directorypath = Fonction.OnlyDirectoryPath(rnm_listBox1.Items[i].ToString());
                this.wl_dataGridView.Rows.Add("Rename", rnm_listBox1.Items[i].ToString(), directorypath + rnm_listBox2.Items[i].ToString());

            }
        }

        private void rnm_btn_validation_Click(object sender, EventArgs e)
        {
            rnm_btn_WaitList_Click(sender, e);
            wl_btn_ValideWaitLIst_Click(sender, e);
        }

        private void rnm_btn_parcourir_Click(object sender, EventArgs e)
        {
            rnm_TB_Directory_Path.Text = "";
            if (rnm_src_path())
            {
                string[] tabfiles;
                if (sousdossier.Checked == true)
                    tabfiles = Directory.GetFiles(rnm_TB_Directory_Path.Text, "*", SearchOption.AllDirectories);
                else
                    tabfiles = Directory.GetFiles(rnm_TB_Directory_Path.Text);
                rnm_listBox1.Items.Clear();
                rnm_listBox2.Items.Clear();
                progressBar2.Maximum = tabfiles.Length;
                progressBar2.Step = 100;
                if (checkBox1.Checked == true)
                {
                    foreach (string file in tabfiles)
                    {
                        progressBar2.PerformStep();
                        if (Code.isSerie(Fonction.OnlyFileName(file)))
                        {
                            if ((Code.RenameSerie(Fonction.OnlyFileName(file)) != Fonction.OnlyFileName(file)) && Code.isBlackListed(@file) == false)
                                rnm_listBox1.Items.Add(file);
                        }
                    }
                }
                else
                {
                    foreach (string file in tabfiles)
                    {
                        if (Code.isSerie(Fonction.OnlyFileName(file)))
                        {
                            progressBar2.PerformStep();
                            rnm_listBox1.Items.Add(file);
                        }
                    }
                }
                if (rnm_listBox1.Items.Count == 0)
                {
                    MessageBox.Show("Aucune serie n'a ete trouvee");
                }
                else
                {
                    foreach (string path in rnm_listBox1.Items)
                    {
                        string newname = Code.RenameSerie(Fonction.OnlyFileName(path));
                        rnm_listBox2.Items.Add(newname);
                        progressBar2.PerformStep();
                    }
                }
                progressBar2.Value = 0;
            }
        }

        private void rnm_btn_findTitle_Click(object sender, EventArgs e)
        {
            logbox_addtext("Recherche des titres sur TheMovieDB ...");
            try
            {
                int i = 0;
                while (i<rnm_listBox2.Items.Count)
                {
                    try
                    {
                        if (MovieDB.getIDofSerie(Code.nameserie(rnm_listBox2.Items[i].ToString())) != -1)
                        {
                            string newfilename = Code.addTitleToEpisode(rnm_listBox2.Items[i].ToString());
                            //int a = rnm_listBox2.Items.IndexOf(rnm_listBox2.Items[i].ToString());
                            rnm_listBox2.Items.RemoveAt(i);
                            rnm_listBox2.Items.Insert(i, newfilename);
                        }
                        else
                        {
                            logbox_addtext("Aucun resultat pour : " + rnm_listBox2.Items[i].ToString());
                        }
                        if (i == 20)
                        {

                        }
                        i++;
                    }
                    catch(Exception ex)
                    {
                        logbox_addtext(i.ToString());
                        Thread.Sleep(1000);//Attente de pouvoir refaire des requete sur TheMovieDB
                    }
                }
               
            }
            catch(Exception ex)
            {
                logbox_addtext(ex.Message);
            }
            logbox_addtext("Recherche terminee");
        }

        //LISTBOX

        private void rnm_listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!rnm_deleting)
            {
                int i = 0;
                while (i < rnm_listBox1.Items.Count)
                {
                    rnm_listBox2.SelectedIndexChanged -= rnm_listBox2_SelectedIndexChanged;
                    rnm_listBox2.SetSelected(i, rnm_listBox1.GetSelected(i));
                    rnm_listBox2.SelectedIndexChanged += rnm_listBox2_SelectedIndexChanged;
                    i++;
                }
            }

        }

        private void rnm_listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!rnm_deleting)
            {
                int i = 0;
                while (i < rnm_listBox2.Items.Count)
                {
                    rnm_listBox1.SelectedIndexChanged -= rnm_listBox1_SelectedIndexChanged;
                    rnm_listBox1.SetSelected(i, rnm_listBox2.GetSelected(i));
                    rnm_listBox1.SelectedIndexChanged += rnm_listBox1_SelectedIndexChanged;
                    i++;
                }

            }
        }

        //FONCTION SPECIALE

        private bool rnm_src_path(string path = "")
        {
            if (path == "")
            {
                path = rnm_TB_Directory_Path.Text;
            }

            if (path != "" && Directory.Exists(path))
            {
                rnm_TB_Directory_Path.Text = path;
                return true;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Le chemin choisi n'aboutie pas\nVoulez-vous en selectionner un ?", "Erreur chemin dossier", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return false;
                }
            }
            if (folderBrowserDialogParcourir.ShowDialog() == DialogResult.OK)
            {
                return (rnm_src_path(folderBrowserDialogParcourir.SelectedPath));
            }
            else
            {
                return (false);
            }
        }

    // FIN RENAME

    // ------------------------------- WAITLIST -------------------------------

        //BOUTON
        private void wl_btn_delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in wl_dataGridView.SelectedRows)
            {
                wl_dataGridView.Rows.Remove(r);
            }
        }

        private void wl_btn_ValideWaitLIst_Click(object sender, EventArgs e)
        {
            if (!back_Worker.IsBusy)
            {
                back_Worker.RunWorkerAsync();
            }
        }

        //DATAGRIDVIEW
        private void wl_dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            string opeType = wl_dataGridView.Rows[wl_dataGridView.Rows.Count - 1].Cells[0].Value.ToString() + " : ";
            string information = wl_dataGridView.Rows[wl_dataGridView.Rows.Count - 1].Cells[2].Value.ToString();
            logbox_addtext("Tache Ajoutee --> " + opeType + information);
        }

        // FIN WAITLIST

    // ------------------------------- SETTING -------------------------------

       //Code pour BOUTTON

        private void stg_btn_save_Click(object sender, EventArgs e)
        {
            parameter.Default.cpy_default_bool_src = stg_cpy_ck_default_sources.Checked;
            parameter.Default.cpy_default_src = stg_cpy_TB_default_sources.Text;
            parameter.Default.cpy_default_bool_dst = stg_cpy_ck_default_destination.Checked;
            parameter.Default.cpy_default_dst = stg_cpy_TB_default_destination.Text;
            parameter.Default.cpy_bool_create_tree = stg_cpy_ck_Active_Create_Folder.Checked;
            parameter.Default.cpy_bool_rename_file = stg_cpy_ck_active_rename.Checked;
            parameter.Default.rnm_default_bool_src = stg_rnm_ck_Default_Source.Checked;
            parameter.Default.rnm_default_src = stg_rnm_tb_Default_Source.Text;
            parameter.Default.Save();
            logbox_addtext("All settings was save !");
            loadParameter();
        }

        private void stg_Btn_default_sources_Click(object sender, EventArgs e)
        {
            if (folderBrowserEnregister.ShowDialog() == DialogResult.OK)
            {
                stg_cpy_TB_default_sources.Text = folderBrowserEnregister.SelectedPath;
            }
        }

        private void stg_rnm_bt_Broswer_DS_Click(object sender, EventArgs e)
        {
            if (folderBrowserEnregister.ShowDialog() == DialogResult.OK)
            {
                stg_rnm_tb_Default_Source.Text = folderBrowserEnregister.SelectedPath;
            }
        }

        private void stg_Btn_default_destination_Click(object sender, EventArgs e)
        {
            if (folderBrowserEnregister.ShowDialog() == DialogResult.OK)
            {
                stg_cpy_TB_default_destination.Text = folderBrowserEnregister.SelectedPath;
            }
        }

        private void stg_btn_cancel_Click(object sender, EventArgs e)
        {
            loadParameter();
        }

        //Code pour CHECKBOX

        private void stg_ck_default_sources_CheckedChanged(object sender, EventArgs e)
        {
            if (stg_cpy_ck_default_sources.Checked == false)
            {
                stg_cpy_TB_default_sources.Enabled = false;
                stg_Btn_default_sources.Enabled = false;
            }
            else
            {
                stg_cpy_TB_default_sources.Enabled = true;
                stg_Btn_default_sources.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieDbSelectSerie SearchSerie = new MovieDbSelectSerie("Casa de papel");
            SearchSerie.Show();
        }

        //FIN SETTING

    }
}