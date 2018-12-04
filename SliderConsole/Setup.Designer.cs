namespace SliderConsole
{
    partial class Setup
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Baud9600Radio = new System.Windows.Forms.RadioButton();
            this.Baud115Radio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Baud115Radio);
            this.groupBox1.Controls.Add(this.Baud9600Radio);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What port is the Slider Operating from?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // Baud9600Radio
            // 
            this.Baud9600Radio.AutoSize = true;
            this.Baud9600Radio.Location = new System.Drawing.Point(194, 49);
            this.Baud9600Radio.Name = "Baud9600Radio";
            this.Baud9600Radio.Size = new System.Drawing.Size(61, 21);
            this.Baud9600Radio.TabIndex = 2;
            this.Baud9600Radio.Text = "9600";
            this.Baud9600Radio.UseVisualStyleBackColor = true;
            // 
            // Baud115Radio
            // 
            this.Baud115Radio.AutoSize = true;
            this.Baud115Radio.Checked = true;
            this.Baud115Radio.Location = new System.Drawing.Point(91, 49);
            this.Baud115Radio.Name = "Baud115Radio";
            this.Baud115Radio.Size = new System.Drawing.Size(77, 21);
            this.Baud115Radio.TabIndex = 3;
            this.Baud115Radio.TabStop = true;
            this.Baud115Radio.Text = "115200";
            this.Baud115Radio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Baud Rate:";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(3, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 148);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setup";
            this.Text = "Setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton Baud115Radio;
        private System.Windows.Forms.RadioButton Baud9600Radio;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}