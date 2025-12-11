namespace WinFormsApp1
{
    partial class Form1
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
            btnRunDemo = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // btnRunDemo
            // 
            btnRunDemo.Location = new Point(14, 16);
            btnRunDemo.Margin = new Padding(3, 4, 3, 4);
            btnRunDemo.Name = "btnRunDemo";
            btnRunDemo.Size = new Size(229, 40);
            btnRunDemo.TabIndex = 0;
            btnRunDemo.Text = "Выполнить демонстрацию";
            btnRunDemo.UseVisualStyleBackColor = true;
            btnRunDemo.Click += btnRunDemo_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(14, 67);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(886, 516);
            txtResult.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnRunDemo);
            Controls.Add(txtResult);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Практическая работа номер шесть";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRunDemo;
        private TextBox txtResult;
    }
}
