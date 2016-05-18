using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;

namespace WordAddIn1
{
    public partial class Ribbon1
    {
        
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            //Document document = Globals.ThisAddIn.Application.ActiveDocument;
            //string allText = document.Range(document.Content.Start, document.Content.End).Text;
            Selection cursor = Globals.ThisAddIn.Application.Selection;
            string parAllTeaxt = cursor.Paragraphs.First.Range.Text;
            string[] parLeters = parAllTeaxt.Split(' ', ',', '.', '!', '?', '\n', ':', '-');
            int count = -1;
            foreach (string leter in parLeters) count += leter.Length;
            MessageBox.Show("Количество символов: " + count + ", " + parAllTeaxt.Length);
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            var count = Globals.ThisAddIn.Application.ActiveDocument.Paragraphs;
            MessageBox.Show("Количество абзацов: " + count.Count);
        }

        private void button1_Click_1(object sender, RibbonControlEventArgs e)
        {
            Document document = Globals.ThisAddIn.Application.ActiveDocument;
            string[] allText = document.Range(document.Content.Start, document.Content.End).Text.Split(' ', ',', '.', '!', '?', '\n', ':', '-');
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (string s in allText)
            {
                if (result.ContainsKey(s)) result[s]++;
                else result.Add(s, 1);
            }
            foreach (var s in result) document.Range(document.Content.Start, document.Content.End).Text += (s);
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
            Document document = Globals.ThisAddIn.Application.ActiveDocument;
            StringBuilder allText = new StringBuilder(document.Range(document.Content.Start, document.Content.End).Text);
            for (int i = 0; i < allText.Length; i++)
            {
                char c = allText[i];
                if (char.IsLetter(c))
                {
                    if (i%2 != 0) allText[i] = char.ToUpper(c);
                    else allText[i] = char.ToLower(c);
                }
            }
            document.Range(document.Content.Start, document.Content.End).Text = allText.ToString();
        }

        private void comboBox1_TextChanged(object sender, RibbonControlEventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Заголовок 1":
                    Globals.ThisAddIn.Application.Selection.Paragraphs.First.Range.set_Style("Заголовок 1"); break;
                case "Заголовок 2":
                    Globals.ThisAddIn.Application.Selection.Paragraphs.First.Range.set_Style("Заголовок 2"); break;
                case "Обычный":
                    Globals.ThisAddIn.Application.Selection.Paragraphs.First.Range.set_Style("Обычный"); break;
                case "Рыжий":
                    Globals.ThisAddIn.Application.Selection.Paragraphs.First.Range.set_Style("Рыжий"); break;
                case "Непонятный":
                    Globals.ThisAddIn.Application.Selection.Paragraphs.First.Range.set_Style("Выделенная цитата"); break;
            }
        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {
            Document document = Globals.ThisAddIn.Application.ActiveDocument;
            var allText = document.Range(document.Content.Start, document.Content.End).Text;
            document.Range(document.Content.Start, document.Content.End).Font.Name = "Times New Roman";
            String titleTop = "Министерство образования и науки Российской Федерации\n" +
                           "Федеральное государственное автономное образовательное учреждение высшего профессионального образования\n" +
                           "«Уральский федеральный университет имени первого Президента России Б.Н.Ельцина»\n" +
                           "Институт радиоэлектроники и информационных технологий – РтФ\n" +
                           "Кафедра «Информационных технологий»\n";
            for (int i = 0; i < 5; i++) titleTop += "\n";
            document.Range(document.Content.Start, document.Content.End).Text = titleTop;
            document.Range(document.Content.Start, document.Content.End).Text += "ОТЧЕТ ПО ЛАБОРАТОРНОЙ РАБОТЕ № 5\n\n";
            document.Range(document.Content.Start, document.Content.End).Text += "Студенты группы:";
            document.Range(document.Content.Start, document.Content.End).Text += "РИ-240002";
            document.Range(document.Content.Start, document.Content.End).Text += "Кирюха";
            document.Range(document.Content.Start, document.Content.End).Text += "Андрюха";
            document.Range(document.Content.Start, document.Content.End).Text += "Преподаватель:";
            document.Range(document.Content.Start, document.Content.End).Text += "Ростунцев С. Д.\n";
            for (int i = 0; i < 6; i++) document.Range(document.Content.Start, document.Content.End).Text += "\n";
            document.Range(document.Content.Start, document.Content.End).Text += "Екатеринбург\n2016\n";

            for (int i = 1; i < 7; i++)
            {
                document.Paragraphs[i].Range.Font.Size = Convert.ToSingle("11");
                document.Paragraphs[i].Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            }
            document.Paragraphs[12].Range.Font.Size = Convert.ToSingle("20");
            document.Paragraphs[12].Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            for (int i = 14; i < 21; i++)
            {
                document.Paragraphs[i].Range.Font.Size = Convert.ToSingle("14");
                document.Paragraphs[i].Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            }
            for (int i = 21; i < document.Paragraphs.Count; i++)
            {
                document.Paragraphs[i].Range.Font.Size = Convert.ToSingle("14");
                document.Paragraphs[i].Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            }

            document.Range(document.Content.End-1, document.Content.End).Text = "\n"+allText;
        }
    }
}
