namespace OSAlgorithmsSimulator.User_Controls.CPU
{
	partial class CPU_FCFS_UC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tlpProDataMain = new System.Windows.Forms.TableLayoutPanel();
			this.ProDGV = new System.Windows.Forms.DataGridView();
			this.tlpProFields = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tlpProButtons = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProName = new System.Windows.Forms.TextBox();
			this.numArrivalTime = new System.Windows.Forms.NumericUpDown();
			this.numBurstTime = new System.Windows.Forms.NumericUpDown();
			this.GbGanttChart = new System.Windows.Forms.GroupBox();
			this.pnlGanttContainer = new System.Windows.Forms.Panel();
			this.DGV = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblAVGWait = new System.Windows.Forms.Label();
			this.lblAVGTA = new System.Windows.Forms.Label();
			this.BtnClear = new System.Windows.Forms.Button();
			this.BtnDelete = new System.Windows.Forms.Button();
			this.BtnEdit = new System.Windows.Forms.Button();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.BtnStartScheduling = new System.Windows.Forms.Button();
			this.BtnReset = new System.Windows.Forms.Button();
			this.PId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PBurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PFinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PWaitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PTurnAroundTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PIsWorking = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tlpMain.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tlpProDataMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProDGV)).BeginInit();
			this.tlpProFields.SuspendLayout();
			this.tlpProButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numArrivalTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numBurstTime)).BeginInit();
			this.GbGanttChart.SuspendLayout();
			this.pnlGanttContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpMain
			// 
			this.tlpMain.BackColor = System.Drawing.Color.Transparent;
			this.tlpMain.ColumnCount = 1;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpMain.Controls.Add(this.groupBox1, 0, 0);
			this.tlpMain.Controls.Add(this.GbGanttChart, 0, 1);
			this.tlpMain.Controls.Add(this.panel1, 0, 2);
			this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpMain.Location = new System.Drawing.Point(0, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 3;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tlpMain.Size = new System.Drawing.Size(1184, 670);
			this.tlpMain.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tlpProDataMain);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new System.Drawing.Font("Cantarell", 20F);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1178, 329);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Processes Data";
			// 
			// tlpProDataMain
			// 
			this.tlpProDataMain.ColumnCount = 2;
			this.tlpProDataMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpProDataMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpProDataMain.Controls.Add(this.ProDGV, 1, 0);
			this.tlpProDataMain.Controls.Add(this.tlpProFields, 0, 0);
			this.tlpProDataMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpProDataMain.Location = new System.Drawing.Point(3, 41);
			this.tlpProDataMain.Name = "tlpProDataMain";
			this.tlpProDataMain.RowCount = 1;
			this.tlpProDataMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpProDataMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 285F));
			this.tlpProDataMain.Size = new System.Drawing.Size(1172, 285);
			this.tlpProDataMain.TabIndex = 0;
			// 
			// ProDGV
			// 
			this.ProDGV.AllowUserToAddRows = false;
			this.ProDGV.AllowUserToDeleteRows = false;
			this.ProDGV.AllowUserToResizeRows = false;
			dataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.ProDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle47;
			this.ProDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.ProDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.ProDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ProDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle48.Font = new System.Drawing.Font("Cantarell", 20F);
			dataGridViewCellStyle48.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle48.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ProDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle48;
			this.ProDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PId,
            this.PName,
            this.PArrivalTime,
            this.PBurstTime,
            this.PPriority,
            this.PStartTime,
            this.PFinishTime,
            this.PWaitTime,
            this.PTurnAroundTime,
            this.PIsWorking});
			this.ProDGV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProDGV.EnableHeadersVisualStyles = false;
			this.ProDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
			this.ProDGV.Location = new System.Drawing.Point(589, 2);
			this.ProDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ProDGV.MultiSelect = false;
			this.ProDGV.Name = "ProDGV";
			this.ProDGV.ReadOnly = true;
			this.ProDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle49.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle49.Font = new System.Drawing.Font("Cantarell", 20F);
			dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ProDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle49;
			this.ProDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
			dataGridViewCellStyle50.Font = new System.Drawing.Font("Hacen Casablanca", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle50.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle50.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.White;
			this.ProDGV.RowsDefaultCellStyle = dataGridViewCellStyle50;
			this.ProDGV.RowTemplate.Height = 40;
			this.ProDGV.RowTemplate.ReadOnly = true;
			this.ProDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ProDGV.Size = new System.Drawing.Size(580, 281);
			this.ProDGV.TabIndex = 4;
			this.ProDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProDGV_CellClick);
			// 
			// tlpProFields
			// 
			this.tlpProFields.ColumnCount = 3;
			this.tlpProFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpProFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tlpProFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpProFields.Controls.Add(this.label3, 0, 2);
			this.tlpProFields.Controls.Add(this.label2, 0, 1);
			this.tlpProFields.Controls.Add(this.tlpProButtons, 2, 0);
			this.tlpProFields.Controls.Add(this.label1, 0, 0);
			this.tlpProFields.Controls.Add(this.txtProName, 1, 0);
			this.tlpProFields.Controls.Add(this.numArrivalTime, 1, 1);
			this.tlpProFields.Controls.Add(this.numBurstTime, 1, 2);
			this.tlpProFields.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpProFields.Location = new System.Drawing.Point(3, 3);
			this.tlpProFields.Name = "tlpProFields";
			this.tlpProFields.RowCount = 3;
			this.tlpProFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpProFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpProFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpProFields.Size = new System.Drawing.Size(580, 279);
			this.tlpProFields.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 93);
			this.label3.TabIndex = 3;
			this.label3.Text = "Burst time*";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 93);
			this.label2.TabIndex = 2;
			this.label2.Text = "Arrival time";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tlpProButtons
			// 
			this.tlpProButtons.ColumnCount = 1;
			this.tlpProButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpProButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpProButtons.Controls.Add(this.BtnClear, 0, 3);
			this.tlpProButtons.Controls.Add(this.BtnDelete, 0, 2);
			this.tlpProButtons.Controls.Add(this.BtnEdit, 0, 1);
			this.tlpProButtons.Controls.Add(this.BtnAdd, 0, 0);
			this.tlpProButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpProButtons.Location = new System.Drawing.Point(409, 3);
			this.tlpProButtons.Name = "tlpProButtons";
			this.tlpProButtons.RowCount = 4;
			this.tlpProFields.SetRowSpan(this.tlpProButtons, 3);
			this.tlpProButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpProButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpProButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpProButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpProButtons.Size = new System.Drawing.Size(168, 273);
			this.tlpProButtons.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 93);
			this.label1.TabIndex = 1;
			this.label1.Text = "Process name*";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtProName
			// 
			this.txtProName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.txtProName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtProName.ForeColor = System.Drawing.Color.White;
			this.txtProName.Location = new System.Drawing.Point(177, 25);
			this.txtProName.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
			this.txtProName.MaxLength = 256;
			this.txtProName.Name = "txtProName";
			this.txtProName.Size = new System.Drawing.Size(226, 45);
			this.txtProName.TabIndex = 1;
			// 
			// numArrivalTime
			// 
			this.numArrivalTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.numArrivalTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numArrivalTime.ForeColor = System.Drawing.Color.White;
			this.numArrivalTime.Location = new System.Drawing.Point(177, 118);
			this.numArrivalTime.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
			this.numArrivalTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numArrivalTime.Name = "numArrivalTime";
			this.numArrivalTime.Size = new System.Drawing.Size(226, 45);
			this.numArrivalTime.TabIndex = 2;
			this.numArrivalTime.Enter += new System.EventHandler(this.numArrivalTime_Enter);
			// 
			// numBurstTime
			// 
			this.numBurstTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.numBurstTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numBurstTime.ForeColor = System.Drawing.Color.White;
			this.numBurstTime.Location = new System.Drawing.Point(177, 211);
			this.numBurstTime.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
			this.numBurstTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numBurstTime.Name = "numBurstTime";
			this.numBurstTime.Size = new System.Drawing.Size(226, 45);
			this.numBurstTime.TabIndex = 3;
			this.numBurstTime.Enter += new System.EventHandler(this.numArrivalTime_Enter);
			// 
			// GbGanttChart
			// 
			this.GbGanttChart.BackColor = System.Drawing.Color.Transparent;
			this.GbGanttChart.Controls.Add(this.pnlGanttContainer);
			this.GbGanttChart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GbGanttChart.Font = new System.Drawing.Font("Cantarell", 20F);
			this.GbGanttChart.ForeColor = System.Drawing.Color.White;
			this.GbGanttChart.Location = new System.Drawing.Point(3, 338);
			this.GbGanttChart.Name = "GbGanttChart";
			this.GbGanttChart.Size = new System.Drawing.Size(1178, 262);
			this.GbGanttChart.TabIndex = 0;
			this.GbGanttChart.TabStop = false;
			this.GbGanttChart.Text = "Gantt Chart";
			// 
			// pnlGanttContainer
			// 
			this.pnlGanttContainer.AutoScroll = true;
			this.pnlGanttContainer.Controls.Add(this.lblAVGTA);
			this.pnlGanttContainer.Controls.Add(this.lblAVGWait);
			this.pnlGanttContainer.Controls.Add(this.DGV);
			this.pnlGanttContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlGanttContainer.Location = new System.Drawing.Point(3, 41);
			this.pnlGanttContainer.Name = "pnlGanttContainer";
			this.pnlGanttContainer.Size = new System.Drawing.Size(1172, 218);
			this.pnlGanttContainer.TabIndex = 19;
			// 
			// DGV
			// 
			this.DGV.AllowUserToAddRows = false;
			this.DGV.AllowUserToDeleteRows = false;
			this.DGV.AllowUserToResizeColumns = false;
			dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle41.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(5)))));
			dataGridViewCellStyle41.NullValue = "0";
			dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(62)))));
			dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.Black;
			this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
			this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			dataGridViewCellStyle42.Font = new System.Drawing.Font("Cantarell", 20F);
			dataGridViewCellStyle42.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
			this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
			dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle44.Font = new System.Drawing.Font("Cantarell", 20F);
			dataGridViewCellStyle44.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(62)))));
			dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGV.DefaultCellStyle = dataGridViewCellStyle44;
			this.DGV.Enabled = false;
			this.DGV.EnableHeadersVisualStyles = false;
			this.DGV.GridColor = System.Drawing.Color.White;
			this.DGV.Location = new System.Drawing.Point(21, 22);
			this.DGV.Margin = new System.Windows.Forms.Padding(0);
			this.DGV.MultiSelect = false;
			this.DGV.Name = "DGV";
			this.DGV.ReadOnly = true;
			this.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle45.Font = new System.Drawing.Font("Cantarell", 20F);
			dataGridViewCellStyle45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(5)))));
			dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(62)))));
			dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle45;
			this.DGV.RowHeadersVisible = false;
			dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle46.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(5)))));
			dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(38)))));
			dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle46;
			this.DGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			this.DGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.DGV.RowTemplate.Height = 50;
			this.DGV.RowTemplate.ReadOnly = true;
			this.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV.Size = new System.Drawing.Size(10, 41);
			this.DGV.TabIndex = 18;
			this.DGV.TabStop = false;
			this.DGV.Visible = false;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewCellStyle43.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(4)))));
			dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(62)))));
			dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle43;
			this.dataGridViewTextBoxColumn1.FillWeight = 98.48485F;
			this.dataGridViewTextBoxColumn1.HeaderText = " ";
			this.dataGridViewTextBoxColumn1.MaxInputLength = 10;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn1.Width = 5;
			// 
			// lblAVGWait
			// 
			this.lblAVGWait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblAVGWait.AutoSize = true;
			this.lblAVGWait.Font = new System.Drawing.Font("Cantarell", 16F);
			this.lblAVGWait.ForeColor = System.Drawing.Color.White;
			this.lblAVGWait.Location = new System.Drawing.Point(88, 147);
			this.lblAVGWait.Name = "lblAVGWait";
			this.lblAVGWait.Size = new System.Drawing.Size(197, 29);
			this.lblAVGWait.TabIndex = 19;
			this.lblAVGWait.Text = "Wait Time AVG = ";
			this.lblAVGWait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblAVGWait.Visible = false;
			// 
			// lblAVGTA
			// 
			this.lblAVGTA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblAVGTA.AutoSize = true;
			this.lblAVGTA.Font = new System.Drawing.Font("Cantarell", 16F);
			this.lblAVGTA.ForeColor = System.Drawing.Color.White;
			this.lblAVGTA.Location = new System.Drawing.Point(7, 176);
			this.lblAVGTA.Name = "lblAVGTA";
			this.lblAVGTA.Size = new System.Drawing.Size(278, 29);
			this.lblAVGTA.TabIndex = 19;
			this.lblAVGTA.Text = "Turnarround Time AVG = ";
			this.lblAVGTA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblAVGTA.Visible = false;
			// 
			// BtnClear
			// 
			this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnClear.FlatAppearance.BorderSize = 0;
			this.BtnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnClear.Font = new System.Drawing.Font("Cantarell", 16F);
			this.BtnClear.ForeColor = System.Drawing.Color.White;
			this.BtnClear.Image = global::OSAlgorithmsSimulator.Properties.Resources.Clean;
			this.BtnClear.Location = new System.Drawing.Point(5, 209);
			this.BtnClear.Margin = new System.Windows.Forms.Padding(5);
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.Size = new System.Drawing.Size(158, 59);
			this.BtnClear.TabIndex = 7;
			this.BtnClear.Text = "Clear";
			this.BtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnClear.UseVisualStyleBackColor = false;
			this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// BtnDelete
			// 
			this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnDelete.FlatAppearance.BorderSize = 0;
			this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnDelete.Font = new System.Drawing.Font("Cantarell", 16F);
			this.BtnDelete.ForeColor = System.Drawing.Color.White;
			this.BtnDelete.Image = global::OSAlgorithmsSimulator.Properties.Resources.Delete;
			this.BtnDelete.Location = new System.Drawing.Point(5, 141);
			this.BtnDelete.Margin = new System.Windows.Forms.Padding(5);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(158, 58);
			this.BtnDelete.TabIndex = 6;
			this.BtnDelete.Text = "Delete";
			this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnDelete.UseVisualStyleBackColor = false;
			this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// BtnEdit
			// 
			this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.BtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnEdit.FlatAppearance.BorderSize = 0;
			this.BtnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			this.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnEdit.Font = new System.Drawing.Font("Cantarell", 16F);
			this.BtnEdit.ForeColor = System.Drawing.Color.White;
			this.BtnEdit.Image = global::OSAlgorithmsSimulator.Properties.Resources.Edit;
			this.BtnEdit.Location = new System.Drawing.Point(5, 73);
			this.BtnEdit.Margin = new System.Windows.Forms.Padding(5);
			this.BtnEdit.Name = "BtnEdit";
			this.BtnEdit.Size = new System.Drawing.Size(158, 58);
			this.BtnEdit.TabIndex = 5;
			this.BtnEdit.Text = "Edit";
			this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnEdit.UseVisualStyleBackColor = false;
			this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
			// 
			// BtnAdd
			// 
			this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnAdd.FlatAppearance.BorderSize = 0;
			this.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAdd.Font = new System.Drawing.Font("Cantarell", 16F);
			this.BtnAdd.ForeColor = System.Drawing.Color.White;
			this.BtnAdd.Image = global::OSAlgorithmsSimulator.Properties.Resources.Add;
			this.BtnAdd.Location = new System.Drawing.Point(5, 5);
			this.BtnAdd.Margin = new System.Windows.Forms.Padding(5);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(158, 58);
			this.BtnAdd.TabIndex = 4;
			this.BtnAdd.Text = "Add";
			this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnAdd.UseVisualStyleBackColor = false;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// BtnStartScheduling
			// 
			this.BtnStartScheduling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnStartScheduling.BackColor = System.Drawing.Color.Transparent;
			this.BtnStartScheduling.FlatAppearance.BorderSize = 0;
			this.BtnStartScheduling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			this.BtnStartScheduling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.BtnStartScheduling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnStartScheduling.Font = new System.Drawing.Font("Cantarell", 16F);
			this.BtnStartScheduling.ForeColor = System.Drawing.Color.White;
			this.BtnStartScheduling.Image = global::OSAlgorithmsSimulator.Properties.Resources.Start;
			this.BtnStartScheduling.Location = new System.Drawing.Point(785, 2);
			this.BtnStartScheduling.Margin = new System.Windows.Forms.Padding(5);
			this.BtnStartScheduling.Name = "BtnStartScheduling";
			this.BtnStartScheduling.Size = new System.Drawing.Size(243, 58);
			this.BtnStartScheduling.TabIndex = 20;
			this.BtnStartScheduling.Text = "Start Scheduling";
			this.BtnStartScheduling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnStartScheduling.UseVisualStyleBackColor = false;
			this.BtnStartScheduling.Click += new System.EventHandler(this.BtnStartScheduling_Click);
			// 
			// BtnReset
			// 
			this.BtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnReset.BackColor = System.Drawing.Color.Transparent;
			this.BtnReset.FlatAppearance.BorderSize = 0;
			this.BtnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			this.BtnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnReset.Font = new System.Drawing.Font("Cantarell", 16F);
			this.BtnReset.ForeColor = System.Drawing.Color.White;
			this.BtnReset.Image = global::OSAlgorithmsSimulator.Properties.Resources.Reload_WF;
			this.BtnReset.Location = new System.Drawing.Point(1038, 2);
			this.BtnReset.Margin = new System.Windows.Forms.Padding(5);
			this.BtnReset.Name = "BtnReset";
			this.BtnReset.Size = new System.Drawing.Size(134, 58);
			this.BtnReset.TabIndex = 20;
			this.BtnReset.Text = "Reset";
			this.BtnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnReset.UseVisualStyleBackColor = false;
			this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// PId
			// 
			this.PId.DataPropertyName = "Id";
			this.PId.HeaderText = "Id";
			this.PId.Name = "PId";
			this.PId.ReadOnly = true;
			this.PId.Visible = false;
			this.PId.Width = 75;
			// 
			// PName
			// 
			this.PName.DataPropertyName = "Name";
			this.PName.HeaderText = "Name";
			this.PName.Name = "PName";
			this.PName.ReadOnly = true;
			this.PName.Width = 123;
			// 
			// PArrivalTime
			// 
			this.PArrivalTime.DataPropertyName = "ArrivalTime";
			this.PArrivalTime.HeaderText = "Arrival Time";
			this.PArrivalTime.Name = "PArrivalTime";
			this.PArrivalTime.ReadOnly = true;
			this.PArrivalTime.Width = 198;
			// 
			// PBurstTime
			// 
			this.PBurstTime.DataPropertyName = "BurstTime";
			this.PBurstTime.HeaderText = "Burst Time";
			this.PBurstTime.Name = "PBurstTime";
			this.PBurstTime.ReadOnly = true;
			this.PBurstTime.Width = 186;
			// 
			// PPriority
			// 
			this.PPriority.DataPropertyName = "Priority";
			this.PPriority.HeaderText = "Priority";
			this.PPriority.Name = "PPriority";
			this.PPriority.ReadOnly = true;
			this.PPriority.Visible = false;
			this.PPriority.Width = 143;
			// 
			// PStartTime
			// 
			this.PStartTime.DataPropertyName = "StartTime";
			this.PStartTime.HeaderText = "Start Time";
			this.PStartTime.Name = "PStartTime";
			this.PStartTime.ReadOnly = true;
			this.PStartTime.Visible = false;
			this.PStartTime.Width = 180;
			// 
			// PFinishTime
			// 
			this.PFinishTime.DataPropertyName = "FinishTime";
			this.PFinishTime.HeaderText = "Finish Time";
			this.PFinishTime.Name = "PFinishTime";
			this.PFinishTime.ReadOnly = true;
			this.PFinishTime.Visible = false;
			this.PFinishTime.Width = 192;
			// 
			// PWaitTime
			// 
			this.PWaitTime.DataPropertyName = "WaitTime";
			this.PWaitTime.HeaderText = "Wait Time";
			this.PWaitTime.Name = "PWaitTime";
			this.PWaitTime.ReadOnly = true;
			this.PWaitTime.Visible = false;
			this.PWaitTime.Width = 177;
			// 
			// PTurnAroundTime
			// 
			this.PTurnAroundTime.DataPropertyName = "TurnAroundTime";
			this.PTurnAroundTime.HeaderText = "TA Time";
			this.PTurnAroundTime.Name = "PTurnAroundTime";
			this.PTurnAroundTime.ReadOnly = true;
			this.PTurnAroundTime.Visible = false;
			this.PTurnAroundTime.Width = 151;
			// 
			// PIsWorking
			// 
			this.PIsWorking.DataPropertyName = "IsWorking";
			this.PIsWorking.HeaderText = "IsWorking";
			this.PIsWorking.Name = "PIsWorking";
			this.PIsWorking.ReadOnly = true;
			this.PIsWorking.Visible = false;
			this.PIsWorking.Width = 181;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.BtnReset);
			this.panel1.Controls.Add(this.BtnStartScheduling);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 606);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1178, 61);
			this.panel1.TabIndex = 2;
			// 
			// CPU_FCFS_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.Controls.Add(this.tlpMain);
			this.Name = "CPU_FCFS_UC";
			this.Size = new System.Drawing.Size(1184, 670);
			this.Load += new System.EventHandler(this.CPU_FCFS_UC_Load);
			this.tlpMain.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tlpProDataMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ProDGV)).EndInit();
			this.tlpProFields.ResumeLayout(false);
			this.tlpProFields.PerformLayout();
			this.tlpProButtons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numArrivalTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numBurstTime)).EndInit();
			this.GbGanttChart.ResumeLayout(false);
			this.pnlGanttContainer.ResumeLayout(false);
			this.pnlGanttContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.GroupBox GbGanttChart;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView DGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.Panel pnlGanttContainer;
		private System.Windows.Forms.TableLayoutPanel tlpProDataMain;
		private System.Windows.Forms.TableLayoutPanel tlpProFields;
		private System.Windows.Forms.TableLayoutPanel tlpProButtons;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProName;
		private System.Windows.Forms.NumericUpDown numArrivalTime;
		private System.Windows.Forms.NumericUpDown numBurstTime;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.Button BtnEdit;
		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.DataGridView ProDGV;
		private System.Windows.Forms.Label lblAVGWait;
		private System.Windows.Forms.Label lblAVGTA;
		private System.Windows.Forms.Button BtnStartScheduling;
		private System.Windows.Forms.Button BtnReset;
		private System.Windows.Forms.DataGridViewTextBoxColumn PId;
		private System.Windows.Forms.DataGridViewTextBoxColumn PName;
		private System.Windows.Forms.DataGridViewTextBoxColumn PArrivalTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn PBurstTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn PPriority;
		private System.Windows.Forms.DataGridViewTextBoxColumn PStartTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn PFinishTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn PWaitTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn PTurnAroundTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn PIsWorking;
		private System.Windows.Forms.Panel panel1;
	}
}
