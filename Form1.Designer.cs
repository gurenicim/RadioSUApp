namespace Radio_App
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Play_Btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectRadioStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyoSUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bBCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bBCRadio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bBCRadio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jazzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daveKozRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Send_btn = new System.Windows.Forms.Button();
            this.Listeners = new System.Windows.Forms.Label();
            this.chatbox_name = new System.Windows.Forms.TextBox();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.tableLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(3, 3);
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Play_Btn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1006F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(223, 1014);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Play_Btn
            // 
            this.Play_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Play_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Play_Btn.Location = new System.Drawing.Point(3, 3);
            this.Play_Btn.Name = "Play_Btn";
            this.Play_Btn.Size = new System.Drawing.Size(217, 1008);
            this.Play_Btn.TabIndex = 1;
            this.Play_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Play_Btn.UseVisualStyleBackColor = true;
            this.Play_Btn.Click += new System.EventHandler(this.Play_Btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Purple;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsernameColumn,
            this.MessageColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.Location = new System.Drawing.Point(1374, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(284, 1014);
            this.dataGridView1.TabIndex = 1;
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.HeaderText = "User Name";
            this.UsernameColumn.MinimumWidth = 12;
            this.UsernameColumn.Name = "UsernameColumn";
            this.UsernameColumn.ReadOnly = true;
            this.UsernameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MessageColumn
            // 
            this.MessageColumn.HeaderText = "Message";
            this.MessageColumn.MinimumWidth = 12;
            this.MessageColumn.Name = "MessageColumn";
            this.MessageColumn.ReadOnly = true;
            this.MessageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectRadioStationToolStripMenuItem,
            this.genreToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1658, 52);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectRadioStationToolStripMenuItem
            // 
            this.selectRadioStationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radyoSUToolStripMenuItem,
            this.bBCToolStripMenuItem});
            this.selectRadioStationToolStripMenuItem.Name = "selectRadioStationToolStripMenuItem";
            this.selectRadioStationToolStripMenuItem.Size = new System.Drawing.Size(305, 48);
            this.selectRadioStationToolStripMenuItem.Text = "Select Radio Station";
            // 
            // radyoSUToolStripMenuItem
            // 
            this.radyoSUToolStripMenuItem.Name = "radyoSUToolStripMenuItem";
            this.radyoSUToolStripMenuItem.Size = new System.Drawing.Size(305, 54);
            this.radyoSUToolStripMenuItem.Text = "RadyoSU";
            this.radyoSUToolStripMenuItem.Click += new System.EventHandler(this.RadyoSUToolStripMenuItem_Click);
            // 
            // bBCToolStripMenuItem
            // 
            this.bBCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bBCRadio1ToolStripMenuItem,
            this.bBCRadio2ToolStripMenuItem});
            this.bBCToolStripMenuItem.Name = "bBCToolStripMenuItem";
            this.bBCToolStripMenuItem.Size = new System.Drawing.Size(305, 54);
            this.bBCToolStripMenuItem.Text = "BBC";
            // 
            // bBCRadio1ToolStripMenuItem
            // 
            this.bBCRadio1ToolStripMenuItem.Name = "bBCRadio1ToolStripMenuItem";
            this.bBCRadio1ToolStripMenuItem.Size = new System.Drawing.Size(345, 54);
            this.bBCRadio1ToolStripMenuItem.Text = "BBC Radio 1";
            this.bBCRadio1ToolStripMenuItem.Click += new System.EventHandler(this.BBCRadio1ToolStripMenuItem_Click);
            // 
            // bBCRadio2ToolStripMenuItem
            // 
            this.bBCRadio2ToolStripMenuItem.Name = "bBCRadio2ToolStripMenuItem";
            this.bBCRadio2ToolStripMenuItem.Size = new System.Drawing.Size(345, 54);
            this.bBCRadio2ToolStripMenuItem.Text = "BBC Radio 2";
            this.bBCRadio2ToolStripMenuItem.Click += new System.EventHandler(this.BBCRadio2ToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jazzToolStripMenuItem});
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(122, 48);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // jazzToolStripMenuItem
            // 
            this.jazzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daveKozRadioToolStripMenuItem});
            this.jazzToolStripMenuItem.Name = "jazzToolStripMenuItem";
            this.jazzToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.jazzToolStripMenuItem.Text = "Jazz";
            // 
            // daveKozRadioToolStripMenuItem
            // 
            this.daveKozRadioToolStripMenuItem.Name = "daveKozRadioToolStripMenuItem";
            this.daveKozRadioToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.daveKozRadioToolStripMenuItem.Text = "Dave Koz Radio";
            this.daveKozRadioToolStripMenuItem.Click += new System.EventHandler(this.DaveKozRadioToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(223, 1025);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1151, 41);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // Send_btn
            // 
            this.Send_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Send_btn.Location = new System.Drawing.Point(1234, 1001);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(140, 65);
            this.Send_btn.TabIndex = 5;
            this.Send_btn.Text = "Send";
            this.Send_btn.UseVisualStyleBackColor = true;
            this.Send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // Listeners
            // 
            this.Listeners.AutoSize = true;
            this.Listeners.Dock = System.Windows.Forms.DockStyle.Top;
            this.Listeners.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listeners.Location = new System.Drawing.Point(223, 52);
            this.Listeners.MinimumSize = new System.Drawing.Size(100, 100);
            this.Listeners.Name = "Listeners";
            this.Listeners.Size = new System.Drawing.Size(474, 161);
            this.Listeners.TabIndex = 6;
            this.Listeners.Text = "Count";
            // 
            // chatbox_name
            // 
            this.chatbox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chatbox_name.Location = new System.Drawing.Point(223, 1001);
            this.chatbox_name.Name = "chatbox_name";
            this.chatbox_name.Size = new System.Drawing.Size(158, 41);
            this.chatbox_name.TabIndex = 7;
            this.chatbox_name.Text = "ChatName";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(94, 48);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1658, 1066);
            this.Controls.Add(this.chatbox_name);
            this.Controls.Add(this.Listeners);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "RadioApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Play_Btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectRadioStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyoSUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bBCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bBCRadio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bBCRadio2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jazzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daveKozRadioToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Send_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Listeners;
        private System.Windows.Forms.TextBox chatbox_name;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

