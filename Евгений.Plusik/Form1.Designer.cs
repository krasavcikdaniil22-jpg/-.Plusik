namespace Евгений.Plusik
{
    partial class FormMain
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
            label1 = new Label();
            label2 = new Label();
            labelTargetNumber = new Label();
            labelUserNumber = new Label();
            buttonMult = new Button();
            buttonPlus = new Button();
            label3 = new Label();
            labelUserSteps = new Label();
            buttonReset = new Button();
            textBoxNum = new TextBox();
            buttonSpecifyNumber = new Button();
            buttonRandomNumber = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 133);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 0;
            label1.Text = "Your Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(80, 30);
            label2.TabIndex = 1;
            label2.Text = "Target:";
            // 
            // labelTargetNumber
            // 
            labelTargetNumber.AutoSize = true;
            labelTargetNumber.Font = new Font("Segoe UI", 18F);
            labelTargetNumber.Location = new Point(98, 38);
            labelTargetNumber.Name = "labelTargetNumber";
            labelTargetNumber.Size = new Size(40, 32);
            labelTargetNumber.TabIndex = 2;
            labelTargetNumber.Text = "56";
            // 
            // labelUserNumber
            // 
            labelUserNumber.AutoSize = true;
            labelUserNumber.Font = new Font("Segoe UI", 18F);
            labelUserNumber.Location = new Point(165, 133);
            labelUserNumber.Name = "labelUserNumber";
            labelUserNumber.Size = new Size(27, 32);
            labelUserNumber.TabIndex = 3;
            labelUserNumber.Text = "1";
            // 
            // buttonMult
            // 
            buttonMult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMult.Location = new Point(264, 22);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(75, 75);
            buttonMult.TabIndex = 4;
            buttonMult.Text = "*2";
            buttonMult.UseVisualStyleBackColor = true;
            buttonMult.Click += buttonMult_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPlus.Location = new Point(264, 117);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(75, 75);
            buttonPlus.TabIndex = 5;
            buttonPlus.Text = "+1";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 313);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 6;
            label3.Text = "Steps:";
            // 
            // labelUserSteps
            // 
            labelUserSteps.AutoSize = true;
            labelUserSteps.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserSteps.Location = new Point(94, 313);
            labelUserSteps.Name = "labelUserSteps";
            labelUserSteps.Size = new Size(27, 32);
            labelUserSteps.TabIndex = 7;
            labelUserSteps.Text = "0";
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReset.Location = new Point(7, 259);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(360, 36);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxNum.Location = new Point(225, 313);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(114, 33);
            textBoxNum.TabIndex = 9;
            textBoxNum.TextChanged += textBoxNum_TextChanged;
            // 
            // buttonSpecifyNumber
            // 
            buttonSpecifyNumber.Location = new Point(225, 353);
            buttonSpecifyNumber.Name = "buttonSpecifyNumber";
            buttonSpecifyNumber.Size = new Size(114, 23);
            buttonSpecifyNumber.TabIndex = 10;
            buttonSpecifyNumber.Text = "Specify a number";
            buttonSpecifyNumber.UseVisualStyleBackColor = true;
            buttonSpecifyNumber.Click += buttonSpecifyNumber_Click;
            // 
            // buttonRandomNumber
            // 
            buttonRandomNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRandomNumber.Location = new Point(7, 209);
            buttonRandomNumber.Name = "buttonRandomNumber";
            buttonRandomNumber.Size = new Size(360, 35);
            buttonRandomNumber.TabIndex = 11;
            buttonRandomNumber.Text = "generate a random number";
            buttonRandomNumber.UseVisualStyleBackColor = true;
            buttonRandomNumber.Click += buttonRandomNumber_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 411);
            Controls.Add(buttonRandomNumber);
            Controls.Add(buttonSpecifyNumber);
            Controls.Add(textBoxNum);
            Controls.Add(buttonReset);
            Controls.Add(labelUserSteps);
            Controls.Add(label3);
            Controls.Add(buttonPlus);
            Controls.Add(buttonMult);
            Controls.Add(labelUserNumber);
            Controls.Add(labelTargetNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMain";
            Text = "FormGame";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelTargetNumber;
        private Label labelUserNumber;
        private Button buttonMult;
        private Button buttonPlus;
        private Label label3;
        private Label labelUserSteps;
        private Button buttonReset;
        private TextBox textBoxNum;
        private Button buttonSpecifyNumber;
        private Button buttonRandomNumber;
    }
}
