/*
 * Created by SharpDevelop.
 * User: rwegl
 * Date: 07/02/2018
 * Time: 16:48
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
using System.Windows.Media.Imaging;
using FourAgainstDarkness.Model;

namespace FourAgainstDarkness.Views
{
	/// <summary>
	/// Interaction logic for NewCharacter.xaml
	/// </summary>
	public partial class NewCharacter : Window
	{
		private PartyWin _partywin;
		private Button _charpos;
		private Warrior _warrior;
		private Barbarian _barbarian;
		private Cleric _cleric;
		private Rogue _rogue;
		private Wizard _wizard;
		private Elf _elf;
		private Dwarf _dwarf;
		private Halfling _halfling;
		private List<Equipment> _equipmentlist;
		private Character _car;
		
		public NewCharacter(PartyWin partywin, Button CharPos)
		{
			_equipmentlist=MainClass.Equipmentlist;
			_partywin = partywin;
			_charpos=CharPos;
			InitializeComponent();
		}
		void CharTypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

			
			Character car = MainClass.FleshOut(CharTypeCombo.SelectedValue.ToString());
			_car=car;
			LifeBox.Text = _car.Life.ToString();
			this.equipstack.DataContext = car;
			this.EquipNoteBlock.Text=car.Equipnotes;
			
			if (CharTypeCombo.SelectedValue.ToString() == "Warrior")
			{																					
				GoldLabel.Content = car.Newwarrior.Defaultwealth;								
			}

			if (CharTypeCombo.SelectedValue.ToString() == "Barbarian")
			{											
				GoldLabel.Content = car.Newbarbarian.Defaultwealth;			
			}
			
			if (CharTypeCombo.SelectedValue.ToString() == "Cleric")
			{											
				GoldLabel.Content = car.Newcleric.Defaultwealth;			
			}
			
			if (CharTypeCombo.SelectedValue.ToString() == "Wizard")
			{											
				GoldLabel.Content = car.Newwizard.Defaultwealth;			
			}
			
			if (CharTypeCombo.SelectedValue.ToString() == "Elf")
			{											
				GoldLabel.Content = car.Newelf.Defaultwealth;				
			}
			
			if (CharTypeCombo.SelectedValue.ToString() == "Dwarf")
			{											
				GoldLabel.Content = car.Newdwarf.Defaultwealth;			
			}
			
			if (CharTypeCombo.SelectedValue.ToString() == "Halfling")
			{											
				GoldLabel.Content = car.Newhalfling.Defaultwealth;			
			}
			
			if (CharTypeCombo.SelectedValue.ToString() == "Rogue")
			{											
				GoldLabel.Content = car.Newrogue.Defaultwealth;			
			}
		}
		private void LoadPic(string name, Button charpos)
		{
			switch(charpos.Name){
				case "Char1" :
					object obj = LogicalTreeHelper.FindLogicalNode(_partywin.Char1, "picpanel");
					if(obj!=null) {
						StackPanel pan = new StackPanel();
						pan = (StackPanel)obj;
						pan.Children.Clear();
					}
					
					Image img1 = _partywin.Resources[name] as Image;
					img1.Height=100;
					img1.Width=100;
					StackPanel stk1 = (StackPanel)LogicalTreeHelper.FindLogicalNode(_partywin, "Stack1");
					stk1.Children.Clear();
					stk1.Children.Add(img1);
					
					_partywin.Char1.Background=Brushes.White;
					break;
					
				case "Char2" :
					object obj2 = LogicalTreeHelper.FindLogicalNode(_partywin.Char2, "picpanel");
					if(obj2!=null) {
						StackPanel pan = new StackPanel();
						pan = (StackPanel)obj2;
						pan.Children.Clear();
					}
					
					Image img2 = _partywin.Resources[name] as Image;
					img2.Height=100;
					img2.Width=100;
					StackPanel stk2 = (StackPanel)LogicalTreeHelper.FindLogicalNode(_partywin, "Stack2");
					stk2.Children.Clear();
					stk2.Children.Add(img2);
					_partywin.Char2.Background=Brushes.White;

					break;	

				case "Char3" :
					object obj3 = LogicalTreeHelper.FindLogicalNode(_partywin.Char3, "picpanel");
					if(obj3!=null) {
						StackPanel pan = new StackPanel();
						pan = (StackPanel)obj3;
						pan.Children.Clear();
					}
					Image img3 = _partywin.Resources[name] as Image;
					img3.Height=100;
					img3.Width=100;
					StackPanel stk3 = (StackPanel)LogicalTreeHelper.FindLogicalNode(_partywin, "Stack3");
					stk3.Children.Clear();
					stk3.Children.Add(img3);
					_partywin.Char3.Background=Brushes.White;

					break;	

				case "Char4" :
					object obj4 = LogicalTreeHelper.FindLogicalNode(_partywin.Char4, "picpanel");
					if(obj4!=null) {
						StackPanel pan = new StackPanel();
						pan = (StackPanel)obj4;
						pan.Children.Clear();
					}
					Image img4 = _partywin.Resources[name] as Image;
					img4.Height=100;
					img4.Width=100;
					StackPanel stk4 = (StackPanel)LogicalTreeHelper.FindLogicalNode(_partywin, "Stack4");
					stk4.Children.Clear();
					stk4.Children.Add(img4);
					_partywin.Char4.Background=Brushes.White;

					break;								
			}
		}
		void SellButton_Click(object sender, RoutedEventArgs e)
		{
			if(GoldBox.Text=="") {return;}
			
			if (EquipmentInventory.SelectedIndex==-1) {return;}
				
			Equipment item = (Equipment)EquipmentInventory.SelectedItem;
			_car.Equipmentcarried.Remove(item);
			int newvalue = Convert.ToInt16(GoldBox.Text)+item.Value/2;
			GoldBox.Text=newvalue.ToString();
			EquipmentInventory.Items.Refresh();			
			
		}
		void BuyButton_Click(object sender, RoutedEventArgs e)
		{
			Views.StoreWin storewin = new Views.StoreWin(this);
			storewin.DataContext = this;
			storewin.Show();
		}

		public List<Equipment> Equipmentlist {
			get {
				return _equipmentlist;
			}
			set {
				_equipmentlist = value;
			}
		}

		public Warrior NewWarrior {
			get {
				return _warrior;
			}
			set {
				if (_warrior != value) {
					_warrior = value;
				}
			}
		}
		
		public Barbarian Newbarbarian {
			get {
				return _barbarian;
			}
			set {
				if (_barbarian != value) {
					_barbarian = value;
				}
			}
		}

		public Cleric Newcleric {
			get {
				return _cleric;
			}
			set {
				_cleric = value;
			}
		}

		public Rogue Newrogue {
			get {
				return _rogue;
			}
			set {
				_rogue = value;
			}
		}

		public Wizard Newwizard {
			get {
				return _wizard;
			}
			set {
				_wizard = value;
			}
		}

		public Elf Newelf {
			get {
				return _elf;
			}
			set {
				_elf = value;
			}
		}

		public Dwarf Newdwarf {
			get {
				return _dwarf;
			}
			set {
				_dwarf = value;
			}
		}

		public Halfling Newhalfling {
			get {
				return _halfling;
			}
			set {
				_halfling = value;
			}
		}
		
		public Character Car {
			get {
				return _car;
			}
			set {
				_car = value;
			}
		}
		void CompleteButton_Click(object sender, RoutedEventArgs e)
		{
				LoadPic(CharTypeCombo.SelectedValue.ToString(), _charpos);
				_car.Name = this.NameBox.Text;
				_car.Level=Convert.ToInt16(this.LevelCombo.Text);
				
				_car.Life=Convert.ToInt16(this.LifeBox.Text);
				_car.Currentlife=Convert.ToInt16(this.LifeBox.Text);

				_car.Gold=Convert.ToInt16(this.GoldBox.Text);
				_car.SetAttackBonus();
				_car.SetEquipAttackBonus();
				_car.SetDefenseBonus();
				_car.SetEquipDefenseBonus();
				
				_partywin.MainParty.Characters.Add(_car);
				this.Close();
		}
		void LevelCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (LifeBox.Text != "")
			{
				LifeBox.Text= _car.CalculateLife(Convert.ToInt16(LevelCombo.SelectedValue)).ToString();
			}
		}
			
		
		
		
		
	}
	
	
}