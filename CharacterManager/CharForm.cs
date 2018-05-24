using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CharacterManager
{
    public partial class CharForm : Form
    {
        public CharForm()
        {
            InitializeComponent();
        }

        private void CharForm_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"raylux.csv"))
            {
                List<string> listA = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listA.Add(values[1]);
                }


            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
