namespace RGB_Crustacean
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Toolbar = new System.Windows.Forms.Panel();
            this.AddGradient = new System.Windows.Forms.Button();
            this.gradientList = new System.Windows.Forms.ListBox();
            this.listContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duplicateList = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteList = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.serialButton3 = new System.Windows.Forms.Button();
            this.serialLabel3 = new System.Windows.Forms.Label();
            this.serialLabel1 = new System.Windows.Forms.Label();
            this.serialLabel2 = new System.Windows.Forms.Label();
            this.serialButton2 = new System.Windows.Forms.Button();
            this.serialButton1 = new System.Windows.Forms.Button();
            this.serialText3 = new System.Windows.Forms.TextBox();
            this.serialText2 = new System.Windows.Forms.TextBox();
            this.serialText1 = new System.Windows.Forms.TextBox();
            this.errorText = new System.Windows.Forms.Label();
            this.serial3 = new System.Windows.Forms.ComboBox();
            this.serial2 = new System.Windows.Forms.ComboBox();
            this.serial1 = new System.Windows.Forms.ComboBox();
            this.GradientBox = new System.Windows.Forms.Panel();
            this.gradientName = new System.Windows.Forms.Label();
            this.gradientText = new System.Windows.Forms.TextBox();
            this.Toolbar.SuspendLayout();
            this.listContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toolbar
            // 
            this.Toolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Toolbar.Controls.Add(this.AddGradient);
            this.Toolbar.Controls.Add(this.gradientList);
            this.Toolbar.Controls.Add(this.panel1);
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(155, 450);
            this.Toolbar.TabIndex = 0;
            // 
            // AddGradient
            // 
            this.AddGradient.BackColor = System.Drawing.Color.Transparent;
            this.AddGradient.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGradient.Location = new System.Drawing.Point(11, 408);
            this.AddGradient.Name = "AddGradient";
            this.AddGradient.Size = new System.Drawing.Size(120, 29);
            this.AddGradient.TabIndex = 13;
            this.AddGradient.Text = "Add Gradient";
            this.AddGradient.UseVisualStyleBackColor = false;
            this.AddGradient.Click += new System.EventHandler(this.AddGradient_Click);
            // 
            // gradientList
            // 
            this.gradientList.ContextMenuStrip = this.listContextMenu;
            this.gradientList.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientList.FormattingEnabled = true;
            this.gradientList.ItemHeight = 17;
            this.gradientList.Location = new System.Drawing.Point(11, 67);
            this.gradientList.Name = "gradientList";
            this.gradientList.Size = new System.Drawing.Size(120, 327);
            this.gradientList.TabIndex = 0;
            this.gradientList.SelectedIndexChanged += new System.EventHandler(this.gradientList_SelectedIndexChanged);
            // 
            // listContextMenu
            // 
            this.listContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplicateList,
            this.deleteList});
            this.listContextMenu.Name = "listContextMenu";
            this.listContextMenu.Size = new System.Drawing.Size(125, 48);
            this.listContextMenu.Opened += new System.EventHandler(this.listContextMenu_Opened);
            // 
            // duplicateList
            // 
            this.duplicateList.Name = "duplicateList";
            this.duplicateList.Size = new System.Drawing.Size(124, 22);
            this.duplicateList.Text = "Duplicate";
            this.duplicateList.Click += new System.EventHandler(this.duplicateList_Click);
            // 
            // deleteList
            // 
            this.deleteList.Name = "deleteList";
            this.deleteList.Size = new System.Drawing.Size(124, 22);
            this.deleteList.Text = "Delete";
            this.deleteList.Click += new System.EventHandler(this.deleteList_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 61);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomPanel.Controls.Add(this.serialButton3);
            this.BottomPanel.Controls.Add(this.serialLabel3);
            this.BottomPanel.Controls.Add(this.serialLabel1);
            this.BottomPanel.Controls.Add(this.serialLabel2);
            this.BottomPanel.Controls.Add(this.serialButton2);
            this.BottomPanel.Controls.Add(this.serialButton1);
            this.BottomPanel.Controls.Add(this.serialText3);
            this.BottomPanel.Controls.Add(this.serialText2);
            this.BottomPanel.Controls.Add(this.serialText1);
            this.BottomPanel.Controls.Add(this.errorText);
            this.BottomPanel.Controls.Add(this.serial3);
            this.BottomPanel.Controls.Add(this.serial2);
            this.BottomPanel.Controls.Add(this.serial1);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(155, 302);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(645, 148);
            this.BottomPanel.TabIndex = 1;
            // 
            // serialButton3
            // 
            this.serialButton3.BackColor = System.Drawing.Color.Transparent;
            this.serialButton3.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialButton3.Location = new System.Drawing.Point(296, 84);
            this.serialButton3.Name = "serialButton3";
            this.serialButton3.Size = new System.Drawing.Size(106, 29);
            this.serialButton3.TabIndex = 10;
            this.serialButton3.Text = "button3";
            this.serialButton3.UseVisualStyleBackColor = false;
            this.serialButton3.Click += new System.EventHandler(this.serialButton3_Click);
            // 
            // serialLabel3
            // 
            this.serialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialLabel3.AutoSize = true;
            this.serialLabel3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serialLabel3.Location = new System.Drawing.Point(36, 87);
            this.serialLabel3.Name = "serialLabel3";
            this.serialLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serialLabel3.Size = new System.Drawing.Size(63, 24);
            this.serialLabel3.TabIndex = 12;
            this.serialLabel3.Text = "label3";
            this.serialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.serialLabel3.Visible = false;
            this.serialLabel3.Click += new System.EventHandler(this.serialLabel3_Click);
            // 
            // serialLabel1
            // 
            this.serialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialLabel1.AutoSize = true;
            this.serialLabel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serialLabel1.Location = new System.Drawing.Point(36, 11);
            this.serialLabel1.Name = "serialLabel1";
            this.serialLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serialLabel1.Size = new System.Drawing.Size(63, 24);
            this.serialLabel1.TabIndex = 2;
            this.serialLabel1.Text = "label1";
            this.serialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.serialLabel1.Click += new System.EventHandler(this.serialLabel1_Click);
            // 
            // serialLabel2
            // 
            this.serialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialLabel2.AutoSize = true;
            this.serialLabel2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serialLabel2.Location = new System.Drawing.Point(36, 49);
            this.serialLabel2.Name = "serialLabel2";
            this.serialLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serialLabel2.Size = new System.Drawing.Size(63, 24);
            this.serialLabel2.TabIndex = 11;
            this.serialLabel2.Text = "label2";
            this.serialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.serialLabel2.Click += new System.EventHandler(this.serialLabel2_Click);
            // 
            // serialButton2
            // 
            this.serialButton2.BackColor = System.Drawing.Color.Transparent;
            this.serialButton2.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialButton2.Location = new System.Drawing.Point(296, 46);
            this.serialButton2.Name = "serialButton2";
            this.serialButton2.Size = new System.Drawing.Size(106, 29);
            this.serialButton2.TabIndex = 9;
            this.serialButton2.Text = "button2";
            this.serialButton2.UseVisualStyleBackColor = false;
            this.serialButton2.Click += new System.EventHandler(this.serialButton2_Click);
            // 
            // serialButton1
            // 
            this.serialButton1.BackColor = System.Drawing.Color.Transparent;
            this.serialButton1.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialButton1.Location = new System.Drawing.Point(296, 8);
            this.serialButton1.Name = "serialButton1";
            this.serialButton1.Size = new System.Drawing.Size(106, 29);
            this.serialButton1.TabIndex = 8;
            this.serialButton1.Text = "button1";
            this.serialButton1.UseVisualStyleBackColor = false;
            this.serialButton1.Click += new System.EventHandler(this.serialButton1_Click);
            // 
            // serialText3
            // 
            this.serialText3.Location = new System.Drawing.Point(19, 84);
            this.serialText3.MaxLength = 10;
            this.serialText3.Name = "serialText3";
            this.serialText3.Size = new System.Drawing.Size(100, 29);
            this.serialText3.TabIndex = 7;
            this.serialText3.Text = "Device3";
            this.serialText3.TextChanged += new System.EventHandler(this.serialText3_TextChanged);
            // 
            // serialText2
            // 
            this.serialText2.Location = new System.Drawing.Point(19, 46);
            this.serialText2.MaxLength = 10;
            this.serialText2.Name = "serialText2";
            this.serialText2.Size = new System.Drawing.Size(100, 29);
            this.serialText2.TabIndex = 6;
            this.serialText2.Text = "Device2";
            this.serialText2.TextChanged += new System.EventHandler(this.serialText2_TextChanged);
            // 
            // serialText1
            // 
            this.serialText1.Location = new System.Drawing.Point(19, 8);
            this.serialText1.MaxLength = 10;
            this.serialText1.Name = "serialText1";
            this.serialText1.Size = new System.Drawing.Size(100, 29);
            this.serialText1.TabIndex = 5;
            this.serialText1.Text = "Device1";
            this.serialText1.TextChanged += new System.EventHandler(this.serialText1_TextChanged);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Location = new System.Drawing.Point(165, 123);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(41, 16);
            this.errorText.TabIndex = 4;
            this.errorText.Text = "label2";
            this.errorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorText.Click += new System.EventHandler(this.errorText_Click);
            // 
            // serial3
            // 
            this.serial3.FormattingEnabled = true;
            this.serial3.Location = new System.Drawing.Point(169, 84);
            this.serial3.Name = "serial3";
            this.serial3.Size = new System.Drawing.Size(121, 32);
            this.serial3.TabIndex = 2;
            this.serial3.SelectedIndexChanged += new System.EventHandler(this.serial3_SelectedIndexChanged);
            // 
            // serial2
            // 
            this.serial2.FormattingEnabled = true;
            this.serial2.Location = new System.Drawing.Point(169, 46);
            this.serial2.Name = "serial2";
            this.serial2.Size = new System.Drawing.Size(121, 32);
            this.serial2.TabIndex = 1;
            this.serial2.SelectedIndexChanged += new System.EventHandler(this.serial2_SelectedIndexChanged);
            // 
            // serial1
            // 
            this.serial1.FormattingEnabled = true;
            this.serial1.Location = new System.Drawing.Point(169, 8);
            this.serial1.Name = "serial1";
            this.serial1.Size = new System.Drawing.Size(121, 32);
            this.serial1.TabIndex = 0;
            this.serial1.SelectedIndexChanged += new System.EventHandler(this.serial1_SelectedIndexChanged);
            // 
            // GradientBox
            // 
            this.GradientBox.Location = new System.Drawing.Point(160, 12);
            this.GradientBox.Name = "GradientBox";
            this.GradientBox.Size = new System.Drawing.Size(628, 100);
            this.GradientBox.TabIndex = 2;
            this.GradientBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GradientBox_Paint);
            // 
            // gradientName
            // 
            this.gradientName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientName.AutoSize = true;
            this.gradientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gradientName.Location = new System.Drawing.Point(175, 121);
            this.gradientName.Name = "gradientName";
            this.gradientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gradientName.Size = new System.Drawing.Size(134, 24);
            this.gradientName.TabIndex = 13;
            this.gradientName.Text = "gradientName";
            this.gradientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gradientName.Click += new System.EventHandler(this.gradientName_Click);
            // 
            // gradientText
            // 
            this.gradientText.Location = new System.Drawing.Point(161, 118);
            this.gradientText.MaxLength = 10;
            this.gradientText.Name = "gradientText";
            this.gradientText.Size = new System.Drawing.Size(100, 29);
            this.gradientText.TabIndex = 13;
            this.gradientText.Text = "gradientText";
            this.gradientText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientText);
            this.Controls.Add(this.gradientName);
            this.Controls.Add(this.GradientBox);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.Toolbar);
            this.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "RGB Crustacean";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Toolbar.ResumeLayout(false);
            this.listContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Toolbar;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox serial3;
        private System.Windows.Forms.ComboBox serial2;
        private System.Windows.Forms.ComboBox serial1;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.TextBox serialText3;
        private System.Windows.Forms.TextBox serialText2;
        private System.Windows.Forms.TextBox serialText1;
        private System.Windows.Forms.Button serialButton3;
        private System.Windows.Forms.Button serialButton2;
        private System.Windows.Forms.Button serialButton1;
        private System.Windows.Forms.Label serialLabel1;
        private System.Windows.Forms.Label serialLabel2;
        private System.Windows.Forms.Label serialLabel3;
        private System.Windows.Forms.Panel GradientBox;
        private System.Windows.Forms.ListBox gradientList;
        private System.Windows.Forms.Button AddGradient;
        private System.Windows.Forms.ContextMenuStrip listContextMenu;
        private System.Windows.Forms.ToolStripMenuItem duplicateList;
        private System.Windows.Forms.ToolStripMenuItem deleteList;
        private System.Windows.Forms.Label gradientName;
        private System.Windows.Forms.TextBox gradientText;
    }
}

