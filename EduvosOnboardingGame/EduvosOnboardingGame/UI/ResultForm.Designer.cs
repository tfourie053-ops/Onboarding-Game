namespace EduvosOnboardingGame.UI
{
    partial class ResultForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblKnowledgeLabel = new System.Windows.Forms.Label();
            this.lblKnowledgeScore = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(26, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Your Result";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStudent.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStudent.Location = new System.Drawing.Point(30, 64);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(111, 19);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "Student: (name)";
            // 
            // lblKnowledgeLabel
            // 
            this.lblKnowledgeLabel.AutoSize = true;
            this.lblKnowledgeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblKnowledgeLabel.Location = new System.Drawing.Point(32, 104);
            this.lblKnowledgeLabel.Name = "lblKnowledgeLabel";
            this.lblKnowledgeLabel.Size = new System.Drawing.Size(95, 15);
            this.lblKnowledgeLabel.TabIndex = 2;
            this.lblKnowledgeLabel.Text = "Final Knowledge:";
            // 
            // lblKnowledgeScore
            // 
            this.lblKnowledgeScore.AutoSize = true;
            this.lblKnowledgeScore.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKnowledgeScore.ForeColor = System.Drawing.Color.White;
            this.lblKnowledgeScore.Location = new System.Drawing.Point(140, 94);
            this.lblKnowledgeScore.Name = "lblKnowledgeScore";
            this.lblKnowledgeScore.Size = new System.Drawing.Size(26, 30);
            this.lblKnowledgeScore.TabIndex = 3;
            this.lblKnowledgeScore.Text = "0";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(32, 140);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(520, 60);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "(message)";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(32, 220);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(260, 38);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Back to Start";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(302, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(584, 281);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblKnowledgeScore);
            this.Controls.Add(this.lblKnowledgeLabel);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result - Eduvos Week One Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblKnowledgeLabel;
        private System.Windows.Forms.Label lblKnowledgeScore;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnExit;
    }
}
