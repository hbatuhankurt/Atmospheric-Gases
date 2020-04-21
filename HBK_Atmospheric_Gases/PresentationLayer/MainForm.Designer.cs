namespace PresentationLayer
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sgHumidity = new LiveCharts.WinForms.SolidGauge();
            this.sgTemperature = new LiveCharts.WinForms.SolidGauge();
            this.sgCarbonMonoxide = new LiveCharts.WinForms.SolidGauge();
            this.sgSmoke = new LiveCharts.WinForms.SolidGauge();
            this.sgAir = new LiveCharts.WinForms.SolidGauge();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_connection = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_hum = new System.Windows.Forms.TextBox();
            this.txt_temp = new System.Windows.Forms.TextBox();
            this.txt_data2 = new System.Windows.Forms.TextBox();
            this.txt_co = new System.Windows.Forms.TextBox();
            this.txt_smoke = new System.Windows.Forms.TextBox();
            this.txt_air = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Humidity (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperature (°C)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Carbon Monoxide (CO)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(712, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Smoke (PPM)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(376, 563);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Air Quality (PPM)";
            // 
            // sgHumidity
            // 
            this.sgHumidity.Location = new System.Drawing.Point(12, 89);
            this.sgHumidity.Name = "sgHumidity";
            this.sgHumidity.Size = new System.Drawing.Size(210, 200);
            this.sgHumidity.TabIndex = 7;
            this.sgHumidity.Text = "solidGauge6";
            // 
            // sgTemperature
            // 
            this.sgTemperature.Location = new System.Drawing.Point(228, 89);
            this.sgTemperature.Name = "sgTemperature";
            this.sgTemperature.Size = new System.Drawing.Size(210, 200);
            this.sgTemperature.TabIndex = 7;
            this.sgTemperature.Text = "solidGauge6";
            // 
            // sgCarbonMonoxide
            // 
            this.sgCarbonMonoxide.Location = new System.Drawing.Point(444, 89);
            this.sgCarbonMonoxide.Name = "sgCarbonMonoxide";
            this.sgCarbonMonoxide.Size = new System.Drawing.Size(210, 200);
            this.sgCarbonMonoxide.TabIndex = 7;
            this.sgCarbonMonoxide.Text = "solidGauge6";
            // 
            // sgSmoke
            // 
            this.sgSmoke.Location = new System.Drawing.Point(660, 89);
            this.sgSmoke.Name = "sgSmoke";
            this.sgSmoke.Size = new System.Drawing.Size(210, 200);
            this.sgSmoke.TabIndex = 7;
            this.sgSmoke.Text = "solidGauge6";
            // 
            // sgAir
            // 
            this.sgAir.Location = new System.Drawing.Point(334, 348);
            this.sgAir.Name = "sgAir";
            this.sgAir.Size = new System.Drawing.Size(210, 200);
            this.sgAir.TabIndex = 7;
            this.sgAir.Text = "solidGauge6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Connection:";
            // 
            // lbl_connection
            // 
            this.lbl_connection.AutoSize = true;
            this.lbl_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connection.Location = new System.Drawing.Point(110, 21);
            this.lbl_connection.Name = "lbl_connection";
            this.lbl_connection.Size = new System.Drawing.Size(99, 17);
            this.lbl_connection.TabIndex = 10;
            this.lbl_connection.Text = "lbl_connection";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_hum
            // 
            this.txt_hum.Location = new System.Drawing.Point(66, 89);
            this.txt_hum.Name = "txt_hum";
            this.txt_hum.Size = new System.Drawing.Size(100, 30);
            this.txt_hum.TabIndex = 13;
            this.txt_hum.Visible = false;
            // 
            // txt_temp
            // 
            this.txt_temp.Location = new System.Drawing.Point(284, 89);
            this.txt_temp.Name = "txt_temp";
            this.txt_temp.Size = new System.Drawing.Size(100, 30);
            this.txt_temp.TabIndex = 13;
            this.txt_temp.Visible = false;
            // 
            // txt_data2
            // 
            this.txt_data2.Location = new System.Drawing.Point(372, 53);
            this.txt_data2.Name = "txt_data2";
            this.txt_data2.Size = new System.Drawing.Size(130, 30);
            this.txt_data2.TabIndex = 13;
            this.txt_data2.Visible = false;
            // 
            // txt_co
            // 
            this.txt_co.Location = new System.Drawing.Point(502, 89);
            this.txt_co.Name = "txt_co";
            this.txt_co.Size = new System.Drawing.Size(100, 30);
            this.txt_co.TabIndex = 13;
            this.txt_co.Visible = false;
            // 
            // txt_smoke
            // 
            this.txt_smoke.Location = new System.Drawing.Point(717, 89);
            this.txt_smoke.Name = "txt_smoke";
            this.txt_smoke.Size = new System.Drawing.Size(100, 30);
            this.txt_smoke.TabIndex = 13;
            this.txt_smoke.Visible = false;
            // 
            // txt_air
            // 
            this.txt_air.Location = new System.Drawing.Point(389, 348);
            this.txt_air.Name = "txt_air";
            this.txt_air.Size = new System.Drawing.Size(100, 30);
            this.txt_air.TabIndex = 13;
            this.txt_air.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(630, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Powered by Hasan Batuhan Kurt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Atmospheric Gases";
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 597);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_data2);
            this.Controls.Add(this.txt_smoke);
            this.Controls.Add(this.txt_co);
            this.Controls.Add(this.txt_temp);
            this.Controls.Add(this.txt_air);
            this.Controls.Add(this.txt_hum);
            this.Controls.Add(this.lbl_connection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sgSmoke);
            this.Controls.Add(this.sgCarbonMonoxide);
            this.Controls.Add(this.sgAir);
            this.Controls.Add(this.sgTemperature);
            this.Controls.Add(this.sgHumidity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atmospheric Gases";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private LiveCharts.WinForms.SolidGauge sgHumidity;
        private LiveCharts.WinForms.SolidGauge sgTemperature;
        private LiveCharts.WinForms.SolidGauge sgCarbonMonoxide;
        private LiveCharts.WinForms.SolidGauge sgSmoke;
        private LiveCharts.WinForms.SolidGauge sgAir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_connection;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_hum;
        private System.Windows.Forms.TextBox txt_temp;
        private System.Windows.Forms.TextBox txt_data2;
        private System.Windows.Forms.TextBox txt_co;
        private System.Windows.Forms.TextBox txt_smoke;
        private System.Windows.Forms.TextBox txt_air;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer2;
    }
}

