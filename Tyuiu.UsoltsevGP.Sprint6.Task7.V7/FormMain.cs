using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.UsoltsevGP.Sprint6.Task7.V7.Lib;
namespace Tyuiu.UsoltsevGP.Sprint6.Task7.V7
{
    public partial class FormMain : Form
    {
        private DataTable inputDataTable;
        private DataTable outputDataTable;

        public FormMain()
        {
            InitializeComponent();
            InitializeDataGridViews();
        }

        private void InitializeDataGridViews()
        {
            inputDataTable = new DataTable();
            outputDataTable = new DataTable();

            dataGridView1.DataSource = inputDataTable;
            dataGridViewOut.DataSource = outputDataTable;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите входной файл";
                openFileDialog.FileName = "InPutFileTask7V7.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadMatrixFile(openFileDialog.FileName);
                    ProcessMatrix();
                    FormatMatrixDisplay();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMatrixFile(string filePath)
        {
            inputDataTable.Clear();
            outputDataTable.Clear();

            List<List<string>> matrix = new List<List<string>>();
            int maxColumns = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                int rowIndex = 0;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] values = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(v => v.Trim())
                                          .ToArray();

                    if (values.Length == 0) continue;

                    matrix.Add(new List<string>(values));

                    if (values.Length > maxColumns)
                        maxColumns = values.Length;

                    rowIndex++;
                }
            }

            for (int i = 0; i < maxColumns; i++)
            {
                inputDataTable.Columns.Add($"Col{i}", typeof(string));
                outputDataTable.Columns.Add($"Col{i}", typeof(string));
            }

            foreach (var row in matrix)
            {
                DataRow inputRow = inputDataTable.NewRow();
                DataRow outputRow = outputDataTable.NewRow();

                for (int i = 0; i < maxColumns; i++)
                {
                    if (i < row.Count)
                    {
                        inputRow[i] = row[i];
                        outputRow[i] = row[i];
                    }
                    else
                    {
                        inputRow[i] = "";
                        outputRow[i] = "";
                    }
                }

                inputDataTable.Rows.Add(inputRow);
                outputDataTable.Rows.Add(outputRow);
            }
        }

        private void ProcessMatrix()
        {
            try
            {
                outputDataTable.Clear();
                foreach (DataRow row in inputDataTable.Rows)
                {
                    DataRow newRow = outputDataTable.NewRow();
                    for (int i = 0; i < inputDataTable.Columns.Count; i++)
                    {
                        newRow[i] = row[i];
                    }
                    outputDataTable.Rows.Add(newRow);
                }

                if (outputDataTable.Rows.Count >= 5)
                {
                    DataRow fifthRow = outputDataTable.Rows[4];

                    for (int i = 0; i < outputDataTable.Columns.Count; i++)
                    {
                        string cellValue = fifthRow[i].ToString();
                        if (int.TryParse(cellValue, out int value))
                        {
                            if (value % 2 != 0)
                            {
                                fifthRow[i] = "66";
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("В матрице меньше 5 строк!", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке матрицы: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatMatrixDisplay()
        {
            foreach (DataGridView dgv in new[] { dataGridView1, dataGridViewOut })
            {
                dgv.RowHeadersVisible = false;

                dgv.ColumnHeadersHeight = 30;
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.DefaultCellStyle.Font = new Font("Consolas", 10);
                dgv.RowTemplate.Height = 25;

                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgv.GridColor = Color.LightGray;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (outputDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Нет данных для сохранения!", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить результат";
                saveFileDialog.FileName = "OutPutFileTask7.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveMatrixToFile(saveFileDialog.FileName);
                    MessageBox.Show($"Файл успешно сохранен:\n{saveFileDialog.FileName}", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveMatrixToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (DataRow row in outputDataTable.Rows)
                {
                    List<string> values = new List<string>();
                    foreach (DataColumn column in outputDataTable.Columns)
                    {
                        string value = row[column].ToString();
                        if (!string.IsNullOrEmpty(value))
                            values.Add(value);
                    }
                    writer.WriteLine(string.Join(";", values));
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (inputDataTable.Rows.Count > 0)
            {
                ProcessMatrix();
                FormatMatrixDisplay();
                MessageBox.Show("Обработка завершена!\nНечетные значения в 5-й строке заменены на 66.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Сначала загрузите файл!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CreateTestFile()
        {
            string testData = @"3;3;14;2;3;0;4
0;8;0;20;2;10;0;4
1;2;0;3;2;3;0;4
2;3;3;5;2;0;4
6;8;0;1;2;10;0;4
1;2;0;3;2;3;0;4
2;3;3;5;2;0;4
6;8;0;1;2;10;0;4
1;2;0;3;2;3;0;4";

            File.WriteAllText("test_matrix.csv", testData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Усольцев Г. П.\n" + "Группа: РППб-25-1",
                          "О программе",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
    }
}