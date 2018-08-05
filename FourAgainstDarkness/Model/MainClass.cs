/*
 * Created by SharpDevelop.
 * User: rwegl
 * Date: 07/01/2018
 * Time: 18:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using FourAgainstDarkness.Views;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using FourAgainstDarkness;

namespace FourAgainstDarkness.Model
{
	/// <summary>
	/// Description of Main.
	/// </summary>
	public static class MainClass
	{
		static List<Equipment> equipmentlist = new List<Equipment>();
		static PartyAlt _party;
		
		[STAThread]
		public static void StartupMain()
		{	
					
			Equipment Bandage = new Equipment(5, "Heal", "+1 life, no combat, 1 use" );
			Bandage.Name="Bandage";
			equipmentlist.Add(Bandage);
			
			Equipment BlessingSpell = new Equipment(100, "Spell", "Removes curse" );
			BlessingSpell.Name="Blessing Spell";
			equipmentlist.Add(BlessingSpell);
			
			Equipment Bow = new Equipment(15, "Weapon", "Act before monster attack, spend turn to put away" );
			Bow.Hit=1;
			Bow.Weapontype="Slash";
			Bow.Hand=1;
			Bow.Name="Bow";
			Bow.EImage = new BitmapImage(new Uri(@"/assets/bow.bmp", UriKind.Relative));
			equipmentlist.Add(Bow);
			
			Equipment Sling = new Equipment(15, "Weapon", "Act before monster attack, spend turn to put away" );
			Sling.Hit=-1;
			Sling.Weapontype="Crush";
			Sling.Hand=1;
			Sling.Name="Sling";
			Sling.EImage = new BitmapImage(new Uri(@"/assets/sling.bmp", UriKind.Relative));
			equipmentlist.Add(Sling);
			
			Equipment Crossbow = new Equipment(15, "Weapon", "Act before monster attack, spend turn to put away" );
			Crossbow.Hit=1;
			Crossbow.Weapontype="Crush";
			Crossbow.Hand=1;
			Crossbow.Name="Crossbow";
			Crossbow.EImage = new BitmapImage(new Uri(@"/assets/crossbow.bmp", UriKind.Relative));
			equipmentlist.Add(Crossbow);
			
			Equipment Sword = new Equipment(6, "Weapon", "One handed" );
			Sword.Hit=0;
			Sword.Weapontype="Slash";
			Sword.Hand=1;
			Sword.Name="Sword";
			Sword.EImage = new BitmapImage(new Uri(@"/assets/sword.bmp", UriKind.Relative));
			equipmentlist.Add(Sword);

			Equipment Axe = new Equipment(6, "Weapon", "One handed" );
			Axe.Hit=0;
			Axe.Weapontype="Slash";
			Axe.Hand=1;
			Axe.Name="Axe";
			Axe.EImage = new BitmapImage(new Uri(@"/assets/axe.bmp", UriKind.Relative));
			equipmentlist.Add(Axe);
			
			Equipment Spear = new Equipment(6, "Weapon", "One handed" );
			Spear.Hit=0;
			Spear.Weapontype="Slash";
			Spear.Hand=1;
			Spear.Name="Spear";
			Spear.EImage = new BitmapImage(new Uri(@"/assets/spear.bmp", UriKind.Relative));
			equipmentlist.Add(Spear);
			
			Equipment Mace = new Equipment(6, "Weapon", "One handed" );
			Mace.Hit=0;
			Mace.Weapontype="Crush";
			Mace.Hand=1;
			Mace.Name="Mace";
			Mace.EImage = new BitmapImage(new Uri(@"/assets/mace.bmp", UriKind.Relative));
			equipmentlist.Add(Mace);
			
			Equipment Hammer = new Equipment(6, "Weapon", "One handed" );
			Hammer.Hit=0;
			Hammer.Weapontype="Crush";
			Hammer.Hand=1;
			Hammer.Name="Hammer";
			Hammer.EImage = new BitmapImage(new Uri(@"/assets/hammer.bmp", UriKind.Relative));
			equipmentlist.Add(Hammer);
			
			Equipment HeavyArmor = new Equipment(30, "Defense", "Check Monster, Check Save Roll, No-Share" );
			HeavyArmor.Hit=2;
			HeavyArmor.Name="Heavy Armor";
			equipmentlist.Add(HeavyArmor);
			
			Equipment HolyWaterVial = new Equipment(30, "Weapon", "Check Monster" );
			HolyWaterVial.Hit=1;
			HolyWaterVial.Name="Holy Water Vial";
			equipmentlist.Add(HolyWaterVial);
			
			Equipment Lantern = new Equipment(4, "", "Must be carried by 1 character, transferable" );
			Lantern.Hand=1;
			Lantern.Name="Lantern";
			Lantern.EImage = new BitmapImage(new Uri(@"/assets/lantern.bmp", UriKind.Relative));
			equipmentlist.Add(Lantern);
			
			Equipment LockPicks = new Equipment(0, "", "Default for Rogue only" );
			LockPicks.Name="Lock Picks";
			equipmentlist.Add(LockPicks);
			
			Equipment Spellbook = new Equipment(0, "", "Default for Wizard only" );
			Spellbook.Name="Spell Book";
			equipmentlist.Add(Spellbook);
			
			Equipment WritingImplements = new Equipment(0, "", "Default for Wizard only" );
			WritingImplements.Name="Writing Implements";
			equipmentlist.Add(WritingImplements);
			
			Equipment LightArmor = new Equipment(10, "Defense", "Transferable to same species" );
			LightArmor.Hit=1;
			LightArmor.Name="Light Armor";
			equipmentlist.Add(LightArmor);
			
			Equipment Dagger = new Equipment(5, "Weapon", "One handed" );
			Dagger.Hit=-1;
			Dagger.Weapontype="Slash";
			Dagger.Hand=1;
			Dagger.Name="Dagger";
			Dagger.EImage = new BitmapImage(new Uri(@"/assets/dagger.bmp", UriKind.Relative));
			equipmentlist.Add(Dagger);
			
			Equipment Knife = new Equipment(5, "Weapon", "One handed" );
			Knife.Hit=-1;
			Knife.Weapontype="Slash";
			Knife.Hand=1;
			Knife.Name="Knife";
			Knife.EImage = new BitmapImage(new Uri(@"/assets/knife.bmp", UriKind.Relative));
			equipmentlist.Add(Knife);

			Equipment ShortSword = new Equipment(5, "Weapon", "One handed" );
			ShortSword.Hit=-1;
			ShortSword.Weapontype="Slash";
			ShortSword.Hand=1;
			ShortSword.Name="Short Sword";
			ShortSword.EImage = new BitmapImage(new Uri(@"/assets/shortsword.bmp", UriKind.Relative));
			equipmentlist.Add(ShortSword);
			
			Equipment WizardStaff = new Equipment(5, "Weapon", "One handed" );
			WizardStaff.Hit=-1;
			WizardStaff.Weapontype="Crush";
			WizardStaff.Hand=1;
			WizardStaff.Name="Wizard Staff";
			WizardStaff.EImage = new BitmapImage(new Uri(@"/assets/wizardstaff.bmp", UriKind.Relative));
			equipmentlist.Add(WizardStaff);

			Equipment Club = new Equipment(5, "Weapon", "One handed" );
			Club.Hit=-1;
			Club.Weapontype="Crush";
			Club.Hand=1;
			Club.Name="Club";
			Club.EImage = new BitmapImage(new Uri(@"/assets/club.bmp", UriKind.Relative));
			equipmentlist.Add(Club);

			Equipment HealingPotion = new Equipment(100, "Heal", "Full life, Anytime, 1 use" );
			HealingPotion.Name="Potion of Healing";
			equipmentlist.Add(HealingPotion);
			
			Equipment ResurrectionRitual = new Equipment(1000, "Spell", "Raise character from death" );
			ResurrectionRitual.Name="Resurrection Ritual";
			equipmentlist.Add(ResurrectionRitual);
			
			Equipment Rope = new Equipment(4, "", "" );
			Rope.Hand=0;
			Rope.Name="Rope";
			equipmentlist.Add(Rope);
			
			Equipment Shield = new Equipment(5, "Defense", "" );
			Shield.Hit=1;
			Shield.Name="Shield";
			Shield.Hand=1;
			Shield.EImage = new BitmapImage(new Uri(@"/assets/shield.bmp", UriKind.Relative));
			equipmentlist.Add(Shield);
			
			Equipment Maul = new Equipment(15, "Weapon", "Two handed" );
			Maul.Hit=2;
			Maul.Weapontype="Crush";
			Maul.Hand=2;
			Maul.Name="Maul";
			Maul.EImage = new BitmapImage(new Uri(@"/assets/maul.bmp", UriKind.Relative));
			equipmentlist.Add(Maul);
			
			Equipment WarHammer = new Equipment(15, "Weapon", "Two handed" );
			WarHammer.Hit=2;
			WarHammer.Weapontype="Crush";
			WarHammer.Hand=2;
			WarHammer.Name="War Hammer";
			WarHammer.EImage = new BitmapImage(new Uri(@"/assets/warhammer.bmp", UriKind.Relative));
			equipmentlist.Add(WarHammer);
			
			Equipment Quarterstaff = new Equipment(15, "Weapon", "Two handed" );
			Quarterstaff.Hit=2;
			Quarterstaff.Weapontype="Crush";
			Quarterstaff.Hand=2;
			Quarterstaff.Name="Quarterstaff";
			Quarterstaff.EImage = new BitmapImage(new Uri(@"/assets/quarterstaff.bmp", UriKind.Relative));
			equipmentlist.Add(Quarterstaff);
			
			Equipment Pike = new Equipment(15, "Weapon", "Two handed" );
			Pike.Hit=2;
			Pike.Weapontype="Slash";
			Pike.Hand=2;
			Pike.Name="Pike";
			Pike.EImage = new BitmapImage(new Uri(@"/assets/pike.bmp", UriKind.Relative));
			equipmentlist.Add(Pike);
			
			Equipment LongSpear = new Equipment(15, "Weapon", "Two handed" );
			LongSpear.Hit=2;
			LongSpear.Weapontype="Slash";
			LongSpear.Hand=2;
			LongSpear.Name="Long Spear";
			LongSpear.EImage = new BitmapImage(new Uri(@"/assets/longspear.bmp", UriKind.Relative));
			equipmentlist.Add(LongSpear);
			
			Equipment TwoHandedSword = new Equipment(15, "Weapon", "Two handed" );
			TwoHandedSword.Hit=2;
			TwoHandedSword.Weapontype="Slash";
			TwoHandedSword.Hand=2;
			TwoHandedSword.Name="Two-Handed Sword";
			TwoHandedSword.EImage = new BitmapImage(new Uri(@"/assets/twohandedsword.bmp", UriKind.Relative));
			equipmentlist.Add(TwoHandedSword);
			
			ControlPanel controlpanel = new ControlPanel();
			controlpanel.ShowDialog();
		}

		public static List<Equipment> Equipmentlist {
			get {
				return equipmentlist;
			}
			set {
				equipmentlist = value;
			}
		}
		
		
		
		public static void CreateNewParty()
		{
			PartyAlt party = new PartyAlt();
			PartyWin partywin=new PartyWin(party);
			partywin.Show();
		}
		
		public static void CreateNewCharacter(PartyWin partywin, Button charpos)
		{
			Character chara = new Character();
			NewCharacter newcharacter = new NewCharacter(partywin,charpos);
			newcharacter.CharTypeCombo.Items.Add("Warrior");
			newcharacter.CharTypeCombo.Items.Add("Cleric");
			newcharacter.CharTypeCombo.Items.Add("Rogue");
			newcharacter.CharTypeCombo.Items.Add("Wizard");
			newcharacter.CharTypeCombo.Items.Add("Barbarian");
			newcharacter.CharTypeCombo.Items.Add("Elf");
			newcharacter.CharTypeCombo.Items.Add("Dwarf");
			newcharacter.CharTypeCombo.Items.Add("Halfling");
			newcharacter.GoldBox.Text="0";
			for(int i=1; i<16; i++){
				newcharacter.LevelCombo.Items.Add(i);
			}
			
			newcharacter.LevelCombo.SelectedIndex=0;
				
			newcharacter.Show();
		}
		
		public static Character FleshOut(string type)
		{
			if(type == "Warrior"){
				Character _warrior = new Character(type);
				_warrior.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Sword")));
				_warrior.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Light Armor")));
				_warrior.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Shield")));
				_warrior.Equipnotes = "May trade Shield and Sword for Two-Handed Sword or Bow. Shield, Light Armor, Heavy Armor allowed.";
				_warrior.Life=_warrior.Newwarrior.Calculatelife(1);
				return _warrior;
			}
			
			if(type == "Barbarian"){
				Character _barbarian = new Character(type);
				_barbarian.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Sword")));
				_barbarian.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Light Armor")));
				_barbarian.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Shield")));
				_barbarian.Equipnotes = "May trade Shield and Sword for Two-Handed Sword or Bow. Shield and Light Armor allowed. No written material, scrolls, potions, or magic items. May use holy water.";
				_barbarian.Life=_barbarian.Newbarbarian.Calculatelife(1);
				return _barbarian;
			}
			
			if(type == "Cleric"){
				Character _cleric = new Character(type);
				_cleric.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Sword")));
				_cleric.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Light Armor")));
				_cleric.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Shield")));
				_cleric.Equipnotes = "May trade Shield and Sword for Two-Handed Sword. May use Shield, Light Armor, Heavy Armor. Weapons are hand weapon, two handed, sling. May use up to 3 blessing or healing spells.";
				_cleric.Life=_cleric.Newcleric.Calculatelife(1);				
				return _cleric;
			}
			
			if(type == "Rogue"){
				Character _rogue = new Character(type);
				_rogue.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Rope")));
				_rogue.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Lock Picks")));
				_rogue.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Light Armor")));
				_rogue.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Dagger")));
				_rogue.Equipnotes = "Light armor allowed, light weapon or sling allowed";
				_rogue.Life=_rogue.Newrogue.Calculatelife(1);				
				return _rogue;
			}
			
			if(type == "Wizard"){
				Character _wizard = new Character(type);
				_wizard.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Spell Book")));
				_wizard.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Writing Implements")));
				_wizard.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Wizard Staff")));
				_wizard.Equipnotes = "Choose 2 spells + 1 spell per level as default";
				_wizard.Life=_wizard.Newwizard.Calculatelife(1);				
				return _wizard;
			}
			
				if(type == "Elf"){
				Character _elf = new Character(type);
				_elf.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Light Armor")));
				_elf.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Short Sword")));
				_elf.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Bow")));
				_elf.Equipnotes = "May use any weapon, shield, light armor or heavy armor. May buy and cast 1 spell/level/game with light armor and no shield.";
				_elf.Life=_elf.Newelf.Calculatelife(1);				
				return _elf;
			}
			
				if(type == "Dwarf"){
				Character _dwarf = new Character(type);
				_dwarf.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Light Armor")));
				_dwarf.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Sword")));
				_dwarf.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Shield")));
				_dwarf.Equipnotes = "May trade all default for Heavy Armor and Two-Handed Weapon.";
				_dwarf.Life=_dwarf.Newdwarf.Calculatelife(1);				
				return _dwarf;
				
			}
				
				if(type == "Halfling"){
				Character _halfling = new Character(type);
				_halfling.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Sling")));
				_halfling.Equipmentcarried.Add(MainClass.Equipmentlist.Find(x=>x.Name.Equals("Short Sword")));
				_halfling.Equipnotes = "Light hand weapons, sling, Light Armor allowed.";
				_halfling.Life=_halfling.Newhalfling.Calculatelife(1);				
				return _halfling;
			}
			return null;
		}

		public static PartyAlt GameParty {
			get {
				return _party;
			}
			set {
				_party = value;
			}
		}
		
		
	}
}
