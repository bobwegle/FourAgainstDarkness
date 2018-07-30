/*
 * Created by SharpDevelop.
 * User: rwegl
 * Date: 7/1/2018
 * Time: 6:38 PM
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
using FourAgainstDarkness.Model;

namespace FourAgainstDarkness.Views
{
	/// <summary>
	/// Interaction logic for ControlPanel.xaml
	/// </summary>
	public partial class ControlPanel : Window
	{
		public ControlPanel()
		{
			InitializeComponent();
		}

		void CreatePartyButton_Click(object sender, RoutedEventArgs e)
		{
			MainClass.CreateNewParty();
		}
		void CharSheetButton_Click(object sender, RoutedEventArgs e)
		{
			CharacterSheet  _charactersheet = new CharacterSheet();
			_charactersheet.ShowDialog();
		}
	}
}