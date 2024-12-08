using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL; 

namespace SamRabVovchokV3
{
    public partial class Task5Graphics : Form
    {
        private OpenGL gl;
        private double x, y;
        private double z = 1;

        public Task5Graphics(double ValX, double ValY)
        {
            InitializeComponent();
            x = ValX;
            y = ValY;
            XVal.Text = "" + x;
            YVal.Text = "" + y;
            openGLControl1.OpenGLInitialized += openGLControl1_OpenGLInitialized;
            openGLControl1.OpenGLDraw += openGLControl1_OpenGLDraw;
            DrawDot();
        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            gl = ((OpenGLControl)sender).OpenGL;

            // Настройка OpenGL
            gl.ClearColor(255, 255, 255, 1.0f); // Белый фон
            gl.Enable(OpenGL.GL_DEPTH_TEST); // Включаем тест глубины
        }

        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -5.0f);
            // Отрисовка точки
            //
            gl.Color(1.0f, 0.0f, 0.0f); //Красный для самой точки
            gl.PointSize(5.0f);
            gl.Begin(OpenGL.GL_POINTS); //Метод отрисовки - Точки
            gl.Vertex(x, y, z); //Позиция
            gl.End();

            gl.Flush(); //Сама команда отрисовки, сделана принудительной

            //Теоретически это должно было создать красную точку на экран, но она является плоской в Трёхмерном пространстве.
            //В связи с этим, и полным отсутствием графика, задание можно считать не выполнененным.
        }


        public void DrawDot()
        {
            //
            //Определяем - попало или нет.
            //
            if (((x <= 1 && y >= -2) || (x <= -5 && y <= 5)) || ((x >= 1 && y <= -2) || (x >= 2 && y <= -5)))
            {
                Real.ForeColor = Color.Lime;
                Real.Text = "ДА";
            }
            else
            {
                Real.ForeColor = Color.Red;
                Real.Text = "НЕТ";
            }
        }
    }
}
