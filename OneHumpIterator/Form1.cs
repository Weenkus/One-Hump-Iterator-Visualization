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
        string[] iterators = { "r * x * (1 - x)", "r * x * sqrt(1 - x)", "r * (x - x^3)", "r * x * exp(-x)", "r * (1 - |2*x - 1|)" };

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
            //initialiseCheckBox();
        }

        private void cbIterator_SelectedIndexChanged(object sender, EventArgs e)
        {
            draw();
        }

        private void sliderR_ValueChanged(object sender, EventArgs e)
        {
            r.Text = Convert.ToString((double)sliderR.Value / 100).Replace(",",".");
            if (cbIterator.SelectedItem != null)
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

            // Initialise variables
            double r = (double)sliderR.Value / 100;
            double f1, f2, f4, f8;
            double smoothness = 0.005;
            const double error = 0.006;

            List<Label> labelsf2 = new List<Label>() { f21, f22, f23, f24 };
            List<double> valuesf2 = new List<double>();

            List<Label> labelsf4 = new List<Label>() { f41, f42, f43, f44, f45, f46, f47, f48 };
            List<double> valuesf4 = new List<double>();
            if (cbIterator.SelectedItem.ToString().Equals(iterators[0]))
            {
                for (double x = 0; x <= 1; x += smoothness)
                {
                    double xPrev = x - smoothness;
                    // f(x)
                    f1 = (r * x * (1 - x));

                    if (cb1.Checked)                     
                        graph.Series[1].Points.AddXY(x, f1);

                    if (Math.Abs(f1 - x) <= error)
                        f11.Text = Convert.ToString(Math.Round(f1, 2)).Replace(",", ".");

                    // f^2(x)
                    f2 = (r * f1 * (1 - f1));
                    if (cb2.Checked)
                        graph.Series[2].Points.AddXY(x, f2);
                   
                    if (Math.Abs(f2 - x) <= error)
                        valuesf2.Add(f2);



                    // f^4(x)
                    f4 = (r * f2 * (1 - f2));
                    if (cb4.Checked)
                        graph.Series[3].Points.AddXY(x, f4);

                    if (Math.Abs(f4 - x) <= error)
                        valuesf4.Add(f4);


                    // f^8(x)
                    f8 = (r * f4 * (1 - f4));
                    if (cb8.Checked) 
                        graph.Series[4].Points.AddXY(x, f8);
                }
            }
            if (cbIterator.SelectedItem.ToString().Equals(iterators[1]))
            {
                for (double x = 0; x <= 1; x += smoothness)
                {
                    // f(x)
                    f1 = (r * x * Math.Sqrt(1 - x));
                    if (cb1.Checked)
                        graph.Series[1].Points.AddXY(x, f1);
                
                    if (Math.Abs(f1 - x) <= error)
                        f11.Text = Convert.ToString(Math.Round(f1, 2)).Replace(",", ".");

                    // f^2(x)
                    f2 = (r * f1 * Math.Sqrt(1 - f1));
                    if (cb2.Checked)
                        graph.Series[2].Points.AddXY(x, f2);

                    if (Math.Abs(f2 - x) <= error)
                        valuesf2.Add(f2);


                    // f^4(x)
                    f4 = (r * f2 * Math.Sqrt(1 - f2));
                    if (cb4.Checked)
                        graph.Series[3].Points.AddXY(x, f4);

                    if (Math.Abs(f4 - x) <= error)
                        valuesf4.Add(f4);

                    // f^8(x)
                    f8 = (r * f4 * Math.Sqrt(1 - f4));
                    if (cb8.Checked)
                        graph.Series[4].Points.AddXY(x, f8);

                }
            }
            if (cbIterator.SelectedItem.ToString().Equals(iterators[2])) {
                for (double x = 0; x <= 1; x += smoothness)
                {
                    // f(x)
                    f1 = r * (x - x * x * x);
                    if (cb1.Checked)
                        graph.Series[1].Points.AddXY(x, f1);
                    if (Math.Abs(f1 - x) <= error)
                        f11.Text = Convert.ToString(Math.Round(f1, 2)).Replace(",", ".");

                    // f^2(x)
                    f2 = r * (f1 - f1 * f1 * f1);
                    if (cb2.Checked)
                        graph.Series[2].Points.AddXY(x, f2);

                    if (Math.Abs(f2 - x) <= error)
                        valuesf2.Add(f2);

                    // f^4(x)
                    f4 = r * (f2 - f2 * f2 * f2);
                    if (cb4.Checked)
                        graph.Series[3].Points.AddXY(x, f4);

                    if (Math.Abs(f4 - x) <= error)
                        valuesf4.Add(f4);

                    // f^8(x)
                    f8 = r * (f4 - f4 * f4 * f4);
                    if (cb8.Checked)
                        graph.Series[4].Points.AddXY(x, f8);

                }
            }
            if (cbIterator.SelectedItem.ToString().Equals(iterators[3]))
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
                    if (cb1.Checked)
                        graph.Series[1].Points.AddXY(x, f1);
                    if (Math.Abs(f1 - x) <= error)
                        f11.Text = Convert.ToString(Math.Round(f1, 2)).Replace(",", ".");

                    // f^2(x)
                    f2 = r * f1 * Math.Exp(-Math.Pow(f1, 2));
                    if (cb2.Checked)
                        graph.Series[2].Points.AddXY(x, f2);

                    if (Math.Abs(f2 - x) <= error)
                        valuesf2.Add(f2);

                    // f^4(x)
                    f4 = r * f2 * Math.Exp(-Math.Pow(f2, 2));
                    if (cb4.Checked)
                        graph.Series[3].Points.AddXY(x, f4);

                    if (Math.Abs(f4 - x) <= error)
                        valuesf4.Add(f4);

                    // f^8(x)
                    f8 = r * f4 * Math.Exp(-Math.Pow(f4, 2));
                    if (cb8.Checked)
                        graph.Series[4].Points.AddXY(x, f8);
                }
            }
            if (cbIterator.SelectedItem.ToString().Equals(iterators[4]))
            {
                // Set the axis to proper values
                graph.ChartAreas[0].AxisX.Minimum = 0;
                graph.ChartAreas[0].AxisX.Maximum = 1;

                graph.ChartAreas[0].AxisY.Minimum = 0;
                graph.ChartAreas[0].AxisY.Maximum = 1;

                graph.Series[0].Points.AddXY(0, 0);
                graph.Series[0].Points.AddXY(1, 1);
                for (double x = 0; x <= 2; x += smoothness)
                {
                    // f(x)
                    f1 = r * (1 - Math.Abs(2*x - 1));
                    if (cb1.Checked)
                        graph.Series[1].Points.AddXY(x, f1);
                    if (Math.Abs(f1 - x) <= error)
                        f11.Text = Convert.ToString(Math.Round(f1,2)).Replace(",", ".");

                    // f^2(x)
                    f2 = r * (1 - Math.Abs(2 * f1 - 1));
                    if (cb2.Checked)
                        graph.Series[2].Points.AddXY(x, f2);

                    if (Math.Abs(f2 - x) <= error)
                        valuesf2.Add(f2);


                    // f^4(x)
                    f4 = r * (1 - Math.Abs(2 * f2 - 1));
                    if (cb4.Checked)
                        graph.Series[3].Points.AddXY(x, f4);

                    if (Math.Abs(f4 - x) <= error)
                        valuesf4.Add(f4);

                    // f^8(x)
                    f8 = r * (1 - Math.Abs(2 * f4 - 1));
                    if (cb8.Checked)
                        graph.Series[4].Points.AddXY(x, f8);
                }
            }

            // Draw FTs for f2
            for (int i = 0; i < labelsf2.Count; ++i)
            {
                if (valuesf2.Count <= i || (i >= 1 && Math.Abs(valuesf2[i] - valuesf2[i-1]) <= (0.05) ))
                   labelsf2[i].Text = "/";
                else
                    labelsf2[i].Text = Convert.ToString(Math.Round(valuesf2[i], 2)).Replace(",", ".");
            }

            // Draw FTs for f4
            for (int i = 0; i < labelsf4.Count; ++i)
            {
               if (valuesf4.Count <= i || (i >= 1 && Math.Abs(valuesf4[i] - valuesf4[i - 1]) <= (0.05)))
                   labelsf4[i].Text = "/";
                else
                    labelsf4[i].Text = Convert.ToString(Math.Round(valuesf4[i], 2)).Replace(",", ".");
            }

            valuesf2.Clear();
            valuesf4.Clear();
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
            cbIterator.Items.Add(new OneHumpIterator(iterators[4], 4));
        }

        private void initialiseTheSlider() {
            sliderR.SetRange(0, 500);
        }

        private void defultLineThicness() {
            graph.Series["f(x) = x"].BorderWidth = 2;
            if(cb1.Checked)
                graph.Series["f(x)"].BorderWidth = 2;
            if (cb2.Checked)
                graph.Series["f^2(x)"].BorderWidth = 2;
            if (cb4.Checked)
                graph.Series["f^4(x)"].BorderWidth = 2;
            if (cb8.Checked)
                graph.Series["f^8(x)"].BorderWidth = 2;
        }

        private void initialiseCheckBox()
        {
            cb1.Checked = true;
            cb2.Checked = true;
            cb4.Checked = true;
            cb8.Checked = true;
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
            graph.Series["f(x) = x"].BorderWidth = 1;
            if(cb1.Checked)
                graph.Series["f(x)"].BorderWidth = 3;
            if (cb2.Checked)
                graph.Series["f^2(x)"].BorderWidth = 3;
            if (cb4.Checked)
                graph.Series["f^4(x)"].BorderWidth = 3;
            if (cb8.Checked)
                graph.Series["f^8(x)"].BorderWidth = 3;
        }

        private void cb1_Click(object sender, EventArgs e)
        {
            if (graph.Series[1].BorderWidth == 0)
            {
                graph.Series[1].BorderWidth = 3;
                dynamicThickness();
            }
            else
                graph.Series[1].BorderWidth = 0;
            draw();

        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (graph.Series[2].BorderWidth == 0)
            {
                graph.Series[2].BorderWidth = 3;
                dynamicThickness();
            }
            else
                graph.Series[2].BorderWidth = 0;
            draw();
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            if (graph.Series[3].BorderWidth == 0)
            {
                graph.Series[3].BorderWidth = 3;
                dynamicThickness();
            }
            else
                graph.Series[3].BorderWidth = 0;
            draw();
        }

        private void cb8_CheckedChanged(object sender, EventArgs e)
        {
            if (graph.Series[4].BorderWidth == 0)
            {
                graph.Series[4].BorderWidth = 3;
                dynamicThickness();
            }
            else
                graph.Series[4].BorderWidth = 0;
            draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String info = "To get the up to date code visit the github page https://github.com/Weenkus/One-Hump-Iterator-Visualization";
            info += "\n\nContact: vinko.kodzoman@fer.hr  \n\n";
            info += "The program draws four compositions of a function that the user chooses at the top of the form. ";
            info += "Every function has a variable r and the user can change it by using the slider found on the bottom of the form. ";
            info += "The value of r is printed on the right of the graph together with all fixed points (FT) from all founction compositions. ";
            info += "\n\nf^2(x) represent the second composition of f(x), f^2(x) = f(f(x))";
            info += "\n\nFT1 is the first fixed point of a function";
            info += "\n\nIn the bottom right coner there are four check boxes witch allow the user to choose which compositions of the function f(x) will be shown.";

            info += "\n\nWhen a composition of f(x) is bolded it means that the given composition has a stable fixed point.";
            info += " Some compositions don't get bolded duo to lack of information needed to give an upper and lower bound for the stability.";

            MessageBox.Show(info);
        }
    }
}
