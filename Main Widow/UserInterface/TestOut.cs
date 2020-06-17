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
    public partial class TestOut : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly TestLogic testLogic;
        public TestOut(TestLogic testLogic)
        {
            InitializeComponent();
            this.testLogic = testLogic;
        }
            
        private void TestAdd_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
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
            LoadData();
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
                        testLogic.Delete(new TestBindModel { Id = id });
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
