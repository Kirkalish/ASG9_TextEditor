namespace ASG9_TextEditor_15877094
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.crlfButton = new System.Windows.Forms.Button();
            this.tabButton = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.noButton = new System.Windows.Forms.Button();
            this.withButton = new System.Windows.Forms.Button();
            this.clipBoardButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conversionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.midToFrequencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.addTextButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endTextBox = new System.Windows.Forms.TextBox();
            this.beginTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.findButton = new System.Windows.Forms.Button();
            this.exludeMatchingCheckBox = new System.Windows.Forms.CheckBox();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.replaceButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dupesCheckBox = new System.Windows.Forms.CheckBox();
            this.ascendingButton = new System.Windows.Forms.Button();
            this.descendingButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.panelControls1 = new System.Windows.Forms.Panel();
            this.panelControls2 = new System.Windows.Forms.Panel();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelControls1.SuspendLayout();
            this.panelControls2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox8.Controls.Add(this.crlfButton);
            this.groupBox8.Controls.Add(this.tabButton);
            this.groupBox8.Location = new System.Drawing.Point(3, 335);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(100, 146);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Copy these special chars to the clipboard for copy/paste.";
            // 
            // crlfButton
            // 
            this.crlfButton.Location = new System.Drawing.Point(6, 113);
            this.crlfButton.Name = "crlfButton";
            this.crlfButton.Size = new System.Drawing.Size(74, 23);
            this.crlfButton.TabIndex = 1;
            this.crlfButton.Text = "[CRLF]";
            this.crlfButton.UseVisualStyleBackColor = true;
            this.crlfButton.Click += new System.EventHandler(this.crlfButton_Click);
            // 
            // tabButton
            // 
            this.tabButton.Location = new System.Drawing.Point(6, 84);
            this.tabButton.Name = "tabButton";
            this.tabButton.Size = new System.Drawing.Size(74, 23);
            this.tabButton.TabIndex = 0;
            this.tabButton.Text = "[TAB]";
            this.tabButton.UseVisualStyleBackColor = true;
            this.tabButton.Click += new System.EventHandler(this.tabButton_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTextBox.ForeColor = System.Drawing.Color.Black;
            this.dataTextBox.Location = new System.Drawing.Point(0, 100);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTextBox.Size = new System.Drawing.Size(1071, 441);
            this.dataTextBox.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.noButton);
            this.groupBox4.Controls.Add(this.withButton);
            this.groupBox4.Location = new System.Drawing.Point(3, 222);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(100, 88);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Make SQL IN:";
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(7, 59);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(81, 23);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "No Quotes";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // withButton
            // 
            this.withButton.Location = new System.Drawing.Point(6, 19);
            this.withButton.Name = "withButton";
            this.withButton.Size = new System.Drawing.Size(82, 23);
            this.withButton.TabIndex = 0;
            this.withButton.Text = "W/Quotes";
            this.withButton.UseVisualStyleBackColor = true;
            this.withButton.Click += new System.EventHandler(this.withButton_Click);
            // 
            // clipBoardButton
            // 
            this.clipBoardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clipBoardButton.BackColor = System.Drawing.Color.Black;
            this.clipBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clipBoardButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipBoardButton.ForeColor = System.Drawing.Color.White;
            this.clipBoardButton.Location = new System.Drawing.Point(0, 484);
            this.clipBoardButton.Name = "clipBoardButton";
            this.clipBoardButton.Size = new System.Drawing.Size(100, 54);
            this.clipBoardButton.TabIndex = 11;
            this.clipBoardButton.Text = "Copy to Clipboard";
            this.clipBoardButton.UseVisualStyleBackColor = false;
            this.clipBoardButton.Click += new System.EventHandler(this.clipBoardButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // conversionsToolStripMenuItem
            // 
            this.conversionsToolStripMenuItem.Name = "conversionsToolStripMenuItem";
            this.conversionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // midToFrequencyToolStripMenuItem
            // 
            this.midToFrequencyToolStripMenuItem.Name = "midToFrequencyToolStripMenuItem";
            this.midToFrequencyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // programingToolStripMenuItem
            // 
            this.programingToolStripMenuItem.Name = "programingToolStripMenuItem";
            this.programingToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // switchToolStripMenuItem
            // 
            this.switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            this.switchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // ifToolStripMenuItem
            // 
            this.ifToolStripMenuItem.Name = "ifToolStripMenuItem";
            this.ifToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.addTextButton);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.endTextBox);
            this.groupBox5.Controls.Add(this.beginTextBox);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(318, 73);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add to Beginning/ End of Each line";
            // 
            // addTextButton
            // 
            this.addTextButton.Location = new System.Drawing.Point(237, 31);
            this.addTextButton.Name = "addTextButton";
            this.addTextButton.Size = new System.Drawing.Size(75, 23);
            this.addTextButton.TabIndex = 4;
            this.addTextButton.Text = "Add text";
            this.addTextButton.UseVisualStyleBackColor = true;
            this.addTextButton.Click += new System.EventHandler(this.addTextButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Beginnning";
            // 
            // endTextBox
            // 
            this.endTextBox.Location = new System.Drawing.Point(72, 46);
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(158, 20);
            this.endTextBox.TabIndex = 1;
            // 
            // beginTextBox
            // 
            this.beginTextBox.Location = new System.Drawing.Point(72, 19);
            this.beginTextBox.Name = "beginTextBox";
            this.beginTextBox.Size = new System.Drawing.Size(158, 20);
            this.beginTextBox.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.findButton);
            this.groupBox6.Controls.Add(this.exludeMatchingCheckBox);
            this.groupBox6.Controls.Add(this.findTextBox);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(618, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(290, 60);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Find line Matching or Not Matching";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(200, 15);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // exludeMatchingCheckBox
            // 
            this.exludeMatchingCheckBox.AutoSize = true;
            this.exludeMatchingCheckBox.Location = new System.Drawing.Point(173, 41);
            this.exludeMatchingCheckBox.Name = "exludeMatchingCheckBox";
            this.exludeMatchingCheckBox.Size = new System.Drawing.Size(111, 17);
            this.exludeMatchingCheckBox.TabIndex = 2;
            this.exludeMatchingCheckBox.Text = "Exclude Matching";
            this.exludeMatchingCheckBox.UseVisualStyleBackColor = true;
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(43, 18);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(151, 20);
            this.findTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Find:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.replaceTextBox);
            this.groupBox7.Controls.Add(this.searchTextBox);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.replaceButton);
            this.groupBox7.Location = new System.Drawing.Point(336, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(276, 73);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Search and Replace";
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(58, 42);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(131, 20);
            this.replaceTextBox.TabIndex = 4;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(58, 16);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(131, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Replace";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Search";
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(195, 28);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(75, 23);
            this.replaceButton.TabIndex = 0;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.dupesCheckBox);
            this.groupBox3.Controls.Add(this.ascendingButton);
            this.groupBox3.Controls.Add(this.descendingButton);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 105);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort Results";
            // 
            // dupesCheckBox
            // 
            this.dupesCheckBox.AutoSize = true;
            this.dupesCheckBox.Location = new System.Drawing.Point(18, 76);
            this.dupesCheckBox.Name = "dupesCheckBox";
            this.dupesCheckBox.Size = new System.Drawing.Size(70, 17);
            this.dupesCheckBox.TabIndex = 9;
            this.dupesCheckBox.Text = "no dupes";
            this.dupesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ascendingButton
            // 
            this.ascendingButton.Location = new System.Drawing.Point(3, 18);
            this.ascendingButton.Name = "ascendingButton";
            this.ascendingButton.Size = new System.Drawing.Size(85, 23);
            this.ascendingButton.TabIndex = 7;
            this.ascendingButton.Text = "Ascending";
            this.ascendingButton.UseVisualStyleBackColor = true;
            this.ascendingButton.Click += new System.EventHandler(this.ascendingButton_Click);
            // 
            // descendingButton
            // 
            this.descendingButton.Location = new System.Drawing.Point(3, 47);
            this.descendingButton.Name = "descendingButton";
            this.descendingButton.Size = new System.Drawing.Size(85, 23);
            this.descendingButton.TabIndex = 8;
            this.descendingButton.Text = "Descending";
            this.descendingButton.UseVisualStyleBackColor = true;
            this.descendingButton.Click += new System.EventHandler(this.descendingButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.undoButton);
            this.groupBox2.Controls.Add(this.redoButton);
            this.groupBox2.Controls.Add(this.clearButton);
            this.groupBox2.Location = new System.Drawing.Point(3, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 105);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Undo / Redo:";
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(3, 19);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(85, 23);
            this.undoButton.TabIndex = 4;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.Location = new System.Drawing.Point(3, 48);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(85, 23);
            this.redoButton.TabIndex = 3;
            this.redoButton.Text = "Redo";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(3, 77);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // panelControls1
            // 
            this.panelControls1.BackColor = System.Drawing.Color.Gray;
            this.panelControls1.Controls.Add(this.groupBox2);
            this.panelControls1.Controls.Add(this.groupBox3);
            this.panelControls1.Controls.Add(this.groupBox8);
            this.panelControls1.Controls.Add(this.clipBoardButton);
            this.panelControls1.Controls.Add(this.groupBox4);
            this.panelControls1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControls1.Location = new System.Drawing.Point(1071, 0);
            this.panelControls1.Name = "panelControls1";
            this.panelControls1.Size = new System.Drawing.Size(100, 541);
            this.panelControls1.TabIndex = 3;
            // 
            // panelControls2
            // 
            this.panelControls2.BackColor = System.Drawing.Color.Gray;
            this.panelControls2.Controls.Add(this.groupBox6);
            this.panelControls2.Controls.Add(this.groupBox7);
            this.panelControls2.Controls.Add(this.groupBox5);
            this.panelControls2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls2.Location = new System.Drawing.Point(0, 0);
            this.panelControls2.Name = "panelControls2";
            this.panelControls2.Size = new System.Drawing.Size(1071, 100);
            this.panelControls2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 541);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.panelControls2);
            this.Controls.Add(this.panelControls1);
            this.Name = "Form1";
            this.Text = "KirkA Text Editor";
            this.groupBox8.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panelControls1.ResumeLayout(false);
            this.panelControls2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button withButton;
        private System.Windows.Forms.Button crlfButton;
        private System.Windows.Forms.Button tabButton;
        private System.Windows.Forms.Button clipBoardButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conversionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem midToFrequencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ifToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button addTextButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.TextBox beginTextBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.CheckBox exludeMatchingCheckBox;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox dupesCheckBox;
        private System.Windows.Forms.Button ascendingButton;
        private System.Windows.Forms.Button descendingButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel panelControls1;
        private System.Windows.Forms.Panel panelControls2;
    }
}

