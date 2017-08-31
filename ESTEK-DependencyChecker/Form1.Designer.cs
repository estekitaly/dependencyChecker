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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dependency Names (the dlls or files you want to check if they are inside the \"Fil" +
    "es to Analyze\")";
            // 
            // txtDependecyNames
            // 
            this.txtDependecyNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtDependecyNames, 2);
            this.txtDependecyNames.Location = new System.Drawing.Point(3, 297);
            this.txtDependecyNames.Multiline = true;
            this.txtDependecyNames.Name = "txtDependecyNames";
            this.txtDependecyNames.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDependecyNames.Size = new System.Drawing.Size(703, 143);
            this.txtDependecyNames.TabIndex = 1;
            this.txtDependecyNames.Text = "msvcp120.dll\r\nmsvcr120.dll";
            this.txtDependecyNames.WordWrap = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Files that you want to Analyze";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFilesToAnalyze
            // 
            this.txtFilesToAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtFilesToAnalyze, 2);
            this.txtFilesToAnalyze.Location = new System.Drawing.Point(3, 36);
            this.txtFilesToAnalyze.Multiline = true;
            this.txtFilesToAnalyze.Name = "txtFilesToAnalyze";
            this.txtFilesToAnalyze.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFilesToAnalyze.Size = new System.Drawing.Size(703, 242);
            this.txtFilesToAnalyze.TabIndex = 3;
            this.txtFilesToAnalyze.WordWrap = false;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnAnalyze, 2);
            this.btnAnalyze.Location = new System.Drawing.Point(9, 446);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(691, 40);
            this.btnAnalyze.TabIndex = 4;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnSearchFilesToAnalyze
            // 
            this.btnSearchFilesToAnalyze.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchFilesToAnalyze.Location = new System.Drawing.Point(547, 3);
            this.btnSearchFilesToAnalyze.Name = "btnSearchFilesToAnalyze";
            this.btnSearchFilesToAnalyze.Size = new System.Drawing.Size(73, 27);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnAnalyze, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDependecyNames, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearchFilesToAnalyze, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFilesToAnalyze, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 490);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(743, 556);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDependecyNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilesToAnalyze;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnSearchFilesToAnalyze;
        private System.Windows.Forms.OpenFileDialog ofdFilesToAnalyze;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

