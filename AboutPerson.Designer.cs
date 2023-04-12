namespace XML_JSON
{
    partial class AboutPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutPerson));
            this.personPicture = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.cardLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.temp1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // personPicture
            // 
            this.personPicture.Image = ((System.Drawing.Image)(resources.GetObject("personPicture.Image")));
            this.personPicture.Location = new System.Drawing.Point(31, 42);
            this.personPicture.Margin = new System.Windows.Forms.Padding(6);
            this.personPicture.Name = "personPicture";
            this.personPicture.Size = new System.Drawing.Size(200, 192);
            this.personPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personPicture.TabIndex = 3;
            this.personPicture.TabStop = false;
            this.personPicture.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(287, 42);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(85, 31);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "name";
            this.nameLabel.Visible = false;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(287, 185);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(62, 31);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "age";
            this.ageLabel.Visible = false;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(537, 185);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(71, 31);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "year";
            this.yearLabel.Visible = false;
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardLabel.Location = new System.Drawing.Point(25, 349);
            this.cardLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(71, 31);
            this.cardLabel.TabIndex = 8;
            this.cardLabel.Text = "card";
            this.cardLabel.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(399, 349);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(94, 31);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Text = "status";
            this.statusLabel.Visible = false;
            // 
            // temp1Label
            // 
            this.temp1Label.AutoSize = true;
            this.temp1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temp1Label.Location = new System.Drawing.Point(25, 504);
            this.temp1Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.temp1Label.Name = "temp1Label";
            this.temp1Label.Size = new System.Drawing.Size(94, 31);
            this.temp1Label.TabIndex = 12;
            this.temp1Label.Text = "temp1";
            this.temp1Label.Visible = false;
            // 
            // AboutPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 722);
            this.Controls.Add(this.temp1Label);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.personPicture);
            this.Name = "AboutPerson";
            this.Text = "Информация";
            this.Load += new System.EventHandler(this.AboutPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox personPicture;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label temp1Label;
    }
}