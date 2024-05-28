using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView2
{
    public partial class Form2 : Form
    {
        int counter = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.jpg; *.jpeg; *.gif; *.bmp; *.ico;*.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.ico; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageList1.Images.Add(Image.FromFile(openFileDialog1.FileName));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Указываем, что колонок(столбцов) с данными будет три
            dataGridView1.ColumnCount = 5;
            //Задаем имена столбцов
            dataGridView1.Columns[0].Name = "НАЗВАНИЕ";
            dataGridView1.Columns[1].Name = "ИЗОБРАЖЕНИЕ";
            dataGridView1.Columns[2].Name = "ОЦЕНКА 1-5";
            dataGridView1.Columns[3].Name = "НРАВИТСЯ (да или нет?)";
            dataGridView1.Columns[4].Name = "ВПЕЧАТЛЕНИЕ";
            //создание ячеек
            DataGridViewCell name = new DataGridViewTextBoxCell();
            DataGridViewCell image = new DataGridViewImageCell();
            DataGridViewCell price = new DataGridViewTextBoxCell();
            DataGridViewCell condition = new DataGridViewTextBoxCell();
            //заполнение ячеек
            name.Value = textBox1.Text;
            image.Value = imageList1.Images[counter++];
            price.Value = int.Parse(textBox2.Text);
            condition.Value = textBox3.Text;
            //создание строки
            DataGridViewRow row = new DataGridViewRow();
            //добавление ячеек в строку
            row.Cells.AddRange(name, image, price, condition);
            //добавление строки в таблицу
            dataGridView1.Rows.Add(row);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            //обновляем таблицу
            dataGridView1.Refresh();
            textBox1.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
