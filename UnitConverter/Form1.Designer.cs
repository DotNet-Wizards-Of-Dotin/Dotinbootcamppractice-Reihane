namespace UnitConverter
{
    partial class UnitCalculator
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
            this.txt_rq_number = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.sout = new System.Windows.Forms.Button();
            this.mesghal = new System.Windows.Forms.Button();
            this.ghirat = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_rq_number
            // 
            this.txt_rq_number.AutoSize = true;
            this.txt_rq_number.Location = new System.Drawing.Point(202, 9);
            this.txt_rq_number.Name = "txt_rq_number";
            this.txt_rq_number.Size = new System.Drawing.Size(95, 17);
            this.txt_rq_number.TabIndex = 1;
            this.txt_rq_number.Text = "گرم را وارد کنید";
            this.txt_rq_number.Click += new System.EventHandler(this.label1_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(61, 7);
            this.input.Name = "input";
            this.input.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.input.Size = new System.Drawing.Size(120, 24);
            this.input.TabIndex = 2;
            this.input.ValueChanged += new System.EventHandler(this.input_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // sout
            // 
            this.sout.Location = new System.Drawing.Point(255, 43);
            this.sout.Name = "sout";
            this.sout.Size = new System.Drawing.Size(75, 23);
            this.sout.TabIndex = 4;
            this.sout.Text = "سوت";
            this.sout.UseVisualStyleBackColor = true;
            this.sout.Click += new System.EventHandler(this.sout_Click);
            // 
            // mesghal
            // 
            this.mesghal.Location = new System.Drawing.Point(12, 43);
            this.mesghal.Name = "mesghal";
            this.mesghal.Size = new System.Drawing.Size(75, 23);
            this.mesghal.TabIndex = 5;
            this.mesghal.Text = "مثقال";
            this.mesghal.UseVisualStyleBackColor = true;
            this.mesghal.Click += new System.EventHandler(this.mesghal_Click);
            // 
            // ghirat
            // 
            this.ghirat.Location = new System.Drawing.Point(127, 43);
            this.ghirat.Name = "ghirat";
            this.ghirat.Size = new System.Drawing.Size(75, 23);
            this.ghirat.TabIndex = 6;
            this.ghirat.Text = "قیراط";
            this.ghirat.UseVisualStyleBackColor = true;
            this.ghirat.Click += new System.EventHandler(this.ghirat_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(161, 99);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 17);
            this.output.TabIndex = 7;
            // 
            // UnitCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 146);
            this.Controls.Add(this.output);
            this.Controls.Add(this.ghirat);
            this.Controls.Add(this.mesghal);
            this.Controls.Add(this.sout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input);
            this.Controls.Add(this.txt_rq_number);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "UnitCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnitCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_rq_number;
        private System.Windows.Forms.NumericUpDown input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sout;
        private System.Windows.Forms.Button mesghal;
        private System.Windows.Forms.Button ghirat;
        private System.Windows.Forms.Label output;
    }
}

