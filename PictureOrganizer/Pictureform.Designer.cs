namespace PictureOrganizer
{
    partial class Pictureform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pictureform));
            this.Frame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Frame)).BeginInit();
            this.SuspendLayout();
            // 
            // Frame
            // 
            this.Frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Frame.Location = new System.Drawing.Point(0, 0);
            this.Frame.Name = "Frame";
            this.Frame.Size = new System.Drawing.Size(855, 504);
            this.Frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Frame.TabIndex = 0;
            this.Frame.TabStop = false;
            // 
            // Pictureform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(65)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(855, 504);
            this.Controls.Add(this.Frame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pictureform";
            this.Text = "Picture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pictureform_FormClosed);
            this.Load += new System.EventHandler(this.Pictureform_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pictureform_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Frame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Frame;
    }
}