using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

internal sealed class _0002_2001_200B : IComparable
{
	private int m__0005;

	private int m__0002;

	private int m__000F;

	private int m__0006;

	public _0002_2001_200B(string _0005)
	{
		_002Ector_2(_0005);
	}

	public int _0005()
	{
		return this.m__0005;
	}

	public int _0002()
	{
		return this.m__0002;
	}

	public int _000F()
	{
		return this.m__000F;
	}

	public int _0006()
	{
		return this.m__0006;
	}

	public int _0008()
	{
		return int.Parse(_0005().ToString() + _0002());
	}

	public static int _0005(_0002_2001_200B _0005, _0002_2001_200B _0002)
	{
		object[] array = new object[2] { _0005, _0002 };
		return (int)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "mafq<e'cWh", array);
	}

	public override string ToString()
	{
		object[] array = new object[1] { this };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "C\"Chae'cWh", array);
	}

	private bool _0005(StringBuilder _0005, int _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), ":Y+(Ge'cWi", array);
	}

	private int _0005(string _0005)
	{
		object[] array = new object[2] { this, _0005 };
		return (int)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "mafq<e'cWj", array);
	}

	private int _0005(string[] _0005, int _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		return (int)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), ".+Zque'cWj", array);
	}

	public override int GetHashCode()
	{
		object[] array = new object[1] { this };
		return (int)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "$.dYVe'cWf", array);
	}

	public bool _0005(_0002_2001_200B _0005)
	{
		object[] array = new object[2] { this, _0005 };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), ":tF1He'cWk", array);
	}

	public int CompareTo(object _0005)
	{
		object[] array = new object[2] { this, _0005 };
		return (int)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "kLS25e'cWl", array);
	}

	public override bool Equals(object _0005)
	{
		object[] array = new object[2] { this, _0005 };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "I+Hite'cWl", array);
	}

	private void _002Ector_2(string P_0)
	{
		object[] array = new object[2] { this, P_0 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), ">1V6Re'cWe", array);
	}
}
internal interface _0002_2008_200B<_0005> : _0005_2008_200B
{
	global::_0008_2008_200B<_0005> GetEnumerator();
}
internal sealed class _0002_2009_200B : _000F
{
	private new byte m__0005;

	public _0002_2009_200B()
		: base(12)
	{
	}

	public new byte _0005()
	{
		return this.m__0005;
	}

	public void _0005(byte _0005)
	{
		this.m__0005 = _0005;
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0002_2009_200B obj = new _0002_2009_200B();
		obj._0005(this.m__0005);
		obj._0005(base._0005());
		return obj;
	}

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		return _0005();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		if (_0005 is short)
		{
			this._0005((byte)(short)_0005);
		}
		else if (_0005 is int)
		{
			this._0005((byte)(int)_0005);
		}
		else if (_0005 is long)
		{
			this._0005((byte)(long)_0005);
		}
		else if (_0005 is ushort)
		{
			this._0005((byte)(ushort)_0005);
		}
		else if (_0005 is uint)
		{
			this._0005((byte)(uint)_0005);
		}
		else if (_0005 is ulong)
		{
			this._0005((byte)(ulong)_0005);
		}
		else if (_0005 is float)
		{
			this._0005((byte)(float)_0005);
		}
		else if (_0005 is double)
		{
			this._0005((byte)(double)_0005);
		}
		else
		{
			this._0005(Convert.ToByte(_0005));
		}
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		switch (_0005._0005())
		{
		case 15:
			this._0005(Convert.ToByte(((_0008_2006)_0005)._0005()));
			break;
		case 12:
			this._0005(((_0002_2009_200B)_0005)._0005());
			break;
		case 26:
			this._0005((byte)((_000E_2001)_0005)._0005());
			break;
		case 1:
			this._0005((byte)((_0006)_0005)._0005());
			break;
		case 13:
			this._0005((byte)((_0003_2003)_0005)._0005());
			break;
		case 17:
			this._0005((byte)((_0003_200B)_0005)._0005());
			break;
		case 19:
			this._0005(Convert.ToByte(((_0005_0019)_0005)._0005()));
			break;
		case 8:
			this._0005((byte)((_000F_2006)_0005)._0005());
			break;
		case 22:
			this._0005((byte)((_0006_2000)_0005)._0005());
			break;
		case 0:
			this._0005((byte)(int)((_000F_2002)_0005)._0005());
			break;
		case 20:
			this._0005((byte)(uint)((_0005_2008)_0005)._0005());
			break;
		case 16:
			this._0005((byte)((_0008_200A)_0005)._0005());
			break;
		case 3:
			this._0005((byte)((_0006_200B)_0005)._0005());
			break;
		case 14:
			this._0005((byte)((_000E_2005)_0005)._0005());
			break;
		case 7:
			this._0005(Convert.ToByte(((_0008_2008)_0005)._0005()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal sealed class _0002_200A_200B : _0005_2000
{
	private new Array m__0005;

	private long _0002;

	public _0002_200A_200B()
		: base(24)
	{
	}

	public new Array _0005()
	{
		return this.m__0005;
	}

	public void _0005(Array _0005)
	{
		this.m__0005 = _0005;
	}

	public new long _0005()
	{
		return _0002;
	}

	public void _0005(long _0005)
	{
		_0002 = _0005;
	}

	[SpecialName]
	public override object _0005_2000_2001_2004_2001_0005()
	{
		return this.m__0005.GetValue(_0002);
	}

	[SpecialName]
	public override void _0005_2000_2001_2004_2001_0005(object _0005)
	{
		this.m__0005.SetValue(_0005, _0002);
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		((_000F)this)._0005(_0005._0005());
		if (_0005._0005() == 24)
		{
			_0002_200A_200B obj = (_0002_200A_200B)_0005;
			this._0005(obj._0005());
			this._0005(obj._0005());
			base._0005(((_0005_2000)obj)._0005());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0002_200A_200B obj = new _0002_200A_200B();
		obj._0005(this.m__0005);
		obj._0005(_0002);
		obj._0005(base._0005());
		((_000F)obj)._0005(((_000F)this)._0005());
		return obj;
	}

	public override bool _0005_2000_2001_2004_2001_0005(_0005_2000 _0005)
	{
		_0002_200A_200B obj = (_0002_200A_200B)_0005;
		if (this._0005() == obj._0005())
		{
			return this._0005() == obj._0005();
		}
		return false;
	}
}
internal static class _0002_200B_200B
{
	[STAThread]
	private static void _0005()
	{
		_0003_2001_200B._0005();
	}
}
internal static class _0003_2001_200B
{
	private static string m__0005;

	static _0003_2001_200B()
	{
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "C=^qbe'cW>", (object[])null);
	}

	[STAThread]
	internal static void _0005()
	{
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "ak#\"le'cW`", (object[])null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void _0002()
	{
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "[FWmXe'cWb", (object[])null);
	}
}
internal static class _0003_2008_200B
{
	internal sealed class _0002 : global::_0002_2008_200B<int>, _0005_2008_200B, global::_0008_2008_200B<int>, _0006_2008_200B, _000F_2008_200B
	{
		private int _0005;

		private int m__0002;

		private int _000F;

		private int _0006;

		[DebuggerHidden]
		public _0002(int _0005)
		{
			this._0005 = _0005;
			_000F = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		private void _0002_2001_2004_2001_0005()
		{
			_0005 = -2;
		}

		void _0006_2008_200B._0006_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0002_2001_2004_2001_0005();
		}

		private bool _000F_2008_200B_2001_2004_2001_0005()
		{
			int num = _0005;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_0005 = -1;
				_0006 += _0006;
				if (_0006 == 64)
				{
					_0006 = 5;
				}
			}
			else
			{
				_0005 = -1;
				_0006 = 1;
			}
			m__0002 = _0006;
			_0005 = 1;
			return true;
		}

		bool _000F_2008_200B._000F_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in  ​   
			return this._000F_2008_200B_2001_2004_2001_0005();
		}

		[DebuggerHidden]
		private int _0002_2001_2004_2001_0005()
		{
			return m__0002;
		}

		int global::_0008_2008_200B<int>._000F_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0002_2001_2004_2001_0005();
		}

		[DebuggerHidden]
		private void _0002_2001_2004_2001_0002()
		{
			throw new NotSupportedException();
		}

		void _000F_2008_200B._000F_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0002_2001_2004_2001_0002();
		}

		[DebuggerHidden]
		private object _0002_2001_2004_2001_0005()
		{
			return m__0002;
		}

		object _000F_2008_200B._000F_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0002_2001_2004_2001_0005();
		}

		[DebuggerHidden]
		private global::_0008_2008_200B<int> _0002_2001_2004_2001_0005()
		{
			if (_0005 == -2 && _000F == Thread.CurrentThread.ManagedThreadId)
			{
				_0005 = 0;
				return this;
			}
			return new _0002(0);
		}

		global::_0008_2008_200B<int> global::_0002_2008_200B<int>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0002_2001_2004_2001_0005();
		}

		[DebuggerHidden]
		private _000F_2008_200B _0002_2001_2004_2001_0005()
		{
			return _0002_2001_2004_2001_0005();
		}

		_000F_2008_200B _0005_2008_200B._0005_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0002_2001_2004_2001_0005();
		}
	}

	internal sealed class _0005 : global::_0002_2008_200B<int>, _0005_2008_200B, global::_0008_2008_200B<int>, _0006_2008_200B, _000F_2008_200B
	{
		private int m__0005;

		private int m__0002;

		private int _000F;

		private int _0006;

		public int _0008;

		private int _0003;

		private int _000E;

		private global::_0008_2008_200B<int> _0005_2009;

		private int _0002_2009;

		[DebuggerHidden]
		public _0005(int _0005)
		{
			this.m__0005 = _0005;
			_000F = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		private void _0005_2001_2004_2001_0005()
		{
			int num = m__0005;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_0002();
				}
			}
			_0005_2009 = null;
			m__0005 = -2;
		}

		void _0006_2008_200B._0006_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0005_2001_2004_2001_0005();
		}

		private bool _000F_2008_200B_2001_2004_2001_0005()
		{
			bool result;
			try
			{
				switch (m__0005)
				{
				default:
					result = false;
					goto end_IL_0000;
				case 0:
					m__0005 = -1;
					_0003 = 0;
					_000E = 1;
					_0005_2009 = ((global::_0002_2008_200B<int>)new _0002(-2)).GetEnumerator();
					m__0005 = -3;
					break;
				case 1:
					m__0005 = -3;
					_0006--;
					if (_0006 != 0)
					{
						int num = _000E;
						_000E = (num + _0003 + _0006) ^ (-1358275320 + _0002_2009);
						_0003 = num;
						break;
					}
					result = false;
					_0002();
					goto end_IL_0000;
				}
				if (((_000F_2008_200B)_0005_2009)._000F_2008_200B_2001_2004_2001_0005())
				{
					_0002_2009 = _0005_2009._000F_2008_200B_2001_2004_2001_0005();
					this.m__0002 = _000E;
					m__0005 = 1;
					result = true;
				}
				else
				{
					_0002();
					_0005_2009 = null;
					result = false;
				}
				end_IL_0000:;
			}
			catch
			{
				//try-fault
				_0005_2001_2004_2001_0005();
				throw;
			}
			return result;
		}

		bool _000F_2008_200B._000F_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in  ​   
			return this._000F_2008_200B_2001_2004_2001_0005();
		}

		private void _0002()
		{
			m__0005 = -1;
			if (_0005_2009 != null)
			{
				_0005_2009._0006_2008_200B_2001_2004_2001_0005();
			}
		}

		[DebuggerHidden]
		private int _0005_2001_2004_2001_0005()
		{
			return this.m__0002;
		}

		int global::_0008_2008_200B<int>._000F_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0005_2001_2004_2001_0005();
		}

		[DebuggerHidden]
		private void _0005_2001_2004_2001_000F()
		{
			throw new NotSupportedException();
		}

		void _000F_2008_200B._000F_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0005_2001_2004_2001_000F();
		}

		[DebuggerHidden]
		private object _0005_2001_2004_2001_0005()
		{
			return this.m__0002;
		}

		object _000F_2008_200B._000F_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0005_2001_2004_2001_0005();
		}

		[DebuggerHidden]
		private global::_0008_2008_200B<int> _0005_2001_2004_2001_0005()
		{
			_0005 obj;
			if (m__0005 == -2 && _000F == Thread.CurrentThread.ManagedThreadId)
			{
				m__0005 = 0;
				obj = this;
			}
			else
			{
				obj = new _0005(0);
			}
			obj._0006 = _0008;
			return obj;
		}

		global::_0008_2008_200B<int> global::_0002_2008_200B<int>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0005_2001_2004_2001_0005();
		}

		[DebuggerHidden]
		private _000F_2008_200B _0005_2001_2004_2001_0005()
		{
			return _0005_2001_2004_2001_0005();
		}

		_000F_2008_200B _0005_2008_200B._0005_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0005_2001_2004_2001_0005();
		}
	}

	internal sealed class _000F : global::_0002_2008_200B<int>, _0005_2008_200B, global::_0008_2008_200B<int>, _0006_2008_200B, _000F_2008_200B
	{
		private int _0005;

		private int m__0002;

		private int m__000F;

		private int _0006;

		public int _0008;

		private int _0003;

		private global::_0008_2008_200B<int> _000E;

		[DebuggerHidden]
		public _000F(int _0005)
		{
			this._0005 = _0005;
			m__000F = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		private void _000F_2001_2004_2001_0005()
		{
			int num = _0005;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_0002();
				}
			}
			_000E = null;
			_0005 = -2;
		}

		void _0006_2008_200B._0006_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._000F_2001_2004_2001_0005();
		}

		private bool _000F_2008_200B_2001_2004_2001_0005()
		{
			bool result;
			try
			{
				switch (_0005)
				{
				default:
					result = false;
					goto end_IL_0000;
				case 0:
				{
					_0005 = -1;
					_0003 = 7;
					int num = _0006;
					_000E = ((global::_0002_2008_200B<int>)new _0005(-2)
					{
						_0008 = num
					}).GetEnumerator();
					_0005 = -3;
					break;
				}
				case 1:
					_0005 = -3;
					if (_0003 != 0)
					{
						break;
					}
					result = false;
					_0002();
					goto end_IL_0000;
				}
				if (((_000F_2008_200B)_000E)._000F_2008_200B_2001_2004_2001_0005())
				{
					int num2 = _000E._000F_2008_200B_2001_2004_2001_0005() ^ _0006;
					if ((num2 & 3) == 0)
					{
						num2 ^= 0x778BF18C;
					}
					int num3 = _0003 - 1;
					_0003 = num3;
					if ((num2 & 0xF) == 0)
					{
						num2 ^= -1189707964;
					}
					this.m__0002 = num2;
					_0005 = 1;
					result = true;
				}
				else
				{
					_0002();
					_000E = null;
					result = false;
				}
				end_IL_0000:;
			}
			catch
			{
				//try-fault
				_000F_2001_2004_2001_0005();
				throw;
			}
			return result;
		}

		bool _000F_2008_200B._000F_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in  ​   
			return this._000F_2008_200B_2001_2004_2001_0005();
		}

		private void _0002()
		{
			_0005 = -1;
			if (_000E != null)
			{
				_000E._0006_2008_200B_2001_2004_2001_0005();
			}
		}

		[DebuggerHidden]
		private int _000F_2001_2004_2001_0005()
		{
			return this.m__0002;
		}

		int global::_0008_2008_200B<int>._000F_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._000F_2001_2004_2001_0005();
		}

		[DebuggerHidden]
		private void _000F_2001_2004_2001_000F()
		{
			throw new NotSupportedException();
		}

		void _000F_2008_200B._000F_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._000F_2001_2004_2001_000F();
		}

		[DebuggerHidden]
		private object _000F_2001_2004_2001_0005()
		{
			return this.m__0002;
		}

		object _000F_2008_200B._000F_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._000F_2001_2004_2001_0005();
		}

		[DebuggerHidden]
		private global::_0008_2008_200B<int> _000F_2001_2004_2001_0005()
		{
			_000F obj;
			if (_0005 == -2 && m__000F == Thread.CurrentThread.ManagedThreadId)
			{
				_0005 = 0;
				obj = this;
			}
			else
			{
				obj = new _000F(0);
			}
			obj._0006 = _0008;
			return obj;
		}

		global::_0008_2008_200B<int> global::_0002_2008_200B<int>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._000F_2001_2004_2001_0005();
		}

		[DebuggerHidden]
		private _000F_2008_200B _000F_2001_2004_2001_0005()
		{
			return _000F_2001_2004_2001_0005();
		}

		_000F_2008_200B _0005_2008_200B._0005_2008_200B_2001_2004_2001_0005()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._000F_2001_2004_2001_0005();
		}
	}
}
internal sealed class _0003_2009_200B
{
	private int m__0005;

	private string m__0002;

	private byte m__000F;

	private int _0006;

	private _0005_2005[] _0008;

	private _0008_2004[] _0003;

	public _0008_2004[] _0005()
	{
		return _0003;
	}

	public void _0005(_0008_2004[] _0005)
	{
		_0003 = _0005;
	}

	public _0005_2005[] _0005()
	{
		return _0008;
	}

	public void _0005(_0005_2005[] _0005)
	{
		_0008 = _0005;
	}

	public string _0005()
	{
		return this.m__0002;
	}

	public void _0005(string _0005)
	{
		this.m__0002 = _0005;
	}

	public int _0005()
	{
		return _0006;
	}

	public void _0005(int _0005)
	{
		_0006 = _0005;
	}

	public int _0002()
	{
		return this.m__0005;
	}

	public void _0002(int _0005)
	{
		this.m__0005 = _0005;
	}

	public byte _0005()
	{
		return this.m__000F;
	}

	public void _0005(byte _0005)
	{
		this.m__000F = _0005;
	}

	public bool _0005()
	{
		return (this._0005() & 2) != 0;
	}

	public bool _0002()
	{
		return (this._0005() & 1) != 0;
	}

	public bool _000F()
	{
		return (this._0005() & 4) != 0;
	}
}
internal static class _0003_200B_200B
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 128)]
	private struct a1
	{
	}

	private static _0002_2007 _000E_200B_200B;

	[ThreadStatic]
	private static Stream _0005_2002_200B;

	internal static a1 a1/* Not supported: data(C4 94 36 B1 4F 60 6C F5 A1 6B DC 4C 4E 05 DA 08 96 6C C9 74 BA 20 92 3C E7 21 95 1F 1A 0E FD 7F 84 B1 04 21 41 95 70 E9 50 0C 11 C9 73 C9 81 A1 E4 B6 8E CD E4 70 C5 7A 77 F8 6B 0F 20 B1 9A D6 CA 9E 1B 21 C3 23 10 09 30 F2 F8 FE BC 82 01 F0 F7 9E E5 D3 6A A4 C4 9C 2A BE 26 35 1C 13 E8 2B AD D7 7E E2 C4 4A 1B 78 E8 71 36 0F 33 1E 65 34 B2 F9 07 E8 62 58 7A 68 16 9F 0B 87 3E 9F E2 90) */;

	public static string _0005()
	{
		return _000F_0019._0005(-1057759797);
	}

	public static Stream _0002_2002_200B()
	{
		if (_0005_2002_200B == null)
		{
			_0005_2002_200B = _0006_2002._0005(typeof(_0003_200B_200B).Assembly.GetManifestResourceStream("52d4096ed71943946c2952c9f0ac7e7f"), new byte[128]
			{
				196, 148, 54, 177, 79, 96, 108, 245, 161, 107,
				220, 76, 78, 5, 218, 8, 150, 108, 201, 116,
				186, 32, 146, 60, 231, 33, 149, 31, 26, 14,
				253, 127, 132, 177, 4, 33, 65, 149, 112, 233,
				80, 12, 17, 201, 115, 201, 129, 161, 228, 182,
				142, 205, 228, 112, 197, 122, 119, 248, 107, 15,
				32, 177, 154, 214, 202, 158, 27, 33, 195, 35,
				16, 9, 48, 242, 248, 254, 188, 130, 1, 240,
				247, 158, 229, 211, 106, 164, 196, 156, 42, 190,
				38, 53, 28, 19, 232, 43, 173, 215, 126, 226,
				196, 74, 27, 120, 232, 113, 54, 15, 51, 30,
				101, 52, 178, 249, 7, 232, 98, 88, 122, 104,
				22, 159, 11, 135, 62, 159, 226, 144
			}, _0005());
		}
		return _0005_2002_200B;
	}

	internal static void _000F_2002_200B(_000F_2001 P_0)
	{
		object[] array = new object[1] { P_0 };
		_0006_2002_200B()._0005(_0002_2002_200B(), "i7?H.e'cXk", array);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static _000F_2001 _0006_2002_200B()
	{
		bool flag = default;
		if (_000E_200B_200B == null)
		{
			_000E_200B_200B = new _0002_2007();
			flag = true;
		}
		_000F_2001 obj = new _000F_2001(_000E_200B_200B);
		if (flag)
		{
			_000F_2002_200B(obj);
		}
		return obj;
	}
}
internal static class _0005_2001_200B
{
	public unsafe static List<int> _0005(this byte[] _0005, byte[] _0002)
	{
		List<int> list = new List<int>();
		fixed (byte* ptr = _0005)
		{
			fixed (byte* ptr2 = _0002)
			{
				int num = 0;
				byte* ptr3 = ptr;
				for (byte* ptr4 = ptr + _0005.LongLength; ptr3 < ptr4; ptr3++)
				{
					bool flag = true;
					byte* ptr5 = ptr3;
					byte* ptr6 = ptr2;
					byte* ptr7 = ptr2 + _0002.Length;
					while (flag && ptr6 < ptr7)
					{
						flag = *ptr6 == *ptr5;
						ptr6++;
						ptr5++;
					}
					if (flag)
					{
						list.Add(num);
					}
					num++;
				}
				return list;
			}
		}
	}
}
internal interface _0005_2008_200B
{
	_000F_2008_200B _0005_2008_200B_2001_2004_2001_0005();
}
internal sealed class _0005_2009_200B : IDisposable
{
	private _0008 m__0005;

	private byte[] m__0002;

	private Decoder m__000F;

	private byte[] m__0006;

	private char[] m__0008;

	private char[] _0003;

	private int _000E;

	private bool _0005_2009;

	private bool _0002_2009;

	private byte[] _000F_2009;

	private MemoryStream _0006_2009;

	private BinaryReader _0008_2009;

	public _0005_2009_200B(_0008 _0005)
		: this(_0005, new UTF8Encoding())
	{
	}

	private _0005_2009_200B(_0008 _0005, Encoding _0002)
	{
		if (_0005 == null)
		{
			throw new ArgumentNullException();
		}
		if (_0002 == null)
		{
			throw new ArgumentNullException();
		}
		if (!_0005._0008_2001_2004_2001_0005())
		{
			throw new ArgumentException();
		}
		this.m__0005 = _0005;
		this.m__000F = _0002.GetDecoder();
		_000E = _0002.GetMaxCharCount(128);
		int num = _0002.GetMaxByteCount(1);
		if (num < 16)
		{
			num = 16;
		}
		this.m__0002 = new byte[num];
		_0003 = null;
		this.m__0006 = null;
		_0005_2009 = _0002 is UnicodeEncoding;
		_0002_2009 = this.m__0005 is _0003;
	}

	public _0008 _0005()
	{
		return this.m__0005;
	}

	public void _0005()
	{
		_0005(_0005: true);
	}

	private void _0005(bool _0005)
	{
		if (_0005)
		{
			_0008 obj = this.m__0005;
			this.m__0005 = null;
			obj?._0008_2001_2004_2001_0005();
		}
		this.m__0005 = null;
		this.m__0002 = null;
		this.m__000F = null;
		this.m__0006 = null;
		this.m__0008 = null;
		_0003 = null;
	}

	private void _0005_2009_200B_2001_2004_2001_0002()
	{
		_0005(_0005: true);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in  ​   
		this._0005_2009_200B_2001_2004_2001_0002();
	}

	public int _0005()
	{
		_000F();
		if (!this.m__0005._0008_2001_2004_2001_000F())
		{
			return -1;
		}
		long num = this.m__0005._0008_2001_2004_2001_0002();
		int result = _0002();
		this.m__0005._0008_2001_2004_2001_0005(num);
		return result;
	}

	public int _0002()
	{
		_000F();
		return _000F();
	}

	public bool _0005()
	{
		_0005(1);
		return this.m__0002[0] != 0;
	}

	public byte _0005()
	{
		_000F();
		int num = this.m__0005._0008_2001_2004_2001_0005();
		if (num == -1)
		{
			throw new Exception();
		}
		return (byte)num;
	}

	public sbyte _0005()
	{
		_0005(1);
		return (sbyte)this.m__0002[0];
	}

	public char _0005()
	{
		int num = _0002();
		if (num == -1)
		{
			throw new Exception();
		}
		return (char)num;
	}

	private static decimal _0005(int _0005, int _0002, int _000F, int _0006)
	{
		bool isNegative = (_0006 & int.MinValue) != 0;
		byte scale = (byte)(_0006 >> 16);
		return new decimal(_0005, _0002, _000F, isNegative, scale);
	}

	internal static decimal _0005(byte[] _0005)
	{
		int num = _0005[0] | (_0005[1] << 8) | (_0005[2] << 16) | (_0005[3] << 24);
		int num2 = _0005[4] | (_0005[5] << 8) | (_0005[6] << 16) | (_0005[7] << 24);
		int num3 = _0005[8] | (_0005[9] << 8) | (_0005[10] << 16) | (_0005[11] << 24);
		int num4 = _0005[12] | (_0005[13] << 8) | (_0005[14] << 16) | (_0005[15] << 24);
		return _0005_2009_200B._0005(num, num2, num3, num4);
	}

	public string _0005()
	{
		int num = 0;
		_000F();
		int num2 = _0006();
		if (num2 < 0)
		{
			throw new IOException();
		}
		if (num2 == 0)
		{
			return string.Empty;
		}
		if (this.m__0006 == null)
		{
			this.m__0006 = new byte[128];
		}
		if (_0003 == null)
		{
			_0003 = new char[_000E];
		}
		StringBuilder stringBuilder = null;
		do
		{
			int num3 = ((num2 - num > 128) ? 128 : (num2 - num));
			int num4 = this.m__0005._0008_2001_2004_2001_0005(this.m__0006, 0, num3);
			if (num4 == 0)
			{
				throw new Exception();
			}
			int chars = this.m__000F.GetChars(this.m__0006, 0, num4, _0003, 0);
			if (num == 0 && num4 == num2)
			{
				return new string(_0003, 0, chars);
			}
			if (stringBuilder == null)
			{
				stringBuilder = new StringBuilder(num2);
			}
			stringBuilder.Append(_0003, 0, chars);
			num += num4;
		}
		while (num < num2);
		return stringBuilder.ToString();
	}

	public int _0005(char[] _0005, int _0002, int _000F)
	{
		if (_0005 == null)
		{
			throw new ArgumentNullException(_000F_0019._0005(-1057760155), _000F_0019._0005(-1057760152));
		}
		if (_0002 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_000F < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0005.Length - _0002 < _000F)
		{
			throw new ArgumentException();
		}
		this._000F();
		return this._0002(_0005, _0002, _000F);
	}

	private int _0002(char[] _0005, int _0002, int _000F)
	{
		int num = 0;
		int num2 = 0;
		int num3 = _000F;
		if (this.m__0006 == null)
		{
			this.m__0006 = new byte[128];
		}
		while (num3 > 0)
		{
			num2 = num3;
			if (_0005_2009)
			{
				num2 <<= 1;
			}
			if (num2 > 128)
			{
				num2 = 128;
			}
			if (_0002_2009)
			{
				_0003 obj = (_0003)this.m__0005;
				int byteIndex = obj._0005();
				num2 = obj._0005(num2);
				if (num2 == 0)
				{
					return _000F - num3;
				}
				num = this.m__000F.GetChars(obj._0005(), byteIndex, num2, _0005, _0002);
			}
			else
			{
				num2 = this.m__0005._0008_2001_2004_2001_0005(this.m__0006, 0, num2);
				if (num2 == 0)
				{
					return _000F - num3;
				}
				num = this.m__000F.GetChars(this.m__0006, 0, num2, _0005, _0002);
			}
			num3 -= num;
			_0002 += num;
		}
		return _000F;
	}

	private int _000F()
	{
		int num = 0;
		int num2 = 0;
		long num3 = (num3 = 0L);
		if (this.m__0005._0008_2001_2004_2001_000F())
		{
			num3 = this.m__0005._0008_2001_2004_2001_0002();
		}
		if (this.m__0006 == null)
		{
			this.m__0006 = new byte[128];
		}
		if (this.m__0008 == null)
		{
			this.m__0008 = new char[1];
		}
		while (num == 0)
		{
			num2 = ((!_0005_2009) ? 1 : 2);
			int num4 = this.m__0005._0008_2001_2004_2001_0005();
			this.m__0006[0] = (byte)num4;
			if (num4 == -1)
			{
				num2 = 0;
			}
			if (num2 == 2)
			{
				num4 = this.m__0005._0008_2001_2004_2001_0005();
				this.m__0006[1] = (byte)num4;
				if (num4 == -1)
				{
					num2 = 1;
				}
			}
			if (num2 == 0)
			{
				return -1;
			}
			try
			{
				num = this.m__000F.GetChars(this.m__0006, 0, num2, this.m__0008, 0);
			}
			catch
			{
				if (this.m__0005._0008_2001_2004_2001_000F())
				{
					this.m__0005._0008_2001_2004_2001_0005(num3 - this.m__0005._0008_2001_2004_2001_0002(), 1);
				}
				throw;
			}
		}
		if (num == 0)
		{
			return -1;
		}
		return this.m__0008[0];
	}

	public char[] _0005(int _0005)
	{
		_000F();
		if (_0005 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		char[] array = new char[_0005];
		int num = _0002(array, 0, _0005);
		if (num != _0005)
		{
			char[] array2 = new char[num];
			Buffer.BlockCopy(array, 0, array2, 0, 2 * num);
			array = array2;
		}
		return array;
	}

	public int _0005(byte[] _0005, int _0002, int _000F)
	{
		if (_0005 == null)
		{
			throw new ArgumentNullException();
		}
		if (_0002 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_000F < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0005.Length - _0002 < _000F)
		{
			throw new ArgumentException();
		}
		this._000F();
		return this.m__0005._0008_2001_2004_2001_0005(_0005, _0002, _000F);
	}

	private void _000F()
	{
		if (this.m__0005 == null)
		{
			throw new Exception();
		}
	}

	public byte[] _0005(int _0005)
	{
		if (_0005 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		_000F();
		byte[] array = new byte[_0005];
		int num = 0;
		do
		{
			int num2 = this.m__0005._0008_2001_2004_2001_0005(array, num, _0005);
			if (num2 == 0)
			{
				break;
			}
			num += num2;
			_0005 -= num2;
		}
		while (_0005 > 0);
		if (num != array.Length)
		{
			byte[] array2 = new byte[num];
			Buffer.BlockCopy(array, 0, array2, 0, num);
			array = array2;
		}
		return array;
	}

	private void _0005(int _0005)
	{
		_000F();
		int num = 0;
		int num2 = 0;
		if (_0005 == 1)
		{
			num2 = this.m__0005._0008_2001_2004_2001_0005();
			if (num2 == -1)
			{
				throw new Exception();
			}
			this.m__0002[0] = (byte)num2;
			return;
		}
		do
		{
			num2 = this.m__0005._0008_2001_2004_2001_0005(this.m__0002, num, _0005 - num);
			if (num2 == 0)
			{
				throw new Exception();
			}
			num += num2;
		}
		while (num < _0005);
	}

	internal int _0006()
	{
		int num = 0;
		int num2 = 0;
		byte b;
		do
		{
			if (num2 == 35)
			{
				throw new FormatException();
			}
			b = this._0005();
			num |= (b & 0x7F) << num2;
			num2 += 7;
		}
		while ((b & 0x80) != 0);
		return num;
	}

	public int _0008()
	{
		if (_0002_2009)
		{
			return ((_0003)this.m__0005)._000F();
		}
		_0005(4);
		return this.m__0002[0] | (this.m__0002[3] << 24) | (this.m__0002[1] << 16) | (this.m__0002[2] << 8);
	}

	public uint _0005()
	{
		_0005(4);
		return (uint)((this.m__0002[3] << 16) | this.m__0002[1] | (this.m__0002[0] << 8) | (this.m__0002[2] << 24));
	}

	public long _0005()
	{
		_0005(8);
		byte[] array = this.m__0002;
		return (uint)((array[7] << 8) | (array[2] << 24) | array[0] | (array[1] << 16)) | ((long)((array[5] << 24) | (array[6] << 16) | array[4] | (array[3] << 8)) << 32);
	}

	public ulong _0005()
	{
		_0005(8);
		byte[] array = this.m__0002;
		return (ulong)((uint)((array[2] << 16) | (array[5] << 24) | (array[4] << 8) | array[6]) | ((long)((array[1] << 16) | array[0] | (array[7] << 24) | (array[3] << 8)) << 32));
	}

	public short _0005()
	{
		_0005(2);
		byte[] array = this.m__0002;
		return (short)((array[0] << 8) | array[1]);
	}

	public ushort _0005()
	{
		_0005(2);
		byte[] array = this.m__0002;
		return (ushort)(array[1] | (array[0] << 8));
	}

	private byte[] _0005()
	{
		byte[] array = _000F_2009;
		if (array == null)
		{
			array = (_000F_2009 = new byte[16]);
		}
		return array;
	}

	public float _0005()
	{
		_0005(4);
		byte[] array = this.m__0002;
		byte[] array2 = _0005();
		array2[1] = array[1];
		array2[3] = array[0];
		array2[2] = array[2];
		array2[0] = array[3];
		return _0005(array2).ReadSingle();
	}

	public double _0005()
	{
		_0005(8);
		byte[] array = this.m__0002;
		byte[] array2 = _0005();
		array2[5] = array[1];
		array2[2] = array[4];
		array2[0] = array[2];
		array2[3] = array[3];
		array2[7] = array[0];
		array2[4] = array[6];
		array2[1] = array[5];
		array2[6] = array[7];
		return _0005(array2).ReadDouble();
	}

	public decimal _0005()
	{
		_0005(16);
		byte[] array = this.m__0002;
		byte[] array2 = _0005();
		array2[14] = array[11];
		array2[5] = array[12];
		array2[7] = array[9];
		array2[6] = array[1];
		array2[10] = array[8];
		array2[11] = array[10];
		array2[8] = array[3];
		array2[0] = array[14];
		array2[4] = array[15];
		array2[3] = array[13];
		array2[1] = array[2];
		array2[2] = array[6];
		array2[15] = array[7];
		array2[9] = array[4];
		array2[12] = array[0];
		array2[13] = array[5];
		return _0005_2009_200B._0005(array2);
	}

	private BinaryReader _0005(byte[] _0005)
	{
		MemoryStream memoryStream = _0006_2009;
		BinaryReader binaryReader = _0008_2009;
		if (memoryStream == null)
		{
			memoryStream = (_0006_2009 = new MemoryStream(8));
			binaryReader = (_0008_2009 = new BinaryReader(memoryStream));
		}
		else
		{
			binaryReader.BaseStream.Position = 0L;
		}
		memoryStream.Write(_0005, 0, _0005.Length);
		memoryStream.Position = 0L;
		return binaryReader;
	}
}
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
[_000F_2005]
internal sealed class _0005_200A_200B : Attribute
{
	public readonly byte[] _0005;

	public _0005_200A_200B(byte _0005)
	{
		this._0005 = new byte[1] { _0005 };
	}

	public _0005_200A_200B(byte[] _0005)
	{
		this._0005 = _0005;
	}
}
internal static class _0005_200B_200B
{
	private sealed class _0005
	{
		private readonly string m__0005;

		private volatile Assembly _0002;

		internal _0005(string _0005)
		{
			this.m__0005 = _0005;
		}

		internal Assembly _0005()
		{
			if ((object)_0002 == null)
			{
				lock (this)
				{
					if ((object)_0002 == null)
					{
						_0002 = _0005(this.m__0005);
					}
				}
			}
			return _0002;
		}

		private static Assembly _0005(string _0005)
		{
			return _000F_200B_200B._0005(_0005) ?? Assembly.Load(_0005);
		}
	}

	private static readonly Assembly m__0005;

	private static volatile Dictionary<string, _0005> m__0002;

	[ThreadStatic]
	private static bool _000F;

	static _0005_200B_200B()
	{
		_0005_200B_200B.m__0005 = typeof(_0005_200B_200B).Assembly;
	}

	internal static void _0005()
	{
		AppDomain.CurrentDomain.ResourceResolve += _0005;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Assembly _0005(object _0005, ResolveEventArgs _0002)
	{
		if ((object)_0002.RequestingAssembly != _0005_200B_200B.m__0005)
		{
			return null;
		}
		if (_000F)
		{
			return null;
		}
		return _0005_200B_200B._0005(_0002.Name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Assembly _0005(string _0005)
	{
		_000F = true;
		try
		{
			_0002();
			if (!_0005_200B_200B.m__0002.TryGetValue(_0005, out var value))
			{
				return null;
			}
			return value._0005();
		}
		finally
		{
			_000F = false;
		}
	}

	private static void _0002()
	{
		if (_0005_200B_200B.m__0002 != null)
		{
			return;
		}
		lock (_0005_200B_200B.m__0005)
		{
			if (_0005_200B_200B.m__0002 != null)
			{
				return;
			}
			string text = _000F_0019._0005(-1057752245);
			string[] array = text.Split(':');
			int num = array.Length;
			Dictionary<string, _0005> dictionary = new Dictionary<string, _0005>(2, StringComparer.Ordinal);
			for (int i = 0; i != num; i++)
			{
				string text2 = array[i];
				string[] array2 = text2.Split('|');
				_0005 value = new _0005(array2[0]);
				int num2 = array2.Length;
				for (int j = 1; j != num2; j++)
				{
					string key = array2[j];
					dictionary.Add(key, value);
				}
			}
			_0005_200B_200B.m__0002 = dictionary;
		}
	}
}
internal sealed class _0006_2001_200B
{
	private readonly string m__0005;

	private readonly string m__0002;

	private readonly string m__000F;

	internal static readonly _0006_2001_200B _0006;

	internal _0006_2001_200B()
	{
	}

	internal _0006_2001_200B(string _0005, string _0002, string _000F)
	{
		_002Ector_2(_0005, _0002, _000F);
	}

	static _0006_2001_200B()
	{
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "$J*bWe'cV[", (object[])null);
	}

	internal bool _0005()
	{
		return this == _0006;
	}

	internal bool _0002()
	{
		return string.IsNullOrEmpty(this._0002());
	}

	internal string _0005()
	{
		return this.m__0005;
	}

	internal string _0002()
	{
		return this.m__0002;
	}

	internal string _000F()
	{
		return this.m__000F;
	}

	private void _002Ector_2(string P_0, string P_1, string P_2)
	{
		object[] array = new object[4] { this, P_0, P_1, P_2 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "M:U5,e'cV[", array);
	}
}
internal interface _0006_2008_200B
{
	void _0006_2008_200B_2001_2004_2001_0005();
}
internal sealed class _0006_2009_200B : _000F
{
	private new MethodBase m__0005;

	public _0006_2009_200B()
		: base(21)
	{
	}

	public new MethodBase _0005()
	{
		return this.m__0005;
	}

	public void _0005(MethodBase _0005)
	{
		this.m__0005 = _0005;
	}

	public new IntPtr _0005()
	{
		return this._0005().MethodHandle.GetFunctionPointer();
	}

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		return this._0005();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		this._0005((MethodBase)_0005);
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		if (_0005._0005() == 21)
		{
			this._0005(((_0006_2009_200B)_0005)._0005());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0006_2009_200B obj = new _0006_2009_200B();
		obj._0005(this.m__0005);
		obj._0005(base._0005());
		return obj;
	}
}
internal static class _0006_200B_200B
{
}
internal sealed class _0008_2001_200B
{
	private readonly int m__0005;

	private readonly long m__0002;

	private readonly long _000F;

	private readonly DateTime _0006;

	private readonly DateTime _0008;

	internal _0008_2001_200B()
	{
	}

	internal _0008_2001_200B(int _0005, long _0002, long _000F, DateTime _0006)
	{
		int num = default;
		long num2 = default;
		long num3 = default;
		DateTime dateTime = default;
		DateTime dateTime2 = default;
		_002Ector_1(ref num, ref num2, ref num3, ref dateTime, ref dateTime2, _0005, _0002, _000F, _0006);
		this._002Ector(num, num2, num3, dateTime, dateTime2);
	}

	internal _0008_2001_200B(int _0005, long _0002, long _000F, DateTime _0006, DateTime _0008)
	{
		_002Ector_2(_0005, _0002, _000F, _0006, _0008);
	}

	internal bool _0005()
	{
		return this._0005() == 0;
	}

	internal int _0005()
	{
		return this.m__0005;
	}

	internal long _0005()
	{
		return this.m__0002;
	}

	internal long _0002()
	{
		return _000F;
	}

	internal DateTime _0005()
	{
		return _0006;
	}

	internal DateTime _0002()
	{
		return _0008;
	}

	internal bool _0005(long[] _0005)
	{
		object[] array = new object[2] { this, _0005 };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "1=k\"*e'cW<", array);
	}

	internal bool _0005(int _0005)
	{
		object[] array = new object[2] { this, _0005 };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "`7EJge'cW>", array);
	}

	private void _002Ector_2(int P_0, long P_1, long P_2, DateTime P_3, DateTime P_4)
	{
		object[] array = new object[6] { this, P_0, P_1, P_2, P_3, P_4 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), ":=dtFe'cW;", array);
	}

	private static void _002Ector_1(ref int P_0, ref long P_1, ref long P_2, ref DateTime P_3, ref DateTime P_4, int P_5, long P_6, long P_7, DateTime P_8)
	{
		object[] array = new object[9] { P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7, P_8 };
		_000F_2001 obj = _0003_200B_200B._0006_2002_200B();
		Stream stream = _0003_200B_200B._0002_2002_200B();
		try
		{
			obj._0005(stream, "T@VQBe'cV]", array);
		}
		finally
		{
			P_0 = (int)array[0];
			P_1 = (long)array[1];
			P_2 = (long)array[2];
			P_3 = (DateTime)array[3];
			P_4 = (DateTime)array[4];
		}
	}
}
internal interface _0008_2008_200B<_0005> : _000F_2008_200B, _0006_2008_200B
{
	[SpecialName]
	new _0005 _000F_2008_200B_2001_2004_2001_0005();
}
internal sealed class _0008_2009_200B : Stream
{
	private int m__0005;

	private int m__0002;

	private int m__000F;

	private Stream m__0006;

	private _0005_200A _0008;

	private int _0003;

	private bool _000E;

	private bool _0005_2009;

	private bool _0002_2009;

	private byte[] _000F_2009;

	private int _0006_2009;

	private byte[] _0008_2009;

	private int _0003_2009;

	private int _000E_2009;

	private int _0005_200A;

	private bool _0002_200A;

	public override bool CanRead => true;

	public override bool CanSeek => true;

	public override bool CanWrite => false;

	public override long Length
	{
		get
		{
			_0006();
			return this.m__0005;
		}
	}

	public override long Position
	{
		get
		{
			return _0003 * _0005_200A + _000E_2009;
		}
		set
		{
			int num = (int)value / _0005_200A;
			_000E_2009 = (int)value % _0005_200A;
			if (_0003 != num)
			{
				_0003 = num;
				_0002_2009 = true;
				_000E = false;
			}
		}
	}

	public _0008_2009_200B(Stream _0005, _0005_200A _0002)
	{
		if (_0005 == null)
		{
			throw new ArgumentNullException(_000F_0019._0005(-1057761793));
		}
		if (_0002 == null)
		{
			throw new ArgumentNullException(_000F_0019._0005(-1057759346));
		}
		this.m__0006 = _0005;
		_0008 = _0002;
		if (this.m__0006.Length < 4)
		{
			throw new InvalidOperationException();
		}
		this._0005();
	}

	private void _0005()
	{
		_0006_2009 = _0008._0005_200A_2001_2004_2001_0005();
		_000F_2009 = new byte[_0006_2009];
		_0005_200A = _0008._0005_200A_2001_2004_2001_0002();
		_0008_2009 = new byte[_0005_200A];
	}

	public override long Seek(long _0005, SeekOrigin _0002)
	{
		switch (_0002)
		{
		case SeekOrigin.Begin:
			Position = _0005;
			break;
		case SeekOrigin.Current:
			Position += _0005;
			break;
		case SeekOrigin.End:
			Position = Length + _0005;
			break;
		}
		return Position;
	}

	public override void SetLength(long _0005)
	{
		throw new NotSupportedException();
	}

	public override int Read(byte[] _0005, int _0002, int _000F)
	{
		if (_0002 < 0)
		{
			throw new ArgumentOutOfRangeException(_000F_0019._0005(-1057759298));
		}
		if (_000F < 0)
		{
			throw new ArgumentOutOfRangeException(_000F_0019._0005(-1057759323));
		}
		if (_0005.Length - _0002 < _000F)
		{
			throw new ArgumentException();
		}
		if (_000F == 0)
		{
			return 0;
		}
		int num = _000F;
		int num2 = _0002;
		if (_000E_2009 < _0005_200A)
		{
			this._0002();
			int num3 = _0003_2009 - _000E_2009;
			if (num3 > _000F)
			{
				Buffer.BlockCopy(_0008_2009, _000E_2009, _0005, _0002, _000F);
				_000E_2009 += _000F;
				return _000F;
			}
			Buffer.BlockCopy(_0008_2009, _000E_2009, _0005, _0002, num3);
			_000E_2009 = _0003_2009;
			if (_0005_2009)
			{
				return num3;
			}
			num -= num3;
			num2 += num3;
		}
		if (_0005_2009)
		{
			return _000F - num;
		}
		while (num > 0)
		{
			this._000F();
			if (_0005_2009)
			{
				return _000F - num;
			}
			int num4 = _0003_2009;
			if (num >= num4)
			{
				Buffer.BlockCopy(_0008_2009, 0, _0005, num2, num4);
				num2 += num4;
				num -= num4;
				_000E_2009 = num4;
				continue;
			}
			Buffer.BlockCopy(_0008_2009, 0, _0005, num2, num);
			_000E_2009 = num;
			return _000F;
		}
		return _000F;
	}

	private void _0002()
	{
		_0006();
		if (!_000E)
		{
			_000E = true;
			_0005_2009 = false;
			int num = _0003;
			if (_0002_2009)
			{
				this.m__0006.Position = 4 + num * _0006_2009;
				_0002_2009 = false;
			}
			_0005(num);
		}
	}

	private void _000F()
	{
		int num = _0003 + 1;
		if (_0005(num))
		{
			_0003 = num;
			_000E_2009 = 0;
		}
		_000E = true;
	}

	private bool _0005(int _0005)
	{
		int num;
		for (int i = 0; i < _0006_2009; i += num)
		{
			num = this.m__0006.Read(_000F_2009, i, _0006_2009 - i);
			if (num == 0)
			{
				if (i != 0)
				{
					throw new InvalidOperationException();
				}
				_0005_2009 = true;
				return false;
			}
		}
		_0003_2009 = _0008._0005_200A_2001_2004_2001_0005(_000F_2009, 0, _0006_2009, _0008_2009, 0, null);
		if (_0005 == this.m__0002)
		{
			_0003_2009 = this.m__000F;
		}
		return true;
	}

	private void _0006()
	{
		if (!_0002_200A)
		{
			if (this.m__0006.Position != 0L)
			{
				this.m__0006.Position = 0L;
				_0002_2009 = true;
			}
			this.m__0005 = _0005(this.m__0006)._0005;
			this.m__0002 = this.m__0005 / _0005_200A;
			this.m__000F = this.m__0005 % _0005_200A;
			_0002_200A = true;
		}
	}

	private static _0006_200A _0005(Stream _0005)
	{
		_000F_2003 obj = new _000F_2003(_0005, 0);
		try
		{
			_0005_2009_200B obj2 = new _0005_2009_200B(obj);
			try
			{
				return new _0006_200A(obj2._0008());
			}
			finally
			{
				((IDisposable)obj2).Dispose();
			}
		}
		finally
		{
			((IDisposable)obj).Dispose();
		}
	}

	public override void Flush()
	{
	}

	public override void Write(byte[] _0005, int _0002, int _000F)
	{
		throw new NotSupportedException();
	}
}
[AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
[_000F_200A_200B]
internal sealed class _0008_200A_200B : Attribute
{
	public readonly int _0005;

	public _0008_200A_200B(int _0005)
	{
		this._0005 = _0005;
	}
}
internal static class _0008_200B_200B
{
	private static class _0002
	{
		internal static int _0005(int _0005, int _0002)
		{
			return _0005 ^ (_0002 - -(~(~(-(~(-(-(~(-(~(~1497622948)))))))))));
		}

		internal static int _0002(int _0005, int _0002)
		{
			return (_0005 - -(~(-(~(-(~(~(-(~-507364716))))))))) ^ (_0002 + -(~(-(~(~(-(~(-(-(~(~-1791426221)))))))))));
		}

		internal static int _000F(int _0005, int _0002)
		{
			return _0005 ^ ((_0002 - -(~(~(-(-(~(-(~(-(~(~-639773407))))))))))) ^ (_0005 - _0002));
		}
	}

	private sealed class _0003
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0005()
		{
			return _0008_200B_200B._0002._000F(_0008_200B_200B._0005(typeof(_0003)), _0008_200B_200B._0002._0005(_0008_200B_200B._0005(typeof(_000F)), _0008_200B_200B._0002._0002(_0008_200B_200B._0005(typeof(_0008)), _0008_200B_200B._0002._000F(_0008_200B_200B._0005(typeof(_0006)), _0008_200B_200B._0002._0005(_0008_200B_200B._0005(typeof(_000E)), _0008_200B_200B._0005(typeof(_0005_2009)))))));
		}
	}

	private sealed class _0005
	{
		private int m__0005;

		private int _0002;

		internal _0005()
		{
			_0005(0L);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long _0005()
		{
			if ((object)Assembly.GetCallingAssembly() != typeof(_0005).Assembly)
			{
				return 2918384L;
			}
			if (!_0008_200B_200B._0005())
			{
				return 2918384L;
			}
			int[] array = new int[4];
			array[3] = ~(-(-(~(~(-(~(-(~1270263601))))))));
			array[1] = -(~(-(~(-(~(~(-(~-1059093957))))))));
			array[2] = -(~(-(~(~(-(-(~(~-1876560478))))))));
			array[0] = ~(-(-(~(~(-(~(-(~2076709148))))))));
			int num = this.m__0005;
			int num2 = _0002;
			int num3 = ~(-(-(~(~(-(-(~(~(-(~1640531525))))))))));
			int num4 = -(~(-(~(~(-(-(~(~(-(~957401312))))))))));
			for (int i = 0; i != 32; i++)
			{
				num2 -= (((num << 4) ^ (num >> 5)) + num) ^ (num4 + array[(num4 >> 11) & 3]);
				num4 -= num3;
				num -= (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[num4 & 3]);
			}
			for (int j = 0; j != 4; j++)
			{
				array[j] = 0;
			}
			ulong num5 = (ulong)((long)num2 << 32);
			return (long)(num5 | (uint)num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _0005(long _0005)
		{
			if ((object)Assembly.GetCallingAssembly() == typeof(_0005).Assembly && _0008_200B_200B._0005())
			{
				int[] array = new int[4];
				array[1] = -(~(~(-(~(-(~(-(~(-(~-1059093962))))))))));
				array[0] = ~(-(~(-(-(~(~(-(~(-(~2076709147))))))))));
				array[2] = -(~(~(-(-(~(-(~(-(~(~-1876560477))))))))));
				array[3] = -(~(-(~(-(~(~(-(~1270263605))))))));
				int num = -(~(~(-(-(~(-(~(~1640531528))))))));
				int num2 = (int)_0005;
				int num3 = (int)(_0005 >> 32);
				int num4 = 0;
				for (int i = 0; i != 32; i++)
				{
					num2 += (((num3 << 4) ^ (num3 >> 5)) + num3) ^ (num4 + array[num4 & 3]);
					num4 += num;
					num3 += (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[(num4 >> 11) & 3]);
				}
				for (int j = 0; j != 4; j++)
				{
					array[j] = 0;
				}
				this.m__0005 = num2;
				_0002 = num3;
			}
		}
	}

	private sealed class _0005_2009
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0005()
		{
			return _0008_200B_200B._0002._0005(_0008_200B_200B._0005(typeof(_0005_2009)), _0008_200B_200B._0002._000F(_0008_200B_200B._0002._0002(_0008_200B_200B._0005(typeof(_000E)), _0008_200B_200B._0005(typeof(_000F))), _0008_200B_200B._0002._000F(_0008_200B_200B._0005(typeof(_0006)) ^ -(~(~(-(~(-(~(-(~1004796741)))))))), _000E._0005())));
		}
	}

	private sealed class _0006
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0005()
		{
			return _0008_200B_200B._0002._000F(_0008_200B_200B._0002._0005(_0008._0005() ^ -(~(~(-(~(-(~(-(~-527758449)))))))), _0008_200B_200B._0005(typeof(_0003))), _0008_200B_200B._0002._0002(_0008_200B_200B._0005(typeof(_000F)) ^ _0008_200B_200B._0005(typeof(_0005_2009)), -(~(~(-(~(-(~(-(-(~(~743405881))))))))))));
		}
	}

	private sealed class _0008
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0005()
		{
			return _0008_200B_200B._0002._0005(_0008_200B_200B._0005(typeof(_0006)), _0008_200B_200B._0005(typeof(_0003)) ^ _0008_200B_200B._0002._0002(_0008_200B_200B._0005(typeof(_0008)), _0008_200B_200B._0002._000F(_0008_200B_200B._0005(typeof(_0005_2009)), _0003._0005())));
		}
	}

	private sealed class _000E
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0005()
		{
			return _0008_200B_200B._0002._0002(_0008_200B_200B._0002._0002(_0006._0005(), _0008_200B_200B._0002._0005(_0008_200B_200B._0005(typeof(_000E)), _0008._0005())), _0008_200B_200B._0005(typeof(_0005_2009)));
		}
	}

	private sealed class _000F
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0005()
		{
			return _0008_200B_200B._0002._000F(_0008_200B_200B._0002._0002(_0008_200B_200B._0005(typeof(_0008)), _0008_200B_200B._0002._000F(_0008_200B_200B._0005(typeof(_000F)), _0008_200B_200B._0005(typeof(_000E)))), _0005_2009._0005());
		}
	}

	private static _0005 m__0005;

	static _0008_200B_200B()
	{
		_0008_200B_200B.m__0005 = new _0005();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long _0005()
	{
		if ((object)Assembly.GetCallingAssembly() != typeof(_0008_200B_200B).Assembly || !_0005())
		{
			return 0L;
		}
		lock (_0008_200B_200B.m__0005)
		{
			long num = _0008_200B_200B.m__0005._0005();
			if (num == 0)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				List<byte> list = new List<byte>();
				AssemblyName assemblyName;
				try
				{
					assemblyName = executingAssembly.GetName();
				}
				catch
				{
					assemblyName = new AssemblyName(executingAssembly.FullName);
				}
				byte[] array = assemblyName.GetPublicKeyToken();
				if (array != null && array.Length == 0)
				{
					array = null;
				}
				if (array != null)
				{
					list.AddRange(array);
				}
				list.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
				int num2 = _0005(typeof(_0008_200B_200B));
				int num3 = _000F._0005();
				list.Add((byte)(num2 >> 8));
				list.Add((byte)(num3 >> 16));
				list.Add((byte)num2);
				list.Add((byte)num3);
				list.Add((byte)(num2 >> 24));
				list.Add((byte)(num3 >> 8));
				list.Add((byte)(num2 >> 16));
				list.Add((byte)(num3 >> 24));
				int count = list.Count;
				ulong num4 = 0uL;
				for (int i = 0; i != count; i++)
				{
					num4 += list[i];
					num4 += num4 << 20;
					num4 ^= num4 >> 12;
					list[i] = 0;
				}
				num4 += num4 << 6;
				num4 ^= num4 >> 22;
				num4 += num4 << 30;
				num = (long)num4;
				num ^= -3399720065040431435L;
				_0008_200B_200B.m__0005._0005(num);
			}
			return num;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void _0005(byte[] _0005)
	{
		if ((object)Assembly.GetCallingAssembly() == typeof(_0008_200B_200B).Assembly && _0008_200B_200B._0005())
		{
			long num = _0008_200B_200B._0005();
			byte[] array = new byte[8]
			{
				(byte)num,
				(byte)(num >> 40),
				(byte)(num >> 56),
				(byte)(num >> 48),
				(byte)(num >> 32),
				(byte)(num >> 24),
				(byte)(num >> 16),
				(byte)(num >> 8)
			};
			int num2 = _0005.Length;
			for (int i = 0; i != num2; i++)
			{
				_0005[i] ^= (byte)(array[i & 7] + i);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0005()
	{
		if (!_0002())
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0002()
	{
		StackTrace stackTrace = new StackTrace();
		Type type = (stackTrace.GetFrame(3)?.GetMethod())?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			return false;
		}
		if ((object)type == null)
		{
			return false;
		}
		if ((object)type.Assembly != typeof(_0008_200B_200B).Assembly)
		{
			return false;
		}
		return true;
	}

	private static int _0005(Type _0005)
	{
		return _0005.MetadataToken;
	}
}
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal sealed class _000E_2001_200B
{
	private static ResourceManager m__0005;

	private static CultureInfo _0002;

	internal _000E_2001_200B()
	{
	}

	internal static ResourceManager _0005()
	{
		if (_000E_2001_200B.m__0005 == null)
		{
			_000E_2001_200B.m__0005 = new ResourceManager(_000F_0019._0005(-1057752271), typeof(_000E_2001_200B).Assembly);
		}
		return _000E_2001_200B.m__0005;
	}

	internal static CultureInfo _0005()
	{
		return _0002;
	}

	internal static void _0005(CultureInfo _0005)
	{
		_0002 = _0005;
	}
}
internal sealed class _000E_2008_200B
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 17)]
	internal struct _0002
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 120)]
	internal struct _0005
	{
	}

	internal static readonly _0002 _0005/* Not supported: data(69 66 28 21 66 75 6E 63 74 69 6F 6E 28 65 29 7B 6C) */;

	internal static readonly _0005 _0002/* Not supported: data(06 02 00 00 00 A4 00 00 52 53 41 31 20 03 00 00 01 00 01 00 49 C0 1C E2 5D 27 AD F3 15 0C 20 B3 1F 36 E7 64 6C 70 E6 29 33 A9 80 96 05 8F BA EE 41 7B CB 6E 43 DC 15 9C 71 E4 FE A1 D7 F3 A9 59 FA 95 F8 0E 3A E4 FE E6 D2 88 49 54 D1 F2 85 6B 47 D8 95 C1 91 38 54 8B EC BC 59 8E AE FB F2 22 F9 47 90 1E 7F 0E F9 BC 06 C1 75 26 C4 83 07 A4 1E C1 5A 77 9A 02 80 F7) */;

	internal static readonly _0005 _000F/* Not supported: data(06 02 00 00 00 A4 00 00 52 53 41 31 20 03 00 00 01 00 01 00 F5 8C C5 14 59 6B FD CC B5 D7 B3 2B 39 78 39 EE 77 7B F9 23 D6 7D EB 89 26 8C E5 B1 D9 28 96 31 53 56 67 AD 50 DB 44 BB 99 42 D2 91 DB D1 FA C0 DD 74 0B F7 A8 76 10 0B 02 8E DE A2 14 48 D5 44 BC CF 92 E2 5E A1 03 C7 4D F1 2B 44 39 F6 B4 36 7D AA EE A1 26 85 18 8C F4 CE 8E 43 7F D3 EA 8D F8 A7 67 B9) */;

	internal static readonly _0002 _0006/* Not supported: data(69 66 28 20 66 75 6E 63 74 69 6F 6E 28 65 29 7B 6C) */;

	internal static readonly _0005 _0008/* Not supported: data(06 02 00 00 00 A4 00 00 52 53 41 31 20 03 00 00 01 00 01 00 E7 00 5D B5 F9 64 CD 60 0C 1E F6 C0 AA FD C8 F7 2C E6 52 20 AD 22 86 19 98 65 21 C0 DA 71 6F B1 4C 45 58 62 42 8A AD 2D E9 49 E0 8B 66 A9 B3 00 DF 6D 18 3F C9 B8 D0 3D 38 7B 84 2D 35 99 73 92 03 9A CD 07 FA 6F 4A 60 AA 20 4A 50 69 FD EB B9 58 71 8E 30 F2 44 3C 8B 89 3E F3 C1 FD E4 07 8C CB 99 DB C8) */;
}
internal sealed class _000E_2009_200B : DeriveBytes
{
	private static volatile bool _0005;

	private DeriveBytes _0002;

	private readonly byte[] _000F;

	private readonly byte[] _0006;

	private readonly int _0008;

	public _000E_2009_200B(byte[] _0005, byte[] _0002, int _000F)
	{
		this._000F = _0005;
		_0006 = _0002;
		_0008 = _000F;
		if (!_000E_2009_200B._0005)
		{
			try
			{
				this._0002 = new Rfc2898DeriveBytes(_0005, _0002, _000F);
			}
			catch
			{
				_000E_2009_200B._0005 = true;
			}
		}
		if (this._0002 == null)
		{
			this._0002 = new _0002(_0005, _0002, _000F);
		}
	}

	public override byte[] GetBytes(int _0005)
	{
		byte[] array = null;
		if (!_000E_2009_200B._0005)
		{
			try
			{
				array = _0002.GetBytes(_0005);
			}
			catch
			{
				_000E_2009_200B._0005 = true;
			}
		}
		if (array == null)
		{
			_0002 = new _0002(_000F, _0006, _0008);
			array = _0002.GetBytes(_0005);
		}
		return array;
	}

	public override void Reset()
	{
		throw new NotSupportedException();
	}
}
internal static class _000E_200A_200B
{
}
internal static class _000F_2001_200B
{
	private static Dictionary<string, List<string>> m__0005;

	private static Dictionary<string, string> m__0002;

	private static Dictionary<string, string> m__000F;

	private static Dictionary<string, long> _0006;

	private static List<string> _0008;

	private static List<string> _0003;

	static _000F_2001_200B()
	{
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "?ImZVe'cWm", (object[])null);
	}

	internal static List<string> _0005()
	{
		return _000F_2001_200B.m__0005.Keys.ToList();
	}

	internal static Dictionary<string, string> _0005()
	{
		return _000F_2001_200B.m__0002;
	}

	private static void _0005(Dictionary<string, string> _0005)
	{
		_000F_2001_200B.m__0002 = _0005;
	}

	internal static Dictionary<string, string> _0002()
	{
		return _000F_2001_200B.m__000F;
	}

	private static void _0002(Dictionary<string, string> _0005)
	{
		_000F_2001_200B.m__000F = _0005;
	}

	internal static Dictionary<string, long> _0005()
	{
		return _0006;
	}

	private static void _0005(Dictionary<string, long> _0005)
	{
		_0006 = _0005;
	}

	internal static List<string> _0002()
	{
		return _0008;
	}

	private static void _0005(List<string> _0005)
	{
		_0008 = _0005;
	}

	internal static List<string> _000F()
	{
		return _0003;
	}

	private static void _0002(List<string> _0005)
	{
		_0003 = _0005;
	}

	private static void _0005()
	{
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), ">Lq?Se'cWP", (object[])null);
	}

	internal static string _0005(string _0005)
	{
		object[] array = new object[1] { _0005 };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "9\\.bDe'cVX", array);
	}

	internal static bool _0005(string _0005)
	{
		object[] array = new object[1] { _0005 };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "6Is]:e'cVY", array);
	}

	internal static string _0005(string _0005, _0002_2001_200B _0002, bool _000F)
	{
		object[] array = new object[3] { _0005, _0002, _000F };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "V:O2He'cVZ", array);
	}
}
internal interface _000F_2008_200B
{
	bool _000F_2008_200B_2001_2004_2001_0005();

	object _000F_2008_200B_2001_2004_2001_0005();

	void _000F_2008_200B_2001_2004_2001_0005();
}
internal sealed class _000F_2009_200B : IEquatable<_000F_2009_200B>
{
	private int m__0005 = 255;

	private int m__0002 = 12;

	private int m__000F = 96;

	private int m__0006 = 10;

	private int m__0008 = 4;

	private static readonly _000F_2009_200B _0003 = new _000F_2009_200B();

	public int _0005()
	{
		return this.m__0005;
	}

	public void _0005(int _0005)
	{
		this.m__0005 = _0005;
	}

	public int _0002()
	{
		return this.m__0002;
	}

	public void _0002(int _0005)
	{
		this.m__0002 = _0005;
	}

	public int _000F()
	{
		return this.m__000F;
	}

	public void _000F(int _0005)
	{
		this.m__000F = _0005;
	}

	public int _0006()
	{
		return this.m__0006;
	}

	public void _0006(int _0005)
	{
		this.m__0006 = _0005;
	}

	public int _0008()
	{
		return this.m__0008;
	}

	public void _0008(int _0005)
	{
		this.m__0008 = _0005;
	}

	public static _000F_2009_200B _0005()
	{
		return _0003;
	}

	public override bool Equals(object _0005)
	{
		return _000F_2009_200B._0005(this, _0005 as _000F_2009_200B);
	}

	public bool Equals(_000F_2009_200B _0005)
	{
		return _000F_2009_200B._0005(this, _0005);
	}

	public static bool _0005(_000F_2009_200B _0005, _000F_2009_200B _0002)
	{
		if (_0005 == _0002)
		{
			return true;
		}
		if (_0005 == null || _0002 == null)
		{
			return false;
		}
		if (_0005._0005() == _0002._0005() && _0005._0002() == _0002._0002() && _0005._000F() == _0002._000F() && _0005._0006() == _0002._0006())
		{
			return _0005._0008() == _0002._0008();
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((((-8832819 + this._0005().GetHashCode()) * -1521134295 + _0002().GetHashCode()) * -1521134295 + _000F().GetHashCode()) * -1521134295 + _0006().GetHashCode()) * -1521134295 + _0008().GetHashCode();
	}
}
[_000F_200A_200B]
internal sealed class _000F_200A_200B : Attribute
{
}
internal static class _000F_200B_200B
{
	private static class _0002
	{
		internal static readonly Dictionary<string, Assembly> _0005 = new Dictionary<string, Assembly>(StringComparer.Ordinal);
	}

	private struct _0005
	{
		public Version _0005;

		public bool _0002;

		public string _000F;

		public string _0006;

		public bool _0008;

		public string _0003;

		public bool _000E;

		public _0005(string _0005)
		{
			this = default;
			this._0005 = new Version();
			_000F = string.Empty;
			string[] array = _0005.Split(',');
			foreach (string text in array)
			{
				string text2 = text.Trim();
				if (text2.StartsWith(_000F_0019._0005(-1057752194), StringComparison.OrdinalIgnoreCase))
				{
					this._0005 = new Version(text2.Substring(_000F_0019._0005(-1057752194).Length));
					_0002 = true;
				}
				else if (text2.StartsWith(_000F_0019._0005(-1057752223), StringComparison.OrdinalIgnoreCase))
				{
					_0006 = text2.Substring(_000F_0019._0005(-1057752223).Length);
					if (_0006.Equals(_000F_0019._0005(-1057752432), StringComparison.OrdinalIgnoreCase))
					{
						_0006 = null;
					}
					_0008 = true;
				}
				else if (text2.StartsWith(_000F_0019._0005(-1057752446), StringComparison.OrdinalIgnoreCase))
				{
					_0003 = text2.Substring(_000F_0019._0005(-1057752446).Length);
					if (_0003.Equals(_000F_0019._0005(-1057752388), StringComparison.OrdinalIgnoreCase))
					{
						_0003 = null;
					}
					_000E = true;
				}
				else
				{
					_000F = text2;
				}
			}
		}

		public string _0005(bool _0005)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(_000F);
			if (_0005)
			{
				stringBuilder.Append(_000F_0019._0005(-1057752413)).Append(this._0005);
			}
			stringBuilder.Append(_000F_0019._0005(-1057752368)).Append(_0006 ?? _000F_0019._0005(-1057752383)).Append(_000F_0019._0005(-1057752333))
				.Append(_0003 ?? _000F_0019._0005(-1057752341));
			return stringBuilder.ToString();
		}
	}

	private static class _0006
	{
		private struct _0002
		{
			private readonly string m__0005;

			private FileStream m__0002;

			public _0002(string _0005)
			{
				this = default;
				this.m__0005 = _0005;
			}

			public bool _0005()
			{
				try
				{
					if (this.m__0002 != null)
					{
						return false;
					}
					this.m__0002 = new FileStream(this.m__0005, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, 128, FileOptions.DeleteOnClose);
				}
				catch
				{
					return false;
				}
				return true;
			}

			public void _0005()
			{
				Stopwatch stopwatch = null;
				int num = 25;
				int num2 = 250;
				while (!this._0005())
				{
					if (stopwatch == null)
					{
						stopwatch = Stopwatch.StartNew();
					}
					else
					{
						if (stopwatch.Elapsed.TotalSeconds > 300.0)
						{
							throw new TimeoutException(string.Format(_000F_0019._0005(-1057752546), this.m__0005));
						}
						if (num < num2)
						{
							num = Math.Min(num * 2, num2);
						}
					}
					Thread.Sleep(num);
				}
			}

			public void _0002()
			{
				if (this.m__0002 != null)
				{
					this.m__0002.Dispose();
					this.m__0002 = null;
				}
			}
		}

		internal sealed class _0005
		{
			public string _0005;

			private string m__0002;

			public string _000F;

			public string _0006;

			public bool _0008;

			public bool _0003;

			public bool _000E;

			public bool _0005_2009;

			public bool _0002_2009;

			public bool _000F_2009;

			public string _0006_2009;

			private string _0008_2009;

			public string _0005()
			{
				if (this.m__0002 == null)
				{
					byte[] array = Convert.FromBase64String(this._0005);
					this.m__0002 = Encoding.UTF8.GetString(array, 0, array.Length);
				}
				return this.m__0002;
			}

			public string _0002()
			{
				if (_0008_2009 == null)
				{
					byte[] array = Convert.FromBase64String(_0006_2009);
					_0008_2009 = Encoding.UTF8.GetString(array, 0, array.Length);
				}
				return _0008_2009;
			}
		}

		private sealed class _000F : IEnumerable<_0005>, IEnumerable, IEnumerator<_0005>, IDisposable, IEnumerator
		{
			private int _0005;

			private _0005 _0002;

			private int m__000F;

			private string _0006;

			public string _0008;

			private string[] _0003;

			private string _000E;

			private int _0005_2009;

			[DebuggerHidden]
			public _000F(int _0005)
			{
				this._0005 = _0005;
				m__000F = Thread.CurrentThread.ManagedThreadId;
			}

			[DebuggerHidden]
			private void _000F_2001_2004_2001_0005()
			{
				_0003 = null;
				_000E = null;
				_0005 = -2;
			}

			void IDisposable.Dispose()
			{
				//ILSpy generated this explicit interface implementation from .override directive in    
				this._000F_2001_2004_2001_0005();
			}

			private bool _000F_2001_2004_2001_0005()
			{
				int num = _0005;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					_0005 = -1;
					goto IL_0163;
				}
				_0005 = -1;
				string text = _000F_0019._0005(-1057752543);
				_0003 = text.Split(',');
				if (_0006 == null && !_000F_200B_200B._0005())
				{
					return false;
				}
				_000E = _0003[0];
				_0005_2009 = 1;
				goto IL_0171;
				IL_0163:
				_0005_2009 += 4;
				goto IL_0171;
				IL_0171:
				if (_0005_2009 < _0003.Length)
				{
					string text2 = _0003[_0005_2009];
					if (_0006 == null || text2.Equals(_0006, StringComparison.Ordinal))
					{
						_0005 obj = new _0005();
						obj._000F = _000E;
						obj._0005 = text2;
						string text3 = _0003[_0005_2009 + 1];
						int num2 = text3.IndexOf('|');
						if (num2 >= 0)
						{
							string text4 = text3.Substring(0, num2);
							text3 = text3.Substring(num2 + 1);
							obj._0008 = text4.IndexOf('a') != -1;
							obj._0003 = text4.IndexOf('b') != -1;
							obj._000E = text4.IndexOf('c') != -1;
							obj._000F_2009 = text4.IndexOf('f') != -1;
						}
						obj._0006 = text3;
						obj._0006_2009 = _0003[_0005_2009 + 2];
						_0002 = obj;
						_0005 = 1;
						return true;
					}
					goto IL_0163;
				}
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in    
				return this._000F_2001_2004_2001_0005();
			}

			[DebuggerHidden]
			private _0005 _000F_2001_2004_2001_0005()
			{
				return _0002;
			}

			_0005 IEnumerator<_0005>.get_Current()
			{
				//ILSpy generated this explicit interface implementation from .override directive in    
				return this._000F_2001_2004_2001_0005();
			}

			[DebuggerHidden]
			private void _000F_2001_2004_2001_0002()
			{
				throw new NotSupportedException();
			}

			void IEnumerator.Reset()
			{
				//ILSpy generated this explicit interface implementation from .override directive in    
				this._000F_2001_2004_2001_0002();
			}

			[DebuggerHidden]
			private object _000F_2001_2004_2001_0005()
			{
				return _0002;
			}

			object IEnumerator.get_Current()
			{
				//ILSpy generated this explicit interface implementation from .override directive in    
				return this._000F_2001_2004_2001_0005();
			}

			[DebuggerHidden]
			private IEnumerator<_0005> _000F_2001_2004_2001_0005()
			{
				_000F obj;
				if (_0005 == -2 && m__000F == Thread.CurrentThread.ManagedThreadId)
				{
					_0005 = 0;
					obj = this;
				}
				else
				{
					obj = new _000F(0);
				}
				obj._0006 = _0008;
				return obj;
			}

			IEnumerator<_0005> IEnumerable<_0005>.GetEnumerator()
			{
				//ILSpy generated this explicit interface implementation from .override directive in    
				return this._000F_2001_2004_2001_0005();
			}

			[DebuggerHidden]
			private IEnumerator _000F_2001_2004_2001_0005()
			{
				return _000F_2001_2004_2001_0005();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				//ILSpy generated this explicit interface implementation from .override directive in    
				return this._000F_2001_2004_2001_0005();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IEnumerable<_0005> _0005(string _0005)
		{
			return new _000F(-2)
			{
				_0008 = _0005
			};
		}

		internal static byte[] _0005(_0005 _0005)
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_0005._0006);
			if (manifestResourceStream == null)
			{
				return null;
			}
			int num = (int)manifestResourceStream.Length;
			byte[] array = new byte[num];
			manifestResourceStream.Read(array, 0, num);
			manifestResourceStream.Dispose();
			if (_0005._0008)
			{
				array = _0002(array);
			}
			if (_0005._0003)
			{
				array = _000F_200B_200B._0005(array);
			}
			return array;
		}

		internal static string _0005(_0005 _0005, bool _0002, byte[] _000F)
		{
			string path = (_0005._000F_2009 ? _0005._0006 : _0005._000F);
			string text = Path.Combine(Path.GetTempPath(), path);
			try
			{
				Directory.CreateDirectory(text);
			}
			catch
			{
				text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				text = Path.Combine(text, _000F_0019._0005(-1057757941));
				text = Path.Combine(text, path);
				Directory.CreateDirectory(text);
				if (text == null)
				{
					throw;
				}
			}
			string text2 = Path.Combine(text, _0005._0002());
			_0002 obj2 = new _0002(text2 + _000F_0019._0005(-1057757892));
			obj2._0005();
			try
			{
				if (!File.Exists(text2))
				{
					if (_000F == null)
					{
						_000F = _0006._0005(_0005);
					}
					File.WriteAllBytes(text2, _000F);
					if (_0002)
					{
						try
						{
							_000F_200B_200B._0005(text2, null, 4);
							_000F_200B_200B._0005(text, null, 4);
						}
						catch
						{
						}
					}
				}
			}
			finally
			{
				obj2._0002();
			}
			return text2;
		}

		internal static void _0005(string _0005, bool _0002)
		{
			bool flag = false;
			try
			{
				File.Delete(_0005);
				flag = true;
			}
			catch
			{
			}
			string directoryName = Path.GetDirectoryName(_0005);
			bool flag2 = false;
			try
			{
				Directory.Delete(directoryName);
				flag = true;
			}
			catch
			{
			}
			if (!_0002)
			{
				return;
			}
			if (!flag)
			{
				try
				{
					_000F_200B_200B._0005(_0005, null, 4);
				}
				catch
				{
				}
			}
			if (!flag2)
			{
				try
				{
					_000F_200B_200B._0005(directoryName, null, 4);
				}
				catch
				{
				}
			}
		}
	}

	private sealed class _000F
	{
		private byte[] m__0005 = new byte[256];

		private int _0002;

		private int m__000F;

		public _000F(byte[] _0005)
		{
			int num = _0005.Length;
			for (_0002 = 0; _0002 < 256; _0002++)
			{
				this.m__0005[_0002] = (byte)_0002;
			}
			for (_0002 = (m__000F = 0); _0002 < 256; _0002++)
			{
				m__000F = (m__000F + _0005[_0002 % num] + this.m__0005[_0002]) & 0xFF;
				this._0005(_0002, m__000F);
			}
		}

		private void _0005(int _0005, int _0002)
		{
			byte b = this.m__0005[_0005];
			this.m__0005[_0005] = this.m__0005[_0002];
			this.m__0005[_0002] = b;
		}

		public byte _0005()
		{
			_0002 = (_0002 + 1) & 0xFF;
			m__000F = (m__000F + this.m__0005[_0002]) & 0xFF;
			_0005(_0002, m__000F);
			return this.m__0005[(byte)(this.m__0005[_0002] + this.m__0005[m__000F])];
		}
	}

	private static int m__0005;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0005()
	{
		if (!_0002())
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0002()
	{
		StackTrace stackTrace = new StackTrace();
		Type type = (stackTrace.GetFrame(3)?.GetMethod())?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			return false;
		}
		if ((object)type == null)
		{
			return false;
		}
		if ((object)type.Assembly != typeof(_000F_200B_200B).Assembly)
		{
			return false;
		}
		return true;
	}

	internal static Assembly _0005(string _0005)
	{
		return _0002(_0005);
	}

	private static Assembly _0005(object _0005, ResolveEventArgs _0002)
	{
		return _000F_200B_200B._0002(_0002.Name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Assembly _0002(string _0005)
	{
		_0005 obj = new _0005(_0005.ToUpperInvariant());
		_0006._0005 obj2 = null;
		bool flag = false;
		if (obj2 == null && !flag)
		{
			string s = obj._0005(_0005: false);
			string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
			using IEnumerator<_0006._0005> enumerator = _0006._0005(text).GetEnumerator();
			if (enumerator.MoveNext())
			{
				_0006._0005 current = enumerator.Current;
				obj2 = current;
			}
		}
		if (obj2 == null)
		{
			return null;
		}
		Dictionary<string, Assembly> dictionary = _000F_200B_200B._0002._0005;
		Assembly value;
		lock (dictionary)
		{
			if (!dictionary.TryGetValue(obj2._0006, out value))
			{
				byte[] array = _0006._0005(obj2);
				if (array == null)
				{
					return null;
				}
				bool flag2 = obj2._000E;
				if (!flag2)
				{
					try
					{
						value = Assembly.Load(array);
					}
					catch (FileLoadException)
					{
						flag2 = true;
					}
					catch (BadImageFormatException)
					{
						flag2 = true;
					}
				}
				if (flag2)
				{
					try
					{
						string assemblyFile = _0006._0005(obj2, _0002: true, array);
						value = Assembly.LoadFrom(assemblyFile);
					}
					catch
					{
					}
				}
				dictionary.Add(obj2._0006, value);
			}
		}
		return value;
	}

	private static int _0005()
	{
		return 1;
	}

	internal static void _0005()
	{
		AppDomain.CurrentDomain.AssemblyResolve += _0005;
	}

	private static int _0005(byte[] _0005, int _0002)
	{
		return _0005[_0002] | (_0005[_0002 + 1] << 24) | (_0005[_0002 + 2] << 8) | (_0005[_0002 + 3] << 16);
	}

	private static int _0002(byte[] _0005, int _0002)
	{
		return _0005[_0002] | (_0005[_0002 + 1] << 8) | (_0005[_0002 + 2] << 16) | (_0005[_0002 + 3] << 24);
	}

	private static byte[] _0005(byte[] _0005)
	{
		int num = _000F_200B_200B._0005(_0005, 0);
		if (num != -1686991929)
		{
			throw new Exception();
		}
		int num2 = _0002(_0005, 4);
		Stream stream = new MemoryStream(_0005, writable: false);
		stream.Position = 8L;
		stream = new DeflateStream(stream, CompressionMode.Decompress);
		BinaryReader binaryReader = new BinaryReader(stream);
		_0005 = binaryReader.ReadBytes(num2);
		binaryReader.Close();
		int num3 = _0005.Length;
		if (num3 != num2)
		{
			throw new Exception();
		}
		return _0005;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] _0002(byte[] _0005)
	{
		string s = _000F_0019._0005(-1057757920);
		byte[] array = Convert.FromBase64String(s);
		_0008_200B_200B._0005(array);
		_000F obj = new _000F(array);
		int num = _0005.Length;
		byte b = 0;
		byte b2 = 121;
		byte[] array2 = new byte[8] { 148, 68, 208, 52, 241, 93, 195, 220 };
		for (int i = 0; i != num; i++)
		{
			if (b == 0)
			{
				b2 = obj._0005();
			}
			b++;
			if (b == 32)
			{
				b = 0;
			}
			_0005[i] ^= (byte)(b2 ^ array2[(i >> 2) & 3] ^ array2[b & 3]);
		}
		return _0005;
	}

	[DllImport("kernel32.dll", EntryPoint = "MoveFileEx")]
	private static extern bool _0005(string _0005, string _0002, int _000F);
}
