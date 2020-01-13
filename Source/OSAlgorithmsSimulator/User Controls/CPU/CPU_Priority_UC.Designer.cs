namespace OSAlgorithmsSimulator.User_Controls.CPU
{
	partial class CPU_Priority_UC
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection1 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
			Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection1 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
			Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection1 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tlpProDataMain = new System.Windows.Forms.TableLayoutPanel();
			this.tlpProFields = new System.Windows.Forms.TableLayoutPanel();
			this.numPriority = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tlpProButtons = new System.Windows.Forms.TableLayoutPanel();
			this.BtnClear = new System.Windows.Forms.Button();
			this.BtnDelete = new System.Windows.Forms.Button();
			this.BtnEdit = new System.Windows.Forms.Button();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProName = new System.Windows.Forms.TextBox();
			this.numArrivalTime = new System.Windows.Forms.NumericUpDown();
			this.numBurstTime = new System.Windows.Forms.NumericUpDown();
			this.GbGanttChart = new System.Windows.Forms.GroupBox();
			this.pnlGanttContainer = new System.Windows.Forms.Panel();
			this.DGV = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProDGV = new System.Windows.Forms.DataGridView();
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
			this.PRemainingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTime = new System.Windows.Forms.Label();
			this.lblAVGWait = new System.Windows.Forms.Label();
			this.lblAVGTA = new System.Windows.Forms.Label();
			this.TglAscending = new Syncfusion.Windows.Forms.Tools.ToggleButton();
			this.label5 = new System.Windows.Forms.Label();
			this.BtnReset = new System.Windows.Forms.Button();
			this.BtnStartScheduling = new System.Windows.Forms.Button();
			this.tlpMain.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tlpProDataMain.SuspendLayout();
			this.tlpProFields.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPriority)).BeginInit();
			this.tlpProButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numArrivalTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numBurstTime)).BeginInit();
			this.GbGanttChart.SuspendLayout();
			this.pnlGanttContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProDGV)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TglAscending)).BeginInit();
			this.SuspendLayout();
			// 
			// tlpMain
			// 
			this.tlpMain.BackColor = System.Drawing.Color.Transparent;
			this.tlpMain.ColumnCount = 1;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpMain.Controls.Add(this.groupBox1, 0, 0);
			this.tlpMain.Controls.Add(this.ProDGV, 0, 1);
			this.tlpMain.Controls.Add(this.panel1, 0, 2);
			this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpMain.Font = new System.Drawing.Font("Cantarell", 20F);
			this.tlpMain.Location = new System.Drawing.Point(0, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 3;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tlpMain.Size = new System.Drawing.Size(1184, 670);
			this.tlpMain.TabIndex = 2;
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
			this.tlpProDataMain.Controls.Add(this.tlpProFields, 0, 0);
			this.tlpProDataMain.Controls.Add(this.GbGanttChart, 1, 0);
			this.tlpProDataMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpProDataMain.Location = new System.Drawing.Point(3, 41);
			this.tlpProDataMain.Name = "tlpProDataMain";
			this.tlpProDataMain.RowCount = 1;
			this.tlpProDataMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpProDataMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 285F));
			this.tlpProDataMain.Size = new System.Drawing.Size(1172, 285);
			this.tlpProDataMain.TabIndex = 0;
			// 
			// tlpProFields
			// 
			this.tlpProFields.ColumnCount = 3;
			this.tlpProFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpProFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tlpProFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpProFields.Controls.Add(this.numPriority, 1, 3);
			this.tlpProFields.Controls.Add(this.label4, 0, 3);
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
			this.tlpProFields.RowCount = 4;
			this.tlpProFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
			this.tlpProFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
			this.tlpProFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
			this.tlpProFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
			this.tlpProFields.Size = new System.Drawing.Size(580, 279);
			this.tlpProFields.TabIndex = 0;
			// 
			// numPriority
			// 
			this.numPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.numPriority.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numPriority.ForeColor = System.Drawing.Color.White;
			this.numPriority.Location = new System.Drawing.Point(177, 232);
			this.numPriority.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
			this.numPriority.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numPriority.Name = "numPriority";
			this.numPriority.Size = new System.Drawing.Size(226, 45);
			this.numPriority.TabIndex = 4;
			this.numPriority.Enter += new System.EventHandler(this.numArrivalTime_Enter);
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(168, 72);
			this.label4.TabIndex = 7;
			this.label4.Text = "Priority*";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 69);
			this.label3.TabIndex = 3;
			this.label3.Text = "Burst time*";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 69);
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
			this.tlpProFields.SetRowSpan(this.tlpProButtons, 4);
			this.tlpProButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpProButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpProButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpProButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpProButtons.Size = new System.Drawing.Size(168, 273);
			this.tlpProButtons.TabIndex = 5;
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
			this.BtnClear.TabIndex = 4;
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
			this.BtnDelete.TabIndex = 3;
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
			this.BtnEdit.TabIndex = 2;
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
			this.BtnAdd.TabIndex = 1;
			this.BtnAdd.Text = "Add";
			this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnAdd.UseVisualStyleBackColor = false;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 69);
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
			this.numArrivalTime.Location = new System.Drawing.Point(177, 94);
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
			this.numBurstTime.Location = new System.Drawing.Point(177, 163);
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
			this.GbGanttChart.Location = new System.Drawing.Point(589, 3);
			this.GbGanttChart.Name = "GbGanttChart";
			this.GbGanttChart.Size = new System.Drawing.Size(580, 279);
			this.GbGanttChart.TabIndex = 0;
			this.GbGanttChart.TabStop = false;
			this.GbGanttChart.Text = "Gantt Chart";
			// 
			// pnlGanttContainer
			// 
			this.pnlGanttContainer.AutoScroll = true;
			this.pnlGanttContainer.Controls.Add(this.DGV);
			this.pnlGanttContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlGanttContainer.Location = new System.Drawing.Point(3, 41);
			this.pnlGanttContainer.Name = "pnlGanttContainer";
			this.pnlGanttContainer.Size = new System.Drawing.Size(574, 235);
			this.pnlGanttContainer.TabIndex = 19;
			// 
			// DGV
			// 
			this.DGV.AllowUserToAddRows = false;
			this.DGV.AllowUserToDeleteRows = false;
			this.DGV.AllowUserToResizeColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(5)))));
			dataGridViewCellStyle1.NullValue = "0";
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(62)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Cantarell", 20F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Cantarell", 20F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(62)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGV.DefaultCellStyle = dataGridViewCellStyle4;
			this.DGV.Enabled = false;
			this.DGV.EnableHeadersVisualStyles = false;
			this.DGV.GridColor = System.Drawing.Color.White;
			this.DGV.Location = new System.Drawing.Point(5, 11);
			this.DGV.Margin = new System.Windows.Forms.Padding(0);
			this.DGV.MultiSelect = false;
			this.DGV.Name = "DGV";
			this.DGV.ReadOnly = true;
			this.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Cantarell", 20F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(5)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(62)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.DGV.RowHeadersVisible = false;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(5)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(38)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(4)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(62)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn1.FillWeight = 98.48485F;
			this.dataGridViewTextBoxColumn1.HeaderText = " ";
			this.dataGridViewTextBoxColumn1.MaxInputLength = 10;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn1.Width = 5;
			// 
			// ProDGV
			// 
			this.ProDGV.AllowUserToAddRows = false;
			this.ProDGV.AllowUserToDeleteRows = false;
			this.ProDGV.AllowUserToResizeRows = false;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.ProDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.ProDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.ProDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.ProDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ProDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Cantarell", 20F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ProDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            this.PIsWorking,
            this.PRemainingTime});
			this.ProDGV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProDGV.EnableHeadersVisualStyles = false;
			this.ProDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
			this.ProDGV.Location = new System.Drawing.Point(3, 337);
			this.ProDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ProDGV.MultiSelect = false;
			this.ProDGV.Name = "ProDGV";
			this.ProDGV.ReadOnly = true;
			this.ProDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Cantarell", 20F);
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ProDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.ProDGV.RowHeadersVisible = false;
			this.ProDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Cantarell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
			this.ProDGV.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.ProDGV.RowTemplate.Height = 40;
			this.ProDGV.RowTemplate.ReadOnly = true;
			this.ProDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ProDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ProDGV.Size = new System.Drawing.Size(1178, 264);
			this.ProDGV.TabIndex = 4;
			this.ProDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProDGV_CellClick);
			// 
			// PId
			// 
			this.PId.DataPropertyName = "Id";
			this.PId.HeaderText = "Id";
			this.PId.Name = "PId";
			this.PId.ReadOnly = true;
			this.PId.Visible = false;
			this.PId.Width = 56;
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
			// PRemainingTime
			// 
			this.PRemainingTime.DataPropertyName = "RemainingTime";
			this.PRemainingTime.HeaderText = "Remaining Time";
			this.PRemainingTime.Name = "PRemainingTime";
			this.PRemainingTime.ReadOnly = true;
			this.PRemainingTime.Visible = false;
			this.PRemainingTime.Width = 250;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblTime);
			this.panel1.Controls.Add(this.lblAVGWait);
			this.panel1.Controls.Add(this.lblAVGTA);
			this.panel1.Controls.Add(this.TglAscending);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.BtnReset);
			this.panel1.Controls.Add(this.BtnStartScheduling);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 606);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1178, 61);
			this.panel1.TabIndex = 2;
			// 
			// lblTime
			// 
			this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Cantarell", 14F);
			this.lblTime.ForeColor = System.Drawing.Color.White;
			this.lblTime.Location = new System.Drawing.Point(0, 35);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(246, 25);
			this.lblTime.TabIndex = 24;
			this.lblTime.Text = "Estimated Time = {time}ms";
			this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTime.Visible = false;
			// 
			// lblAVGWait
			// 
			this.lblAVGWait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblAVGWait.AutoSize = true;
			this.lblAVGWait.Font = new System.Drawing.Font("Cantarell", 14F);
			this.lblAVGWait.ForeColor = System.Drawing.Color.White;
			this.lblAVGWait.Location = new System.Drawing.Point(0, 0);
			this.lblAVGWait.Name = "lblAVGWait";
			this.lblAVGWait.Size = new System.Drawing.Size(170, 25);
			this.lblAVGWait.TabIndex = 22;
			this.lblAVGWait.Text = "Wait Time AVG = ";
			this.lblAVGWait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblAVGWait.Visible = false;
			// 
			// lblAVGTA
			// 
			this.lblAVGTA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblAVGTA.AutoSize = true;
			this.lblAVGTA.Font = new System.Drawing.Font("Cantarell", 14F);
			this.lblAVGTA.ForeColor = System.Drawing.Color.White;
			this.lblAVGTA.Location = new System.Drawing.Point(260, 0);
			this.lblAVGTA.Name = "lblAVGTA";
			this.lblAVGTA.Size = new System.Drawing.Size(236, 25);
			this.lblAVGTA.TabIndex = 23;
			this.lblAVGTA.Text = "Turnarround Time AVG = ";
			this.lblAVGTA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblAVGTA.Visible = false;
			// 
			// TglAscending
			// 
			activeStateCollection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
			activeStateCollection1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
			activeStateCollection1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			activeStateCollection1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(176)))));
			this.TglAscending.ActiveState = activeStateCollection1;
			this.TglAscending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.TglAscending.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.TglAscending.ForeColor = System.Drawing.Color.Black;
			inactiveStateCollection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			inactiveStateCollection1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			inactiveStateCollection1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			inactiveStateCollection1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.TglAscending.InactiveState = inactiveStateCollection1;
			this.TglAscending.Location = new System.Drawing.Point(695, 11);
			this.TglAscending.Margin = new System.Windows.Forms.Padding(3, 10, 120, 10);
			this.TglAscending.MinimumSize = new System.Drawing.Size(52, 20);
			this.TglAscending.Name = "TglAscending";
			this.TglAscending.Size = new System.Drawing.Size(90, 40);
			sliderCollection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			sliderCollection1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
			sliderCollection1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			sliderCollection1.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			sliderCollection1.InactiveHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.TglAscending.Slider = sliderCollection1;
			this.TglAscending.TabIndex = 21;
			this.TglAscending.Text = "toggleButton1";
			this.TglAscending.ThemeName = "";
			this.TglAscending.ThemeStyle.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.TglAscending.ThemeStyle.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.TglAscending.ThemeStyle.ActiveHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.TglAscending.ThemeStyle.ActiveHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.TglAscending.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.TglAscending.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.TglAscending.ThemeStyle.InActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.TglAscending.ThemeStyle.InActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.TglAscending.ThemeStyle.InActiveForeColor = System.Drawing.Color.White;
			this.TglAscending.ThemeStyle.InActiveHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.TglAscending.ThemeStyle.InActiveHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cantarell", 14F);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(634, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 25);
			this.label5.TabIndex = 19;
			this.label5.Text = "Desc";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// CPU_Priority_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.Controls.Add(this.tlpMain);
			this.Name = "CPU_Priority_UC";
			this.Size = new System.Drawing.Size(1184, 670);
			this.tlpMain.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tlpProDataMain.ResumeLayout(false);
			this.tlpProFields.ResumeLayout(false);
			this.tlpProFields.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPriority)).EndInit();
			this.tlpProButtons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numArrivalTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numBurstTime)).EndInit();
			this.GbGanttChart.ResumeLayout(false);
			this.pnlGanttContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProDGV)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TglAscending)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tlpProDataMain;
		private System.Windows.Forms.TableLayoutPanel tlpProFields;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tlpProButtons;
		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.Button BtnEdit;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtProName;
		private System.Windows.Forms.NumericUpDown numArrivalTime;
		private System.Windows.Forms.NumericUpDown numBurstTime;
		private System.Windows.Forms.GroupBox GbGanttChart;
		private System.Windows.Forms.Panel pnlGanttContainer;
		private System.Windows.Forms.DataGridView DGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView ProDGV;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button BtnReset;
		private System.Windows.Forms.Button BtnStartScheduling;
		private System.Windows.Forms.NumericUpDown numPriority;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn PRemainingTime;
		private Syncfusion.Windows.Forms.Tools.ToggleButton TglAscending;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblAVGWait;
		private System.Windows.Forms.Label lblAVGTA;
	}
}
