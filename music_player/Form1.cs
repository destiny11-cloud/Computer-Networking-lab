using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MusicPlayer
{
    
    public partial class Form1 : Form
    {
        SQLiteConnection conn = null;
        private List<SongInfo> songs = new List<SongInfo>();
        private SongInfo selectedSong;
        private bool songFullScreen = false;   //是否将歌曲全屏
        private readonly string userID;

        public Form1(string userID)
        {
            InitializeComponent();
            listBoxMenu.SelectedItem = listBoxMenu.Items[0];
            this.userID = userID;
            conn = database.dbcon.getConnection();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            listViewFavorites.Columns[0].Width = listViewFavorites.Width * 2 / 5;
            listViewFavorites.Columns[1].Width = listViewFavorites.Width * 1 / 5;
            listViewFavorites.Columns[2].Width = listViewFavorites.Width * 370 / 1000;
            listViewOnline.Columns[0].Width = listViewFavorites.Width * 2 / 5;
            listViewOnline.Columns[1].Width = listViewFavorites.Width * 1 / 5;
            listViewOnline.Columns[2].Width = listViewFavorites.Width * 370 / 1000;
        }
        #region 侧边栏相关
        private void listBoxMenu_DrawItem(object sender, DrawItemEventArgs e)
        {
            Bitmap bitmap = new Bitmap(e.Bounds.Width, e.Bounds.Height);                                   
            Graphics tempG = Graphics.FromImage(bitmap);

            // 使绘图质量最高
            tempG.SmoothingMode = SmoothingMode.AntiAlias;
            tempG.InterpolationMode = InterpolationMode.HighQualityBicubic;
            tempG.CompositingQuality = CompositingQuality.HighQuality;

            Color backgroundColor = Color.FromArgb(41, 41, 41);             // 背景色
            Color guideTagColor = Color.FromArgb(255, 51, 0);               // 高亮指示色
            Color selectedBackgroundColor = Color.FromArgb(77, 77, 77);     // 选中背景色
            Color fontColor = Color.FromArgb(119, 119, 119);                // 字体颜色
            Color selectedFontColor = Color.White;                          // 选中字体颜色

            Rectangle backgroundRect = new Rectangle(0, 0, e.Bounds.Width, e.Bounds.Height);
            Rectangle selectedBackgroundRect = new Rectangle(0, 2, e.Bounds.Width - 2, e.Bounds.Height - 4);
            Rectangle guideRect = new Rectangle(2, 5, 5, e.Bounds.Height - 10);
            Rectangle textRect = new Rectangle(30, 0, e.Bounds.Width, e.Bounds.Height);

            if (e.State.HasFlag(DrawItemState.Selected))
            {
                backgroundColor = selectedBackgroundColor;
                fontColor = selectedFontColor;
                tempG.FillRectangle(new SolidBrush(backgroundColor), selectedBackgroundRect);
            }
            else
            {
                guideTagColor = backgroundColor;
                tempG.FillRectangle(new SolidBrush(backgroundColor), backgroundRect);
            }
            
            //绘制左前高亮指示
            tempG.FillRectangle(new SolidBrush(guideTagColor), guideRect);
            //绘制显示文本
            string text = listBoxMenu.Items[e.Index].ToString();
            TextRenderer.DrawText(tempG, text, new Font("微软雅黑", 11, FontStyle.Bold), textRect, fontColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

            e.Graphics.DrawImage(bitmap, e.Bounds.X, e.Bounds.Y, bitmap.Width, bitmap.Height);
            tempG.Dispose();
        }
        private void listBoxMenu_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 45;
        }
        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxMenu.SelectedIndex)
            {
                case 0:     //选中的是音乐馆
                    panelOnline.Visible = true;
                    panelFavorites.Visible = false;
                    panelLocal.Visible = false;
                    panelHistory.Visible = false;
                    panelUser.Visible = false;
                    pictureBox3.Visible = true;
                    label8.Visible = true;
                    listViewOnline.Items.Clear();
                    textBoxOnline.Text = "";
                    break;
                case 1:     //选中的是我喜欢
                    panelOnline.Visible = false;
                    panelFavorites.Visible = true;
                    panelLocal.Visible = false;
                    panelHistory.Visible = false;
                    panelUser.Visible = false;
                    
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM favorite_music WHERE accountNum = '{userID}'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    songs.Clear();
                    while (reader.Read())
                    { 
                        songs.Add(new SongInfo(reader[0].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
                    }
                    reader.Close();
                    conn.Close();
                    if (songs.Count > 0)
                    {
                        listViewFavorites.Items.Clear();
                        listViewFavorites.Items.Add("歌曲");
                        listViewFavorites.Items[0].SubItems.Add("歌手");
                        listViewFavorites.Items[0].SubItems.Add("专辑");
                        for (int i = 0; i < songs.Count; i++)
                        {
                            listViewFavorites.Items.Add(songs[i].SongName);
                            listViewFavorites.Items[i + 1].SubItems.Add(songs[i].SongSinger);
                            listViewFavorites.Items[i + 1].SubItems.Add(songs[i].SongAlbum);
                        }
                    }
                    else
                    {
                        listViewFavorites.Items.Clear();
                        listViewFavorites.Items.Add("歌曲");
                        listViewFavorites.Items[0].SubItems.Add("歌手");
                        listViewFavorites.Items[0].SubItems.Add("专辑");
                    }
                    labelSongSum.Text = $"歌曲 {songs.Count}";
                    break;
                case 2:     //选中的是本地下载
                    panelOnline.Visible = false;
                    panelFavorites.Visible = false;
                    panelLocal.Visible = true;
                    panelHistory.Visible = false;
                    panelUser.Visible = false;
                    break;
                case 3:     //选中的是历史记录
                    panelOnline.Visible = false;
                    panelFavorites.Visible = false;
                    panelLocal.Visible = false;
                    panelHistory.Visible = true;
                    panelUser.Visible = false;
                    //SQLiteConnection con1 = new SQLiteConnection("data source=music_player.db");

                    historyPaint();
                    break;
                case 4:     //选中的是个人空间
                    panelOnline.Visible = false;
                    panelFavorites.Visible = false;
                    panelLocal.Visible = false;
                    panelHistory.Visible = false;
                    panelUser.Visible = true;
                    break;
            }
        }
        #endregion
 
        #region 我喜欢相关
        private void listViewFavorites_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            listViewFavorites.Columns[0].Width = listViewFavorites.Width * 2 / 5;
            listViewFavorites.Columns[1].Width = listViewFavorites.Width * 1 / 5;
            listViewFavorites.Columns[2].Width = listViewFavorites.Width * 370 / 1000;
            if (e.ItemIndex == 0)
            {
                e.SubItem.BackColor = Color.FromArgb(28, 28, 28);
                e.DrawBackground();
            }
            else if (e.ItemIndex % 2 == 1)
            {
                e.SubItem.BackColor = Color.FromArgb(41, 41, 41);
                e.DrawBackground();
            }

            if (e.ColumnIndex == 0 && e.ItemIndex != 0)
            {
                e.SubItem.ForeColor = Color.White;
            }
            else
            {
                e.SubItem.ForeColor = Color.Silver;
            }

            if (e.ItemState.HasFlag(ListViewItemStates.Selected) && e.ItemIndex != 0)
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(61, 61, 61));
                e.Graphics.FillRectangle((brush), e.Bounds);

            }
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, e.SubItem.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }
        private void listViewFavorites_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listViewFavorites.GetItemAt(e.X, e.Y);
                selectedSong = songs[item.Index - 1];
                if (item != null && item.Index != 0)
                {
                    CustomColorTable colorTable = new CustomColorTable();
                    contextMenuFavorites.Renderer = new ToolStripProfessionalRenderer(colorTable);
                    contextMenuFavorites.Visible = true;
                    contextMenuFavorites.Show(Cursor.Position);
                }
                else
                    contextMenuFavorites.Close();
            }
        }
        private async void listViewFavorites_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //播放音乐
            ListViewItem item = listViewFavorites.GetItemAt(e.X, e.Y);
            selectedSong = songs[item.Index - 1];
            string dirImgTemp = "..\\..\\temp\\img";                  // 缓存的专辑所在文件夹
            string dirLrcTemp = "..\\..\\temp\\lrc";                  // 缓存的歌词所在文件夹
            string imgFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".jpg";
            string lrcFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".txt";
            //播放音乐
            play(selectedSong);

            if (!Directory.Exists(dirImgTemp))      //如果不存在dirImgTemp就创建 
            {
                Directory.CreateDirectory(dirImgTemp);
            }
            if (!Directory.Exists(dirLrcTemp))      //如果不存在dirLrcTemp就创建 
            {
                Directory.CreateDirectory(dirLrcTemp);
            }
            await Task.Run(() =>
            {

                if (!File.Exists(dirImgTemp + "\\" + imgFile))  //如果不存在，则获取URL下载
                {
                    if (!(DownLoader.DownloadSongOrImg(selectedSong.ImgDownloadURL, dirImgTemp + "\\" + imgFile)))
                    {
                        //错误处理
                    }
                }
                if (!File.Exists(dirLrcTemp + "\\" + lrcFile))  //如果不存在，则获取URL下载
                {
                    if (!(DownLoader.DownloadLrc(selectedSong.LrcDownloadURL, dirLrcTemp + "\\" + lrcFile)))
                    {
                        //错误处理
                    }
                }
            });
            IncreaseHistory(selectedSong);
            pictureBoxAlbum.BackgroundImage = Image.FromFile(dirImgTemp + "\\" + imgFile);
            labelSongInfo.Text = selectedSong.SongName + "- " + selectedSong.SongSinger;
        }
        private async void MenuItemDownload_Click(object sender, EventArgs e)
        {
            //下载单曲
            string dirSongDownload = "..\\..\\download\\music";         // 下载的音乐所在文件夹
            string dirImgDownload = "..\\..\\download\\img";            // 下载的专辑图片所在文件夹
            string dirLrcDownload = "..\\..\\download\\lrc";            // 下载的歌词所在文件夹
            string dirImgTemp = "..\\..\\temp\\img";                    // 缓存的专辑所在文件夹
            string dirLrcTemp = "..\\..\\temp\\lrc";                    // 缓存的歌词所在文件夹

            string songFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".mp3";
            string imgFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".jpg";
            string lrcFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".txt";
            if (!Directory.Exists(dirSongDownload))     //如果不存在dirSongDownload就创建 
            {
                Directory.CreateDirectory(dirSongDownload);
            }
            if (!Directory.Exists(dirImgDownload))      //如果不存在dirImgDownload就创建 
            {
                Directory.CreateDirectory(dirImgDownload);
            }
            if (!Directory.Exists(dirLrcDownload))      //如果不存在dirLrcDownload就创建 
            {
                Directory.CreateDirectory(dirLrcDownload);
            }
            await Task.Run(() =>
            {
                if (!(DownLoader.DownloadSongOrImg(selectedSong.SongDownloadURL, dirSongDownload + "\\" + songFile)))
                {
                    //错误处理
                }
                if (File.Exists(dirImgTemp + "\\" + imgFile))  //如果存在缓存，直接复制
                {
                    if (!File.Exists(dirImgDownload + "\\" + imgFile))
                    {
                        FileInfo file = new FileInfo(dirImgTemp + "\\" + imgFile);
                        file.CopyTo(dirImgDownload + "\\" + imgFile);
                    }
                }
                else    //如果不存在，则获取URL下载
                {
                    if (!(DownLoader.DownloadSongOrImg(selectedSong.ImgDownloadURL, dirImgDownload + "\\" + imgFile)))
                    {
                        //错误处理
                    }
                }
                if (File.Exists(dirLrcTemp + "\\" + lrcFile))  //如果存在缓存，直接复制
                {
                    if (!File.Exists(dirLrcDownload + "\\" + lrcFile))
                    {
                        FileInfo file = new FileInfo(dirLrcTemp + "\\" + lrcFile);
                        file.CopyTo(dirLrcDownload + "\\" + lrcFile);
                    }
                }
                else    //如果不存在，则获取URL下载
                {
                    if (!(DownLoader.DownloadLrc(selectedSong.LrcDownloadURL, dirLrcDownload + "\\" + lrcFile)))
                    {
                        //错误处理
                    }
                }
                SQLiteConnection conn = new SQLiteConnection("data source=music_player.db");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM local WHERE musicPath = '{songFile}'", conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    cmd = new SQLiteCommand($"INSERT INTO local VALUES('{selectedSong.SongName}', '{selectedSong.SongSinger}', '{selectedSong.SongAlbum}', '{songFile}', '{imgFile}', '{lrcFile}')", conn);
                    cmd.ExecuteNonQuery();
                }
                reader.Close();
                conn.Close();
            });
        }
        private void MenuItemRemove_Click(object sender, EventArgs e)
        {
            songs.Remove(selectedSong);
            //从我喜欢中删除单曲
            SQLiteConnection conn = new SQLiteConnection("data source=music_player.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM favorite_music WHERE songID = '{selectedSong.SongID}' AND accountNum = '{userID}'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            if (songs.Count > 0)
            {
                listViewFavorites.Items.Clear();
                listViewFavorites.Items.Add("歌曲");
                listViewFavorites.Items[0].SubItems.Add("歌手");
                listViewFavorites.Items[0].SubItems.Add("专辑");
                for (int i = 0; i < songs.Count; i++)
                {
                    listViewFavorites.Items.Add(songs[i].SongName);
                    listViewFavorites.Items[i + 1].SubItems.Add(songs[i].SongSinger);
                    listViewFavorites.Items[i + 1].SubItems.Add(songs[i].SongAlbum);
                }
            }
            else
            {
                listViewFavorites.Items.Clear();
                listViewFavorites.Items.Add("歌曲");
                listViewFavorites.Items[0].SubItems.Add("歌手");
                listViewFavorites.Items[0].SubItems.Add("专辑");
            }
            labelSongSum.Text = $"歌曲 {songs.Count}";
        }
        private void textBoxFavorites_TextChanged(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=music_player.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            //查找音乐
            if (textBoxFavorites.Text == "")
            {
                cmd.CommandText = $"SELECT * FROM favorite_music WHERE accountNum = '{userID}'";
            }
            else
            {
                cmd.CommandText = $"SELECT * FROM favorite_music WHERE songName LIKE '%{textBoxFavorites.Text}%' OR singer LIKE '%{textBoxFavorites.Text}%' OR songAlbum LIKE '%{textBoxFavorites.Text}%' AND accountNum = '{userID}'";
            }
            SQLiteDataReader reader = cmd.ExecuteReader();
            songs.Clear();
            while (reader.Read())
            {
                songs.Add(new SongInfo(reader[0].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
            }
            reader.Close();
            conn.Close();
            if (songs.Count > 0)
            {
                listViewFavorites.Items.Clear();
                listViewFavorites.Items.Add("歌曲");
                listViewFavorites.Items[0].SubItems.Add("歌手");
                listViewFavorites.Items[0].SubItems.Add("专辑");
                for (int i = 0; i < songs.Count; i++)
                {
                    listViewFavorites.Items.Add(songs[i].SongName);
                    listViewFavorites.Items[i + 1].SubItems.Add(songs[i].SongSinger);
                    listViewFavorites.Items[i + 1].SubItems.Add(songs[i].SongAlbum);
                }
            }
            else
            {
                listViewFavorites.Items.Clear();
                listViewFavorites.Items.Add("歌曲");
                listViewFavorites.Items[0].SubItems.Add("歌手");
                listViewFavorites.Items[0].SubItems.Add("专辑");
            }
        }
        #endregion
        
        #region 音乐馆相关
        private void listViewOnline_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            listViewOnline.Columns[0].Width = listViewFavorites.Width * 2 / 5;
            listViewOnline.Columns[1].Width = listViewFavorites.Width * 1 / 5;
            listViewOnline.Columns[2].Width = listViewFavorites.Width * 370 / 1000;
            if (e.ItemIndex == 0)
            {
                e.SubItem.BackColor = Color.FromArgb(28, 28, 28);
                e.DrawBackground();
            }
            else if (e.ItemIndex % 2 == 1)
            {
                e.SubItem.BackColor = Color.FromArgb(41, 41, 41);
                e.DrawBackground();
            }

            if (e.ItemIndex != 0)
            {
                e.SubItem.ForeColor = Color.White;
            }
            else if(e.ItemIndex != 0 && songs.Count > 0 && !songs[e.ItemIndex - 1].SongCanDownload)
            {
                e.SubItem.ForeColor = Color.Red;
            }
            else
            {
                e.SubItem.ForeColor = Color.Silver;
            }

            if (e.ItemState.HasFlag(ListViewItemStates.Selected) && e.ItemIndex != 0)
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(61, 61, 61));
                e.Graphics.FillRectangle((brush), e.Bounds);

            }
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, e.SubItem.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }
        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            //添加到我喜欢
            SQLiteConnection conn = new SQLiteConnection("data source=music_player.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM favorite_music WHERE songID = '{selectedSong.SongID}' AND accountNum = '{userID}'", conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if(!reader.HasRows)
            {
                cmd = new SQLiteCommand($"INSERT INTO favorite_music VALUES('{selectedSong.SongID}', '{userID}', '{selectedSong.SongName}', '{selectedSong.SongSinger}', '{selectedSong.SongAlbum}', '{selectedSong.SongDownloadURL}', '{selectedSong.ImgDownloadURL}', '{selectedSong.LrcDownloadURL}')", conn);
                cmd.ExecuteNonQuery();
            }
            reader.Close();
            conn.Close();
        }
        private async void MenuItemDown_Click(object sender, EventArgs e)
        {
            string dirSongDownload = "..\\..\\download\\music";         // 下载的音乐所在文件夹
            string dirImgDownload = "..\\..\\download\\img";            // 下载的专辑图片所在文件夹
            string dirLrcDownload = "..\\..\\download\\lrc";            // 下载的歌词所在文件夹
            string dirImgTemp = "..\\..\\temp\\img";                    // 缓存的专辑所在文件夹
            string dirLrcTemp = "..\\..\\temp\\lrc";                    // 缓存的歌词所在文件夹

            string songFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".mp3";
            string imgFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".jpg";
            string lrcFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".txt";
            if (!Directory.Exists(dirSongDownload))     //如果不存在dirSongDownload就创建 
            {
                Directory.CreateDirectory(dirSongDownload);
            }
            if (!Directory.Exists(dirImgDownload))      //如果不存在dirImgDownload就创建 
            {
                Directory.CreateDirectory(dirImgDownload);
            }
            if (!Directory.Exists(dirLrcDownload))      //如果不存在dirLrcDownload就创建 
            {
                Directory.CreateDirectory(dirLrcDownload);
            }
            await Task.Run(() =>
            {
                if (!(DownLoader.DownloadSongOrImg(selectedSong.SongDownloadURL, dirSongDownload + "\\" + songFile)))
                {
                    //错误处理
                }
                if (File.Exists(dirImgTemp + "\\" + imgFile))  //如果存在缓存，直接复制
                {
                    if (!File.Exists(dirImgDownload + "\\" + imgFile))
                    {
                        FileInfo file = new FileInfo(dirImgTemp + "\\" + imgFile);
                        file.CopyTo(dirImgDownload + "\\" + imgFile);
                    }
                }
                else    //如果不存在，则获取URL下载
                {
                    if (!(DownLoader.DownloadSongOrImg(selectedSong.ImgDownloadURL, dirImgDownload + "\\" + imgFile)))
                    {
                        //错误处理
                    }
                }
                if (File.Exists(dirLrcTemp + "\\" + lrcFile))  //如果存在缓存，直接复制
                {
                    if (!File.Exists(dirLrcDownload + "\\" + lrcFile))
                    {
                        FileInfo file = new FileInfo(dirLrcTemp + "\\" + lrcFile);
                        file.CopyTo(dirLrcDownload + "\\" + lrcFile);
                    }
                }
                else    //如果不存在，则获取URL下载
                {
                    if (!(DownLoader.DownloadLrc(selectedSong.LrcDownloadURL, dirLrcDownload + "\\" + lrcFile)))
                    {
                        //错误处理
                    }
                }
                SQLiteConnection conn = new SQLiteConnection("data source=music_player.db");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM local WHERE songID = '{songFile}'", conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    cmd = new SQLiteCommand($"INSERT INTO local VALUES('{selectedSong.SongName}', '{selectedSong.SongSinger}', '{selectedSong.SongAlbum}', '{songFile}', '{imgFile}', '{lrcFile}')", conn);
                    cmd.ExecuteNonQuery();
                }
                reader.Close();
                conn.Close();
            });
        }

        private async void listViewOnline_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listViewOnline.GetItemAt(e.X, e.Y);
            selectedSong = songs[item.Index - 1];
            string dirImgTemp = "..\\..\\temp\\img";                  // 缓存的专辑所在文件夹
            string dirLrcTemp = "..\\..\\temp\\lrc";                  // 缓存的歌词所在文件夹
            string imgFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".jpg";
            string lrcFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".txt";
            //播放音乐
            play(selectedSong);

            if (!Directory.Exists(dirImgTemp))      //如果不存在dirImgTemp就创建 
            {
                Directory.CreateDirectory(dirImgTemp);
            }
            if (!Directory.Exists(dirLrcTemp))      //如果不存在dirLrcTemp就创建 
            {
                Directory.CreateDirectory(dirLrcTemp);
            }
            await Task.Run(() =>
            {
                
                if (!File.Exists(dirImgTemp + "\\" + imgFile))  //如果不存在，则获取URL下载
                {
                    if (!(DownLoader.DownloadSongOrImg(selectedSong.ImgDownloadURL, dirImgTemp + "\\" + imgFile)))
                    {
                        //错误处理
                    }
                }
                if (!File.Exists(dirLrcTemp + "\\" + lrcFile))  //如果不存在，则获取URL下载
                {
                    if (!(DownLoader.DownloadLrc(selectedSong.LrcDownloadURL, dirLrcTemp + "\\" + lrcFile)))
                    {
                        //错误处理
                    }
                }
            });
            IncreaseHistory(selectedSong);
            pictureBoxAlbum.BackgroundImage = Image.FromFile(dirImgTemp + "\\" + imgFile);
            labelSongInfo.Text = selectedSong.SongName + "- " + selectedSong.SongSinger;
        }

        private void listViewOnline_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listViewOnline.GetItemAt(e.X, e.Y);
                selectedSong = songs[item.Index - 1];
                if (item != null && item.Index != 0)
                {
                    CustomColorTable colorTable = new CustomColorTable();
                    contextMenuOnline.Renderer = new ToolStripProfessionalRenderer(colorTable);
                    contextMenuOnline.Visible = true;
                    contextMenuOnline.Show(Cursor.Position);
                }
                else
                    contextMenuOnline.Close();
            }
        }

        private void labelOnlineSearch_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            label8.Visible = false;
            songs = NetEaseCloud.GetNetEaseCloudSongs(textBoxOnline.Text);
            if (songs.Count > 0)
            {
                listViewOnline.Items.Clear();
                listViewOnline.Items.Add("歌曲");
                listViewOnline.Items[0].SubItems.Add("歌手");
                listViewOnline.Items[0].SubItems.Add("专辑");
                for (int i = 0; i < songs.Count; i++)
                {
                    listViewOnline.Items.Add(songs[i].SongName);
                    listViewOnline.Items[i + 1].SubItems.Add(songs[i].SongSinger);
                    listViewOnline.Items[i + 1].SubItems.Add(songs[i].SongAlbum); 
                }
            }
        }

        private void labelOnlineSearch_MouseLeave(object sender, EventArgs e)
        {
            labelOnlineSearch.ForeColor = Color.LightGray;
        }

        private void labelOnlineSearch_MouseEnter(object sender, EventArgs e)
        {
            labelOnlineSearch.ForeColor = Color.DarkGray;
        }
        #endregion

        #region 播放控制相关
        private void play(SongInfo song)
        {
            axWindowsMediaPlayer1.URL = song.SongDownloadURL;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            pictureBox6.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            pictureBox6.Visible = true;
            pictureBox5.Visible = false;
        }

        private void pictureBoxAlbum_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAlbum.Image = null;
            songFullScreen = false;
        }

        private void pictureBoxAlbum_MouseEnter(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsUndefined)
            {
                pictureBoxAlbum.Image = Properties.Resources.全屏;
                songFullScreen = true;
            }
        }

        private void pictureBoxAlbum_Click(object sender, EventArgs e)
        {
            if(songFullScreen)
            {
                panelSong.Visible = true;
                panelOnline.Visible = false;
                panelFavorites.Visible = false;
                panelLocal.Visible = false;
                panelHistory.Visible = false;
                panelUser.Visible = false;
            }
        }
        #endregion

        #region 历史记录
        private void listViewHistory_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            listViewHistory.Columns[0].Width = listViewFavorites.Width * 2 / 5;
            listViewHistory.Columns[1].Width = listViewFavorites.Width * 1 / 5;
            listViewHistory.Columns[2].Width = listViewFavorites.Width * 370 / 1000;
            if (e.ItemIndex == 0)
            {
                e.SubItem.BackColor = Color.FromArgb(28, 28, 28);
                e.DrawBackground();
            }
            else if (e.ItemIndex % 2 == 1)
            {
                e.SubItem.BackColor = Color.FromArgb(41, 41, 41);
                e.DrawBackground();
            }

            if (e.ColumnIndex == 0 && e.ItemIndex != 0)
            {
                e.SubItem.ForeColor = Color.White;
            }
            else
            {
                e.SubItem.ForeColor = Color.Silver;
            }

            if (e.ItemState.HasFlag(ListViewItemStates.Selected) && e.ItemIndex != 0)
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(61, 61, 61));
                e.Graphics.FillRectangle((brush), e.Bounds);

            }
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, e.SubItem.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }

        private void listViewHistory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listViewHistory.GetItemAt(e.X, e.Y);
                selectedSong = songs[item.Index - 1];
                if (item != null && item.Index != 0)
                {
                    CustomColorTable colorTable = new CustomColorTable();
                    contextMenuHistory.Renderer = new ToolStripProfessionalRenderer(colorTable);
                    contextMenuHistory.Visible = true;
                    contextMenuHistory.Show(Cursor.Position);
                }
                else
                    contextMenuFavorites.Close();
            }
        }

        private async void listViewHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //播放音乐
            ListViewItem item = listViewHistory.GetItemAt(e.X, e.Y);
            selectedSong = songs[item.Index - 1];
            string dirImgTemp = "..\\..\\temp\\img";                  // 缓存的专辑所在文件夹
            string dirLrcTemp = "..\\..\\temp\\lrc";                  // 缓存的歌词所在文件夹
            string imgFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".jpg";
            string lrcFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".txt";
            //播放音乐
            play(selectedSong);

            if (!Directory.Exists(dirImgTemp))      //如果不存在dirImgTemp就创建 
            {
                Directory.CreateDirectory(dirImgTemp);
            }
            if (!Directory.Exists(dirLrcTemp))      //如果不存在dirLrcTemp就创建 
            {
                Directory.CreateDirectory(dirLrcTemp);
            }
            await Task.Run(() =>
            {

                if (!File.Exists(dirImgTemp + "\\" + imgFile))  //如果不存在，则获取URL下载
                {
                    if (!(DownLoader.DownloadSongOrImg(selectedSong.ImgDownloadURL, dirImgTemp + "\\" + imgFile)))
                    {
                        //错误处理
                    }
                }
                if (!File.Exists(dirLrcTemp + "\\" + lrcFile))  //如果不存在，则获取URL下载
                {
                    if (!(DownLoader.DownloadLrc(selectedSong.LrcDownloadURL, dirLrcTemp + "\\" + lrcFile)))
                    {
                        //错误处理
                    }
                }
            });
            IncreaseHistory(selectedSong);
            pictureBoxAlbum.BackgroundImage = Image.FromFile(dirImgTemp + "\\" + imgFile);
            labelSongInfo.Text = selectedSong.SongName + "- " + selectedSong.SongSinger;
            historyPaint();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //添加到我喜欢
            SQLiteConnection conn = new SQLiteConnection("data source=music_player.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM favorite_music WHERE songID = '{selectedSong.SongID}' AND accountNum = '{userID}'", conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                cmd = new SQLiteCommand($"INSERT INTO favorite_music VALUES('{selectedSong.SongID}', '{userID}', '{selectedSong.SongName}', '{selectedSong.SongSinger}', '{selectedSong.SongAlbum}', '{selectedSong.SongDownloadURL}', '{selectedSong.ImgDownloadURL}', '{selectedSong.LrcDownloadURL}')", conn);
                cmd.ExecuteNonQuery();
            }
            reader.Close();
            conn.Close();
        }

        private async void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string dirSongDownload = "..\\..\\download\\music";         // 下载的音乐所在文件夹
            string dirImgDownload = "..\\..\\download\\img";            // 下载的专辑图片所在文件夹
            string dirLrcDownload = "..\\..\\download\\lrc";            // 下载的歌词所在文件夹
            string dirImgTemp = "..\\..\\temp\\img";                    // 缓存的专辑所在文件夹
            string dirLrcTemp = "..\\..\\temp\\lrc";                    // 缓存的歌词所在文件夹

            string songFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".mp3";
            string imgFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".jpg";
            string lrcFile = selectedSong.SongName + "-" + selectedSong.SongSinger + "-" + selectedSong.SongAlbum + ".txt";
            if (!Directory.Exists(dirSongDownload))     //如果不存在dirSongDownload就创建 
            {
                Directory.CreateDirectory(dirSongDownload);
            }
            if (!Directory.Exists(dirImgDownload))      //如果不存在dirImgDownload就创建 
            {
                Directory.CreateDirectory(dirImgDownload);
            }
            if (!Directory.Exists(dirLrcDownload))      //如果不存在dirLrcDownload就创建 
            {
                Directory.CreateDirectory(dirLrcDownload);
            }
            await Task.Run(() =>
            {
                if (!(DownLoader.DownloadSongOrImg(selectedSong.SongDownloadURL, dirSongDownload + "\\" + songFile)))
                {
                    //错误处理
                }
                if (File.Exists(dirImgTemp + "\\" + imgFile))  //如果存在缓存，直接复制
                {
                    if (!File.Exists(dirImgDownload + "\\" + imgFile))
                    {
                        FileInfo file = new FileInfo(dirImgTemp + "\\" + imgFile);
                        file.CopyTo(dirImgDownload + "\\" + imgFile);
                    }
                }
                else    //如果不存在，则获取URL下载
                {
                    if (!(DownLoader.DownloadSongOrImg(selectedSong.ImgDownloadURL, dirImgDownload + "\\" + imgFile)))
                    {
                        //错误处理
                    }
                }
                if (File.Exists(dirLrcTemp + "\\" + lrcFile))  //如果存在缓存，直接复制
                {
                    if (!File.Exists(dirLrcDownload + "\\" + lrcFile))
                    {
                        FileInfo file = new FileInfo(dirLrcTemp + "\\" + lrcFile);
                        file.CopyTo(dirLrcDownload + "\\" + lrcFile);
                    }
                }
                else    //如果不存在，则获取URL下载
                {
                    if (!(DownLoader.DownloadLrc(selectedSong.LrcDownloadURL, dirLrcDownload + "\\" + lrcFile)))
                    {
                        //错误处理
                    }
                }
                SQLiteConnection conn = new SQLiteConnection("data source=music_player.db");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM local WHERE songID = '{songFile}'", conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    cmd = new SQLiteCommand($"INSERT INTO local VALUES('{selectedSong.SongName}', '{selectedSong.SongSinger}', '{selectedSong.SongAlbum}', '{songFile}', '{imgFile}', '{lrcFile}',1)", conn);
                    cmd.ExecuteNonQuery();
                }
                reader.Close();
                conn.Close();
            });
        }

        //增加历史记录功能
        private void IncreaseHistory(SongInfo song)
        {
            
            //SQLiteConnection conn = new SQLiteConnection("data source=music_player.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM history WHERE songID = '{song.SongID}' AND accountNum = '{userID}'", conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                cmd = new SQLiteCommand($"INSERT INTO history VALUES('{song.SongID}', '{userID}', '{song.SongName}', '{song.SongSinger}', '{song.SongAlbum}', '{song.SongDownloadURL}', '{song.ImgDownloadURL}', '{song.LrcDownloadURL}',1)", conn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SQLiteCommand($"UPDATE history SET times = times + 1 WHERE songID = '{song.SongID}' AND accountNum = '{userID}'", conn);
                cmd.ExecuteNonQuery();
            }
            reader.Close();
            conn.Close();
            
            //return false;
        }

        //历史记录显示模块
        private void historyPaint()
        {
            conn.Open();
            SQLiteCommand cmd1 = new SQLiteCommand($"SELECT * FROM history WHERE accountNum = '{userID}'", conn);
            SQLiteDataReader reader1 = cmd1.ExecuteReader();
            songs.Clear();
            List<int> times = new List<int>();
            while (reader1.Read())
            {
                songs.Add(new SongInfo(reader1[0].ToString(), reader1[2].ToString(), reader1[3].ToString(), reader1[4].ToString(), reader1[5].ToString(), reader1[6].ToString(), reader1[7].ToString()));
                int tim = int.Parse(reader1[8].ToString());
                times.Add(tim);
            }
            reader1.Close();
            conn.Close();
            if (songs.Count > 0)
            {
                listViewHistory.Items.Clear();
                listViewHistory.Items.Add("歌曲");
                listViewHistory.Items[0].SubItems.Add("歌手");
                listViewHistory.Items[0].SubItems.Add("专辑");
                listViewHistory.Items[0].SubItems.Add("听歌次数");
                for (int i = 0; i < songs.Count; i++)
                {
                    listViewHistory.Items.Add(songs[i].SongName);
                    listViewHistory.Items[i + 1].SubItems.Add(songs[i].SongSinger);
                    listViewHistory.Items[i + 1].SubItems.Add(songs[i].SongAlbum);
                    listViewHistory.Items[i + 1].SubItems.Add(times[i].ToString());
                }
            }
            else
            {
                listViewHistory.Items.Clear();
                listViewHistory.Items.Add("歌曲");
                listViewHistory.Items[0].SubItems.Add("歌手");
                listViewHistory.Items[0].SubItems.Add("专辑");
                listViewHistory.Items[0].SubItems.Add("听歌次数");
            }
            /*this.listViewHistory.ListViewItemSorter = new ListViewColumnSorter();
            this.listViewHistory.ColumnClick += new ColumnClickEventHandler(ListViewHelper.ListView_ColumnClick);*/
        }
        #endregion

        
    }
    
    public class CustomColorTable : ProfessionalColorTable
    {
        public override Color MenuBorder
        {
            get { return Color.Transparent; }
        }
        public override Color MenuItemBorder
        {
            get { return Color.Transparent; }
        }
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(61, 61, 61); }
        }

    }
    //
    #region listView按列排序方法

    /// <summary>
    /// 对ListView点击列标题自动排序功能
    /// </summary>
    public class ListViewHelper
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ListViewHelper()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public static void ListView_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            System.Windows.Forms.ListView lv = sender as System.Windows.Forms.ListView;
            // 检查点击的列是不是现在的排序列.
            if (e.Column == (lv.ListViewItemSorter as ListViewColumnSorter).SortColumn)
            {
                // 重新设置此列的排序方法.
                if ((lv.ListViewItemSorter as ListViewColumnSorter).Order == System.Windows.Forms.SortOrder.Ascending)
                {
                    (lv.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Descending;
                }
                else
                {
                    (lv.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending;
                }
            }
            else
            {
                // 设置排序列，默认为正向排序
                (lv.ListViewItemSorter as ListViewColumnSorter).SortColumn = e.Column;
                (lv.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending;
            }
            // 用新的排序方法对ListView排序
            ((System.Windows.Forms.ListView)sender).Sort();
        }
    }
    /// <summary>
    /// 继承自IComparer
    /// </summary>
    public class ListViewColumnSorter : System.Collections.IComparer
    {
        /// <summary>
        /// 指定按照哪个列排序
        /// </summary>
        private int ColumnToSort;
        /// <summary>
        /// 指定排序的方式
        /// </summary>
        private System.Windows.Forms.SortOrder OrderOfSort;
        /// <summary>
        /// 声明CaseInsensitiveComparer类对象
        /// </summary>
        private System.Collections.CaseInsensitiveComparer ObjectCompare;
        /// <summary>
        /// 构造函数
        /// </summary>
        public ListViewColumnSorter()
        {
            // 默认按第一列排序
            ColumnToSort = 3;
            // 排序方式为不排序
            OrderOfSort = System.Windows.Forms.SortOrder.None;
            // 初始化CaseInsensitiveComparer类对象
            ObjectCompare = new System.Collections.CaseInsensitiveComparer();
        }
        /// <summary>
        /// 重写IComparer接口.
        /// </summary>
        /// <param name="x">要比较的第一个对象</param>
        /// <param name="y">要比较的第二个对象</param>
        /// <returns>比较的结果.如果相等返回0，如果x大于y返回1，如果x小于y返回-1</returns>
        public int Compare(object x, object y)
        {
            int compareResult;
            System.Windows.Forms.ListViewItem listviewX, listviewY;
            // 将比较对象转换为ListViewItem对象
            listviewX = (System.Windows.Forms.ListViewItem)x;
            listviewY = (System.Windows.Forms.ListViewItem)y;
            string xText = listviewX.SubItems[ColumnToSort].Text;
            string yText = listviewY.SubItems[ColumnToSort].Text;
            int xInt, yInt;
            // 比较,如果值为IP地址，则根据IP地址的规则排序。
            if (IsIP(xText) && IsIP(yText))
            {
                compareResult = CompareIp(xText, yText);
            }
            else if (int.TryParse(xText, out xInt) && int.TryParse(yText, out yInt)) //是否全为数字
            {
                //比较数字
                compareResult = CompareInt(xInt, yInt);
            }
            else
            {
                //比较对象
                compareResult = ObjectCompare.Compare(xText, yText);
            }
            // 根据上面的比较结果返回正确的比较结果
            if (OrderOfSort == System.Windows.Forms.SortOrder.Ascending)
            {
                // 因为是正序排序，所以直接返回结果
                return compareResult;
            }
            else if (OrderOfSort == System.Windows.Forms.SortOrder.Descending)
            {
                // 如果是反序排序，所以要取负值再返回
                return (-compareResult);
            }
            else
            {
                // 如果相等返回0
                return 0;
            }
        }
        /// <summary>
        /// 判断是否为正确的IP地址，IP范围（0.0.0.0～255.255.255）
        /// </summary>
        /// <param name="ip">需验证的IP地址</param>
        /// <returns></returns>
        public bool IsIP(String ip)
        {
            return System.Text.RegularExpressions.Regex.Match(ip, @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$").Success;
        }
        /// <summary>
        /// 比较两个数字的大小
        /// </summary>
        /// <param name="ipx">要比较的第一个对象</param>
        /// <param name="ipy">要比较的第二个对象</param>
        /// <returns>比较的结果.如果相等返回0，如果x大于y返回1，如果x小于y返回-1</returns>
        private int CompareInt(int x, int y)
        {
            if (x > y)
            {
                return 1;
            }
            else if (x < y)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 比较两个IP地址的大小
        /// </summary>
        /// <param name="ipx">要比较的第一个对象</param>
        /// <param name="ipy">要比较的第二个对象</param>
        /// <returns>比较的结果.如果相等返回0，如果x大于y返回1，如果x小于y返回-1</returns>
        private int CompareIp(string ipx, string ipy)
        {
            string[] ipxs = ipx.Split('.');
            string[] ipys = ipy.Split('.');
            for (int i = 0; i < 4; i++)
            {
                if (Convert.ToInt32(ipxs[i]) > Convert.ToInt32(ipys[i]))
                {
                    return 1;
                }
                else if (Convert.ToInt32(ipxs[i]) < Convert.ToInt32(ipys[i]))
                {
                    return -1;
                }
                else
                {
                    continue;
                }
            }
            return 0;
        }
        /// <summary>
        /// 获取或设置按照哪一列排序.
        /// </summary>
        public int SortColumn
        {
            set
            {
                ColumnToSort = value;
            }
            get
            {
                return ColumnToSort;
            }
        }
        /// <summary>
        /// 获取或设置排序方式.
        /// </summary>
        public System.Windows.Forms.SortOrder Order
        {
            set
            {
                OrderOfSort = value;
            }
            get
            {
                return OrderOfSort;
            }
        }
    }
    #endregion
}
