﻿namespace FEBuilderGBA
{
    partial class ToolWorkSupportForm
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CommunityButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.VersionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CommunityTextBox = new System.Windows.Forms.TextBox();
            this.SnowAllWorksButton = new System.Windows.Forms.Button();
            this.ToggleAutoFeedbackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.LOGO = new FEBuilderGBA.InterpolatedPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(17, 217);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(838, 48);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "最新バージョンに更新する";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CommunityButton
            // 
            this.CommunityButton.Location = new System.Drawing.Point(17, 277);
            this.CommunityButton.Name = "CommunityButton";
            this.CommunityButton.Size = new System.Drawing.Size(838, 48);
            this.CommunityButton.TabIndex = 1;
            this.CommunityButton.Text = "開発コミニティにアクセスする";
            this.CommunityButton.UseVisualStyleBackColor = true;
            this.CommunityButton.Click += new System.EventHandler(this.CommunityButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(236, 107);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(105, 33);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Location = new System.Drawing.Point(116, 107);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(105, 33);
            this.ReloadButton.TabIndex = 0;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(397, 22);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(458, 25);
            this.NameTextBox.TabIndex = 6;
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(3, 3);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.Size = new System.Drawing.Size(832, 98);
            this.InfoTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(291, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "名前";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(291, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "著者";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(397, 56);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.ReadOnly = true;
            this.AuthorTextBox.Size = new System.Drawing.Size(458, 25);
            this.AuthorTextBox.TabIndex = 10;
            // 
            // VersionTextBox
            // 
            this.VersionTextBox.Location = new System.Drawing.Point(397, 87);
            this.VersionTextBox.Name = "VersionTextBox";
            this.VersionTextBox.ReadOnly = true;
            this.VersionTextBox.Size = new System.Drawing.Size(458, 25);
            this.VersionTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(291, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "バージョン";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(291, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "コミニティ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CommunityTextBox
            // 
            this.CommunityTextBox.Location = new System.Drawing.Point(397, 176);
            this.CommunityTextBox.Name = "CommunityTextBox";
            this.CommunityTextBox.ReadOnly = true;
            this.CommunityTextBox.Size = new System.Drawing.Size(458, 25);
            this.CommunityTextBox.TabIndex = 33;
            // 
            // SnowAllWorksButton
            // 
            this.SnowAllWorksButton.Location = new System.Drawing.Point(285, 476);
            this.SnowAllWorksButton.Name = "SnowAllWorksButton";
            this.SnowAllWorksButton.Size = new System.Drawing.Size(570, 48);
            this.SnowAllWorksButton.TabIndex = 3;
            this.SnowAllWorksButton.Text = "他の作品を表示する";
            this.SnowAllWorksButton.UseVisualStyleBackColor = true;
            this.SnowAllWorksButton.Click += new System.EventHandler(this.SnowAllWorksButton_Click);
            // 
            // ToggleAutoFeedbackButton
            // 
            this.ToggleAutoFeedbackButton.Location = new System.Drawing.Point(17, 360);
            this.ToggleAutoFeedbackButton.Name = "ToggleAutoFeedbackButton";
            this.ToggleAutoFeedbackButton.Size = new System.Drawing.Size(838, 48);
            this.ToggleAutoFeedbackButton.TabIndex = 2;
            this.ToggleAutoFeedbackButton.Text = "自動フィードバックを無効にする";
            this.ToggleAutoFeedbackButton.UseVisualStyleBackColor = true;
            this.ToggleAutoFeedbackButton.Click += new System.EventHandler(this.ToggleAutoFeedbackButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.InfoTextBox);
            this.panel1.Controls.Add(this.ReloadButton);
            this.panel1.Controls.Add(this.OpenButton);
            this.panel1.Location = new System.Drawing.Point(17, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 143);
            this.panel1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "UpdateInfo:";
            // 
            // LOGO
            // 
            this.LOGO.Interpolation = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
            this.LOGO.Location = new System.Drawing.Point(17, 22);
            this.LOGO.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(270, 180);
            this.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LOGO.TabIndex = 31;
            this.LOGO.TabStop = false;
            // 
            // ToolWorkSupportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(867, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToggleAutoFeedbackButton);
            this.Controls.Add(this.SnowAllWorksButton);
            this.Controls.Add(this.CommunityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LOGO);
            this.Controls.Add(this.VersionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CommunityButton);
            this.Controls.Add(this.UpdateButton);
            this.Name = "ToolWorkSupportForm";
            this.Text = "作品支援";
            this.Load += new System.EventHandler(this.WorkSupport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CommunityButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox VersionTextBox;
        private System.Windows.Forms.Label label3;
        private InterpolatedPictureBox LOGO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CommunityTextBox;
        private System.Windows.Forms.Button SnowAllWorksButton;
        private System.Windows.Forms.Button ToggleAutoFeedbackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}