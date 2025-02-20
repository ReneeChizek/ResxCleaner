namespace ResxCleaner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectFile = new Button();
            lblFolder = new Label();
            openFileDialog1 = new OpenFileDialog();
            lblFilename = new Label();
            btnSave = new Button();
            btnHelp = new Button();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(76, 53);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(75, 23);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.BorderStyle = BorderStyle.Fixed3D;
            lblFolder.Location = new Point(194, 57);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(2, 17);
            lblFolder.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "RESX|*.resx";
            openFileDialog1.Title = "Select RESX file";
            // 
            // lblFilename
            // 
            lblFilename.AutoSize = true;
            lblFilename.BorderStyle = BorderStyle.Fixed3D;
            lblFilename.Location = new Point(194, 85);
            lblFilename.Name = "lblFilename";
            lblFilename.Size = new Size(2, 17);
            lblFilename.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(341, 372);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(642, 53);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(75, 23);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "About";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHelp);
            Controls.Add(btnSave);
            Controls.Add(lblFilename);
            Controls.Add(lblFolder);
            Controls.Add(btnSelectFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private Label lblFolder;
        private OpenFileDialog openFileDialog1;
        private Label lblFilename;
        private Button btnSave;
        private Button btnHelp;
    }
}
