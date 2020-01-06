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
		}

		public GanttChart_UC(List<OSASProcess> processes)
		{
			Processes = processes;
		}

		public void DrawGanttChart(UserControl uc)
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

			uc.Paint += new PaintEventHandler((object sender, PaintEventArgs e) =>
			{
				var graphics = e.Graphics;
				var currentX = DGV.Location.X;
				lastFinish = 0;
				foreach (var p in Processes)
				{
					if (p == Processes.FirstOrDefault())
					{
						graphics.DrawString(p.StartTime.ToString(), new Font("consolas", 10), new SolidBrush(Color.White), currentX, DGV.Location.Y + 60);
						currentX += (40 + p.BurstTime * 10);
						graphics.DrawString(p.FinishTime.ToString(), new Font("consolas", 10), new SolidBrush(Color.White), currentX, DGV.Location.Y + 60);
						lastFinish = p.FinishTime;
					}
					else
					{
						if (lastFinish != p.StartTime)
						{
							var nullTime = p.StartTime - lastFinish;
							currentX += nullTime * 10;
							graphics.DrawString(p.StartTime.ToString(), new Font("consolas", 10), new SolidBrush(Color.White), currentX, DGV.Location.Y + 60);
						}

						currentX += (40 + p.BurstTime * 10);
						graphics.DrawString(p.FinishTime.ToString(), new Font("consolas", 10), new SolidBrush(Color.White), currentX, DGV.Location.Y + 60);
						lastFinish = p.FinishTime;
					}
				}
			});
		}

	}
}
