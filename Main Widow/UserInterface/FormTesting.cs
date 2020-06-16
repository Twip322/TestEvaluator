using BusinessLogic.Views;
using DataBaseImplemention.Logic;
using DataBaseImplemention.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class FormTesting : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        TestLogic logic;
        Dictionary<int, (string, string, int)> tmp;
        int[] questNum;
        int questNumCurr=0;
        int answer;
        int n;
        int result;
        public FormTesting(TestLogic logic)
        {
            InitializeComponent();
            this.logic=logic;
            
        }

        private void FormTesting_Load(object sender, EventArgs e)
        {
            var list = logic.Read(null);
            if (list != null)
            {
                dataGridView1.DataSource = list;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].Visible = false;
            }
        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            tmp=(Dictionary<int, (string, string, int)>)dataGridView1.SelectedRows[0].Cells[2].Value;
            questNum = tmp.Keys.ToArray();
            questNumCurr = 0;
            StartTest.Enabled=false;
            Exit.Enabled = false;
            Answer.Enabled = true;
            DNK.Enabled = true;
            printquest(questNum[questNumCurr]);
        }

        private void End_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                answer = 1;
            else if (radioButton2.Checked)
                answer = 2;
            else if (radioButton3.Checked)
                answer = 3;
            else if (radioButton4.Checked)
                answer = 4;

            if (answer == tmp[questNum[questNumCurr]].Item3)
            {
                result++;
            }
            questNumCurr++;
            if(questNumCurr<questNum.Length)
            printquest(questNum[questNumCurr]);
            else
            {
                Marking();
            }
        }

        private void DNK_Click(object sender, EventArgs e)
        {
            questNumCurr++;
            if (questNumCurr < questNum.Length)
                printquest(questNum[questNumCurr]);
            else
            {
                Marking();
            }
        }
        private void printquest(int n)
        {
            richTextBox1.Text = "";
            string[] str= tmp[n].Item2.ToString().Split(' ');
            textBox1.Text = tmp[n].Item1.ToString();
            for(int i=0;i<str.Length;i++)
            richTextBox1.Text += i+1+ " " +str[i]+"\n";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public void Marking()
        {
            if (tmp.Count == result)
                MessageBox.Show("Поздравляем, вы у нас отличник!", "Гений!", MessageBoxButtons.OK);
            else if(tmp.Count / 2 < result)
                MessageBox.Show("Ну, на четыре вы знаете, давайте зачётку", "Неплохо", MessageBoxButtons.OK);
            else if(tmp.Count/2==result)
                MessageBox.Show("Ну, на тройку хватит", "Пойдёт", MessageBoxButtons.OK);
            else if(tmp.Count/2>result)
                MessageBox.Show("Ну что ж встретимся на пересдаче", "Полный провал", MessageBoxButtons.OK);
            Answer.Enabled = false;
            DNK.Enabled = false;
            End.Enabled = true;

        }
    }
}
