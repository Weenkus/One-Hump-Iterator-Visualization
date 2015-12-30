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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbIterator = new System.Windows.Forms.ComboBox();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sliderR = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderR)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIterator
            // 
            this.cbIterator.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbIterator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.cbIterator.FormattingEnabled = true;
            this.cbIterator.Location = new System.Drawing.Point(0, 0);
            this.cbIterator.Name = "cbIterator";
            this.cbIterator.Size = new System.Drawing.Size(637, 34);
            this.cbIterator.TabIndex = 0;
            this.cbIterator.SelectedIndexChanged += new System.EventHandler(this.cbIterator_SelectedIndexChanged);
            // 
            // graph
            // 
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            this.graph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.graph.Legends.Add(legend1);
            this.graph.Location = new System.Drawing.Point(0, 34);
            this.graph.Name = "graph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graph.Series.Add(series1);
            this.graph.Size = new System.Drawing.Size(637, 492);
            this.graph.TabIndex = 2;
            this.graph.Text = "graph";
            // 
            // sliderR
            // 
            this.sliderR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sliderR.Location = new System.Drawing.Point(0, 481);
            this.sliderR.Name = "sliderR";
            this.sliderR.Size = new System.Drawing.Size(637, 45);
            this.sliderR.TabIndex = 3;
            this.sliderR.ValueChanged += new System.EventHandler(this.sliderR_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 526);
            this.Controls.Add(this.sliderR);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.cbIterator);
            this.Name = "Form1";
            this.Text = "OneHumpIterators";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIterator;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.TrackBar sliderR;
    }
}

