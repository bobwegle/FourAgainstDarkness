/*
 * Created by SharpDevelop.
 * User: rwegl
 * Date: 07/10/2018
 * Time: 17:10
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
using MahApps.Metro.Controls;

namespace FourAgainstDarkness.Views
{
	/// <summary>
	/// Interaction logic for StoreWin.xaml
	/// </summary>
	public partial class StoreWin : MetroWindow
	{
		private NewCharacter _newchar;
		public StoreWin(NewCharacter newchar)
		{
			_newchar=newchar;
			InitializeComponent();
		}
		void StoreList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if(_newchar.GoldBox.Text==""){
				StatusLab.Content="Must have gold to buy items";
				return;
			}
			if(Convert.ToInt16(_newchar.GoldBox.Text)==0){
				StatusLab.Content="Must have more than 0 gold to buy items";
				return;
			}
			
			
			Equipment item = (Equipment)StoreList.SelectedItem;
			
			int newvalue = Convert.ToInt16(_newchar.GoldBox.Text)-item.Value;
			if(newvalue<0){
				StatusLab.Content="Not enough Gold to Complete Transaction";
				return;
			}
			_newchar.Car.Equipmentcarried.Add(item);
			_newchar.GoldBox.Text=newvalue.ToString();
			_newchar.EquipmentInventory.Items.Refresh();
			this.Close();
			
		}
	}
}