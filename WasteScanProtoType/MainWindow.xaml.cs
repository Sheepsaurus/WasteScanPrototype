using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WasteScanProtoType
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			TextHandle textHandle = new TextHandle
			{
				SaveAmount = "SAVE 20,-",
				InformationFact = "Did you know that 40% of all food is wasted in the US?\n" + 
								  "1.3 billion tons of food are wasted every year.\n" + 
								  "This amounts to US$1 trillion dollars of wasted or lost food.\n" + 
								  "If wasted food was a country, " + 
								  "it would be the third largest producer of carbon dioxide in the world, " + 
								  "around 3.3 billions tons of carbon dioxide.",
				BarcodeWidth = 300,
				BarcodeHeight = 170
			};

			textHandle.LineLength = textHandle.BarcodeWidth - 3;
			textHandle.LineOffset = textHandle.BarcodeHeight / 2;			

			DataContext = textHandle;
		}
	}	
}
