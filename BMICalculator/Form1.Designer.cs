namespace BMICalculator
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
            lblWeight = new Label();
            lblHeight = new Label();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            btnCalculate = new Button();
            btnclear = new Button();
            label1 = new Label();
            Status = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeight.Location = new Point(12, 136);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(156, 31);
            lblWeight.TabIndex = 0;
            lblWeight.Text = "Weight (Kg) : ";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeight.Location = new Point(25, 215);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(144, 31);
            lblHeight.TabIndex = 1;
            lblHeight.Text = "Height (m) : ";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(175, 136);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(460, 27);
            txtWeight.TabIndex = 2;
            txtWeight.TextChanged += txtWeight_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(175, 219);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(460, 27);
            txtHeight.TabIndex = 3;
            txtHeight.TextChanged += txtHeight_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(328, 279);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(122, 29);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(497, 279);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(122, 29);
            btnclear.TabIndex = 5;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 380);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 6;
            label1.Text = "Health Status : ";
            label1.Click += label1_Click;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.BackColor = SystemColors.GradientInactiveCaption;
            Status.Location = new Point(175, 380);
            Status.Name = "Status";
            Status.Size = new Size(165, 20);
            Status.TabIndex = 7;
            Status.Text = "__________________________";
            Status.Click += Status_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Adobe Caslon Pro Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(267, 27);
            label2.Name = "label2";
            label2.Size = new Size(352, 58);
            label2.TabIndex = 8;
            label2.Text = "BMI CALCULATOR";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(861, 511);
            Controls.Add(label2);
            Controls.Add(Status);
            Controls.Add(label1);
            Controls.Add(btnclear);
            Controls.Add(btnCalculate);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "BMI Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWeight;
        private Label lblHeight;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private Button btnCalculate;
        private Button btnclear;
        private Label label1;
        private Label Status;
        private Label label2;
    }
}
