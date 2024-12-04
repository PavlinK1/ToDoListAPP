namespace ToDoListAPP
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
            btnAdd = new Button();
            btnRemove = new Button();
            txtTask = new TextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            запазиToolStripMenuItem = new ToolStripMenuItem();
            отвориToolStripMenuItem = new ToolStripMenuItem();
            btnEdit = new Button();
            clbTasks = new CheckedListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(194, 62);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавяне";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(460, 62);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(121, 23);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Изтриване";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtTask
            // 
            txtTask.ForeColor = Color.Gray;
            txtTask.Location = new Point(194, 33);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(387, 23);
            txtTask.TabIndex = 2;
            txtTask.Text = "Въведете нова задача..";
            txtTask.TextChanged += txtTask_TextChanged;
            txtTask.Enter += txtTask_Enter;
            txtTask.Leave += txtTask_Leave;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { запазиToolStripMenuItem, отвориToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // запазиToolStripMenuItem
            // 
            запазиToolStripMenuItem.Name = "запазиToolStripMenuItem";
            запазиToolStripMenuItem.Size = new Size(115, 22);
            запазиToolStripMenuItem.Text = "Запази";
            запазиToolStripMenuItem.Click += запазиToolStripMenuItem_Click;
            // 
            // отвориToolStripMenuItem
            // 
            отвориToolStripMenuItem.Name = "отвориToolStripMenuItem";
            отвориToolStripMenuItem.Size = new Size(115, 22);
            отвориToolStripMenuItem.Text = "Отвори";
            отвориToolStripMenuItem.Click += отвориToolStripMenuItem_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(346, 62);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(84, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Редактирай";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // clbTasks
            // 
            clbTasks.FormattingEnabled = true;
            clbTasks.Location = new Point(194, 103);
            clbTasks.Name = "clbTasks";
            clbTasks.Size = new Size(387, 274);
            clbTasks.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clbTasks);
            Controls.Add(btnEdit);
            Controls.Add(txtTask);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnRemove;
        private TextBox txtTask;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem запазиToolStripMenuItem;
        private ToolStripMenuItem отвориToolStripMenuItem;
        private Button btnEdit;
        private CheckedListBox clbTasks;
    }
}