using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

namespace ExcelAddIn
{
    public partial class Ribbon1
    {
        private List<Client> clients;
        private Microsoft.Office.Interop.Excel.Application excel;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            clients = new List<Client>();
            excel = Globals.ThisAddIn.Application;
            //MessageBox.Show();
            //excel.Range["A1"].Value = "ID";
            //excel.Range["B1"].Value = "Balance";
            //excel.Range["A2"].Select();
            //excel.ActiveCell.Offset[1, 0].Select();   //сдвиг от выбраной на 1 вниз и 0 в право
            //excel.Range["A1:B3"].Value = "Ok";
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            List<int> numbers = new List<int>();
            int value = 0;
            while (excel.ActiveCell.Value != null)
            {
                if (int.TryParse(excel.ActiveCell.get_Value().ToString(), out value))
                {

                }
                numbers.Add(value);
                excel.ActiveCell.Offset[1, 0].Select();
            }
            numbers.Sort();
            excel.ActiveCell.Offset[-numbers.Count, 0].Select();
            foreach (int number in numbers)
            {
                excel.ActiveCell.Value = number;
                excel.ActiveCell.Offset[1, 0].Select();
            }
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            int i = 0;
            object[,] count = excel.Range["A1:ZZ500"].Value;
            foreach (object numb in count)
            {
                if (numb != null) i++;
            }
            MessageBox.Show(i.ToString());
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
            List<int> numbers = new List<int>();
            int value = 0;
            while (excel.ActiveCell.Value != null)
            {
                if (int.TryParse(excel.ActiveCell.get_Value().ToString(), out value))
                {
                    numbers.Add(value);
                    excel.ActiveCell.Offset[1, 0].Select();
                }
            }
            MessageBox.Show("Сумма: " + initSum(numbers) + " Среднее:" + initAverange(numbers) + " " + getMinAndMax(numbers));
        }

        private int initSum(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        private double initAverange(List<int> numbers)
        {
            return (initSum(numbers) / numbers.Count);
        }

        private string getMinAndMax(List<int> numbers)
        {
            numbers.Sort();
            return ("Минимум: " + numbers[0] + ", Максимум: " + numbers[numbers.Count-1]);
        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {
            int a1, b1, a2, b2;
            if (int.TryParse(editBox1.Text, out a1) &&
                int.TryParse(editBox2.Text, out b1) &&
                int.TryParse(editBox3.Text, out a2) &&
                int.TryParse(editBox4.Text, out b2))
            {
                if (a1 == b2 && a2 == b1 && a1 > 0 && b1 > 0 && a2 > 0 && b2 > 0)
                {
                    int[,] matrix1 = initMatrix(a1, b1);
                    excel.ActiveCell.Offset[0, b1 + 1].Select();
                    int[,] matrix2 = initMatrix(a2, b2);
                    multMatrix(matrix1, matrix2);
                }
            }
        }

        private int[,] initMatrix(int a, int b)
        {
                int[,] matrix = new int[a, b];
                while (excel.ActiveCell.Value != null)
                {
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            matrix[i, j] = Convert.ToInt32(excel.ActiveCell.get_Value().ToString());
                            excel.ActiveCell.Offset[0, 1].Select();
                        }
                        excel.ActiveCell.Offset[0, -b].Select();
                        excel.ActiveCell.Offset[1, 0].Select();
                    }
                }
                excel.ActiveCell.Offset[-a, 0].Select();
                return matrix;
        }

        private void multMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        resultMatrix[k, i] += matrix1[k, j] * matrix2[j, i];
                    }
                }
            }
            string result = "";
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    result += (resultMatrix[i, j] + "   ");
                }
                result += "\n\n";
            }
            MessageBox.Show(result);
        }

        private void button5_Click(object sender, RibbonControlEventArgs e)
        {
            initList();
            var result = clients.Where(x => x.Name[0] == editBox5.Text[0]).ToList();
            excel.Range["E1"].Select();
            getListResult(result);
        }

        private void initList()
        {
            clients.Clear();
            excel.Range["A1"].Select();
            while (excel.ActiveCell.Value != null)
            {
                string name = excel.ActiveCell.Value.ToString();
                excel.ActiveCell.Offset[0, 1].Select();
                int money = Convert.ToInt32(excel.ActiveCell.Value.ToString());
                excel.ActiveCell.Offset[0, 1].Select();
                int count = Convert.ToInt32(excel.ActiveCell.Value.ToString());
                excel.ActiveCell.Offset[1, -2].Select();
                clients.Add(new Client(name, money, count));
            }
        }

        private void getListResult(List<Client> result)
        {
            foreach (Client client in result)
            {
                excel.ActiveCell.Value = client.Name;
                excel.ActiveCell.Offset[0, 1].Select();
                excel.ActiveCell.Value = client.Money;
                excel.ActiveCell.Offset[0, 1].Select();
                excel.ActiveCell.Value = client.OrderCount;
                excel.ActiveCell.Offset[1, -2].Select();
            }
        }

        private void button6_Click(object sender, RibbonControlEventArgs e)
        {
            initList();
            var result = clients.Where(x => string.Compare(x.Name, editBox6.Text) > 0).ToList();
            excel.Range["E1"].Select();
            getListResult(result);
        }

        private void button7_Click(object sender, RibbonControlEventArgs e)
        {
            initList();
            int a = 0, b = 0;
            if (int.TryParse(editBox7.Text, out a) && int.TryParse(editBox8.Text, out b))
            {
                var result = clients.Where(x => x.Money >= a && x.Money <= b).ToList();
                excel.Range["E1"].Select();
                getListResult(result);

            }
        }

        private void button8_Click(object sender, RibbonControlEventArgs e)
        {
            initList();
            var result = clients.Where(x => string.Compare(x.Name, editBox6.Text) > 0 && x.Money % 3 == 0
                                                                            && x.Money % 7 == 0).ToList();
            excel.Range["E1"].Select();
            getListResult(result);
        }

        private void button9_Click(object sender, RibbonControlEventArgs e)
        {
            excel.Range["C1"].Select();
            while (excel.ActiveCell.Value != null)
            {
                int number = Convert.ToInt32(excel.ActiveCell.Value.ToString());
                if (number < 10) excel.ActiveCell.Interior.Color = Color.Red;
                else if (number < 15) excel.ActiveCell.Interior.Color = Color.Yellow;
                else if (number < 20) excel.ActiveCell.Interior.Color = Color.YellowGreen;
                excel.ActiveCell.Offset[1, 0].Select();
            }
        }
    }
}
