using System.Windows.Forms;

namespace maiKey
{
    partial class Key : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Key));
            this.closeBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.keySetTipsLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiusBar = new System.Windows.Forms.TrackBar();
            this.radiusNum = new System.Windows.Forms.NumericUpDown();
            this.autoReplaceBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.angleBar = new System.Windows.Forms.TrackBar();
            this.angleNum = new System.Windows.Forms.NumericUpDown();
            this.lockLocation = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.showExtraKey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNum)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(158, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(137, 64);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "关闭所有虚拟键";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(24, 12);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(121, 64);
            this.showBtn.TabIndex = 1;
            this.showBtn.Text = "显示选择键";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // keySetTipsLab
            // 
            this.keySetTipsLab.AutoSize = true;
            this.keySetTipsLab.Location = new System.Drawing.Point(21, 94);
            this.keySetTipsLab.Name = "keySetTipsLab";
            this.keySetTipsLab.Size = new System.Drawing.Size(431, 54);
            this.keySetTipsLab.TabIndex = 2;
            this.keySetTipsLab.Text = "当前键位布局：\r\n操作键：#controlKeyPairs#（从上到下，从左到右）\r\n选择键： #selectKey#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "由于使用该工具进行输入可能会有较大的操作延迟\r\n故不建议在游戏过程中使用该工具";
            // 
            // radiusBar
            // 
            this.radiusBar.Location = new System.Drawing.Point(27, 60);
            this.radiusBar.Maximum = 1000;
            this.radiusBar.Minimum = 300;
            this.radiusBar.Name = "radiusBar";
            this.radiusBar.Size = new System.Drawing.Size(238, 69);
            this.radiusBar.SmallChange = 20;
            this.radiusBar.TabIndex = 4;
            this.radiusBar.Value = 300;
            this.radiusBar.Scroll += new System.EventHandler(this.radiusBar_Scroll);
            // 
            // radiusNum
            // 
            this.radiusNum.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.radiusNum.Location = new System.Drawing.Point(289, 72);
            this.radiusNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.radiusNum.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.radiusNum.Name = "radiusNum";
            this.radiusNum.Size = new System.Drawing.Size(102, 28);
            this.radiusNum.TabIndex = 5;
            this.radiusNum.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.radiusNum.ValueChanged += new System.EventHandler(this.radiusNum_ValueChanged);
            // 
            // autoReplaceBtn
            // 
            this.autoReplaceBtn.Location = new System.Drawing.Point(30, 206);
            this.autoReplaceBtn.Name = "autoReplaceBtn";
            this.autoReplaceBtn.Size = new System.Drawing.Size(182, 78);
            this.autoReplaceBtn.TabIndex = 6;
            this.autoReplaceBtn.Text = "显示并自动排列其他按键位置";
            this.autoReplaceBtn.UseVisualStyleBackColor = true;
            this.autoReplaceBtn.Click += new System.EventHandler(this.autoReplaceBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.angleBar);
            this.groupBox1.Controls.Add(this.angleNum);
            this.groupBox1.Controls.Add(this.lockLocation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radiusBar);
            this.groupBox1.Controls.Add(this.autoReplaceBtn);
            this.groupBox1.Controls.Add(this.radiusNum);
            this.groupBox1.Location = new System.Drawing.Point(10, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 305);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按钮排列（基于选择键窗口的位置）";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "计算角度";
            // 
            // angleBar
            // 
            this.angleBar.LargeChange = 1;
            this.angleBar.Location = new System.Drawing.Point(29, 128);
            this.angleBar.Maximum = 350;
            this.angleBar.Minimum = 150;
            this.angleBar.Name = "angleBar";
            this.angleBar.Size = new System.Drawing.Size(238, 69);
            this.angleBar.SmallChange = 20;
            this.angleBar.TabIndex = 9;
            this.angleBar.Value = 200;
            this.angleBar.Scroll += new System.EventHandler(this.angleBar_Scroll);
            // 
            // angleNum
            // 
            this.angleNum.DecimalPlaces = 1;
            this.angleNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.angleNum.Location = new System.Drawing.Point(291, 140);
            this.angleNum.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.angleNum.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.angleNum.Name = "angleNum";
            this.angleNum.Size = new System.Drawing.Size(102, 28);
            this.angleNum.TabIndex = 10;
            this.angleNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.angleNum.ValueChanged += new System.EventHandler(this.angleNum_ValueChanged);
            // 
            // lockLocation
            // 
            this.lockLocation.AutoSize = true;
            this.lockLocation.Location = new System.Drawing.Point(237, 235);
            this.lockLocation.Name = "lockLocation";
            this.lockLocation.Size = new System.Drawing.Size(160, 22);
            this.lockLocation.TabIndex = 8;
            this.lockLocation.Text = "锁定虚拟键布局";
            this.lockLocation.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "半径";
            // 
            // showExtraKey
            // 
            this.showExtraKey.Location = new System.Drawing.Point(301, 12);
            this.showExtraKey.Name = "showExtraKey";
            this.showExtraKey.Size = new System.Drawing.Size(135, 64);
            this.showExtraKey.TabIndex = 8;
            this.showExtraKey.Text = "拓展虚拟键";
            this.showExtraKey.UseVisualStyleBackColor = true;
            this.showExtraKey.Click += new System.EventHandler(this.showExtraKey_Click);
            // 
            // Key
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(447, 559);
            this.Controls.Add(this.showExtraKey);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keySetTipsLab);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Key";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "maimai 虚拟键";
            ((System.ComponentModel.ISupportInitialize)(this.radiusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button showExtraKey;

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Label keySetTipsLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar radiusBar;
        private System.Windows.Forms.NumericUpDown radiusNum;
        private System.Windows.Forms.Button autoReplaceBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox lockLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar angleBar;
        private System.Windows.Forms.NumericUpDown angleNum;
    }
}