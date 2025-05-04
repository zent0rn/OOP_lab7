namespace OOP_Lab7
{
    partial class ViewImpl
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
            mainPanel = new Panel();
            addStudentPanel = new Panel();
            addStudentButton = new Button();
            durationOfStudyNumericUpDown = new NumericUpDown();
            durationOfStudyLabel = new Label();
            averageScoreNumericUpDown = new NumericUpDown();
            averageScoreLabel = new Label();
            studentSpecialityTextBox = new TextBox();
            studentSpecialityLabel = new Label();
            studentGroupTextBox = new TextBox();
            studentGroupLabel = new Label();
            studentNameTextBox = new TextBox();
            studentName = new Label();
            addStudentLabel = new Label();
            logsRichTextBox = new RichTextBox();
            buttonsPanel = new Panel();
            getAllStudensInfoButton = new Button();
            getStudentInfoButton = new Button();
            removeStudentButton = new Button();
            studentIdNumericUpDown = new NumericUpDown();
            studentIdLabel = new Label();
            mainPanel.SuspendLayout();
            addStudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)durationOfStudyNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)averageScoreNumericUpDown).BeginInit();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentIdNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Controls.Add(addStudentPanel);
            mainPanel.Controls.Add(logsRichTextBox);
            mainPanel.Location = new Point(10, 9);
            mainPanel.Margin = new Padding(2, 2, 2, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(802, 337);
            mainPanel.TabIndex = 0;
            // 
            // addStudentPanel
            // 
            addStudentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            addStudentPanel.Controls.Add(addStudentButton);
            addStudentPanel.Controls.Add(durationOfStudyNumericUpDown);
            addStudentPanel.Controls.Add(durationOfStudyLabel);
            addStudentPanel.Controls.Add(averageScoreNumericUpDown);
            addStudentPanel.Controls.Add(averageScoreLabel);
            addStudentPanel.Controls.Add(studentSpecialityTextBox);
            addStudentPanel.Controls.Add(studentSpecialityLabel);
            addStudentPanel.Controls.Add(studentGroupTextBox);
            addStudentPanel.Controls.Add(studentGroupLabel);
            addStudentPanel.Controls.Add(studentNameTextBox);
            addStudentPanel.Controls.Add(studentName);
            addStudentPanel.Controls.Add(addStudentLabel);
            addStudentPanel.Location = new Point(3, 2);
            addStudentPanel.Margin = new Padding(2, 2, 2, 2);
            addStudentPanel.Name = "addStudentPanel";
            addStudentPanel.Size = new Size(341, 332);
            addStudentPanel.TabIndex = 1;
            // 
            // addStudentButton
            // 
            addStudentButton.Dock = DockStyle.Bottom;
            addStudentButton.Location = new Point(0, 299);
            addStudentButton.Margin = new Padding(2, 2, 2, 2);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(341, 33);
            addStudentButton.TabIndex = 11;
            addStudentButton.Text = "Добавить студента";
            addStudentButton.UseVisualStyleBackColor = true;
            // 
            // durationOfStudyNumericUpDown
            // 
            durationOfStudyNumericUpDown.Location = new Point(149, 222);
            durationOfStudyNumericUpDown.Margin = new Padding(2, 2, 2, 2);
            durationOfStudyNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            durationOfStudyNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            durationOfStudyNumericUpDown.Name = "durationOfStudyNumericUpDown";
            durationOfStudyNumericUpDown.Size = new Size(188, 26);
            durationOfStudyNumericUpDown.TabIndex = 10;
            durationOfStudyNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // durationOfStudyLabel
            // 
            durationOfStudyLabel.AutoSize = true;
            durationOfStudyLabel.Location = new Point(2, 222);
            durationOfStudyLabel.Margin = new Padding(2, 0, 2, 0);
            durationOfStudyLabel.Name = "durationOfStudyLabel";
            durationOfStudyLabel.Size = new Size(138, 19);
            durationOfStudyLabel.TabIndex = 9;
            durationOfStudyLabel.Text = "Срок обучения (лет)";
            // 
            // averageScoreNumericUpDown
            // 
            averageScoreNumericUpDown.DecimalPlaces = 2;
            averageScoreNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            averageScoreNumericUpDown.Location = new Point(107, 176);
            averageScoreNumericUpDown.Margin = new Padding(2, 2, 2, 2);
            averageScoreNumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 65536 });
            averageScoreNumericUpDown.Name = "averageScoreNumericUpDown";
            averageScoreNumericUpDown.Size = new Size(230, 26);
            averageScoreNumericUpDown.TabIndex = 8;
            averageScoreNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // averageScoreLabel
            // 
            averageScoreLabel.AutoSize = true;
            averageScoreLabel.Location = new Point(2, 176);
            averageScoreLabel.Margin = new Padding(2, 0, 2, 0);
            averageScoreLabel.Name = "averageScoreLabel";
            averageScoreLabel.Size = new Size(98, 19);
            averageScoreLabel.TabIndex = 7;
            averageScoreLabel.Text = "Средний балл";
            // 
            // studentSpecialityTextBox
            // 
            studentSpecialityTextBox.Location = new Point(108, 136);
            studentSpecialityTextBox.Margin = new Padding(2, 2, 2, 2);
            studentSpecialityTextBox.Name = "studentSpecialityTextBox";
            studentSpecialityTextBox.Size = new Size(230, 26);
            studentSpecialityTextBox.TabIndex = 6;
            // 
            // studentSpecialityLabel
            // 
            studentSpecialityLabel.AutoSize = true;
            studentSpecialityLabel.Location = new Point(2, 136);
            studentSpecialityLabel.Margin = new Padding(2, 0, 2, 0);
            studentSpecialityLabel.Name = "studentSpecialityLabel";
            studentSpecialityLabel.Size = new Size(105, 19);
            studentSpecialityLabel.TabIndex = 5;
            studentSpecialityLabel.Text = "Специальность";
            // 
            // studentGroupTextBox
            // 
            studentGroupTextBox.Location = new Point(108, 87);
            studentGroupTextBox.Margin = new Padding(2, 2, 2, 2);
            studentGroupTextBox.Name = "studentGroupTextBox";
            studentGroupTextBox.Size = new Size(231, 26);
            studentGroupTextBox.TabIndex = 4;
            // 
            // studentGroupLabel
            // 
            studentGroupLabel.AutoSize = true;
            studentGroupLabel.Location = new Point(2, 87);
            studentGroupLabel.Margin = new Padding(2, 0, 2, 0);
            studentGroupLabel.Name = "studentGroupLabel";
            studentGroupLabel.Size = new Size(54, 19);
            studentGroupLabel.TabIndex = 3;
            studentGroupLabel.Text = "Группа";
            // 
            // studentNameTextBox
            // 
            studentNameTextBox.Location = new Point(108, 41);
            studentNameTextBox.Margin = new Padding(2, 2, 2, 2);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.Size = new Size(231, 26);
            studentNameTextBox.TabIndex = 2;
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Location = new Point(2, 41);
            studentName.Margin = new Padding(2, 0, 2, 0);
            studentName.Name = "studentName";
            studentName.Size = new Size(40, 19);
            studentName.TabIndex = 1;
            studentName.Text = "ФИО";
            // 
            // addStudentLabel
            // 
            addStudentLabel.AutoSize = true;
            addStudentLabel.Location = new Point(83, 0);
            addStudentLabel.Margin = new Padding(2, 0, 2, 0);
            addStudentLabel.Name = "addStudentLabel";
            addStudentLabel.Size = new Size(129, 19);
            addStudentLabel.TabIndex = 0;
            addStudentLabel.Text = "Добавить студента";
            // 
            // logsRichTextBox
            // 
            logsRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logsRichTextBox.Location = new Point(349, 2);
            logsRichTextBox.Margin = new Padding(2, 2, 2, 2);
            logsRichTextBox.Name = "logsRichTextBox";
            logsRichTextBox.Size = new Size(451, 333);
            logsRichTextBox.TabIndex = 0;
            logsRichTextBox.Text = "";
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonsPanel.Controls.Add(getAllStudensInfoButton);
            buttonsPanel.Controls.Add(getStudentInfoButton);
            buttonsPanel.Controls.Add(removeStudentButton);
            buttonsPanel.Controls.Add(studentIdNumericUpDown);
            buttonsPanel.Controls.Add(studentIdLabel);
            buttonsPanel.Location = new Point(10, 364);
            buttonsPanel.Margin = new Padding(2, 2, 2, 2);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(802, 50);
            buttonsPanel.TabIndex = 1;
            // 
            // getAllStudensInfoButton
            // 
            getAllStudensInfoButton.Anchor = AnchorStyles.Top;
            getAllStudensInfoButton.Cursor = Cursors.Hand;
            getAllStudensInfoButton.Location = new Point(570, 0);
            getAllStudensInfoButton.Margin = new Padding(2, 2, 2, 2);
            getAllStudensInfoButton.Name = "getAllStudensInfoButton";
            getAllStudensInfoButton.Size = new Size(172, 50);
            getAllStudensInfoButton.TabIndex = 4;
            getAllStudensInfoButton.Text = "Получить информацию о всех студентах";
            getAllStudensInfoButton.UseVisualStyleBackColor = true;
            // 
            // getStudentInfoButton
            // 
            getStudentInfoButton.Anchor = AnchorStyles.Top;
            getStudentInfoButton.Cursor = Cursors.Hand;
            getStudentInfoButton.Location = new Point(386, 0);
            getStudentInfoButton.Margin = new Padding(2, 2, 2, 2);
            getStudentInfoButton.Name = "getStudentInfoButton";
            getStudentInfoButton.Size = new Size(166, 50);
            getStudentInfoButton.TabIndex = 3;
            getStudentInfoButton.Text = "Вывести информацию о студенте";
            getStudentInfoButton.UseVisualStyleBackColor = true;
            // 
            // removeStudentButton
            // 
            removeStudentButton.Anchor = AnchorStyles.Top;
            removeStudentButton.Cursor = Cursors.Hand;
            removeStudentButton.Location = new Point(251, 0);
            removeStudentButton.Margin = new Padding(2, 2, 2, 2);
            removeStudentButton.Name = "removeStudentButton";
            removeStudentButton.Size = new Size(122, 50);
            removeStudentButton.TabIndex = 2;
            removeStudentButton.Text = "Удалить студента";
            removeStudentButton.UseVisualStyleBackColor = true;
            // 
            // studentIdNumericUpDown
            // 
            studentIdNumericUpDown.Location = new Point(86, 15);
            studentIdNumericUpDown.Margin = new Padding(2, 2, 2, 2);
            studentIdNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            studentIdNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            studentIdNumericUpDown.Name = "studentIdNumericUpDown";
            studentIdNumericUpDown.Size = new Size(93, 26);
            studentIdNumericUpDown.TabIndex = 1;
            studentIdNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // studentIdLabel
            // 
            studentIdLabel.AutoSize = true;
            studentIdLabel.Location = new Point(2, 17);
            studentIdLabel.Margin = new Padding(2, 0, 2, 0);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new Size(85, 19);
            studentIdLabel.TabIndex = 0;
            studentIdLabel.Text = "ID студента:";
            // 
            // ViewImpl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(821, 423);
            Controls.Add(buttonsPanel);
            Controls.Add(mainPanel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ViewImpl";
            Text = "ЛБ 7. Сазонов/Зимин";
            mainPanel.ResumeLayout(false);
            addStudentPanel.ResumeLayout(false);
            addStudentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)durationOfStudyNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)averageScoreNumericUpDown).EndInit();
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentIdNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel buttonsPanel;
        private Button getStudentInfoButton;
        private Button removeStudentButton;
        private NumericUpDown studentIdNumericUpDown;
        private Label studentIdLabel;
        private Panel addStudentPanel;
        private Label studentName;
        private Label addStudentLabel;
        private RichTextBox logsRichTextBox;
        private Button getAllStudensInfoButton;
        private TextBox studentSpecialityTextBox;
        private Label studentSpecialityLabel;
        private TextBox studentGroupTextBox;
        private Label studentGroupLabel;
        private TextBox studentNameTextBox;
        private NumericUpDown durationOfStudyNumericUpDown;
        private Label durationOfStudyLabel;
        private NumericUpDown averageScoreNumericUpDown;
        private Label averageScoreLabel;
        private Button addStudentButton;
    }
}
