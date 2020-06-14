﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace UserInterface
{
    public partial class TestOut : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public TestOut()
        {
            InitializeComponent();
        }

        private void TestAdd_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<TestAdd>();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
