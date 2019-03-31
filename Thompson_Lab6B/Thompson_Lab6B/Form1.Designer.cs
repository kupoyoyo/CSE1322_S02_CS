namespace Thompson_Lab6B
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
            this.T_fileSearch = new System.Windows.Forms.TextBox();
            this.B_openFile = new System.Windows.Forms.Button();
            this.T_fileOutput = new System.Windows.Forms.TextBox();
            this.B_saveFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_saveComplete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // T_fileSearch
            // 
            this.T_fileSearch.Location = new System.Drawing.Point(35, 37);
            this.T_fileSearch.Name = "T_fileSearch";
            this.T_fileSearch.Size = new System.Drawing.Size(467, 29);
            this.T_fileSearch.TabIndex = 0;
            // 
            // B_openFile
            // 
            this.B_openFile.Location = new System.Drawing.Point(524, 37);
            this.B_openFile.Name = "B_openFile";
            this.B_openFile.Size = new System.Drawing.Size(99, 42);
            this.B_openFile.TabIndex = 1;
            this.B_openFile.Text = "Open";
            this.B_openFile.UseVisualStyleBackColor = true;
            this.B_openFile.Click += new System.EventHandler(this.B_openFile_Click);
            // 
            // T_fileOutput
            // 
            this.T_fileOutput.Location = new System.Drawing.Point(35, 122);
            this.T_fileOutput.Multiline = true;
            this.T_fileOutput.Name = "T_fileOutput";
            this.T_fileOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.T_fileOutput.Size = new System.Drawing.Size(737, 276);
            this.T_fileOutput.TabIndex = 2;
            this.T_fileOutput.WordWrap = false;
            // 
            // B_saveFile
            // 
            this.B_saveFile.Location = new System.Drawing.Point(35, 415);
            this.B_saveFile.Name = "B_saveFile";
            this.B_saveFile.Size = new System.Drawing.Size(90, 40);
            this.B_saveFile.TabIndex = 3;
            this.B_saveFile.Text = "Save";
            this.B_saveFile.UseVisualStyleBackColor = true;
            this.B_saveFile.Click += new System.EventHandler(this.B_saveFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "File Output";
            // 
            // L_saveComplete
            // 
            this.L_saveComplete.AutoSize = true;
            this.L_saveComplete.Location = new System.Drawing.Point(166, 423);
            this.L_saveComplete.Name = "L_saveComplete";
            this.L_saveComplete.Size = new System.Drawing.Size(110, 25);
            this.L_saveComplete.TabIndex = 6;
            this.L_saveComplete.Text = "saveStatus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.L_saveComplete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_saveFile);
            this.Controls.Add(this.T_fileOutput);
            this.Controls.Add(this.B_openFile);
            this.Controls.Add(this.T_fileSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T_fileSearch;
        private System.Windows.Forms.Button B_openFile;
        private System.Windows.Forms.TextBox T_fileOutput;
        private System.Windows.Forms.Button B_saveFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_saveComplete;
    }
}

