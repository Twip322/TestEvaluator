using BusinessLogic.BindingModels;
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
    public partial class AddQuestInTest : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id
        {
            get { return Convert.ToInt32(comboBox1.SelectedValue); }
            set { comboBox1.SelectedValue = value; }
        }
        public string quest { get { return comboBox1.Text; } }
        public string answer { get { return comboBox1.Items.ToString(); } }
        public AddQuestInTest(QuestionLogic logic)
        {
            InitializeComponent();
            List<Question> list = logic.Read(null);
            if (list != null)
            {
                comboBox1.DisplayMember = "quest";
                comboBox1.ValueMember = "Id";
                comboBox1.DataSource = list;
                comboBox1.SelectedItem = null;

            }
        }


        private void AddQuestInTest_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
