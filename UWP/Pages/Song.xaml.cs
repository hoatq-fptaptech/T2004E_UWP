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
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Song : Page
    {
        public Song()
        {
            this.InitializeComponent();
            GetSong();
        }

        public async void GetSong()
        {
            StorageFolder folder = Windows.ApplicationModel.Package.Current.InstalledLocation; // lấy folder lúc cài đặt app
            folder = await folder.GetFolderAsync("Assets"); // trỏ đến thư mục Assets
           // StorageFile file = await folder.GetFileAsync("music.mp3");// lấy file trong thư mục assets
            StorageFile file = await folder.GetFileAsync("video.mp4");// lấy file trong thư mục assets
            MediaPlay.SetSource(await file.OpenAsync(FileAccessMode.Read),file.ContentType);
        }
    }
}
