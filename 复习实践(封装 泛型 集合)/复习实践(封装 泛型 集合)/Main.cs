using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 复习实践_封装_泛型_集合_
{
    public partial class Main : Form
    {
        ArrayList list = null;
        Dictionary<string, StudentMess> dt = null;
        public Main()
        {
            InitializeComponent();
            list = new ArrayList();
            dt = new Dictionary<string, StudentMess>();

        }
        //添加
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") 
            {
                MessageBox.Show("请填写数据！");
            }
            else
            {
                string name = textBox1.Text;
                int score = int.Parse(textBox2.Text);
                string grade = textBox3.Text;
                //list.Add();
                list.Add(name);
                dt.Add(name, new StudentMess() { Name = name, Score = score, Grade = grade });
                listBox1.Items.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    listBox1.Items.Add(list[i]);
                }
            }
        }

        //成绩查询
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem!=null)
            {
                string name = listBox1.SelectedItem.ToString();
                textBox4.Text = $"姓名：{dt[name].Name}\r\n班级：{dt[name].Grade}\r\n分数：{dt[name].Score}";
            }
            else
            {
                MessageBox.Show("请选择要查询的学生信息！");
            }
        }

        //信息删除
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string name = listBox1.SelectedItem.ToString();
                list.RemoveAt(listBox1.SelectedIndex);
                dt.Remove(name);
                listBox1.SelectedItems.Remove(name);
                listBox1.Items.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    listBox1.Items.Add(list[i]);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的学生信息！");
            }
        }

        //升序
        private void button4_Click(object sender, EventArgs e)
        {
            list.Sort();
            listBox1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                listBox1.Items.Add(list[i]);
            }
        }

        //降序
        private void button5_Click(object sender, EventArgs e)
        {
            list.Sort();
            list.Reverse();
            listBox1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                listBox1.Items.Add(list[i]);
            }
        }
    }
}
