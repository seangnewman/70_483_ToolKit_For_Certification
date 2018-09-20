namespace Chap5_ComparingCars
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
            this.unsortedListView = new System.Windows.Forms.ListView();
            this.sortedListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // unsortedListView
            // 
            this.unsortedListView.Location = new System.Drawing.Point(24, 24);
            this.unsortedListView.Name = "unsortedListView";
            this.unsortedListView.Size = new System.Drawing.Size(369, 225);
            this.unsortedListView.TabIndex = 0;
            this.unsortedListView.UseCompatibleStateImageBehavior = false;
            // 
            // sortedListView
            // 
            this.sortedListView.GridLines = true;
            this.sortedListView.LabelWrap = false;
            this.sortedListView.Location = new System.Drawing.Point(416, 24);
            this.sortedListView.Name = "sortedListView";
            this.sortedListView.Size = new System.Drawing.Size(376, 224);
            this.sortedListView.TabIndex = 1;
            this.sortedListView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 261);
            this.Controls.Add(this.sortedListView);
            this.Controls.Add(this.unsortedListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView unsortedListView;
        private System.Windows.Forms.ListView sortedListView;
    }
}

