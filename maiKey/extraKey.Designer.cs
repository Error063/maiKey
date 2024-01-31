using System.ComponentModel;

namespace maiKey
{
    partial class extraKey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.testBtn_F1 = new System.Windows.Forms.Button();
            this.serviceBtn_F2 = new System.Windows.Forms.Button();
            this.virtualReaderBtn = new System.Windows.Forms.Button();
            this.serviceBtn_2 = new System.Windows.Forms.Button();
            this.testKey_1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // testBtn_F1
            //
            this.testBtn_F1.Location = new System.Drawing.Point(17, 21);
            this.testBtn_F1.Name = "testBtn_F1";
            this.testBtn_F1.Size = new System.Drawing.Size(278, 61);
            this.testBtn_F1.TabIndex = 0;
            this.testBtn_F1.Text = "测试键（F1）";
            this.testBtn_F1.UseVisualStyleBackColor = true;
            this.testBtn_F1.Click += new System.EventHandler(this.testBtn_F1_Click);
            //
            // serviceBtn_F2
            //
            this.serviceBtn_F2.Location = new System.Drawing.Point(17, 88);
            this.serviceBtn_F2.Name = "serviceBtn_F2";
            this.serviceBtn_F2.Size = new System.Drawing.Size(278, 61);
            this.serviceBtn_F2.TabIndex = 1;
            this.serviceBtn_F2.Text = "服务键（F2）";
            this.serviceBtn_F2.UseVisualStyleBackColor = true;
            this.serviceBtn_F2.Click += new System.EventHandler(this.serviceBtn_F2_Click);
            //
            // virtualReaderBtn
            //
            this.virtualReaderBtn.Location = new System.Drawing.Point(17, 421);
            this.virtualReaderBtn.Name = "virtualReaderBtn";
            this.virtualReaderBtn.Size = new System.Drawing.Size(278, 61);
            this.virtualReaderBtn.TabIndex = 2;
            this.virtualReaderBtn.Text = "刷卡（长按回车）";
            this.virtualReaderBtn.UseVisualStyleBackColor = true;
            this.virtualReaderBtn.Click += new System.EventHandler(this.virtualReaderBtn_Click);
            //
            // serviceBtn_2
            //
            this.serviceBtn_2.Location = new System.Drawing.Point(17, 231);
            this.serviceBtn_2.Name = "serviceBtn_2";
            this.serviceBtn_2.Size = new System.Drawing.Size(278, 61);
            this.serviceBtn_2.TabIndex = 4;
            this.serviceBtn_2.Text = "服务键（2）";
            this.serviceBtn_2.UseVisualStyleBackColor = true;
            this.serviceBtn_2.Click += new System.EventHandler(this.serviceBtn_2_Click);
            //
            // testKey_1
            //
            this.testKey_1.Location = new System.Drawing.Point(17, 164);
            this.testKey_1.Name = "testKey_1";
            this.testKey_1.Size = new System.Drawing.Size(278, 61);
            this.testKey_1.TabIndex = 3;
            this.testKey_1.Text = "测试键（1）";
            this.testKey_1.UseVisualStyleBackColor = true;
            this.testKey_1.Click += new System.EventHandler(this.testKey_1_Click);
            //
            // button1
            //
            this.button1.Location = new System.Drawing.Point(16, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "服务键（2）";
            this.button1.UseVisualStyleBackColor = true;
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(24, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 61);
            this.button2.TabIndex = 6;
            this.button2.Text = "服务键（2）";
            this.button2.UseVisualStyleBackColor = true;
            //
            // extraKey
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(311, 607);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.serviceBtn_2);
            this.Controls.Add(this.testKey_1);
            this.Controls.Add(this.virtualReaderBtn);
            this.Controls.Add(this.serviceBtn_F2);
            this.Controls.Add(this.testBtn_F1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "extraKey";
            this.Text = "extraKey";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button serviceBtn_2;
        private System.Windows.Forms.Button testKey_1;

        private System.Windows.Forms.Button virtualReaderBtn;

        private System.Windows.Forms.Button serviceBtn_F2;

        private System.Windows.Forms.Button testBtn_F1;

        #endregion
    }
}