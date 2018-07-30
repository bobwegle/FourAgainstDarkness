/*
 * Created by SharpDevelop.
 * User: rwegl
 * Date: 7/1/2018
 * Time: 4:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Media;
	
namespace FourAgainstDarkness.Model
{
	/// <summary>
	/// Description of Equipment.
	/// </summary>
	public class Equipment
	{
		private int _value;
		private string _type;
		private string _notes;
		private int _hit;
		private string _weapontype;
		private int _hand;
		private string _name; 
		private ImageSource _image;
		
		public Equipment(int value, string type, string notes)
		{
			_value=value;
			_type=type;
			_notes=notes;
			
			
		}
		
		
		public int Value {
			get { return _value; }
			set { value = _value; }
		}

		public string Type {
			get {
				return _type;
			}
			set {
				_type = value;
			}
		}

		public string Notes {
			get {
				return _notes;
			}
			set {
				_notes = value;
			}
		}

		public int Hit {
			get {
				return _hit;
			}
			set {
				_hit = value;
			}
		}

		public string Weapontype {
			get {
				return _weapontype;
			}
			set {
				_weapontype = value;
			}
		}

		public int Hand {
			get {
				return _hand;
			}
			set {
				_hand = value;
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

		public ImageSource EImage {
			get {
				return _image;
			}
			set {
				_image = value;
			}
		}

		
		
		
		
	}
	
	
}
