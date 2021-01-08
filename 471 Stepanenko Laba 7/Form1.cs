using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _471_Stepanenko_Laba_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");

            fileItem.DropDownItems.Add("Закрити");
            fileItem.DropDownItems[0].Click += aboutItem_Click;
            menuStrip1.Items.Add(fileItem);

            ToolStripMenuItem aboutItem = new ToolStripMenuItem("О программе");
            aboutItem.DropDownItems.Add("Автор: Степаненко М.І. 471");
            menuStrip1.Items.Add(aboutItem);

            ToolStripMenuItem helpItem = new ToolStripMenuItem("Довідка");
            helpItem.Click += helpItem_Click;
            menuStrip1.Items.Add(helpItem);
        }
        private void aboutItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void helpItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\USER\source\repos\471 Stepanenko Laba 7\471 Stepanenko Laba 7\help.html");
        }
    }
}
