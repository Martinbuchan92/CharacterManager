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

        private Character thisChar;
        Random rnd = new Random();
        int HammerGapCount;
        int TotalDamage;

        internal Character ThisChar { get => thisChar; set => thisChar = value; }

        public CharForm()
        {
            InitializeComponent();
        }

        public CharForm(Object selected) : this()
        {
            thisChar = (Character)selected;
        }

        private void CharForm_Load(object sender, EventArgs e)
        {
            
            ReadCSV();

            FillForm();


        }

        private void ReadCSV()
        {
            try
            {

                using (var reader = new StreamReader(thisChar.FilePath1))
                {
                    List<string> stats = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');


                        stats.Add(values[1]);
                    }

                    thisChar.Name1 = stats[0];
                    thisChar.CharClass1 = stats[1];
                    thisChar.Level1 = int.Parse(stats[2]);
                    thisChar.WepEnhBonus1 = int.Parse(stats[3]);
                    thisChar.BaseAttackBonus1 = int.Parse(stats[4]);
                    thisChar.Strength1 = int.Parse(stats[5]);
                    thisChar.Dexterity1 = int.Parse(stats[6]);
                    thisChar.Constitution1 = int.Parse(stats[7]);
                    thisChar.Intelligence1 = int.Parse(stats[8]);
                    thisChar.Wisdom1 = int.Parse(stats[9]);
                    thisChar.Charisma1 = int.Parse(stats[10]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("You dun goof'd");
            }
            
        }

        private void FillForm()
        {
            txtCharacterName.Text = thisChar.Name1;
            txtCharacterClass.Text = thisChar.CharClass1;
            nupLVL.Value = thisChar.Level1;
            nupWeaponEnhancementBonus.Value = thisChar.WepEnhBonus1;
            nupBAB.Value = thisChar.BaseAttackBonus1;
            nupSTR.Value = thisChar.Strength1;
            nupDEX.Value = thisChar.Dexterity1;
            nupCON.Value = thisChar.Constitution1;
            nupINT.Value = thisChar.Intelligence1;
            nupWIS.Value = thisChar.Wisdom1;
            nupCHA.Value = thisChar.Charisma1;
            nupLv3.Value = thisChar.ThreeLevelJudgement1;
            nupLv5.Value = thisChar.FiveLevelJudgement1;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void Show(Character newCharacter)
        {
            thisChar = newCharacter;
        }

        public int D(int Die)
        {
            int max = Die + 1;
            int dice = rnd.Next(1, max);
            return dice;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            int toHit = thisChar.BaseAttackBonus1 + thisChar.Dexterity1 + thisChar.WepEnhBonus1 + thisChar.ItemBonus;
            int attacks;
            String attack = "";

            txtAttack.Clear();

            attacks = (thisChar.BaseAttackBonus1 + 4) / 5;

            if (chkRapidShot.Checked)
            {
                attacks += 1;
            }
            if (chkBane.Checked)
            {
                toHit += 2;
            }
            if (chkJustice.Checked)
            {
                toHit += thisChar.FiveLevelJudgement1;
            }
            if (chkPointBlank.Checked)
            {
                toHit += 1;
            }

            for (int i = 0; i < attacks; i++)
            {
                if (chkRapidShot.Checked)
                {
                    if (i == 0)
                    {
                        toHit -= 2;
                    }
                    else if (i >= 2)
                    {
                        toHit -= 5;
                    }
                }
                else
                {
                    if (i >= 1)
                    {
                        toHit -= 5;
                    }
                }

                int roll = D(20);
                attack += (toHit + roll).ToString() + "(" + roll + ")" + "/";

            }
            attack = attack.TrimEnd(new char[] { '/' });
            txtAttack.Text = attack;
        }

        private void btnD20_Click(object sender, EventArgs e)
        {
            txtD20.Text = (D(20)).ToString();
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            txtDamage.Clear();

            int Damage = thisChar.Strength1 + thisChar.WepEnhBonus1;

            if (chkPointBlank.Checked)
            {
                Damage += 1;
            }
            if (ChkCrit.Checked)
            {
                Damage = Damage * 3 + D(8) + D(8);
            }
            if (chkBane.Checked)
            {
                Damage += 2 + D(6) + D(6) + D(6) + D(6);
            }
            if (chkEvil.Checked)
            {
                Damage += D(6) + D(6);
            }
            if (chkDestruction.Checked)
            {
                Damage += thisChar.ThreeLevelJudgement1;
            }
            if (chkHammerGap.Checked)
            {
                Damage += HammerGapCount;
            }
            Damage += D(8);


            TotalDamage += Damage;
            txtDamage.Text = Damage.ToString();
            txtTotalDamage.Text = TotalDamage.ToString();
            HammerGapCount += 1;
        }
    }
}
