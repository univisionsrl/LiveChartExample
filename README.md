# LiveChartExample
LiveChartExample with dll

Importing a chart from a user control in a dll, cause this trace in the file MainWindow.xaml

InvalidOperationException: '{DependencyProperty.UnsetValue}' is not a valid value for pro

   at System.Windows.DependencyObject.GetEffectiveValue(EntryIndex entryIndex, DependencyProperty dp, RequestFlags requests)
   at System.Windows.DependencyObject.GetValueEntry(EntryIndex entryIndex, DependencyProperty dp, PropertyMetadata metadata, RequestFlags requests)
   at System.Windows.DependencyObject.GetValue(DependencyProperty dp)
   at LiveCharts.Wpf.Charts.Base.Chart.get_SeriesColors()
   at LiveCharts.Wpf.Charts.Base.Chart.GetNextDefaultColor()
   at LiveCharts.Wpf.Series.InitializeColors()
   at LiveCharts.ChartUpdater.Update(Boolean restartsAnimations, Boolean force)
   at LiveCharts.Wpf.Components.ChartUpdater.UpdaterTick(Boolean restartView, Boolean force)
   at LiveCharts.Wpf.Components.ChartUpdater.OnTimerOnTick(Object sender, EventArgs args)
   at System.Windows.Threading.DispatcherTimer.FireTick(Object unused)
   at System.Windows.Threading.ExceptionWrapper.InternalRealCall(Delegate callback, Object args, Int32 numArgs)
   at System.Windows.Threading.ExceptionWrapper.TryCatchWhen(Object source, Delegate callback, Object args, Int32 numArgs, Delegate catchHandler)
