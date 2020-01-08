using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OSAlgorithmsSimulator.User_Controls.Virtual_Memory
{
	public partial class VM_Optimal_UC : UserControl
	{
		public VM_Optimal_UC()
		{
			InitializeComponent();
		}

		private void BtnStart_Click(object sender, EventArgs e)
		{
			if (!TlpInputFields.AC_CheckRequiredFields(txtInputString, NumFramesCount))
			{
				ACMessageBox.ShowFillRequiredFields();
				return;
			}

			var optimal = new VM_PageReplacment(txtInputString.Text, Convert.ToInt32(NumFramesCount.Value), VMAlgorithmType.Optimal);
			
			var watch = Stopwatch.StartNew();

			optimal.Calculate();

			watch.Stop();

			lblTime.Text = $"Estimated Time= {watch.ElapsedMilliseconds}ms";

			optimal.FillDGV(DGV);

			var hits = $"{optimal.Hits}/{optimal.CleanInputStringLength}";
			var faults = $"{optimal.Faults}/{optimal.CleanInputStringLength}";

			lblHits.Text = $"Page Hits = {hits}";
			lblFaults.Text = $"Page Faults = {faults}";

			lblHits.Visible = lblFaults.Visible = lblTime.Visible = true;

			GbInput.Enabled = false;
			BtnStart.Enabled = false;

		}

		private void BtnReset_Click(object sender, EventArgs e)
		{
			DGV.DataSource = null;
			DGV.Rows.Clear();
			DGV.Columns.Clear();

			TlpInputFields.AC_ClearFields();

			lblHits.Visible = lblFaults.Visible = lblTime.Visible = false;

			GbInput.Enabled = true;
			BtnStart.Enabled = true;

		}
	}
}
