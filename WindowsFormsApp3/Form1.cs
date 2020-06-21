using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
    int[] array = new int[27];
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)//кнопка генерации случайного массива
        {
            dataGridView1.ColumnCount = 27;//кол-во строк в списке массивов
            Random rand = new Random();//создание случайного массива 
            for (int i = 0; i < array.Length; i++)//Начало цикла
            {
                array[i] = rand.Next(-200, 200);
                dataGridView1.Rows[0].Cells[i].Value = array[i];
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)//кнопка сортировки 
        {
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = array[i];
            }
        }
        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)// Составление диаграммы
        {
            int[] x = array;
            int[] y = new int[27];
            for (int i = 0; i < 27; i++)
            {
                y[i] = array[i];
                x[i] = i;
                chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 10;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
                chart1.Series[0].Points.DataBindXY(x, y);
            }
        }

        private void Button4_Click(object sender, EventArgs e)//Очистка
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = "";
            }
            label1.Text = "";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)//Выполнение задания
        {
            double sr_ar = 0;
            int sum = 0;//переменная обозначенная за сумму
            int count = 0;//переменная обозначенная за кол-во отрицательных элементов массива
            Random rand = new Random();
            int[] array = new int[27];
            for (int i = 0; i < 27; i++)//начало цикла
            {
                array[i] = rand.Next(-200, 200);
   

                if (array[i] < 0)
                {
                    sum += array[i];
                    count++;
                }

            }
            sr_ar = sum / count;//вычисление среднего арифметического из отрицательных элементов
            label1.Text = "Среднее арифметическое отрицательных элементов массива : " + sr_ar.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)//Переход на 2 форму
        {
            Form1.ActiveForm.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Button7_Click(object sender, EventArgs e)//переход на 3 форму
        {
            Form1.ActiveForm.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
