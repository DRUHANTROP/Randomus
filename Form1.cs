using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomicGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] ar = { "ID", "First Name", "Last Name", "Full Name", "Mixed (in progress)" };
            genCB.Items.AddRange(ar);
            genCB.SelectedIndex = 0;
            countUD.Minimum = 0;
            countUD.Value = 10;
        }

        private void generateB_Click(object sender, EventArgs e)
        {
            resultLB.Items.Clear();
            IRandomGenerator random = new IntGenerator();
            switch (genCB.SelectedIndex)
            {
                case 0:
                    random = new IntGenerator();
                    break;
                case 1:
                    random = new FirstNameGenerator();
                    break;
                case 2:
                    random = new LastNameGenerator();
                    break;
                case 3:
                    random = new FullNameGenerator();
                    break;
                case 4:
                    random = new MixedGenerator();
                    break;
            }
            for (int i = 0; i < countUD.Value; i++)
            {
                resultLB.Items.Add(random.Next());
            }
        }
    }
}
