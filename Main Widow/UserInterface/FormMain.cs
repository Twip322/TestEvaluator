using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FormMain : Form
    {
        FormTesting test;
        public FormMain()
        {
            InitializeComponent();
        }

        private void Testing_Click(object sender, EventArgs e)
        {
            test = new FormTesting();
            test.Show();
        }

        private void Test_Click(object sender, EventArgs e)
        {

        }

      
    }
}
