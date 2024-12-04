using System;
using System.IO;
using System.Windows.Forms;

namespace ToDoListAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            clbTasks.ItemCheck += clbTasks_ItemCheck;

            txtTask.Text = "Въведете нова задача...";
            txtTask.ForeColor = Color.Gray;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                string newTask = txtTask.Text.Trim();

                // Проверка дали задачата вече съществува
                bool taskExists = false;
                foreach (var item in clbTasks.Items)
                {
                    string existingTask = item.ToString().Substring(2).Trim(); // Премахваме символа и интервала
                    if (string.Equals(existingTask, newTask, StringComparison.OrdinalIgnoreCase))
                    {
                        taskExists = true;
                        break;
                    }
                }

                if (taskExists)
                {
                    MessageBox.Show("Тази задача вече съществува.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string taskText = $"✘ {newTask}";
                    clbTasks.Items.Add(taskText, false);
                    txtTask.Text = "Въведете нова задача...";
                    txtTask.ForeColor = Color.Gray;
                }
            }
            else
            {
                MessageBox.Show("Моля, въведете задача.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clbTasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Забавяне на изпълнението, за да се обнови състоянието на отметката
            this.BeginInvoke(new Action(() =>
            {
                int index = e.Index;
                string taskText = clbTasks.Items[index].ToString();

                if (e.NewValue == CheckState.Checked)
                {
                    // Заменяме '✘' с '✔'
                    if (taskText.StartsWith("✘"))
                    {
                        taskText = taskText.Replace("✘", "✔");
                        clbTasks.Items[index] = taskText;
                    }
                }
                else
                {
                    // Заменяме '✔' с '✘'
                    if (taskText.StartsWith("✔"))
                    {
                        taskText = taskText.Replace("✔", "✘");
                        clbTasks.Items[index] = taskText;
                    }
                }
            }));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (clbTasks.CheckedItems.Count > 0)
            {
                for (int i = clbTasks.CheckedItems.Count - 1; i >= 0; i--)
                {
                    clbTasks.Items.Remove(clbTasks.CheckedItems[i]);
                }
            }
            else
            {
                MessageBox.Show("Моля, маркирайте задача за премахване.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void запазиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                // Генериране на име на файла с текущата дата
                string dateString = DateTime.Now.ToString("yyyyMMdd_HH");
                saveFileDialog.FileName = $"ToDoList_{dateString}.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine($"ToDo List - Дата: {DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}");
                        writer.WriteLine("=====================================");
                        writer.WriteLine();

                        foreach (var item in clbTasks.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }
                }
            }
        }

        private void отвориToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    clbTasks.Items.Clear();
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        int lineNumber = 0;
                        while ((line = reader.ReadLine()) != null)
                        {
                            lineNumber++;
                            // Пропускаме първите три реда
                            if (lineNumber <= 3)
                            {
                                continue;
                            }

                            bool isChecked = false;
                            if (line.StartsWith("✔"))
                            {
                                isChecked = true;
                            }
                            clbTasks.Items.Add(line, isChecked);
                        }
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (clbTasks.SelectedIndex != -1)
            {
                string selectedTask = clbTasks.SelectedItem.ToString();
                string taskText = selectedTask.Substring(2);
                txtTask.Text = taskText;
                clbTasks.Items.RemoveAt(clbTasks.SelectedIndex);
                txtTask.Focus();
            }
            else
            {
                MessageBox.Show("Моля, изберете задача за редактиране.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTask_Enter(object sender, EventArgs e)
        {
            if (txtTask.Text == "Въведете нова задача...")
            {
                txtTask.Text = "";
                txtTask.ForeColor = SystemColors.WindowText; // Връщаме цвета на текста към стандартния
            }
        }

        private void txtTask_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTask.Text))
            {
                txtTask.Text = "Въведете нова задача...";
                txtTask.ForeColor = Color.Gray; // Задаваме цвета на текста към сив за placeholder
            }
        }
    }
}
