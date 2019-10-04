using Firebase.Storage;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Diagnostics;
using Firebase.Database.Extensions;


namespace Tam
{
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}


		private async void Button_Clicked(object sender, EventArgs e)
		{
			// Get any Stream - it can be FileStream, MemoryStream or any other type of Stream
			var stream = typeof(App).Assembly.GetManifestResourceStream("Tam.images.gai.jpg");

			// Constructr FirebaseStorage, path to where you want to upload the file and Put it there
			var task = new FirebaseStorage("learn-firebase-tam.appspot.com")
				.Child("tam").Child("gai dep.jpg")
				.PutAsync(stream);

			// Track progress of the upload
			task.Progress.ProgressChanged += (s, ee) => Debug.WriteLine($"Progress: {ee.Percentage} %");

			// await the task to wait until upload completes and get the download url
			string downloadUrl = await task;
		}
	}
}
