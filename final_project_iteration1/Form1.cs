using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project_iteration1
{
    public partial class Form1 : Form
    {
        lotrTimeline f2 = new lotrTimeline();
        lotrTree f3 = new lotrTree();
        lotrItem f4 = new lotrItem();
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (LOTRbutton.Checked)
            {
                if (timelineCheckBox.Checked)
                {
                    this.Hide();
                    f2.ShowDialog();
                }
                if (treeCheckBox.Checked)
                {
                    this.Hide();
                    f3.ShowDialog();
                }
                if (itemCheckBox.Checked)
                {
                    this.Hide();
                    f4.ShowDialog();
                }
                
            }
            
        }
    }
}
