using System.Windows.Forms;

namespace OSAlgorithmsSimulator
{
	public static class VMPageReplacmentExtensions
	{
		public static void FillDGV(this VM_PageReplacment vm, DataGridView DGV)
		{
			var stringColumn = new DataGridViewTextBoxColumn();
			stringColumn.Name = $"StringCol";
			stringColumn.DataPropertyName = "String";
			stringColumn.HeaderText = "String";
			stringColumn.DisplayIndex = 0;
			stringColumn.Width = 120;
			stringColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

			DGV.Columns.Add(stringColumn);

			foreach (var obj in vm.OutputList)
			{
				var column = new DataGridViewTextBoxColumn();
				column.Name = $"Num{obj.Index}";
				column.DataPropertyName = $"Num{obj.Index}";
				column.HeaderText = obj.InputObject.ToString();
				column.DisplayIndex = obj.Index+1;
				column.Width = 50;
				column.SortMode = DataGridViewColumnSortMode.NotSortable;

				DGV.Columns.Add(column);
			}

			DGV.DataSource = vm.OutputList.AsDataTable(vm.FramesCount);

			DGV.ClearSelection();

			DGV.SelectionChanged += (ss, ee) =>
			{
				DGV.ClearSelection();
			};
		}
	}
}
