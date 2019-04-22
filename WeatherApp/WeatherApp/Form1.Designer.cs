namespace WeatherApp
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
            this.getWeatherButton = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.weatherImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.weatherImage)).BeginInit();
            this.SuspendLayout();
            // 
            // getWeatherButton
            // 
            this.getWeatherButton.BackColor = System.Drawing.Color.White;
            this.getWeatherButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.getWeatherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getWeatherButton.ForeColor = System.Drawing.Color.Navy;
            this.getWeatherButton.Location = new System.Drawing.Point(302, 12);
            this.getWeatherButton.Name = "getWeatherButton";
            this.getWeatherButton.Size = new System.Drawing.Size(204, 48);
            this.getWeatherButton.TabIndex = 0;
            this.getWeatherButton.Text = "Get Today\'s Weather";
            this.getWeatherButton.UseVisualStyleBackColor = false;
            this.getWeatherButton.Click += new System.EventHandler(this.GetWeatherButton_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.Navy;
            this.locationLabel.Location = new System.Drawing.Point(12, 109);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(91, 24);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Location: ";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureLabel.ForeColor = System.Drawing.Color.Navy;
            this.temperatureLabel.Location = new System.Drawing.Point(38, 144);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(129, 24);
            this.temperatureLabel.TabIndex = 2;
            this.temperatureLabel.Text = "Temperature: ";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Navy;
            this.descriptionLabel.Location = new System.Drawing.Point(38, 179);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(114, 24);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Navy;
            this.statusLabel.Location = new System.Drawing.Point(162, 91);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(53, 20);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "status";
            // 
            // weatherImage
            // 
            this.weatherImage.Location = new System.Drawing.Point(146, 171);
            this.weatherImage.Name = "weatherImage";
            this.weatherImage.Size = new System.Drawing.Size(69, 39);
            this.weatherImage.TabIndex = 5;
            this.weatherImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 224);
            this.Controls.Add(this.weatherImage);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.getWeatherButton);
            this.Name = "Form1";
            this.Text = "WeatherApp";
            ((System.ComponentModel.ISupportInitialize)(this.weatherImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getWeatherButton;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox weatherImage;
    }
}

