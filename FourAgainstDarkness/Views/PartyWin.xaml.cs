/*
 * Created by SharpDevelop.
 * User: rwegl
 * Date: 07/02/2018
 * Time: 12:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using FourAgainstDarkness.Model;
using MahApps.Metro.Controls;

namespace FourAgainstDarkness.Views
{
	/// <summary>
	/// Interaction logic for PartyWin.xaml
	/// </summary>
	public partial class PartyWin : MetroWindow
	{
		private PartyAlt _party;
			
		public PartyWin(PartyAlt party)
		{
			_party = party;
			InitializeComponent();
		}
		void Char1_Click(object sender, RoutedEventArgs e)
		{
			Button btn = new Button();
			btn = (Button)sender;
			MainClass.CreateNewCharacter(this, btn);
		}

public PartyAlt MainParty {
	get { return _party; }
	set { _party = value; }
}
		void FinalizeButton_Click(object sender, RoutedEventArgs e)
		{
			MainClass.GameParty = _party;
			this.Close();
		}


		
	}
}