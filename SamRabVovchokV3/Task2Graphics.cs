using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamRabVovchokV3
{
    public partial class Task2Graphics : Form
    {
        //Задаём копии переменных Х и Y для 
        private double X;
        private double Y;
        public Task2Graphics(double ValX, double ValY)
        {
            //Получаем переменные из основной консольной программы.
            InitializeComponent();
            X = ValX;
            Y = ValY;
            XVal.Text = "" + X;
            YVal.Text = "" + Y;
            DrawDot();

        }
        public void DrawFigure(object sender, PaintEventArgs e)
        {
            //Всё отрисовываем.
            double XDot = X * 10;
            double YDot = Y * 10;
            Brush brush = new SolidBrush(Color.Black);
            Brush dotBrush = new SolidBrush(Color.Lime);
            Pen pen = new Pen(Brushes.Black);
            pictureBox1.Image = null;
            Graphics grphcs = e.Graphics;
            grphcs.DrawLine(pen, 150, 25, 150, 225);
            grphcs.DrawLine(pen, 150, 25, 145, 40);
            grphcs.DrawLine(pen, 150, 25, 155, 40);
            grphcs.DrawLine(pen, 50, 125, 250, 125);
            grphcs.DrawLine(pen, 250, 125, 235, 120);
            grphcs.DrawLine(pen, 250, 125, 235, 130);
            grphcs.DrawEllipse(pen, 75,50,150,150);
            grphcs.FillPie(brush, 60, 50, 220, 200, 210, 60);
            grphcs.FillPie(brush, 115, 95, 100, 100, 20, 63);
            grphcs.FillEllipse(dotBrush, (145+(float)XDot), (122+(float)-YDot), 10, 10);
        }
        public void DrawDot()
        {
            //
            //Определяем - попало или нет.
            //
            if (((X <= 1 && Y >= -2) || (X <= -5 && Y <= 5)) || ((X >= 1 && Y <= -2) || (X >= 2 && Y <= -5)))
            {
                Real.ForeColor = Color.Lime;
                Real.Text="ДА";
            }
            else
            {
                Real.ForeColor = Color.Red;
                Real.Text = "НЕТ";
            }
        }
    }
}
