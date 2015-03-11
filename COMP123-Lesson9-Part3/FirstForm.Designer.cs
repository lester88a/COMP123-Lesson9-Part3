namespace COMP123_Lesson9_Part3
{
    partial class FirstForm
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
            this.Hellolabel = new System.Windows.Forms.Label();
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.GreetingTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Hellolabel
            // 
            this.Hellolabel.AutoSize = true;
            this.Hellolabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hellolabel.Location = new System.Drawing.Point(131, 210);
            this.Hellolabel.Name = "Hellolabel";
            this.Hellolabel.Size = new System.Drawing.Size(195, 32);
            this.Hellolabel.TabIndex = 2;
            this.Hellolabel.Text = "Hello World!";
            this.Hellolabel.Click += new System.EventHandler(this.Hellolabel_Click);
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ClickMeButton.Location = new System.Drawing.Point(185, 281);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(75, 23);
            this.ClickMeButton.TabIndex = 1;
            this.ClickMeButton.Text = "Click Me";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            // 
            // GreetingTextBox
            // 
            this.GreetingTextBox.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingTextBox.Location = new System.Drawing.Point(12, 157);
            this.GreetingTextBox.Name = "GreetingTextBox";
            this.GreetingTextBox.Size = new System.Drawing.Size(460, 39);
            this.GreetingTextBox.TabIndex = 0;
            this.GreetingTextBox.Text = "Enter Message";
            this.GreetingTextBox.TextChanged += new System.EventHandler(this.GreetingTextBox_TextChanged);
            this.GreetingTextBox.Enter += new System.EventHandler(this.GreetingTextBox_Enter);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.GreetingTextBox);
            this.Controls.Add(this.ClickMeButton);
            this.Controls.Add(this.Hellolabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hellolabel;
        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.TextBox GreetingTextBox;
    }
}

