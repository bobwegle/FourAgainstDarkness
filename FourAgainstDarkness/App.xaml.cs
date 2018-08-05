using System;
using System.Windows;
using System.Data;
using System.Xml;
using System.Configuration;
using FourAgainstDarkness.Model;

namespace FourAgainstDarkness
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		void StartUp(object sender, StartupEventArgs e)
		{
			MainClass.StartupMain();
		}
	}
}