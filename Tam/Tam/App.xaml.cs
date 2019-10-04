using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;
using SQLitePCL;


namespace Tam
{
	public partial class App : Application
	{
		public static readonly SQLiteAsyncConnection sqlConnection = new SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tam.db3"));



		public App()
		{
			InitializeComponent();
			MainPage = new MainPage();
		}


		protected override void OnStart()
		{
			// Handle when your app starts
		}


		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}


		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}



	public class Item
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string s { get; set; }


		public override string ToString() => s;
	}

}
