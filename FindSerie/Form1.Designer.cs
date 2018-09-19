namespace FindSerie
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            cpy_cb_Serie = new System.Windows.Forms.ComboBox();
            this.cpy_btn_RemoveSelectedEpisode = new System.Windows.Forms.Button();
            this.cpy_list_episode_renommer = new System.Windows.Forms.ListBox();
            this.cpy_checkrename = new System.Windows.Forms.CheckBox();
            this.cpy_list_episode = new System.Windows.Forms.ListBox();
            this.cpy_tb_sourcepath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpy_btn_Parcourir = new System.Windows.Forms.Button();
            this.folderBrowserDialogParcourir = new System.Windows.Forms.FolderBrowserDialog();
            this.cpy_cb_SeasonNumber = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.logBox = new System.Windows.Forms.TextBox();
            this.folderBrowserEnregister = new System.Windows.Forms.FolderBrowserDialog();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.cpy_checkcreate = new System.Windows.Forms.CheckBox();
            this.backCopy = new System.ComponentModel.BackgroundWorker();
            this.cpy_btn_modnameserie = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCopy = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cpy_btn_SelectDestinationPath = new System.Windows.Forms.Button();
            this.cpy_groupebox_Ajouter = new System.Windows.Forms.GroupBox();
            this.cpy_btn_addFinal = new System.Windows.Forms.Button();
            this.cpy_btn_findTitle = new System.Windows.Forms.Button();
            this.cpy_btn_ValidationCopy = new System.Windows.Forms.Button();
            this.cpy_btn_verify_presence = new System.Windows.Forms.Button();
            this.cpy_tb_DestinationPath = new System.Windows.Forms.TextBox();
            this.cpy_btn_go = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cpy_btn_WaitList = new System.Windows.Forms.Button();
            this.Cpy_ContextMenu_btn_WaitList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cpy_CMenu_btn_WaitList_Normal_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.cpy_CMenu_btn_WaitList_CopyDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabRename = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rnm_btn_findTitle = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.rnm_btn_WaitList = new System.Windows.Forms.Button();
            this.rnm_btn_validation = new System.Windows.Forms.Button();
            this.rnm_btn_actualiser = new System.Windows.Forms.Button();
            this.rnm_btn_BlackList = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sousdossier = new System.Windows.Forms.CheckBox();
            this.rnm_btn_selectiondelete = new System.Windows.Forms.Button();
            this.rnm_listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rnm_listBox1 = new System.Windows.Forms.ListBox();
            this.rnm_btn_parcourir = new System.Windows.Forms.Button();
            this.rnm_TB_Directory_Path = new System.Windows.Forms.TextBox();
            this.tabWaitList = new System.Windows.Forms.TabPage();
            this.wl_btn_delete = new System.Windows.Forms.Button();
            this.btn_ValideWaitLIst = new System.Windows.Forms.Button();
            this.wl_dataGridView = new System.Windows.Forms.DataGridView();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stg_rnm_tb_Default_Source = new System.Windows.Forms.TextBox();
            this.stg_rnm_ck_Default_Source = new System.Windows.Forms.CheckBox();
            this.stg_rnm_bt_Broswer_DS = new System.Windows.Forms.Button();
            this.stg_btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stg_cpy_ck_delete_aftercopy = new System.Windows.Forms.CheckBox();
            this.stg_cpy_TB_default_destination = new System.Windows.Forms.TextBox();
            this.stg_Btn_default_destination = new System.Windows.Forms.Button();
            this.stg_cpy_TB_default_sources = new System.Windows.Forms.TextBox();
            this.stg_cpy_ck_default_sources = new System.Windows.Forms.CheckBox();
            this.stg_cpy_ck_active_rename = new System.Windows.Forms.CheckBox();
            this.stg_cpy_ck_default_destination = new System.Windows.Forms.CheckBox();
            this.stg_cpy_ck_Active_Create_Folder = new System.Windows.Forms.CheckBox();
            this.stg_Btn_default_sources = new System.Windows.Forms.Button();
            this.stg_btn_save = new System.Windows.Forms.Button();
            this.back_Worker = new System.ComponentModel.BackgroundWorker();
            this.cpy_ContextMenu_btn_ValidationCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cpy_CMenu_btn_ValidationCopy_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.cpy_CMenu_btn_ValidationCopy_CopyDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltip_btn_AddFinal = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCopy.SuspendLayout();
            this.cpy_groupebox_Ajouter.SuspendLayout();
            this.Cpy_ContextMenu_btn_WaitList.SuspendLayout();
            this.tabRename.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabWaitList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wl_dataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cpy_ContextMenu_btn_ValidationCopy.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpy_cb_Serie
            // 
            cpy_cb_Serie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cpy_cb_Serie.FormattingEnabled = true;
            cpy_cb_Serie.Location = new System.Drawing.Point(130, 100);
            cpy_cb_Serie.Margin = new System.Windows.Forms.Padding(4);
            cpy_cb_Serie.Name = "cpy_cb_Serie";
            cpy_cb_Serie.Size = new System.Drawing.Size(440, 33);
            cpy_cb_Serie.TabIndex = 1;
            cpy_cb_Serie.SelectedIndexChanged += new System.EventHandler(cpy_cb_Serie_SelectedIndexChanged);
            // 
            // cpy_btn_RemoveSelectedEpisode
            // 
            this.cpy_btn_RemoveSelectedEpisode.Location = new System.Drawing.Point(92, 156);
            this.cpy_btn_RemoveSelectedEpisode.Margin = new System.Windows.Forms.Padding(4);
            this.cpy_btn_RemoveSelectedEpisode.Name = "cpy_btn_RemoveSelectedEpisode";
            this.cpy_btn_RemoveSelectedEpisode.Size = new System.Drawing.Size(276, 40);
            this.cpy_btn_RemoveSelectedEpisode.TabIndex = 4;
            this.cpy_btn_RemoveSelectedEpisode.Text = "Supprimer";
            this.cpy_btn_RemoveSelectedEpisode.UseVisualStyleBackColor = true;
            this.cpy_btn_RemoveSelectedEpisode.Click += new System.EventHandler(this.cpy_btn_RemoveSelectedEpisode_Click);
            // 
            // cpy_list_episode_renommer
            // 
            this.cpy_list_episode_renommer.Enabled = false;
            this.cpy_list_episode_renommer.FormattingEnabled = true;
            this.cpy_list_episode_renommer.ItemHeight = 25;
            this.cpy_list_episode_renommer.Location = new System.Drawing.Point(896, 212);
            this.cpy_list_episode_renommer.Margin = new System.Windows.Forms.Padding(4);
            this.cpy_list_episode_renommer.Name = "cpy_list_episode_renommer";
            this.cpy_list_episode_renommer.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.cpy_list_episode_renommer.Size = new System.Drawing.Size(768, 879);
            this.cpy_list_episode_renommer.TabIndex = 7;
            this.cpy_list_episode_renommer.SelectedIndexChanged += new System.EventHandler(this.cpy_list_episode_renommer_SelectedIndexChanged);
            // 
            // cpy_checkrename
            // 
            this.cpy_checkrename.AutoSize = true;
            this.cpy_checkrename.Location = new System.Drawing.Point(820, 121);
            this.cpy_checkrename.Margin = new System.Windows.Forms.Padding(4);
            this.cpy_checkrename.Name = "cpy_checkrename";
            this.cpy_checkrename.Size = new System.Drawing.Size(275, 29);
            this.cpy_checkrename.TabIndex = 9;
            this.cpy_checkrename.Text = "Renommer les épisodes";
            this.cpy_checkrename.UseVisualStyleBackColor = true;
            // 
            // cpy_list_episode
            // 
            this.cpy_list_episode.Enabled = false;
            this.cpy_list_episode.FormattingEnabled = true;
            this.cpy_list_episode.HorizontalScrollbar = true;
            this.cpy_list_episode.ItemHeight = 25;
            this.cpy_list_episode.Location = new System.Drawing.Point(49, 212);
            this.cpy_list_episode.Margin = new System.Windows.Forms.Padding(4);
            this.cpy_list_episode.Name = "cpy_list_episode";
            this.cpy_list_episode.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.cpy_list_episode.Size = new System.Drawing.Size(768, 879);
            this.cpy_list_episode.TabIndex = 10;
            this.cpy_list_episode.SelectedIndexChanged += new System.EventHandler(this.cpy_list_episode_SelectedIndexChanged);
            // 
            // cpy_tb_sourcepath
            // 
            this.cpy_tb_sourcepath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cpy_tb_sourcepath.Location = new System.Drawing.Point(130, 34);
            this.cpy_tb_sourcepath.Margin = new System.Windows.Forms.Padding(4);
            this.cpy_tb_sourcepath.Name = "cpy_tb_sourcepath";
            this.cpy_tb_sourcepath.Size = new System.Drawing.Size(1068, 31);
            this.cpy_tb_sourcepath.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Source :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Serie :";
            // 
            // cpy_btn_Parcourir
            // 
            this.cpy_btn_Parcourir.Location = new System.Drawing.Point(1297, 34);
            this.cpy_btn_Parcourir.Margin = new System.Windows.Forms.Padding(4);
            this.cpy_btn_Parcourir.Name = "cpy_btn_Parcourir";
            this.cpy_btn_Parcourir.Size = new System.Drawing.Size(172, 44);
            this.cpy_btn_Parcourir.TabIndex = 14;
            this.cpy_btn_Parcourir.Text = "Parcourir";
            this.cpy_btn_Parcourir.UseVisualStyleBackColor = true;
            this.cpy_btn_Parcourir.Click += new System.EventHandler(this.cpy_btn_Parcourir_Click);
            // 
            // cpy_cb_SeasonNumber
            // 
            this.cpy_cb_SeasonNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpy_cb_SeasonNumber.Enabled = false;
            this.cpy_cb_SeasonNumber.FormattingEnabled = true;
            this.cpy_cb_SeasonNumber.Location = new System.Drawing.Point(608, 100);
            this.cpy_cb_SeasonNumber.Margin = new System.Windows.Forms.Padding(4);
            this.cpy_cb_SeasonNumber.Name = "cpy_cb_SeasonNumber";
            this.cpy_cb_SeasonNumber.Size = new System.Drawing.Size(120, 33);
            this.cpy_cb_SeasonNumber.TabIndex = 15;
            this.cpy_cb_SeasonNumber.SelectedIndexChanged += new System.EventHandler(this.cpy_cb_SeasonNumber_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(238, 1243);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1365, 42);
            this.progressBar1.TabIndex = 16;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(112, 1306);
            this.logBox.Margin = new System.Windows.Forms.Padding(4);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logBox.Size = new System.Drawing.Size(1590, 381);
            this.logBox.TabIndex = 17;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // cpy_checkcreate
            // 
            this.cpy_checkcreate.AutoSize = true;
            this.cpy_checkcreate.Location = new System.Drawing.Point(820, 84);
            this.cpy_checkcreate.Margin = new System.Windows.Forms.Padding(4);
            this.cpy_checkcreate.Name = "cpy_checkcreate";
            this.cpy_checkcreate.Size = new System.Drawing.Size(276, 29);
            this.cpy_checkcreate.TabIndex = 18;
            this.cpy_checkcreate.Text = "Creer une arboressence";
            this.cpy_checkcreate.UseVisualStyleBackColor = true;
            // 
            // backCopy
            // 
            this.backCopy.WorkerReportsProgress = true;
            this.backCopy.WorkerSupportsCancellation = true;
            this.backCopy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backCopy_DoWork);
            this.backCopy.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backCopy_ProgressChanged);
            this.backCopy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backCopy_RunWorkerCompleted);
            // 
            // cpy_btn_modnameserie
            // 
            this.cpy_btn_modnameserie.Location = new System.Drawing.Point(375, 156);
            this.cpy_btn_modnameserie.Name = "cpy_btn_modnameserie";
            this.cpy_btn_modnameserie.Size = new System.Drawing.Size(236, 40);
            this.cpy_btn_modnameserie.TabIndex = 19;
            this.cpy_btn_modnameserie.Text = "Modifier nom serie";
            this.cpy_btn_modnameserie.UseVisualStyleBackColor = true;
            this.cpy_btn_modnameserie.Click += new System.EventHandler(this.cpy_btn_modnameserie_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCopy);
            this.tabControl1.Controls.Add(this.tabRename);
            this.tabControl1.Controls.Add(this.tabWaitList);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1731, 1224);
            this.tabControl1.TabIndex = 20;
            // 
            // tabCopy
            // 
            this.tabCopy.BackColor = System.Drawing.Color.Transparent;
            this.tabCopy.Controls.Add(this.button1);
            this.tabCopy.Controls.Add(this.cpy_btn_SelectDestinationPath);
            this.tabCopy.Controls.Add(this.cpy_groupebox_Ajouter);
            this.tabCopy.Controls.Add(this.cpy_btn_ValidationCopy);
            this.tabCopy.Controls.Add(this.cpy_btn_verify_presence);
            this.tabCopy.Controls.Add(this.cpy_tb_DestinationPath);
            this.tabCopy.Controls.Add(this.cpy_btn_go);
            this.tabCopy.Controls.Add(this.label3);
            this.tabCopy.Controls.Add(this.cpy_btn_WaitList);
            this.tabCopy.Controls.Add(this.cpy_list_episode_renommer);
            this.tabCopy.Controls.Add(this.cpy_list_episode);
            this.tabCopy.Controls.Add(this.cpy_btn_modnameserie);
            this.tabCopy.Controls.Add(this.cpy_cb_SeasonNumber);
            this.tabCopy.Controls.Add(cpy_cb_Serie);
            this.tabCopy.Controls.Add(this.label1);
            this.tabCopy.Controls.Add(this.cpy_checkrename);
            this.tabCopy.Controls.Add(this.cpy_checkcreate);
            this.tabCopy.Controls.Add(this.label2);
            this.tabCopy.Controls.Add(this.cpy_btn_Parcourir);
            this.tabCopy.Controls.Add(this.cpy_btn_RemoveSelectedEpisode);
            this.tabCopy.Controls.Add(this.cpy_tb_sourcepath);
            this.tabCopy.Location = new System.Drawing.Point(8, 39);
            this.tabCopy.Name = "tabCopy";
            this.tabCopy.Padding = new System.Windows.Forms.Padding(3);
            this.tabCopy.Size = new System.Drawing.Size(1715, 1177);
            this.tabCopy.TabIndex = 0;
            this.tabCopy.Text = "Copy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1507, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 59);
            this.button1.TabIndex = 35;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cpy_btn_SelectDestinationPath
            // 
            this.cpy_btn_SelectDestinationPath.Location = new System.Drawing.Point(1165, 1116);
            this.cpy_btn_SelectDestinationPath.Name = "cpy_btn_SelectDestinationPath";
            this.cpy_btn_SelectDestinationPath.Size = new System.Drawing.Size(51, 32);
            this.cpy_btn_SelectDestinationPath.TabIndex = 34;
            this.cpy_btn_SelectDestinationPath.Text = "...";
            this.cpy_btn_SelectDestinationPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cpy_btn_SelectDestinationPath.UseVisualStyleBackColor = true;
            this.cpy_btn_SelectDestinationPath.Click += new System.EventHandler(this.cpy_btn_SelectDestinationPath_Click);
            // 
            // cpy_groupebox_Ajouter
            // 
            this.cpy_groupebox_Ajouter.Controls.Add(this.cpy_btn_addFinal);
            this.cpy_groupebox_Ajouter.Controls.Add(this.cpy_btn_findTitle);
            this.cpy_groupebox_Ajouter.Location = new System.Drawing.Point(1269, 131);
            this.cpy_groupebox_Ajouter.Name = "cpy_groupebox_Ajouter";
            this.cpy_groupebox_Ajouter.Size = new System.Drawing.Size(339, 74);
            this.cpy_groupebox_Ajouter.TabIndex = 33;
            this.cpy_groupebox_Ajouter.TabStop = false;
            this.cpy_groupebox_Ajouter.Text = "Ajouter";
            // 
            // cpy_btn_addFinal
            // 
            this.cpy_btn_addFinal.Location = new System.Drawing.Point(184, 26);
            this.cpy_btn_addFinal.Name = "cpy_btn_addFinal";
            this.cpy_btn_addFinal.Size = new System.Drawing.Size(130, 39);
            this.cpy_btn_addFinal.TabIndex = 33;
            this.cpy_btn_addFinal.Text = "Final";
            this.cpy_btn_addFinal.UseVisualStyleBackColor = true;
            this.cpy_btn_addFinal.Click += new System.EventHandler(this.cpy_btn_addFinal_Click);
            // 
            // cpy_btn_findTitle
            // 
            this.cpy_btn_findTitle.Location = new System.Drawing.Point(28, 26);
            this.cpy_btn_findTitle.Name = "cpy_btn_findTitle";
            this.cpy_btn_findTitle.Size = new System.Drawing.Size(130, 39);
            this.cpy_btn_findTitle.TabIndex = 32;
            this.cpy_btn_findTitle.Text = "Les Titres";
            this.cpy_btn_findTitle.UseVisualStyleBackColor = true;
            this.cpy_btn_findTitle.Click += new System.EventHandler(this.cpy_btn_findTitle_Click);
            // 
            // cpy_btn_ValidationCopy
            // 
            this.cpy_btn_ValidationCopy.Location = new System.Drawing.Point(1257, 1117);
            this.cpy_btn_ValidationCopy.Name = "cpy_btn_ValidationCopy";
            this.cpy_btn_ValidationCopy.Size = new System.Drawing.Size(160, 41);
            this.cpy_btn_ValidationCopy.TabIndex = 25;
            this.cpy_btn_ValidationCopy.Text = "Valider";
            this.cpy_btn_ValidationCopy.UseVisualStyleBackColor = true;
            this.cpy_btn_ValidationCopy.Click += new System.EventHandler(this.cpy_btn_ValidationCopy_Click);
            // 
            // cpy_btn_verify_presence
            // 
            this.cpy_btn_verify_presence.Location = new System.Drawing.Point(912, 156);
            this.cpy_btn_verify_presence.Name = "cpy_btn_verify_presence";
            this.cpy_btn_verify_presence.Size = new System.Drawing.Size(323, 39);
            this.cpy_btn_verify_presence.TabIndex = 24;
            this.cpy_btn_verify_presence.Text = "Enlever Episode(s) Existant(s)";
            this.cpy_btn_verify_presence.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cpy_btn_verify_presence.UseVisualStyleBackColor = true;
            this.cpy_btn_verify_presence.Click += new System.EventHandler(this.cpy_btn_verify_presence_Click);
            // 
            // cpy_tb_DestinationPath
            // 
            this.cpy_tb_DestinationPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cpy_tb_DestinationPath.Location = new System.Drawing.Point(90, 1117);
            this.cpy_tb_DestinationPath.Margin = new System.Windows.Forms.Padding(4);
            this.cpy_tb_DestinationPath.Name = "cpy_tb_DestinationPath";
            this.cpy_tb_DestinationPath.Size = new System.Drawing.Size(1068, 31);
            this.cpy_tb_DestinationPath.TabIndex = 23;
            // 
            // cpy_btn_go
            // 
            this.cpy_btn_go.Location = new System.Drawing.Point(1218, 31);
            this.cpy_btn_go.Margin = new System.Windows.Forms.Padding(4);
            this.cpy_btn_go.Name = "cpy_btn_go";
            this.cpy_btn_go.Size = new System.Drawing.Size(71, 47);
            this.cpy_btn_go.TabIndex = 22;
            this.cpy_btn_go.Text = "GO";
            this.cpy_btn_go.UseVisualStyleBackColor = true;
            this.cpy_btn_go.Click += new System.EventHandler(this.cpy_btn_go_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1423, 1134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "ou";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cpy_btn_WaitList
            // 
            this.cpy_btn_WaitList.ContextMenuStrip = this.Cpy_ContextMenu_btn_WaitList;
            this.cpy_btn_WaitList.Location = new System.Drawing.Point(1464, 1117);
            this.cpy_btn_WaitList.Name = "cpy_btn_WaitList";
            this.cpy_btn_WaitList.Size = new System.Drawing.Size(218, 42);
            this.cpy_btn_WaitList.TabIndex = 20;
            this.cpy_btn_WaitList.Text = "File d\'attente";
            this.cpy_btn_WaitList.UseVisualStyleBackColor = true;
            this.cpy_btn_WaitList.Click += new System.EventHandler(this.cpy_btn_WaitList_Click);
            // 
            // Cpy_ContextMenu_btn_WaitList
            // 
            this.Cpy_ContextMenu_btn_WaitList.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Cpy_ContextMenu_btn_WaitList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cpy_CMenu_btn_WaitList_Normal_Copy,
            this.cpy_CMenu_btn_WaitList_CopyDelete});
            this.Cpy_ContextMenu_btn_WaitList.Name = "Cpy_ContextMenu_btn_WaitList";
            this.Cpy_ContextMenu_btn_WaitList.Size = new System.Drawing.Size(504, 76);
            // 
            // cpy_CMenu_btn_WaitList_Normal_Copy
            // 
            this.cpy_CMenu_btn_WaitList_Normal_Copy.Name = "cpy_CMenu_btn_WaitList_Normal_Copy";
            this.cpy_CMenu_btn_WaitList_Normal_Copy.Size = new System.Drawing.Size(503, 36);
            this.cpy_CMenu_btn_WaitList_Normal_Copy.Text = "Executer Copie";
            this.cpy_CMenu_btn_WaitList_Normal_Copy.Click += new System.EventHandler(this.cpy_CMenu_btn_WaitList_Normal_Copy_Click);
            // 
            // cpy_CMenu_btn_WaitList_CopyDelete
            // 
            this.cpy_CMenu_btn_WaitList_CopyDelete.Name = "cpy_CMenu_btn_WaitList_CopyDelete";
            this.cpy_CMenu_btn_WaitList_CopyDelete.Size = new System.Drawing.Size(503, 36);
            this.cpy_CMenu_btn_WaitList_CopyDelete.Text = "Copie et Supprimer Fichier(s) Source(s)";
            this.cpy_CMenu_btn_WaitList_CopyDelete.Click += new System.EventHandler(this.cpy_CMenu_btn_WaitList_CopyDelete_Click);
            // 
            // tabRename
            // 
            this.tabRename.Controls.Add(this.groupBox2);
            this.tabRename.Controls.Add(this.progressBar2);
            this.tabRename.Controls.Add(this.label6);
            this.tabRename.Controls.Add(this.rnm_btn_WaitList);
            this.tabRename.Controls.Add(this.rnm_btn_validation);
            this.tabRename.Controls.Add(this.rnm_btn_actualiser);
            this.tabRename.Controls.Add(this.rnm_btn_BlackList);
            this.tabRename.Controls.Add(this.checkBox1);
            this.tabRename.Controls.Add(this.sousdossier);
            this.tabRename.Controls.Add(this.rnm_btn_selectiondelete);
            this.tabRename.Controls.Add(this.rnm_listBox2);
            this.tabRename.Controls.Add(this.label4);
            this.tabRename.Controls.Add(this.label5);
            this.tabRename.Controls.Add(this.rnm_listBox1);
            this.tabRename.Controls.Add(this.rnm_btn_parcourir);
            this.tabRename.Controls.Add(this.rnm_TB_Directory_Path);
            this.tabRename.Location = new System.Drawing.Point(8, 39);
            this.tabRename.Name = "tabRename";
            this.tabRename.Size = new System.Drawing.Size(1715, 1177);
            this.tabRename.TabIndex = 2;
            this.tabRename.Text = "Rename";
            this.tabRename.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.rnm_btn_findTitle);
            this.groupBox2.Location = new System.Drawing.Point(737, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 74);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajouter";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 39);
            this.button2.TabIndex = 33;
            this.button2.Text = "Final";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rnm_btn_findTitle
            // 
            this.rnm_btn_findTitle.Location = new System.Drawing.Point(28, 26);
            this.rnm_btn_findTitle.Name = "rnm_btn_findTitle";
            this.rnm_btn_findTitle.Size = new System.Drawing.Size(130, 39);
            this.rnm_btn_findTitle.TabIndex = 32;
            this.rnm_btn_findTitle.Text = "Les Titres";
            this.rnm_btn_findTitle.UseVisualStyleBackColor = true;
            this.rnm_btn_findTitle.Click += new System.EventHandler(this.rnm_btn_findTitle_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(473, 69);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(410, 29);
            this.progressBar2.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1423, 1138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "ou";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rnm_btn_WaitList
            // 
            this.rnm_btn_WaitList.Location = new System.Drawing.Point(1464, 1121);
            this.rnm_btn_WaitList.Name = "rnm_btn_WaitList";
            this.rnm_btn_WaitList.Size = new System.Drawing.Size(218, 42);
            this.rnm_btn_WaitList.TabIndex = 27;
            this.rnm_btn_WaitList.Text = "File d\'attente";
            this.rnm_btn_WaitList.UseVisualStyleBackColor = true;
            this.rnm_btn_WaitList.Click += new System.EventHandler(this.rnm_btn_WaitList_Click);
            // 
            // rnm_btn_validation
            // 
            this.rnm_btn_validation.Location = new System.Drawing.Point(1198, 1121);
            this.rnm_btn_validation.Margin = new System.Windows.Forms.Padding(4);
            this.rnm_btn_validation.Name = "rnm_btn_validation";
            this.rnm_btn_validation.Size = new System.Drawing.Size(218, 42);
            this.rnm_btn_validation.TabIndex = 26;
            this.rnm_btn_validation.Text = "Valider";
            this.rnm_btn_validation.UseVisualStyleBackColor = true;
            this.rnm_btn_validation.Click += new System.EventHandler(this.rnm_btn_validation_Click);
            // 
            // rnm_btn_actualiser
            // 
            this.rnm_btn_actualiser.Location = new System.Drawing.Point(1433, 13);
            this.rnm_btn_actualiser.Margin = new System.Windows.Forms.Padding(6);
            this.rnm_btn_actualiser.Name = "rnm_btn_actualiser";
            this.rnm_btn_actualiser.Size = new System.Drawing.Size(150, 44);
            this.rnm_btn_actualiser.TabIndex = 25;
            this.rnm_btn_actualiser.Text = "Actualiser";
            this.rnm_btn_actualiser.UseVisualStyleBackColor = true;
            this.rnm_btn_actualiser.Click += new System.EventHandler(this.rnm_btn_actualiser_Click);
            // 
            // rnm_btn_BlackList
            // 
            this.rnm_btn_BlackList.Location = new System.Drawing.Point(204, 1119);
            this.rnm_btn_BlackList.Margin = new System.Windows.Forms.Padding(6);
            this.rnm_btn_BlackList.Name = "rnm_btn_BlackList";
            this.rnm_btn_BlackList.Size = new System.Drawing.Size(396, 44);
            this.rnm_btn_BlackList.TabIndex = 24;
            this.rnm_btn_BlackList.Text = "Black LIster selection";
            this.rnm_btn_BlackList.UseVisualStyleBackColor = true;
            this.rnm_btn_BlackList.Click += new System.EventHandler(this.rnm_btn_BlackList_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(1198, 69);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(347, 29);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Ne pas inclure fichier deja traite";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // sousdossier
            // 
            this.sousdossier.AutoSize = true;
            this.sousdossier.Checked = true;
            this.sousdossier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sousdossier.Location = new System.Drawing.Point(892, 69);
            this.sousdossier.Margin = new System.Windows.Forms.Padding(6);
            this.sousdossier.Name = "sousdossier";
            this.sousdossier.Size = new System.Drawing.Size(282, 29);
            this.sousdossier.TabIndex = 22;
            this.sousdossier.Text = "Inclure les sous-dossiers";
            this.sousdossier.UseVisualStyleBackColor = true;
            // 
            // rnm_btn_selectiondelete
            // 
            this.rnm_btn_selectiondelete.Location = new System.Drawing.Point(612, 1119);
            this.rnm_btn_selectiondelete.Margin = new System.Windows.Forms.Padding(6);
            this.rnm_btn_selectiondelete.Name = "rnm_btn_selectiondelete";
            this.rnm_btn_selectiondelete.Size = new System.Drawing.Size(374, 44);
            this.rnm_btn_selectiondelete.TabIndex = 21;
            this.rnm_btn_selectiondelete.Text = "Suprimer selection";
            this.rnm_btn_selectiondelete.UseVisualStyleBackColor = true;
            this.rnm_btn_selectiondelete.Click += new System.EventHandler(this.rnm_btn_selectiondelete_Click);
            // 
            // rnm_listBox2
            // 
            this.rnm_listBox2.ColumnWidth = 405;
            this.rnm_listBox2.FormattingEnabled = true;
            this.rnm_listBox2.HorizontalScrollbar = true;
            this.rnm_listBox2.ItemHeight = 25;
            this.rnm_listBox2.Location = new System.Drawing.Point(1166, 203);
            this.rnm_listBox2.Margin = new System.Windows.Forms.Padding(6);
            this.rnm_listBox2.Name = "rnm_listBox2";
            this.rnm_listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.rnm_listBox2.Size = new System.Drawing.Size(496, 904);
            this.rnm_listBox2.TabIndex = 20;
            this.rnm_listBox2.SelectedIndexChanged += new System.EventHandler(this.rnm_listBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fichier Present";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1161, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nouveau Nom";
            // 
            // rnm_listBox1
            // 
            this.rnm_listBox1.ColumnWidth = 405;
            this.rnm_listBox1.FormattingEnabled = true;
            this.rnm_listBox1.ItemHeight = 25;
            this.rnm_listBox1.Location = new System.Drawing.Point(57, 203);
            this.rnm_listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.rnm_listBox1.Name = "rnm_listBox1";
            this.rnm_listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.rnm_listBox1.Size = new System.Drawing.Size(1069, 904);
            this.rnm_listBox1.TabIndex = 17;
            this.rnm_listBox1.SelectedIndexChanged += new System.EventHandler(this.rnm_listBox1_SelectedIndexChanged);
            // 
            // rnm_btn_parcourir
            // 
            this.rnm_btn_parcourir.Location = new System.Drawing.Point(1263, 15);
            this.rnm_btn_parcourir.Margin = new System.Windows.Forms.Padding(6);
            this.rnm_btn_parcourir.Name = "rnm_btn_parcourir";
            this.rnm_btn_parcourir.Size = new System.Drawing.Size(158, 42);
            this.rnm_btn_parcourir.TabIndex = 15;
            this.rnm_btn_parcourir.Text = "Parcourir";
            this.rnm_btn_parcourir.UseVisualStyleBackColor = true;
            this.rnm_btn_parcourir.Click += new System.EventHandler(this.rnm_btn_parcourir_Click);
            // 
            // rnm_TB_Directory_Path
            // 
            this.rnm_TB_Directory_Path.Location = new System.Drawing.Point(57, 26);
            this.rnm_TB_Directory_Path.Margin = new System.Windows.Forms.Padding(6);
            this.rnm_TB_Directory_Path.Name = "rnm_TB_Directory_Path";
            this.rnm_TB_Directory_Path.Size = new System.Drawing.Size(1160, 31);
            this.rnm_TB_Directory_Path.TabIndex = 14;
            // 
            // tabWaitList
            // 
            this.tabWaitList.Controls.Add(this.wl_btn_delete);
            this.tabWaitList.Controls.Add(this.btn_ValideWaitLIst);
            this.tabWaitList.Controls.Add(this.wl_dataGridView);
            this.tabWaitList.Location = new System.Drawing.Point(8, 39);
            this.tabWaitList.Name = "tabWaitList";
            this.tabWaitList.Padding = new System.Windows.Forms.Padding(3);
            this.tabWaitList.Size = new System.Drawing.Size(1715, 1177);
            this.tabWaitList.TabIndex = 1;
            this.tabWaitList.Text = "File D\'attente";
            this.tabWaitList.UseVisualStyleBackColor = true;
            // 
            // wl_btn_delete
            // 
            this.wl_btn_delete.Location = new System.Drawing.Point(429, 1099);
            this.wl_btn_delete.Name = "wl_btn_delete";
            this.wl_btn_delete.Size = new System.Drawing.Size(293, 44);
            this.wl_btn_delete.TabIndex = 2;
            this.wl_btn_delete.Text = "Supprimer de la liste";
            this.wl_btn_delete.UseVisualStyleBackColor = true;
            this.wl_btn_delete.Click += new System.EventHandler(this.wl_btn_delete_Click);
            // 
            // btn_ValideWaitLIst
            // 
            this.btn_ValideWaitLIst.Location = new System.Drawing.Point(1467, 1098);
            this.btn_ValideWaitLIst.Name = "btn_ValideWaitLIst";
            this.btn_ValideWaitLIst.Size = new System.Drawing.Size(179, 45);
            this.btn_ValideWaitLIst.TabIndex = 1;
            this.btn_ValideWaitLIst.Text = "Valider";
            this.btn_ValideWaitLIst.UseVisualStyleBackColor = true;
            this.btn_ValideWaitLIst.Click += new System.EventHandler(this.wl_btn_ValideWaitLIst_Click);
            // 
            // wl_dataGridView
            // 
            this.wl_dataGridView.AllowUserToAddRows = false;
            this.wl_dataGridView.AllowUserToDeleteRows = false;
            this.wl_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wl_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType,
            this.colAvant,
            this.colApres});
            this.wl_dataGridView.Location = new System.Drawing.Point(28, 18);
            this.wl_dataGridView.Name = "wl_dataGridView";
            this.wl_dataGridView.ReadOnly = true;
            this.wl_dataGridView.RowTemplate.Height = 33;
            this.wl_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wl_dataGridView.Size = new System.Drawing.Size(1670, 1050);
            this.wl_dataGridView.TabIndex = 0;
            this.wl_dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.wl_dataGridView1_RowsAdded);
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colAvant
            // 
            this.colAvant.HeaderText = "Avant";
            this.colAvant.Name = "colAvant";
            this.colAvant.ReadOnly = true;
            // 
            // colApres
            // 
            this.colApres.HeaderText = "Apres";
            this.colApres.Name = "colApres";
            this.colApres.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.stg_btn_cancel);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.stg_btn_save);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1715, 1177);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stg_rnm_tb_Default_Source);
            this.groupBox3.Controls.Add(this.stg_rnm_ck_Default_Source);
            this.groupBox3.Controls.Add(this.stg_rnm_bt_Broswer_DS);
            this.groupBox3.Location = new System.Drawing.Point(81, 469);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1468, 356);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rename";
            // 
            // stg_rnm_tb_Default_Source
            // 
            this.stg_rnm_tb_Default_Source.Location = new System.Drawing.Point(303, 98);
            this.stg_rnm_tb_Default_Source.Name = "stg_rnm_tb_Default_Source";
            this.stg_rnm_tb_Default_Source.Size = new System.Drawing.Size(1066, 31);
            this.stg_rnm_tb_Default_Source.TabIndex = 0;
            // 
            // stg_rnm_ck_Default_Source
            // 
            this.stg_rnm_ck_Default_Source.AutoSize = true;
            this.stg_rnm_ck_Default_Source.Location = new System.Drawing.Point(45, 100);
            this.stg_rnm_ck_Default_Source.Name = "stg_rnm_ck_Default_Source";
            this.stg_rnm_ck_Default_Source.Size = new System.Drawing.Size(227, 29);
            this.stg_rnm_ck_Default_Source.TabIndex = 1;
            this.stg_rnm_ck_Default_Source.Text = "Source par defaut :";
            this.stg_rnm_ck_Default_Source.UseVisualStyleBackColor = true;
            // 
            // stg_rnm_bt_Broswer_DS
            // 
            this.stg_rnm_bt_Broswer_DS.Location = new System.Drawing.Point(1375, 97);
            this.stg_rnm_bt_Broswer_DS.Name = "stg_rnm_bt_Broswer_DS";
            this.stg_rnm_bt_Broswer_DS.Size = new System.Drawing.Size(51, 32);
            this.stg_rnm_bt_Broswer_DS.TabIndex = 9;
            this.stg_rnm_bt_Broswer_DS.Text = "...";
            this.stg_rnm_bt_Broswer_DS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stg_rnm_bt_Broswer_DS.UseVisualStyleBackColor = true;
            this.stg_rnm_bt_Broswer_DS.Click += new System.EventHandler(this.stg_rnm_bt_Broswer_DS_Click);
            // 
            // stg_btn_cancel
            // 
            this.stg_btn_cancel.Location = new System.Drawing.Point(1247, 1087);
            this.stg_btn_cancel.Name = "stg_btn_cancel";
            this.stg_btn_cancel.Size = new System.Drawing.Size(192, 48);
            this.stg_btn_cancel.TabIndex = 16;
            this.stg_btn_cancel.Text = "Annuler";
            this.stg_btn_cancel.UseVisualStyleBackColor = true;
            this.stg_btn_cancel.Click += new System.EventHandler(this.stg_btn_cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stg_cpy_ck_delete_aftercopy);
            this.groupBox1.Controls.Add(this.stg_cpy_TB_default_destination);
            this.groupBox1.Controls.Add(this.stg_Btn_default_destination);
            this.groupBox1.Controls.Add(this.stg_cpy_TB_default_sources);
            this.groupBox1.Controls.Add(this.stg_cpy_ck_default_sources);
            this.groupBox1.Controls.Add(this.stg_cpy_ck_active_rename);
            this.groupBox1.Controls.Add(this.stg_cpy_ck_default_destination);
            this.groupBox1.Controls.Add(this.stg_cpy_ck_Active_Create_Folder);
            this.groupBox1.Controls.Add(this.stg_Btn_default_sources);
            this.groupBox1.Location = new System.Drawing.Point(81, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1468, 356);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copy";
            // 
            // stg_cpy_ck_delete_aftercopy
            // 
            this.stg_cpy_ck_delete_aftercopy.AutoSize = true;
            this.stg_cpy_ck_delete_aftercopy.Location = new System.Drawing.Point(47, 53);
            this.stg_cpy_ck_delete_aftercopy.Name = "stg_cpy_ck_delete_aftercopy";
            this.stg_cpy_ck_delete_aftercopy.Size = new System.Drawing.Size(369, 29);
            this.stg_cpy_ck_delete_aftercopy.TabIndex = 4;
            this.stg_cpy_ck_delete_aftercopy.Text = "Supprimer les fichiers apres copie";
            this.stg_cpy_ck_delete_aftercopy.UseVisualStyleBackColor = true;
            // 
            // stg_cpy_TB_default_destination
            // 
            this.stg_cpy_TB_default_destination.Location = new System.Drawing.Point(303, 148);
            this.stg_cpy_TB_default_destination.Name = "stg_cpy_TB_default_destination";
            this.stg_cpy_TB_default_destination.Size = new System.Drawing.Size(1066, 31);
            this.stg_cpy_TB_default_destination.TabIndex = 7;
            // 
            // stg_Btn_default_destination
            // 
            this.stg_Btn_default_destination.Location = new System.Drawing.Point(1375, 150);
            this.stg_Btn_default_destination.Name = "stg_Btn_default_destination";
            this.stg_Btn_default_destination.Size = new System.Drawing.Size(51, 32);
            this.stg_Btn_default_destination.TabIndex = 13;
            this.stg_Btn_default_destination.Text = "...";
            this.stg_Btn_default_destination.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stg_Btn_default_destination.UseVisualStyleBackColor = true;
            this.stg_Btn_default_destination.Click += new System.EventHandler(this.stg_Btn_default_destination_Click);
            // 
            // stg_cpy_TB_default_sources
            // 
            this.stg_cpy_TB_default_sources.Location = new System.Drawing.Point(303, 98);
            this.stg_cpy_TB_default_sources.Name = "stg_cpy_TB_default_sources";
            this.stg_cpy_TB_default_sources.Size = new System.Drawing.Size(1066, 31);
            this.stg_cpy_TB_default_sources.TabIndex = 0;
            // 
            // stg_cpy_ck_default_sources
            // 
            this.stg_cpy_ck_default_sources.AutoSize = true;
            this.stg_cpy_ck_default_sources.Location = new System.Drawing.Point(45, 100);
            this.stg_cpy_ck_default_sources.Name = "stg_cpy_ck_default_sources";
            this.stg_cpy_ck_default_sources.Size = new System.Drawing.Size(227, 29);
            this.stg_cpy_ck_default_sources.TabIndex = 1;
            this.stg_cpy_ck_default_sources.Text = "Source par defaut :";
            this.stg_cpy_ck_default_sources.UseVisualStyleBackColor = true;
            this.stg_cpy_ck_default_sources.CheckedChanged += new System.EventHandler(this.stg_ck_default_sources_CheckedChanged);
            // 
            // stg_cpy_ck_active_rename
            // 
            this.stg_cpy_ck_active_rename.AutoSize = true;
            this.stg_cpy_ck_active_rename.Location = new System.Drawing.Point(555, 201);
            this.stg_cpy_ck_active_rename.Name = "stg_cpy_ck_active_rename";
            this.stg_cpy_ck_active_rename.Size = new System.Drawing.Size(484, 29);
            this.stg_cpy_ck_active_rename.TabIndex = 6;
            this.stg_cpy_ck_active_rename.Text = "Activer le rennomage des episodes par defaut";
            this.stg_cpy_ck_active_rename.UseVisualStyleBackColor = true;
            // 
            // stg_cpy_ck_default_destination
            // 
            this.stg_cpy_ck_default_destination.AutoSize = true;
            this.stg_cpy_ck_default_destination.Location = new System.Drawing.Point(45, 150);
            this.stg_cpy_ck_default_destination.Name = "stg_cpy_ck_default_destination";
            this.stg_cpy_ck_default_destination.Size = new System.Drawing.Size(255, 29);
            this.stg_cpy_ck_default_destination.TabIndex = 2;
            this.stg_cpy_ck_default_destination.Text = "Destination par defaut";
            this.stg_cpy_ck_default_destination.UseVisualStyleBackColor = true;
            // 
            // stg_cpy_ck_Active_Create_Folder
            // 
            this.stg_cpy_ck_Active_Create_Folder.AutoSize = true;
            this.stg_cpy_ck_Active_Create_Folder.Location = new System.Drawing.Point(45, 201);
            this.stg_cpy_ck_Active_Create_Folder.Name = "stg_cpy_ck_Active_Create_Folder";
            this.stg_cpy_ck_Active_Create_Folder.Size = new System.Drawing.Size(472, 29);
            this.stg_cpy_ck_Active_Create_Folder.TabIndex = 3;
            this.stg_cpy_ck_Active_Create_Folder.Text = "Activer la creation d\'arborescence par defaut";
            this.stg_cpy_ck_Active_Create_Folder.UseVisualStyleBackColor = true;
            // 
            // stg_Btn_default_sources
            // 
            this.stg_Btn_default_sources.Location = new System.Drawing.Point(1375, 97);
            this.stg_Btn_default_sources.Name = "stg_Btn_default_sources";
            this.stg_Btn_default_sources.Size = new System.Drawing.Size(51, 32);
            this.stg_Btn_default_sources.TabIndex = 9;
            this.stg_Btn_default_sources.Text = "...";
            this.stg_Btn_default_sources.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stg_Btn_default_sources.UseVisualStyleBackColor = true;
            this.stg_Btn_default_sources.Click += new System.EventHandler(this.stg_Btn_default_sources_Click);
            // 
            // stg_btn_save
            // 
            this.stg_btn_save.Location = new System.Drawing.Point(1445, 1087);
            this.stg_btn_save.Name = "stg_btn_save";
            this.stg_btn_save.Size = new System.Drawing.Size(185, 49);
            this.stg_btn_save.TabIndex = 14;
            this.stg_btn_save.Text = "Enregistrer";
            this.stg_btn_save.UseVisualStyleBackColor = true;
            this.stg_btn_save.Click += new System.EventHandler(this.stg_btn_save_Click);
            // 
            // back_Worker
            // 
            this.back_Worker.WorkerReportsProgress = true;
            this.back_Worker.WorkerSupportsCancellation = true;
            this.back_Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.back_Worker_DoWork);
            this.back_Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.back_Worker_ProgressChanged);
            this.back_Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.back_Worker_RunWorkerCompleted);
            // 
            // cpy_ContextMenu_btn_ValidationCopy
            // 
            this.cpy_ContextMenu_btn_ValidationCopy.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cpy_ContextMenu_btn_ValidationCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cpy_CMenu_btn_ValidationCopy_Copy,
            this.cpy_CMenu_btn_ValidationCopy_CopyDelete});
            this.cpy_ContextMenu_btn_ValidationCopy.Name = "Cpy_ContextMenu_btn_ValidationCopy";
            this.cpy_ContextMenu_btn_ValidationCopy.Size = new System.Drawing.Size(504, 76);
            // 
            // cpy_CMenu_btn_ValidationCopy_Copy
            // 
            this.cpy_CMenu_btn_ValidationCopy_Copy.Name = "cpy_CMenu_btn_ValidationCopy_Copy";
            this.cpy_CMenu_btn_ValidationCopy_Copy.Size = new System.Drawing.Size(503, 36);
            this.cpy_CMenu_btn_ValidationCopy_Copy.Text = "Copié";
            this.cpy_CMenu_btn_ValidationCopy_Copy.Click += new System.EventHandler(this.cpy_CMenu_btn_ValidationCopy_Copy_Click);
            // 
            // cpy_CMenu_btn_ValidationCopy_CopyDelete
            // 
            this.cpy_CMenu_btn_ValidationCopy_CopyDelete.Name = "cpy_CMenu_btn_ValidationCopy_CopyDelete";
            this.cpy_CMenu_btn_ValidationCopy_CopyDelete.Size = new System.Drawing.Size(503, 36);
            this.cpy_CMenu_btn_ValidationCopy_CopyDelete.Text = "Copie et Supprimer Fichier(s) Source(s)";
            this.cpy_CMenu_btn_ValidationCopy_CopyDelete.Click += new System.EventHandler(this.cpy_CMenu_btn_ValidationCopy_CopyDelete_Click);
            // 
            // tooltip_btn_AddFinal
            // 
            this.tooltip_btn_AddFinal.ToolTipTitle = "Ajouter \"Final\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1829, 1728);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.progressBar1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCopy.ResumeLayout(false);
            this.tabCopy.PerformLayout();
            this.cpy_groupebox_Ajouter.ResumeLayout(false);
            this.Cpy_ContextMenu_btn_WaitList.ResumeLayout(false);
            this.tabRename.ResumeLayout(false);
            this.tabRename.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabWaitList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wl_dataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cpy_ContextMenu_btn_ValidationCopy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cpy_btn_RemoveSelectedEpisode;
        private System.Windows.Forms.CheckBox cpy_checkrename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cpy_btn_Parcourir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogParcourir;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserEnregister;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.CheckBox cpy_checkcreate;
        public System.Windows.Forms.ComboBox cpy_cb_SeasonNumber;
        public System.Windows.Forms.TextBox cpy_tb_sourcepath;
        public System.Windows.Forms.TextBox logBox;
        public System.Windows.Forms.ListBox cpy_list_episode_renommer;
        public System.Windows.Forms.ListBox cpy_list_episode;
        private System.ComponentModel.BackgroundWorker backCopy;
        private System.Windows.Forms.Button cpy_btn_modnameserie;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCopy;
        private System.Windows.Forms.TabPage tabWaitList;
        private System.Windows.Forms.DataGridView wl_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cpy_btn_WaitList;
        private System.Windows.Forms.Button btn_ValideWaitLIst;
        private System.ComponentModel.BackgroundWorker back_Worker;
        private System.Windows.Forms.TabPage tabRename;
        private System.Windows.Forms.Button rnm_btn_actualiser;
        public System.Windows.Forms.Button rnm_btn_BlackList;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox sousdossier;
        public System.Windows.Forms.Button rnm_btn_selectiondelete;
        public System.Windows.Forms.ListBox rnm_listBox2;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox rnm_listBox1;
        public System.Windows.Forms.Button rnm_btn_parcourir;
        public System.Windows.Forms.TextBox rnm_TB_Directory_Path;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button rnm_btn_WaitList;
        private System.Windows.Forms.Button rnm_btn_validation;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button wl_btn_delete;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button stg_Btn_default_destination;
        private System.Windows.Forms.Button stg_Btn_default_sources;
        private System.Windows.Forms.TextBox stg_cpy_TB_default_destination;
        private System.Windows.Forms.CheckBox stg_cpy_ck_active_rename;
        private System.Windows.Forms.CheckBox stg_cpy_ck_delete_aftercopy;
        private System.Windows.Forms.CheckBox stg_cpy_ck_Active_Create_Folder;
        private System.Windows.Forms.CheckBox stg_cpy_ck_default_destination;
        private System.Windows.Forms.CheckBox stg_cpy_ck_default_sources;
        private System.Windows.Forms.TextBox stg_cpy_TB_default_sources;
        private System.Windows.Forms.Button stg_btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cpy_btn_go;
        public System.Windows.Forms.TextBox cpy_tb_DestinationPath;
        private System.Windows.Forms.Button cpy_btn_verify_presence;
        private System.Windows.Forms.Button cpy_btn_ValidationCopy;
        private System.Windows.Forms.ContextMenuStrip Cpy_ContextMenu_btn_WaitList;
        private System.Windows.Forms.ToolStripMenuItem cpy_CMenu_btn_WaitList_Normal_Copy;
        private System.Windows.Forms.ToolStripMenuItem cpy_CMenu_btn_WaitList_CopyDelete;
        private System.Windows.Forms.ContextMenuStrip cpy_ContextMenu_btn_ValidationCopy;
        private System.Windows.Forms.ToolStripMenuItem cpy_CMenu_btn_ValidationCopy_Copy;
        private System.Windows.Forms.ToolStripMenuItem cpy_CMenu_btn_ValidationCopy_CopyDelete;
        private System.Windows.Forms.Button stg_btn_cancel;
        private System.Windows.Forms.ToolTip tooltip_btn_AddFinal;
        private System.Windows.Forms.Button cpy_btn_findTitle;
        private System.Windows.Forms.GroupBox cpy_groupebox_Ajouter;
        private System.Windows.Forms.Button cpy_btn_addFinal;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button cpy_btn_SelectDestinationPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button rnm_btn_findTitle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox stg_rnm_tb_Default_Source;
        private System.Windows.Forms.CheckBox stg_rnm_ck_Default_Source;
        private System.Windows.Forms.Button stg_rnm_bt_Broswer_DS;
        public static System.Windows.Forms.ComboBox cpy_cb_Serie;
    }
} 




