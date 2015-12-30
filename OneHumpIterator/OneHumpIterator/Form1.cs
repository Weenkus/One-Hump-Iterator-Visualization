using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneHumpIterator
{
    public partial class Form1 : Form
    {
        string[] iterators = { "r * x * (1 - x)", "r * x * sqrt(1 - x)", "r * (x - x^3)", "r * x * exp(-x)" };

        // Content item for the combo box
        private class OneHumpIterator
        {
            public string name;
            public int id;
            public OneHumpIterator(string name, int id)
            {
                this.name = name; this.id = id;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return this.name;
            }

        }

        public Form1()
        {
            InitializeComponent();
            initialiseTheComboBox();
            initialiseTheGraph();
            initialiseTheSlider();
        }

        private void cbIterator_SelectedIndexChanged(object sender, EventArgs e)
        {
            draw();
        }

        private void sliderR_ValueChanged(object sender, EventArgs e)
        {
            if(cbIterator.SelectedItem != null)
            {
                dynamicThickness();
                draw();
            }
        }

        private void draw()
        {
            // Clear all previous compositions
            graph.Series[1].Points.Clear();
            graph.Series[2].Points.Clear();
            graph.Series[3].Points.Clear();
            graph.Series[4].Points.Clear();

            // Set the axis to proper values
            graph.ChartAreas[0].AxisX.Minimum = 0;
            graph.ChartAreas[0].AxisX.Maximum = 1;

            graph.ChartAreas[0].AxisY.Minimum = 0;
            graph.ChartAreas[0].AxisY.Maximum = 1;

            graph.Series[0].Points.AddXY(0, 0);
            graph.Series[0].Points.AddXY(1, 1);

            double r = (double)sliderR.Value / 100;
            double f1, f2, f4, f8;
            double smoothness = 0.003;
            if (cbIterator.SelectedItem.ToString().Equals(iterators[0]))
            {
                for (double x = 0; x <= 1; x += smoothness)
                {
                    // f(x)
                    f1 = (r * x * (1 - x));
                    graph.Series[1].Points.AddXY(x, f1);


                    // f^2(x)
                    f2 = (r * f1 * (1 - f1));
                    graph.Series[2].Points.AddXY(x, f2);

                    // f^4(x)
                    f4 = (r * f2 * (1 - f2));
                    graph.Series[3].Points.AddXY(x, f4);


                    // f^8(x)
                    f8 = (r * f4 * (1 - f4));
                    graph.Series[4].Points.AddXY(x, f8);
                }
            }
            else if (cbIterator.SelectedItem.ToString().Equals(iterators[1]))
            {
                for (double x = 0; x <= 1; x += smoothness)
                {
                    // f(x)
                    f1 = (r * x * Math.Sqrt(1 - x));
                    graph.Series[1].Points.AddXY(x, f1);

                    // f^2(x)
                    f2 = (r * f1 * Math.Sqrt(1 - f1));
                    graph.Series[2].Points.AddXY(x, f2);

                    // f^4(x)
                    f4 = (r * f2 * Math.Sqrt(1 - f2));
                    graph.Series[3].Points.AddXY(x, f4);

                    // f^8(x)
                    f8 = (r * f4 * Math.Sqrt(1 - f4));
                    graph.Series[4].Points.AddXY(x, f8);
                }
            }
            else if (cbIterator.SelectedItem.ToString().Equals(iterators[2])) {
                for (double x = 0; x <= 1; x += smoothness)
                {
                    // f(x)
                    f1 = r * (x - x * x * x);
                    graph.Series[1].Points.AddXY(x, f1);

                    // f^2(x)
                    f2 = r * (f1 - f1 * f1 * f1);
                    graph.Series[2].Points.AddXY(x, f2);

                    // f^4(x)
                    f4 = r * (f2 - f2 * f2 * f2);
                    graph.Series[3].Points.AddXY(x, f4);

                    // f^8(x)
                    f8 = r * (f4 - f4 * f4 * f4);
                    graph.Series[4].Points.AddXY(x, f8);
                }
            }
            else if (cbIterator.SelectedItem.ToString().Equals(iterators[3]))
            {
                // Set the axis to proper values
                graph.ChartAreas[0].AxisX.Minimum = 0;
                graph.ChartAreas[0].AxisX.Maximum = 2;

                graph.ChartAreas[0].AxisY.Minimum = 0;
                graph.ChartAreas[0].AxisY.Maximum = 2;

                graph.Series[0].Points.AddXY(0, 0);
                graph.Series[0].Points.AddXY(2, 2);
                for (double x = 0; x <= 2; x += smoothness)
                {
                    // f(x)
                    f1 = r * x * Math.Exp(- Math.Pow(x, 2));
                    graph.Series[1].Points.AddXY(x, f1);

                    // f^2(x)
                    f2 = r * f1 * Math.Exp(-Math.Pow(f1, 2));
                    graph.Series[2].Points.AddXY(x, f2);

                    // f^4(x)
                    f4 = r * f2 * Math.Exp(-Math.Pow(f2, 2));
                    graph.Series[3].Points.AddXY(x, f4);

                    // f^8(x)
                    f8 = r * f4 * Math.Exp(-Math.Pow(f4, 2));
                    graph.Series[4].Points.AddXY(x, f8);
                }
            }


        }



        private void initialiseTheGraph() {
            // Initialise the graph
            graph.Series.Clear();
            graph.Series.Add("f(x) = x");
            graph.Series.Add("f(x)");
            graph.Series.Add("f^2(x)");
            graph.Series.Add("f^4(x)");
            graph.Series.Add("f^8(x)");

            graph.Series["f(x) = x"].BorderWidth = 2;
            graph.Series["f(x)"].BorderWidth = 3;
            graph.Series["f^2(x)"].BorderWidth = 3;
            graph.Series["f^4(x)"].BorderWidth = 3;
            graph.Series["f^8(x)"].BorderWidth = 3;

            // Set the axis to proper values
            graph.ChartAreas[0].AxisX.Minimum = 0;
            graph.ChartAreas[0].AxisX.Maximum = 1;

            graph.ChartAreas[0].AxisY.Minimum = 0;
            graph.ChartAreas[0].AxisY.Maximum = 1;


            // Add the linear line
            graph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            graph.Series[0].Points.AddXY(0, 0);
            graph.Series[0].Points.AddXY(1, 1);

            // Set function typesg
            graph.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            graph.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            graph.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            graph.Series[4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void initialiseTheComboBox() {
            // Fill the comobo box with one hump iterator equations
            cbIterator.Items.Add(new OneHumpIterator(iterators[0], 0));
            cbIterator.Items.Add(new OneHumpIterator(iterators[1], 1));
            cbIterator.Items.Add(new OneHumpIterator(iterators[2], 2));
            cbIterator.Items.Add(new OneHumpIterator(iterators[3], 3));
        }

        private void initialiseTheSlider() {
            sliderR.SetRange(0, 1000);
        }

        private void defultLineThicness() {
            graph.Series["f(x) = x"].BorderWidth = 2;
            graph.Series["f(x)"].BorderWidth = 2;
            graph.Series["f^2(x)"].BorderWidth = 2;
            graph.Series["f^4(x)"].BorderWidth = 2;
            graph.Series["f^8(x)"].BorderWidth = 2;
        }

        private void dynamicThickness() {
            // Adjust thickness for the leading hump
            defaultThickness();
            double r = (double)sliderR.Value / 100;
            int leadingHumpThickness = 7;
          
            if (cbIterator.SelectedItem.ToString().Equals(iterators[0]))
            {
                if (r < 3)
                {
                    defultLineThicness();
                    graph.Series[1].BorderWidth = leadingHumpThickness;
                }
                else if (r > 3 && r < 3.48)
                {
                    defultLineThicness();
                    graph.Series[2].BorderWidth = leadingHumpThickness;
                }
                else if (r > 3.48 && r < 3.54)
                {
                    defultLineThicness();
                    graph.Series[3].BorderWidth = leadingHumpThickness;
                }
                else if (r > 3.54) {
                    defultLineThicness();
                    graph.Series[4].BorderWidth = leadingHumpThickness;
                }

                  
            }
            else if (cbIterator.SelectedItem.ToString().Equals(iterators[1]))
            {
                if (r < 1)
                {
                    defultLineThicness();
                    graph.Series[1].BorderWidth = leadingHumpThickness;
                }
                else if (r > 1 && r < Math.Sqrt(5))
                {
                    defultLineThicness();
                    graph.Series[2].BorderWidth = leadingHumpThickness;
                }
            }
            else if (cbIterator.SelectedItem.ToString().Equals(iterators[2]))
            {
                if (r < 1)
                {
                    defultLineThicness();
                    graph.Series[1].BorderWidth = leadingHumpThickness;
                }
                else if (r > 1 && r < 2)
                {
                    defultLineThicness();
                    graph.Series[2].BorderWidth = leadingHumpThickness;
                }
            }
            else if (cbIterator.SelectedItem.ToString().Equals(iterators[3]))
            {
                if (r < 1)
                {
                    defultLineThicness();
                    graph.Series[1].BorderWidth = leadingHumpThickness;
                }
                else if (r > 1 && r < Math.Exp(1))
                {
                    defultLineThicness();
                    graph.Series[2].BorderWidth = leadingHumpThickness;
                }
            }
        }

        private void defaultThickness()
        {
            graph.Series["f(x) = x"].BorderWidth = 2;
            graph.Series["f(x)"].BorderWidth = 3;
            graph.Series["f^2(x)"].BorderWidth = 3;
            graph.Series["f^4(x)"].BorderWidth = 3;
            graph.Series["f^8(x)"].BorderWidth = 3;
        }


        

    }
}
