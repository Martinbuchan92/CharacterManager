using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterManager
{
    public partial class CharacterManager : Form
    {

        public string selectedFile;
        private const String path = @"..\..\savefiles\";
        public CharacterManager()
        {
            InitializeComponent();
        }

        private void CharacterManager_Load(object sender, EventArgs e)
        {
            
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles("*.csv");

            foreach(FileInfo items in files)
            {
                CmbName.Items.Add(items);
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CharForm().Show();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            Character newCharacter = new Character(path + CmbName.SelectedValue);
            new CharForm().Show();
        }
    }
}

