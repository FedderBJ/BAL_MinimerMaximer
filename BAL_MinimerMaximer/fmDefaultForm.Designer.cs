namespace BAL_MinimerMaximer
{
    partial class fmDefaultForm
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
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.gbLines = new System.Windows.Forms.GroupBox();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHeader
            // 
            this.gbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHeader.Location = new System.Drawing.Point(0, 0);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(684, 173);
            this.gbHeader.TabIndex = 0;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "Group Box 1 (Header Data)";
            // 
            // gbLines
            // 
            this.gbLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLines.Location = new System.Drawing.Point(0, 173);
            this.gbLines.Name = "gbLines";
            this.gbLines.Size = new System.Drawing.Size(684, 316);
            this.gbLines.TabIndex = 1;
            this.gbLines.TabStop = false;
            this.gbLines.Text = "Group Box 1 (Til Linjer)";
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.button3);
            this.gbButtons.Controls.Add(this.btnKeyboard);
            this.gbButtons.Controls.Add(this.btnClose);
            this.gbButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbButtons.Location = new System.Drawing.Point(0, 424);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(684, 65);
            this.gbButtons.TabIndex = 2;
            this.gbButtons.TabStop = false;
            this.gbButtons.Text = "Group Box 3 (Evt. til Knapper)";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(415, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKeyboard.Location = new System.Drawing.Point(507, 29);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(75, 23);
            this.btnKeyboard.TabIndex = 1;
            this.btnKeyboard.Text = "&Tastatur";
            this.btnKeyboard.UseVisualStyleBackColor = true;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(597, 29);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Luk";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fmDefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 489);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gbLines);
            this.Controls.Add(this.gbHeader);
            this.Name = "fmDefaultForm";
            this.Text = "Default Form Caption";
            this.gbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.GroupBox gbLines;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.Button btnClose;
    }
}

