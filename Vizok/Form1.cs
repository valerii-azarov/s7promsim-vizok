using System;
using System.Windows.Forms;
using S7PROSIMLib;

namespace Vizok
{
    public partial class Form1 : Form
    {
        // бібліотека, яка дозволяє підключатися до програми SIMATIC
        public S7ProSim PS = new S7ProSim();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            // підключення до програми SIMATIC
            PS.Connect();
            // стан ЗАПУСКУ вставлено
            PS.SetState("RUN"); 
            // режим сканування ставиться в Continuous
            PS.SetScanMode(ScanModeConstants.ContinuousScan); 

            MessageBox.Show(
                "Підключення ввімкнено",
                "Повідомлення",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // зміна мітки
            label1_status.Text = "ПІДКЛЮЧЕННЯ";
            label1_status.ForeColor = System.Drawing.Color.Green;
            // checkboxs увімкнено
            setEnableDisableCheckBoxs(true);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // стан СТОПУ вставлено
            PS.SetState("STOP");
            // відключення від програми SIMATIC
            PS.Disconnect();

            MessageBox.Show(
                "Підключення вимкнено",
                "Повідомлення",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // зміна мітки
            label1_status.Text = "ВІДКЛЮЧЕННЯ";
            label1_status.ForeColor = System.Drawing.Color.DarkRed;
            // checkboxs вимкнено
            setEnableDisableCheckBoxs(false);
        }           

        private void checkBox_I00_CheckedChanged(object sender, EventArgs e)
        {
            // I0.0 читається
            object I0_0 = checkBox_I00.Checked;
            // I0.0 записується
            PS.WriteInputPoint(0, 0, ref I0_0);
        }

        private void checkBox_I01_CheckedChanged(object sender, EventArgs e)
        {
            // I0.1 читається
            object I0_1 = checkBox_I01.Checked;
            // I0.1 записується
            PS.WriteInputPoint(0, 1, ref I0_1);
        }

        private void checkBox_I02_CheckedChanged(object sender, EventArgs e)
        {
            // I0.2 читається
            object I0_2 = checkBox_I02.Checked;
            // I0.2 записується
            PS.WriteInputPoint(0, 2, ref I0_2);
        }

        private void checkBox_I03_CheckedChanged(object sender, EventArgs e)
        {
            // I0.3 читається
            object I0_3 = checkBox_I03.Checked;
            // I0.3 записується
            PS.WriteInputPoint(0, 3, ref I0_3);
        }        

        private void timer_Read_Output_Tick(object sender, EventArgs e)
        {
            // Q0.0 читається
            object Q0_0 = true;
            // Q0.0 отримується
            PS.ReadOutputPoint(0, 0, PointDataTypeConstants.S7_Bit, ref Q0_0);

            // якщо Q0.0 не отримує галочку
            if (!(bool)Q0_0)
            {
                label_Q00.Text = "ВІЗОК РУХАЄТЬСЯ";
                label_Q00.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label_Q00.Text = "ВІЗОК ЗУПИНЯЄТЬСЯ";
                label_Q00.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void setEnableDisableCheckBoxs(bool value)
        {
            // всі елементи отримуються
            foreach (Control control in this.Controls)
            {
                // перевіряється, чи checkbox є елемент
                if (control is CheckBox)
                {
                    // вимкнення або включення встановлюється за умовою 
                    ((CheckBox)control).Enabled = value;
                }
            }
        }
    }
}
