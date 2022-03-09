namespace Chapter_1_3_assignment
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
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblheight = new System.Windows.Forms.Label();
            this.lblgreatings = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.nudage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtheight
            // 
            this.txtheight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtheight.Location = new System.Drawing.Point(300, 130);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(100, 20);
            this.txtheight.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtname.Location = new System.Drawing.Point(300, 39);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblname.Location = new System.Drawing.Point(12, 39);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(176, 20);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Please enter your name";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblage.Location = new System.Drawing.Point(12, 82);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(163, 20);
            this.lblage.TabIndex = 5;
            this.lblage.Text = "Please enter your age";
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblheight.Location = new System.Drawing.Point(11, 130);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(249, 20);
            this.lblheight.TabIndex = 6;
            this.lblheight.Text = "Please enter your height in meters";
            // 
            // lblgreatings
            // 
            this.lblgreatings.AutoSize = true;
            this.lblgreatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgreatings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblgreatings.Location = new System.Drawing.Point(13, 161);
            this.lblgreatings.Name = "lblgreatings";
            this.lblgreatings.Size = new System.Drawing.Size(0, 13);
            this.lblgreatings.TabIndex = 7;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsubmit.Location = new System.Drawing.Point(406, 24);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(225, 126);
            this.btnsubmit.TabIndex = 8;
            this.btnsubmit.Text = "Submit information";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // nudage
            // 
            this.nudage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nudage.Location = new System.Drawing.Point(300, 82);
            this.nudage.Name = "nudage";
            this.nudage.Size = new System.Drawing.Size(100, 20);
            this.nudage.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(653, 199);
            this.Controls.Add(this.nudage);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.lblgreatings);
            this.Controls.Add(this.lblheight);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtheight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.Label lblgreatings;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.NumericUpDown nudage;
    }
}

