using OSAlgorithmsSimulator.User_Controls.CPU;
using OSAlgorithmsSimulator.User_Controls.Virtual_Memory;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.Controls.Enums;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace OSAlgorithmsSimulator
{
	public partial class MainDashboard : Form
	{
		#region CPU UCs Initialize

		CPU_FCFS_UC CPU_FCFS_Page { get; set; } = new CPU_FCFS_UC();

		CPU_SJF_UC CPU_SJF_Page { get; set; } = new CPU_SJF_UC();

		CPU_Priority_UC CPU_Priority_Page { get; set; } = new CPU_Priority_UC();

		CPU_RoundRobin_UC CPU_RoundRobin_Page { get; set; } = new CPU_RoundRobin_UC();

		#endregion

		#region VM UCs Initialize

		VM_FIFO_UC VM_FIFO_Page { get; set; } = new VM_FIFO_UC();

		VM_LRU_UC VM_LRU_Page { get; set; } = new VM_LRU_UC();

		VM_Optimal_UC VM_Optimal_Page { get; set; } = new VM_Optimal_UC();

		VM_MFU_UC VM_MFU_Page { get; set; } = new VM_MFU_UC();

		VM_SecondChance_UC VM_SecondChance_Page { get; set; } = new VM_SecondChance_UC();

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public MainDashboard()
		{
			InitializeComponent();
			InitializeToolTips();
		}

		void InitializeToolTips()
		{
			SetToolTip(BtnCPUFCFS, Properties.Resources.CPU_FCFS);			
			SetToolTip(BtnCPUSJF, Properties.Resources.CPU_SJF);			
			SetToolTip(BtnCPUPriority, Properties.Resources.CPU_Priority);
			SetToolTip(BtnCPURR, Properties.Resources.CPU_RoundRobin);
			SetToolTip(BtnVMFIFO, Properties.Resources.VM_FIFO);
			SetToolTip(BtnVMLRU, Properties.Resources.VM_LRU);
			SetToolTip(BtnVMOptimal, Properties.Resources.VM_Optimal);
			SetToolTip(BtnVMMFU, Properties.Resources.VM_MFU);
			SetToolTip(BtnVMSecondChance, Properties.Resources.VM_SecondChance);
		}

		#endregion

		#region Form Events

		private void MainDashboard_Load(object sender, System.EventArgs e)
		{
			#region CPU Load

			CPUNavigateTo(BtnCPUFCFS, CPU_FCFS_Page);

			#endregion

			#region VM Load

			VMNavigateTo(BtnVMFIFO, VM_FIFO_Page);

			#endregion
		}

		#endregion

		#region Helper Methods

		/// <summary>
		/// Changes back color of non-selected buttons to Transparent, and Selected
		/// Button to Specific Color
		/// </summary>
		/// <param name="senderBtn">The selected button</param>
		/// <param name="containerPanel">The buttons container panel</param>
		void VisualizeButtonsOnClick(Button senderBtn, Panel containerPanel)
		{
			foreach (Control control in containerPanel.Controls)
			{
				if (control is Button)
					if ((control as Button) != senderBtn)
						(control as Button).BackColor = Color.Transparent;
			}
			senderBtn.BackColor = Color.FromArgb(39, 42, 49);
		}

		/// <summary>
		/// Moves ButtonHead panel to the selected button
		/// </summary>
		/// <param name="buttonTo">The selected button</param>
		void MoveButtonHead(Button buttonTo, Panel buttonHead)
		{
			buttonHead.Top = buttonTo.Top;
			buttonHead.Height = buttonTo.Height;
		}

		/// <summary>
		/// Brings User control to front if exists, else will add it to the panel
		/// </summary>
		/// <param name="uc">The user control to show</param>
		/// <param name="pnl">The container panel</param>
		public void ShowUserControl(UserControl uc, Panel pnl)
		{
			if (!pnl.Controls.ContainsKey(uc.Name))
			{
				uc.Dock = DockStyle.Fill;
				pnl.Controls.Add(uc);
				pnl.Controls[uc.Name].BringToFront();
			}
			else
			{
				pnl.Controls[uc.Name].BringToFront();
			}
		}

		/// <summary>
		/// Navigate to specific page
		/// </summary>
		/// <param name="uc">Page user control</param>
		/// <param name="senderButton">The sender button</param>
		/// <param name="ucsContainer">The container of pages</param>
		/// <param name="buttonHead">Button head to move</param>
		/// <param name="btnsContainer">Buttons container</param>
		private void NavigateTo(UserControl uc, Button senderButton, Panel ucsContainer, Panel buttonHead, Panel btnsContainer)
		{
			ShowUserControl(uc, ucsContainer);
			MoveButtonHead(senderButton, buttonHead);
			VisualizeButtonsOnClick(senderButton, btnsContainer);
		}

		/// <summary>
		/// Navigate to CPU Tab pages
		/// </summary>
		/// <param name="senderButton">The sender button</param>
		/// <param name="userControl">The page to visit</param>
		private void CPUNavigateTo(object senderButton,UserControl userControl)
		{
			NavigateTo(userControl, (senderButton as Button), pnlCpuUCs, PnlCPUButtonHead, CpuSidePanel);
		}

		private void VMNavigateTo(object senderButton,UserControl userControl)
		{
			NavigateTo(userControl, (senderButton as Button), pnlVMUcs, PnlVMButtonHead, VMSidePanel);
		}

		private void SetToolTip(Control control, string content)
		{
			ToolTipInfo toolTipInfo1 = new ToolTipInfo();
			toolTipInfo1.MaxWidth = 1000;
			toolTipInfo1.ToolTipStyle = ToolTipStyle.Balloon;
			toolTipInfo1.ToolTipLocation = ToolTipLocation.BottomRight;
			toolTipInfo1.BeakBackColor = ColorTranslator.FromHtml("#3D3D3D");
			toolTipInfo1.BorderColor = ColorTranslator.FromHtml("#1E1E1E");
			ToolTipItem toolTipItem1 = new ToolTipItem();
			toolTipItem1.Padding = new Padding(10);
			toolTipItem1.Style.BackColor = ColorTranslator.FromHtml("#3D3D3D");

			RichTextBox richTextBox1 = new RichTextBox();
			richTextBox1.Margin = new Padding(0);
			richTextBox1.Location = new Point(0, 0);
			richTextBox1.WordWrap = true;
			richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
			richTextBox1.Width = 500;
			richTextBox1.BackColor = ColorTranslator.FromHtml("#3D3D3D");
			richTextBox1.ContentsResized += (ss, ee) =>
			{
				var send = ss as RichTextBox;

				send.Height = ee.NewRectangle.Height;
			};

			richTextBox1.Rtf = content;
			richTextBox1.BorderStyle = BorderStyle.None;

			toolTipItem1.Control = richTextBox1;

			toolTipInfo1.Items.Add(toolTipItem1);

			this.sfToolTip1.SetToolTipInfo(control, toolTipInfo1);
		}


		#endregion

		#region CPU Buttons Events

		private void BtnCPUFCFS_Click(object sender, System.EventArgs e)
		{
			CPUNavigateTo(sender, CPU_FCFS_Page);
		}

		private void BtnCPUSJF_Click(object sender, System.EventArgs e)
		{
			CPUNavigateTo(sender, CPU_SJF_Page);
		}

		private void BtnCPUPriority_Click(object sender, System.EventArgs e)
		{
			CPUNavigateTo(sender, CPU_Priority_Page);
		}

		private void BtnCPURR_Click(object sender, System.EventArgs e)
		{
			CPUNavigateTo(sender, CPU_RoundRobin_Page);
		}

		#endregion

		#region VM Buttons Events

		private void BtnVMFIFO_Click(object sender, System.EventArgs e)
		{
			VMNavigateTo(sender, VM_FIFO_Page);
		}

		private void BtnVMLRU_Click(object sender, System.EventArgs e)
		{
			VMNavigateTo(sender, VM_LRU_Page);
		}

		private void BtnVMOptimal_Click(object sender, System.EventArgs e)
		{
			VMNavigateTo(sender, VM_Optimal_Page);
		}

		private void BtnVMMFU_Click(object sender, System.EventArgs e)
		{
			VMNavigateTo(sender, VM_MFU_Page);
		}

		private void BtnVMSecondChance_Click(object sender, System.EventArgs e)
		{
			VMNavigateTo(sender, VM_SecondChance_Page);
		}

		#endregion
	}
}
