using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OSAlgorithmsSimulator
{
	public class ChartExt : Syncfusion.Windows.Forms.Chart.ChartControl
    {
        CategoryAxisDataBindModel categoryModel;
        /// <summary>
        /// Get and set Category model
        /// </summary>
        public CategoryAxisDataBindModel CategoryModel
        {
            get { return categoryModel; }
            set
            {
                categoryModel = value;
                OnCategoryModelChanged(value);
            }
        }

        private void OnCategoryModelChanged(CategoryAxisDataBindModel value)
        {
            if (value != null)
            {
              var data = value.DataSource as BindingList<ChartProcess>;
                if (data != null)
                {
                    if (data is INotifyCollectionChanged)
                        (data as INotifyCollectionChanged).CollectionChanged += DataPoint_CollectionChanged;
                    foreach (var obj in data)
                    {
                        {
                            CreateSeries(obj, value.YNames[0], value.CategoryName);
                            CreateAxisLabels(obj);
                        }
                    }
                }
            }
        }

        private void CreateAxisLabels(ChartProcess newValue)
        {
            if (this.PrimaryXAxis.ValueType == ChartValueType.Double)
            {
                double xValue = newValue.XValue;
                int count = this.PrimaryXAxis.Labels.Count;
                if (count > 0)
                {
                    //Added current value with previous value. 
                    xValue += (PrimaryXAxis.Labels[count - 1] as ChartAxisLabel).DoubleValue;
                }
                else
                {
					//Added zero label for first position.
					this.PrimaryXAxis.Labels.Add(new ChartAxisLabel("0", Color.White, this.Font));
                }

				//Custom label collection 
				this.PrimaryXAxis.Labels.Add(new ChartAxisLabel(xValue, "##") { Color = Color.White });
            }
        }

        private void DataPoint_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    CreateSeries(e.NewItems[0] as ChartProcess, categoryModel.YNames[0], categoryModel.CategoryName);
                    CreateAxisLabels(e.NewItems[0] as ChartProcess);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Series.RemoveAt(e.OldStartingIndex);
                    this.PrimaryXAxis.Labels.RemoveAt(e.OldStartingIndex);
                    break;
            }
        }

        public ChartExt(List<OSASProcess> processes) : base()
        {
			this.Legend.Visible = false;
			this.Palette = ChartColorPalette.Custom;
			this.CustomPalette = new Color[] { Color.FromArgb(28, 30, 35) };

			this.BackColor = Color.FromArgb(28, 30, 35);
			this.ElementsSpacing = 1;
			this.Font = new System.Drawing.Font("Cantarell", 10);

			//
			// PrimaryXAxis
			//
			this.PrimaryXAxis.ValueType = ChartValueType.Double;
			this.PrimaryXAxis.IsVisible = true;
			this.PrimaryXAxis.DrawGrid = false;
			this.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.None;
			this.PrimaryXAxis.TickSize = new Size(1, 5);
			this.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode;

			//
			// PrimaryYAxis
			//
			this.PrimaryYAxis.ValueType = ChartValueType.Category;
			this.PrimaryYAxis.RangePaddingType = ChartAxisRangePaddingType.None;
			this.PrimaryYAxis.IsVisible = false;
			this.PrimaryYAxis.DrawGrid = false;
			this.PrimaryYAxis.TickSize = new Size(5, 5);

			CategoryAxisDataBindModel dataSeriesModel = new CategoryAxisDataBindModel(processes.AsBindingList());
			dataSeriesModel.CategoryName = "YCategory";
			dataSeriesModel.YNames = new string[] { "XValue" };

			CategoryModel = dataSeriesModel;

			this.Location = new Point(0, 0);
			this.Height = 150;
			//this.Dock = System.Windows.Forms.DockStyle.Top;
			this.BorderAppearance.Interior.ForeColor = Color.Red;
			this.BorderAppearance.BaseColor = Color.Transparent;
			//this.Size = new System.Drawing.Size(575, 150);
			this.ChartArea.BorderStyle = BorderStyle.None;
			//this.ClientSize = new System.Drawing.Size(575, 150);
			this.ChartInterior = new BrushInfo(Color.FromArgb(28, 30, 35));
		}

		private void CreateSeries(ChartProcess newValue, string yvalue, string categoryName)
        {
            ChartSeries stackingBarSeries = new ChartSeries();
            stackingBarSeries.Type = ChartSeriesType.StackingBar;
            var dataSource = new BindingList<ChartProcess>();
            dataSource.Add(newValue);
            stackingBarSeries.CategoryModel = new CategoryAxisDataBindModel(dataSource) { CategoryName = categoryName, YNames = new string[] { yvalue } };
            // stackingBarSeries.Style.Border.Color = Color.White;
            stackingBarSeries.Style.DisplayText = true;
            stackingBarSeries.Style.TextOrientation = ChartTextOrientation.RegionCenter;
            stackingBarSeries.Style.Text = newValue.SeriesLabel;
			stackingBarSeries.Style.TextColor = Color.White;
			stackingBarSeries.Style.Border.Color = Color.White;
			this.Width += 30;
			Series.Add(stackingBarSeries);
        }
    }
}
