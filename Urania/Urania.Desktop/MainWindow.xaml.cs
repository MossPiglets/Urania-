﻿using System.Windows;
using Urania.Desktop.States;

namespace Urania.Desktop {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow {
		public WdState WdState { get; set; }
		public MainWindow() {
			InitializeComponent();
			this.DataContext = this;
		}

		private void ToggleButton_OnChecked(object sender, RoutedEventArgs e) {
			MessageBox.Show(string.Format($"wdState: {WdState}"));
		}
	}
}