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

namespace scrolling
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void scrollup_Click(object sender, RoutedEventArgs e)
		{
			string line = line1.Text;
			line1.Text = line2.Text;
			line2.Text = line3.Text;
			line3.Text = line4.Text;
			line4.Text = line;
			MessageBox.Show(grid.ActualWidth.ToString());
			//MessageBox.Show("width: "+((Panel)Application.Current.MainWindow.Content).ActualWidth+" and height: "+ ((Panel)Application.Current.MainWindow.Content).ActualHeight);
		}
		private void scrolldown_Click(object sender, RoutedEventArgs e)
		{
			string line = line4.Text;
			line4.Text = line3.Text;
			line3.Text = line2.Text;
			line2.Text = line1.Text;
			line1.Text = line;
		}
		private void clear_Click(object sender, RoutedEventArgs e)
		{
			line1.Text = "";
			line2.Text = "";
			line3.Text = "";
			line4.Text = "";
		}
	}
}
