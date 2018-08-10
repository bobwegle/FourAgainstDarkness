/*
 * Created by SharpDevelop.
 * User: rwegl
 * Date: 08/07/2018
 * Time: 19:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using MahApps.Metro.Controls;

namespace FourAgainstDarkness.Views
{
	/// <summary>
	/// Interaction logic for Monster.xaml
	/// </summary>
	public partial class Monster : MetroWindow
	{
		public Monster()
		{
			InitializeComponent();
		}
		void AddEncounter(object sender, RoutedEventArgs e)
		{
			ContentPresenter content = new ContentPresenter();
			Border brd = new Border();
			brd = (Border)FindResource("encounter");
			content.Margin=new Thickness(5,0,0,5);
			content.Content=brd;
			wrappanel.Children.Add(content);
			
		}
		void AddChk(object sender, RoutedEventArgs e)
		{
			CheckBox chk = new CheckBox();
			chk.VerticalAlignment=VerticalAlignment.Center;
			WrapPanel stk = new WrapPanel();
			Button btn = new Button();
			btn=(Button)sender;
			stk = (WrapPanel)VisualTreeHelper.GetParent(btn);
			stk.Children.Insert(stk.Children.Count-1, chk);
		}
	}
}