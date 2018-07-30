/*
 * Created by SharpDevelop.
 * User: rwegl
 * Date: 07/19/2018
 * Time: 16:45
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
	/// Interaction logic for CharacterSheet.xaml
	/// </summary>
	public partial class CharacterSheet : Window
	{
		Character _character1;
		
		public CharacterSheet()
		{
			Character _char1 = new Character();
			_char1 = MainClass.GameParty.Characters[0];
			_character1=_char1;
			InitializeComponent();
			this.Panel1.DataContext = _char1;
							
			Image img1 = this.Resources[_char1.CharType] as Image;
			img1.Height=100;
			img1.Width=100;
			
			picpanel1.Children.Add(img1);
		}
		void button1_Click(object sender, RoutedEventArgs e)
		{
			if(_character1.Currentlife!=0)
			{
				_character1.Currentlife=_character1.Currentlife-1;
				currliferun.GetBindingExpression(Run.TextProperty).UpdateTarget();
			}
		}
		void button2_Click(object sender, RoutedEventArgs e)
		{
			if(_character1.Currentlife<_character1.Life)
			{
				_character1.Currentlife=_character1.Currentlife+1;				
				currliferun.GetBindingExpression(Run.TextProperty).UpdateTarget();			
			}
		}
		void button3_Click(object sender, RoutedEventArgs e)
		{
			_character1.LevelUp();
			_character1.SetAttackBonus();
			liferun.GetBindingExpression(Run.TextProperty).UpdateTarget();
			currliferun.GetBindingExpression(Run.TextProperty).UpdateTarget();
			levelbox.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
			attackbonusbox.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
			
		}
		void GoldButtonClick(object sender, RoutedEventArgs e)
		{
			Button btn = new Button();
			btn=(Button)sender;
			string name = btn.Content.ToString();
			switch(name)
			{
				case "+1":
					_character1.Gold=_character1.Gold+1;
					goldbox.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
					
				case "+10":
					_character1.Gold=_character1.Gold+10;
					goldbox.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
					
				case "-1":
					if(_character1.Gold>0) _character1.Gold=_character1.Gold-1;
					goldbox.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
					
				case "-10":
					if(_character1.Gold>9) _character1.Gold=_character1.Gold-10;
					goldbox.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
			}
		}
		void AddButton(object sender, RoutedEventArgs e)
		{
			CheckBox chk = new CheckBox();
			chk.VerticalAlignment=VerticalAlignment.Center;
			StackPanel stk = new StackPanel();
			Button btn = new Button();
			btn=(Button)sender;
			stk = (StackPanel)VisualTreeHelper.GetParent(btn);
			stk.Children.Insert(stk.Children.Count-1, chk);
		}
		void AddRow(object sender, RoutedEventArgs e)
		{
			StackPanel pan = new StackPanel();
			pan.Orientation=Orientation.Horizontal;
			spellpanel.Children.Add(pan);
			TextBox txt = new TextBox();
			pan.Children.Add(txt);
			txt.Width=125;
			CheckBox chk = new CheckBox();
			chk.VerticalAlignment=VerticalAlignment.Center;
			pan.Children.Add(chk);
			Button btn = new Button();
			pan.Children.Add(btn);
			btn.Content="+1";
			btn.Click+=AddButton;
			
			
			
		}

	}
}