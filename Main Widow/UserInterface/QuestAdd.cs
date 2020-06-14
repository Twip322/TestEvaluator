using BusinessLogic.BindingModels;
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
    public partial class QuestAdd : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly QuestionLogic questionLogic;
        private int Id { set { Id = value; } }
        private int? id;
        public QuestAdd(QuestionLogic questionLogic)
        {
            InitializeComponent();
            this.questionLogic = questionLogic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                questionLogic.CreateOrUpdate(new QuestionBindModel
                {
                    Id = id,
                    quest = textBoxName.Text,
                    answers=textBoxANS1.Text+'\n'+textBoxANS2.Text+'\n'+textBoxANS3.Text+'\n'+textBoxANS4.Text,
                    rightNum=Convert.ToInt32(textBoxRIGHT.Text)
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close();
        }

        private void QuestAdd_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = questionLogic.Read(new QuestionBindModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.quest;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
    }
}
