using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using BLL;
using Model;

namespace WindowsFormCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        infosBLL bll = new infosBLL();
        private void button2_Click(object sender, EventArgs e)
        {
            //UpdateXmlByNode("two", "127.0.0.1", "sa", "ovenjackchain", "qidian10");
            //MessageBox.Show(GetXmlByNode("one"));
            //this.textBox1.Text = Encrypt("123456");
            //MessageBox.Show(Dencrypt(textBox1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.FindAllByPage_infos("0", "10", ""); ;
            //CJ_DBOperater.CJ.sqlconn_str = "server=localhost;database=qidian10;uid=sa;pwd=ovenjackchain;";
            //dataGridView1.DataSource = CJ_DBOperater.CJ.SQL_ReturnDataTable("select top 10 * from infos");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBConfig cfg = new DBConfig();
            cfg.ShowDialog();
        }
        
    }
}
