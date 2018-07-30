/*
 * Created by SharpDevelop.
 * User: rwegl
 * Date: 07/02/2018
 * Time: 11:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections;


namespace FourAgainstDarkness.Model
{
	/// <summary>
	/// Description of Party.
	/// </summary>
	public class Party<T>:ICollection<T> where T : Character 
	{
		protected ArrayList _innerArray;
		protected bool _IsReadOnly;
		
		public Party()
		{
			_innerArray=new ArrayList();
		}

		public virtual T this[int index]
		{
			get
			{
				return (T)_innerArray[index];
			}
			set
			{
				_innerArray[index] = value;
			}
		}
		
		public virtual int Count
		{
			get
			{
				return _innerArray.Count;
			}
		}
		
		public virtual bool IsReadOnly
		{
			get
			{
				return _IsReadOnly;
			}
		}
		
		public virtual void Add(T Character)
		{
			_innerArray.Add(Character);
		}
		
		public virtual bool Remove(T Character)
		{
			bool result = false;
			for(int i=0; i<_innerArray.Count;i++)
			{
				T obj=(T)_innerArray[i];
				
				if(obj.UniqueId == Character.UniqueId)
				{
					_innerArray.RemoveAt(i);
					result=true;
					break;
				}
			}
			
			return result;
		}
		
		public bool Contains(T Character)
		{
			foreach (T obj in _innerArray)
			{
				if(obj.UniqueId == Character.UniqueId);
				{
					return true;
				}
			}
			return false;
		}
		
		public virtual void CopyTo(T[] Party, int index)
		{
			throw new Exception("Not valid for this implementation.");
		}
		
		public virtual void Clear()
		{
			_innerArray.Clear();
		}
		
		public virtual IEnumerator<T> GetEnumerator()
		{
			return new PartyEnumerator<T>(this);
		}
		
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new PartyEnumerator<T>(this);
		}	
		
	}
	
	public class PartyEnumerator<T> : IEnumerator<T> where T : Character
	{
		protected Party<T> _collection;
		protected int index;
		protected T _current;
		
		public PartyEnumerator(Party<T> collection)
		{
			_collection=collection;
			index=-1;
			_current=default(T);
		}
		
		public virtual T Current
		{
			get
			{
				return _current;
			}
		}
		
		object IEnumerator.Current
		{
			get
			{
				return _current;
			}
		}
		
		public virtual void Dispose()
		{
			_collection=null;
			_current=default(T);
			index=-1;
		}
		
		public virtual bool MoveNext()
		{
			if(++index >= _collection.Count)
			{
				return false;
			}
			else
			{
				_current=_collection[index];
			}
			
			return true;
		}
		
		public virtual void Reset()
		{
			_current = default(T);
			index = -1;
		}
	}
	
	public class PartyAlt 
	{
		List<Character> _characters;
		
		public PartyAlt()
		{
			List<Character> characters = new List<Character>();
			_characters=characters;
		}

		public List<Character> Characters {
			get {
				return _characters;
			}
			set {
				_characters = value;
			}
		}
		
		
	}
}
