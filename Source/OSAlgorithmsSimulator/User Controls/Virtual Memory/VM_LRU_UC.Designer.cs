namespace OSAlgorithmsSimulator.User_Controls.Virtual_Memory
{
	partial class VM_LRU_UC
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.GbGrid = new System.Windows.Forms.GroupBox();
			this.DGV = new System.Windows.Forms.DataGridView();
			this.GbInput = new System.Windows.Forms.GroupBox();
			this.TlpInputFields = new System.Windows.Forms.TableLayoutPanel();
			this.txtInputString = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.NumFramesCount = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblFaults = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.lblHits = new System.Windows.Forms.Label();
			this.BtnReset = new System.Windows.Forms.Button();
			this.BtnStart = new System.Windows.Forms.Button();
			this.tlpMain.SuspendLayout();
			this.GbGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
			this.GbInput.SuspendLayout();
			this.TlpInputFields.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumFramesCount)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpMain
			// 
			this.tlpMain.ColumnCount = 1;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpMain.Controls.Add(this.GbGrid, 0, 1);
			this.tlpMain.Controls.Add(this.GbInput, 0, 0);
			this.tlpMain.Controls.Add(this.panel1, 0, 2);
			this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpMain.Location = new System.Drawing.Point(0, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 3;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpMain.Size = new System.Drawing.Size(1184, 670);
			this.tlpMain.TabIndex = 1;
			// 
			// GbGrid
			// 
			this.GbGrid.Controls.Add(this.DGV);
			this.GbGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GbGrid.Font = new System.Drawing.Font("Cantarell", 20F);
			this.GbGrid.ForeColor = System.Drawing.Color.White;
			this.GbGrid.Location = new System.Drawing.Point(3, 170);
			this.GbGrid.Name = "GbGrid";
			this.GbGrid.Size = new System.Drawing.Size(1178, 396);
			this.GbGrid.TabIndex = 4;
			this.GbGrid.TabStop = false;
			this.GbGrid.Text = "Output Grid";
			// 
			// DGV
			// 
			this.DGV.AllowUserToAddRows = false;
			this.DGV.AllowUserToDeleteRows = false;
			this.DGV.AllowUserToResizeColumns = false;
			this.DGV.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Cantarell", 20F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Cantarell", 20F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGV.DefaultCellStyle = dataGridViewCellStyle3;
			this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DGV.EnableHeadersVisualStyles = false;
			this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
			this.DGV.Location = new System.Drawing.Point(3, 41);
			this.DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DGV.MultiSelect = false;
			this.DGV.Name = "DGV";
			this.DGV.ReadOnly = true;
			this.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Cantarell", 20F);
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.DGV.RowHeadersVisible = false;
			this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Cantarell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.DGV.RowTemplate.Height = 40;
			this.DGV.RowTemplate.ReadOnly = true;
			this.DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV.Size = new System.Drawing.Size(1172, 352);
			this.DGV.TabIndex = 5;
			// 
			// GbInput
			// 
			this.GbInput.Controls.Add(this.TlpInputFields);
			this.GbInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GbInput.Font = new System.Drawing.Font("Cantarell", 20F);
			this.GbInput.ForeColor = System.Drawing.Color.White;
			this.GbInput.Location = new System.Drawing.Point(3, 3);
			this.GbInput.Name = "GbInput";
			this.GbInput.Size = new System.Drawing.Size(1178, 161);
			this.GbInput.TabIndex = 2;
			this.GbInput.TabStop = false;
			this.GbInput.Text = "Input Details";
			// 
			// TlpInputFields
			// 
			this.TlpInputFields.ColumnCount = 2;
			this.TlpInputFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TlpInputFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.TlpInputFields.Controls.Add(this.txtInputString, 1, 0);
			this.TlpInputFields.Controls.Add(this.label1, 0, 1);
			this.TlpInputFields.Controls.Add(this.NumFramesCount, 1, 1);
			this.TlpInputFields.Controls.Add(this.label4, 0, 0);
			this.TlpInputFields.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TlpInputFields.Location = new System.Drawing.Point(3, 41);
			this.TlpInputFields.Name = "TlpInputFields";
			this.TlpInputFields.RowCount = 2;
			this.TlpInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TlpInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TlpInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TlpInputFields.Size = new System.Drawing.Size(1172, 117);
			this.TlpInputFields.TabIndex = 0;
			// 
			// txtInputString
			// 
			this.txtInputString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.txtInputString.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtInputString.ForeColor = System.Drawing.Color.White;
			this.txtInputString.Location = new System.Drawing.Point(237, 3);
			this.txtInputString.MaxLength = 256;
			this.txtInputString.Name = "txtInputString";
			this.txtInputString.Size = new System.Drawing.Size(932, 45);
			this.txtInputString.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 59);
			this.label1.TabIndex = 4;
			this.label1.Text = "Frames count*";
			// 
			// NumFramesCount
			// 
			this.NumFramesCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.NumFramesCount.Dock = System.Windows.Forms.DockStyle.Left;
			this.NumFramesCount.ForeColor = System.Drawing.Color.White;
			this.NumFramesCount.Location = new System.Drawing.Point(237, 61);
			this.NumFramesCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.NumFramesCount.Name = "NumFramesCount";
			this.NumFramesCount.Size = new System.Drawing.Size(85, 45);
			this.NumFramesCount.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(228, 58);
			this.label4.TabIndex = 2;
			this.label4.Text = "Input string*";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblFaults);
			this.panel1.Controls.Add(this.lblTime);
			this.panel1.Controls.Add(this.lblHits);
			this.panel1.Controls.Add(this.BtnReset);
			this.panel1.Controls.Add(this.BtnStart);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 572);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1178, 95);
			this.panel1.TabIndex = 3;
			// 
			// lblFaults
			// 
			this.lblFaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblFaults.AutoSize = true;
			this.lblFaults.Font = new System.Drawing.Font("Cantarell", 14F);
			this.lblFaults.ForeColor = System.Drawing.Color.White;
			this.lblFaults.Location = new System.Drawing.Point(7, 18);
			this.lblFaults.Name = "lblFaults";
			this.lblFaults.Size = new System.Drawing.Size(137, 25);
			this.lblFaults.TabIndex = 25;
			this.lblFaults.Text = "Page Faults = ";
			this.lblFaults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblFaults.Visible = false;
			// 
			// lblTime
			// 
			this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Cantarell", 14F);
			this.lblTime.ForeColor = System.Drawing.Color.White;
			this.lblTime.Location = new System.Drawing.Point(7, 53);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(246, 25);
			this.lblTime.TabIndex = 26;
			this.lblTime.Text = "Estimated Time = {time}ms";
			this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTime.Visible = false;
			// 
			// lblHits
			// 
			this.lblHits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblHits.AutoSize = true;
			this.lblHits.Font = new System.Drawing.Font("Cantarell", 14F);
			this.lblHits.ForeColor = System.Drawing.Color.White;
			this.lblHits.Location = new System.Drawing.Point(298, 18);
			this.lblHits.Name = "lblHits";
			this.lblHits.Size = new System.Drawing.Size(119, 25);
			this.lblHits.TabIndex = 27;
			this.lblHits.Text = "Page Hits = ";
			this.lblHits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblHits.Visible = false;
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
			this.BtnReset.Location = new System.Drawing.Point(1036, 18);
			this.BtnReset.Margin = new System.Windows.Forms.Padding(5);
			this.BtnReset.Name = "BtnReset";
			this.BtnReset.Size = new System.Drawing.Size(135, 60);
			this.BtnReset.TabIndex = 23;
			this.BtnReset.Text = "Reset";
			this.BtnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnReset.UseVisualStyleBackColor = false;
			this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// BtnStart
			// 
			this.BtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnStart.BackColor = System.Drawing.Color.Transparent;
			this.BtnStart.FlatAppearance.BorderSize = 0;
			this.BtnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
			this.BtnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnStart.Font = new System.Drawing.Font("Cantarell", 16F);
			this.BtnStart.ForeColor = System.Drawing.Color.White;
			this.BtnStart.Image = global::OSAlgorithmsSimulator.Properties.Resources.Start;
			this.BtnStart.Location = new System.Drawing.Point(891, 18);
			this.BtnStart.Margin = new System.Windows.Forms.Padding(5);
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.Size = new System.Drawing.Size(135, 60);
			this.BtnStart.TabIndex = 24;
			this.BtnStart.Text = "Start";
			this.BtnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnStart.UseVisualStyleBackColor = false;
			this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// VM_LRU_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.Controls.Add(this.tlpMain);
			this.Name = "VM_LRU_UC";
			this.Size = new System.Drawing.Size(1184, 670);
			this.tlpMain.ResumeLayout(false);
			this.GbGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
			this.GbInput.ResumeLayout(false);
			this.TlpInputFields.ResumeLayout(false);
			this.TlpInputFields.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumFramesCount)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.GroupBox GbGrid;
		private System.Windows.Forms.DataGridView DGV;
		private System.Windows.Forms.GroupBox GbInput;
		private System.Windows.Forms.TableLayoutPanel TlpInputFields;
		private System.Windows.Forms.TextBox txtInputString;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown NumFramesCount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button BtnReset;
		private System.Windows.Forms.Button BtnStart;
		private System.Windows.Forms.Label lblFaults;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblHits;
	}
}
