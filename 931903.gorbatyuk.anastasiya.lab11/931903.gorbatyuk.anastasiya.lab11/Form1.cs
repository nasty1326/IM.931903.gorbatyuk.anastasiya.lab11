using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _931903.gorbatyuk.anastasiya.lab11
{

    public partial class Form1 : Form
    {

        double teoMean = 0; // теоретическое мат. ожидание
        double teoVar = 0; // теоретческая дисперсия
        double statMean = 0; // эмпирическое мат. ожидание
        double statVar = 0; // эмпирическая дисперсия
        double ErMean = 0; //погрешность мат. ожидания
        double ErVar = 0; // погрешность дисперсии
        double Hi = 0; // хи-квадрат
        int size; // число эксперементов
        // таблица хи-квадрата
        double[] HiValue = new double[12] {3.841, 5.991, 7.815, 9.488, 11.070, 12.592, 14.067, 15.507, 16.919, 18.307, 19.675, 21.026};
        int stolb; //число столбцов в гистограмме
        double stolbLength; // размер диапозона значений в гистограмме
         double h1, h2;
        int[] stolbCount; // массив для суммы значений в гистрограмме
        double[] spanLen; // массив по х в гистограмме
        double[] stolbFreq; // массив для соотношения количества попавших в промежуток к общему количеству эксперементов
        
        double max = -100000, min = 100000; // минимальное и максимальное значение в эксперементах
        double[] normDis; // массив для записи результатов при нормальном распределении
        double curLength;
        Random rnd = new Random();
        double pi = 0, px = 0, x = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear(); // ощищаем график
            teoMean = (double)numMean.Value; // считываем мат ожидание
            teoVar = (double)numVar.Value; // считываем дисперсию
            size = (int)numNumber.Value; // считываем число эксперементов
            normDis = new double[size];
            for (int i = 0; i < size; i += 2) // через один
            {
                h1 = rnd.NextDouble(); //случайное число 1
                h2 = rnd.NextDouble(); // случайное число 2 
                normDis[i] = Math.Sqrt((-2) * Math.Log(h1)) * Math.Sin(2 * Math.PI * h2) * Math.Sqrt(teoVar) + teoMean;
                normDis[i + 1] = Math.Sqrt((-2) * Math.Log(h1)) * Math.Cos(2 * Math.PI * h2) * Math.Sqrt(teoVar) + teoMean;
                // вычисляем большее и меньшее значение
                if (normDis[i] > max)
                    max = normDis[i];
                if (normDis[i + 1] > max)
                    max = normDis[i + 1];
                if (normDis[i] < min)
                    min = normDis[i];
                if (normDis[i + 1] < min)
                    min = normDis[i + 1];
                // накапливаем мат ожидание и дисперсию
                statMean += normDis[i] + normDis[i + 1];
                statVar += normDis[i] * normDis[i] + normDis[i + 1] * normDis[i + 1];
            }
            statMean = statMean / size; // вычисляем среднее мат ожидание
            statVar = statVar / size - statMean * statMean; // вычисляем среднюю дисперсию 
            ErMean = Math.Abs(statMean - teoMean) / Math.Abs(teoMean) * 100; //считаем погрешность мат ожидания
            ErVar = Math.Abs(statVar - teoVar) / Math.Abs(teoVar) * 100; // считаем погрешность дисперсии

            stolb = (int)Math.Log(size, 2) + 1; // находим число промежутков логарифм по основанию 2 из числа испытаний +1
            stolbLength = (max - min) / stolb; // находм размер промежутков 
            stolbCount = new int[stolb];  // массив для значений гистограммы
            // проходимся по всем элементам и смотрим, в какой промежуток они попадают
            for (int i = 0; i < size; i++)
            {
                curLength = min + stolbLength;
                int j = 0;
                while (j < stolb)
                {//если попал
                    if (normDis[i] < curLength)
                    {
                        stolbCount[j]++;
                        break;
                    }
                    else//если больше
                    {
                        curLength += stolbLength;
                        j++;
                    }
                }
                normDis[i] = 0;
            }

            spanLen = new double[stolb + 1];
            stolbFreq = new double[stolb];
         
            
            double min1 = min;
            
            for (int i = 0; i < stolb; i++)
            {
                stolbFreq[i] = (double)stolbCount[i] / size; // вычисляем соотношение количества попавших в промежуток к общему количеству эксперементов
                x = (min1 + min1 + stolbLength) / 2;
                px = (1 / (Math.Sqrt(2 * Math.PI) * Math.Sqrt(teoVar))) * Math.Exp(-((x - teoMean) * (x - teoMean)) / (2 * teoVar));
                pi = ((min1 + stolbLength) - min1) * px;
                Hi += (stolbCount[i] * stolbCount[i]) / (double)(size * pi);
                spanLen[i] = min1;
                chart1.Series[0].Points.AddXY(min1, stolbFreq[i]);
                min1 += stolbLength;
              
            }
            chart1.Series[0].Points.AddXY(min1, stolbFreq[stolb-1]);
            Hi -= size;
            // выводим данные на экран
            lbStatMean.Text = Math.Round(statMean, 2).ToString();
            lbErMean.Text = Math.Round(ErMean, 2) + "%";
            lbErVar.Text = Math.Round(statVar, 2).ToString();
            lbErVar.Text= Math.Round(ErVar, 2) + "%";

            lbHi.Text = Math.Round(Hi, 3).ToString();

            if (Hi > HiValue[stolb - 2])
            {
                lbZnac.Text = ">";
                lbTF.Text = "true";
                lbHiVal.Text = HiValue[stolb - 1].ToString();
                lbTF.ForeColor = Color.Red;
            }
            else
            {
                lbZnac.Text = "<";
                lbTF.Text = "false";
                lbHiVal.Text = HiValue[stolb - 1].ToString();
                lbTF.ForeColor = Color.Green;
            }
            
        }
    }
}
