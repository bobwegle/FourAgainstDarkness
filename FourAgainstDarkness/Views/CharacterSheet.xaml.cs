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
using MahApps.Metro.Controls;

namespace FourAgainstDarkness.Views
{
	/// <summary>
	/// Interaction logic for CharacterSheet.xaml
	/// </summary>
	public partial class CharacterSheet : MetroWindow
	{
		Character _character1;
		Character _character2;
		Character _character3;
		Character _character4;
		
		public CharacterSheet()
		{
			Character _char1 = new Character();
			Character _char2 = new Character();
			Character _char3 = new Character();
			Character _char4 = new Character();
			
			_char1 = MainClass.GameParty.Characters[0];
			_char2=MainClass.GameParty.Characters[1];
			_char3=MainClass.GameParty.Characters[2];
			_char4=MainClass.GameParty.Characters[3];
			
			_character1=_char1;
			_character2=_char2;
			_character3=_char3;
			_character4=_char4;
			
			InitializeComponent();
			
			this.Panel1.DataContext = _char1;
			this.Panel2.DataContext = _char2;
			this.Panel3.DataContext=_char3;
			this.Panel4.DataContext= _char4;
							
			Image img1 = FindResource(_char1.CharType) as Image;
			img1.Height=100;
			img1.Width=100;
			
			Image img2 = FindResource(_char2.CharType) as Image;
			img2.Height=100;
			img2.Width=100;
			
			Image img3 = FindResource(_char3.CharType) as Image;
			img3.Height=100;
			img3.Width=100;
			
			Image img4 = FindResource(_char4.CharType) as Image;
			img4.Height=100;
			img4.Width=100;
			
			picpanel1.Children.Add(img1);
			picpanel2.Children.Add(img2);
			picpanel3.Children.Add(img3);
			picpanel4.Children.Add(img4);
		}
		
		void button1_Click(object sender, RoutedEventArgs e)
		{
			if(_character1.Currentlife!=0)
			{
				_character1.Currentlife=_character1.Currentlife-1;
				currliferun.GetBindingExpression(Run.TextProperty).UpdateTarget();
			}
		}
		
		void button12_Click(object sender, RoutedEventArgs e)
		{
			if(_character2.Currentlife!=0)
			{
				_character2.Currentlife=_character2.Currentlife-1;
				currliferun2.GetBindingExpression(Run.TextProperty).UpdateTarget();
			}
		}
		
		void button13_Click(object sender, RoutedEventArgs e)
		{
			if(_character3.Currentlife!=0)
			{
				_character3.Currentlife=_character3.Currentlife-1;
				currliferun3.GetBindingExpression(Run.TextProperty).UpdateTarget();
			}
		}
		
		void button14_Click(object sender, RoutedEventArgs e)
		{
			if(_character4.Currentlife!=0)
			{
				_character4.Currentlife=_character4.Currentlife-1;
				currliferun4.GetBindingExpression(Run.TextProperty).UpdateTarget();
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
		
		void button22_Click(object sender, RoutedEventArgs e)
		{
			if(_character2.Currentlife<_character2.Life)
			{
				_character2.Currentlife=_character2.Currentlife+1;				
				currliferun2.GetBindingExpression(Run.TextProperty).UpdateTarget();			
			}
		}
		
		void button23_Click(object sender, RoutedEventArgs e)
		{
			if(_character3.Currentlife<_character3.Life)
			{
				_character3.Currentlife=_character3.Currentlife+1;				
				currliferun3.GetBindingExpression(Run.TextProperty).UpdateTarget();			
			}
		}
		
		void button24_Click(object sender, RoutedEventArgs e)
		{
			if(_character4.Currentlife<_character4.Life)
			{
				_character4.Currentlife=_character4.Currentlife+1;				
				currliferun4.GetBindingExpression(Run.TextProperty).UpdateTarget();			
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
		
		void button32_Click(object sender, RoutedEventArgs e)
		{
			_character2.LevelUp();
			_character2.SetAttackBonus();
			liferun2.GetBindingExpression(Run.TextProperty).UpdateTarget();
			currliferun2.GetBindingExpression(Run.TextProperty).UpdateTarget();
			levelbox2.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
			attackbonusbox2.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
		}
			
		void button33_Click(object sender, RoutedEventArgs e)
		{
			_character3.LevelUp();
			_character3.SetAttackBonus();
			liferun3.GetBindingExpression(Run.TextProperty).UpdateTarget();
			currliferun3.GetBindingExpression(Run.TextProperty).UpdateTarget();
			levelbox3.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
			attackbonusbox3.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
		}
		
		void button34_Click(object sender, RoutedEventArgs e)
		{
			_character4.LevelUp();
			_character4.SetAttackBonus();
			liferun4.GetBindingExpression(Run.TextProperty).UpdateTarget();
			currliferun4.GetBindingExpression(Run.TextProperty).UpdateTarget();
			levelbox4.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
			attackbonusbox4.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
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
		
		void GoldButton2Click(object sender, RoutedEventArgs e)
		{
			Button btn = new Button();
			btn=(Button)sender;
			string name = btn.Content.ToString();
			switch(name)
			{
				case "+1":
					_character2.Gold=_character2.Gold+1;
					goldbox2.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
					
				case "+10":
					_character2.Gold=_character2.Gold+10;
					goldbox2.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
					
				case "-1":
					if(_character2.Gold>0) _character2.Gold=_character2.Gold-1;
					goldbox2.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
					
				case "-10":
					if(_character2.Gold>9) _character2.Gold=_character2.Gold-10;
					goldbox2.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
			}
				}
		
		void GoldButton3Click(object sender, RoutedEventArgs e)
		{
			Button btn = new Button();
			btn=(Button)sender;
			string name = btn.Content.ToString();
			switch(name)
			{
				case "+1":
					_character3.Gold=_character3.Gold+1;
					goldbox3.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
					
				case "+10":
					_character3.Gold=_character3.Gold+10;
					goldbox3.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
					
				case "-1":
					if(_character3.Gold>0) _character3.Gold=_character3.Gold-1;
					goldbox3.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
					
				case "-10":
					if(_character3.Gold>9) _character3.Gold=_character3.Gold-10;
					goldbox3.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
			}
				}
				
		void GoldButton4Click(object sender, RoutedEventArgs e)
		{
			Button btn = new Button();
			btn=(Button)sender;
			string name = btn.Content.ToString();
			switch(name)
			{
				case "+1":
					_character4.Gold=_character4.Gold+1;
					goldbox4.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
					
				case "+10":
					_character4.Gold=_character4.Gold+10;
					goldbox4.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
					
				case "-1":
					if(_character4.Gold>0) _character4.Gold=_character4.Gold-1;
					goldbox4.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
					break;
					
				case "-10":
					if(_character4.Gold>9) _character4.Gold=_character4.Gold-10;
					goldbox4.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
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
		
		void AddRow2(object sender, RoutedEventArgs e)
		{
			StackPanel pan = new StackPanel();
			pan.Orientation=Orientation.Horizontal;
			spellpanel2.Children.Add(pan);
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
		
		void AddRow3(object sender, RoutedEventArgs e)
		{
			StackPanel pan = new StackPanel();
			pan.Orientation=Orientation.Horizontal;
			spellpanel3.Children.Add(pan);
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
		
		void AddRow4(object sender, RoutedEventArgs e)
		{
			StackPanel pan = new StackPanel();
			pan.Orientation=Orientation.Horizontal;
			spellpanel4.Children.Add(pan);
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
		void Pos_switch(object sender, RoutedEventArgs e)
		{
				int charno;
				int placeno;
				string name;
				ToggleSwitchButton sw = new ToggleSwitchButton();
				sw = (ToggleSwitchButton)sender;
				name = sw.Name;
				charno = Convert.ToInt16(name.Substring(6,1));
				placeno = Convert.ToInt16(name.Substring(8,1));
				
				for(int i=1; i<5; i++)
				{
					if(i!=charno)
					{
						string swname;
						swname="switch" + i.ToString() +"_" + placeno.ToString();
						ToggleSwitchButton sw1=(ToggleSwitchButton)LogicalTreeHelper.FindLogicalNode(this,swname);
						sw1.IsChecked=false;
					}
				}
				
				for(int j=1; j<5; j++)
				{
					if(j!=placeno)
					{
						string swname;
						swname="switch" + charno.ToString() +"_" + j.ToString();
						ToggleSwitchButton sw1=(ToggleSwitchButton)LogicalTreeHelper.FindLogicalNode(this,swname);
						sw1.IsChecked=false;

					}
				}
				
				
		}
	}
}