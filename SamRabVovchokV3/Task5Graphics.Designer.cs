
namespace SamRabVovchokV3
{
    partial class Task5Graphics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.label3 = new System.Windows.Forms.Label();
            this.Real = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YVal = new System.Windows.Forms.Label();
            this.XVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.openGLControl1.DrawFPS = true;
            this.openGLControl1.FrameRate = 30;
            this.openGLControl1.Location = new System.Drawing.Point(35, 12);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL3_0;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(706, 452);
            this.openGLControl1.TabIndex = 0;
            this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl1_OpenGLInitialized);
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(353, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пересекается:";
            // 
            // Real
            // 
            this.Real.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Real.AutoSize = true;
            this.Real.BackColor = System.Drawing.Color.White;
            this.Real.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Real.ForeColor = System.Drawing.Color.Lime;
            this.Real.Location = new System.Drawing.Point(378, 554);
            this.Real.Name = "Real";
            this.Real.Size = new System.Drawing.Size(123, 21);
            this.Real.TabIndex = 9;
            this.Real.Text = "+Пересечение";
            this.Real.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Значение Y:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Значение X:";
            // 
            // YVal
            // 
            this.YVal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.YVal.AutoSize = true;
            this.YVal.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.YVal.Location = new System.Drawing.Point(154, 542);
            this.YVal.Name = "YVal";
            this.YVal.Size = new System.Drawing.Size(24, 19);
            this.YVal.TabIndex = 12;
            this.YVal.Text = "-1";
            // 
            // XVal
            // 
            this.XVal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.XVal.AutoSize = true;
            this.XVal.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.XVal.Location = new System.Drawing.Point(154, 503);
            this.XVal.Name = "XVal";
            this.XVal.Size = new System.Drawing.Size(24, 19);
            this.XVal.TabIndex = 11;
            this.XVal.Text = "-1";
            // 
            // Task5Graphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.YVal);
            this.Controls.Add(this.XVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Real);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openGLControl1);
            this.Name = "Task5Graphics";
            this.Text = "Задание 5";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Real;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label YVal;
        private System.Windows.Forms.Label XVal;
    }
}