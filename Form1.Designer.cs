namespace InAppAlerts
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
            this.btnAlert = new System.Windows.Forms.Button();
            this.btnCloseAlert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlert
            // 
            this.btnAlert.Location = new System.Drawing.Point(514, 294);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(177, 50);
            this.btnAlert.TabIndex = 0;
            this.btnAlert.Text = "Show Alert";
            this.btnAlert.UseVisualStyleBackColor = true;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // btnCloseAlert
            // 
            this.btnCloseAlert.Location = new System.Drawing.Point(244, 294);
            this.btnCloseAlert.Name = "btnCloseAlert";
            this.btnCloseAlert.Size = new System.Drawing.Size(132, 50);
            this.btnCloseAlert.TabIndex = 1;
            this.btnCloseAlert.Text = "Close";
            this.btnCloseAlert.UseVisualStyleBackColor = true;
            this.btnCloseAlert.Click += new System.EventHandler(this.btnCloseAlert_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseAlert);
            this.Controls.Add(this.btnAlert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlert;
        private System.Windows.Forms.Button btnCloseAlert;
    }
}

