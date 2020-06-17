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
        private readonly QuestionLogic logic;
        public int Id
        {
            get { return Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value); }
        }

        public string quest { get { return dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); } }
        public string answer { get { return dataGridView1.SelectedRows[0].Cells[2].Value.ToString(); } }
        public int rightNum { get { return Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value); } }
        public AddQuestInTest(QuestionLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
            LoadData();
        }
        private void LoadData()
        {
            List<Question> list = logic.Read(null);
            if (list != null)
            {
                dataGridView1.DataSource = list;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        logic.Delete(new QuestionBindModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }
    }
}
