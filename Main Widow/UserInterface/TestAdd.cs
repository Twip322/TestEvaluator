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

        Dictionary<int, (string,string, int)> testQuests=new Dictionary<int,(string, string, int)>();
        private int Id { set { Id = value; } }
        private int? id;
        public TestAdd(TestLogic testLogic, QuestionLogic questionLogic)
        {
            InitializeComponent();
            this.testLogic = testLogic;
        }
        private void TestAdd_Load(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add("Id", "Id");
            dataGridView2.Columns.Add("quest", "Вопрос");
            dataGridView2.Columns.Add("answers", "Ответ");
            dataGridView2.Columns.Add("rightNum", "Правильный");
            LoadData();
        }

        private void LoadData()
        {
                try
                {
                    dataGridView2.Rows.Clear();
                    foreach(var pc in testQuests)
                {
                    dataGridView2.Rows.Add( new object[] { pc.Key, pc.Value.Item1, pc.Value.Item2, pc.Value.Item3 } );
                }
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
            try
            {
                testLogic.CreateOrUpdate(new TestBindModel
                {
                    Id = id,
                    testName = textBoxName.Text,
                    testQuestions = testQuests
                });
                DialogResult=DialogResult.OK;
                Close();
            }
            catch { }
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
            if(form.DialogResult==DialogResult.OK)
            {
                if (testQuests.ContainsKey(form.Id))
                {
                    testQuests[form.Id] = (form.quest, form.answer,form.rightNum);
                }
                else
                {
                    testQuests.Add(form.Id, (form.quest, form.answer, form.rightNum));
                }
                    LoadData();
            }
        }
    }
}
