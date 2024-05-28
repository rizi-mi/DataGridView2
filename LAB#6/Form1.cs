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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Указываем, что колонок(столбцов) с данными будет три
            dataGridView1.ColumnCount = 5;
            //Задаем имена столбцов
            dataGridView1.Columns[0].Name = "Номер товара";
            dataGridView1.Columns[1].Name = "Название товара";
            dataGridView1.Columns[2].Name = "Цена товара";
            dataGridView1.Columns[3].Name = "Индекс товара";
            dataGridView1.Columns[4].Name = "Чек товара";
            //Добавляем строки данных
            string[] row = new string[] { "1", "Товар 1", "1000", "17001", "342112" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "2", "Товар 2", "2000", "17002", "344412" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "3", "Товар 3", "3000", "17003", "308912" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "4", "Товар 4", "4000", "17004", "349812" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "5", "Товар 5", "1500", "17005", "312112" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "6", "Товар 6", "4300", "17006", "342762" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "7", "Товар 7", "5400", "17007", "342562" };
            dataGridView1.Rows.Add(row);
        }
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            int cell = 0;
            if (e.KeyCode == Keys.Enter)
            {
                int currentRow = dataGridView1.CurrentRow.Index;
                if (currentRow >= 0)
                {
                    //Получаем индекс столбца для данной ячейки
                    int currentcell = dataGridView1.CurrentCell.ColumnIndex;
                    //Получаем общее количество столбцов
                    int countcell = dataGridView1.ColumnCount;
                    cell = currentcell + 1;
                    //Если текущий столбец равен
                    //их общему количеству то делаем переход на новую строку
                if (cell == countcell)
                    {
                        //Задаем первую ячейку, которая будет активной
                        //при переходе на новую строку
                        dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[0];
                    }
                    else
                    {
                        //Задаем следующую ячейку в строке,
                        //которая будет активна при нажатии на клавишу Enter
                    dataGridView1.CurrentCell = dataGridView1.Rows[currentRow - 1].Cells[cell];
                    }
                }
            }
            base.OnKeyUp(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
