using BusinessLogic.Views;
using DataBaseImplemention.Logic;
using System;
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
        TestLogic testLogic;
        public TestOut(TestLogic testLogic)
        {
            InitializeComponent();
            this.testLogic = testLogic;
        }
            
        private void TestAdd_Load(object sender, EventArgs e)
        {
            var list = testLogic.Read(null);
            if (list != null)
            {
                dataGridView1.DataSource = list;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<TestAdd>();
            form.ShowDialog();
        }

       

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
