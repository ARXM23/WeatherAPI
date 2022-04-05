namespace WeatherAPI
{
    partial class weather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(weather));
            this.label1 = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.labelsu = new System.Windows.Forms.Label();
            this.labsunn = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.labtemp = new System.Windows.Forms.Label();
            this.labTemperature = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.labHumidity = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad:";
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(105, 19);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(173, 29);
            this.TBCity.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(284, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.Color.Black;
            this.labCondition.Location = new System.Drawing.Point(12, 100);
            this.labCondition.Name = "labCondition";
            this.labCondition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labCondition.Size = new System.Drawing.Size(177, 22);
            this.labCondition.TabIndex = 3;
            this.labCondition.Text = "Condicion Climatica";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.Color.Black;
            this.labDetails.Location = new System.Drawing.Point(12, 121);
            this.labDetails.Name = "labDetails";
            this.labDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labDetails.Size = new System.Drawing.Size(76, 22);
            this.labDetails.TabIndex = 4;
            this.labDetails.Text = "Detalles";
            // 
            // labelsu
            // 
            this.labelsu.AutoSize = true;
            this.labelsu.BackColor = System.Drawing.Color.Transparent;
            this.labelsu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsu.ForeColor = System.Drawing.Color.Black;
            this.labelsu.Location = new System.Drawing.Point(12, 211);
            this.labelsu.Name = "labelsu";
            this.labelsu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelsu.Size = new System.Drawing.Size(67, 22);
            this.labelsu.TabIndex = 5;
            this.labelsu.Text = "Ocaso:";
            // 
            // labsunn
            // 
            this.labsunn.AutoSize = true;
            this.labsunn.BackColor = System.Drawing.Color.Transparent;
            this.labsunn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsunn.ForeColor = System.Drawing.Color.Black;
            this.labsunn.Location = new System.Drawing.Point(12, 179);
            this.labsunn.Name = "labsunn";
            this.labsunn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labsunn.Size = new System.Drawing.Size(98, 22);
            this.labsunn.TabIndex = 6;
            this.labsunn.Text = "Amanecer:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.Black;
            this.labSunrise.Location = new System.Drawing.Point(116, 180);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labSunrise.Size = new System.Drawing.Size(41, 21);
            this.labSunrise.TabIndex = 7;
            this.labSunrise.Text = "N/A";
            this.labSunrise.Click += new System.EventHandler(this.labSunrise_Click);
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.Color.Black;
            this.labSunset.Location = new System.Drawing.Point(81, 211);
            this.labSunset.Name = "labSunset";
            this.labSunset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labSunset.Size = new System.Drawing.Size(41, 21);
            this.labSunset.TabIndex = 8;
            this.labSunset.Text = "N/A";
            // 
            // labtemp
            // 
            this.labtemp.AutoSize = true;
            this.labtemp.BackColor = System.Drawing.Color.Transparent;
            this.labtemp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtemp.ForeColor = System.Drawing.Color.Black;
            this.labtemp.Location = new System.Drawing.Point(12, 243);
            this.labtemp.Name = "labtemp";
            this.labtemp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labtemp.Size = new System.Drawing.Size(121, 22);
            this.labtemp.TabIndex = 9;
            this.labtemp.Text = "Temperatura:";
            // 
            // labTemperature
            // 
            this.labTemperature.AutoSize = true;
            this.labTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemperature.ForeColor = System.Drawing.Color.Black;
            this.labTemperature.Location = new System.Drawing.Point(133, 243);
            this.labTemperature.Name = "labTemperature";
            this.labTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labTemperature.Size = new System.Drawing.Size(41, 21);
            this.labTemperature.TabIndex = 10;
            this.labTemperature.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(269, 176);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Velocidad del Viento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(269, 211);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Presión:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(269, 243);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Humedad:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.Black;
            this.labWindSpeed.Location = new System.Drawing.Point(443, 176);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labWindSpeed.Size = new System.Drawing.Size(41, 21);
            this.labWindSpeed.TabIndex = 14;
            this.labWindSpeed.Text = "N/A";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.Color.Black;
            this.labPressure.Location = new System.Drawing.Point(345, 211);
            this.labPressure.Name = "labPressure";
            this.labPressure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labPressure.Size = new System.Drawing.Size(41, 21);
            this.labPressure.TabIndex = 15;
            this.labPressure.Text = "N/A";
            // 
            // labHumidity
            // 
            this.labHumidity.AutoSize = true;
            this.labHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labHumidity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHumidity.ForeColor = System.Drawing.Color.Black;
            this.labHumidity.Location = new System.Drawing.Point(361, 243);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labHumidity.Size = new System.Drawing.Size(41, 21);
            this.labHumidity.TabIndex = 16;
            this.labHumidity.Text = "N/A";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(334, 100);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(100, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 17;
            this.picIcon.TabStop = false;
            // 
            // weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labHumidity);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labTemperature);
            this.Controls.Add(this.labtemp);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.labsunn);
            this.Controls.Add(this.labelsu);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "weather";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.weather_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label labelsu;
        private System.Windows.Forms.Label labsunn;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label labtemp;
        private System.Windows.Forms.Label labTemperature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label labHumidity;
        private System.Windows.Forms.PictureBox picIcon;
    }
}