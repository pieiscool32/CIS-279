using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            string startText = decripted.Text;
            char[] letters = startText.ToCharArray();
            for(int a=0; a<letters.Length; a++)
            {
                char letter = letters[a];
                int unicode = (int)letter;
                unicode += 5;
                letters[a] = (char)unicode;
            }
            encrypted.Text = new string(letters);
            decripted.Text = null;
        }

        private void decript_Click(object sender, EventArgs e)
        {
            string startText = encrypted.Text;
            char[] letters = startText.ToCharArray();
            for(int a=0; a<letters.Length; a++)
            {
                char letter = letters[a];
                int unicode = (int)letter;
                unicode -= 5;
                letters[a] = (char)unicode;
            }
            decripted.Text = new string(letters);
            encrypted.Text = null;
        }
    }
}
