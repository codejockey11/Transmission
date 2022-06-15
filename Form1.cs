using System;
using System.IO;
using System.Windows.Forms;

namespace Transmission
{
    public partial class Form1 : Form
    {
        String line;

        Boolean wasWritten = false;

        Form3 settingsForm;

        public Form1()
        {
            InitializeComponent();

            settingsForm = new Form3();

            Double i = settingsForm.ringGear;

            textBoxDifferential.Text = i.ToString("F2");

            i = settingsForm.fromSpeed;

            textBoxFromSpeed.Text = i.ToString("F0");

            i = settingsForm.toSpeed;

            textBoxToSpeed.Text = i.ToString("F0");

            i = settingsForm.RPM;

            textBoxToRPM.Text = i.ToString("F0");

            i = settingsForm.tireDiameter;

            textBoxTireDiameter.Text = i.ToString("F2");
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Form2 numbersForm = new Form2();

            StreamWriter sr = new StreamWriter("speeds.txt");

            line = "Differential: " + Convert.ToDouble(textBoxDifferential.Text).ToString("F2") + " Speed: " + Convert.ToDouble(textBoxFromSpeed.Text).ToString("F2") + "-" + Convert.ToDouble(textBoxToSpeed.Text).ToString("F2");

            numbersForm.richTextBoxNumbers.Text += line;

            numbersForm.richTextBoxNumbers.Text += "\n\n";

            sr.WriteLine(line);

            if (settingsForm.useGForce)
            {
                foreach (String r in settingsForm.ratios)
                {
                    double ratio = Convert.ToDouble(r);

                    wasWritten = false;

                    CalcMPH(numbersForm, sr, ratio);

                    if (wasWritten == true)
                    {
                        wasWritten = false;

                        sr.WriteLine();

                        line = "\n";

                        numbersForm.richTextBoxNumbers.Text += line;
                    }
                }
            }
            else
            {
                for (double ratio = Convert.ToDouble(textBoxFromRatio.Text); ratio <= Convert.ToDouble(textBoxToRatio.Text); ratio += 0.025)
                {
                    wasWritten = false;

                    CalcMPH(numbersForm, sr, ratio);

                    if (wasWritten == true)
                    {
                        wasWritten = false;

                        sr.WriteLine();

                        line = "\n";

                        numbersForm.richTextBoxNumbers.Text += line;
                    }
                }
            }

            sr.Close();

            numbersForm.ShowDialog();
        }

        private void CalcMPH(Form2 numbersForm, StreamWriter sr, Double ratio)
        {
            Double diff = Convert.ToDouble(textBoxDifferential.Text);
            Double tire = Convert.ToDouble(textBoxTireDiameter.Text);

            Double fromSpeed = Convert.ToDouble(textBoxFromSpeed.Text);
            Double toSpeed = Convert.ToDouble(textBoxToSpeed.Text);

            Double fromRPM = Convert.ToDouble(textBoxFromRPM.Text);
            Double toRPM = Convert.ToDouble(textBoxToRPM.Text);

            String ratioString = Convert.ToDouble(ratio).ToString("F3");

            for (Int16 mph = 0; mph <= 500; mph += 1)
            {
                Double rpm = (mph * diff * ratio * 336) / tire;

                if ((mph >= fromSpeed) && (mph <= toSpeed))
                {
                    if ((rpm >= fromRPM) && (rpm <= toRPM))
                    {
                        line = "\t" + mph.ToString("D3") + " " + ratioString + " " + rpm.ToString("F0");

                        numbersForm.richTextBoxNumbers.Text += line;

                        sr.Write(line);

                        wasWritten = true;
                    }
                }
            }
        }

        private void buttonSingle_Click(object sender, EventArgs e)
        {
            double rpm = (Convert.ToDouble(textBoxSpeed.Text) * Convert.ToDouble(textBoxDifferential.Text) * Convert.ToDouble(textBoxRatio.Text) * 336) / Convert.ToDouble(textBoxTireDiameter.Text);

            textBoxRPM.Text = rpm.ToString("F0");
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();

            Double i = settingsForm.ringGear;

            textBoxDifferential.Text = i.ToString("F2");

            i = settingsForm.fromSpeed;

            textBoxFromSpeed.Text = i.ToString("F0");

            i = settingsForm.toSpeed;

            textBoxToSpeed.Text = i.ToString("F0");

            i = settingsForm.RPM;

            textBoxToRPM.Text = i.ToString("F0");

            i = settingsForm.tireDiameter;

            textBoxTireDiameter.Text = i.ToString("F2");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
