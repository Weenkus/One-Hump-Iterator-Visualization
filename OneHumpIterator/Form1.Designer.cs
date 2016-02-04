namespace OneHumpIterator
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbIterator = new System.Windows.Forms.ComboBox();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sliderR = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.f24 = new System.Windows.Forms.Label();
            this.f23 = new System.Windows.Forms.Label();
            this.f48 = new System.Windows.Forms.Label();
            this.f47 = new System.Windows.Forms.Label();
            this.f46 = new System.Windows.Forms.Label();
            this.f45 = new System.Windows.Forms.Label();
            this.f44 = new System.Windows.Forms.Label();
            this.f43 = new System.Windows.Forms.Label();
            this.f42 = new System.Windows.Forms.Label();
            this.f41 = new System.Windows.Forms.Label();
            this.f22 = new System.Windows.Forms.Label();
            this.f21 = new System.Windows.Forms.Label();
            this.f11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderR)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbIterator
            // 
            this.cbIterator.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbIterator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.cbIterator.FormattingEnabled = true;
            this.cbIterator.Location = new System.Drawing.Point(0, 0);
            this.cbIterator.Name = "cbIterator";
            this.cbIterator.Size = new System.Drawing.Size(771, 34);
            this.cbIterator.TabIndex = 0;
            this.cbIterator.SelectedIndexChanged += new System.EventHandler(this.cbIterator_SelectedIndexChanged);
            // 
            // graph
            // 
            chartArea2.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea2);
            this.graph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.graph.Legends.Add(legend2);
            this.graph.Location = new System.Drawing.Point(0, 0);
            this.graph.Name = "graph";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graph.Series.Add(series2);
            this.graph.Size = new System.Drawing.Size(637, 501);
            this.graph.TabIndex = 2;
            this.graph.Text = "graph";
            // 
            // sliderR
            // 
            this.sliderR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sliderR.Location = new System.Drawing.Point(0, 535);
            this.sliderR.Maximum = 5;
            this.sliderR.Name = "sliderR";
            this.sliderR.Size = new System.Drawing.Size(771, 45);
            this.sliderR.TabIndex = 3;
            this.sliderR.ValueChanged += new System.EventHandler(this.sliderR_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb8);
            this.panel1.Controls.Add(this.cb4);
            this.panel1.Controls.Add(this.cb2);
            this.panel1.Controls.Add(this.cb1);
            this.panel1.Controls.Add(this.f24);
            this.panel1.Controls.Add(this.f23);
            this.panel1.Controls.Add(this.f48);
            this.panel1.Controls.Add(this.f47);
            this.panel1.Controls.Add(this.f46);
            this.panel1.Controls.Add(this.f45);
            this.panel1.Controls.Add(this.f44);
            this.panel1.Controls.Add(this.f43);
            this.panel1.Controls.Add(this.f42);
            this.panel1.Controls.Add(this.f41);
            this.panel1.Controls.Add(this.f22);
            this.panel1.Controls.Add(this.f21);
            this.panel1.Controls.Add(this.f11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.r);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(637, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 501);
            this.panel1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(-16, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 2);
            this.label8.TabIndex = 30;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(-16, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 2);
            this.label7.TabIndex = 29;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(-16, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 2);
            this.label6.TabIndex = 28;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(-16, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 2);
            this.label5.TabIndex = 27;
            this.label5.Text = "label5";
            // 
            // cb8
            // 
            this.cb8.AutoSize = true;
            this.cb8.Checked = true;
            this.cb8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb8.Location = new System.Drawing.Point(72, 420);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(49, 24);
            this.cb8.TabIndex = 26;
            this.cb8.Text = "f^8";
            this.cb8.UseVisualStyleBackColor = true;
            this.cb8.CheckedChanged += new System.EventHandler(this.cb8_CheckedChanged);
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Checked = true;
            this.cb4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb4.Location = new System.Drawing.Point(6, 420);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(49, 24);
            this.cb4.TabIndex = 25;
            this.cb4.Text = "f^4";
            this.cb4.UseVisualStyleBackColor = true;
            this.cb4.CheckedChanged += new System.EventHandler(this.cb4_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Checked = true;
            this.cb2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb2.Location = new System.Drawing.Point(72, 393);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(49, 24);
            this.cb2.TabIndex = 24;
            this.cb2.Text = "f^2";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Checked = true;
            this.cb1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb1.Location = new System.Drawing.Point(6, 393);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(33, 24);
            this.cb1.TabIndex = 23;
            this.cb1.Text = "f";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.Click += new System.EventHandler(this.cb1_Click);
            // 
            // f24
            // 
            this.f24.AutoSize = true;
            this.f24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f24.Location = new System.Drawing.Point(80, 160);
            this.f24.Name = "f24";
            this.f24.Size = new System.Drawing.Size(37, 20);
            this.f24.TabIndex = 18;
            this.f24.Text = "FT4";
            // 
            // f23
            // 
            this.f23.AutoSize = true;
            this.f23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f23.Location = new System.Drawing.Point(7, 160);
            this.f23.Name = "f23";
            this.f23.Size = new System.Drawing.Size(37, 20);
            this.f23.TabIndex = 17;
            this.f23.Text = "FT3";
            // 
            // f48
            // 
            this.f48.AutoSize = true;
            this.f48.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f48.Location = new System.Drawing.Point(80, 351);
            this.f48.Name = "f48";
            this.f48.Size = new System.Drawing.Size(37, 20);
            this.f48.TabIndex = 16;
            this.f48.Text = "FT8";
            // 
            // f47
            // 
            this.f47.AutoSize = true;
            this.f47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f47.Location = new System.Drawing.Point(6, 351);
            this.f47.Name = "f47";
            this.f47.Size = new System.Drawing.Size(37, 20);
            this.f47.TabIndex = 15;
            this.f47.Text = "FT7";
            // 
            // f46
            // 
            this.f46.AutoSize = true;
            this.f46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f46.Location = new System.Drawing.Point(80, 310);
            this.f46.Name = "f46";
            this.f46.Size = new System.Drawing.Size(37, 20);
            this.f46.TabIndex = 14;
            this.f46.Text = "FT6";
            // 
            // f45
            // 
            this.f45.AutoSize = true;
            this.f45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f45.Location = new System.Drawing.Point(7, 310);
            this.f45.Name = "f45";
            this.f45.Size = new System.Drawing.Size(37, 20);
            this.f45.TabIndex = 13;
            this.f45.Text = "FT5";
            // 
            // f44
            // 
            this.f44.AutoSize = true;
            this.f44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f44.Location = new System.Drawing.Point(80, 273);
            this.f44.Name = "f44";
            this.f44.Size = new System.Drawing.Size(37, 20);
            this.f44.TabIndex = 12;
            this.f44.Text = "FT4";
            // 
            // f43
            // 
            this.f43.AutoSize = true;
            this.f43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f43.Location = new System.Drawing.Point(7, 273);
            this.f43.Name = "f43";
            this.f43.Size = new System.Drawing.Size(37, 20);
            this.f43.TabIndex = 11;
            this.f43.Text = "FT3";
            // 
            // f42
            // 
            this.f42.AutoSize = true;
            this.f42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f42.Location = new System.Drawing.Point(80, 234);
            this.f42.Name = "f42";
            this.f42.Size = new System.Drawing.Size(37, 20);
            this.f42.TabIndex = 10;
            this.f42.Text = "FT2";
            // 
            // f41
            // 
            this.f41.AutoSize = true;
            this.f41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f41.Location = new System.Drawing.Point(7, 234);
            this.f41.Name = "f41";
            this.f41.Size = new System.Drawing.Size(37, 20);
            this.f41.TabIndex = 9;
            this.f41.Text = "FT1";
            // 
            // f22
            // 
            this.f22.AutoSize = true;
            this.f22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f22.Location = new System.Drawing.Point(80, 124);
            this.f22.Name = "f22";
            this.f22.Size = new System.Drawing.Size(37, 20);
            this.f22.TabIndex = 8;
            this.f22.Text = "FT2";
            // 
            // f21
            // 
            this.f21.AutoSize = true;
            this.f21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f21.Location = new System.Drawing.Point(7, 124);
            this.f21.Name = "f21";
            this.f21.Size = new System.Drawing.Size(37, 20);
            this.f21.TabIndex = 7;
            this.f21.Text = "FT1";
            // 
            // f11
            // 
            this.f11.AutoSize = true;
            this.f11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f11.Location = new System.Drawing.Point(56, 53);
            this.f11.Name = "f11";
            this.f11.Size = new System.Drawing.Size(37, 20);
            this.f11.TabIndex = 6;
            this.f11.Text = "FT1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(32, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "f^4(x)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(32, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "f^2(x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "f(x):";
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.r.Location = new System.Drawing.Point(56, 15);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(0, 20);
            this.r.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "r:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.graph);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 501);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sliderR);
            this.Controls.Add(this.cbIterator);
            this.Name = "Form1";
            this.Text = "One Hump Iterators - KAOS2016 By Vinko Kodžoman";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIterator;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.TrackBar sliderR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label f11;
        private System.Windows.Forms.Label f22;
        private System.Windows.Forms.Label f21;
        private System.Windows.Forms.Label f42;
        private System.Windows.Forms.Label f41;
        private System.Windows.Forms.Label f44;
        private System.Windows.Forms.Label f43;
        private System.Windows.Forms.Label f48;
        private System.Windows.Forms.Label f47;
        private System.Windows.Forms.Label f46;
        private System.Windows.Forms.Label f45;
        private System.Windows.Forms.Label f24;
        private System.Windows.Forms.Label f23;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb8;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

