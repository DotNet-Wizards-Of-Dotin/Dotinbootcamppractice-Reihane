namespace Part13_Task
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
            this.myButton1 = new EventExample.CustomButton.MyButton();
            this.myButton2 = new EventExample.CustomButton.MyButton();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.GreenYellow;
            this.myButton1.Location = new System.Drawing.Point(30, 27);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(203, 67);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "myButton1";
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.BeforeClick += new System.EventHandler(this.myButton1_BeforeClick);
            this.myButton1.AfterClick += new System.EventHandler(this.myButton1_AfterClick);
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.GreenYellow;
            this.myButton2.Location = new System.Drawing.Point(145, 145);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(194, 79);
            this.myButton2.TabIndex = 1;
            this.myButton2.Text = "myButton2";
            this.myButton2.UseVisualStyleBackColor = false;
            this.myButton2.BeforeClick += new System.EventHandler(this.myButton2_BeforeClick);
            this.myButton2.AfterClick += new System.EventHandler(this.myButton2_AfterClick);
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private EventExample.CustomButton.MyButton myButton1;
        private EventExample.CustomButton.MyButton myButton2;
    }
}

