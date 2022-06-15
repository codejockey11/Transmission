using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Transmission
{
    public partial class Form3 : Form
    {
        public Double ringGear;
        public Double fromSpeed;
        public Double toSpeed;
        public Double RPM;
        public Double tireDiameter;

        public Boolean useGForce;

        public List<String> ratios;

        StreamReader sr;

        public Form3()
        {
            InitializeComponent();

            try
            {
                sr = new StreamReader("settings.cfg");

                String[] values = sr.ReadLine().Split(' ');

                ringGear = Convert.ToDouble(values[0]);
                fromSpeed = Convert.ToDouble(values[1]);
                toSpeed = Convert.ToDouble(values[2]);
                RPM = Convert.ToDouble(values[3]);
                tireDiameter = Convert.ToDouble(values[4]);

                useGForce = false;

                if (values.Length == 6 && values[5] != "")
                {
                    useGForce = true;
                }

                sr.Close();

                rearDiffText.Text = values[0];
                fromSpeedText.Text = values[1];
                toSpeedText.Text = values[2];
                rpmText.Text = values[3];
                tireDiameterText.Text = values[4];

                if (useGForce)
                {
                    gForceCheckbox.Checked = true;
                }
                else
                {
                    gForceCheckbox.Checked = false;
                }
            }
            catch (System.IO.IOException exc)
            {
                String msg = exc.Message;

                ringGear = 3.50;
                fromSpeed = 0;
                toSpeed = 55;
                RPM = 7000;
                tireDiameter = 28.70;
                
                useGForce = true;
            }

            if (useGForce)
            {
                LoadRatios();
            }
        }

        private void LoadRatios()
        {
            ratios = new List<String>();

            sr = new StreamReader("GForceGears.txt");

            String rec = sr.ReadLine();

            String[] values;

            while (!sr.EndOfStream)
            {
                values = rec.Split('/');

                foreach (String v in values)
                {
                    ratios.Add(v);
                }

                rec = sr.ReadLine();
            }

            values = rec.Split('/');

            foreach (String v in values)
            {
                ratios.Add(v);
            }

            ratios.Sort();
        }

        private void Form3_FormClosing(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("settings.cfg");

            sw.Write(rearDiffText.Text);
            sw.Write(" ");

            sw.Write(fromSpeedText.Text);
            sw.Write(" ");

            sw.Write(toSpeedText.Text);
            sw.Write(" ");

            sw.Write(rpmText.Text);
            sw.Write(" ");

            sw.Write(tireDiameterText.Text);

            if (gForceCheckbox.Checked)
            {
                sw.Write(" ");

                sw.Write("X");
            }

            sw.Close();

            ringGear = Convert.ToDouble(rearDiffText.Text);
            fromSpeed = Convert.ToDouble(fromSpeedText.Text);
            toSpeed = Convert.ToDouble(toSpeedText.Text);
            RPM = Convert.ToDouble(rpmText.Text);
            tireDiameter = Convert.ToDouble(tireDiameterText.Text);

            useGForce = false;

            if (gForceCheckbox.Checked)
            {
                useGForce = true;

                LoadRatios();
            }
        }
    }
}
