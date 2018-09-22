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
            this.sortByComboBox = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unsortedListView
            // 
            this.unsortedListView.Location = new System.Drawing.Point(17, 48);
            this.unsortedListView.Name = "unsortedListView";
            this.unsortedListView.Size = new System.Drawing.Size(369, 225);
            this.unsortedListView.TabIndex = 0;
            this.unsortedListView.UseCompatibleStateImageBehavior = false;
            // 
            // sortedListView
            // 
            this.sortedListView.GridLines = true;
            this.sortedListView.LabelWrap = false;
            this.sortedListView.Location = new System.Drawing.Point(409, 48);
            this.sortedListView.Name = "sortedListView";
            this.sortedListView.Size = new System.Drawing.Size(376, 224);
            this.sortedListView.TabIndex = 1;
            this.sortedListView.UseCompatibleStateImageBehavior = false;
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.FormattingEnabled = true;
            this.sortByComboBox.Items.AddRange(new object[] {
            "Name",
            "Max MPH",
            "Horsepower",
            "Price"});
            this.sortByComboBox.Location = new System.Drawing.Point(112, 16);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortByComboBox.TabIndex = 2;
            this.sortByComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(23, 16);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(69, 20);
            this.lblSortBy.TabIndex = 3;
            this.lblSortBy.Text = "Sort By :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 297);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.sortByComboBox);
            this.Controls.Add(this.sortedListView);
            this.Controls.Add(this.unsortedListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView unsortedListView;
        private System.Windows.Forms.ListView sortedListView;
        private System.Windows.Forms.ComboBox sortByComboBox;
        private System.Windows.Forms.Label lblSortBy;
    }
}

