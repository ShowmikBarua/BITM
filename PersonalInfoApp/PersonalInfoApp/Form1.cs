using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfoApp
{
    public partial class Form1 : Form
    {
        private string name;
        private string roll;
        private string cgpa;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            roll = rollTextBox.Text;
            cgpa = cgpaTextBox.Text;
            clearAllText();
        }

        private void clearAllText()
        {
            nameTextBox.Clear();
            cgpaTextBox.Clear();
            rollTextBox.Clear();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            clearAllText();
            nameTextBox.Text = name;
            cgpaTextBox.Text = cgpa;
            rollTextBox.Text = roll;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAllText();
        }

    }
}
