namespace AndresarZadanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.button_Show = new System.Windows.Forms.Button();
            this.directory_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(872, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresár";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(954, 592);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(120, 20);
            this.inputBox.TabIndex = 1;
            // 
            // button_Show
            // 
            this.button_Show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Show.Location = new System.Drawing.Point(54, 86);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(136, 46);
            this.button_Show.TabIndex = 2;
            this.button_Show.Text = "Vypísať";
            this.button_Show.UseVisualStyleBackColor = false;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // directory_panel
            // 
            this.directory_panel.AutoScroll = true;
            this.directory_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.directory_panel.Location = new System.Drawing.Point(272, 69);
            this.directory_panel.Name = "directory_panel";
            this.directory_panel.Size = new System.Drawing.Size(802, 505);
            this.directory_panel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.backButton.Image = global::AndresarZadanie.Properties.Resources.back_arrow__1_;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(272, 28);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(135, 35);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Späť";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 648);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.directory_panel);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.FlowLayoutPanel directory_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
    }
}

