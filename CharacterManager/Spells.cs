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
    public partial class spells : Form
    {
        public spells()
        {
            InitializeComponent();
        }

        private void lbxLevel0_SelectedIndexChanged(object sender, EventArgs e)
        {
              
          switch (lbxLevel0.SelectedIndex)
            {
                case 0: //Brand
                    richTextBox1.Text = "School transmutation; Level inquisitor 0 \nCasting Time 1 standard action \nComponents V, S, DF \nRange touch \nTarget creature touched \nDuration 1 day / level \nSaving Throw Fortitude negates; Spell Resistance yes \n\nBrand etches an indelible rune or mark of no more than 6 characters onto a creature, inflicting 1 point of damage.The mark may be placed on any exposed portion of the creature, typically the head or forearm. A brand can be hidden by clothing or removed by scraping it away(causing 1d6 points of damage), though the brand returns if the damage is healed.";
                    break;
                case 1: //Sift
                    richTextBox1.Text = "School divination \nCasting Time 1 standard action \nComponents V, S \nRange 30 ft.\nArea one 10-ft. cube\nDuration instantaneous\nSaving Throw none; Spell Resistance no\n\nYou examine an area at range as if you were searching for fine details with the Perception skill. Make a Perception check with a –5 penalty, modified as normal for conditions. No penalty is applied for distance. Apply the result against the DC for any hidden features, such as secret doors, traps, or hidden treasure. You must be able to see the area you are attempting to search, and you only find details that can be perceived with sight or touch. Sift detects only objects and features, not actual creatures.";
                    break;
                case 2: //Acid Splash
                    richTextBox1.Text = "School conjuration (creation) [acid]\nCasting Time 1 standard action\nComponents V, S\nRange close (25 ft. + 5 ft./2 levels)\nEffect one missile of acid\nDuration instantaneous\nSaving Throw none; Spell Resistance no\n\nYou fire a small orb of acid at the target. You must succeed on a ranged touch attack to hit your target. The orb deals 1d3 points of acid damage. This acid disappears after 1 round.";
                    break;
                case 3: //Detect Magic
                    richTextBox1.Text = "School divination; Level bard 0, cleric 0, druid 0, sorcerer/wizard 0\nCasting Time 1 standard action\nComponent: V, S\nRange 60 ft.\nArea cone-shaped emanation\nDuration concentration, up to 1 min./level (D)\nSaving Throw none; Spell Resistance no\n\nYou detect magical auras. The amount of information revealed depends on how long you study a particular area or subject.\n1st Round: Presence or absence of magical auras.\n2nd Round: Number of different magical auras and the power of the most potent aura.\n3rd Round: The strength and location of each aura.";
                    break;
                case 4: //Guidance
                    richTextBox1.Text = "School divination\nCasting Time 1 standard action\nComponents V, S\nRange touch\nTarget creature touched\nDuration 1 minute or until discharged\nSaving Throw Will negates (harmless); Spell Resistance yes\n\nThis spell imbues the subject with a touch of divine guidance. The creature gets a +1 competence bonus on a single attack roll, saving throw, or skill check. It must choose to use the bonus before making the roll to which it applies.";
                    break;
                case 5: //Read Magic
                    richTextBox1.Text = "School divination\nCasting Time 1 standard action\nComponents V, S, F (a clear crystal or mineral prism)\nRange personal\nTarget you\nDuration 10 min./level\n\nYou can decipher magical inscriptions on objects—books, scrolls, weapons, and the like—that would otherwise be unintelligible. This deciphering does not normally invoke the magic contained in the writing, although it may do so in the case of a cursed or trapped scroll. Furthermore, once the spell is cast and you have read the magical inscription, you are thereafter able to read that particular writing without recourse to the use of read magic. You can read at the rate of one page (250 words) per minute. The spell allows you to identify a glyph of warding with a DC 13 Spellcraft check, a greater glyph of warding with a DC 16 Spellcraft check, or any symbol spell with a Spellcraft check (DC 10 + spell level).";
                    break;

            }

        }

        private void lbxLevel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbxLevel1.SelectedIndex)
            {
                case 0: //Command
                    richTextBox1.Text = "School enchantment (compulsion) [language-dependent, mind-affecting]\nCasting Time 1 standard action\nComponents V\nRange close (25 ft. + 5 ft./2 levels)\nTarget one living creature\nDuration 1 round\nSaving Throw Will negates; Spell Resistance yes\n\nYou give the subject a single command, which it obeys to the best of its ability at its earliest opportunity. You may select from the following options.\nApproach: On its turn, the subject moves toward you as quickly and directly as possible for 1 round. The creature may do nothing but move during its turn, and it provokes attacks of opportunity for this movement as normal.\nDrop: On its turn, the subject drops whatever it is holding. It can't pick up any dropped item until its next turn.\nFall: On its turn, the subject falls to the ground and remains prone for 1 round. It may act normally while prone but takes any appropriate penalties.\nFlee: On its turn, the subject moves away from you as quickly as possible for 1 round. It may do nothing but move during its turn, and it provokes attacks of opportunity for this movement as normal.\nHalt: The subject stands in place for 1 round. It may not take any actions but is not considered helpless.\nIf the subject can't carry out your command on its next turn, the spell automatically fails.";
                    break;
                case 1: //Comprehend Languages
                    richTextBox1.Text = "School divination\nCasting Time 1 standard action\nComponents V, S, M/DF (pinch of soot and salt)\nRange personal\nTarget you\nDuration 10 min./level\n\nYou can understand the spoken words of creatures or read otherwise incomprehensible written messages. The ability to read does not necessarily impart insight into the material, merely its literal meaning. The spell enables you to understand or read an unknown language, not speak or write it.Written material can be read at the rate of one page (250 words) per minute. Magical writing cannot be read, though the spell reveals that it is magical. This spell can be foiled by certain warding magic (such as the secret page and illusory script spells). It does not decipher codes or reveal messages concealed in otherwise normal text.";
                    break;
                case 2: //Forbid Action
                    richTextBox1.Text = "School enchantment (compulsion) [language-dependent, mind-affecting]\nCasting Time 1 standard action\nComponent V\nRange close (25 ft. +5 ft./2 levels)\nTarget one creature\nDuration 1 round\nSaving Throw Will negates; Spell Resistance yes\n\nYou forbid the target a single course of action, which it avoids to the best of its ability. You may demand the target not take actions that fall into one of the following options.\nAttack: The target cannot take any action that involves an attack roll, or uses a spell or ability that targets a foe or an area that includes a foe.\nCast: Target cannot cast spells or use spell-like abilities.\nCommunicate: The target cannot take any actions that allow it to communicate with anyone. This includes such acts as speaking, Bluff checks to pass secret messages, writing, and using telepathy. It does not prevent verbalizations made for purposes other than communication, such as command words or the verbal component of spellcasting.\nDraw: Target cannot ready or prepare any item, weapon, component, or equipment.\nMove: The target can take no act that would cause it to end up in a different location. The target does not resist being moved by others (and thus can be picked up or dragged, or can float along on a raft), but does not consciously attempt to move (including not directing a mount to move).\nThe target is free to take any actions not forbidden by the caster. For example, a target affected by this spell's demand to not move is still free to cast spells, make attacks, or shout for help.";
                    break;
                case 3: //Sanctuary
                    richTextBox1.Text = "School abjuration\nCasting Time 1 standard action\nComponents V, S, DF\nRange touch\nTarget creature touched\nDuration 1 round/level\nSaving Throw Will negates; Spell Resistance no\n\nAny opponent attempting to directly attack the warded creature, even with a targeted spell, must attempt a Will save. If the save succeeds, the opponent can attack normally and is unaffected by that casting of the spell. If the save fails, the opponent can't follow through with the attack, that part of its action is lost, and it can't directly attack the warded creature for the duration of the spell. Those not attempting to attack the subject remain unaffected. This spell does not prevent the warded creature from being attacked or affected by area of effect spells. The subject cannot attack without breaking the spell but may use nonattack spells or otherwise act.";
                    break;
                case 4: //True Strike
                    richTextBox1.Text = "School divination\nCasting Time 1 standard action\nComponents V, F (small wooden replica of an archery target)\nRange personal\nTarget you\nDuration see text\n\nYou gain temporary, intuitive insight into the immediate future during your next attack. Your next single attack roll (if it is made before the end of the next round) gains a +20 insight bonus. Additionally, you are not affected by the miss chance that applies to attackers trying to strike a concealed target.";
                    break;
                case 5: //Cure Light Wounds
                    richTextBox1.Text = "School conjuration (healing)\nCasting Time 1 standard action\nComponents V, S\nRange touch\nTarget creature touched\nDuration instantaneous\nSaving Throw Will half (harmless); see text; Spell Resistance yes (harmless); see text\n\nWhen laying your hand upon a living creature, you channel positive energy that cures 1d8 points of damage + 1 point per caster level (maximum +5). Since undead are powered by negative energy, this spell deals damage to them instead of curing their wounds. An undead creature can apply spell resistance, and can attempt a Will save to take half damage.";
                    break;
            }
        }
    }
}
