using BusinessLogic.BindingModels;
using BusinessLogic.Views;
using DataBaseImplemention.Logic;
using DataBaseImplemention.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace UserInterface
{
    public partial class TestAdd : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

     
        private readonly TestLogic testLogic;
        private readonly QuestionLogic questionLogic;
        private List<Question> gridQuest;
        private int Id { set { Id = value; } }
        private int? id;
        public TestAdd(TestLogic testLogic, QuestionLogic questionLogic)
        {
            InitializeComponent();
            this.testLogic = testLogic;
            this.questionLogic = questionLogic;
        }
        private void TestAdd_Load(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add("quest", "Вопрос");
            dataGridView2.Columns.Add("rightNum", "Ответ");
            LoadData();
        }

        private void LoadData()
        {
                try
                {
                  
                }
                catch { }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<QuestAdd>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<AddQuestInTest>();
            form.ShowDialog();
        }
    }
}
