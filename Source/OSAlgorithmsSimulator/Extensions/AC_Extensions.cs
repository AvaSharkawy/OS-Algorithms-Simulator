using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// Useful extensions for many controls in .NET and <see cref="Syncfusion"/>
	/// </summary>
	public static class AC_Extensions
	{
		#region Objects

		/// <summary>
		/// Clear the control according to it's type
		/// </summary>
		/// <param name="obj">The control to clear as <see cref="object"/></param>
		public static void AC_ClearField(this object obj)
		{
			if (obj is TextBox)
			{
				(obj as TextBox).Clear();
			}
			else if (obj is ComboBox)
			{
				(obj as ComboBox).SelectedIndex = -1;
			}
			else if (obj is DateTimePicker)
			{
				(obj as DateTimePicker).Value = DateTime.Now;
			}
			else if (obj is NumericUpDown)
			{
				(obj as NumericUpDown).Value = 0;
			}
			else if (obj is DoubleTextBox)
			{
				(obj as DoubleTextBox).DoubleValue = 0;
			}
			else if (obj is CheckBox)
			{
				(obj as CheckBox).Checked = false;
			}
		}

		public static int AC_ToInt32(this object obj)
		{
			return Convert.ToInt32(obj);
		}

		#endregion

		#region Control

		/// <summary>
		/// Indicates if the value in the given <see cref="Control"/> is valid or not
		/// </summary>
		/// <param name="control">The control to check the value from</param>
		/// <returns></returns>
		public static bool AC_ValidValue(this Control control)
		{
			var t = control.GetType();
			if (t == typeof(TextBox))
				return (control as TextBox).Text.Trim() == "" ? false : true;
			else if (t == typeof(DoubleTextBox))
				return (control as DoubleTextBox).DoubleValue == 0 ? false : true;
			else if (t == typeof(ComboBox))
				return (control as ComboBox).SelectedIndex == -1 ? false : true;
			else if (t == typeof(NumericUpDown))
				return (control as NumericUpDown).Value <= 0 ? false : true;
			else
				return true;
		}

		/// <summary>
		/// Indicates if the given controls have valid values
		/// </summary>
		/// <param name="controls">The controls to check values from</param>
		/// <returns></returns>
		public static bool AC_CheckRequiredFields(params Control[] controls)
		{
			foreach (var item in controls)
			{
				if (!item.Enabled)
					continue;
				if (!item.AC_ValidValue())
					return false;
			}
			return true;
		}

		#endregion

		#region TableLayoutPanel

		public static void AC_ConfigButtons(this TableLayoutPanel tlp, Button addButton, Button cogButton, DataGridView dgv, string cogButtonCogText = null, string cogButtonCancelText = null, params Control[] controls)
		{
			if (addButton.Enabled)
			{
				addButton.Enabled = false;
				cogButton.Text = cogButtonCogText ?? "";
				foreach (var btn in controls)
					btn.Enabled = true;
				dgv.Enabled = true;
			}
			else
			{
				addButton.Enabled = true;
				cogButton.Text = cogButtonCancelText ?? "";
				foreach (var btn in controls)
					btn.Enabled = false;
				dgv.Enabled = false;
			}
		}

		/// <summary>
		/// Clear all data from the controls in the given <see cref="TableLayoutPanel"/>
		/// </summary>
		/// <param name="tlp">The TableLayoutPanel to clear control data from</param>
		public static void AC_ClearFields(this TableLayoutPanel tlp)
		{
			foreach (Control con in tlp.Controls)
			{
				con.AC_ClearField();
			}
		}

		/// <summary>
		/// Indicates if the presented data in given controls are valid or not
		/// </summary>
		/// <param name="tlp">The TableLayoutPanel that has the controls in</param>
		/// <param name="controls">The controls to check</param>
		/// <returns></returns>
		public static bool AC_CheckRequiredFields(this TableLayoutPanel tlp, params Control[] controls)
		{
			return AC_CheckRequiredFields(controls);
		}

		#endregion

		#region DataGridView

		/// <summary>
		/// Converts the given <see cref="DataGridView"/> to DataTable
		/// </summary>
		/// <param name="dgv">The DataGridView to convert</param>
		/// <returns></returns>
		public static DataTable AC_AsDataTable(this DataGridView dgv)
		{
			var dt = new DataTable();
			foreach (DataGridViewColumn colm in dgv.Columns)
			{
				dt.Columns.Add(colm.Name, typeof(object));
			}

			foreach (DataGridViewRow row in dgv.Rows)
			{
				var roww = dt.NewRow();

				foreach (DataGridViewCell cell in row.Cells)
				{
					roww[cell.ColumnIndex] = cell.Value;
				}
				dt.Rows.Add(roww);
			}
			return dt;
		}

		/// <summary>
		/// Gets the DataGridView given column name data as an array
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="dgv">The DataGridView to get data from</param>
		/// <param name="columnName">The column name in the DataGridView</param>
		/// <param name="count">Rows count</param>
		/// <returns></returns>
		public static T[] AC_GetColumnAsArray<T>(this DataGridView dgv, string columnName, int count)
		{
			var arr = new T[count];
			for (var i = 0; i < count; i++)
			{
				arr[i] = (T)dgv.Rows[i].Cells[columnName].Value;
			}
			return arr;
		}

		/// <summary>
		/// Gets the DataGridView given column name data as a list
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="dgv">The DataGridView to get data from</param>
		/// <param name="columnName">The column name in the DataGridView</param>
		/// <returns></returns>
		public static List<T> AC_GetColumnAsList<T>(this DataGridView dgv, string columnName)
		{
			var ls = new List<T>();
			var type = typeof(T);
			foreach (DataGridViewRow row in dgv.Rows)
			{
				ls.Add((T)Convert.ChangeType(row.Cells[columnName].Value, typeof(T)));
			}
			return ls;
		}

		#endregion

		#region IEnumerable

		/// <summary>
		/// Converts the given data to DataTable
		/// </summary>
		/// <typeparam name="T">The type of the given data</typeparam>
		/// <param name="data">The data to convert</param>
		/// <returns></returns>
		public static DataTable AC_AsDataTable<T>(this IEnumerable<T> data)
		{
			var dt = new DataTable();

			var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

			foreach (var p in properties)
			{
				dt.Columns.Add(p.Name, p.PropertyType);
			}


			foreach (var val in data)
			{
				var values = new object[properties.Length];
				for (var i = 0; i < properties.Length; i++)
				{
					values[i] = properties[i].GetValue(val, null);
				}
				dt.Rows.Add(values);
			}
			return dt;
		}

		/// <summary>
		/// For each loop as a function that executes the given action on the given data
		/// </summary>
		/// <typeparam name="T">The type of data</typeparam>
		/// <param name="source">The data to perform action on</param>
		/// <param name="action">The action to perform</param>
		public static void AC_ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
			foreach (var element in source)
				action(element);
		}

		/// <summary>
		/// Indicates if the given value is exist in the given list or not
		/// </summary>
		/// <typeparam name="T">The type of the value</typeparam>
		/// <param name="list">The list to search in</param>
		/// <param name="value">The value to search for</param>
		/// <returns></returns>
		public static bool AC_Exists<T>(this IEnumerable<T> list, T value)
		{
			foreach (var element in list)
			{
				if (element.Equals(value))
					return true;
			}
			return false;
		}

		/// <summary>
		/// Converts <see cref="IEnumerable{T}"/> to <see cref="Stack{T}"/>
		/// </summary>
		/// <typeparam name="T">The data type</typeparam>
		/// <param name="data">The data to convert</param>
		/// <param name="defaultStack">To determine the data order in stack</param>
		/// <returns></returns>
		public static Stack<T> AC_ToStack<T>(this IEnumerable<T> data, bool defaultStack = true)
		{
			data = defaultStack ? data : data.Reverse();

			return new Stack<T>(data);
		}

		#endregion

		#region DataTable

		/// <summary>
		/// Converts a specific column to a <see cref="List{T}"/>
		/// </summary>
		/// <typeparam name="T">The type of data</typeparam>
		/// <param name="dataTable">The DataTable that contains data</param>
		/// <param name="colName">The name of the column to convert</param>
		/// <returns></returns>
		public static List<T> AC_AsList<T>(this DataTable dataTable, string colName)
		{
			var ls = new List<T>();
			var type = typeof(T);
			dataTable.AsEnumerable().AC_ForEach(a => ls.Add((T)Convert.ChangeType(a[colName], typeof(T))));
			return ls;
		}

		#endregion

		#region Int

		/// <summary>
		/// Indicates if this integer exists in the given <see cref="List{T}"/>
		/// </summary>
		/// <param name="num">The number to search for</param>
		/// <param name="ls">The list to search in</param>
		/// <returns></returns>
		public static bool AC_ExistsIn(this int num, List<int> ls)
		{
			foreach (var i in ls)
			{
				if (i == num)
				{
					return true;
				}
			}
			return false;
		}

		#endregion
	}

}
