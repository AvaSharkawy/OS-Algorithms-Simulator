using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSAlgorithmsSimulator.User_Controls
{
	public partial class GanttChart_UC : UserControl
	{
		public List<OSASProcess> Processes { get; set; }

		public GanttChart_UC()
		{
			InitializeComponent();
			Processes = new List<OSASProcess>();
		}

		public GanttChart_UC(List<OSASProcess> processes)
		{
			InitializeComponent();
			Processes = processes;
		}

		public void DrawGanttChart()
		{
			if(Processes.Count <= 0)
			{
				MessageBox.Show("Empty processes list");
				return;
			}

			var lastFinish = 0;
			foreach (var p in Processes)
			{
				if (p != Processes.FirstOrDefault())
				{
					if (lastFinish != p.StartTime)
					{
						var nullTime = p.StartTime - lastFinish;
						DataGridViewColumn nullCol = new DataGridViewTextBoxColumn { HeaderText = "", Width = nullTime * 10 };
						DGV.Columns.Add(nullCol);
						DGV.Width += nullCol.Width;
						lastFinish += nullTime;
					}
				}

				DataGridViewColumn column = new DataGridViewTextBoxColumn { HeaderText = p.Name, Width = Math.Max(50, (40 + (10 * p.BurstTime))) };
				DGV.Columns.Add(column);
				DGV.Width += column.Width;
				lastFinish = p.FinishTime;
			}

			DGV.Visible = true;
			lblNumbers.Text = string.Empty;

			//foreach (var p in Processes)
			//{
			//	if (p == Processes.FirstOrDefault())
			//	{
			//		lblNumbers.Text += $"{p.StartTime}";


			//		var sb = new StringBuilder();
			//		sb.Insert(0, " ", Math.Max(5, p.BurstTime + 7));
			//		lblNumbers.Text += $"{sb.ToString()}";


			//		lblNumbers.Text += $"{p.FinishTime}";
			//		lastFinish = p.FinishTime;
			//	}
			//	else
			//	{
			//		if (lastFinish != p.StartTime)
			//		{
			//			var nullTime = p.StartTime - lastFinish;
			//			var sb = new StringBuilder();
			//			sb.Insert(0, " ", nullTime);
			//			lblNumbers.Text += $"{sb.ToString()}";
			//			lblNumbers.Text += $"{p.StartTime}";
			//		}
			//		var sbb = new StringBuilder();
			//		sbb.Insert(0, " ", Math.Max(5, p.BurstTime + 7));
			//		lblNumbers.Text += $"{sbb.ToString()}";
			//		lblNumbers.Text += $"{p.FinishTime}";
			//		lastFinish = p.FinishTime;
			//	}
			//}

			this.Paint += new PaintEventHandler((object sender, PaintEventArgs e) =>
			{
				lblNumbers.Text = string.Empty;
				var graphics = e.Graphics;
				var currentX = DGV.Location.X;
				lastFinish = 0;
				foreach (var p in Processes)
				{
					if (p == Processes.FirstOrDefault())
					{
						lblNumbers.Text += $"{p.StartTime}";

						graphics.DrawString(p.StartTime.ToString(), new Font("consolas", 10), new SolidBrush(Color.White), currentX, DGV.Location.Y + 60);

						var sb = new StringBuilder();
						sb.Insert(0, " ", p.BurstTime);
						lblNumbers.Text += $"{sb.ToString()}";

						currentX += (40 + p.BurstTime * 10);

						lblNumbers.Text += $"{p.FinishTime}";
						graphics.DrawString(p.FinishTime.ToString(), new Font("consolas", 10), new SolidBrush(Color.White), currentX, DGV.Location.Y + 60);
						lastFinish = p.FinishTime;
					}
					else
					{
						if (lastFinish != p.StartTime)
						{
							var nullTime = p.StartTime - lastFinish;
							currentX += nullTime * 10;
							var sb = new StringBuilder();
							sb.Insert(0, " ", nullTime);
							lblNumbers.Text += $"{sb.ToString()}";
							lblNumbers.Text += $"{p.StartTime}";
							graphics.DrawString(p.StartTime.ToString(), new Font("consolas", 10), new SolidBrush(Color.White), currentX, DGV.Location.Y + 60);
						}
						var sbb = new StringBuilder();
						sbb.Insert(0, " ", p.BurstTime);
						lblNumbers.Text += $"{sbb.ToString()}";
						lblNumbers.Text += $"{p.FinishTime}";
						currentX += (40 + p.BurstTime * 10);
						graphics.DrawString(p.FinishTime.ToString(), new Font("consolas", 10), new SolidBrush(Color.White), currentX, DGV.Location.Y + 60);
						lastFinish = p.FinishTime;
					}
				}
			});
			DGV.Visible = false;
			this.Invalidate(true);
		}

		

	}
}
