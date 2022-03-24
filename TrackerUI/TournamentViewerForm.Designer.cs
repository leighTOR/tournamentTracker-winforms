namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.drpdRound = new System.Windows.Forms.ComboBox();
            this.chkbUplayedOnly = new System.Windows.Forms.CheckBox();
            this.lstbMatchup = new System.Windows.Forms.ListBox();
            this.lblTeamOneName = new System.Windows.Forms.Label();
            this.lblTeamOneScore = new System.Windows.Forms.Label();
            this.lblVersus = new System.Windows.Forms.Label();
            this.lblTeamTwoName = new System.Windows.Forms.Label();
            this.lblTeamTwoScore = new System.Windows.Forms.Label();
            this.txtbTeamOneSocre = new System.Windows.Forms.TextBox();
            this.txtbTeamTwoScore = new System.Windows.Forms.TextBox();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(23, 31);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(214, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentName.Location = new System.Drawing.Point(233, 31);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(150, 50);
            this.tournamentName.TabIndex = 0;
            this.tournamentName.Text = "<none>";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblRound.Location = new System.Drawing.Point(25, 92);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(94, 37);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Round";
            // 
            // drpdRound
            // 
            this.drpdRound.FormattingEnabled = true;
            this.drpdRound.Location = new System.Drawing.Point(134, 91);
            this.drpdRound.Name = "drpdRound";
            this.drpdRound.Size = new System.Drawing.Size(232, 38);
            this.drpdRound.TabIndex = 2;
            // 
            // chkbUplayedOnly
            // 
            this.chkbUplayedOnly.AutoSize = true;
            this.chkbUplayedOnly.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbUplayedOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.chkbUplayedOnly.Location = new System.Drawing.Point(134, 135);
            this.chkbUplayedOnly.Name = "chkbUplayedOnly";
            this.chkbUplayedOnly.Size = new System.Drawing.Size(193, 41);
            this.chkbUplayedOnly.TabIndex = 3;
            this.chkbUplayedOnly.Text = "Uplayed only";
            this.chkbUplayedOnly.UseVisualStyleBackColor = true;
            // 
            // lstbMatchup
            // 
            this.lstbMatchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbMatchup.FormattingEnabled = true;
            this.lstbMatchup.ItemHeight = 30;
            this.lstbMatchup.Location = new System.Drawing.Point(32, 194);
            this.lstbMatchup.Name = "lstbMatchup";
            this.lstbMatchup.Size = new System.Drawing.Size(334, 242);
            this.lstbMatchup.TabIndex = 4;
            // 
            // lblTeamOneName
            // 
            this.lblTeamOneName.AutoSize = true;
            this.lblTeamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamOneName.Location = new System.Drawing.Point(402, 194);
            this.lblTeamOneName.Name = "lblTeamOneName";
            this.lblTeamOneName.Size = new System.Drawing.Size(165, 37);
            this.lblTeamOneName.TabIndex = 1;
            this.lblTeamOneName.Text = "<team one>";
            // 
            // lblTeamOneScore
            // 
            this.lblTeamOneScore.AutoSize = true;
            this.lblTeamOneScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOneScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamOneScore.Location = new System.Drawing.Point(402, 231);
            this.lblTeamOneScore.Name = "lblTeamOneScore";
            this.lblTeamOneScore.Size = new System.Drawing.Size(82, 37);
            this.lblTeamOneScore.TabIndex = 1;
            this.lblTeamOneScore.Text = "Score";
            // 
            // lblVersus
            // 
            this.lblVersus.AutoSize = true;
            this.lblVersus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblVersus.Location = new System.Drawing.Point(452, 291);
            this.lblVersus.Name = "lblVersus";
            this.lblVersus.Size = new System.Drawing.Size(63, 37);
            this.lblVersus.TabIndex = 1;
            this.lblVersus.Text = "-vs-";
            // 
            // lblTeamTwoName
            // 
            this.lblTeamTwoName.AutoSize = true;
            this.lblTeamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamTwoName.Location = new System.Drawing.Point(402, 345);
            this.lblTeamTwoName.Name = "lblTeamTwoName";
            this.lblTeamTwoName.Size = new System.Drawing.Size(165, 37);
            this.lblTeamTwoName.TabIndex = 1;
            this.lblTeamTwoName.Text = "<team two>";
            // 
            // lblTeamTwoScore
            // 
            this.lblTeamTwoScore.AutoSize = true;
            this.lblTeamTwoScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTwoScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamTwoScore.Location = new System.Drawing.Point(402, 382);
            this.lblTeamTwoScore.Name = "lblTeamTwoScore";
            this.lblTeamTwoScore.Size = new System.Drawing.Size(82, 37);
            this.lblTeamTwoScore.TabIndex = 1;
            this.lblTeamTwoScore.Text = "Score";
            // 
            // txtbTeamOneSocre
            // 
            this.txtbTeamOneSocre.Location = new System.Drawing.Point(490, 234);
            this.txtbTeamOneSocre.Name = "txtbTeamOneSocre";
            this.txtbTeamOneSocre.Size = new System.Drawing.Size(102, 35);
            this.txtbTeamOneSocre.TabIndex = 5;
            // 
            // txtbTeamTwoScore
            // 
            this.txtbTeamTwoScore.Location = new System.Drawing.Point(490, 385);
            this.txtbTeamTwoScore.Name = "txtbTeamTwoScore";
            this.txtbTeamTwoScore.Size = new System.Drawing.Size(102, 35);
            this.txtbTeamTwoScore.TabIndex = 5;
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnScore.Location = new System.Drawing.Point(607, 291);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(107, 47);
            this.btnScore.TabIndex = 6;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 487);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.txtbTeamTwoScore);
            this.Controls.Add(this.txtbTeamOneSocre);
            this.Controls.Add(this.lstbMatchup);
            this.Controls.Add(this.chkbUplayedOnly);
            this.Controls.Add(this.drpdRound);
            this.Controls.Add(this.lblVersus);
            this.Controls.Add(this.lblTeamTwoScore);
            this.Controls.Add(this.lblTeamOneScore);
            this.Controls.Add(this.lblTeamTwoName);
            this.Controls.Add(this.lblTeamOneName);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox drpdRound;
        private System.Windows.Forms.CheckBox chkbUplayedOnly;
        private System.Windows.Forms.ListBox lstbMatchup;
        private System.Windows.Forms.Label lblTeamOneName;
        private System.Windows.Forms.Label lblTeamOneScore;
        private System.Windows.Forms.Label lblVersus;
        private System.Windows.Forms.Label lblTeamTwoName;
        private System.Windows.Forms.Label lblTeamTwoScore;
        private System.Windows.Forms.TextBox txtbTeamOneSocre;
        private System.Windows.Forms.TextBox txtbTeamTwoScore;
        private System.Windows.Forms.Button btnScore;
    }
}

