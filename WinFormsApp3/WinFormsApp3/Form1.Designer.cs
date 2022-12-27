namespace WinFormsApp3
{
    partial class Antivirus_Form
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox_Diagnostic = new System.Windows.Forms.ListBox();
            this.button_Scan = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_ProcessList = new System.Windows.Forms.ListBox();
            this.button_ProcessList = new System.Windows.Forms.Button();
            this.label_Proverka = new System.Windows.Forms.Label();
            this.Label_Proverka2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 53);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // listBox_Diagnostic
            // 
            this.listBox_Diagnostic.FormattingEnabled = true;
            this.listBox_Diagnostic.ItemHeight = 15;
            this.listBox_Diagnostic.Items.AddRange(new object[] {
            "Программа готова к работе! ",
            "Нажмите кнопку SCAN для сканирования..."});
            this.listBox_Diagnostic.Location = new System.Drawing.Point(28, 82);
            this.listBox_Diagnostic.Name = "listBox_Diagnostic";
            this.listBox_Diagnostic.Size = new System.Drawing.Size(683, 274);
            this.listBox_Diagnostic.TabIndex = 1;
            this.listBox_Diagnostic.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_Scan
            // 
            this.button_Scan.Location = new System.Drawing.Point(103, 362);
            this.button_Scan.Name = "button_Scan";
            this.button_Scan.Size = new System.Drawing.Size(75, 23);
            this.button_Scan.TabIndex = 3;
            this.button_Scan.Text = "SCAN";
            this.button_Scan.UseVisualStyleBackColor = true;
            this.button_Scan.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(184, 362);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(75, 23);
            this.button_Remove.TabIndex = 4;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Detected: 0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox_ProcessList
            // 
            this.listBox_ProcessList.FormattingEnabled = true;
            this.listBox_ProcessList.ItemHeight = 15;
            this.listBox_ProcessList.Location = new System.Drawing.Point(732, 82);
            this.listBox_ProcessList.Name = "listBox_ProcessList";
            this.listBox_ProcessList.Size = new System.Drawing.Size(25, 274);
            this.listBox_ProcessList.TabIndex = 7;
            this.listBox_ProcessList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // button_ProcessList
            // 
            this.button_ProcessList.Location = new System.Drawing.Point(373, 362);
            this.button_ProcessList.Name = "button_ProcessList";
            this.button_ProcessList.Size = new System.Drawing.Size(75, 23);
            this.button_ProcessList.TabIndex = 8;
            this.button_ProcessList.Text = "button1";
            this.button_ProcessList.UseVisualStyleBackColor = true;
            this.button_ProcessList.Click += new System.EventHandler(this.button_ProcessList_Click);
            // 
            // label_Proverka
            // 
            this.label_Proverka.AutoSize = true;
            this.label_Proverka.Location = new System.Drawing.Point(383, 390);
            this.label_Proverka.Name = "label_Proverka";
            this.label_Proverka.Size = new System.Drawing.Size(38, 15);
            this.label_Proverka.TabIndex = 9;
            this.label_Proverka.Text = "label1";
            // 
            // Label_Proverka2
            // 
            this.Label_Proverka2.AutoSize = true;
            this.Label_Proverka2.Location = new System.Drawing.Point(383, 417);
            this.Label_Proverka2.Name = "Label_Proverka2";
            this.Label_Proverka2.Size = new System.Drawing.Size(38, 15);
            this.Label_Proverka2.TabIndex = 10;
            this.Label_Proverka2.Text = "label1";
            // 
            // Antivirus_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Proverka2);
            this.Controls.Add(this.label_Proverka);
            this.Controls.Add(this.button_ProcessList);
            this.Controls.Add(this.listBox_ProcessList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Scan);
            this.Controls.Add(this.listBox_Diagnostic);
            this.Controls.Add(this.progressBar1);
            this.Name = "Antivirus_Form";
            this.Text = "antiDOTa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progressBar1;
        private ListBox listBox_Diagnostic;
        private Button button_Scan;
        private Button button_Remove;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label2;
        private ListBox listBox_ProcessList;
        private Button button_ProcessList;
        private Label label_Proverka;
        private Label Label_Proverka2;
    }
}