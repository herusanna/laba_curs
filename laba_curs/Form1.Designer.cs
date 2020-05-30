namespace laba_curs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genButton = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.RichTextBox();
            this.nameTextBox = new System.Windows.Forms.RichTextBox();
            this.countryListBox = new System.Windows.Forms.ListBox();
            this.typeListBox = new System.Windows.Forms.ListBox();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.passButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputN
            // 
            this.inputN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.inputN.Location = new System.Drawing.Point(122, 45);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(60, 29);
            this.inputN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Количество:";
            // 
            // genButton
            // 
            this.genButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genButton.Location = new System.Drawing.Point(199, 44);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(140, 35);
            this.genButton.TabIndex = 12;
            this.genButton.Text = "Сгенерировать";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.infoTextBox.Location = new System.Drawing.Point(345, 169);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(417, 172);
            this.infoTextBox.TabIndex = 14;
            this.infoTextBox.Text = "";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameTextBox.Location = new System.Drawing.Point(12, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(327, 256);
            this.nameTextBox.TabIndex = 19;
            this.nameTextBox.Text = "";
            // 
            // countryListBox
            // 
            this.countryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.countryListBox.FormattingEnabled = true;
            this.countryListBox.ItemHeight = 20;
            this.countryListBox.Location = new System.Drawing.Point(345, 39);
            this.countryListBox.Name = "countryListBox";
            this.countryListBox.Size = new System.Drawing.Size(135, 124);
            this.countryListBox.TabIndex = 20;
            // 
            // typeListBox
            // 
            this.typeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typeListBox.FormattingEnabled = true;
            this.typeListBox.ItemHeight = 20;
            this.typeListBox.Location = new System.Drawing.Point(486, 39);
            this.typeListBox.Name = "typeListBox";
            this.typeListBox.Size = new System.Drawing.Size(135, 124);
            this.typeListBox.TabIndex = 21;
            this.typeListBox.SelectedIndexChanged += new System.EventHandler(this.typeListBox_SelectedIndexChanged);
            // 
            // nameListBox
            // 
            this.nameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 20;
            this.nameListBox.Location = new System.Drawing.Point(627, 39);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(135, 124);
            this.nameListBox.TabIndex = 22;
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.openButton.Location = new System.Drawing.Point(618, 347);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(72, 35);
            this.openButton.TabIndex = 23;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.Location = new System.Drawing.Point(540, 347);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(72, 35);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // passButton
            // 
            this.passButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passButton.Location = new System.Drawing.Point(73, 347);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(168, 35);
            this.passButton.TabIndex = 25;
            this.passButton.Text = "Добавить пароль";
            this.passButton.UseVisualStyleBackColor = true;
            this.passButton.Click += new System.EventHandler(this.passButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitButton.Location = new System.Drawing.Point(696, 347);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(72, 35);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(404, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Просмотр призеров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(615, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Удаление по фамилии:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(345, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "по стране:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(484, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "по виду спорта:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 402);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.passButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.typeListBox);
            this.Controls.Add(this.countryListBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.RichTextBox infoTextBox;
        private System.Windows.Forms.RichTextBox nameTextBox;
        private System.Windows.Forms.ListBox countryListBox;
        private System.Windows.Forms.ListBox typeListBox;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button passButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

