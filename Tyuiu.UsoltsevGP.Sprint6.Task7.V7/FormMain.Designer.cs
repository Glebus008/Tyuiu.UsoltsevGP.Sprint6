namespace Tyuiu.UsoltsevGP.Sprint6.Task7.V7
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.GroupBox groupBoxInput;
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
            dataGridViewIn = new DataGridView();
            dataGridViewOut = new DataGridView();
            groupBoxInput = new GroupBox();
            groupBoxOutput = new GroupBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            btnShowInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Image = (Image)resources.GetObject("btnLoad.Image");
            btnLoad.Location = new Point(50, 20);
            btnLoad.Margin = new Padding(6, 5, 6, 5);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(97, 100);
            btnLoad.TabIndex = 0;
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnProcess
            // 
            btnProcess.Image = (Image)resources.GetObject("btnProcess.Image");
            btnProcess.Location = new Point(159, 20);
            btnProcess.Margin = new Padding(6, 5, 6, 5);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(97, 100);
            btnProcess.TabIndex = 1;
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(267, 20);
            btnSave.Margin = new Padding(6, 5, 6, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 100);
            btnSave.TabIndex = 2;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.AllowUserToAddRows = false;
            dataGridViewIn.AllowUserToDeleteRows = false;
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.ColumnHeadersVisible = false;
            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.Location = new Point(6, 29);
            dataGridViewIn.Margin = new Padding(6, 5, 6, 5);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.ReadOnly = true;
            dataGridViewIn.RowHeadersVisible = false;
            dataGridViewIn.RowHeadersWidth = 62;
            dataGridViewIn.Size = new Size(599, 481);
            dataGridViewIn.TabIndex = 3;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.AllowUserToAddRows = false;
            dataGridViewOut.AllowUserToDeleteRows = false;
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.ColumnHeadersVisible = false;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(6, 29);
            dataGridViewOut.Margin = new Padding(6, 5, 6, 5);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.ReadOnly = true;
            dataGridViewOut.RowHeadersVisible = false;
            dataGridViewOut.RowHeadersWidth = 62;
            dataGridViewOut.Size = new Size(579, 476);
            dataGridViewOut.TabIndex = 4;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridViewIn);
            groupBoxInput.Location = new Point(43, 327);
            groupBoxInput.Margin = new Padding(6, 5, 6, 5);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Padding = new Padding(6, 5, 6, 5);
            groupBoxInput.Size = new Size(611, 515);
            groupBoxInput.TabIndex = 7;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод:";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewOut);
            groupBoxOutput.Location = new Point(730, 327);
            groupBoxOutput.Margin = new Padding(6, 5, 6, 5);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Padding = new Padding(6, 5, 6, 5);
            groupBoxOutput.Size = new Size(591, 510);
            groupBoxOutput.TabIndex = 8;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(49, 153);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1273, 143);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(9, 33);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1201, 100);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnShowInfo
            // 
            btnShowInfo.Image = (Image)resources.GetObject("btnShowInfo.Image");
            btnShowInfo.Location = new Point(1224, 17);
            btnShowInfo.Margin = new Padding(6, 5, 6, 5);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(97, 103);
            btnShowInfo.TabIndex = 3;
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 887);
            Controls.Add(btnShowInfo);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Controls.Add(btnSave);
            Controls.Add(btnProcess);
            Controls.Add(btnLoad);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 7 | Усольцев Г. П.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button btnShowInfo;
    }
}