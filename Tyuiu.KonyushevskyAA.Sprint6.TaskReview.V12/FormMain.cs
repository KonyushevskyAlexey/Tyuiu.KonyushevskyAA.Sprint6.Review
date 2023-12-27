using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KonyushevskyAA.Sprint6.TaskReview.V12.Lib;

using System.IO;

namespace Tyuiu.KonyushevskyAA.Sprint6.TaskReview.V12
{
    public partial class FormMain_KAA : Form
    {
        public FormMain_KAA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        
        

        private void buttonhelp_KAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonCreat_KAA_Click(object sender, EventArgs e)
        {
           //
        }

        private void buttonChange_KAA_Click(object sender, EventArgs e)
        {
            try
            {
                int m, n, n1, n2, k, l, c;
                m = Convert.ToInt32(textBoxm_KAA.Text);
                n = Convert.ToInt32(textBoxn_KAA.Text);
                n1 = Convert.ToInt32(textBoxStart_KAA.Text);
                n2 = Convert.ToInt32(textBoxStop_KAA.Text);
                k = Convert.ToInt32(textBoxK_KAA.Text);
                l = Convert.ToInt32(textBoxl_KAA.Text);
                c = Convert.ToInt32(textBoxc_KAA.Text);

                // Проверка на корректность ввода интервальных значений
                if (n1 >= n2 || k >= l || c >= m)
                {
                    MessageBox.Show("Ошибка ввода интервальных значений!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создание и заполнение двумерного массива
                int[,] array = new int[n, m];
                Random rand = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (j >= 3 && (j % 3 == 0))
                        {
                            array[i, j] = array[i, j - 1] + array[i, j - 2] + array[i, j - 3];
                        }
                        else
                        {
                            array[i, j] = rand.Next(n1, n2 - 1);
                        }
                    }
                }


                // Вывод матрицы в DataGridView
                dataGridView_KAA.RowCount = n;
                dataGridView_KAA.ColumnCount = m;
                for (int i = 0; i < n; i++)
                {
                   
                    for (int j = 0; j < m; j++)
                    {
                        dataGridView_KAA[j, i].Value = array[i, j];
                    }
                }

                

                // Количество нечетных элементов
                int oddCount = 0;

                // Выполнение цика по строкам от K до L включительно
                for (int i = k; i <= l; i++)
                {
                    // Проверьте, находится ли элемент в указанном столбце с нечетным индексом
                    if (i % 2 != 0)
                    {
                        oddCount++;
                    }
                }
                textBoxResult_KAA.Text = Convert.ToString(oddCount);

                

            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void textBoxResult_KAA_TextChanged(object sender, EventArgs e)
        {
           //

        }
    }
}
