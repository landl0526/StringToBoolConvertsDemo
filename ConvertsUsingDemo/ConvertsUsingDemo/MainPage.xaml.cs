using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConvertsUsingDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();


            List<ViewModel> list = new List<ViewModel>();
            for (int i = 0; i < 10; i++)
            {
                // more or other strings will show the image and hide the switch
                list.Add(new ViewModel { type = "switch" });
            }
            MyListView.ItemsSource = list;
        }
	}


    public class ViewModel
    {
        public string type { set; get; }
    }
}
