/*
 * Created by SharpDevelop.
 * User: rwegl
 * Date: 6/29/2018
 * Time: 12:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace FourAgainstDarkness.Model
{
	/// <summary>
	/// Description of Character.
	/// </summary>
	public class Character
	{
		protected Guid? _UniqueId;
		
		private int _life;
		private string _type;
		private string _name;
		private int _level;
		private int _currentlife;
		private int _gold;
		private bool _lantern;
		private bool _bandaged;
		private List<Equipment> _equipmentcarried;
		private string _equipnotes;
		private Warrior _warrior;
		private Barbarian _barbarian;
		private Cleric _cleric;
		private Rogue _rogue;
		private Wizard _wizard;
		private Elf _elf;
		private Dwarf _dwarf;
		private Halfling _halfling;
		private string _attacknotes;
		private string _defensenotes;
		private int _attackbonus;
		private int _defensebonus;
		private int _equipattackbonus;
		private string _equipattacknotes;
		private int _equipdefensebonus;
		private string _equipdefensenotes;
		
		
		public Character()
		{
			_UniqueId=Guid.NewGuid();
			_equipmentcarried = new List<Equipment>();
		}
		
		public Character(string type)
		{
			_UniqueId=Guid.NewGuid();
			_equipmentcarried = new List<Equipment>();
			
			_type=type;
			
			if(_type=="Warrior"){
				Warrior warrior = new Warrior();
				_life=warrior.Life;
				_warrior=warrior;
			}
			
			if(_type=="Barbarian"){
				Barbarian barbarian = new Barbarian();
				_life=barbarian.Life;
				_barbarian=barbarian;		
			}
			
			if(_type=="Cleric"){
				Cleric cleric = new Cleric();
				_life=cleric.Life;
				_cleric=cleric;
			}
			
			if(_type=="Rogue"){
				Rogue rogue = new Rogue();
				_life=rogue.Life;
				_rogue =rogue;
			}
			
			if(_type=="Wizard"){
				Wizard wizard = new Wizard();
				_life=wizard.Life;
				_wizard=wizard;
			}
			
			if(_type=="Elf"){
				Elf elf = new Elf();
				_life=elf.Life;
				_elf=elf;
			}
			
			if(_type=="Dwarf"){
				Dwarf dwarf = new Dwarf();
				_life=dwarf.Life;
				_dwarf=dwarf;
			}
			
			if(_type=="Halfling"){
				Halfling halfling = new Halfling();
				_life=halfling.Life;
				_halfling=halfling;
			}
		}
	
		public Guid? UniqueId
		{
			get
			{
				return _UniqueId;
			}
			set
			{
				_UniqueId=value;
			}
		}
		
		public int CalculateLife(int Lev)
		{
			switch (_type)
			{
				case "Warrior":
					int i1=_warrior.Calculatelife(Lev);
					return i1;
					break;
					
				case "Barbarian":
					int i2=_barbarian.Calculatelife(Lev);
					return i2;
										
				case "Cleric":
					int i3=_cleric.Calculatelife(Lev);
					return i3;
										
				case "Dwarf":
					int i4=_dwarf.Calculatelife(Lev);
					return i4;
					
				case "Elf":
					int i5=_elf.Calculatelife(Lev);
					return i5;
					
				case "Halfline":
					int i6=_halfling.Calculatelife(Lev);
					return i6;
					
				case "Rogue":
					int i7=_rogue.Calculatelife(Lev);
					return i7;
					
				case "Wizard":
					int i8=_wizard.Calculatelife(Lev);
					return i8;
			}
			
			int j = 0;
			return j;
		}
		
		public void LevelUp()
		{
			_level=_level+1;
			_life=_life+1;
			_currentlife=_currentlife+1;
			
			if(_type=="Warrior") _attackbonus=_level;
	
		}
		
		public void SetAttackBonus()
		{
			switch (_type)
			{
				case "Warrior":
					_attackbonus=_level;
					break;
					
				case "Barbarian":

					break;
										
				case "Cleric":

					break;
										
				case "Dwarf":

					break;
					
				case "Elf":

					break;
					
				case "Halfling":

					break;
					
				case "Rogue":

					break;
					
				case "Wizard":

					break;
			}

		}
		
		public void SetDefenseBonus()
		{
			switch (_type)
			{
				case "Warrior":
					
					break;
					
				case "Barbarian":

					break;
										
				case "Cleric":

					break;
										
				case "Dwarf":

					break;
					
				case "Elf":

					break;
					
				case "Halfling":

					break;
					
				case "Rogue":

					break;
					
				case "Wizard":

					break;
			}

		}
		
		public void SetEquipAttackBonus()
		{
			int i=0;
				
			foreach(Equipment equ in Equipmentcarried)
			{
				if(equ.Type=="Weapon")
				{
					i=i+equ.Hit;
				}
			}
			
			_equipattackbonus=i;
			_equipattacknotes="If all weapons in hand. ";
		}
		
		public void SetEquipDefenseBonus()
		{
			int i=0;
				
			foreach(Equipment equ in Equipmentcarried)
			{
				if(equ.Type=="Defense")
				{
					i=i+equ.Hit;
				}
			}
			
			_equipdefensebonus=i;
			_equipdefensenotes="If shield in hand. -1 for Shield if fleeing or surprised by wandering monsters.";
		}
		

		public int Level {
			get {
				return _level;
			}
			set {
				_level = value;
			}
		}

		public int Life {
			get {
				return _life;
			}
			set {
				_life = value;
			}
		}
		
		

		public int Currentlife {
			get {
				return _currentlife;
			}
			set {
				_currentlife = value;
			}
		}

		public List<Equipment> Equipmentcarried {
			get {
				return _equipmentcarried;
			}
			set {
				_equipmentcarried = value;
			}
		}

		public string Equipnotes {
			get {
				return _equipnotes;
			}
			set {
				_equipnotes = value;
			}
		}

		public Warrior Newwarrior {
			get {
				return _warrior;
			}
			set {
				_warrior = value;
			}
		}

		public Barbarian Newbarbarian {
			get {
				return _barbarian;
			}
			set {
				_barbarian = value;
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

		public string Name {
			get {
				return _name;
			}
			set {
				_name = value;
			}
		}
		
		public string CharType {
			get{
				return _type;
			}
			set {
				_type=value;
			}
		}

		public int Gold {
			get {
				return _gold;
			}
			set {
				_gold = value;
			}
		}

		public string Attacknotes {
			get {
				return _attacknotes;
			}
			set {
				_attacknotes = value;
			}
		}

		public string Defensenotes {
			get {
				return _defensenotes;
			}
			set {
				_defensenotes = value;
			}
		}

		public int Attackbonus {
			get {
				return _attackbonus;
			}
			set {
				_attackbonus = value;
			}
		}

		public int Defensebonus {
			get {
				return _defensebonus;
			}
			set {
				_defensebonus = value;
			}
		}

		public int Equipattackbonus {
			get {
				return _equipattackbonus;
			}
			set {
				_equipattackbonus = value;
			}
		}

		public string Equipattacknotes {
			get {
				return _equipattacknotes;
			}
			set {
				_equipattacknotes = value;
			}
		}
		public int Equipdefensebonus {
			get {
				return _equipdefensebonus;
			}
			set {
				_equipdefensebonus = value;
			}
		}

		public string Equipdefensenotes {
			get {
				return _equipdefensenotes;
			}
			set {
				_equipattacknotes = value;
			}
		}		
	
		
	}
	
	public class Warrior:Character{
		
		private int _life;
		private string _defaultwealth="Roll 2D6";
		
		
		public Warrior(int level):base()
		{
			_life=level+6;
			Level=Level;
		}
		
		public Warrior():base()
		{}
		
		public int Calculatelife(int level)
		{
			int _clife=level+6;
			return _clife;
		}
		
		public void LevelUp()
		{
			Level=Level+1;
			_life=_life+1;
		//	Base.CurrentLife=Base.Currentlife+1;
		}
		

		public int Life {
			get {
				return _life;
			}
			
			set{
				_life=value;
			}
		}

		public string Defaultwealth {
			get {
				return _defaultwealth;
			}
		}		
	}
	
		public class Barbarian:Character{
		
		private int _life;
		private string _defaultwealth="Roll D6";
		
		
		public Barbarian(int level):base()
		{
			_life=level+7;
			Level=Level;
		}
		
		public Barbarian():base()
		{}
		
		public void LevelUp()
		{
			Level=Level+1;
			_life=_life+1;
		//	Base.CurrentLife=Base.Currentlife+1;
		}
		
		public int Calculatelife(int level)
		{
			int _clife=level+7;
			return _clife;
		}
		
		public int Life {
			get {
				return _life;
			}
		}

		public string Defaultwealth {
			get {
				return _defaultwealth;
			}
		}	
	}
	
		public class Cleric:Character{
		
		private int _life;
		private string _defaultwealth="Roll D6";
		
		
		public Cleric(int level):base()
		{
			_life=level+4;
			Level=Level;
		}
		
		public Cleric():base()
		{}
		
		public void LevelUp()
		{
			Level=Level+1;
			_life=_life+1;
		//	Base.CurrentLife=Base.Currentlife+1;
		}

		public int Calculatelife(int level)
		{
			int _clife=level+4;
			return _clife;
		}		

		public int Life {
			get {
				return _life;
			}
		}

		public string Defaultwealth {
			get {
				return _defaultwealth;
			}
		}			
	}
	
		public class Rogue:Character{
		
		private int _life;
		private string _defaultwealth="Roll 3D6";
		
		
		public Rogue(int level):base()
		{
			_life=level+3;
			Level=Level;
		}
		
		public Rogue():base()
		{}
		
		public void LevelUp()
		{
			Level=Level+1;
			_life=_life+1;
		//	Base.CurrentLife=Base.Currentlife+1;
		}

		public int Calculatelife(int level)
		{
			int _clife=level+3;
			return _clife;
		}		

		public int Life {
			get {
				return _life;
			}
		}

		public string Defaultwealth {
			get {
				return _defaultwealth;
			}
		}

		
	}
	
		public class Wizard:Character{
		
		private int _life;
		private string _defaultwealth="Roll 4D6";
		
		
		public Wizard(int level):base()
		{
			_life=level+2;
			Level=Level;
		}
		
		public Wizard():base()
		{}
		
		public void LevelUp()
		{
			Level=Level+1;
			_life=_life+1;
		//	Base.CurrentLife=Base.Currentlife+1;
		}
		
		public int Calculatelife(int level)
		{
			int _clife=level+2;
			return _clife;
		}
		
		public int Life {
			get {
				return _life;
			}
		}

		public string Defaultwealth {
			get {
				return _defaultwealth;
			}
		}		
	}
	
		public class Elf:Character{
		
		private int _life;
		private string _defaultwealth="Roll 2D6";
		
		
		public Elf(int level):base()
		{
			_life=level+4;
			Level=Level;
		}
		
		public Elf():base()
		{}
		
		public void LevelUp()
		{
			Level=Level+1;
			_life=_life+1;
		//	Base.CurrentLife=Base.Currentlife+1;
		}
		
		public int Calculatelife(int level)
		{
			int _clife=level+4;
			return _clife;
		}
		
		public int Life {
			get {
				return _life;
			}
		}

		public string Defaultwealth {
			get {
				return _defaultwealth;
			}
		}		
	}
	
		public class Dwarf:Character{
		
		private int _life;
		private string _defaultwealth="Roll 3D6";
		
		
		public Dwarf(int level):base()
		{
			_life=level+5;
			Level=Level;
		}
		
		public Dwarf():base()
		{}
		
		public void LevelUp()
		{
			Level=Level+1;
			_life=_life+1;
		//	Base.CurrentLife=Base.Currentlife+1;
		}
		
		public int Calculatelife(int level)
		{
			int _clife=level+5;
			return _clife;
		}
		
		public int Life {
			get {
				return _life;
			}
		}

		public string Defaultwealth {
			get {
				return _defaultwealth;
			}
		}		
	}
	
		public class Halfling:Character{
		
		private int _life;
		private string _defaultwealth="Roll 2D6";
		
		
		public Halfling(int level):base()
		{
			_life=level+3;
			Level=Level;
		}
		
		public Halfling():base()
		{}
		
		public void LevelUp()
		{
			Level=Level+1;
			_life=_life+1;
		//	Base.CurrentLife=Base.Currentlife+1;
		}
		
		public int Calculatelife(int level)
		{
			int _clife=level+3;
			return _clife;
		}
		
		public int Life {
			get {
				return _life;
			}
		}

		public string Defaultwealth {
			get {
				return _defaultwealth;
			}
		}		
	}
}

