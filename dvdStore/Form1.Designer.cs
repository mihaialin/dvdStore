namespace dvdStore
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
            this.dvdTitleBox = new System.Windows.Forms.TextBox();
            this.releaseYear = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.viewerRating = new System.Windows.Forms.TextBox();
            this.newLanguage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.languageList = new System.Windows.Forms.ListBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dvdTitleBox
            // 
            this.dvdTitleBox.Location = new System.Drawing.Point(27, 51);
            this.dvdTitleBox.Name = "dvdTitleBox";
            this.dvdTitleBox.Size = new System.Drawing.Size(135, 20);
            this.dvdTitleBox.TabIndex = 0;
            // 
            // releaseYear
            // 
            this.releaseYear.Location = new System.Drawing.Point(27, 114);
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Size = new System.Drawing.Size(135, 20);
            this.releaseYear.TabIndex = 1;
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(27, 177);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(135, 20);
            this.publisher.TabIndex = 2;
            // 
            // viewerRating
            // 
            this.viewerRating.Location = new System.Drawing.Point(27, 242);
            this.viewerRating.Name = "viewerRating";
            this.viewerRating.Size = new System.Drawing.Size(135, 20);
            this.viewerRating.TabIndex = 3;
            // 
            // newLanguage
            // 
            this.newLanguage.Location = new System.Drawing.Point(456, 51);
            this.newLanguage.Name = "newLanguage";
            this.newLanguage.Size = new System.Drawing.Size(135, 20);
            this.newLanguage.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DVD Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Release Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Publisher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Viewer Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "New Language";
            // 
            // languageList
            // 
            this.languageList.FormattingEnabled = true;
            this.languageList.Location = new System.Drawing.Point(223, 51);
            this.languageList.Name = "languageList";
            this.languageList.Size = new System.Drawing.Size(165, 212);
            this.languageList.TabIndex = 10;
            this.languageList.SelectedIndexChanged += new System.EventHandler(this.languageList_SelectedIndexChanged);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(516, 310);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = ">>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(426, 310);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 12;
            this.previousButton.Text = "<<";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(456, 88);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(135, 23);
            this.modifyButton.TabIndex = 13;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(426, 269);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(165, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(426, 239);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(165, 23);
            this.load_button.TabIndex = 15;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 345);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.languageList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newLanguage);
            this.Controls.Add(this.viewerRating);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.releaseYear);
            this.Controls.Add(this.dvdTitleBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dvdTitleBox;
        private System.Windows.Forms.TextBox releaseYear;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.TextBox viewerRating;
        private System.Windows.Forms.TextBox newLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox languageList;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button load_button;
    }
}

