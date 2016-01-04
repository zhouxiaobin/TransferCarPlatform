using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2()
        {
            InitializeComponent();
            
        }
        public Form2(Form1 f1)
        {
            InitializeComponent();
            this .f1 = f1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("保存成功！");
            //Form1 f1 = (Form1)this.Parent;
            //f1.Text = "test";
            f1.Controls["textBox1"].Text = "ok";
        }
        public void shuaxinChuan()
        {
            MessageBox.Show("刷新窗体1");
            
        }
    }
}
