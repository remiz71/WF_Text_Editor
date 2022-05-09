namespace WF_Text_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.f_box = new System.Windows.Forms.ToolStripComboBox();
            this.s_box = new System.Windows.Forms.ToolStripComboBox();
            this.BoldBt = new System.Windows.Forms.ToolStripButton();
            this.ItalBt = new System.Windows.Forms.ToolStripButton();
            this.UndLBt = new System.Windows.Forms.ToolStripButton();
            this.LeftAbt = new System.Windows.Forms.ToolStripButton();
            this.CenterAbt = new System.Windows.Forms.ToolStripButton();
            this.RightAlbt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.msEn = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Copybt = new System.Windows.Forms.ToolStripMenuItem();
            this.Cutbt = new System.Windows.Forms.ToolStripMenuItem();
            this.Pastebt = new System.Windows.Forms.ToolStripMenuItem();
            this.msRu = new System.Windows.Forms.MenuStrip();
            this.ruFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenRu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveRu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseRu = new System.Windows.Forms.ToolStripMenuItem();
            this.ruEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ruCut = new System.Windows.Forms.ToolStripMenuItem();
            this.ruPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SafeFile1 = new System.Windows.Forms.SaveFileDialog();
            this.Font_D = new System.Windows.Forms.FontDialog();
            this.Color_D = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.msEn.SuspendLayout();
            this.msRu.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 90);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(692, 430);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = " ";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.f_box,
            this.s_box,
            this.BoldBt,
            this.ItalBt,
            this.UndLBt,
            this.LeftAbt,
            this.CenterAbt,
            this.RightAlbt,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 56);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(716, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.Open_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.Safe_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // f_box
            // 
            this.f_box.Name = "f_box";
            this.f_box.Size = new System.Drawing.Size(121, 28);
            this.f_box.SelectedIndexChanged += new System.EventHandler(this.f_box_SelectedIndexChanged);
            // 
            // s_box
            // 
            this.s_box.Items.AddRange(new object[] {
            "8",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "26",
            "28",
            "36",
            "72",
            "99"});
            this.s_box.Name = "s_box";
            this.s_box.Size = new System.Drawing.Size(75, 28);
            this.s_box.SelectedIndexChanged += new System.EventHandler(this.s_box_SelectedIndexChanged);
            // 
            // BoldBt
            // 
            this.BoldBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldBt.Image = ((System.Drawing.Image)(resources.GetObject("BoldBt.Image")));
            this.BoldBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldBt.Name = "BoldBt";
            this.BoldBt.Size = new System.Drawing.Size(29, 25);
            this.BoldBt.Text = "toolStripButton1";
            this.BoldBt.Click += new System.EventHandler(this.BoldBt_Click);
            // 
            // ItalBt
            // 
            this.ItalBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalBt.Image = ((System.Drawing.Image)(resources.GetObject("ItalBt.Image")));
            this.ItalBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalBt.Name = "ItalBt";
            this.ItalBt.Size = new System.Drawing.Size(29, 25);
            this.ItalBt.Text = "toolStripButton2";
            this.ItalBt.Click += new System.EventHandler(this.ItalBt_Click);
            // 
            // UndLBt
            // 
            this.UndLBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndLBt.Image = ((System.Drawing.Image)(resources.GetObject("UndLBt.Image")));
            this.UndLBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndLBt.Name = "UndLBt";
            this.UndLBt.Size = new System.Drawing.Size(29, 25);
            this.UndLBt.Text = "toolStripButton3";
            this.UndLBt.Click += new System.EventHandler(this.UndLBt_Click);
            // 
            // LeftAbt
            // 
            this.LeftAbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LeftAbt.Image = ((System.Drawing.Image)(resources.GetObject("LeftAbt.Image")));
            this.LeftAbt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LeftAbt.Name = "LeftAbt";
            this.LeftAbt.Size = new System.Drawing.Size(29, 25);
            this.LeftAbt.Text = "По левому краю";
            this.LeftAbt.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.LeftAbt.Click += new System.EventHandler(this.LeftAbt_Click);
            // 
            // CenterAbt
            // 
            this.CenterAbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterAbt.Image = ((System.Drawing.Image)(resources.GetObject("CenterAbt.Image")));
            this.CenterAbt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CenterAbt.Name = "CenterAbt";
            this.CenterAbt.Size = new System.Drawing.Size(29, 25);
            this.CenterAbt.Text = "По центру";
            this.CenterAbt.Click += new System.EventHandler(this.CenterAbt_Click);
            // 
            // RightAlbt
            // 
            this.RightAlbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RightAlbt.Image = ((System.Drawing.Image)(resources.GetObject("RightAlbt.Image")));
            this.RightAlbt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RightAlbt.Name = "RightAlbt";
            this.RightAlbt.Size = new System.Drawing.Size(29, 25);
            this.RightAlbt.Text = "По правому краю";
            this.RightAlbt.Click += new System.EventHandler(this.RightAlbt_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "Colbt";
            this.toolStripButton1.Click += new System.EventHandler(this.Colbt_Click);
            // 
            // msEn
            // 
            this.msEn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msEn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.msEn.Location = new System.Drawing.Point(0, 28);
            this.msEn.Name = "msEn";
            this.msEn.Size = new System.Drawing.Size(716, 28);
            this.msEn.TabIndex = 2;
            this.msEn.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Copybt,
            this.Cutbt,
            this.Pastebt});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // Copybt
            // 
            this.Copybt.Enabled = false;
            this.Copybt.Name = "Copybt";
            this.Copybt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copybt.Size = new System.Drawing.Size(177, 26);
            this.Copybt.Text = "Copy";
            this.Copybt.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // Cutbt
            // 
            this.Cutbt.Enabled = false;
            this.Cutbt.Name = "Cutbt";
            this.Cutbt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Cutbt.Size = new System.Drawing.Size(177, 26);
            this.Cutbt.Text = "Cut";
            this.Cutbt.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // Pastebt
            // 
            this.Pastebt.Name = "Pastebt";
            this.Pastebt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Pastebt.Size = new System.Drawing.Size(177, 26);
            this.Pastebt.Text = "Paste";
            this.Pastebt.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // msRu
            // 
            this.msRu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msRu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruFileToolStripMenuItem,
            this.ruEditToolStripMenuItem});
            this.msRu.Location = new System.Drawing.Point(0, 0);
            this.msRu.Name = "msRu";
            this.msRu.Size = new System.Drawing.Size(716, 28);
            this.msRu.TabIndex = 3;
            this.msRu.Text = "menuStrip1";
            // 
            // ruFileToolStripMenuItem
            // 
            this.ruFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenRu,
            this.toolStripMenuItem3,
            this.SaveRu,
            this.toolStripMenuItem4,
            this.CloseRu});
            this.ruFileToolStripMenuItem.Name = "ruFileToolStripMenuItem";
            this.ruFileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.ruFileToolStripMenuItem.Text = "Файл";
            // 
            // OpenRu
            // 
            this.OpenRu.Name = "OpenRu";
            this.OpenRu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenRu.Size = new System.Drawing.Size(216, 26);
            this.OpenRu.Text = "Открыть";
            this.OpenRu.Click += new System.EventHandler(this.Open_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(213, 6);
            // 
            // SaveRu
            // 
            this.SaveRu.Name = "SaveRu";
            this.SaveRu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveRu.Size = new System.Drawing.Size(216, 26);
            this.SaveRu.Text = "Сохранить";
            this.SaveRu.Click += new System.EventHandler(this.Safe_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(213, 6);
            // 
            // CloseRu
            // 
            this.CloseRu.Name = "CloseRu";
            this.CloseRu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.CloseRu.Size = new System.Drawing.Size(216, 26);
            this.CloseRu.Text = "Закрыть";
            this.CloseRu.Click += new System.EventHandler(this.Close_Click);
            // 
            // ruEditToolStripMenuItem
            // 
            this.ruEditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruCopy,
            this.ruCut,
            this.ruPaste});
            this.ruEditToolStripMenuItem.Name = "ruEditToolStripMenuItem";
            this.ruEditToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.ruEditToolStripMenuItem.Text = "Правка";
            this.ruEditToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // ruCopy
            // 
            this.ruCopy.Enabled = false;
            this.ruCopy.Name = "ruCopy";
            this.ruCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ruCopy.Size = new System.Drawing.Size(227, 26);
            this.ruCopy.Text = "Копировать";
            this.ruCopy.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // ruCut
            // 
            this.ruCut.Enabled = false;
            this.ruCut.Name = "ruCut";
            this.ruCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ruCut.Size = new System.Drawing.Size(227, 26);
            this.ruCut.Text = "Вырезать";
            this.ruCut.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // ruPaste
            // 
            this.ruPaste.Name = "ruPaste";
            this.ruPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ruPaste.Size = new System.Drawing.Size(227, 26);
            this.ruPaste.Text = "Вставить";
            this.ruPaste.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // cms1
            // 
            this.cms1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(61, 4);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сменить язык";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.msEn);
            this.Controls.Add(this.msRu);
            this.Controls.Add(this.richTextBox1);
            this.MainMenuStrip = this.msEn;
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.msEn.ResumeLayout(false);
            this.msEn.PerformLayout();
            this.msRu.ResumeLayout(false);
            this.msRu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip msEn;
        private System.Windows.Forms.MenuStrip msRu;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.SaveFileDialog SafeFile1;
        private System.Windows.Forms.FontDialog Font_D;
        private System.Windows.Forms.ColorDialog Color_D;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem ruFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenRu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem SaveRu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem CloseRu;
        private System.Windows.Forms.ToolStripMenuItem ruEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruCopy;
        private System.Windows.Forms.ToolStripMenuItem ruCut;
        private System.Windows.Forms.ToolStripMenuItem ruPaste;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Copybt;
        private System.Windows.Forms.ToolStripMenuItem Cutbt;
        private System.Windows.Forms.ToolStripMenuItem Pastebt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripComboBox f_box;
        private System.Windows.Forms.ToolStripComboBox s_box;
        private System.Windows.Forms.ToolStripButton BoldBt;
        private System.Windows.Forms.ToolStripButton ItalBt;
        private System.Windows.Forms.ToolStripButton UndLBt;
        private System.Windows.Forms.ToolStripButton LeftAbt;
        private System.Windows.Forms.ToolStripButton CenterAbt;
        private System.Windows.Forms.ToolStripButton RightAlbt;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

