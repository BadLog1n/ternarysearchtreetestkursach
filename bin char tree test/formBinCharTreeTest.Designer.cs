namespace bin_char_test_tree
{
    partial class formBinCharTreeTest
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.btnTraverseTree = new System.Windows.Forms.Button();
            this.cmbWords = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(5, 5);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(661, 530);
            this.txtInput.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(563, 543);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(5, 592);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(420, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(435, 590);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.AutoSize = true;
            this.lblSearchResult.Location = new System.Drawing.Point(543, 596);
            this.lblSearchResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(90, 17);
            this.lblSearchResult.TabIndex = 4;
            this.lblSearchResult.Text = "search result";
            // 
            // btnTraverseTree
            // 
            this.btnTraverseTree.Location = new System.Drawing.Point(16, 543);
            this.btnTraverseTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTraverseTree.Name = "btnTraverseTree";
            this.btnTraverseTree.Size = new System.Drawing.Size(100, 28);
            this.btnTraverseTree.TabIndex = 5;
            this.btnTraverseTree.Text = "traverse tree";
            this.btnTraverseTree.UseVisualStyleBackColor = true;
            this.btnTraverseTree.Click += new System.EventHandler(this.btnTraverseTree_Click);
            // 
            // cmbWords
            // 
            this.cmbWords.FormattingEnabled = true;
            this.cmbWords.Location = new System.Drawing.Point(124, 543);
            this.cmbWords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbWords.Name = "cmbWords";
            this.cmbWords.Size = new System.Drawing.Size(409, 24);
            this.cmbWords.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 159);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // formBinCharTreeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbWords);
            this.Controls.Add(this.btnTraverseTree);
            this.Controls.Add(this.lblSearchResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formBinCharTreeTest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label lblSearchResult;
		private System.Windows.Forms.Button btnTraverseTree;
		private System.Windows.Forms.ComboBox cmbWords;
        private System.Windows.Forms.Button button1;
    }
}

