namespace PictureOrganizer
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.FromTxt = new System.Windows.Forms.TextBox();
            this.FromLab = new System.Windows.Forms.Label();
            this.Totxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TbrwB = new System.Windows.Forms.Button();
            this.FbrwB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FromTxt
            // 
            this.FromTxt.Location = new System.Drawing.Point(47, 7);
            this.FromTxt.Name = "FromTxt";
            this.FromTxt.Size = new System.Drawing.Size(166, 20);
            this.FromTxt.TabIndex = 0;
            // 
            // FromLab
            // 
            this.FromLab.AutoSize = true;
            this.FromLab.Location = new System.Drawing.Point(11, 10);
            this.FromLab.Name = "FromLab";
            this.FromLab.Size = new System.Drawing.Size(30, 13);
            this.FromLab.TabIndex = 1;
            this.FromLab.Text = "From";
            // 
            // Totxt
            // 
            this.Totxt.Location = new System.Drawing.Point(47, 33);
            this.Totxt.Name = "Totxt";
            this.Totxt.Size = new System.Drawing.Size(166, 20);
            this.Totxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbrwB
            // 
            this.TbrwB.Location = new System.Drawing.Point(219, 31);
            this.TbrwB.Name = "TbrwB";
            this.TbrwB.Size = new System.Drawing.Size(75, 23);
            this.TbrwB.TabIndex = 4;
            this.TbrwB.Text = "Browse";
            this.TbrwB.UseVisualStyleBackColor = true;
            this.TbrwB.Click += new System.EventHandler(this.TbrwB_Click);
            // 
            // FbrwB
            // 
            this.FbrwB.Location = new System.Drawing.Point(219, 5);
            this.FbrwB.Name = "FbrwB";
            this.FbrwB.Size = new System.Drawing.Size(75, 23);
            this.FbrwB.TabIndex = 4;
            this.FbrwB.Text = "Browse";
            this.FbrwB.UseVisualStyleBackColor = true;
            this.FbrwB.Click += new System.EventHandler(this.FbrwB_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 91);
            this.Controls.Add(this.FbrwB);
            this.Controls.Add(this.TbrwB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FromLab);
            this.Controls.Add(this.Totxt);
            this.Controls.Add(this.FromTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Picture Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FromTxt;
        private System.Windows.Forms.Label FromLab;
        private System.Windows.Forms.TextBox Totxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TbrwB;
        private System.Windows.Forms.Button FbrwB;
    }
}

