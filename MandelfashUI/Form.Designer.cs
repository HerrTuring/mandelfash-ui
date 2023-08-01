namespace MandelfashCalculator
{
    partial class Form
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
            this.mandelfash = new System.Windows.Forms.PictureBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.xText = new System.Windows.Forms.TextBox();
            this.yText = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.genButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mandelfash)).BeginInit();
            this.SuspendLayout();
            // 
            // mandelfash
            // 
            this.mandelfash.Image = global::MandelfashUI.Properties.Resources.black;
            this.mandelfash.Location = new System.Drawing.Point(12, 12);
            this.mandelfash.Name = "mandelfash";
            this.mandelfash.Size = new System.Drawing.Size(1000, 1023);
            this.mandelfash.TabIndex = 0;
            this.mandelfash.TabStop = false;
            this.mandelfash.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mandefash_MouseClick);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(1015, 12);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(73, 13);
            this.xLabel.TabIndex = 1;
            this.xLabel.Text = "X Coordinates";
            // 
            // xText
            // 
            this.xText.Location = new System.Drawing.Point(1018, 29);
            this.xText.Name = "xText";
            this.xText.ReadOnly = true;
            this.xText.Size = new System.Drawing.Size(100, 20);
            this.xText.TabIndex = 2;
            // 
            // yText
            // 
            this.yText.Location = new System.Drawing.Point(1018, 84);
            this.yText.Name = "yText";
            this.yText.ReadOnly = true;
            this.yText.Size = new System.Drawing.Size(100, 20);
            this.yText.TabIndex = 4;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(1015, 67);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(73, 13);
            this.yLabel.TabIndex = 3;
            this.yLabel.Text = "Y Coordinates";
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(1018, 110);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(100, 23);
            this.genButton.TabIndex = 5;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 1044);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.yText);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xText);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.mandelfash);
            this.Name = "Form";
            this.Text = "Mandelfash Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.mandelfash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mandelfash;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox xText;
        private System.Windows.Forms.TextBox yText;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Button genButton;
    }
}

