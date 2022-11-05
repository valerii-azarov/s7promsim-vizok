
namespace Vizok
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_run = new System.Windows.Forms.Button();
            this.checkBox_I02 = new System.Windows.Forms.CheckBox();
            this.timer_Read_Output = new System.Windows.Forms.Timer(this.components);
            this.button_stop = new System.Windows.Forms.Button();
            this.checkBox_I00 = new System.Windows.Forms.CheckBox();
            this.checkBox_I03 = new System.Windows.Forms.CheckBox();
            this.label_Q00 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox_I01 = new System.Windows.Forms.CheckBox();
            this.label1_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(25, 25);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(100, 35);
            this.button_run.TabIndex = 0;
            this.button_run.Text = "Запускати";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // checkBox_I02
            // 
            this.checkBox_I02.AutoSize = true;
            this.checkBox_I02.Enabled = false;
            this.checkBox_I02.Location = new System.Drawing.Point(40, 372);
            this.checkBox_I02.Name = "checkBox_I02";
            this.checkBox_I02.Size = new System.Drawing.Size(230, 21);
            this.checkBox_I02.TabIndex = 13;
            this.checkBox_I02.Text = "Автоматичний / ручний режим";
            this.checkBox_I02.UseVisualStyleBackColor = true;
            this.checkBox_I02.CheckedChanged += new System.EventHandler(this.checkBox_I02_CheckedChanged);
            // 
            // timer_Read_Output
            // 
            this.timer_Read_Output.Enabled = true;
            this.timer_Read_Output.Tick += new System.EventHandler(this.timer_Read_Output_Tick);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(131, 25);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(100, 35);
            this.button_stop.TabIndex = 15;
            this.button_stop.Text = "Стоп";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // checkBox_I00
            // 
            this.checkBox_I00.AutoSize = true;
            this.checkBox_I00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_I00.Enabled = false;
            this.checkBox_I00.Location = new System.Drawing.Point(285, 82);
            this.checkBox_I00.Name = "checkBox_I00";
            this.checkBox_I00.Size = new System.Drawing.Size(91, 21);
            this.checkBox_I00.TabIndex = 24;
            this.checkBox_I00.Text = "Датчик 1";
            this.checkBox_I00.UseVisualStyleBackColor = false;
            this.checkBox_I00.CheckedChanged += new System.EventHandler(this.checkBox_I00_CheckedChanged);
            // 
            // checkBox_I03
            // 
            this.checkBox_I03.AutoSize = true;
            this.checkBox_I03.BackColor = System.Drawing.Color.Yellow;
            this.checkBox_I03.Enabled = false;
            this.checkBox_I03.Location = new System.Drawing.Point(285, 136);
            this.checkBox_I03.Name = "checkBox_I03";
            this.checkBox_I03.Size = new System.Drawing.Size(129, 21);
            this.checkBox_I03.TabIndex = 26;
            this.checkBox_I03.Text = "Зупинити візок";
            this.checkBox_I03.UseVisualStyleBackColor = false;
            this.checkBox_I03.CheckedChanged += new System.EventHandler(this.checkBox_I03_CheckedChanged);
            // 
            // label_Q00
            // 
            this.label_Q00.AutoSize = true;
            this.label_Q00.BackColor = System.Drawing.SystemColors.Control;
            this.label_Q00.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Q00.Location = new System.Drawing.Point(237, 31);
            this.label_Q00.Name = "label_Q00";
            this.label_Q00.Size = new System.Drawing.Size(185, 20);
            this.label_Q00.TabIndex = 24;
            this.label_Q00.Text = "ВІЗОК РУХАЄТЬСЯ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vizok.Properties.Resources._93ec3b583b879e1dac78929d5b2f8686;
            this.pictureBox2.Location = new System.Drawing.Point(46, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(394, 294);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox_I01
            // 
            this.checkBox_I01.AutoSize = true;
            this.checkBox_I01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBox_I01.Enabled = false;
            this.checkBox_I01.Location = new System.Drawing.Point(285, 109);
            this.checkBox_I01.Name = "checkBox_I01";
            this.checkBox_I01.Size = new System.Drawing.Size(91, 21);
            this.checkBox_I01.TabIndex = 27;
            this.checkBox_I01.Text = "Датчик 2";
            this.checkBox_I01.UseVisualStyleBackColor = false;
            this.checkBox_I01.CheckedChanged += new System.EventHandler(this.checkBox_I01_CheckedChanged);
            // 
            // label1_status
            // 
            this.label1_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_status.ForeColor = System.Drawing.Color.DarkRed;
            this.label1_status.Location = new System.Drawing.Point(276, 367);
            this.label1_status.Name = "label1_status";
            this.label1_status.Size = new System.Drawing.Size(164, 28);
            this.label1_status.TabIndex = 0;
            this.label1_status.Text = "ВІДКЛЮЧЕННЯ";
            this.label1_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 413);
            this.Controls.Add(this.label1_status);
            this.Controls.Add(this.checkBox_I01);
            this.Controls.Add(this.checkBox_I00);
            this.Controls.Add(this.label_Q00);
            this.Controls.Add(this.checkBox_I03);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.checkBox_I02);
            this.Controls.Add(this.button_run);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizok. Coded by Azarov Valerii";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.CheckBox checkBox_I02;
        private System.Windows.Forms.Timer timer_Read_Output;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.CheckBox checkBox_I00;
        private System.Windows.Forms.CheckBox checkBox_I03;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Q00;
        private System.Windows.Forms.CheckBox checkBox_I01;
        private System.Windows.Forms.Label label1_status;
    }
}