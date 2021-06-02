using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWP.Services;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DemoFileHandle : Page
    {
        public DemoFileHandle()
        {
            this.InitializeComponent();
        }

        private async void Read_File(object sender, RoutedEventArgs e) {
            string txt = await FileHandleService.ReadFile("t2004e.txt");
            TxtBlock.Text = txt;
        }

        private void Write_File(object sender, RoutedEventArgs e)
        {
            FileHandleService.WriteFile("t2004e.txt", "Xin chao tat ca cac ban");
        }
    }
}
