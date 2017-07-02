namespace WindowsFormsApplication10
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.b_CreateQR = new System.Windows.Forms.Button();
            this.b_SaveQR = new System.Windows.Forms.Button();
            this.b_LoadQR = new System.Windows.Forms.Button();
            this.b_Recognise = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 206);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(221, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите текст";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(221, 28);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(156, 20);
            this.tb.TabIndex = 2;
            // 
            // b_CreateQR
            // 
            this.b_CreateQR.Location = new System.Drawing.Point(221, 83);
            this.b_CreateQR.Name = "b_CreateQR";
            this.b_CreateQR.Size = new System.Drawing.Size(156, 23);
            this.b_CreateQR.TabIndex = 3;
            this.b_CreateQR.Text = "Создать QR-код";
            this.b_CreateQR.UseVisualStyleBackColor = true;
            this.b_CreateQR.Click += new System.EventHandler(this.button_Click);
            // 
            // b_SaveQR
            // 
            this.b_SaveQR.Location = new System.Drawing.Point(221, 112);
            this.b_SaveQR.Name = "b_SaveQR";
            this.b_SaveQR.Size = new System.Drawing.Size(156, 23);
            this.b_SaveQR.TabIndex = 4;
            this.b_SaveQR.Text = "Сохранить QR-код";
            this.b_SaveQR.UseVisualStyleBackColor = true;
            this.b_SaveQR.Click += new System.EventHandler(this.button_Click);
            // 
            // b_LoadQR
            // 
            this.b_LoadQR.Location = new System.Drawing.Point(221, 141);
            this.b_LoadQR.Name = "b_LoadQR";
            this.b_LoadQR.Size = new System.Drawing.Size(156, 23);
            this.b_LoadQR.TabIndex = 5;
            this.b_LoadQR.Text = "Загрузить QR-код";
            this.b_LoadQR.UseVisualStyleBackColor = true;
            this.b_LoadQR.Click += new System.EventHandler(this.button_Click);
            // 
            // b_Recognise
            // 
            this.b_Recognise.Location = new System.Drawing.Point(221, 54);
            this.b_Recognise.Name = "b_Recognise";
            this.b_Recognise.Size = new System.Drawing.Size(156, 23);
            this.b_Recognise.TabIndex = 6;
            this.b_Recognise.Text = "Распознать QR-код";
            this.b_Recognise.UseVisualStyleBackColor = true;
            this.b_Recognise.Click += new System.EventHandler(this.button_Click);
            // 
            // sfd
            // 
            this.sfd.Filter = "PNG(*.png)|*.png";
            // 
            // ofd
            // 
            this.ofd.Filter = "PNG(*.png)|*.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 229);
            this.Controls.Add(this.b_Recognise);
            this.Controls.Add(this.b_LoadQR);
            this.Controls.Add(this.b_SaveQR);
            this.Controls.Add(this.b_CreateQR);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "QR-code";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button b_CreateQR;
        private System.Windows.Forms.Button b_SaveQR;
        private System.Windows.Forms.Button b_LoadQR;
        private System.Windows.Forms.Button b_Recognise;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

