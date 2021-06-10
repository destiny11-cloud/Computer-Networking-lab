using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
//using MySql.Data.MySqlClient;

namespace MusicPlayer
{
    public partial class login : Form
    {
        //MySqlConnection conn = null;
        public login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(login_KeyDown);
            //conn = database.dbcon.getConnection();//获得数据库连接
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                textBox2.PasswordChar = '*';
            else
                textBox2.PasswordChar = (char)0;
        }


        //登录回车键监控
        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // 将Handled设置为true，指示已经处理过KeyPress事件
                button1_Click(sender, e); // 登录界面如果监听到回车按钮，则触发单击事件进行登录校验
            }
        }

        //登录函数
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            if (username.Equals(""))
            {
                MessageBox.Show("用户名不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Focus();
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("密码不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }
            //与数据库交互
            User us1 = new User(username, password);
            //bool success = verify(us1);//判断密码是否正确


            bool success = true;//假设都能登录
            if (success)
            {

                Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                cfa.AppSettings.Settings["userName"].Value = username; // 账号（默认记住）
                if (this.checkBox3.Checked)//自动登录
                {
                    cfa.AppSettings.Settings["autoLogin"].Value = "true";
                    cfa.AppSettings.Settings["remember"].Value = "true";
                    cfa.AppSettings.Settings["password"].Value = password;
                }
                else
                {
                    if (this.checkBox2.Checked)//记住密码
                    {
                        cfa.AppSettings.Settings["autoLogin"].Value = "false";
                        cfa.AppSettings.Settings["remember"].Value = "true";
                        cfa.AppSettings.Settings["password"].Value = password;
                    }
                    else//什么都不做
                    {
                        cfa.AppSettings.Settings["autoLogin"].Value = "false";
                        cfa.AppSettings.Settings["remember"].Value = "false";
                        cfa.AppSettings.Settings["password"].Value = "";
                    }
                }
                cfa.Save();//保存数据
                MessageBox.Show("登录成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DialogResult = DialogResult.OK;
                Form1 minForm = new Form1(textBox1.Text);
                this.Hide(); // 登录成功关闭当前页面，启动新页面
                minForm.ShowDialog();
            }
            else
                MessageBox.Show("登录失败，账号或密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void login_Focus(object sender, EventArgs e)
        {
            //记住用户名
            this.textBox1.Text = ConfigurationManager.AppSettings["username"];

            //记住密码
            if (ConfigurationManager.AppSettings["remember"].Equals("true"))
            {
                this.textBox2.Text = ConfigurationManager.AppSettings["password"];
                checkBox2.Checked = true;
            }

            //自动登录
            if (ConfigurationManager.AppSettings["autoLogin"].Equals("true"))
            {
                checkBox3.Checked = true;
                button1_Click(sender, e);
            }

            //获取焦点
            string username = this.textBox1.Text.Trim();
            string password = this.textBox2.Text.Trim();
            if (username.Equals(""))
            {
                textBox1.Focus();
            }
            else if (password.Equals(""))
            {
                textBox2.Focus();
            }
            else
                button1.Focus();
        }

        //判断密码是否正确
        /*private bool verify(User u)
        {
            string un = u.getUsername();
            string pw = u.getPassword();
            string sql = "select * from user where username=@para1 and password=@para2";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("para1", un);
            cmd.Parameters.AddWithValue("para2", pw);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                return true;
            return false;

        }*/


        //暂未设置皮肤
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }


}
