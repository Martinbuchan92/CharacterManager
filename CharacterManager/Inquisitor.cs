using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inquisitor
{
    public partial class Inquisitor : Form
    {
        int Lvl3Bonus;
        int Lvl5Bonus;
        int BAB;
        int DEX;
        int STR;
        int CON;
        int INT;
        int WIS;
        int CHA;
        int WepEnh;
        int LVL;
        //Bracers +1
        int items = 2;
        int TotalDamage;
        Random rnd = new Random();
        int HammerGapCount;
        String[] inputLines;
        String[] abilities;

        public Inquisitor()
        {
            InitializeComponent();
        }

        private void Inquisitor_Load(object sender, EventArgs e)
        {
            LoadInformation();
            LoadAbilities();
            CalcJudgements();
            WepEnh = (int)nupWeaponEnhancementBonus.Value;

            txtToolStrip.Text = "Loaded";
        }

        public int D(int Die)
        {
            int max = Die + 1;
            int dice = rnd.Next(1, max);
            return dice;
        }

        private void btnD20_Click(object sender, EventArgs e)
        {
            txtD20.Text = (D(20)).ToString();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            int toHit = BAB + DEX + WepEnh + items;
            int attacks;
            String attack = "";

            txtAttack.Clear();

            attacks = (BAB + 4) / 5;

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
                toHit += Lvl5Bonus;
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

        private void nupLVL_ValueChanged(object sender, EventArgs e)
        {
            CalcJudgements();
        }

        private void CalcJudgements()
        {
            Lvl3Bonus = (int)(1 + (nupLVL.Value / 3));
            Lvl5Bonus = (int)(1 + (nupLVL.Value / 5));
            nupLv3.Value = Lvl3Bonus;
            nupLv5.Value = Lvl5Bonus;
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            txtDamage.Clear();

            int Damage = STR + WepEnh;

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
                Damage += Lvl3Bonus;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            TotalDamage = 0;
            HammerGapCount = 0;
            txtTotalDamage.Clear();
            txtDamage.Clear();
            txtAttack.Clear();
        }

        private void nupBAB_ValueChanged(object sender, EventArgs e)
        {
            BAB = (int)nupBAB.Value;
        }

        private void btnSpellList_Click(object sender, EventArgs e)
        {
            spells spellsForm = new spells();
            spellsForm.Show();
        }

        private void btnSkills_Click(object sender, EventArgs e)
        {
            skills skillsForm = new skills();
            skillsForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BAB = (int)nupBAB.Value;
            DEX = (int)nupDEX.Value;
            STR = (int)nupSTR.Value;
            LVL = (int)nupLVL.Value;


            String[] stats = { BAB.ToString(), DEX.ToString(), STR.ToString(), LVL.ToString() };


            txtToolStrip.Text = "Saved";
        }

        private void LoadInformation()
        {
            inputLines = System.IO.File.ReadAllLines(@"..\..\stats\inquisitor1.txt");

            BAB = int.Parse(inputLines[0]);
            DEX = int.Parse(inputLines[1]);
            STR = int.Parse(inputLines[2]);
            LVL = int.Parse(inputLines[3]);

            nupBAB.Value = BAB;
            nupDEX.Value = DEX;
            nupSTR.Value = STR;
            nupLVL.Value = LVL;

        }

        private void LoadAbilities()
        {

        }

        private void SaveAbilities()
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadInformation();

            txtToolStrip.Text = "Loaded"; 
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
        }
    }
}