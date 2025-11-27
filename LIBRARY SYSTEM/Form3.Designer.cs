namespace LIBRARY_SYSTEM
{
    partial class Form3
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
            panel2 = new Panel();
            btnReturn = new Button();
            txtBOOKID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            dataGridViewRecords = new DataGridView();
            label9 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBookIDBorrow = new TextBox();
            label5 = new Label();
            btnBorrow = new Button();
            panel1 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecords).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(txtBOOKID);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(2, 188);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(911, 199);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.LightGreen;
            btnReturn.Location = new Point(431, 92);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(86, 31);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // txtBOOKID
            // 
            txtBOOKID.Location = new Point(101, 67);
            txtBOOKID.Margin = new Padding(3, 4, 3, 4);
            txtBOOKID.Name = "txtBOOKID";
            txtBOOKID.Size = new Size(292, 27);
            txtBOOKID.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Sienna;
            label8.Location = new Point(30, 133);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 2;
            label8.Text = "Return Date : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Sienna;
            label7.Location = new Point(30, 71);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 1;
            label7.Text = "Book ID : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(30, 23);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 0;
            label6.Text = "Return : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 404);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FloralWhite;
            panel3.Controls.Add(dataGridViewRecords);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 395);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(805, 205);
            panel3.TabIndex = 3;
            // 
            // dataGridViewRecords
            // 
            dataGridViewRecords.BackgroundColor = Color.Gainsboro;
            dataGridViewRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecords.Location = new Point(119, 25);
            dataGridViewRecords.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRecords.Name = "dataGridViewRecords";
            dataGridViewRecords.RowHeadersWidth = 51;
            dataGridViewRecords.Size = new Size(671, 164);
            dataGridViewRecords.TabIndex = 1;
            dataGridViewRecords.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SaddleBrown;
            label9.Location = new Point(15, 25);
            label9.Name = "label9";
            label9.Size = new Size(100, 28);
            label9.TabIndex = 0;
            label9.Text = "Records : ";
            label9.Click += label9_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(25, 24);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 0;
            label2.Text = "Borrow : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Sienna;
            label3.Location = new Point(25, 72);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 1;
            label3.Text = " Book ID : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Sienna;
            label4.Location = new Point(30, 124);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 2;
            label4.Text = "Borrow Date : ";
            // 
            // txtBookIDBorrow
            // 
            txtBookIDBorrow.Location = new Point(101, 68);
            txtBookIDBorrow.Margin = new Padding(3, 4, 3, 4);
            txtBookIDBorrow.Name = "txtBookIDBorrow";
            txtBookIDBorrow.Size = new Size(292, 27);
            txtBookIDBorrow.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Sienna;
            label5.Location = new Point(427, 72);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 5;
            label5.Text = "Return Date : ";
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.LightGreen;
            btnBorrow.Location = new Point(431, 124);
            btnBorrow.Margin = new Padding(3, 4, 3, 4);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(86, 31);
            btnBorrow.TabIndex = 7;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(btnBorrow);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBookIDBorrow);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 600);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(129, 124);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(523, 68);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 600);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecords).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private TextBox txtBOOKID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnReturn;
        private Panel panel3;
        private DataGridView dataGridViewRecords;
        private Label label9;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.TextBox txtBookIDBorrow; 
        private Label label5;
        private Button btnBorrow;
        private Panel panel1;
        private DateTimePicker dateTimePicker1; 
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}