namespace 串口通信
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GetPortName = new System.Windows.Forms.Button();
            this.OpenPort = new System.Windows.Forms.Button();
            this.ClosePort = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.GetData = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SendData = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GetPortName
            // 
            this.GetPortName.Location = new System.Drawing.Point(289, 16);
            this.GetPortName.Name = "GetPortName";
            this.GetPortName.Size = new System.Drawing.Size(121, 40);
            this.GetPortName.TabIndex = 0;
            this.GetPortName.Text = "获取串口列表";
            this.GetPortName.UseVisualStyleBackColor = true;
            this.GetPortName.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenPort
            // 
            this.OpenPort.Location = new System.Drawing.Point(416, 16);
            this.OpenPort.Name = "OpenPort";
            this.OpenPort.Size = new System.Drawing.Size(108, 40);
            this.OpenPort.TabIndex = 1;
            this.OpenPort.Text = "打开串口";
            this.OpenPort.UseVisualStyleBackColor = true;
            this.OpenPort.Click += new System.EventHandler(this.OpenPort_Click);
            // 
            // ClosePort
            // 
            this.ClosePort.Location = new System.Drawing.Point(533, 16);
            this.ClosePort.Name = "ClosePort";
            this.ClosePort.Size = new System.Drawing.Size(102, 40);
            this.ClosePort.TabIndex = 2;
            this.ClosePort.Text = "关闭串口";
            this.ClosePort.UseVisualStyleBackColor = true;
            this.ClosePort.Click += new System.EventHandler(this.ClosePort_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 341);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 25);
            this.textBox1.TabIndex = 4;
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(437, 104);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(87, 25);
            this.GetData.TabIndex = 6;
            this.GetData.Text = "接收数据";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(547, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 25);
            this.textBox3.TabIndex = 7;
            // 
            // SendData
            // 
            this.SendData.Location = new System.Drawing.Point(437, 341);
            this.SendData.Name = "SendData";
            this.SendData.Size = new System.Drawing.Size(87, 25);
            this.SendData.TabIndex = 8;
            this.SendData.Text = "发送数据";
            this.SendData.UseVisualStyleBackColor = true;
            this.SendData.Click += new System.EventHandler(this.SendData_Click);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(25, 68);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox5.Size = new System.Drawing.Size(405, 250);
            this.textBox5.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 23);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "没有可用串口";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 411);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.SendData);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClosePort);
            this.Controls.Add(this.OpenPort);
            this.Controls.Add(this.GetPortName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetPortName;
        private System.Windows.Forms.Button OpenPort;
        private System.Windows.Forms.Button ClosePort;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button SendData;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

