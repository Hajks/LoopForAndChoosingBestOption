using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopForAndChoosingBestOption
{
    public partial class Form1 : Form
    {
        public Form1()
            // I shoudnt do this task in Visual Studio, but for as beginner it was so smart solution that i will write it because it might be usufull for me in future.
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Elephant[] elephants = new Elephant[7];
            elephants[0] = new Elephant { Name = "Lloyd", EarSize = 40 };
            elephants[1] = new Elephant { Name = "Kamil", EarSize = 33};
            elephants[2] = new Elephant { Name = "Darek", EarSize = 42};
            elephants[3] = new Elephant { Name = "Bartek", EarSize = 32 };
            elephants[4] = new Elephant { Name = "Sławek", EarSize = 44 };
            elephants[5] = new Elephant { Name = "Ziutek", EarSize = 37 };
            elephants[6] = new Elephant { Name = "Wariat", EarSize = 45 };

            Elephant biggestEars = elephants[0];
            for (int i = 0; i < elephants.Length; i++)
            {
                if (elephants[i].EarSize > biggestEars.EarSize)
                {
                    biggestEars = elephants[i]; //Loop for should finally choose an elephant with biggest ears. 
                }

            }
            MessageBox.Show("Największe uszy ma: " + biggestEars.Name + " i mają one " + biggestEars.EarSize.ToString() + " cm.");
        }
    }
}
