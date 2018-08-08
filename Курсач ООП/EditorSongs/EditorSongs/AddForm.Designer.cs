namespace EditorSongs
{
    partial class AddForm
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
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewAuthor = new System.Windows.Forms.TextBox();
            this.rtbNewText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntAddNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(51, 6);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(229, 20);
            this.tbNewName.TabIndex = 0;
            this.tbNewName.TextChanged += new System.EventHandler(this.tbNewName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Автор";
            // 
            // tbNewAuthor
            // 
            this.tbNewAuthor.Location = new System.Drawing.Point(51, 41);
            this.tbNewAuthor.Name = "tbNewAuthor";
            this.tbNewAuthor.Size = new System.Drawing.Size(229, 20);
            this.tbNewAuthor.TabIndex = 3;
            this.tbNewAuthor.TextChanged += new System.EventHandler(this.tbNewAuthor_TextChanged);
            // 
            // rtbNewText
            // 
            this.rtbNewText.Location = new System.Drawing.Point(5, 91);
            this.rtbNewText.Name = "rtbNewText";
            this.rtbNewText.Size = new System.Drawing.Size(275, 236);
            this.rtbNewText.TabIndex = 4;
            this.rtbNewText.Text = "";
            this.rtbNewText.TextChanged += new System.EventHandler(this.rtbNewText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Текст пісні";
            // 
            // bntAddNew
            // 
            this.bntAddNew.Location = new System.Drawing.Point(5, 333);
            this.bntAddNew.Name = "bntAddNew";
            this.bntAddNew.Size = new System.Drawing.Size(275, 23);
            this.bntAddNew.TabIndex = 6;
            this.bntAddNew.Text = "Додати";
            this.bntAddNew.UseVisualStyleBackColor = true;
            this.bntAddNew.Click += new System.EventHandler(this.bntAddNew_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 355);
            this.Controls.Add(this.bntAddNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbNewText);
            this.Controls.Add(this.tbNewAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNewName);
            this.Name = "AddForm";
            this.Text = "Додавання пісні";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewAuthor;
        private System.Windows.Forms.RichTextBox rtbNewText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntAddNew;
    }
}