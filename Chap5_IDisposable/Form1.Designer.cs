namespace Chap5_IDisposable
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
            this.createAndDisposeButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.createButton = new System.Windows.Forms.Button();
            this.createAndDispose = new System.Windows.Forms.Button();
            this.collectGarbageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createAndDisposeButton
            // 
            this.createAndDisposeButton.Location = new System.Drawing.Point(23, 23);
            this.createAndDisposeButton.Name = "createAndDisposeButton";
            this.createAndDisposeButton.Size = new System.Drawing.Size(153, 23);
            this.createAndDisposeButton.TabIndex = 0;
            this.createAndDisposeButton.Text = "Create And Dispose";
            this.createAndDisposeButton.UseVisualStyleBackColor = true;
            this.createAndDisposeButton.Click += new System.EventHandler(this.createAndDisposeButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(195, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 225);
            this.listBox1.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(23, 62);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(153, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // createAndDispose
            // 
            this.createAndDispose.Location = new System.Drawing.Point(23, 105);
            this.createAndDispose.Name = "createAndDispose";
            this.createAndDispose.Size = new System.Drawing.Size(153, 23);
            this.createAndDispose.TabIndex = 3;
            this.createAndDispose.Text = "Create And Dispose";
            this.createAndDispose.UseVisualStyleBackColor = true;
            // 
            // collectGarbageButton
            // 
            this.collectGarbageButton.Location = new System.Drawing.Point(23, 149);
            this.collectGarbageButton.Name = "collectGarbageButton";
            this.collectGarbageButton.Size = new System.Drawing.Size(153, 23);
            this.collectGarbageButton.TabIndex = 4;
            this.collectGarbageButton.Text = "Collect Garbage";
            this.collectGarbageButton.UseVisualStyleBackColor = true;
            this.collectGarbageButton.Click += new System.EventHandler(this.collectGarbageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 261);
            this.Controls.Add(this.collectGarbageButton);
            this.Controls.Add(this.createAndDispose);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.createAndDisposeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAndDisposeButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button createAndDispose;
        private System.Windows.Forms.Button collectGarbageButton;
    }
}

