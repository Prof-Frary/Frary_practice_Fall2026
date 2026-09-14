namespace Frary_practice_Fall2026
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
            label1 = new Label();
            label2 = new Label();
            txtTextInput = new TextBox();
            label3 = new Label();
            txtNumericInput = new TextBox();
            lstOut = new ListBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(108, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 25);
            label1.TabIndex = 0;
            label1.Text = "Sample Transaction Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 91);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "Text Based Input";
            // 
            // txtTextInput
            // 
            txtTextInput.Location = new Point(237, 88);
            txtTextInput.Name = "txtTextInput";
            txtTextInput.Size = new Size(100, 23);
            txtTextInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 148);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 3;
            label3.Text = "Numeric Based Input";
            // 
            // txtNumericInput
            // 
            txtNumericInput.Location = new Point(243, 149);
            txtNumericInput.Name = "txtNumericInput";
            txtNumericInput.Size = new Size(100, 23);
            txtNumericInput.TabIndex = 4;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.Location = new Point(44, 208);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(352, 94);
            lstOut.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(18, 373);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 65);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate && &Display";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(161, 373);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 65);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(304, 373);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 65);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 450);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lstOut);
            Controls.Add(txtNumericInput);
            Controls.Add(label3);
            Controls.Add(txtTextInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Frary Sample Program";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTextInput;
        private Label label3;
        private TextBox txtNumericInput;
        private ListBox lstOut;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnQuit;
    }
}
