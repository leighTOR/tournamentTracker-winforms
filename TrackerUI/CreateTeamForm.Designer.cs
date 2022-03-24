namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.lstbTournamentPlayers = new System.Windows.Forms.ListBox();
            this.drpdSelectTeamMember = new System.Windows.Forms.ComboBox();
            this.txtbTeamName = new System.Windows.Forms.TextBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblCreateTeam = new System.Windows.Forms.Label();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.grpbAddNewMember = new System.Windows.Forms.GroupBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.txtbCellphone = new System.Windows.Forms.TextBox();
            this.btnDeleteSelectedMember = new System.Windows.Forms.Button();
            this.grpbAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbTournamentPlayers
            // 
            this.lstbTournamentPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbTournamentPlayers.FormattingEnabled = true;
            this.lstbTournamentPlayers.ItemHeight = 30;
            this.lstbTournamentPlayers.Location = new System.Drawing.Point(492, 119);
            this.lstbTournamentPlayers.Name = "lstbTournamentPlayers";
            this.lstbTournamentPlayers.Size = new System.Drawing.Size(368, 452);
            this.lstbTournamentPlayers.TabIndex = 18;
            // 
            // drpdSelectTeamMember
            // 
            this.drpdSelectTeamMember.FormattingEnabled = true;
            this.drpdSelectTeamMember.Location = new System.Drawing.Point(55, 213);
            this.drpdSelectTeamMember.Name = "drpdSelectTeamMember";
            this.drpdSelectTeamMember.Size = new System.Drawing.Size(412, 38);
            this.drpdSelectTeamMember.TabIndex = 17;
            // 
            // txtbTeamName
            // 
            this.txtbTeamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbTeamName.Location = new System.Drawing.Point(55, 119);
            this.txtbTeamName.Name = "txtbTeamName";
            this.txtbTeamName.Size = new System.Drawing.Size(412, 35);
            this.txtbTeamName.TabIndex = 16;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSelectTeam.Location = new System.Drawing.Point(48, 173);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(263, 37);
            this.lblSelectTeam.TabIndex = 10;
            this.lblSelectTeam.Text = "Select Team Member";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamName.Location = new System.Drawing.Point(48, 79);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(157, 37);
            this.lblTeamName.TabIndex = 11;
            this.lblTeamName.Text = "Team Name";
            // 
            // lblCreateTeam
            // 
            this.lblCreateTeam.AutoSize = true;
            this.lblCreateTeam.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblCreateTeam.Location = new System.Drawing.Point(21, 17);
            this.lblCreateTeam.Name = "lblCreateTeam";
            this.lblCreateTeam.Size = new System.Drawing.Size(213, 50);
            this.lblCreateTeam.TabIndex = 20;
            this.lblCreateTeam.Text = "Create Team";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddTeam.Location = new System.Drawing.Point(55, 257);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(163, 47);
            this.btnAddTeam.TabIndex = 21;
            this.btnAddTeam.Text = "Add Member";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateMember.Location = new System.Drawing.Point(155, 590);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(178, 47);
            this.btnCreateMember.TabIndex = 21;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            // 
            // grpbAddNewMember
            // 
            this.grpbAddNewMember.Controls.Add(this.txtbCellphone);
            this.grpbAddNewMember.Controls.Add(this.lblCellphone);
            this.grpbAddNewMember.Controls.Add(this.txtbEmail);
            this.grpbAddNewMember.Controls.Add(this.lblEmail);
            this.grpbAddNewMember.Controls.Add(this.txtbLastName);
            this.grpbAddNewMember.Controls.Add(this.lblLastName);
            this.grpbAddNewMember.Controls.Add(this.txtbFirstName);
            this.grpbAddNewMember.Controls.Add(this.lblFirstName);
            this.grpbAddNewMember.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbAddNewMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.grpbAddNewMember.Location = new System.Drawing.Point(55, 326);
            this.grpbAddNewMember.Name = "grpbAddNewMember";
            this.grpbAddNewMember.Size = new System.Drawing.Size(412, 256);
            this.grpbAddNewMember.TabIndex = 23;
            this.grpbAddNewMember.TabStop = false;
            this.grpbAddNewMember.Text = "Add New Member";
            // 
            // txtbEmail
            // 
            this.txtbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbEmail.Location = new System.Drawing.Point(158, 142);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(237, 43);
            this.txtbEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblEmail.Location = new System.Drawing.Point(8, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 37);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtbLastName
            // 
            this.txtbLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbLastName.Location = new System.Drawing.Point(158, 93);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(237, 43);
            this.txtbLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblLastName.Location = new System.Drawing.Point(8, 93);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(142, 37);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbFirstName.Location = new System.Drawing.Point(158, 44);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(237, 43);
            this.txtbFirstName.TabIndex = 7;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblFirstName.Location = new System.Drawing.Point(8, 44);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(144, 37);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateTeam.Location = new System.Drawing.Point(367, 670);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(178, 47);
            this.btnCreateTeam.TabIndex = 21;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblCellphone.Location = new System.Drawing.Point(8, 191);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(138, 37);
            this.lblCellphone.TabIndex = 6;
            this.lblCellphone.Text = "Cellphone";
            // 
            // txtbCellphone
            // 
            this.txtbCellphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbCellphone.Location = new System.Drawing.Point(158, 191);
            this.txtbCellphone.Name = "txtbCellphone";
            this.txtbCellphone.Size = new System.Drawing.Size(237, 43);
            this.txtbCellphone.TabIndex = 7;
            // 
            // btnDeleteSelectedMember
            // 
            this.btnDeleteSelectedMember.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDeleteSelectedMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnDeleteSelectedMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDeleteSelectedMember.Location = new System.Drawing.Point(584, 590);
            this.btnDeleteSelectedMember.Name = "btnDeleteSelectedMember";
            this.btnDeleteSelectedMember.Size = new System.Drawing.Size(178, 47);
            this.btnDeleteSelectedMember.TabIndex = 21;
            this.btnDeleteSelectedMember.Text = "Delete Selected";
            this.btnDeleteSelectedMember.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 739);
            this.Controls.Add(this.grpbAddNewMember);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnDeleteSelectedMember);
            this.Controls.Add(this.btnCreateMember);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.lblCreateTeam);
            this.Controls.Add(this.lstbTournamentPlayers);
            this.Controls.Add(this.drpdSelectTeamMember);
            this.Controls.Add(this.txtbTeamName);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.lblTeamName);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.grpbAddNewMember.ResumeLayout(false);
            this.grpbAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstbTournamentPlayers;
        private System.Windows.Forms.ComboBox drpdSelectTeamMember;
        private System.Windows.Forms.TextBox txtbTeamName;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblCreateTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.GroupBox grpbAddNewMember;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.TextBox txtbCellphone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.Button btnDeleteSelectedMember;
    }
}