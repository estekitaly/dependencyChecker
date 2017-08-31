namespace ESTEK_DependencyChecker
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDependecyNames = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilesToAnalyze = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnSearchFilesToAnalyze = new System.Windows.Forms.Button();
            this.ofdFilesToAnalyze = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dependency Names (the dlls or files you want to check if they are inside the \"Fil" +
    "es to Analyze\")";
            // 
            // txtDependecyNames
            // 
            this.txtDependecyNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDependecyNames.Location = new System.Drawing.Point(19, 231);
            this.txtDependecyNames.Multiline = true;
            this.txtDependecyNames.Name = "txtDependecyNames";
            this.txtDependecyNames.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDependecyNames.Size = new System.Drawing.Size(501, 178);
            this.txtDependecyNames.TabIndex = 1;
            this.txtDependecyNames.Text = "msvcp120.dll\r\nmsvcr120.dll";
            this.txtDependecyNames.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Files that you want to Analyze";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFilesToAnalyze
            // 
            this.txtFilesToAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilesToAnalyze.Location = new System.Drawing.Point(19, 44);
            this.txtFilesToAnalyze.Multiline = true;
            this.txtFilesToAnalyze.Name = "txtFilesToAnalyze";
            this.txtFilesToAnalyze.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFilesToAnalyze.Size = new System.Drawing.Size(498, 159);
            this.txtFilesToAnalyze.TabIndex = 3;
            this.txtFilesToAnalyze.WordWrap = false;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyze.Location = new System.Drawing.Point(13, 426);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(504, 40);
            this.btnAnalyze.TabIndex = 4;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnSearchFilesToAnalyze
            // 
            this.btnSearchFilesToAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchFilesToAnalyze.Location = new System.Drawing.Point(181, 9);
            this.btnSearchFilesToAnalyze.Name = "btnSearchFilesToAnalyze";
            this.btnSearchFilesToAnalyze.Size = new System.Drawing.Size(336, 23);
            this.btnSearchFilesToAnalyze.TabIndex = 5;
            this.btnSearchFilesToAnalyze.Text = "Add Files...";
            this.btnSearchFilesToAnalyze.UseVisualStyleBackColor = true;
            this.btnSearchFilesToAnalyze.Click += new System.EventHandler(this.btnSearchFilesToAnalyze_Click);
            // 
            // ofdFilesToAnalyze
            // 
            this.ofdFilesToAnalyze.Multiselect = true;
            this.ofdFilesToAnalyze.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdFilesToAnalyze_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 478);
            this.Controls.Add(this.btnSearchFilesToAnalyze);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.txtFilesToAnalyze);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDependecyNames);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(545, 517);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDependecyNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilesToAnalyze;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnSearchFilesToAnalyze;
        private System.Windows.Forms.OpenFileDialog ofdFilesToAnalyze;
    }
}

