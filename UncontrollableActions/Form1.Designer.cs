namespace UncontrollableActions
{
    partial class Form1
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
            this.consolePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.nextTurnButton = new System.Windows.Forms.Button();
            this.playerInspectPanel = new System.Windows.Forms.Panel();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedPlayerDescTextbox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentPlayerPanel = new System.Windows.Forms.Panel();
            this.currentTurnLabel = new System.Windows.Forms.Label();
            this.currentPlayerDescTextbox = new System.Windows.Forms.RichTextBox();
            this.consolePanel.SuspendLayout();
            this.playerInspectPanel.SuspendLayout();
            this.currentPlayerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // consolePanel
            // 
            this.consolePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.consolePanel.Controls.Add(this.consoleTextBox);
            this.consolePanel.Controls.Add(this.label1);
            this.consolePanel.Location = new System.Drawing.Point(708, 402);
            this.consolePanel.Name = "consolePanel";
            this.consolePanel.Size = new System.Drawing.Size(330, 248);
            this.consolePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Console";
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Enabled = false;
            this.consoleTextBox.Location = new System.Drawing.Point(4, 21);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(323, 224);
            this.consoleTextBox.TabIndex = 1;
            this.consoleTextBox.Text = "";
            // 
            // nextTurnButton
            // 
            this.nextTurnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nextTurnButton.Location = new System.Drawing.Point(13, 269);
            this.nextTurnButton.Name = "nextTurnButton";
            this.nextTurnButton.Size = new System.Drawing.Size(120, 42);
            this.nextTurnButton.TabIndex = 1;
            this.nextTurnButton.Text = "End Turn";
            this.nextTurnButton.UseVisualStyleBackColor = true;
            // 
            // playerInspectPanel
            // 
            this.playerInspectPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerInspectPanel.Controls.Add(this.label3);
            this.playerInspectPanel.Controls.Add(this.selectedPlayerDescTextbox);
            this.playerInspectPanel.Controls.Add(this.label2);
            this.playerInspectPanel.Controls.Add(this.playerListBox);
            this.playerInspectPanel.Location = new System.Drawing.Point(708, 13);
            this.playerInspectPanel.Name = "playerInspectPanel";
            this.playerInspectPanel.Size = new System.Drawing.Size(330, 250);
            this.playerInspectPanel.TabIndex = 2;
            // 
            // playerListBox
            // 
            this.playerListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.Location = new System.Drawing.Point(7, 18);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(78, 225);
            this.playerListBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Players";
            // 
            // selectedPlayerDescTextbox
            // 
            this.selectedPlayerDescTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedPlayerDescTextbox.Enabled = false;
            this.selectedPlayerDescTextbox.Location = new System.Drawing.Point(91, 18);
            this.selectedPlayerDescTextbox.Name = "selectedPlayerDescTextbox";
            this.selectedPlayerDescTextbox.Size = new System.Drawing.Size(236, 225);
            this.selectedPlayerDescTextbox.TabIndex = 2;
            this.selectedPlayerDescTextbox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // currentPlayerPanel
            // 
            this.currentPlayerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPlayerPanel.Controls.Add(this.currentPlayerDescTextbox);
            this.currentPlayerPanel.Controls.Add(this.currentTurnLabel);
            this.currentPlayerPanel.Location = new System.Drawing.Point(13, 13);
            this.currentPlayerPanel.Name = "currentPlayerPanel";
            this.currentPlayerPanel.Size = new System.Drawing.Size(689, 250);
            this.currentPlayerPanel.TabIndex = 3;
            // 
            // currentTurnLabel
            // 
            this.currentTurnLabel.AutoSize = true;
            this.currentTurnLabel.Location = new System.Drawing.Point(4, 4);
            this.currentTurnLabel.Name = "currentTurnLabel";
            this.currentTurnLabel.Size = new System.Drawing.Size(135, 13);
            this.currentTurnLabel.TabIndex = 0;
            this.currentTurnLabel.Text = "It is currently nobody\'s turn.";
            // 
            // currentPlayerDescTextbox
            // 
            this.currentPlayerDescTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.currentPlayerDescTextbox.Enabled = false;
            this.currentPlayerDescTextbox.Location = new System.Drawing.Point(7, 20);
            this.currentPlayerDescTextbox.Name = "currentPlayerDescTextbox";
            this.currentPlayerDescTextbox.Size = new System.Drawing.Size(218, 223);
            this.currentPlayerDescTextbox.TabIndex = 1;
            this.currentPlayerDescTextbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 662);
            this.Controls.Add(this.currentPlayerPanel);
            this.Controls.Add(this.playerInspectPanel);
            this.Controls.Add(this.nextTurnButton);
            this.Controls.Add(this.consolePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.consolePanel.ResumeLayout(false);
            this.consolePanel.PerformLayout();
            this.playerInspectPanel.ResumeLayout(false);
            this.playerInspectPanel.PerformLayout();
            this.currentPlayerPanel.ResumeLayout(false);
            this.currentPlayerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel consolePanel;
        private System.Windows.Forms.RichTextBox consoleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextTurnButton;
        private System.Windows.Forms.Panel playerInspectPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.RichTextBox selectedPlayerDescTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel currentPlayerPanel;
        private System.Windows.Forms.RichTextBox currentPlayerDescTextbox;
        private System.Windows.Forms.Label currentTurnLabel;
    }
}

