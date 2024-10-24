namespace To_Do_List
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
            Add = new Button();
            inputTextBox = new TextBox();
            checkedListBox = new CheckedListBox();
            buttonSave = new Button();
            buttonUpload = new Button();
            label1 = new Label();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(192, 255, 192);
            Add.BackgroundImageLayout = ImageLayout.None;
            Add.Location = new Point(393, 273);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 0;
            Add.Text = "ADD";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(493, 273);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(337, 27);
            inputTextBox.TabIndex = 1;
            inputTextBox.TextAlign = HorizontalAlignment.Center;
            inputTextBox.TextChanged += input_TextChanged;
            // 
            // checkedListBox
            // 
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(193, 317);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(652, 290);
            checkedListBox.TabIndex = 2;
            checkedListBox.SelectedIndexChanged += checkedListBox_SelectedIndexChanged;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(192, 255, 255);
            buttonSave.BackgroundImageLayout = ImageLayout.None;
            buttonSave.Location = new Point(193, 273);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonUpload
            // 
            buttonUpload.BackColor = Color.FromArgb(255, 128, 128);
            buttonUpload.BackgroundImageLayout = ImageLayout.None;
            buttonUpload.Location = new Point(293, 273);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(94, 29);
            buttonUpload.TabIndex = 4;
            buttonUpload.Text = "Upload";
            buttonUpload.UseVisualStyleBackColor = false;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(393, 103);
            label1.Name = "label1";
            label1.Size = new Size(276, 67);
            label1.TabIndex = 5;
            label1.Text = "To Do List ";
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(192, 192, 255);
            buttonClear.Location = new Point(193, 613);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 28);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 694);
            Controls.Add(buttonClear);
            Controls.Add(label1);
            Controls.Add(buttonUpload);
            Controls.Add(buttonSave);
            Controls.Add(checkedListBox);
            Controls.Add(inputTextBox);
            Controls.Add(Add);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add;
        private TextBox inputTextBox;
        private CheckedListBox checkedListBox;
        private Button buttonSave;
        private Button buttonUpload;
        private Label label1;
        private Button buttonClear;
    }
}
