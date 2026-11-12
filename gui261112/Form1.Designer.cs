namespace gui261112
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
            btn_add = new Button();
            btn_del = new Button();
            btn_all_del = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Location = new Point(280, 100);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(143, 23);
            btn_add.TabIndex = 0;
            btn_add.Text = "Hozzáadás";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(280, 160);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(143, 23);
            btn_del.TabIndex = 1;
            btn_del.Text = "Törlés";
            btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_all_del
            // 
            btn_all_del.Location = new Point(280, 223);
            btn_all_del.Name = "btn_all_del";
            btn_all_del.Size = new Size(143, 23);
            btn_all_del.TabIndex = 2;
            btn_all_del.Text = "Összes törlése";
            btn_all_del.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(29, 100);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(236, 304);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 52);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Írja be ide a nevét";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 450);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(btn_all_del);
            Controls.Add(btn_del);
            Controls.Add(btn_add);
            Name = "Form1";
            Text = "Bevásárló lista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add;
        private Button btn_del;
        private Button btn_all_del;
        private ListBox listBox1;
        private TextBox textBox1;
    }
}
