
namespace ЛР5
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
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dgwLeft = new System.Windows.Forms.DataGridView();
            dgw2 = new System.Windows.Forms.DataGridView();
            cbCriteria = new System.Windows.Forms.ComboBox();
            cbType = new System.Windows.Forms.ComboBox();
            cbFunction = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblQ = new System.Windows.Forms.Label();
            lblS = new System.Windows.Forms.Label();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBox1 = new System.Windows.Forms.GroupBox();
            nudS = new System.Windows.Forms.NumericUpDown();
            nudQ = new System.Windows.Forms.NumericUpDown();
            nudWeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw2).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numericUpDown1.Location = new System.Drawing.Point(211, 46);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(57, 26);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numericUpDown2.Location = new System.Drawing.Point(211, 80);
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(57, 26);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(231, 202, 255);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(488, 524);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(718, 42);
            button2.TabIndex = 5;
            button2.Text = "Рассчитать";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(11, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(188, 18);
            label1.TabIndex = 6;
            label1.Text = "Кол-во альтернатив";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(10, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(168, 18);
            label2.TabIndex = 7;
            label2.Text = "Кол-во критериев";
            // 
            // dgwLeft
            // 
            dgwLeft.AllowUserToAddRows = false;
            dgwLeft.AllowUserToDeleteRows = false;
            dgwLeft.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgwLeft.BackgroundColor = System.Drawing.Color.White;
            dgwLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLeft.Location = new System.Drawing.Point(11, 130);
            dgwLeft.Name = "dgwLeft";
            dgwLeft.RowHeadersWidth = 51;
            dgwLeft.RowTemplate.Height = 29;
            dgwLeft.Size = new System.Drawing.Size(445, 435);
            dgwLeft.TabIndex = 8;
            // 
            // dgw2
            // 
            dgw2.AllowUserToAddRows = false;
            dgw2.AllowUserToDeleteRows = false;
            dgw2.BackgroundColor = System.Drawing.Color.White;
            dgw2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw2.Location = new System.Drawing.Point(488, 184);
            dgw2.Name = "dgw2";
            dgw2.ReadOnly = true;
            dgw2.RowHeadersWidth = 51;
            dgw2.RowTemplate.Height = 29;
            dgw2.Size = new System.Drawing.Size(718, 322);
            dgw2.TabIndex = 9;
            // 
            // cbCriteria
            // 
            cbCriteria.BackColor = System.Drawing.Color.FromArgb(231, 202, 255);
            cbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCriteria.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cbCriteria.FormattingEnabled = true;
            cbCriteria.Location = new System.Drawing.Point(6, 51);
            cbCriteria.Name = "cbCriteria";
            cbCriteria.Size = new System.Drawing.Size(136, 26);
            cbCriteria.TabIndex = 10;
            cbCriteria.SelectedIndexChanged += cbCriteria_SelectedIndexChanged;
            // 
            // cbType
            // 
            cbType.BackColor = System.Drawing.Color.FromArgb(231, 202, 255);
            cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbType.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cbType.FormattingEnabled = true;
            cbType.Location = new System.Drawing.Point(262, 108);
            cbType.Name = "cbType";
            cbType.Size = new System.Drawing.Size(265, 26);
            cbType.TabIndex = 11;
            // 
            // cbFunction
            // 
            cbFunction.BackColor = System.Drawing.Color.FromArgb(231, 202, 255);
            cbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFunction.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cbFunction.FormattingEnabled = true;
            cbFunction.Location = new System.Drawing.Point(262, 50);
            cbFunction.Name = "cbFunction";
            cbFunction.Size = new System.Drawing.Size(440, 26);
            cbFunction.TabIndex = 12;
            cbFunction.SelectedIndexChanged += cbFunction_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(231, 202, 255);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(320, 80);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(136, 30);
            button1.TabIndex = 15;
            button1.Text = "Создать таблицу";
            button1.UseVisualStyleBackColor = false;
            button1.Click += onCreateTable;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(231, 202, 255);
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(593, 106);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(109, 35);
            button3.TabIndex = 16;
            button3.Text = "Задать";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(6, 31);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 18);
            label3.TabIndex = 17;
            label3.Text = "Критерий";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(151, 31);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 18);
            label4.TabIndex = 18;
            label4.Text = "Вес";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(262, 31);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 18);
            label5.TabIndex = 19;
            label5.Text = "Функция";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(262, 89);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(38, 18);
            label6.TabIndex = 20;
            label6.Text = "Тип";
            // 
            // lblQ
            // 
            lblQ.AutoSize = true;
            lblQ.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblQ.Location = new System.Drawing.Point(6, 89);
            lblQ.Name = "lblQ";
            lblQ.Size = new System.Drawing.Size(18, 18);
            lblQ.TabIndex = 21;
            lblQ.Text = "Q";
            // 
            // lblS
            // 
            lblS.AutoSize = true;
            lblS.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblS.Location = new System.Drawing.Point(79, 89);
            lblS.Name = "lblS";
            lblS.Size = new System.Drawing.Size(18, 18);
            lblS.TabIndex = 23;
            lblS.Text = "S";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(232, 247, 255);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1221, 28);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += Load_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += Save_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudS);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(nudQ);
            groupBox1.Controls.Add(lblS);
            groupBox1.Controls.Add(nudWeight);
            groupBox1.Controls.Add(cbType);
            groupBox1.Controls.Add(lblQ);
            groupBox1.Controls.Add(cbCriteria);
            groupBox1.Controls.Add(cbFunction);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(488, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(718, 147);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задание критерия";
            // 
            // nudS
            // 
            nudS.DecimalPlaces = 2;
            nudS.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            nudS.Location = new System.Drawing.Point(79, 110);
            nudS.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudS.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            nudS.Name = "nudS";
            nudS.Size = new System.Drawing.Size(67, 26);
            nudS.TabIndex = 21;
            // 
            // nudQ
            // 
            nudQ.DecimalPlaces = 2;
            nudQ.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            nudQ.Location = new System.Drawing.Point(6, 110);
            nudQ.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudQ.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            nudQ.Name = "nudQ";
            nudQ.Size = new System.Drawing.Size(67, 26);
            nudQ.TabIndex = 21;
            // 
            // nudWeight
            // 
            nudWeight.DecimalPlaces = 2;
            nudWeight.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            nudWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudWeight.Location = new System.Drawing.Point(151, 51);
            nudWeight.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new System.Drawing.Size(96, 26);
            nudWeight.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(232, 247, 255);
            ClientSize = new System.Drawing.Size(1221, 578);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(dgw2);
            Controls.Add(dgwLeft);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Метод PROMETHEE";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudS).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCriteria;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbFunction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgwLeft;
        private System.Windows.Forms.DataGridView dgw2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.NumericUpDown nudQ;
        private System.Windows.Forms.NumericUpDown nudS;
    }
}

