namespace WinFormsApp1
{
    partial class firstSample
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label1 = new Label();
            btnClick = new Button();
            txtName = new TextBox();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(334, 89);
            Label1.Name = "Label1";
            Label1.Size = new Size(99, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Enter Your Name:";
            Label1.Click += label1_Click;
            // 
            // btnClick
            // 
            btnClick.Location = new Point(343, 170);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(75, 23);
            btnClick.TabIndex = 1;
            btnClick.Text = "Click";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(301, 141);
            txtName.Name = "txtName";
            txtName.Size = new Size(154, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(301, 277);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 15);
            lblWelcome.TabIndex = 3;
            lblWelcome.Click += label2_Click;
            // 
            // firstSample
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWelcome);
            Controls.Add(txtName);
            Controls.Add(btnClick);
            Controls.Add(Label1);
            Name = "firstSample";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label1;
        private Button btnClick;
        private TextBox txtName;
        private Label lblWelcome;
    }
}
