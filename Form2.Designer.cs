namespace WinFormsApp1
{
    partial class Form2
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
            lblRed = new Label();
            lblYellow = new Label();
            lblGreen = new Label();
            lblBlue = new Label();
            lblOrange = new Label();
            SuspendLayout();
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.ForeColor = Color.Red;
            lblRed.Location = new Point(306, 47);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(27, 15);
            lblRed.TabIndex = 0;
            lblRed.Text = "Red";
            lblRed.Click += lblRed_MouseMove;
            lblRed.MouseHover += lblRed_MouseMove;
            // 
            // lblYellow
            // 
            lblYellow.AutoSize = true;
            lblYellow.ForeColor = Color.Yellow;
            lblYellow.Location = new Point(312, 80);
            lblYellow.Name = "lblYellow";
            lblYellow.Size = new Size(41, 15);
            lblYellow.TabIndex = 1;
            lblYellow.Text = "Yellow";
            lblYellow.Click += lblYellow_MouseMove;
            lblYellow.MouseHover += lblYellow_MouseMove;
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.ForeColor = Color.ForestGreen;
            lblGreen.Location = new Point(313, 107);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(38, 15);
            lblGreen.TabIndex = 2;
            lblGreen.Text = "Green";
            lblGreen.Click += lblGreen_MouseMove;
            lblGreen.MouseHover += lblGreen_MouseMove;
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.ForeColor = Color.Blue;
            lblBlue.Location = new Point(319, 142);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(30, 15);
            lblBlue.TabIndex = 3;
            lblBlue.Text = "Blue";
            lblBlue.Click += lblBlue_MouseMove;
            lblBlue.MouseHover += lblBlue_MouseMove;
            // 
            // lblOrange
            // 
            lblOrange.AutoSize = true;
            lblOrange.ForeColor = Color.FromArgb(255, 128, 0);
            lblOrange.Location = new Point(333, 177);
            lblOrange.Name = "lblOrange";
            lblOrange.Size = new Size(46, 15);
            lblOrange.TabIndex = 4;
            lblOrange.Text = "Orange";
            lblOrange.Click += lblOrange_MouseMove;
            lblOrange.MouseHover += lblOrange_MouseMove;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOrange);
            Controls.Add(lblBlue);
            Controls.Add(lblGreen);
            Controls.Add(lblYellow);
            Controls.Add(lblRed);
            ForeColor = Color.FromArgb(0, 192, 0);
            Name = "Form2";
            Text = "Form2";
            MouseHover += Form2_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRed;
        private Label lblYellow;
        private Label lblGreen;
        private Label lblBlue;
        private Label lblOrange;
    }
}