namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.panelOnline = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelOnlineSearch = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxOnline = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewOnline = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelFavorites = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelSongSum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxFavorites = new System.Windows.Forms.RichTextBox();
            this.listViewFavorites = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSinger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.panelLocal = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelSongInfo = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuFavorites = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuOnline = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDown = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSong = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelOnline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelFavorites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLocal.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuFavorites.SuspendLayout();
            this.contextMenuOnline.SuspendLayout();
            this.panelSong.SuspendLayout();
            this.contextMenuHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.listBoxMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 45;
            this.listBoxMenu.Items.AddRange(new object[] {
            "🎵 音乐馆",
            "❤ 我喜欢",
            "🏠 本地音乐",
            "🕓 最近播放",
            "🧒 个人空间"});
            this.listBoxMenu.Location = new System.Drawing.Point(0, 112);
            this.listBoxMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(255, 674);
            this.listBoxMenu.TabIndex = 0;
            this.listBoxMenu.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxMenu_DrawItem);
            this.listBoxMenu.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBoxMenu_MeasureItem);
            this.listBoxMenu.SelectedIndexChanged += new System.EventHandler(this.listBoxMenu_SelectedIndexChanged);
            // 
            // panelOnline
            // 
            this.panelOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelOnline.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelOnline.Controls.Add(this.labelOnlineSearch);
            this.panelOnline.Controls.Add(this.label8);
            this.panelOnline.Controls.Add(this.pictureBox3);
            this.panelOnline.Controls.Add(this.label12);
            this.panelOnline.Controls.Add(this.label10);
            this.panelOnline.Controls.Add(this.textBoxOnline);
            this.panelOnline.Controls.Add(this.label1);
            this.panelOnline.Controls.Add(this.listViewOnline);
            this.panelOnline.Location = new System.Drawing.Point(253, 0);
            this.panelOnline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOnline.Name = "panelOnline";
            this.panelOnline.Size = new System.Drawing.Size(1003, 702);
            this.panelOnline.TabIndex = 1;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 3);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(247, 45);
            this.axWindowsMediaPlayer1.TabIndex = 17;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // labelOnlineSearch
            // 
            this.labelOnlineSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOnlineSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelOnlineSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOnlineSearch.ForeColor = System.Drawing.Color.LightGray;
            this.labelOnlineSearch.Location = new System.Drawing.Point(684, 101);
            this.labelOnlineSearch.Name = "labelOnlineSearch";
            this.labelOnlineSearch.Size = new System.Drawing.Size(45, 42);
            this.labelOnlineSearch.TabIndex = 10;
            this.labelOnlineSearch.Text = "🔍";
            this.labelOnlineSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOnlineSearch.Click += new System.EventHandler(this.labelOnlineSearch_Click);
            this.labelOnlineSearch.MouseEnter += new System.EventHandler(this.labelOnlineSearch_MouseEnter);
            this.labelOnlineSearch.MouseLeave += new System.EventHandler(this.labelOnlineSearch_MouseLeave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(388, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 42);
            this.label8.TabIndex = 16;
            this.label8.Text = "一起听音乐吧";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::MusicPlayer.Properties.Resources.女孩_1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(382, 251);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(279, 240);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(301, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(383, 8);
            this.label12.TabIndex = 14;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(301, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(383, 8);
            this.label10.TabIndex = 13;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOnline
            // 
            this.textBoxOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.textBoxOnline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOnline.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxOnline.ForeColor = System.Drawing.Color.Silver;
            this.textBoxOnline.Location = new System.Drawing.Point(301, 109);
            this.textBoxOnline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOnline.Name = "textBoxOnline";
            this.textBoxOnline.Size = new System.Drawing.Size(383, 27);
            this.textBoxOnline.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(293, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 42);
            this.label1.TabIndex = 11;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewOnline
            // 
            this.listViewOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listViewOnline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewOnline.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewOnline.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewOnline.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listViewOnline.FullRowSelect = true;
            this.listViewOnline.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewOnline.HideSelection = false;
            this.listViewOnline.Location = new System.Drawing.Point(70, 191);
            this.listViewOnline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewOnline.MultiSelect = false;
            this.listViewOnline.Name = "listViewOnline";
            this.listViewOnline.OwnerDraw = true;
            this.listViewOnline.Size = new System.Drawing.Size(867, 511);
            this.listViewOnline.TabIndex = 8;
            this.listViewOnline.TabStop = false;
            this.listViewOnline.UseCompatibleStateImageBehavior = false;
            this.listViewOnline.View = System.Windows.Forms.View.Details;
            this.listViewOnline.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listViewOnline_DrawSubItem);
            this.listViewOnline.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewOnline_MouseDoubleClick);
            this.listViewOnline.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewOnline_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "歌曲";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "歌手";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "专辑";
            this.columnHeader3.Width = 0;
            // 
            // panelFavorites
            // 
            this.panelFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelFavorites.Controls.Add(this.label11);
            this.panelFavorites.Controls.Add(this.labelSearch);
            this.panelFavorites.Controls.Add(this.labelSongSum);
            this.panelFavorites.Controls.Add(this.pictureBox1);
            this.panelFavorites.Controls.Add(this.textBoxFavorites);
            this.panelFavorites.Controls.Add(this.listViewFavorites);
            this.panelFavorites.Controls.Add(this.label2);
            this.panelFavorites.Location = new System.Drawing.Point(250, 0);
            this.panelFavorites.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFavorites.Name = "panelFavorites";
            this.panelFavorites.Size = new System.Drawing.Size(1003, 702);
            this.panelFavorites.TabIndex = 2;
            this.panelFavorites.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(715, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 30);
            this.label11.TabIndex = 7;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.labelSearch.ForeColor = System.Drawing.Color.LightGray;
            this.labelSearch.Location = new System.Drawing.Point(903, 167);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(32, 30);
            this.labelSearch.TabIndex = 6;
            this.labelSearch.Text = "🔍";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSongSum
            // 
            this.labelSongSum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSongSum.ForeColor = System.Drawing.Color.Silver;
            this.labelSongSum.Location = new System.Drawing.Point(263, 161);
            this.labelSongSum.Name = "labelSongSum";
            this.labelSongSum.Size = new System.Drawing.Size(112, 36);
            this.labelSongSum.TabIndex = 5;
            this.labelSongSum.Text = "歌曲 109";
            this.labelSongSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MusicPlayer.Properties.Resources.Higher_Brothers_Lover_Boy_88;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(70, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 169);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxFavorites
            // 
            this.textBoxFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.textBoxFavorites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFavorites.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFavorites.ForeColor = System.Drawing.Color.Silver;
            this.textBoxFavorites.Location = new System.Drawing.Point(729, 167);
            this.textBoxFavorites.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFavorites.Multiline = false;
            this.textBoxFavorites.Name = "textBoxFavorites";
            this.textBoxFavorites.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBoxFavorites.Size = new System.Drawing.Size(184, 30);
            this.textBoxFavorites.TabIndex = 3;
            this.textBoxFavorites.TabStop = false;
            this.textBoxFavorites.Text = "";
            this.textBoxFavorites.TextChanged += new System.EventHandler(this.textBoxFavorites_TextChanged);
            // 
            // listViewFavorites
            // 
            this.listViewFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listViewFavorites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewFavorites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderSinger,
            this.columnHeaderAlbum});
            this.listViewFavorites.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewFavorites.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listViewFavorites.FullRowSelect = true;
            this.listViewFavorites.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewFavorites.HideSelection = false;
            this.listViewFavorites.Location = new System.Drawing.Point(70, 239);
            this.listViewFavorites.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewFavorites.MultiSelect = false;
            this.listViewFavorites.Name = "listViewFavorites";
            this.listViewFavorites.OwnerDraw = true;
            this.listViewFavorites.Scrollable = false;
            this.listViewFavorites.Size = new System.Drawing.Size(868, 463);
            this.listViewFavorites.TabIndex = 1;
            this.listViewFavorites.TabStop = false;
            this.listViewFavorites.UseCompatibleStateImageBehavior = false;
            this.listViewFavorites.View = System.Windows.Forms.View.Details;
            this.listViewFavorites.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listViewFavorites_DrawSubItem);
            this.listViewFavorites.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewFavorites_MouseDoubleClick);
            this.listViewFavorites.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewFavorites_MouseDown);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "歌曲";
            // 
            // columnHeaderSinger
            // 
            this.columnHeaderSinger.Text = "歌手";
            // 
            // columnHeaderAlbum
            // 
            this.columnHeaderAlbum.Text = "专辑";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(255, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 109);
            this.label2.TabIndex = 0;
            this.label2.Text = "我喜欢";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLocal
            // 
            this.panelLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelLocal.Controls.Add(this.label3);
            this.panelLocal.Location = new System.Drawing.Point(250, 0);
            this.panelLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLocal.Name = "panelLocal";
            this.panelLocal.Size = new System.Drawing.Size(1006, 702);
            this.panelLocal.TabIndex = 3;
            this.panelLocal.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(539, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "本地音乐";
            // 
            // panelUser
            // 
            this.panelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelUser.Controls.Add(this.label5);
            this.panelUser.Location = new System.Drawing.Point(250, 0);
            this.panelUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(1006, 702);
            this.panelUser.TabIndex = 4;
            this.panelUser.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(539, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "个人空间";
            // 
            // panelHistory
            // 
            this.panelHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelHistory.Controls.Add(this.listViewHistory);
            this.panelHistory.Controls.Add(this.pictureBox4);
            this.panelHistory.Controls.Add(this.label7);
            this.panelHistory.Controls.Add(this.label9);
            this.panelHistory.Controls.Add(this.label4);
            this.panelHistory.Location = new System.Drawing.Point(250, 0);
            this.panelHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(1006, 702);
            this.panelHistory.TabIndex = 4;
            this.panelHistory.Visible = false;
            // 
            // listViewHistory
            // 
            this.listViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listViewHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewHistory.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewHistory.HideSelection = false;
            this.listViewHistory.Location = new System.Drawing.Point(71, 216);
            this.listViewHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewHistory.MultiSelect = false;
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.OwnerDraw = true;
            this.listViewHistory.Scrollable = false;
            this.listViewHistory.Size = new System.Drawing.Size(868, 463);
            this.listViewHistory.TabIndex = 10;
            this.listViewHistory.TabStop = false;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            this.listViewHistory.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listViewHistory_DrawSubItem);
            this.listViewHistory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewHistory_MouseDoubleClick);
            this.listViewHistory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewHistory_MouseDown);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "歌曲";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "歌手";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "专辑";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::MusicPlayer.Properties.Resources.Higher_Brothers_Lover_Boy_88;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(68, 23);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 169);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(270, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 57);
            this.label7.TabIndex = 8;
            this.label7.Text = "我的听歌排行";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(538, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "最近播放";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(539, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "最近播放";
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelControl.Controls.Add(this.pictureBox6);
            this.panelControl.Controls.Add(this.labelSongInfo);
            this.panelControl.Controls.Add(this.pictureBox5);
            this.panelControl.Controls.Add(this.pictureBoxAlbum);
            this.panelControl.Location = new System.Drawing.Point(253, 702);
            this.panelControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1003, 85);
            this.panelControl.TabIndex = 5;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(505, 16);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(78, 68);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // labelSongInfo
            // 
            this.labelSongInfo.AutoSize = true;
            this.labelSongInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSongInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelSongInfo.Location = new System.Drawing.Point(104, 11);
            this.labelSongInfo.Name = "labelSongInfo";
            this.labelSongInfo.Size = new System.Drawing.Size(0, 24);
            this.labelSongInfo.TabIndex = 18;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(505, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(78, 68);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(7, 6);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(76, 71);
            this.pictureBoxAlbum.TabIndex = 18;
            this.pictureBoxAlbum.TabStop = false;
            this.pictureBoxAlbum.Click += new System.EventHandler(this.pictureBoxAlbum_Click);
            this.pictureBoxAlbum.MouseEnter += new System.EventHandler(this.pictureBoxAlbum_MouseEnter);
            this.pictureBoxAlbum.MouseLeave += new System.EventHandler(this.pictureBoxAlbum_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 115);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MusicPlayer.Properties.Resources.logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(44, 36);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 60);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // contextMenuFavorites
            // 
            this.contextMenuFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.contextMenuFavorites.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuFavorites.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRemove,
            this.MenuItemDownload});
            this.contextMenuFavorites.Name = "contextMenuFavorites";
            this.contextMenuFavorites.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuFavorites.ShowImageMargin = false;
            this.contextMenuFavorites.Size = new System.Drawing.Size(184, 52);
            // 
            // MenuItemRemove
            // 
            this.MenuItemRemove.ForeColor = System.Drawing.Color.White;
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.Size = new System.Drawing.Size(183, 24);
            this.MenuItemRemove.Text = "🗑 从我喜欢中移除";
            this.MenuItemRemove.Click += new System.EventHandler(this.MenuItemRemove_Click);
            // 
            // MenuItemDownload
            // 
            this.MenuItemDownload.ForeColor = System.Drawing.Color.White;
            this.MenuItemDownload.Name = "MenuItemDownload";
            this.MenuItemDownload.Size = new System.Drawing.Size(183, 24);
            this.MenuItemDownload.Text = " 👇 下载此歌曲";
            this.MenuItemDownload.Click += new System.EventHandler(this.MenuItemDownload_Click);
            // 
            // contextMenuOnline
            // 
            this.contextMenuOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.contextMenuOnline.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuOnline.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAdd,
            this.MenuItemDown});
            this.contextMenuOnline.Name = "contextMenuFavorites";
            this.contextMenuOnline.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuOnline.ShowImageMargin = false;
            this.contextMenuOnline.Size = new System.Drawing.Size(169, 52);
            // 
            // MenuItemAdd
            // 
            this.MenuItemAdd.ForeColor = System.Drawing.Color.White;
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.Size = new System.Drawing.Size(168, 24);
            this.MenuItemAdd.Text = "❤ 添加到我喜欢";
            this.MenuItemAdd.Click += new System.EventHandler(this.MenuItemAdd_Click);
            // 
            // MenuItemDown
            // 
            this.MenuItemDown.ForeColor = System.Drawing.Color.White;
            this.MenuItemDown.Name = "MenuItemDown";
            this.MenuItemDown.Size = new System.Drawing.Size(168, 24);
            this.MenuItemDown.Text = " 👇 下载此歌曲";
            this.MenuItemDown.Click += new System.EventHandler(this.MenuItemDown_Click);
            // 
            // panelSong
            // 
            this.panelSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelSong.Controls.Add(this.label6);
            this.panelSong.Location = new System.Drawing.Point(250, 0);
            this.panelSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSong.Name = "panelSong";
            this.panelSong.Size = new System.Drawing.Size(1085, 702);
            this.panelSong.TabIndex = 17;
            this.panelSong.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(502, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "展示专辑图片和歌词";
            // 
            // contextMenuHistory
            // 
            this.contextMenuHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.contextMenuHistory.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuHistory.Name = "contextMenuFavorites";
            this.contextMenuHistory.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuHistory.ShowImageMargin = false;
            this.contextMenuHistory.Size = new System.Drawing.Size(169, 52);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 24);
            this.toolStripMenuItem1.Text = "❤ 添加到我喜欢";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 24);
            this.toolStripMenuItem2.Text = " 👇 下载此歌曲";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "听歌次数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1252, 787);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.panelFavorites);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panelLocal);
            this.Controls.Add(this.panelSong);
            this.Controls.Add(this.panelOnline);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelOnline.ResumeLayout(false);
            this.panelOnline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelFavorites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLocal.ResumeLayout(false);
            this.panelLocal.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelHistory.ResumeLayout(false);
            this.panelHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuFavorites.ResumeLayout(false);
            this.contextMenuOnline.ResumeLayout(false);
            this.panelSong.ResumeLayout(false);
            this.panelSong.PerformLayout();
            this.contextMenuHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Panel panelOnline;
        private System.Windows.Forms.Panel panelFavorites;
        private System.Windows.Forms.Panel panelLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewFavorites;
        private System.Windows.Forms.RichTextBox textBoxFavorites;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSongSum;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSinger;
        private System.Windows.Forms.ColumnHeader columnHeaderAlbum;
        private System.Windows.Forms.ContextMenuStrip contextMenuFavorites;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDownload;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRemove;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOnlineSearch;
        private System.Windows.Forms.ListView listViewOnline;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBoxOnline;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuOnline;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.Label labelSongInfo;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panelSong;
        private System.Windows.Forms.Label label6;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuHistory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

