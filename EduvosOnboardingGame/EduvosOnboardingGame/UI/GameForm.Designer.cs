namespace EduvosOnboardingGame.UI
{
    partial class GameForm
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
            this.lblDay = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.groupStats = new System.Windows.Forms.GroupBox();
            this.lblMotivationValue = new System.Windows.Forms.Label();
            this.lblKnowledgeValue = new System.Windows.Forms.Label();
            this.lblEnergyValue = new System.Windows.Forms.Label();
            this.lblMotivation = new System.Windows.Forms.Label();
            this.lblKnowledge = new System.Windows.Forms.Label();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblScenario = new System.Windows.Forms.Label();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.groupStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(24, 20);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(132, 30);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Day 1 of 5";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStudentName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStudentName.Location = new System.Drawing.Point(26, 54);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(111, 19);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student: (name)";
            // 
            // groupStats
            // 
            this.groupStats.Controls.Add(this.lblMotivationValue);
            this.groupStats.Controls.Add(this.lblKnowledgeValue);
            this.groupStats.Controls.Add(this.lblEnergyValue);
            this.groupStats.Controls.Add(this.lblMotivation);
            this.groupStats.Controls.Add(this.lblKnowledge);
            this.groupStats.Controls.Add(this.lblEnergy);
            this.groupStats.ForeColor = System.Drawing.Color.White;
            this.groupStats.Location = new System.Drawing.Point(30, 88);
            this.groupStats.Name = "groupStats";
            this.groupStats.Size = new System.Drawing.Size(520, 80);
            this.groupStats.TabIndex = 2;
            this.groupStats.TabStop = false;
            this.groupStats.Text = "Current Stats";
            // 
            // lblMotivationValue
            // 
            this.lblMotivationValue.AutoSize = true;
            this.lblMotivationValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMotivationValue.ForeColor = System.Drawing.Color.White;
            this.lblMotivationValue.Location = new System.Drawing.Point(426, 34);
            this.lblMotivationValue.Name = "lblMotivationValue";
            this.lblMotivationValue.Size = new System.Drawing.Size(19, 21);
            this.lblMotivationValue.TabIndex = 5;
            this.lblMotivationValue.Text = "0";
            // 
            // lblKnowledgeValue
            // 
            this.lblKnowledgeValue.AutoSize = true;
            this.lblKnowledgeValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblKnowledgeValue.ForeColor = System.Drawing.Color.White;
            this.lblKnowledgeValue.Location = new System.Drawing.Point(250, 34);
            this.lblKnowledgeValue.Name = "lblKnowledgeValue";
            this.lblKnowledgeValue.Size = new System.Drawing.Size(19, 21);
            this.lblKnowledgeValue.TabIndex = 4;
            this.lblKnowledgeValue.Text = "0";
            // 
            // lblEnergyValue
            // 
            this.lblEnergyValue.AutoSize = true;
            this.lblEnergyValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEnergyValue.ForeColor = System.Drawing.Color.White;
            this.lblEnergyValue.Location = new System.Drawing.Point(86, 34);
            this.lblEnergyValue.Name = "lblEnergyValue";
            this.lblEnergyValue.Size = new System.Drawing.Size(19, 21);
            this.lblEnergyValue.TabIndex = 3;
            this.lblEnergyValue.Text = "0";
            // 
            // lblMotivation
            // 
            this.lblMotivation.AutoSize = true;
            this.lblMotivation.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMotivation.Location = new System.Drawing.Point(338, 38);
            this.lblMotivation.Name = "lblMotivation";
            this.lblMotivation.Size = new System.Drawing.Size(63, 15);
            this.lblMotivation.TabIndex = 2;
            this.lblMotivation.Text = "Motivation";
            // 
            // lblKnowledge
            // 
            this.lblKnowledge.AutoSize = true;
            this.lblKnowledge.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblKnowledge.Location = new System.Drawing.Point(170, 38);
            this.lblKnowledge.Name = "lblKnowledge";
            this.lblKnowledge.Size = new System.Drawing.Size(62, 15);
            this.lblKnowledge.TabIndex = 1;
            this.lblKnowledge.Text = "Knowledge";
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEnergy.Location = new System.Drawing.Point(24, 38);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(41, 15);
            this.lblEnergy.TabIndex = 0;
            this.lblEnergy.Text = "Energy";
            // 
            // lblScenario
            // 
            this.lblScenario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblScenario.ForeColor = System.Drawing.Color.White;
            this.lblScenario.Location = new System.Drawing.Point(30, 190);
            this.lblScenario.Name = "lblScenario";
            this.lblScenario.Size = new System.Drawing.Size(520, 68);
            this.lblScenario.TabIndex = 3;
            this.lblScenario.Text = "(Scenario description)";
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOption1.ForeColor = System.Drawing.Color.White;
            this.btnOption1.Location = new System.Drawing.Point(30, 286);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(520, 40);
            this.btnOption1.TabIndex = 4;
            this.btnOption1.Text = "Option 1";
            this.btnOption1.UseVisualStyleBackColor = false;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOption2.ForeColor = System.Drawing.Color.White;
            this.btnOption2.Location = new System.Drawing.Point(30, 336);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(520, 40);
            this.btnOption2.TabIndex = 5;
            this.btnOption2.Text = "Option 2";
            this.btnOption2.UseVisualStyleBackColor = false;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Orange;
            this.lblWarning.Location = new System.Drawing.Point(30, 170);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(290, 15);
            this.lblWarning.TabIndex = 6;
            this.lblWarning.Text = "Warning: Low energy! Consider choices carefully.";
            this.lblWarning.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption1);
            this.Controls.Add(this.lblScenario);
            this.Controls.Add(this.groupStats);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game - Eduvos Week One Simulator";
            this.groupStats.ResumeLayout(false);
            this.groupStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.GroupBox groupStats;
        private System.Windows.Forms.Label lblMotivationValue;
        private System.Windows.Forms.Label lblKnowledgeValue;
        private System.Windows.Forms.Label lblEnergyValue;
        private System.Windows.Forms.Label lblMotivation;
        private System.Windows.Forms.Label lblKnowledge;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblScenario;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Label lblWarning;
    }
}
