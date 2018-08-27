using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyChartDll
{
	public class DateModel
	{
		public System.DateTime DateTime { get; set; }
		public double Value { get; set; }
	}

	/// <summary>
	/// Interaction logic for MyChart.xaml
	/// </summary>
	public partial class MyChart : UserControl
	{
		public MyChart()
		{
			InitializeComponent();

			var dayConfig = LiveCharts.Configurations.Mappers.Xy<DateModel>()
					.X(dayModel => (double)dayModel.DateTime.Ticks / TimeSpan.FromHours(1).Ticks)
					.Y(dayModel => dayModel.Value);

			Series = new SeriesCollection(dayConfig)
						{
								new LineSeries
								{
										Values = new ChartValues<DateModel>
										{
												new DateModel
												{
														DateTime = System.DateTime.Now,
														Value = 5
												},
												new DateModel
												{
														DateTime = System.DateTime.Now.AddHours(2),
														Value = 9
												}
										},
								},
								new LineSeries
								{
										Values = new ChartValues<DateModel>
										{
												new DateModel
												{
														DateTime = System.DateTime.Now.AddHours(1),
														Value = 2
												},
												new DateModel
												{
														DateTime = System.DateTime.Now.AddMinutes(90),
														Value = 7
												},
												new DateModel
												{
														DateTime = System.DateTime.Now.AddHours(2),
														Value = -7
												},
												new DateModel
												{
														DateTime = System.DateTime.Now.AddHours(3),
														Value = 7
												}
										},
										Fill = Brushes.Transparent
								},
						};

			Formatter = value => new System.DateTime((long)(value * TimeSpan.FromHours(1).Ticks)).ToString("t");

			DataContext = this;
		}

		public Func<double, string> Formatter { get; set; }
		public SeriesCollection Series { get; set; }
	}
}

