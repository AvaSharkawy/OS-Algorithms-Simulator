namespace OSAlgorithmsSimulator
{
	partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.TabCPU = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.pnlCpuUCs = new System.Windows.Forms.Panel();
            this.CpuSidePanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.PnlCPUButtonHead = new System.Windows.Forms.Panel();
            this.BtnCPURR = new System.Windows.Forms.Button();
            this.BtnCPUSJF = new System.Windows.Forms.Button();
            this.BtnCPUPriority = new System.Windows.Forms.Button();
            this.BtnCPUFCFS = new System.Windows.Forms.Button();
            this.TabVM = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.pnlVMUcs = new System.Windows.Forms.Panel();
            this.VMSidePanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.PnlVMButtonHead = new System.Windows.Forms.Panel();
            this.BtnVMLFU = new System.Windows.Forms.Button();
            this.BtnVMMFU = new System.Windows.Forms.Button();
            this.BtnVMLRU = new System.Windows.Forms.Button();
            this.BtnVMOptimal = new System.Windows.Forms.Button();
            this.BtnVMFIFO = new System.Windows.Forms.Button();
            this.sfToolTip1 = new Syncfusion.Windows.Forms.SfToolTip(this.components);
            this.BtnVMSecondChance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.TabCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CpuSidePanel)).BeginInit();
            this.CpuSidePanel.SuspendLayout();
            this.TabVM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMSidePanel)).BeginInit();
            this.VMSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(1344, 747);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.BorderWidth = 1;
            this.tabControlAdv1.Controls.Add(this.TabCPU);
            this.tabControlAdv1.Controls.Add(this.TabVM);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.tabControlAdv1.ImageAlignmentR = Syncfusion.Windows.Forms.Tools.RelativeImageAlignment.AboveText;
            this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(1344, 747);
            this.tabControlAdv1.TabIndex = 24;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.tabControlAdv1.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = ((System.Drawing.Image)(resources.GetObject("resource.DisabledNextPageImage")));
            this.tabControlAdv1.ThemeStyle.PrimitiveButtonStyle.NextPageImage = ((System.Drawing.Image)(resources.GetObject("resource.NextPageImage")));
            // 
            // TabCPU
            // 
            this.TabCPU.Controls.Add(this.pnlCpuUCs);
            this.TabCPU.Controls.Add(this.CpuSidePanel);
            this.TabCPU.Image = global::OSAlgorithmsSimulator.Properties.Resources.CPU_1_WF;
            this.TabCPU.ImageSize = new System.Drawing.Size(32, 32);
            this.TabCPU.Location = new System.Drawing.Point(1, 78);
            this.TabCPU.Name = "TabCPU";
            this.TabCPU.ShowCloseButton = true;
            this.TabCPU.Size = new System.Drawing.Size(1342, 668);
            this.TabCPU.TabFont = new System.Drawing.Font("Cantarell", 18.25F);
            this.TabCPU.TabForeColor = System.Drawing.Color.White;
            this.TabCPU.TabIndex = 1;
            this.TabCPU.Text = "CPU Scheduling";
            this.TabCPU.ThemesEnabled = false;
            // 
            // pnlCpuUCs
            // 
            this.pnlCpuUCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCpuUCs.Location = new System.Drawing.Point(160, 0);
            this.pnlCpuUCs.Name = "pnlCpuUCs";
            this.pnlCpuUCs.Size = new System.Drawing.Size(1182, 668);
            this.pnlCpuUCs.TabIndex = 25;
            // 
            // CpuSidePanel
            // 
            this.CpuSidePanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63))))), System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49))))));
            this.CpuSidePanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CpuSidePanel.Controls.Add(this.PnlCPUButtonHead);
            this.CpuSidePanel.Controls.Add(this.BtnCPURR);
            this.CpuSidePanel.Controls.Add(this.BtnCPUSJF);
            this.CpuSidePanel.Controls.Add(this.BtnCPUPriority);
            this.CpuSidePanel.Controls.Add(this.BtnCPUFCFS);
            this.CpuSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CpuSidePanel.Location = new System.Drawing.Point(0, 0);
            this.CpuSidePanel.Name = "CpuSidePanel";
            this.CpuSidePanel.Size = new System.Drawing.Size(160, 668);
            this.CpuSidePanel.TabIndex = 24;
            // 
            // PnlCPUButtonHead
            // 
            this.PnlCPUButtonHead.Location = new System.Drawing.Point(0, 3);
            this.PnlCPUButtonHead.Name = "PnlCPUButtonHead";
            this.PnlCPUButtonHead.Size = new System.Drawing.Size(10, 64);
            this.PnlCPUButtonHead.TabIndex = 14;
            // 
            // BtnCPURR
            // 
            this.BtnCPURR.BackColor = System.Drawing.Color.Transparent;
            this.BtnCPURR.FlatAppearance.BorderSize = 0;
            this.BtnCPURR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.BtnCPURR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.BtnCPURR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCPURR.Font = new System.Drawing.Font("Cantarell", 13F);
            this.BtnCPURR.ForeColor = System.Drawing.Color.White;
            this.BtnCPURR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCPURR.Location = new System.Drawing.Point(10, 206);
            this.BtnCPURR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCPURR.Name = "BtnCPURR";
            this.BtnCPURR.Size = new System.Drawing.Size(150, 64);
            this.BtnCPURR.TabIndex = 13;
            this.BtnCPURR.Text = "Round Robin";
            this.BtnCPURR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCPURR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCPURR.UseVisualStyleBackColor = false;
            this.BtnCPURR.Click += new System.EventHandler(this.BtnCPURR_Click);
            // 
            // BtnCPUSJF
            // 
            this.BtnCPUSJF.BackColor = System.Drawing.Color.Transparent;
            this.BtnCPUSJF.FlatAppearance.BorderSize = 0;
            this.BtnCPUSJF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.BtnCPUSJF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.BtnCPUSJF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCPUSJF.Font = new System.Drawing.Font("Cantarell", 14.25F);
            this.BtnCPUSJF.ForeColor = System.Drawing.Color.White;
            this.BtnCPUSJF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCPUSJF.Location = new System.Drawing.Point(10, 70);
            this.BtnCPUSJF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCPUSJF.Name = "BtnCPUSJF";
            this.BtnCPUSJF.Size = new System.Drawing.Size(150, 64);
            this.BtnCPUSJF.TabIndex = 13;
            this.BtnCPUSJF.Text = "SJF and SRTF";
            this.BtnCPUSJF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCPUSJF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCPUSJF.UseVisualStyleBackColor = false;
            this.BtnCPUSJF.Click += new System.EventHandler(this.BtnCPUSJF_Click);
            // 
            // BtnCPUPriority
            // 
            this.BtnCPUPriority.BackColor = System.Drawing.Color.Transparent;
            this.BtnCPUPriority.FlatAppearance.BorderSize = 0;
            this.BtnCPUPriority.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.BtnCPUPriority.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.BtnCPUPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCPUPriority.Font = new System.Drawing.Font("Cantarell", 13F);
            this.BtnCPUPriority.ForeColor = System.Drawing.Color.White;
            this.BtnCPUPriority.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCPUPriority.Location = new System.Drawing.Point(10, 138);
            this.BtnCPUPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCPUPriority.Name = "BtnCPUPriority";
            this.BtnCPUPriority.Size = new System.Drawing.Size(150, 64);
            this.BtnCPUPriority.TabIndex = 13;
            this.BtnCPUPriority.Text = "Priority";
            this.BtnCPUPriority.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCPUPriority.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCPUPriority.UseVisualStyleBackColor = false;
            this.BtnCPUPriority.Click += new System.EventHandler(this.BtnCPUPriority_Click);
            // 
            // BtnCPUFCFS
            // 
            this.BtnCPUFCFS.BackColor = System.Drawing.Color.Transparent;
            this.BtnCPUFCFS.FlatAppearance.BorderSize = 0;
            this.BtnCPUFCFS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.BtnCPUFCFS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.BtnCPUFCFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCPUFCFS.Font = new System.Drawing.Font("Cantarell", 14.25F);
            this.BtnCPUFCFS.ForeColor = System.Drawing.Color.White;
            this.BtnCPUFCFS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCPUFCFS.Location = new System.Drawing.Point(10, 3);
            this.BtnCPUFCFS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCPUFCFS.Name = "BtnCPUFCFS";
            this.BtnCPUFCFS.Size = new System.Drawing.Size(150, 64);
            this.BtnCPUFCFS.TabIndex = 13;
            this.BtnCPUFCFS.Text = "FCFS";
            this.BtnCPUFCFS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCPUFCFS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCPUFCFS.UseVisualStyleBackColor = false;
            this.BtnCPUFCFS.Click += new System.EventHandler(this.BtnCPUFCFS_Click);
            // 
            // TabVM
            // 
            this.TabVM.Controls.Add(this.pnlVMUcs);
            this.TabVM.Controls.Add(this.VMSidePanel);
            this.TabVM.Image = global::OSAlgorithmsSimulator.Properties.Resources.Ram_WF;
            this.TabVM.ImageSize = new System.Drawing.Size(32, 32);
            this.TabVM.Location = new System.Drawing.Point(1, 78);
            this.TabVM.Name = "TabVM";
            this.TabVM.ShowCloseButton = true;
            this.TabVM.Size = new System.Drawing.Size(1342, 668);
            this.TabVM.TabFont = new System.Drawing.Font("Cantarell", 18.25F);
            this.TabVM.TabForeColor = System.Drawing.Color.White;
            this.TabVM.TabIndex = 2;
            this.TabVM.Text = "Virtual Memory";
            this.TabVM.ThemesEnabled = false;
            // 
            // pnlVMUcs
            // 
            this.pnlVMUcs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVMUcs.Location = new System.Drawing.Point(160, 0);
            this.pnlVMUcs.Name = "pnlVMUcs";
            this.pnlVMUcs.Size = new System.Drawing.Size(1182, 668);
            this.pnlVMUcs.TabIndex = 26;
            // 
            // VMSidePanel
            // 
            this.VMSidePanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63))))), System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49))))));
            this.VMSidePanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VMSidePanel.Controls.Add(this.BtnVMSecondChance);
            this.VMSidePanel.Controls.Add(this.PnlVMButtonHead);
            this.VMSidePanel.Controls.Add(this.BtnVMLFU);
            this.VMSidePanel.Controls.Add(this.BtnVMMFU);
            this.VMSidePanel.Controls.Add(this.BtnVMLRU);
            this.VMSidePanel.Controls.Add(this.BtnVMOptimal);
            this.VMSidePanel.Controls.Add(this.BtnVMFIFO);
            this.VMSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.VMSidePanel.Location = new System.Drawing.Point(0, 0);
            this.VMSidePanel.Name = "VMSidePanel";
            this.VMSidePanel.Size = new System.Drawing.Size(160, 668);
            this.VMSidePanel.TabIndex = 25;
            // 
            // PnlVMButtonHead
            // 
            this.PnlVMButtonHead.Location = new System.Drawing.Point(0, 3);
            this.PnlVMButtonHead.Name = "PnlVMButtonHead";
            this.PnlVMButtonHead.Size = new System.Drawing.Size(10, 64);
            this.PnlVMButtonHead.TabIndex = 14;
            // 
            // BtnVMLFU
            // 
            this.BtnVMLFU.BackColor = System.Drawing.Color.Transparent;
            this.BtnVMLFU.FlatAppearance.BorderSize = 0;
            this.BtnVMLFU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.BtnVMLFU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.BtnVMLFU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVMLFU.Font = new System.Drawing.Font("Cantarell", 13F);
            this.BtnVMLFU.ForeColor = System.Drawing.Color.White;
            this.BtnVMLFU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVMLFU.Location = new System.Drawing.Point(10, 274);
            this.BtnVMLFU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVMLFU.Name = "BtnVMLFU";
            this.BtnVMLFU.Size = new System.Drawing.Size(150, 64);
            this.BtnVMLFU.TabIndex = 13;
            this.BtnVMLFU.Text = "LFU";
            this.BtnVMLFU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVMLFU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVMLFU.UseVisualStyleBackColor = false;
            this.BtnVMLFU.Click += new System.EventHandler(this.BtnVMLFU_Click);
            // 
            // BtnVMMFU
            // 
            this.BtnVMMFU.BackColor = System.Drawing.Color.Transparent;
            this.BtnVMMFU.FlatAppearance.BorderSize = 0;
            this.BtnVMMFU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.BtnVMMFU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.BtnVMMFU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVMMFU.Font = new System.Drawing.Font("Cantarell", 13F);
            this.BtnVMMFU.ForeColor = System.Drawing.Color.White;
            this.BtnVMMFU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVMMFU.Location = new System.Drawing.Point(10, 206);
            this.BtnVMMFU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVMMFU.Name = "BtnVMMFU";
            this.BtnVMMFU.Size = new System.Drawing.Size(150, 64);
            this.BtnVMMFU.TabIndex = 13;
            this.BtnVMMFU.Text = "MFU";
            this.BtnVMMFU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVMMFU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVMMFU.UseVisualStyleBackColor = false;
            this.BtnVMMFU.Click += new System.EventHandler(this.BtnVMMFU_Click);
            // 
            // BtnVMLRU
            // 
            this.BtnVMLRU.BackColor = System.Drawing.Color.Transparent;
            this.BtnVMLRU.FlatAppearance.BorderSize = 0;
            this.BtnVMLRU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.BtnVMLRU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.BtnVMLRU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVMLRU.Font = new System.Drawing.Font("Cantarell", 14.25F);
            this.BtnVMLRU.ForeColor = System.Drawing.Color.White;
            this.BtnVMLRU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVMLRU.Location = new System.Drawing.Point(10, 70);
            this.BtnVMLRU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVMLRU.Name = "BtnVMLRU";
            this.BtnVMLRU.Size = new System.Drawing.Size(150, 64);
            this.BtnVMLRU.TabIndex = 13;
            this.BtnVMLRU.Text = "LRU";
            this.BtnVMLRU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVMLRU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVMLRU.UseVisualStyleBackColor = false;
            this.BtnVMLRU.Click += new System.EventHandler(this.BtnVMLRU_Click);
            // 
            // BtnVMOptimal
            // 
            this.BtnVMOptimal.BackColor = System.Drawing.Color.Transparent;
            this.BtnVMOptimal.FlatAppearance.BorderSize = 0;
            this.BtnVMOptimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.BtnVMOptimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.BtnVMOptimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVMOptimal.Font = new System.Drawing.Font("Cantarell", 13F);
            this.BtnVMOptimal.ForeColor = System.Drawing.Color.White;
            this.BtnVMOptimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVMOptimal.Location = new System.Drawing.Point(10, 138);
            this.BtnVMOptimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVMOptimal.Name = "BtnVMOptimal";
            this.BtnVMOptimal.Size = new System.Drawing.Size(150, 64);
            this.BtnVMOptimal.TabIndex = 13;
            this.BtnVMOptimal.Text = "Optimal";
            this.BtnVMOptimal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVMOptimal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVMOptimal.UseVisualStyleBackColor = false;
            this.BtnVMOptimal.Click += new System.EventHandler(this.BtnVMOptimal_Click);
            // 
            // BtnVMFIFO
            // 
            this.BtnVMFIFO.BackColor = System.Drawing.Color.Transparent;
            this.BtnVMFIFO.FlatAppearance.BorderSize = 0;
            this.BtnVMFIFO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.BtnVMFIFO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.BtnVMFIFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVMFIFO.Font = new System.Drawing.Font("Cantarell", 14.25F);
            this.BtnVMFIFO.ForeColor = System.Drawing.Color.White;
            this.BtnVMFIFO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVMFIFO.Location = new System.Drawing.Point(10, 3);
            this.BtnVMFIFO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVMFIFO.Name = "BtnVMFIFO";
            this.BtnVMFIFO.Size = new System.Drawing.Size(150, 64);
            this.BtnVMFIFO.TabIndex = 13;
            this.BtnVMFIFO.Text = "FIFO";
            this.BtnVMFIFO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVMFIFO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVMFIFO.UseVisualStyleBackColor = false;
            this.BtnVMFIFO.Click += new System.EventHandler(this.BtnVMFIFO_Click);
            // 
            // sfToolTip1
            // 
            this.sfToolTip1.AutoPopDelay = 60000;
            this.sfToolTip1.InitialDelay = 700;
            // 
            // BtnVMSecondChance
            // 
            this.BtnVMSecondChance.BackColor = System.Drawing.Color.Transparent;
            this.BtnVMSecondChance.FlatAppearance.BorderSize = 0;
            this.BtnVMSecondChance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.BtnVMSecondChance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.BtnVMSecondChance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVMSecondChance.Font = new System.Drawing.Font("Cantarell", 13F);
            this.BtnVMSecondChance.ForeColor = System.Drawing.Color.White;
            this.BtnVMSecondChance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVMSecondChance.Location = new System.Drawing.Point(10, 342);
            this.BtnVMSecondChance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVMSecondChance.Name = "BtnVMSecondChance";
            this.BtnVMSecondChance.Size = new System.Drawing.Size(150, 64);
            this.BtnVMSecondChance.TabIndex = 15;
            this.BtnVMSecondChance.Text = "Second Chance";
            this.BtnVMSecondChance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVMSecondChance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVMSecondChance.UseVisualStyleBackColor = false;
            this.BtnVMSecondChance.Click += new System.EventHandler(this.BtnVMSecondChance_Click);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1344, 747);
            this.Controls.Add(this.tabControlAdv1);
            this.Name = "MainDashboard";
            this.Text = "OS Algorithms Simulator";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.TabCPU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CpuSidePanel)).EndInit();
            this.CpuSidePanel.ResumeLayout(false);
            this.TabVM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VMSidePanel)).EndInit();
            this.VMSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button BtnCPUSJF;
		private System.Windows.Forms.Button BtnCPUPriority;
		private System.Windows.Forms.Button BtnCPUFCFS;
		private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv TabCPU;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv TabVM;
		private System.Windows.Forms.Button BtnCPURR;
		private Syncfusion.Windows.Forms.Tools.GradientPanel CpuSidePanel;
		private System.Windows.Forms.Panel PnlCPUButtonHead;
		private System.Windows.Forms.Panel pnlCpuUCs;
		private Syncfusion.Windows.Forms.Tools.GradientPanel VMSidePanel;
		private System.Windows.Forms.Panel PnlVMButtonHead;
		private System.Windows.Forms.Button BtnVMMFU;
		private System.Windows.Forms.Button BtnVMLRU;
		private System.Windows.Forms.Button BtnVMOptimal;
		private System.Windows.Forms.Button BtnVMFIFO;
		private System.Windows.Forms.Button BtnVMLFU;
		private System.Windows.Forms.Panel pnlVMUcs;
		private Syncfusion.Windows.Forms.SfToolTip sfToolTip1;
        private System.Windows.Forms.Button BtnVMSecondChance;
    }
}

