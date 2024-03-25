namespace dictionaries
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
            addButton = new Button();
            contactListBox = new ListBox();
            editButton = new Button();
            deleteButton = new Button();
            label1 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            searchTextBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(20, 200);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 0;
            addButton.Text = "додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // contactListBox
            // 
            contactListBox.FormattingEnabled = true;
            contactListBox.ItemHeight = 15;
            contactListBox.Location = new Point(140, 20);
            contactListBox.Name = "contactListBox";
            contactListBox.Size = new Size(120, 259);
            contactListBox.TabIndex = 1;
            contactListBox.SelectedIndexChanged += contactListBox_SelectedIndexChanged;
            // 
            // editButton
            // 
            editButton.Location = new Point(20, 230);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 2;
            editButton.Text = "редагувати";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(20, 260);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 80);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 4;
            label1.Text = "Ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 140);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Телефон";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(20, 100);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 6;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(20, 160);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(100, 23);
            phoneNumberTextBox.TabIndex = 7;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(20, 40);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(100, 23);
            searchTextBox.TabIndex = 8;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 20);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 9;
            label3.Text = "Пошук";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 301);
            Controls.Add(label3);
            Controls.Add(searchTextBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(contactListBox);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private ListBox contactListBox;
        private Button editButton;
        private Button deleteButton;
        private Label label1;
        private Label label2;
        private TextBox nameTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox searchTextBox;
        private Label label3;
    }
}
