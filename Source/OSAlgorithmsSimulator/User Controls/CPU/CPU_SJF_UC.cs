using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Diagnostics;

namespace OSAlgorithmsSimulator.User_Controls.CPU
{
	public partial class CPU_SJF_UC : UserControl
	{
		#region Private Members

		OSASProcess mProcess;

		#endregion

		#region Public Properties

		public List<OSASProcess> Processes { get; set; } = new List<OSASProcess>();

		public List<OSASProcess> TerminatedProcess { get; set; } = new List<OSASProcess>();

		public OSASProcess SelectedProcess
		{
			get { return mProcess; }
			set
			{
				mProcess = value;

				if (value == null)
					BtnAdd.Enabled = true;
				else
					BtnAdd.Enabled = false;
			}
		}

		#endregion

		public CPU_SJF_UC()
		{
			InitializeComponent();
			Processes = new List<OSASProcess>()
			{
				new OSASProcess
				{
					Id = 1,
					Name = "P1",
					ArrivalTime = 0,
					BurstTime = 5,
					RemainingTime = 5,
					Priority = 2,
				},
				new OSASProcess
				{
					Id = 2,
					Name = "P2",
					ArrivalTime = 1,
					BurstTime = 3,
					RemainingTime = 3,
					Priority = 1,
				},
				new OSASProcess
				{
					Id = 3,
					Name = "P3",
					ArrivalTime = 2,
					BurstTime = 1,
					RemainingTime = 1,
					Priority = 0
				},
				new OSASProcess
				{
					Id = 4,
					Name = "P4",
					ArrivalTime = 3,
					BurstTime = 2,
					RemainingTime = 2,
					Priority = 6
				},
				new OSASProcess
				{
					Id = 4,
					Name = "P5",
					ArrivalTime = 4,
					BurstTime = 3,
					RemainingTime = 3,
					Priority = 6
				},
			};
		}


		void RefreshDGV(List<OSASProcess> processes, bool showColumns = false)
		{
			ProDGV.DataSource = processes.Where(a => a.Id > -1).AC_AsDataTable();
			VisualiseProDGV(showColumns);
			DGV.ClearSelection();
		}

		void VisualiseProDGV(bool showColumns)
		{
			ProDGV.Columns["PStartTime"].Visible = showColumns;
			ProDGV.Columns["PFinishTime"].Visible = showColumns;
			ProDGV.Columns["PWaitTime"].Visible = showColumns;
			ProDGV.Columns["PTurnAroundTime"].Visible = showColumns;
			lblAVGTA.Visible = lblAVGWait.Visible = lblTime.Visible = showColumns;

			ProDGV.Columns["PName"].DisplayIndex = 0;
			ProDGV.Columns["PArrivalTime"].DisplayIndex = 1;
			ProDGV.Columns["PBurstTime"].DisplayIndex = 2;

			if (showColumns)
			{
				ProDGV.Columns["PStartTime"].DisplayIndex = 3;
				ProDGV.Columns["PFinishTime"].DisplayIndex = 4;
				ProDGV.Columns["PWaitTime"].DisplayIndex = 5;
				ProDGV.Columns["PTurnAroundTime"].DisplayIndex = 6;
			}

		}

		private void ProDGV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex <= -1)
				return;

			SelectedProcess = Processes.FirstOrDefault(a => a.Id.Equals(ProDGV.Rows[e.RowIndex].Cells["PId"].Value));
			txtProName.Text = SelectedProcess.Name;
			numArrivalTime.Value = SelectedProcess.ArrivalTime;
			numBurstTime.Value = SelectedProcess.BurstTime;
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			if (!tlpProFields.AC_CheckRequiredFields(txtProName, numBurstTime))
			{
				ACMessageBox.ShowFillRequiredFields();
				return;
			}

			var p = new OSASProcess
			{
				Id = ProDGV.Rows.Count + 1,
				Name = txtProName.Text,
				ArrivalTime = Convert.ToInt32(numArrivalTime.Value),
				BurstTime = Convert.ToInt32(numBurstTime.Value),
				RemainingTime = Convert.ToInt32(numBurstTime.Value),
				StartTime = -1
			};

			Processes.Add(p);

			RefreshDGV(Processes);
			tlpProFields.AC_ClearFields();
			txtProName.Focus();
			SelectedProcess = null;
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			if (SelectedProcess == null)
			{
				ACMessageBox.ShowSelectObjectToContinue();
				return;
			}

			SelectedProcess.Name = txtProName.Text;
			SelectedProcess.ArrivalTime = Convert.ToInt32(numArrivalTime.Value);
			SelectedProcess.BurstTime = Convert.ToInt32(numBurstTime.Value);
			SelectedProcess.RemainingTime = Convert.ToInt32(numBurstTime.Value);

			RefreshDGV(Processes);
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			if (SelectedProcess == null)
			{
				ACMessageBox.ShowSelectObjectToContinue();
				return;
			}

			Processes.Remove(SelectedProcess);
			SelectedProcess = null;
			tlpProFields.AC_ClearFields();
			RefreshDGV(Processes);
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			SelectedProcess = null;
			tlpProFields.AC_ClearFields();
			DGV.ClearSelection();
		}

		private void BtnStartScheduling_Click(object sender, EventArgs e)
		{
			if (Processes.Count <= 0)
			{
				ACMessageBox.ShowFailedMessage("You must enter some processes to start scheduling");
				return;
			}

			var sjf = new CPU_SJF_Algorithm(Processes, TglPreemptive.ToggleState == ToggleButtonState.Active ? true : false);

			var watch = Stopwatch.StartNew();

			sjf.SimulateProcesses();

			watch.Stop();

			TerminatedProcess = sjf.TerminatedProcesses;

			pnlGanttContainer.Controls.Add(new ChartExt(TerminatedProcess));

			var count = TerminatedProcess.GroupBy(a => a.Id).Select(a => a.FirstOrDefault()).ToList().Count;
			
			lblAVGWait.Text = $"Wait Time AVG = {(TerminatedProcess.Sum(a => a.WaitTime) / (float)count).ToString("0.00")}";
			lblAVGTA.Text = $"Turn-around Time AVG = {(TerminatedProcess.Sum(a => a.TurnAroundTime) / (float)count).ToString("0.00")}";
			lblTime.Text = $"Estimated Time= {watch.ElapsedMilliseconds}ms";

			RefreshDGV(TerminatedProcess, true);
			tlpProFields.Enabled = false;
		}

		private void BtnReset_Click(object sender, EventArgs e)
		{
			Processes = new List<OSASProcess>();
			TerminatedProcess = new List<OSASProcess>();

			RefreshDGV(Processes, false);
			tlpProFields.Enabled = true;

			SelectedProcess = null;
			tlpProFields.AC_ClearFields();

			pnlGanttContainer.Controls.Clear();

			DGV.Columns.Clear();
			this.CreateGraphics().FillRectangle(new SolidBrush(Color.FromArgb(28, 30, 35)), new RectangleF(new PointF(0, 0), this.Size));
		}

		private void numArrivalTime_Enter(object sender, EventArgs e)
		{
			(sender as NumericUpDown).Select(0, numArrivalTime.Value.ToString().Length);
		}
	}
}
