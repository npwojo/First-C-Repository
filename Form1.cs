using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "Bowser";
            label6.Text = "Bottom";
            label8.Text = "13";
            pictureBox13.ImageLocation = @"C:\Users\Nicholas P Wojcik\Desktop\bowser5.png";
            label4.Text = "Bowser has  along history of kidnapping Peach to lure\nhis nemesis, Mario, into traps.  He leads an enormous\ngroup of mischevious creatures," +
                " not the least of which\nare his seven children.  With outrageous strength,\nflammable breath, and more spikes than you can\nshake a Star Rod at," +
                " Bowser is a constant threat.";
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label1.Text = "Link";
            label6.Text = "Middle";
            label8.Text = "9";
            pictureBox13.ImageLocation = @"C:\Users\Nicholas P Wojcik\Desktop\link2.png";
            label4.Text = "Even in his youth, Link was already becoming the\nwarrior who would carry the destiny of Hyrule\n(and many other lands) on his shoulders." +
                "  His epic\nstruggles against the forces of darkness are written\nin legend.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "Mario";
            label6.Text = "Middle";
            label8.Text = "8";
            pictureBox13.ImageLocation = @"C:\Users\Nicholas P Wojcik\Desktop\mario2.png";
            label4.Text = "Known worldwide as Mr. Nintendo, Mario uses his\nincredible jumping ability to thwart the evil Bowser time\nafter time.  " +
                "While he's best known as a hero, Mario\nhas played many roles, including racer, doctor,\ngolfer, and villain.  His tastes have changed over\n" +
                " 20 years of gaming; he long ago swapped the colors\nof his shirt and overalls.";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "Luigi";
            label6.Text = "Middle";
            label8.Text = "7";
            pictureBox13.ImageLocation = @"C:\Users\Nicholas P Wojcik\Desktop\luigi2.png";
            label4.Text = "Although Mario's younger brother has always played\na second fiddle, Luigi finally garnered the spotlight\nwith his very own game," +
                " Luigi's Mansion.  Things are\nlooking up for the eternal understudy; he's even\npicked up his own rival in Waluigi.  The day he's\nreffered" +
                " to as the \"lean, mean, green machine\"\nmay not be too far off.";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "Pikachu";
            label6.Text = "Middle";
            label8.Text = "5";
            pictureBox13.ImageLocation = @"C:\Users\Nicholas P Wojcik\Desktop\pikachu2.png";
            label4.Text = "It's safe to say that Pikachu is the most famous and\npopular of all Pokemon.  It has electric pouches in both\ncheeks; when in danger," +
                " it shoots electricity at its\nenemies.  Although Pikachu can evolve into Raichu\nby exposure to a Thunderstone, many trainers like\nPikachu" +
                " so much that they don't let it evolve.";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "Peach";
            label6.Text = "Top";
            label8.Text = "3";
            pictureBox13.ImageLocation = @"C:\Users\Nicholas P Wojcik\Desktop\peach2.png";
            label4.Text = "The princess of the Mushroom Kingdom.  Her long\nblond hair is a perfect match for her pink dress.\nRegardless of the number" +
                " of Toad retainers she has,\nshe's often kidnapped by Bowser.  Though she's\nusually the damsel in distress, she got a starring role\n" +
                " in Super Princess Peach, where it was her turn to\nrescue Mario and Luigi.";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label1.Text = "Yoshi";
            label6.Text = "Bottom";
            label8.Text = "11";
            pictureBox13.ImageLocation = @"C:\Users\Nicholas P Wojcik\Desktop\yoshi3.png";
            label4.Text = "A creature that hails from Yoshi's Island.  Yoshis come\nin a variety of colors, and all possess gentle\npersonalities.  No matter" +
                " what problems they face,\nthey always look like they're having fun.  Yoshis use\ntheir long tongues to grab and swallow fruit and\nenemies.  " +
                "They can convert what they swallow into\neggs, which they then lay.  They also give Mario rides.";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label1.Text = "Fox";
            label6.Text = "Top";
            label8.Text = "1";
            pictureBox13.ImageLocation = @"C:\Users\Nicholas P Wojcik\Desktop\fox2.png";
            label4.Text = "Fox McCloud is the leader of a band of adventures-\nfor-hire known as Star Fox.  Fox and his fellow pilots\nPeppy, Slippy, and Falco patrol the Lylat" +
                " system in\ntheir mother ship, the Great Fox.  From the cockpit\nof his Arwing, Fox leads the ceaseless pursuit of the\nevil scientist Andross," +
                " who doomed Fox's father.";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label1.Text = "Zelda";
            label6.Text = "Middle, (Shiek Top)";
            label8.Text = "12, (Shiek 2)";
            pictureBox13.ImageLocation = @"C:\Users\Nicholas P Wojcik\Desktop\zelda2.png";
            label4.Text = "The crown princess of Hyrule.  She knows much about\nthe Triforce; in fact, the only person who likely knows\nmore about the Triforce" +
                " lore is Ganondorf himself,\nwhom Zelda evaded in Ocarina of Time by\ntransforming into her alter ego, Sheik.";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label1.Text = "Captain Falcon";
            label6.Text = "Top";
            label8.Text = "4";
            pictureBox13.ImageLocation = @"C:\Users\Nicholas P Wojcik\Desktop\CF2.png";
            label4.Text = "Usually a relentless bountry hunter, Captain Falcon\nshifts gears to become a race pilot once the F-Zero\nGrand Prix begins." +
                " His beloved racer, the Blue Falcon,\ncan exceed the speed of sound, and he knows how to\ndrive it; he'll go down as one of the all-time greats";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label1.Text = "Donkey Kong";
            label6.Text = "Bottom";
            label8.Text = "10";
            pictureBox13.ImageLocation = @"C:\Users\Nicholas P Wojcik\Desktop\dk3.png";
            label4.Text = "While he now prefers the laid-back jungle lifestyle to\nconstruction site mischief, Donkey Kong is often forced\nback into action by the" +
                " Kremling Krew.  The great ape\nis quite fast despite his burly physique, and he keeps\nhis strength up with a steady diet of his favorite\nfood: bananas." +
                " His one extravagance (and only piece\nof clothing) is a monogrammed necktie.";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label1.Text = "Samus";
            label6.Text = "Middle";
            label8.Text = "6";
            pictureBox13.ImageLocation = @"C:\Users\Nicholas P Wojcik\Desktop\samus2.png";
            label4.Text = "This intergalactic bounty hunter's full name is Samus\nAran.  Clad in a power suit made by the Chozo race\nand infused with their enchanced blood, she" +
                " cleared\nthe planet Zebes of a Metroid infestation.  Samus is\nan orphan, the sole survivor of a Space Pirate raid\nthat destroyed an Earth colony named K-2L.";
        }
    }
}
