namespace DZ1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addBut = new System.Windows.Forms.Button();
            this.deleteBut = new System.Windows.Forms.Button();
            this.editBut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uptBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(44, 168);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Контакты";
            // 
            // addBut
            // 
            this.addBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBut.Location = new System.Drawing.Point(636, 191);
            this.addBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(146, 40);
            this.addBut.TabIndex = 2;
            this.addBut.Text = "Добавить контакт";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // deleteBut
            // 
            this.deleteBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBut.Location = new System.Drawing.Point(636, 298);
            this.deleteBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBut.Name = "deleteBut";
            this.deleteBut.Size = new System.Drawing.Size(146, 40);
            this.deleteBut.TabIndex = 3;
            this.deleteBut.Text = "Удалить";
            this.deleteBut.UseVisualStyleBackColor = true;
            this.deleteBut.Click += new System.EventHandler(this.deleteBut_Click);
            // 
            // editBut
            // 
            this.editBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBut.Location = new System.Drawing.Point(636, 239);
            this.editBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editBut.Name = "editBut";
            this.editBut.Size = new System.Drawing.Size(146, 40);
            this.editBut.TabIndex = 4;
            this.editBut.Text = "Изменить";
            this.editBut.UseVisualStyleBackColor = true;
            this.editBut.Click += new System.EventHandler(this.editBut_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(199, 108);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 35);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Найти контакт";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(623, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 238);
            this.label4.TabIndex = 8;
            // 
            // uptBut
            // 
            this.uptBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uptBut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uptBut.Location = new System.Drawing.Point(480, 118);
            this.uptBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uptBut.Name = "uptBut";
            this.uptBut.Size = new System.Drawing.Size(122, 42);
            this.uptBut.TabIndex = 13;
            this.uptBut.Text = "Обновить";
            this.uptBut.UseVisualStyleBackColor = true;
            this.uptBut.Click += new System.EventHandler(this.uptBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBut.Location = new System.Drawing.Point(636, 345);
            this.saveBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(146, 40);
            this.saveBut.TabIndex = 14;
            this.saveBut.Text = "Сохранить";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(176, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID";
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTB.Location = new System.Drawing.Point(226, 429);
            this.idTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(177, 35);
            this.idTB.TabIndex = 16;
            // 
            // phoneTB
            // 
            this.phoneTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTB.Location = new System.Drawing.Point(226, 519);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(177, 35);
            this.phoneTB.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(39, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "Номер телефона";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTB.Location = new System.Drawing.Point(226, 474);
            this.nameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(177, 35);
            this.nameTB.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(158, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "Имя";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(438, 471);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(808, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.uptBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editBut);
            this.Controls.Add(this.deleteBut);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контакты";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Button deleteBut;
        private System.Windows.Forms.Button editBut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uptBut;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

