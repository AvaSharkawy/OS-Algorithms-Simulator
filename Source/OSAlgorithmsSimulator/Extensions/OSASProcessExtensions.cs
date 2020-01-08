using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// Helper methods for <see cref="OSASProcess"/>
	/// </summary>
	public static class OSASProcessExtensions
	{
		public static void DrawGanttChart(this List<OSASProcess> processes, DataGridView DGV, UserControl senderUC, int startY)
		{
			var lastFinish = 0;
			foreach (var p in processes)
			{
				if(p!= processes.FirstOrDefault())
				{
					if(lastFinish != p.StartTime)
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

			senderUC.Paint += new PaintEventHandler((object sender, PaintEventArgs e) =>
			{
				var graphics = e.Graphics;
				var currentX = DGV.Location.X;
				lastFinish = 0;
				foreach (var p in processes)
				{
					if (p == processes.FirstOrDefault())
					{
						graphics.DrawString(p.StartTime.ToString(), new Font("consolas", 10), new SolidBrush(Color.White), currentX, DGV.Location.Y + 60 + startY);
						currentX += (40 + p.BurstTime * 10);
						graphics.DrawString(p.FinishTime.ToString(), new Font("consolas", 10), new SolidBrush(Color.White), currentX, DGV.Location.Y + 60 + startY);
						lastFinish = p.FinishTime;
					}
					else
					{
						if(lastFinish != p.StartTime)
						{
							var nullTime = p.StartTime - lastFinish;
							currentX += nullTime * 10;
							graphics.DrawString(p.StartTime.ToString(), new Font("consolas", 10), new SolidBrush(Color.White), currentX, DGV.Location.Y + 60 + startY);
						}

						currentX += (40 + p.BurstTime * 10);
						graphics.DrawString(p.FinishTime.ToString(), new Font("consolas", 10), new SolidBrush(Color.White), currentX, DGV.Location.Y + 60 + startY);
						lastFinish = p.FinishTime;
					}
				}
			});

		}
	
		public static BindingList<ChartProcess> AsBindingList(this List<OSASProcess> list)
		{
			var retlist = new BindingList<ChartProcess>();

			foreach (var p in list)
				retlist.Add(new ChartProcess("1999", p.FinishTime-p.StartTime, p.Name));

			return retlist;
		}
	}
}
