namespace MyEditor
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(160, 150);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(77, 33);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Files";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(156, 96);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(121, 20);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Select a text file";
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(326, 19);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(462, 419);
            this.rtb.TabIndex = 2;
            this.rtb.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button btnSave;
    }
}

