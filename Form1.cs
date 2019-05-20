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
        private List<IRandomGenerator> generators = new List<IRandomGenerator>();
        public Form1()
        {
            InitializeComponent();
            generators.Add(new IntGenerator());
            generators.Add(new FirstNameGenerator());
            generators.Add(new LastNameGenerator());
            generators.Add(new FullNameGenerator());
            generators.Add(new MixedGenerator());
            foreach (var item in generators)
            {
                genCB.Items.Add(item.Name);
            }
            genCB.SelectedIndex = 0;
            countUD.Minimum = 0;
            countUD.Value = 10;
        }

        private void generateB_Click(object sender, EventArgs e)
        {
            resultLB.Items.Clear();
            IRandomGenerator random = new IntGenerator();
            random = (from i in generators where i.Name == genCB.SelectedItem.ToString() select i).First();
            for (int i = 0; i < countUD.Value; i++)
            {
                resultLB.Items.Add(random.Next());
            }
        }
    }
}
