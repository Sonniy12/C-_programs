namespace Storage
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
            this.File_size = new System.Windows.Forms.NumericUpDown();
            this.USB_size = new System.Windows.Forms.NumericUpDown();
            this.DVD_size = new System.Windows.Forms.NumericUpDown();
            this.HDD_size = new System.Windows.Forms.NumericUpDown();
            this.File = new System.Windows.Forms.Label();
            this.USB = new System.Windows.Forms.Label();
            this.DVD = new System.Windows.Forms.Label();
            this.HDD = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Inform = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this._usb = new System.Windows.Forms.Button();
            this._dvd = new System.Windows.Forms.Button();
            this._hdd = new System.Windows.Forms.Button();
            this._file = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.File_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USB_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVD_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDD_size)).BeginInit();
            this.SuspendLayout();
            // 
            // File_size
            // 
            this.File_size.Location = new System.Drawing.Point(182, 32);
            this.File_size.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.File_size.Name = "File_size";
            this.File_size.Size = new System.Drawing.Size(120, 26);
            this.File_size.TabIndex = 0;
            // 
            // USB_size
            // 
            this.USB_size.Location = new System.Drawing.Point(182, 207);
            this.USB_size.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.USB_size.Name = "USB_size";
            this.USB_size.Size = new System.Drawing.Size(120, 26);
            this.USB_size.TabIndex = 1;
            // 
            // DVD_size
            // 
            this.DVD_size.Location = new System.Drawing.Point(182, 305);
            this.DVD_size.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.DVD_size.Name = "DVD_size";
            this.DVD_size.Size = new System.Drawing.Size(120, 26);
            this.DVD_size.TabIndex = 2;
            // 
            // HDD_size
            // 
            this.HDD_size.Location = new System.Drawing.Point(182, 454);
            this.HDD_size.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HDD_size.Name = "HDD_size";
            this.HDD_size.Size = new System.Drawing.Size(120, 26);
            this.HDD_size.TabIndex = 3;
            // 
            // File
            // 
            this.File.AutoSize = true;
            this.File.Location = new System.Drawing.Point(10, 32);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(155, 20);
            this.File.TabIndex = 4;
            this.File.Text = "размер файла в Гб";
            // 
            // USB
            // 
            this.USB.AutoSize = true;
            this.USB.Location = new System.Drawing.Point(10, 213);
            this.USB.Name = "USB";
            this.USB.Size = new System.Drawing.Size(138, 20);
            this.USB.TabIndex = 5;
            this.USB.Text = "Размер USB в Гб";
            // 
            // DVD
            // 
            this.DVD.Location = new System.Drawing.Point(-1, 283);
            this.DVD.Name = "DVD";
            this.DVD.Size = new System.Drawing.Size(137, 106);
            this.DVD.TabIndex = 6;
            this.DVD.Text = " DVD - диск: тип (односторонний (4.7 Гб)/двусторонний (9 Гб))";
            // 
            // HDD
            // 
            this.HDD.AutoSize = true;
            this.HDD.Location = new System.Drawing.Point(8, 454);
            this.HDD.Name = "HDD";
            this.HDD.Size = new System.Drawing.Size(140, 20);
            this.HDD.TabIndex = 7;
            this.HDD.Text = "Размер HDD в Гб";
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Result.Location = new System.Drawing.Point(711, 42);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(411, 501);
            this.Result.TabIndex = 12;
            this.Result.Text = "Result";
            // 
            // Inform
            // 
            this.Inform.Location = new System.Drawing.Point(455, 445);
            this.Inform.Name = "Inform";
            this.Inform.Size = new System.Drawing.Size(215, 76);
            this.Inform.TabIndex = 13;
            this.Inform.Text = "вывод информации о носителях";
            this.Inform.UseVisualStyleBackColor = true;
            this.Inform.Click += new System.EventHandler(this.Inform_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 76);
            this.button1.TabIndex = 14;
            this.button1.Text = "расчет общего количества памяти всех устройств";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 76);
            this.button2.TabIndex = 15;
            this.button2.Text = "копирование информации на устройства";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(455, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 76);
            this.button3.TabIndex = 16;
            this.button3.Text = "расчет времени необходимого для копирования";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(455, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 76);
            this.button4.TabIndex = 17;
            this.button4.Text = " расчет необходимого количества носителей ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // _usb
            // 
            this._usb.Location = new System.Drawing.Point(342, 216);
            this._usb.Name = "_usb";
            this._usb.Size = new System.Drawing.Size(75, 31);
            this._usb.TabIndex = 18;
            this._usb.Text = "USB";
            this._usb.UseVisualStyleBackColor = true;
            this._usb.Click += new System.EventHandler(this._usb_Click);
            // 
            // _dvd
            // 
            this._dvd.Location = new System.Drawing.Point(342, 308);
            this._dvd.Name = "_dvd";
            this._dvd.Size = new System.Drawing.Size(75, 32);
            this._dvd.TabIndex = 19;
            this._dvd.Text = "DVD";
            this._dvd.UseVisualStyleBackColor = true;
            this._dvd.Click += new System.EventHandler(this._dvd_Click);
            // 
            // _hdd
            // 
            this._hdd.Location = new System.Drawing.Point(342, 451);
            this._hdd.Name = "_hdd";
            this._hdd.Size = new System.Drawing.Size(75, 29);
            this._hdd.TabIndex = 20;
            this._hdd.Text = "HDD";
            this._hdd.UseVisualStyleBackColor = true;
            this._hdd.Click += new System.EventHandler(this._hdd_Click);
            // 
            // _file
            // 
            this._file.Location = new System.Drawing.Point(329, 32);
            this._file.Name = "_file";
            this._file.Size = new System.Drawing.Size(75, 31);
            this._file.TabIndex = 21;
            this._file.Text = "File";
            this._file.UseVisualStyleBackColor = true;
            this._file.Click += new System.EventHandler(this._file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 582);
            this.Controls.Add(this._file);
            this.Controls.Add(this._hdd);
            this.Controls.Add(this._dvd);
            this.Controls.Add(this._usb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Inform);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.HDD);
            this.Controls.Add(this.DVD);
            this.Controls.Add(this.USB);
            this.Controls.Add(this.File);
            this.Controls.Add(this.HDD_size);
            this.Controls.Add(this.DVD_size);
            this.Controls.Add(this.USB_size);
            this.Controls.Add(this.File_size);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.File_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USB_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVD_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDD_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown File_size;
        private System.Windows.Forms.NumericUpDown USB_size;
        private System.Windows.Forms.NumericUpDown DVD_size;
        private System.Windows.Forms.NumericUpDown HDD_size;
        private System.Windows.Forms.Label File;
        private System.Windows.Forms.Label USB;
        private System.Windows.Forms.Label DVD;
        private System.Windows.Forms.Label HDD;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Inform;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button _usb;
        private System.Windows.Forms.Button _dvd;
        private System.Windows.Forms.Button _hdd;
        private System.Windows.Forms.Button _file;
        // private System.Windows.Forms.Button button1;
    }
}

