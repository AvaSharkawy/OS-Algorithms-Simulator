using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// Helper methods for <see cref="OSASVMObject"/>
	/// </summary>
	public static class OSASVMObjectExtensions
	{
		public static DataTable AsDataTable(this List<OSASVMObject> list, int rows)
		{
			var dt = new DataTable();

			dt.Columns.Add("String");

			foreach(var obj in list)
			{
				dt.Columns.Add($"Num{obj.Index}");
			}

			for (int i = 0; i < rows; i++)
			{
				var row = dt.NewRow();

				row[0] = $"Frame{i + 1}";

				foreach (var obj in list)
				{
					if (obj.Hit)
						row[obj.Index+1] = " ";
					else
					{
						if (obj.Frames.Count < i + 1)
							row[obj.Index+1] = " ";
						else
							row[obj.Index+1] = obj.Frames[i].ToString();
					}
				}

				dt.Rows.Add(row);
			}

			var HFRow = dt.NewRow();

			HFRow[0] = "Fault";

			foreach(var obj in list)
				HFRow[obj.Index+1] = (obj.Hit) ? "H" : "F";

			dt.Rows.Add(HFRow);

			return dt;
		}

		public static void FillDGV(this List<OSASVMObject> list, int framesCount, DataGridView DGV)
		{
			foreach (var obj in list)
			{
				var column = new DataGridViewTextBoxColumn();
				column.Name = $"Num{obj.Index}";
				column.DataPropertyName = $"Num{obj.Index}";
				column.HeaderText = obj.InputObject.ToString();
				column.DisplayIndex = obj.Index;
				column.Width = 50;

				DGV.Columns.Add(column);
			}

			DGV.DataSource = list.AsDataTable(framesCount);
		}
	}
}
