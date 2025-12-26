namespace Tyuiu.UsoltsevGP.Sprint6.Task7.V7
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.GroupBox groupBoxOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            btnLoad = new Button();
            btnProcess = new Button();
            btnSave = new Button();
            dataGridViewOut = new DataGridView();
            groupBoxOutput = new GroupBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            btnShowInfo = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBoxInput = new GroupBox();
            dataGridView1 = new DataGridView();
            splitter1 = new Splitter();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            groupBoxOutput.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Image = (Image)resources.GetObject("btnLoad.Image");
            btnLoad.Location = new Point(35, 12);
            btnLoad.Margin = new Padding(4, 3, 4, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(68, 60);
            btnLoad.TabIndex = 0;
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnProcess
            // 
            btnProcess.Image = (Image)resources.GetObject("btnProcess.Image");
            btnProcess.Location = new Point(111, 12);
            btnProcess.Margin = new Padding(4, 3, 4, 3);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(68, 60);
            btnProcess.TabIndex = 1;
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(187, 12);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(68, 60);
            btnSave.TabIndex = 2;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.AllowUserToAddRows = false;
            dataGridViewOut.AllowUserToDeleteRows = false;
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.ColumnHeadersVisible = false;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(4, 19);
            dataGridViewOut.Margin = new Padding(4, 3, 4, 3);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.ReadOnly = true;
            dataGridViewOut.RowHeadersVisible = false;
            dataGridViewOut.RowHeadersWidth = 62;
            dataGridViewOut.Size = new Size(463, 366);
            dataGridViewOut.TabIndex = 4;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewOut);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(484, 190);
            groupBoxOutput.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutput.Size = new Size(471, 388);
            groupBoxOutput.TabIndex = 8;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(34, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(891, 86);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(885, 64);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnShowInfo
            // 
            btnShowInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowInfo.Image = (Image)resources.GetObject("btnShowInfo.Image");
            btnShowInfo.Location = new Point(857, 10);
            btnShowInfo.Margin = new Padding(4, 3, 4, 3);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(68, 62);
            btnShowInfo.TabIndex = 3;
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 190);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxInput);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 190);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 388);
            panel2.TabIndex = 11;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridView1);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(0, 0);
            groupBoxInput.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Padding = new Padding(4, 3, 4, 3);
            groupBoxInput.Size = new Size(484, 388);
            groupBoxInput.TabIndex = 9;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(4, 19);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(476, 366);
            dataGridView1.TabIndex = 4;
            // 
            // splitter1
            // 
            splitter1.BackColor = SystemColors.ActiveCaption;
            splitter1.Location = new Point(484, 190);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 388);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(955, 388);
            panel3.TabIndex = 13;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 578);
            Controls.Add(splitter1);
            Controls.Add(btnShowInfo);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxOutput);
            Controls.Add(btnSave);
            Controls.Add(btnProcess);
            Controls.Add(btnLoad);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(971, 617);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 7 | Усольцев Г. П.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            groupBoxOutput.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button btnShowInfo;
        private Panel panel1;
        private Panel panel2;
        private Splitter splitter1;
        private Panel panel3;
        private GroupBox groupBoxInput;
        private DataGridView dataGridView1;
    }
}