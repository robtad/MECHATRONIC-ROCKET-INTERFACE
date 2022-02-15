namespace WinFormsApp1.ChildForms
{
    partial class DashboardForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDot = new System.Windows.Forms.Label();
            this.lblColon2 = new System.Windows.Forms.Label();
            this.lblColon1 = new System.Windows.Forms.Label();
            this.lblMilliSecond = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(25, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dashboard";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(154)))), ((int)(((byte)(138)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(292, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Search for something...";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(179, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "DASHBOARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTimer
            // 
            this.pnlTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTimer.Controls.Add(this.btnReset);
            this.pnlTimer.Controls.Add(this.btnStop);
            this.pnlTimer.Controls.Add(this.btnStart);
            this.pnlTimer.Controls.Add(this.lblDot);
            this.pnlTimer.Controls.Add(this.lblColon2);
            this.pnlTimer.Controls.Add(this.lblColon1);
            this.pnlTimer.Controls.Add(this.lblMilliSecond);
            this.pnlTimer.Controls.Add(this.lblSecond);
            this.pnlTimer.Controls.Add(this.lblMinute);
            this.pnlTimer.Controls.Add(this.lblHour);
            this.pnlTimer.Location = new System.Drawing.Point(151, 163);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(269, 115);
            this.pnlTimer.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.Yellow;
            this.btnReset.Location = new System.Drawing.Point(170, 56);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(54, 29);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStop.ForeColor = System.Drawing.Color.Yellow;
            this.btnStop.Location = new System.Drawing.Point(88, 56);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(49, 29);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.Yellow;
            this.btnStart.Location = new System.Drawing.Point(23, 56);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(49, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDot
            // 
            this.lblDot.AutoSize = true;
            this.lblDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDot.ForeColor = System.Drawing.Color.Yellow;
            this.lblDot.Location = new System.Drawing.Point(170, 17);
            this.lblDot.Name = "lblDot";
            this.lblDot.Size = new System.Drawing.Size(19, 25);
            this.lblDot.TabIndex = 0;
            this.lblDot.Text = ".";
            // 
            // lblColon2
            // 
            this.lblColon2.AutoSize = true;
            this.lblColon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColon2.ForeColor = System.Drawing.Color.Yellow;
            this.lblColon2.Location = new System.Drawing.Point(118, 17);
            this.lblColon2.Name = "lblColon2";
            this.lblColon2.Size = new System.Drawing.Size(19, 25);
            this.lblColon2.TabIndex = 0;
            this.lblColon2.Text = ":";
            // 
            // lblColon1
            // 
            this.lblColon1.AutoSize = true;
            this.lblColon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColon1.ForeColor = System.Drawing.Color.Yellow;
            this.lblColon1.Location = new System.Drawing.Point(64, 17);
            this.lblColon1.Name = "lblColon1";
            this.lblColon1.Size = new System.Drawing.Size(19, 25);
            this.lblColon1.TabIndex = 0;
            this.lblColon1.Text = ":";
            // 
            // lblMilliSecond
            // 
            this.lblMilliSecond.AutoSize = true;
            this.lblMilliSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMilliSecond.ForeColor = System.Drawing.Color.Yellow;
            this.lblMilliSecond.Location = new System.Drawing.Point(195, 21);
            this.lblMilliSecond.Name = "lblMilliSecond";
            this.lblMilliSecond.Size = new System.Drawing.Size(29, 20);
            this.lblMilliSecond.TabIndex = 0;
            this.lblMilliSecond.Text = "00";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecond.ForeColor = System.Drawing.Color.Yellow;
            this.lblSecond.Location = new System.Drawing.Point(130, 11);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(46, 31);
            this.lblSecond.TabIndex = 0;
            this.lblSecond.Text = "00";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinute.ForeColor = System.Drawing.Color.Yellow;
            this.lblMinute.Location = new System.Drawing.Point(78, 11);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(46, 31);
            this.lblMinute.TabIndex = 0;
            this.lblMinute.Text = "00";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHour.ForeColor = System.Drawing.Color.Yellow;
            this.lblHour.Location = new System.Drawing.Point(23, 11);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(46, 31);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.pnlTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Panel pnlTimer;
        private Button btnReset;
        private Button btnStop;
        private Button btnStart;
        private Label lblDot;
        private Label lblColon2;
        private Label lblColon1;
        private Label lblMilliSecond;
        private Label lblSecond;
        private Label lblMinute;
        private Label lblHour;
        private System.Windows.Forms.Timer timer1;
    }
}