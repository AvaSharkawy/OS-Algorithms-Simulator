using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSAlgorithmsSimulator.User_Controls.CPU
{
	public partial class CPU_FCFS_UC : UserControl
	{
		#region Private Members

		OSASProcess mProcess;

		#endregion

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

		public CPU_FCFS_UC()
		{
			InitializeComponent();

			Processes = new List<OSASProcess>()
			{
				new OSASProcess
				{
					Id = 1,
					Name = "P0",
					ArrivalTime = 3,
					BurstTime = 2,
					RemainingTime = 2
				},
				new OSASProcess
				{
					Id = 2,
					Name = "P1",
					ArrivalTime = 2,
					BurstTime = 4,
					RemainingTime = 4
				},
				new OSASProcess
				{
					Id = 3,
					Name = "P2",
					ArrivalTime = 0,
					BurstTime = 6,
					RemainingTime = 6
				},
				new OSASProcess
				{
					Id = 4,
					Name = "P3",
					ArrivalTime = 1,
					BurstTime = 4,
					RemainingTime = 4
				},
			};

			//var FSFC = new FCFS_Algorithm(new List<OSASProcess>
			//{
			//	new OSASProcess
			//	{
			//		Name = "P0",
			//		ArrivalTime = 0,
			//		BurstTime = 4
			//	},
			//	new OSASProcess
			//	{
			//		Name = "P1",
			//		ArrivalTime = 8,
			//		BurstTime = 3
			//	},
			//	new OSASProcess
			//	{
			//		Name = "P2",
			//		ArrivalTime = 6,
			//		BurstTime = 1
			//	},
			//	new OSASProcess
			//	{
			//		Name = "P3",
			//		ArrivalTime = 10,
			//		BurstTime = 2
			//	},

			//});

			//FSFC.CalculateProcesses();

			//if (FSFC.CalculatedSuccessfully)
			//{
			//	TerminatedProcess = FSFC.TerminatedProcesses;
			//}
		}

		void RefreshDGV(List<OSASProcess> processes, bool showColumns = false)
		{
			ProDGV.DataSource = processes.Where(a => a.Id > -1).AC_AsDataTable();
			VisualiseProDGV(showColumns);
		}

		void VisualiseProDGV(bool showColumns)
		{
			ProDGV.Columns["PStartTime"].Visible = showColumns;
			ProDGV.Columns["PFinishTime"].Visible = showColumns;
			ProDGV.Columns["PWaitTime"].Visible = showColumns;
			ProDGV.Columns["PTurnAroundTime"].Visible = showColumns;
			lblAVGTA.Visible = showColumns;
			lblAVGWait.Visible = showColumns;

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

		private void CPU_FCFS_UC_Load(object sender, EventArgs e)
		{

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
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			if(SelectedProcess == null)
			{
				ACMessageBox.ShowSelectObjectToContinue();
				return;
			}

			Processes.FirstOrDefault(a => a.Id.Equals(SelectedProcess.Id)).Name = txtProName.Text;
			Processes.FirstOrDefault(a => a.Id.Equals(SelectedProcess.Id)).ArrivalTime = Convert.ToInt32(numArrivalTime.Value);
			Processes.FirstOrDefault(a => a.Id.Equals(SelectedProcess.Id)).BurstTime = Convert.ToInt32(numBurstTime.Value);
			Processes.FirstOrDefault(a => a.Id.Equals(SelectedProcess.Id)).RemainingTime = Convert.ToInt32(numBurstTime.Value);

			RefreshDGV(Processes);
			SelectedProcess = Processes.FirstOrDefault(a => a.Id.Equals(SelectedProcess.Id));
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			if(SelectedProcess == null)
			{
				ACMessageBox.ShowSelectObjectToContinue();
				return;
			}

			Processes.Remove(Processes.FirstOrDefault(a => a.Id.Equals(SelectedProcess.Id)));
			RefreshDGV(Processes);
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			SelectedProcess = null;
			tlpProFields.AC_ClearFields();
		}

		private void BtnStartScheduling_Click(object sender, EventArgs e)
		{
			if (Processes.Count <= 0)
			{
				ACMessageBox.ShowFailedMessage("You must enter some processes to start scheduling");
				return;
			}

			var fcfs = new SJF_Algorithm(Processes,true);

			fcfs.CalculateProcesses();

			TerminatedProcess = fcfs.TerminatedProcesses;
			//TerminatedProcess.DrawGanttChart(DGV, this, GbGanttChart.Location.Y + pnlGanttContainer.Location.Y);
			var gantt = new GanttChart_UC(TerminatedProcess);
			gantt.DrawGanttChart();
			GbGanttChart.Controls.Add(gantt);
			gantt.Dock = DockStyle.Top;
			gantt.Height = 100;

			var count = TerminatedProcess.GroupBy(a=>a.Id).Select(a=>a.FirstOrDefault()).ToList().Count;

			lblAVGWait.Text = $"Wait Time AVG = {TerminatedProcess.Sum(a => a.WaitTime) / (float)count}";
			lblAVGTA.Text = $"Turn-around Time AVG = {TerminatedProcess.Sum(a => a.TurnAroundTime) / (float)count}";

			RefreshDGV(TerminatedProcess, true);
			tlpProFields.Enabled = false;
		}

		private void BtnReset_Click(object sender, EventArgs e)
		{
			Processes = new List<OSASProcess>();
			TerminatedProcess = new List<OSASProcess>();

			RefreshDGV(Processes, false);
			tlpProFields.Enabled = true;

			DGV.Columns.Clear();
			this.CreateGraphics().FillRectangle(new SolidBrush(Color.FromArgb(28, 30, 35)), new RectangleF(new PointF(0, 0), this.Size));
		}

		private void numArrivalTime_Enter(object sender, EventArgs e)
		{
			(sender as NumericUpDown).Select(0, numArrivalTime.Value.ToString().Length);
		}
	}
}
