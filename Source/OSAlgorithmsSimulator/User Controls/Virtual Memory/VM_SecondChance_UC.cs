﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OSAlgorithmsSimulator.User_Controls.Virtual_Memory
{
	public partial class VM_SecondChance_UC : UserControl
	{
		public VM_SecondChance_UC()
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

			var secondChance = new VM_PageReplacment(txtInputString.Text, Convert.ToInt32(NumFramesCount.Value), VMAlgorithmType.SecondChance);

			var watch = Stopwatch.StartNew();

			if (!secondChance.Calculate())
			{
				ACMessageBox.ShowFailedMessage("Failed to start, please check your input");
				return;
			}

			watch.Stop();

			lblTime.Text = $"Estimated Time= {watch.ElapsedMilliseconds}ms";

			secondChance.FillDGV(DGV);

			var hits = $"{secondChance.Hits}/{secondChance.InputString.Length}";
			var faults = $"{secondChance.Faults}/{secondChance.InputString.Length}";

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
