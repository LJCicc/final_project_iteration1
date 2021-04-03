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
    public partial class firstAge : Form
    {
        public firstAge()
        {
            InitializeComponent();
        }

        private void firstAgeYear_TextChanged(object sender, EventArgs e)
        {
            firstAgeYear.Text = Console.ReadLine();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
