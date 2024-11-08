namespace assignment7
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
            components = new System.ComponentModel.Container();
            btnLoadAnswers = new Button();
            lblResult = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblCorrectCount = new Label();
            lblIncorrectCount = new Label();
            txtIncorrectQuestions = new TextBox();
            SuspendLayout();
            // 
            // btnLoadAnswers
            // 
            btnLoadAnswers.Location = new Point(36, 47);
            btnLoadAnswers.Name = "btnLoadAnswers";
            btnLoadAnswers.Size = new Size(130, 23);
            btnLoadAnswers.TabIndex = 0;
            btnLoadAnswers.Text = "Load Answers";
            btnLoadAnswers.UseVisualStyleBackColor = true;
            btnLoadAnswers.Click += btnLoadAnswers_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(223, 55);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(117, 15);
            lblResult.TabIndex = 1;
            lblResult.Text = "Total correct answers";
            lblResult.Click += lblResult_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblCorrectCount
            // 
            lblCorrectCount.AutoSize = true;
            lblCorrectCount.Location = new Point(36, 100);
            lblCorrectCount.Name = "lblCorrectCount";
            lblCorrectCount.Size = new Size(82, 15);
            lblCorrectCount.TabIndex = 3;
            lblCorrectCount.Text = "Correct Count";
            // 
            // lblIncorrectCount
            // 
            lblIncorrectCount.AutoSize = true;
            lblIncorrectCount.Location = new Point(223, 100);
            lblIncorrectCount.Name = "lblIncorrectCount";
            lblIncorrectCount.Size = new Size(101, 15);
            lblIncorrectCount.TabIndex = 4;
            lblIncorrectCount.Text = "Incorrect Answers";
            lblIncorrectCount.Click += lblIncorrectCount_Click;
            // 
            // txtIncorrectQuestions
            // 
            txtIncorrectQuestions.Location = new Point(377, 12);
            txtIncorrectQuestions.Multiline = true;
            txtIncorrectQuestions.Name = "txtIncorrectQuestions";
            txtIncorrectQuestions.ReadOnly = true;
            txtIncorrectQuestions.Size = new Size(255, 226);
            txtIncorrectQuestions.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 334);
            Controls.Add(txtIncorrectQuestions);
            Controls.Add(lblIncorrectCount);
            Controls.Add(lblCorrectCount);
            Controls.Add(lblResult);
            Controls.Add(btnLoadAnswers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadAnswers;
        private Label lblResult;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblCorrectCount;
        private Label lblIncorrectCount;
        private TextBox txtIncorrectQuestions;
    }
}
