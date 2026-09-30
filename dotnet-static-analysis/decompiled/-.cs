using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.Win32.SafeHandles;

internal sealed class _0002 : DeriveBytes
{
	private byte[] m__0005;

	private byte[] m__0002;

	private int _000F;

	private readonly _000F_2000 _0006 = new _000F_2000();

	private readonly byte[] _0008;

	public _0002(byte[] _0005, byte[] _0002, int _000F)
	{
		if (_0005 == null)
		{
			throw new ArgumentNullException(_000F_0019._0005(-1057761902));
		}
		if (_0002 == null)
		{
			throw new ArgumentNullException(_000F_0019._0005(-1057761895));
		}
		if (_000F < 1)
		{
			throw new ArgumentException(_000F_0019._0005(-1057761908));
		}
		this.m__0005 = (byte[])_0005.Clone();
		this.m__0002 = (byte[])_0002.Clone();
		this._000F = _000F;
		_0008 = new byte[_0006._0005()];
	}

	private void _0005(byte[] _0005, int _0002, byte[] _000F, byte[] _0006, int _0008)
	{
		if (_0005 != null)
		{
			this._0006._0005(_0005, 0, _0005.Length);
		}
		this._0006._0005(_000F, 0, _000F.Length);
		this._0006._0005(this._0008, 0);
		Buffer.BlockCopy(this._0008, 0, _0006, _0008, this._0008.Length);
		for (int i = 1; i < _0002; i++)
		{
			this._0006._0005(this._0008, 0, this._0008.Length);
			this._0006._0005(this._0008, 0);
			for (int j = 0; j < this._0008.Length; j++)
			{
				_0006[_0008 + j] ^= this._0008[j];
			}
		}
	}

	public override byte[] GetBytes(int _0005)
	{
		int num = _0006._0005();
		int num2 = (_0005 + num - 1) / num;
		byte[] array = new byte[4];
		byte[] array2 = new byte[num2 * num];
		int num3 = 0;
		_0006._0005(this.m__0005);
		for (int i = 1; i <= num2; i++)
		{
			int num4 = 3;
			while (++array[num4] == 0)
			{
				num4--;
			}
			this._0005(m__0002, _000F, array, array2, num3);
			num3 += num;
		}
		if (_0005 < array2.Length)
		{
			byte[] array3 = new byte[_0005];
			Buffer.BlockCopy(array2, 0, array3, 0, _0005);
			array2 = array3;
		}
		return array2;
	}

	public override void Reset()
	{
		throw new NotSupportedException();
	}
}
internal sealed class _0002_2000 : _0005_2000
{
	private new Array m__0005;

	private int[] _0002;

	public _0002_2000()
		: base(11)
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

	public new int[] _0005()
	{
		return _0002;
	}

	public void _0005(int[] _0005)
	{
		_0002 = _0005;
	}

	[SpecialName]
	public override object _0005_2000_2001_2004_2001_0005()
	{
		return this._0005().GetValue(this._0005());
	}

	[SpecialName]
	public override void _0005_2000_2001_2004_2001_0005(object _0005)
	{
		this._0005().SetValue(_0005, this._0005());
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0002_2000 obj = new _0002_2000();
		obj._0005(this._0005());
		obj._0005(this._0005());
		obj._0005(base._0005());
		((_000F)obj)._0005(((_000F)this)._0005());
		return obj;
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		((_000F)this)._0005(_0005._0005());
		if (_0005._0005() == 11)
		{
			_0002_2000 obj = (_0002_2000)_0005;
			this._0005(obj._0005());
			this._0005(obj._0005());
			base._0005(((_0005_2000)obj)._0005());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	public override bool _0005_2000_2001_2004_2001_0005(_0005_2000 _0005)
	{
		_0002_2000 obj = (_0002_2000)_0005;
		if (this._0005() == obj._0005())
		{
			return _0006_2007._0005(this._0005(), obj._0005());
		}
		return false;
	}
}
internal sealed class _0002_2001 : _0005_2001, IDisposable
{
	private SecureString m__0005 = new SecureString();

	[SpecialName]
	public int _0005_2001_2001_2004_2001_0005()
	{
		return this.m__0005.Length;
	}

	public _0005_2001 _0005_2001_2001_2004_2001_0005()
	{
		return new _0002_2001();
	}

	public void _0005_2001_2001_2004_2001_0005(int _0005, out byte _0002)
	{
		if (_0005 < 0 || _0005 >= this._0005_2001_2001_2004_2001_0005())
		{
			throw new ArgumentOutOfRangeException();
		}
		IntPtr intPtr = IntPtr.Zero;
		char c = '\0';
		try
		{
			intPtr = Marshal.SecureStringToGlobalAllocUnicode(this.m__0005);
			c = (char)Marshal.ReadInt16(intPtr, _0005 * 2);
			_0002 = _0002_2001._0005(c, _0005);
		}
		finally
		{
			_0006_2008._0005(ref c);
			if (intPtr != IntPtr.Zero)
			{
				Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
			}
		}
	}

	public void _0005_2001_2001_2004_2001_0002(int _0005, ref byte _0002)
	{
		int num = this.m__0005.Length;
		while (true)
		{
			if (num > _0005)
			{
				this.m__0005.SetAt(_0005, _0002_2001._0005(_0002, _0005));
				return;
			}
			if (num == _0005)
			{
				break;
			}
			this.m__0005.AppendChar(_0002_2001._0005(0, num));
			num++;
		}
		this.m__0005.AppendChar(_0002_2001._0005(_0002, num));
	}

	private static char _0005(byte _0005, int _0002)
	{
		return (char)(_0005 + 1);
	}

	private static byte _0005(char _0005, int _0002)
	{
		return (byte)(_0005 - 1);
	}

	public void _0005_2001_2001_2004_2001_0005()
	{
		this.m__0005.Clear();
	}

	public void Dispose()
	{
		this.m__0005.Dispose();
		this.m__0005 = null;
	}
}
[_000F_2005]
internal sealed class _0002_2003 : Attribute
{
}
internal sealed class _0002_2004 : _0005_200A, IDisposable
{
	private _0005_2003 m__0005;

	private byte[] m__0002;

	private readonly int _000F;

	private readonly int _0006;

	public _0002_2004(_0005_2003 _0005)
	{
		if (_0005 == null)
		{
			throw new ArgumentNullException();
		}
		if (_0005._0005())
		{
			throw new NotSupportedException();
		}
		this.m__0005 = _0005;
		this.m__0002 = new byte[_0005._0005_200A_2001_2004_2001_0002()];
		_000F = this._0005();
		_0006 = _0002();
	}

	private int _0005()
	{
		return this.m__0005._0005_200A_2001_2004_2001_0005();
	}

	private int _0002()
	{
		return this.m__0005._0005_200A_2001_2004_2001_0002() - 10;
	}

	[SpecialName]
	[CompilerGenerated]
	public int _0005_200A_2001_2004_2001_0005()
	{
		return _000F;
	}

	[SpecialName]
	[CompilerGenerated]
	public int _0005_200A_2001_2004_2001_0002()
	{
		return _0006;
	}

	public int _0005_200A_2001_2004_2001_0005(byte[] _0005, int _0002, int _000F, byte[] _0006, int _0008, RandomNumberGenerator _0003)
	{
		return this._0005(_0005, _0002, _000F, _0006, _0008, _0003);
	}

	private int _0005(byte[] _0005, int _0002, int _000F, byte[] _0006, int _0008, RandomNumberGenerator _0003)
	{
		int num = this.m__0005._0005_200A_2001_2004_2001_0002();
		byte[] array = this.m__0002;
		this.m__0005._0005_200A_2001_2004_2001_0005(_0005, _0002, _000F, array, 0, _0003);
		byte b = array[0];
		bool flag = b != 2;
		int num2 = _0002_2004._0005(b, array, 0, num);
		num2++;
		if (flag | (num2 < 10))
		{
			throw new InvalidOperationException(_000F_0019._0005(-1057760040));
		}
		int num3 = num - num2;
		Buffer.BlockCopy(array, num2, _0006, _0008, num3);
		return num3;
	}

	private static int _0005(byte _0005, byte[] _0002, int _000F, int _0006)
	{
		for (int i = _000F + 1; i != _000F + _0006; i++)
		{
			if (_0002[i] == 0)
			{
				return i;
			}
		}
		return -1;
	}

	public void Dispose()
	{
		if (this.m__0005 != null)
		{
			this.m__0005.Dispose();
			this.m__0005 = null;
		}
	}
}
internal sealed class _0002_2005
{
	private byte[] m__0005;

	private int m__0002;

	private long m__000F;

	private uint _0006;

	private uint _0008;

	private uint _0003;

	private uint _000E;

	private uint _0005_2009;

	private uint[] _0002_2009 = new uint[80];

	private int _000F_2009;

	public _0002_2005()
	{
		this.m__0005 = new byte[4];
		this._0002();
	}

	public _0002_2005(_0002_2005 _0005)
	{
		this._0005(_0005);
	}

	public void _0005(byte _0005)
	{
		this.m__0005[this.m__0002++] = _0005;
		if (this.m__0002 == this.m__0005.Length)
		{
			this._0005(this.m__0005, 0);
			this.m__0002 = 0;
		}
		this.m__000F++;
	}

	public void _0005(byte[] _0005, int _0002, int _000F)
	{
		_000F = Math.Max(0, _000F);
		int i = 0;
		if (this.m__0002 != 0)
		{
			while (i < _000F)
			{
				this.m__0005[this.m__0002++] = _0005[_0002 + i++];
				if (this.m__0002 == 4)
				{
					this._0005(this.m__0005, 0);
					this.m__0002 = 0;
					break;
				}
			}
		}
		for (int num = ((_000F - i) & -4) + i; i < num; i += 4)
		{
			this._0005(_0005, _0002 + i);
		}
		while (i < _000F)
		{
			this.m__0005[this.m__0002++] = _0005[_0002 + i++];
		}
		this.m__000F += _000F;
	}

	public void _0005()
	{
		long num = this.m__000F << 3;
		_0005(128);
		while (this.m__0002 != 0)
		{
			_0005(0);
		}
		_0005(num);
		_000F();
	}

	public int _0005()
	{
		return 64;
	}

	private void _0005(_0002_2005 _0005)
	{
		this.m__0005 = new byte[_0005.m__0005.Length];
		Buffer.BlockCopy(_0005.m__0005, 0, this.m__0005, 0, _0005.m__0005.Length);
		this.m__0002 = _0005.m__0002;
		this.m__000F = _0005.m__000F;
		_0006 = _0005._0006;
		_0008 = _0005._0008;
		_0003 = _0005._0003;
		_000E = _0005._000E;
		_0005_2009 = _0005._0005_2009;
		Array.Copy(_0005._0002_2009, 0, _0002_2009, 0, _0005._0002_2009.Length);
		_000F_2009 = _0005._000F_2009;
	}

	public int _0002()
	{
		return 20;
	}

	public void _0005(byte[] _0005, int _0002)
	{
		_0002_2009[_000F_2009] = _0002_2005._0005(_0005, _0002);
		if (++_000F_2009 == 16)
		{
			_000F();
		}
	}

	public void _0005(long _0005)
	{
		if (_000F_2009 > 14)
		{
			_000F();
		}
		_0002_2009[14] = (uint)((ulong)_0005 >> 32);
		_0002_2009[15] = (uint)_0005;
	}

	public int _0005(byte[] _0005, int _0002)
	{
		this._0005();
		_0002_2005._0005(_0006, _0005, _0002);
		_0002_2005._0005(_0008, _0005, _0002 + 4);
		_0002_2005._0005(_0003, _0005, _0002 + 8);
		_0002_2005._0005(_000E, _0005, _0002 + 12);
		_0002_2005._0005(_0005_2009, _0005, _0002 + 16);
		this._0002();
		return 20;
	}

	public void _0002()
	{
		this.m__000F = 0L;
		this.m__0002 = 0;
		Array.Clear(this.m__0005, 0, this.m__0005.Length);
		_0006 = 1732584193u;
		_0008 = 4023233417u;
		_0003 = 2562383102u;
		_000E = 271733878u;
		_0005_2009 = 3285377520u;
		_000F_2009 = 0;
		Array.Clear(_0002_2009, 0, _0002_2009.Length);
	}

	private static uint _0005(uint _0005, uint _0002, uint _000F)
	{
		return (_0005 & _0002) | (~_0005 & _000F);
	}

	private static uint _0002(uint _0005, uint _0002, uint _000F)
	{
		return _0005 ^ _0002 ^ _000F;
	}

	private static uint _000F(uint _0005, uint _0002, uint _000F)
	{
		return (_0005 & _0002) | (_0005 & _000F) | (_0002 & _000F);
	}

	private void _000F()
	{
		for (int i = 16; i < 80; i++)
		{
			uint num = _0002_2009[i - 3] ^ _0002_2009[i - 8] ^ _0002_2009[i - 14] ^ _0002_2009[i - 16];
			_0002_2009[i] = (num << 1) | (num >> 31);
		}
		uint num2 = _0006;
		uint num3 = _0008;
		uint num4 = _0003;
		uint num5 = _000E;
		uint num6 = _0005_2009;
		int num7 = 0;
		for (int j = 0; j < 4; j++)
		{
			num6 += ((num2 << 5) | (num2 >> 27)) + _0005(num3, num4, num5) + _0002_2009[num7++] + 1518500249;
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += ((num6 << 5) | (num6 >> 27)) + _0005(num2, num3, num4) + _0002_2009[num7++] + 1518500249;
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += ((num5 << 5) | (num5 >> 27)) + _0005(num6, num2, num3) + _0002_2009[num7++] + 1518500249;
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += ((num4 << 5) | (num4 >> 27)) + _0005(num5, num6, num2) + _0002_2009[num7++] + 1518500249;
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += ((num3 << 5) | (num3 >> 27)) + _0005(num4, num5, num6) + _0002_2009[num7++] + 1518500249;
			num4 = (num4 << 30) | (num4 >> 2);
		}
		for (int k = 0; k < 4; k++)
		{
			num6 += ((num2 << 5) | (num2 >> 27)) + _0002(num3, num4, num5) + _0002_2009[num7++] + 1859775393;
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += ((num6 << 5) | (num6 >> 27)) + _0002(num2, num3, num4) + _0002_2009[num7++] + 1859775393;
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += ((num5 << 5) | (num5 >> 27)) + _0002(num6, num2, num3) + _0002_2009[num7++] + 1859775393;
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += ((num4 << 5) | (num4 >> 27)) + _0002(num5, num6, num2) + _0002_2009[num7++] + 1859775393;
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += ((num3 << 5) | (num3 >> 27)) + _0002(num4, num5, num6) + _0002_2009[num7++] + 1859775393;
			num4 = (num4 << 30) | (num4 >> 2);
		}
		for (int l = 0; l < 4; l++)
		{
			num6 += (uint)((int)(((num2 << 5) | (num2 >> 27)) + _000F(num3, num4, num5) + _0002_2009[num7++]) + -1894007588);
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += (uint)((int)(((num6 << 5) | (num6 >> 27)) + _000F(num2, num3, num4) + _0002_2009[num7++]) + -1894007588);
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += (uint)((int)(((num5 << 5) | (num5 >> 27)) + _000F(num6, num2, num3) + _0002_2009[num7++]) + -1894007588);
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += (uint)((int)(((num4 << 5) | (num4 >> 27)) + _000F(num5, num6, num2) + _0002_2009[num7++]) + -1894007588);
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += (uint)((int)(((num3 << 5) | (num3 >> 27)) + _000F(num4, num5, num6) + _0002_2009[num7++]) + -1894007588);
			num4 = (num4 << 30) | (num4 >> 2);
		}
		for (int m = 0; m < 4; m++)
		{
			num6 += (uint)((int)(((num2 << 5) | (num2 >> 27)) + _0002(num3, num4, num5) + _0002_2009[num7++]) + -899497514);
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += (uint)((int)(((num6 << 5) | (num6 >> 27)) + _0002(num2, num3, num4) + _0002_2009[num7++]) + -899497514);
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += (uint)((int)(((num5 << 5) | (num5 >> 27)) + _0002(num6, num2, num3) + _0002_2009[num7++]) + -899497514);
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += (uint)((int)(((num4 << 5) | (num4 >> 27)) + _0002(num5, num6, num2) + _0002_2009[num7++]) + -899497514);
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += (uint)((int)(((num3 << 5) | (num3 >> 27)) + _0002(num4, num5, num6) + _0002_2009[num7++]) + -899497514);
			num4 = (num4 << 30) | (num4 >> 2);
		}
		_0006 += num2;
		_0008 += num3;
		_0003 += num4;
		_000E += num5;
		_0005_2009 += num6;
		_000F_2009 = 0;
		Array.Clear(_0002_2009, 0, 16);
	}

	private static void _0005(uint _0005, byte[] _0002, int _000F)
	{
		_0002[_000F] = (byte)(_0005 >> 24);
		_0002[_000F + 1] = (byte)(_0005 >> 16);
		_0002[_000F + 2] = (byte)(_0005 >> 8);
		_0002[_000F + 3] = (byte)_0005;
	}

	private static uint _0005(byte[] _0005, int _0002)
	{
		return (uint)((_0005[_0002] << 24) | (_0005[_0002 + 1] << 16) | (_0005[_0002 + 2] << 8) | _0005[_0002 + 3]);
	}

	public _0002_2005 _0005()
	{
		return new _0002_2005(this);
	}

	public void _0002(_0002_2005 _0005)
	{
		this._0005(_0005);
	}
}
internal sealed class _0002_2006
{
	private readonly bool m__0005;

	private readonly _000F_2007 m__0002;

	private readonly _000F_2007 _000F;

	public _0002_2006(bool _0005, _000F_2007 _0002, _000F_2007 _000F)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException(_000F_0019._0005(-1057760192));
		}
		if (_000F == null)
		{
			throw new ArgumentNullException(_000F_0019._0005(-1057760142));
		}
		this.m__0005 = _0005;
		this.m__0002 = _0002;
		this._000F = _000F;
	}

	public bool _0005()
	{
		return this.m__0005;
	}

	public _000F_2007 _0005()
	{
		return this.m__0002;
	}

	public _000F_2007 _0002()
	{
		return _000F;
	}
}
internal sealed class _0002_2007
{
	public readonly _0006_2003 _0002_200B_200B = new _0006_2003(-1232479313, 2);

	public readonly _0006_2003 _0002 = new _0006_2003(1094346108, 11);

	public readonly _0006_2003 _0003_2008_2005 = new _0006_2003(-316960875, 1);

	public readonly _0006_2003 _0005_2005 = new _0006_2003(47769849, 11);

	public readonly _0006_2003 _0003 = new _0006_2003(-295246650, 11);

	public readonly _0006_2003 _000F_200B = new _0006_2003(-1650938952, 11);

	public readonly _0006_2003 _0003_2003 = new _0006_2003(66705748, 1);

	public readonly _0006_2003 _0002_2003_200B = new _0006_2003(-146859002, 11);

	public readonly _0006_2003 _0008_2008_2005 = new _0006_2003(1735380682, 11);

	public readonly _0006_2003 _000E_2009 = new _0006_2003(1613828428, 11);

	public readonly _0006_2003 _000F_2005_200B = new _0006_2003(868003463, 11);

	public readonly _0006_2003 _000F_200A_2005 = new _0006_2003(845823706, 11);

	public readonly _0006_2003 _0002_2004 = new _0006_2003(-1756348106, 2);

	public readonly _0006_2003 _0005_2000 = new _0006_2003(1317869153, 11);

	public readonly _0006_2003 _000E_2005_200B = new _0006_2003(1699891452, 11);

	public readonly _0006_2003 _0005_200B = new _0006_2003(1917224674, 11);

	public readonly _0006_2003 _0006_200A_2005 = new _0006_2003(-268434242, 11);

	public readonly _0006_2003 _0006_2002_200B = new _0006_2003(-1689778255, 11);

	public readonly _0006_2003 _000F_200B_200B = new _0006_2003(1877618583, 11);

	public readonly _0006_2003 _0008_2000 = new _0006_2003(-1644009814, 11);

	public readonly _0006_2003 _0005_2000_200B = new _0006_2003(-1807897747, 11);

	public readonly _0006_2003 _0006_2003 = new _0006_2003(-640640518, 3);

	public readonly _0006_2003 _0006_2008 = new _0006_2003(1705374220, 11);

	public readonly _0006_2003 _0006_200B = new _0006_2003(-728708886, 11);

	public readonly _0006_2003 _0008_2002_200B = new _0006_2003(-2037119401, 11);

	public readonly _0006_2003 _0008_2005_200B = new _0006_2003(-1886101765, 11);

	public readonly _0006_2003 _0003_200A_200B = new _0006_2003(1056322836, 11);

	public readonly _0006_2003 _0002_200B_2005 = new _0006_2003(-1436663687, 11);

	public readonly _0006_2003 _0008_2000_200B = new _0006_2003(-1764217143, 11);

	public readonly _0006_2003 _0008_2006_200B = new _0006_2003(700109729, 11);

	public readonly _0006_2003 _000E_2003 = new _0006_2003(619626356, 11);

	public readonly _0006_2003 _0003_2006_200B = new _0006_2003(-1735230197, 11);

	public readonly _0006_2003 _0002_2000 = new _0006_2003(2042017729, 11);

	public readonly _0006_2003 _0005_2001_2005 = new _0006_2003(1414533200, 11);

	public readonly _0006_2003 _000E_2000_200B = new _0006_2003(166816473, 11);

	public readonly _0006_2003 _0005_2004_200B = new _0006_2003(1735266217, 2);

	public readonly _0006_2003 _000E_2002 = new _0006_2003(478142844, 11);

	public readonly _0006_2003 _0002_2005_200B = new _0006_2003(264631522, 11);

	public readonly _0006_2003 _0005_200A_2005 = new _0006_2003(1921054505, 2);

	public readonly _0006_2003 _0006_2007_200B = new _0006_2003(-1560633937, 2);

	public readonly _0006_2003 _0003_2005_200B = new _0006_2003(-944049420, 2);

	public readonly _0006_2003 _0005_2003_200B = new _0006_2003(766470513, 11);

	public readonly _0006_2003 _0002_200B = new _0006_2003(-669785195, 11);

	public readonly _0006_2003 _0005_2007 = new _0006_2003(1833198827, 0);

	public readonly _0006_2003 _000E_2001 = new _0006_2003(-897381497, 11);

	public readonly _0006_2003 _0005_2009_2005 = new _0006_2003(-1590139933, 12);

	public readonly _0006_2003 _0005_2005_200B = new _0006_2003(155293256, 1);

	public readonly _0006_2003 _0005_200A_200B = new _0006_2003(-1566847779, 2);

	public readonly _0006_2003 _0005_2003 = new _0006_2003(-2102536773, 11);

	public readonly _0006_2003 _0006_2001_2005 = new _0006_2003(550610199, 11);

	public readonly _0006_2003 _000E_200B = new _0006_2003(694964542, 11);

	public readonly _0006_2003 _0005_2009_200B = new _0006_2003(1710025575, 11);

	public readonly _0006_2003 _000E_2009_2005 = new _0006_2003(-720311366, 2);

	public readonly _0006_2003 _0008_2009_200B = new _0006_2003(-885690738, 12);

	public readonly _0006_2003 _0003_200B_200B = new _0006_2003(-662074842, 11);

	public readonly _0006_2003 _0003_2008 = new _0006_2003(-2131033827, 11);

	public readonly _0006_2003 _0005_2006_200B = new _0006_2003(496218931, 11);

	public readonly _0006_2003 _0002_2007_200B = new _0006_2003(-2065308837, 11);

	public readonly _0006_2003 _0005_2008 = new _0006_2003(487008607, 2);

	public readonly _0006_2003 _0008_2004_200B = new _0006_2003(-1704882964, 11);

	public readonly _0006_2003 _000E_200B_2005 = new _0006_2003(747469837, 2);

	public readonly _0006_2003 _0002_2004_200B = new _0006_2003(19856216, 1);

	public readonly _0006_2003 _0005_200A = new _0006_2003(-1631426610, 11);

	public readonly _0006_2003 _0005_2002_200B = new _0006_2003(430473575, 11);

	public readonly _0006_2003 _0003_200A_2005 = new _0006_2003(1982239394, 3);

	public readonly _0006_2003 _0006_2006_200B = new _0006_2003(622742323, 12);

	public readonly _0006_2003 _0008_2003 = new _0006_2003(50629271, 11);

	public readonly _0006_2003 _0006_200B_2005 = new _0006_2003(474409694, 1);

	public readonly _0006_2003 _0008_200A_200B = new _0006_2003(514397307, 11);

	public readonly _0006_2003 _0003_2002_200B = new _0006_2003(113022720, 12);

	public readonly _0006_2003 _000F_2003 = new _0006_2003(1118302236, 11);

	public readonly _0006_2003 _0003_2008_200B = new _0006_2003(1481561783, 2);

	public readonly _0006_2003 _0003_2009 = new _0006_2003(1321544975, 11);

	public readonly _0006_2003 _0008_200B_2005 = new _0006_2003(1160149921, 12);

	public readonly _0006_2003 _0002_2006_200B = new _0006_2003(-1181486451, 2);

	public readonly _0006_2003 _000E_2007_200B = new _0006_2003(1565081396, 11);

	public readonly _0006_2003 _0003_2001_2005 = new _0006_2003(-1290785155, 11);

	public readonly _0006_2003 _0006_2000_200B = new _0006_2003(-1641023038, 1);

	public readonly _0006_2003 _000E_2003_200B = new _0006_2003(697641588, 11);

	public readonly _0006_2003 _0003_2002 = new _0006_2003(-929613099, 11);

	public readonly _0006_2003 _0008_2004 = new _0006_2003(1202618390, 11);

	public readonly _0006_2003 _000E_2008 = new _0006_2003(-950157025, 11);

	public readonly _0006_2003 _0008_2008 = new _0006_2003(-1394411845, 11);

	public readonly _0006_2003 _000E_2009_200B = new _0006_2003(2060797460, 11);

	public readonly _0006_2003 _0002_200A = new _0006_2003(1969445451, 3);

	public readonly _0006_2003 _0003_2000 = new _0006_2003(-1614438479, 1);

	public readonly _0006_2003 _0003_2001 = new _0006_2003(639888136, 2);

	public readonly _0006_2003 _000F_2006 = new _0006_2003(-571673345, 11);

	public readonly _0006_2003 _0005_2006 = new _0006_2003(467987973, 11);

	public readonly _0006_2003 _0003_2005 = new _0006_2003(-1276404659, 11);

	public readonly _0006_2003 _0008_2007_200B = new _0006_2003(2051680887, 2);

	public readonly _0006_2003 _0008_2008_200B = new _0006_2003(-1780432598, 11);

	public readonly _0006_2003 _0003_2006 = new _0006_2003(-879497243, 9);

	public readonly _0006_2003 _000E_2004 = new _0006_2003(1754774123, 11);

	public readonly _0006_2003 _0008_2003_200B = new _0006_2003(-1940657739, 2);

	public readonly _0006_2003 _000F_2005 = new _0006_2003(-280473258, 1);

	public readonly _0006_2003 _000F_2009 = new _0006_2003(593767845, 2);

	public readonly _0006_2003 _0006_2009 = new _0006_2003(1658546769, 1);

	public readonly _0006_2003 _000E_2006 = new _0006_2003(1738906083, 11);

	public readonly _0006_2003 _0005_2001_200B = new _0006_2003(1076173747, 11);

	public readonly _0006_2003 _0003_200A = new _0006_2003(1617271926, 11);

	public readonly _0006_2003 _000E_2007 = new _0006_2003(-1092746967, 11);

	public readonly _0006_2003 _000E_2002_200B = new _0006_2003(-553251771, 11);

	public readonly _0006_2003 _000F_2001_2005 = new _0006_2003(-1727800960, 1);

	public readonly _0006_2003 _000F_2007_200B = new _0006_2003(980606468, 11);

	public readonly _0006_2003 _0003_2009_200B = new _0006_2003(-393023604, 11);

	public readonly _0006_2003 _0002_2005 = new _0006_2003(-1768507293, 11);

	public readonly _0006_2003 _0002_2009_2005 = new _0006_2003(750490928, 11);

	public readonly _0006_2003 _000E_2001_2005 = new _0006_2003(1636111751, 2);

	public readonly _0006_2003 _0002_2001_200B = new _0006_2003(1228920773, 11);

	public readonly _0006_2003 _0003_2004_200B = new _0006_2003(1628387610, 11);

	public readonly _0006_2003 _0002_200A_2005 = new _0006_2003(82792537, 2);

	public readonly _0006_2003 _0006_2002_2005 = new _0006_2003(-1956891004, 11);

	public readonly _0006_2003 _0008_2001 = new _0006_2003(-976814221, 11);

	public readonly _0006_2003 _000F_2007 = new _0006_2003(-402412298, 2);

	public readonly _0006_2003 _0006_2006 = new _0006_2003(202219098, 11);

	public readonly _0006_2003 _000F_2009_2005 = new _0006_2003(-1146840356, 11);

	public readonly _0006_2003 _000F_2001_200B = new _0006_2003(1462706025, 1);

	public readonly _0006_2003 _0006_2009_2005 = new _0006_2003(-82497909, 11);

	public readonly _0006_2003 _0008_2009_2005 = new _0006_2003(1448497618, 11);

	public readonly _0006_2003 _0006_2001 = new _0006_2003(-967563137, 11);

	public readonly _0006_2003 _0008_2002 = new _0006_2003(478970835, 2);

	public readonly _0006_2003 _0006_200B_200B = new _0006_2003(1589493405, 11);

	public readonly _0006_2003 _0002_2002_2005 = new _0006_2003(-344192368, 11);

	public readonly _0006_2003 _0006 = new _0006_2003(-1484714341, 11);

	public readonly _0006_2003 _0002_2009_200B = new _0006_2003(1782685435, 11);

	public readonly _0006_2003 _0008_2001_2005 = new _0006_2003(1356594483, 11);

	public readonly _0006_2003 _0002_2008 = new _0006_2003(1824039666, 11);

	public readonly _0006_2003 _0005_200B_200B = new _0006_2003(1422584043, 11);

	public readonly _0006_2003 _0006_2005_200B = new _0006_2003(895779461, 11);

	public readonly _0006_2003 _000E_2001_200B = new _0006_2003(112879404, 11);

	public readonly _0006_2003 _0002_2002_200B = new _0006_2003(1670391660, 11);

	public readonly _0006_2003 _000F_200A_200B = new _0006_2003(1724612859, 11);

	public readonly _0006_2003 _0005_200B_2005 = new _0006_2003(-506605325, 11);

	public readonly _0006_2003 _0008_2002_2005 = new _0006_2003(105602118, 11);

	public readonly _0006_2003 _0002_2008_200B = new _0006_2003(-1441378932, 10);

	public readonly _0006_2003 _0003_200B_2005 = new _0006_2003(-69909233, 11);

	public readonly _0006_2003 _000F_2002_2005 = new _0006_2003(1550087082, 11);

	public readonly _0006_2003 _0005_2002 = new _0006_2003(-1401303340, 4);

	public readonly _0006_2003 _000F_2008 = new _0006_2003(996144638, 11);

	public readonly _0006_2003 _0005_2008_200B = new _0006_2003(1423438618, 2);

	public readonly _0006_2003 _0002_2002 = new _0006_2003(-1947034655, 8);

	public readonly _0006_2003 _0008_2005 = new _0006_2003(950730491, 3);

	public readonly _0006_2003 _0008_2009 = new _0006_2003(-1948604185, 11);

	public readonly _0006_2003 _0006_2004 = new _0006_2003(-605120166, 2);

	public readonly _0006_2003 _0006_2007 = new _0006_2003(-2096718034, 3);

	public readonly _0006_2003 _0003_2009_2005 = new _0006_2003(-1210497405, 11);

	public readonly _0006_2003 _0005_2002_2005 = new _0006_2003(359547438, 11);

	public readonly _0006_2003 _0003_2001_200B = new _0006_2003(981127230, 1);

	public readonly _0006_2003 _000E_200A_2005 = new _0006_2003(-787546728, 11);

	public readonly _0006_2003 _0002_2008_2005 = new _0006_2003(-911098731, 11);

	public readonly _0006_2003 _000E_2008_2005 = new _0006_2003(1087731348, 11);

	public readonly _0006_2003 _0008_200A = new _0006_2003(756813850, 1);

	public readonly _0006_2003 _0008_2001_200B = new _0006_2003(-1891749911, 11);

	public readonly _0006_2003 _0003_2004 = new _0006_2003(-2087745251, 11);

	public readonly _0006_2003 _0006_200A = new _0006_2003(1616001111, 11);

	public readonly _0006_2003 _0008_200B = new _0006_2003(-1035228571, 11);

	public readonly _0006_2003 _0002_2001_2005 = new _0006_2003(1652329444, 11);

	public readonly _0006_2003 _000F_2008_200B = new _0006_2003(-693632083, 11);

	public readonly _0006_2003 _0006_2003_200B = new _0006_2003(519891070, 11);

	public readonly _0006_2003 _0003_2003_200B = new _0006_2003(1472563324, 11);

	public readonly _0006_2003 _000E_2004_200B = new _0006_2003(2129198032, 11);

	public readonly _0006_2003 _0006_2001_200B = new _0006_2003(1356411028, 11);

	public readonly _0006_2003 _0006_2008_200B = new _0006_2003(-1183151415, 1);

	private bool _000E_200B_200B;

	public readonly _0006_2003 _000F_2002 = new _0006_2003(-1589594721, 3);

	public readonly _0006_2003 _000F_200B_2005 = new _0006_2003(-1215405632, 6);

	public readonly _0006_2003 _000E_200A_200B = new _0006_2003(995199289, 11);

	public readonly _0006_2003 _000E_2006_200B = new _0006_2003(2035563030, 11);

	public readonly _0006_2003 _0002_2009 = new _0006_2003(-1744982463, 11);

	public readonly _0006_2003 _0006_2005 = new _0006_2003(-1430365741, 11);

	public readonly _0006_2003 _0008_2006 = new _0006_2003(566297260, 2);

	public readonly _0006_2003 _000E = new _0006_2003(1558668494, 11);

	public readonly _0006_2003 _0006_2008_2005 = new _0006_2003(1389532784, 11);

	public readonly _0006_2003 _000F_2004_200B = new _0006_2003(-551268472, 11);

	public readonly _0006_2003 _0006_2004_200B = new _0006_2003(79038153, 11);

	public readonly _0006_2003 _000F_2001 = new _0006_2003(-1562139187, 11);

	public readonly _0006_2003 _000E_200A = new _0006_2003(165030930, 11);

	public readonly _0006_2003 _0002_2001 = new _0006_2003(820378447, 11);

	public readonly _0006_2003 _000E_2008_200B = new _0006_2003(873924831, 2);

	public readonly _0006_2003 _000F_2009_200B = new _0006_2003(1936644069, 11);

	public readonly _0006_2003 _000F = new _0006_2003(-2135957356, 2);

	public readonly _0006_2003 _0008_200A_2005 = new _0006_2003(-564348554, 11);

	public readonly _0006_2003 _000F_200A = new _0006_2003(-1746784450, 11);

	public readonly _0006_2003 _000F_2002_200B = new _0006_2003(233106690, 2);

	public readonly _0006_2003 _0002_2000_200B = new _0006_2003(1494111114, 12);

	public readonly _0006_2003 _0002_2006 = new _0006_2003(-1027538627, 11);

	public readonly _0006_2003 _0003_2000_200B = new _0006_2003(-1281443288, 11);

	public readonly _0006_2003 _0006_200A_200B = new _0006_2003(1046449978, 2);

	public readonly _0006_2003 _0005_2008_2005 = new _0006_2003(733052617, 11);

	public readonly _0006_2003 _000F_2004 = new _0006_2003(-142315144, 11);

	public readonly _0006_2003 _000F_2003_200B = new _0006_2003(285383863, 11);

	public readonly _0006_2003 _0005_2007_200B = new _0006_2003(816466880, 11);

	public readonly _0006_2003 _0002_2003 = new _0006_2003(178120934, 11);

	public readonly _0006_2003 _0005_2009 = new _0006_2003(937121372, 11);

	public readonly _0006_2003 _000E_2005 = new _0006_2003(-173274244, 11);

	public readonly _0006_2003 _0006_2000 = new _0006_2003(1923807246, 11);

	public readonly _0006_2003 _0008_200B_200B = new _0006_2003(1793638373, 6);

	public readonly _0006_2003 _0005_2004 = new _0006_2003(-1809820463, 2);

	public readonly _0006_2003 _0003_2007 = new _0006_2003(1763182578, 2);

	public readonly _0006_2003 _000E_2000 = new _0006_2003(1562329700, 11);

	public readonly _0006_2003 _0003_2007_200B = new _0006_2003(2051600946, 11);

	public readonly _0006_2003 _000F_2000 = new _0006_2003(-287802367, 11);

	public readonly _0006_2003 _0002_200A_200B = new _0006_2003(320550049, 11);

	public readonly _0006_2003 _000F_2008_2005 = new _0006_2003(-1840811982, 11);

	public readonly _0006_2003 _0005 = new _0006_2003(107963250, 11);

	public readonly _0006_2003 _0006_2009_200B = new _0006_2003(-490592247, 2);

	public readonly _0006_2003 _000F_2006_200B = new _0006_2003(1809680255, 11);

	public readonly _0006_2003 _0006_2002 = new _0006_2003(-1705441396, 11);

	public readonly _0006_2003 _0003_200B = new _0006_2003(-1670712646, 2);

	public readonly _0006_2003 _000F_2000_200B = new _0006_2003(-1929707350, 11);

	public readonly _0006_2003 _0005_2001 = new _0006_2003(-107036067, 0);

	public readonly _0006_2003 _0003_2002_2005 = new _0006_2003(-1210047813, 11);

	public readonly _0006_2003 _0008 = new _0006_2003(-2004341378, 11);

	public readonly _0006_2003 _0008_2007 = new _0006_2003(164618879, 2);

	public readonly _0006_2003 _0002_2007 = new _0006_2003(817205086, 11);

	public bool _0005()
	{
		return _000E_200B_200B;
	}

	public void _0005(bool _0005)
	{
		_000E_200B_200B = _0005;
	}
}
internal sealed class _0002_2008 : _000E_2009
{
	private int m__0005;

	private byte[] m__0002;

	private long _000F;

	private int _0006;

	[SpecialName]
	[CompilerGenerated]
	public int _000E_2009_2001_2004_2001_0005()
	{
		return this.m__0005;
	}

	public void _0005(int _0005)
	{
		this.m__0005 = _0005;
	}

	[SpecialName]
	[CompilerGenerated]
	public byte[] _000E_2009_2001_2004_2001_0005()
	{
		return this.m__0002;
	}

	public void _0005(byte[] _0005)
	{
		this.m__0002 = _0005;
	}

	[SpecialName]
	[CompilerGenerated]
	public long _000E_2009_2001_2004_2001_0005()
	{
		return _000F;
	}

	public void _0005(long _0005)
	{
		_000F = _0005;
	}

	public int _0005()
	{
		return _0006;
	}

	public void _0002(int _0005)
	{
		_0006 = _0005;
	}
}
internal sealed class _0002_2009 : _0005_2009
{
	private new int m__0005;

	public _0002_2009()
		: base(23)
	{
	}

	public new int _0005()
	{
		return this.m__0005;
	}

	public void _0005(int _0005)
	{
		this.m__0005 = _0005;
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		if (_0005._0005() == 23)
		{
			this._0005(((_0002_2009)_0005)._0005());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0002_2009 obj = new _0002_2009();
		obj._0005(this.m__0005);
		obj._0005(((_000F)this)._0005());
		return obj;
	}
}
internal sealed class _0002_200A : _0005_200A
{
	private _0003_2004 _0005;

	private readonly int _0002;

	private readonly int _000F;

	public _0002_200A(bool _0005, _0002_2006 _0002)
	{
		this._0005 = new _0003_2004();
		this._0005._0005(_0005, _0002);
		this._0002 = this._0005._0005();
		_000F = this._0005._0002();
	}

	[SpecialName]
	[CompilerGenerated]
	public int _0005_200A_2001_2004_2001_0005()
	{
		return _0002;
	}

	[SpecialName]
	[CompilerGenerated]
	public int _0005_200A_2001_2004_2001_0002()
	{
		return _000F;
	}

	public int _0005_200A_2001_2004_2001_0005(byte[] _0005, int _0002, int _000F, byte[] _0006, int _0008, RandomNumberGenerator _0003)
	{
		_000F_2007 obj = this._0005._0005(_0005, _0002, _000F);
		_000F_2007 obj2 = this._0005._0005(obj);
		return this._0005._0005(obj2, _0006, _0008);
	}
}
internal sealed class _0003 : _0008, IDisposable
{
	private byte[] m__0005;

	private int m__0002;

	private int m__000F;

	private int _0006;

	private int _0008;

	private bool m__0003;

	private bool _000E;

	private bool _0005_2009;

	private bool _0002_2009;

	public _0003()
		: this(0)
	{
	}

	public _0003(int _0005)
	{
		if (_0005 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.m__0005 = new byte[_0005];
		_0008 = _0005;
		m__0003 = true;
		_000E = true;
		this.m__0002 = 0;
		_0005_2009 = true;
	}

	public _0003(byte[] _0005)
		: this(_0005, _0002: true)
	{
	}

	public _0003(byte[] _0005, bool _0002)
	{
		if (_0005 == null)
		{
			throw new ArgumentNullException();
		}
		this.m__0005 = _0005;
		_0006 = (_0008 = _0005.Length);
		_000E = _0002;
		this.m__0002 = 0;
		_0005_2009 = true;
	}

	public _0003(byte[] _0005, int _0002, int _000F)
		: this(_0005, _0002, _000F, _0006: true)
	{
	}

	public _0003(byte[] _0005, int _0002, int _000F, bool _0006)
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
		this.m__0005 = _0005;
		this.m__0002 = (this.m__000F = _0002);
		this._0006 = (_0008 = _0002 + _000F);
		_000E = _0006;
		m__0003 = false;
		_0005_2009 = true;
	}

	[SpecialName]
	public override bool _0008_2001_2004_2001_0005()
	{
		return _0005_2009;
	}

	[SpecialName]
	public override bool _0008_2001_2004_2001_000F()
	{
		return _0005_2009;
	}

	[SpecialName]
	public override bool _0008_2001_2004_2001_0002()
	{
		return _000E;
	}

	protected override void _0008_2001_2004_2001_0005(bool _0005)
	{
		if (!_0002_2009)
		{
			if (_0005)
			{
				_0005_2009 = false;
				_000E = false;
				m__0003 = false;
			}
			_0002_2009 = true;
		}
	}

	private bool _0005(int _0005)
	{
		if (_0005 < 0)
		{
			throw new IOException();
		}
		if (_0005 > _0008)
		{
			int num = _0005;
			if (num < 256)
			{
				num = 256;
			}
			if (num < _0008 * 2)
			{
				num = _0008 * 2;
			}
			this._0005(num);
			return true;
		}
		return false;
	}

	public override void _0008_2001_2004_2001_0002()
	{
	}

	internal byte[] _0005()
	{
		return this.m__0005;
	}

	internal void _0005(out int _0005, out int _0002)
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		_0005 = this.m__0002;
		_0002 = _0006;
	}

	internal int _0005()
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		return this.m__000F;
	}

	public int _0005(int _0005)
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		int num = _0006 - this.m__000F;
		if (num > _0005)
		{
			num = _0005;
		}
		if (num < 0)
		{
			num = 0;
		}
		this.m__000F += num;
		return num;
	}

	public int _0002()
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		return _0008 - this.m__0002;
	}

	public void _0005(int _0005)
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		if (_0005 == _0008)
		{
			return;
		}
		if (!m__0003)
		{
			throw new Exception();
		}
		if (_0005 < _0006)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0005 > 0)
		{
			byte[] array = new byte[_0005];
			if (_0006 > 0)
			{
				Buffer.BlockCopy(this.m__0005, 0, array, 0, _0006);
			}
			this.m__0005 = array;
		}
		else
		{
			this.m__0005 = null;
		}
		_0008 = _0005;
	}

	[SpecialName]
	public override long _0008_2001_2004_2001_0005()
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		return _0006 - this.m__0002;
	}

	[SpecialName]
	public override long _0008_2001_2004_2001_0002()
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		return this.m__000F - this.m__0002;
	}

	[SpecialName]
	public override void _0008_2001_2004_2001_0005(long _0005)
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		if (_0005 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0005 > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.m__000F = this.m__0002 + (int)_0005;
	}

	public override int _0008_2001_2004_2001_0005(byte[] _0005, int _0002, int _000F)
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
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
		int num = _0006 - this.m__000F;
		if (num > _000F)
		{
			num = _000F;
		}
		if (num <= 0)
		{
			return 0;
		}
		if (num <= 8)
		{
			int num2 = num;
			while (--num2 >= 0)
			{
				_0005[_0002 + num2] = this.m__0005[this.m__000F + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(this.m__0005, this.m__000F, _0005, _0002, num);
		}
		this.m__000F += num;
		return num;
	}

	public override int _0008_2001_2004_2001_0005()
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		if (this.m__000F >= _0006)
		{
			return -1;
		}
		return this.m__0005[this.m__000F++];
	}

	public override long _0008_2001_2004_2001_0005(long _0005, int _0002)
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		if (_0005 > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException();
		}
		switch (_0002)
		{
		case 0:
			if (_0005 < 0)
			{
				throw new IOException();
			}
			this.m__000F = this.m__0002 + (int)_0005;
			break;
		case 1:
			if (_0005 + this.m__000F < this.m__0002)
			{
				throw new IOException();
			}
			this.m__000F += (int)_0005;
			break;
		case 2:
			if (_0006 + _0005 < this.m__0002)
			{
				throw new IOException();
			}
			this.m__000F = _0006 + (int)_0005;
			break;
		default:
			throw new ArgumentException();
		}
		return this.m__000F;
	}

	public override void _0008_2001_2004_2001_0002(long _0005)
	{
		if (!_000E)
		{
			throw new Exception();
		}
		if (_0005 > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0005 < 0 || _0005 > int.MaxValue - this.m__0002)
		{
			throw new ArgumentOutOfRangeException();
		}
		int num = this.m__0002 + (int)_0005;
		if (!this._0005(num) && num > _0006)
		{
			Array.Clear(this.m__0005, _0006, num - _0006);
		}
		_0006 = num;
		if (this.m__000F > num)
		{
			this.m__000F = num;
		}
	}

	public byte[] _0002()
	{
		byte[] array = new byte[_0006 - this.m__0002];
		Buffer.BlockCopy(this.m__0005, this.m__0002, array, 0, _0006 - this.m__0002);
		return array;
	}

	public override void _0008_2001_2004_2001_0005(byte[] _0005, int _0002, int _000F)
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		if (!_000E)
		{
			throw new Exception();
		}
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
		int num = this.m__000F + _000F;
		if (num < 0)
		{
			throw new IOException();
		}
		if (num > _0006)
		{
			bool flag = this.m__000F > _0006;
			if (num > _0008 && this._0005(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(this.m__0005, _0006, num - _0006);
			}
			_0006 = num;
		}
		if (_000F <= 8)
		{
			int num2 = _000F;
			while (--num2 >= 0)
			{
				this.m__0005[this.m__000F + num2] = _0005[_0002 + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(_0005, _0002, this.m__0005, this.m__000F, _000F);
		}
		this.m__000F = num;
	}

	public override void _0008_2001_2004_2001_0005(byte _0005)
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		if (!_000E)
		{
			throw new Exception();
		}
		if (this.m__000F >= _0006)
		{
			int num = this.m__000F + 1;
			bool flag = this.m__000F > _0006;
			if (num >= _0008 && this._0005(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(this.m__0005, _0006, this.m__000F - _0006);
			}
			_0006 = num;
		}
		this.m__0005[this.m__000F++] = _0005;
	}

	public void _0005(Stream _0005)
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		if (_0005 == null)
		{
			throw new ArgumentNullException();
		}
		_0005.Write(this.m__0005, this.m__0002, _0006 - this.m__0002);
	}

	internal int _000F()
	{
		if (!_0005_2009)
		{
			throw new Exception();
		}
		int num = (this.m__000F += 4);
		if (num > _0006)
		{
			this.m__000F = _0006;
			throw new Exception();
		}
		return (this.m__0005[num - 1] << 24) | (this.m__0005[num - 2] << 8) | (this.m__0005[num - 3] << 16) | this.m__0005[num - 4];
	}
}
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
[_000F_2005]
internal sealed class _0003_2000 : Attribute
{
	public readonly byte _0005;

	public _0003_2000(byte _0005)
	{
		this._0005 = _0005;
	}
}
internal sealed class _0003_2001 : SymmetricAlgorithm
{
	private sealed class _0005 : ICryptoTransform, IDisposable
	{
		private byte[] m__0005;

		private bool _0002;

		public int InputBlockSize => 4;

		public int OutputBlockSize => 4;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => true;

		public _0005(byte[] _0005, bool _0002)
		{
			this.m__0005 = _0005;
			this._0002 = _0002;
		}

		public void Dispose()
		{
		}

		public int TransformBlock(byte[] _0005, int _0002, int _000F, byte[] _0006, int _0008)
		{
			if (_000F % 4 != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			for (int i = 0; i < _000F; i += 4)
			{
				_0003_2001._0005(this.m__0005, _0005, _0002 + i, _0006, _0008 + i, this._0002);
			}
			return _000F;
		}

		public byte[] TransformFinalBlock(byte[] _0005, int _0002, int _000F)
		{
			byte[] array = new byte[_000F];
			TransformBlock(_0005, _0002, _000F, array, 0);
			return array;
		}
	}

	private static byte[] m__0005;

	public _0003_2001()
	{
		LegalBlockSizesValue = new KeySizes[1]
		{
			new KeySizes(32, 32, 0)
		};
		LegalKeySizesValue = new KeySizes[1]
		{
			new KeySizes(80, 80, 0)
		};
		BlockSizeValue = 32;
		KeySizeValue = 80;
		ModeValue = CipherMode.ECB;
		PaddingValue = PaddingMode.None;
	}

	public _0003_2001(byte[] _0005)
		: this()
	{
		Key = _0005 ?? throw new ArgumentNullException();
	}

	static _0003_2001()
	{
		_0003_2001.m__0005 = new byte[256]
		{
			163, 215, 9, 131, 248, 72, 246, 244, 179, 33,
			21, 120, 153, 177, 175, 249, 231, 45, 77, 138,
			206, 76, 202, 46, 82, 149, 217, 30, 78, 56,
			68, 40, 10, 223, 2, 160, 23, 241, 96, 104,
			18, 183, 122, 195, 233, 250, 61, 83, 150, 132,
			107, 186, 242, 99, 154, 25, 124, 174, 229, 245,
			247, 22, 106, 162, 57, 182, 123, 15, 193, 147,
			129, 27, 238, 180, 26, 234, 208, 145, 47, 184,
			85, 185, 218, 133, 63, 65, 191, 224, 90, 88,
			128, 95, 102, 11, 216, 144, 53, 213, 192, 167,
			51, 6, 101, 105, 69, 0, 148, 86, 109, 152,
			155, 118, 151, 252, 178, 194, 176, 254, 219, 32,
			225, 235, 214, 228, 221, 71, 74, 29, 66, 237,
			158, 110, 73, 60, 205, 67, 39, 210, 7, 212,
			222, 199, 103, 24, 137, 203, 48, 31, 141, 198,
			143, 170, 200, 116, 220, 201, 93, 92, 49, 164,
			112, 136, 97, 44, 159, 13, 43, 135, 80, 130,
			84, 100, 38, 125, 3, 64, 52, 75, 28, 115,
			209, 196, 253, 59, 204, 251, 127, 171, 230, 62,
			91, 165, 173, 4, 35, 156, 20, 81, 34, 240,
			41, 121, 113, 126, 255, 140, 14, 226, 12, 239,
			188, 114, 117, 111, 55, 161, 236, 211, 142, 98,
			139, 134, 16, 232, 8, 119, 17, 190, 146, 79,
			36, 197, 50, 54, 157, 207, 243, 166, 187, 172,
			94, 108, 169, 19, 87, 37, 181, 227, 189, 168,
			58, 1, 5, 89, 42, 70
		};
	}

	public override ICryptoTransform CreateDecryptor(byte[] _0005, byte[] _0002)
	{
		return new _0005(_0005, _0002: false);
	}

	public override ICryptoTransform CreateEncryptor(byte[] _0005, byte[] _0002)
	{
		return new _0005(_0005, _0002: true);
	}

	public override void GenerateIV()
	{
		throw new NotImplementedException();
	}

	public override void GenerateKey()
	{
		throw new NotImplementedException();
	}

	private static ushort _0005(byte[] _0005, int _0002, ushort _000F)
	{
		byte b = (byte)(_000F >> 8);
		byte b2 = (byte)_000F;
		byte b3 = (byte)(_0003_2001.m__0005[b2 ^ _0005[4 * _0002 % 10]] ^ b);
		byte b4 = (byte)(_0003_2001.m__0005[b3 ^ _0005[(4 * _0002 + 1) % 10]] ^ b2);
		byte b5 = (byte)(_0003_2001.m__0005[b4 ^ _0005[(4 * _0002 + 2) % 10]] ^ b3);
		byte b6 = (byte)(_0003_2001.m__0005[b5 ^ _0005[(4 * _0002 + 3) % 10]] ^ b4);
		return (ushort)((b5 << 8) + b6);
	}

	private static void _0005(byte[] _0005, byte[] _0002, int _000F, byte[] _0006, int _0008, bool _0003)
	{
		int num;
		int num2;
		if (_0003)
		{
			num = 1;
			num2 = 0;
		}
		else
		{
			num = -1;
			num2 = 23;
		}
		ushort num3 = (ushort)((_0002[_000F] << 8) + _0002[_000F + 1]);
		ushort num4 = (ushort)((_0002[_000F + 2] << 8) + _0002[_000F + 3]);
		for (int i = 0; i < 12; i++)
		{
			num4 ^= (ushort)(_0003_2001._0005(_0005, num2, num3) ^ num2);
			num2 += num;
			num3 ^= (ushort)(_0003_2001._0005(_0005, num2, num4) ^ num2);
			num2 += num;
		}
		_0006[_0008] = (byte)(num4 >> 8);
		_0006[_0008 + 1] = (byte)num4;
		_0006[_0008 + 2] = (byte)(num3 >> 8);
		_0006[_0008 + 3] = (byte)num3;
	}
}
internal static class _0003_2002
{
	private static readonly bool m__0005;

	private static readonly bool m__0002;

	static _0003_2002()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		_0003_2002.m__0005 = oSVersion.Platform == PlatformID.Win32NT && oSVersion.Version >= new Version(6, 0);
		if (_0005())
		{
			try
			{
				_0003_2002.m__0002 = _0005(oSVersion);
			}
			catch
			{
				_0003_2002.m__0002 = false;
			}
		}
	}

	public static bool _0005()
	{
		return _0003_2002.m__0005;
	}

	public static bool _0002()
	{
		return _0003_2002.m__0002;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0005(OperatingSystem _0005)
	{
		if (_0005.Platform == PlatformID.Win32NT && _0005.Version < new Version(6, 2, 9200) && Process.GetCurrentProcess().SessionId == 0)
		{
			return false;
		}
		return true;
	}
}
internal sealed class _0003_2003 : _000F
{
	private new long m__0005;

	public _0003_2003()
		: base(13)
	{
	}

	public _0003_2003(long _0005)
		: this()
	{
		this.m__0005 = _0005;
	}

	public new long _0005()
	{
		return this.m__0005;
	}

	public void _0005(long _0005)
	{
		this.m__0005 = _0005;
	}

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		return _0005();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		if (_0005 is ulong)
		{
			this._0005((long)(ulong)_0005);
		}
		else if (_0005 is float)
		{
			this._0005((long)(float)_0005);
		}
		else if (_0005 is double)
		{
			this._0005((long)(double)_0005);
		}
		else
		{
			this._0005(Convert.ToInt64(_0005));
		}
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0003_2003 obj = new _0003_2003();
		obj._0005(this.m__0005);
		obj._0005(base._0005());
		return obj;
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
			this._0005(((_000E_2001)_0005)._0005());
			break;
		case 1:
			this._0005(((_0006)_0005)._0005());
			break;
		case 17:
			this._0005(((_0003_200B)_0005)._0005());
			break;
		case 16:
			this._0005(((_0008_200A)_0005)._0005());
			break;
		case 3:
			this._0005(((_0006_200B)_0005)._0005());
			break;
		case 13:
			this._0005(((_0003_2003)_0005)._0005());
			break;
		case 14:
			this._0005((long)((_000E_2005)_0005)._0005());
			break;
		case 19:
			this._0005(Convert.ToInt64(((_0005_0019)_0005)._0005()));
			break;
		case 7:
			this._0005(Convert.ToInt64(((_0008_2008)_0005)._0005()));
			break;
		case 0:
			this._0005((long)((_000F_2002)_0005)._0005());
			break;
		case 20:
			this._0005((long)(ulong)((_0005_2008)_0005)._0005());
			break;
		case 22:
			this._0005((long)((_0006_2000)_0005)._0005());
			break;
		case 8:
			this._0005((long)((_000F_2006)_0005)._0005());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal sealed class _0003_2004
{
	private _0002_2006 m__0005;

	private int m__0002;

	private int _000F;

	private int _0006;

	public void _0005(bool _0005, _0002_2006 _0002)
	{
		this.m__0005 = _0002;
		this.m__0002 = this.m__0005._0005()._0005();
		this._0005(_0003_2004._0005(this.m__0002, _0005));
		this._0002(_0003_2004._0002(this.m__0002, _0005));
	}

	public int _0005()
	{
		return _000F;
	}

	private void _0005(int _0005)
	{
		_000F = _0005;
	}

	public int _0002()
	{
		return _0006;
	}

	private void _0002(int _0005)
	{
		_0006 = _0005;
	}

	private static int _0005(int _0005, bool _0002)
	{
		if (!_0002)
		{
			return (_0005 + 7) / 8;
		}
		return (_0005 - 1) / 8;
	}

	private static int _0002(int _0005, bool _0002)
	{
		if (!_0002)
		{
			return (_0005 - 1) / 8;
		}
		return (_0005 + 7) / 8;
	}

	public _000F_2007 _0005(byte[] _0005, int _0002, int _000F)
	{
		return new _000F_2007(1, _0005, _0002, _000F);
	}

	public int _0005(_000F_2007 _0005, byte[] _0002, int _000F)
	{
		int num = this._0002() - _0005._0006();
		Array.Clear(_0002, _000F, num);
		_000F += num;
		_0005._0005(_0002, _000F);
		return this._0002();
	}

	public _000F_2007 _0005(_000F_2007 _0005)
	{
		return _0005._0005(this.m__0005._0002(), this.m__0005._0005());
	}
}
internal static class _0003_2005<_0005>
{
	public static readonly _0005[] _0005;

	static _0003_2005()
	{
		global::_0003_2005<_0005>._0005 = new _0005[0];
	}
}
internal static class _0003_2006
{
	private static readonly uint[] m__0005;

	static _0003_2006()
	{
		_0003_2006.m__0005 = new uint[5] { 52200625u, 614125u, 7225u, 85u, 1u };
	}

	public static byte[] _0005(string _0005)
	{
		if (_0005 == null)
		{
			throw new Exception();
		}
		MemoryStream memoryStream = new MemoryStream(_0005.Length * 4 / 5);
		try
		{
			int num = 0;
			uint num2 = 0u;
			foreach (char c in _0005)
			{
				if (c == 'z' && num == 0)
				{
					_0003_2006._0005(memoryStream, num2, 0);
					continue;
				}
				if (c < '!' || c > 'u')
				{
					throw new Exception();
				}
				num2 = checked(num2 + (uint)(_0003_2006.m__0005[num] * (c - 33)));
				num++;
				if (num == 5)
				{
					_0003_2006._0005(memoryStream, num2, 0);
					num = 0;
					num2 = 0u;
				}
			}
			if (num == 1)
			{
				throw new Exception();
			}
			if (num > 1)
			{
				for (int j = num; j < 5; j++)
				{
					num2 = checked(num2 + 84 * _0003_2006.m__0005[j]);
				}
				_0003_2006._0005(memoryStream, num2, 5 - num);
			}
			return memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	private static void _0005(Stream _0005, uint _0002, int _000F)
	{
		_0005.WriteByte((byte)(_0002 >> 24));
		if (_000F == 3)
		{
			return;
		}
		_0005.WriteByte((byte)(_0002 >> 16));
		if (_000F != 2)
		{
			_0005.WriteByte((byte)(_0002 >> 8));
			if (_000F != 1)
			{
				_0005.WriteByte((byte)_0002);
			}
		}
	}
}
internal sealed class _0003_2007
{
	private int m__0005;

	private int m__0002;

	private uint m__000F;

	private uint m__0006;

	private uint _0008;

	private uint _0003;

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

	public uint _0005()
	{
		return this.m__000F;
	}

	public void _0005(uint _0005)
	{
		this.m__000F = _0005;
	}

	public uint _0002()
	{
		return this.m__0006;
	}

	public void _0002(uint _0005)
	{
		this.m__0006 = _0005;
	}

	public uint _000F()
	{
		return _0008;
	}

	public void _000F(uint _0005)
	{
		_0008 = _0005;
	}

	public uint _0006()
	{
		return _0003;
	}

	public void _0006(uint _0005)
	{
		_0003 = _0005;
	}
}
internal abstract class _0003_2008
{
	private readonly SymmetricAlgorithm[] m__0005;

	public _0003_2008(byte[] _0005, long _0002)
		: this(_0005, _0003_2008._0005(_0002))
	{
	}

	public _0003_2008(byte[] _0005, byte[] _0002)
	{
		_000E_2009_200B obj = new _000E_2009_200B(_0005, _0002, 1);
		SymmetricAlgorithm[] array = new SymmetricAlgorithm[5];
		for (int i = 0; i < 5; i++)
		{
			_0002_200B obj2 = new _0002_200B(new _0003_2001());
			obj2.Key = obj.GetBytes(obj2.KeySize / 8);
			obj2.IV = obj.GetBytes(obj2._0005() / 8);
			array[i] = obj2;
		}
		this.m__0005 = array;
	}

	protected static int _0005(int _0005)
	{
		return (_0005 + 3) / 4 * 4;
	}

	public static int _0002(int _0005)
	{
		return _0003_2008._0005(_0005 + 4);
	}

	protected static byte[] _0005(long _0005)
	{
		byte[] array = new byte[8];
		_0003_2008._0005(_0005, array, 0);
		return array;
	}

	protected static void _0005(long _0005, byte[] _0002, int _000F)
	{
		_0002[_000F] = (byte)_0005;
		_0002[_000F + 1] = (byte)(_0005 >> 8);
		_0002[_000F + 2] = (byte)(_0005 >> 16);
		_0002[_000F + 3] = (byte)(_0005 >> 24);
		_0002[_000F + 4] = (byte)(_0005 >> 32);
		_0002[_000F + 5] = (byte)(_0005 >> 40);
		_0002[_000F + 6] = (byte)(_0005 >> 48);
		_0002[_000F + 7] = (byte)(_0005 >> 56);
	}

	protected static int _0005(byte[] _0005, int _0002)
	{
		return _0005[_0002] | (_0005[_0002 + 1] << 8) | (_0005[_0002 + 2] << 16) | (_0005[_0002 + 3] << 24);
	}

	protected static void _0005(int _0005, byte[] _0002, int _000F)
	{
		_0002[_000F] = (byte)_0005;
		_0002[_000F + 1] = (byte)(_0005 >> 8);
		_0002[_000F + 2] = (byte)(_0005 >> 16);
		_0002[_000F + 3] = (byte)(_0005 >> 24);
	}

	protected byte[] _0005(byte[] _0005, bool _0002)
	{
		if (_0002)
		{
			SymmetricAlgorithm[] array = this.m__0005;
			foreach (SymmetricAlgorithm symmetricAlgorithm in array)
			{
				if (_0002)
				{
					using ICryptoTransform cryptoTransform = symmetricAlgorithm.CreateEncryptor();
					_0005 = cryptoTransform.TransformFinalBlock(_0005, 0, _0005.Length);
				}
				else
				{
					using ICryptoTransform cryptoTransform2 = symmetricAlgorithm.CreateDecryptor();
					_0005 = cryptoTransform2.TransformFinalBlock(_0005, 0, _0005.Length);
				}
				_0002 = !_0002;
			}
		}
		else
		{
			for (int num = 4; num >= 0; num--)
			{
				SymmetricAlgorithm symmetricAlgorithm2 = this.m__0005[num];
				if (_0002)
				{
					using ICryptoTransform cryptoTransform3 = symmetricAlgorithm2.CreateEncryptor();
					_0005 = cryptoTransform3.TransformFinalBlock(_0005, 0, _0005.Length);
				}
				else
				{
					using ICryptoTransform cryptoTransform4 = symmetricAlgorithm2.CreateDecryptor();
					_0005 = cryptoTransform4.TransformFinalBlock(_0005, 0, _0005.Length);
				}
				_0002 = !_0002;
			}
		}
		return _0005;
	}
}
internal sealed class _0003_2009 : _0008_2009
{
	private _0005 m__0005;

	private string _0002;

	private bool _000F;

	public _0005 _0005()
	{
		return this.m__0005;
	}

	public void _0005(_0005 _0005)
	{
		this.m__0005 = _0005;
	}

	public string _0005()
	{
		return _0002;
	}

	public void _0005(string _0005)
	{
		_0002 = _0005;
	}

	public bool _0005()
	{
		return _000F;
	}

	public void _0005(bool _0005)
	{
		_000F = _0005;
	}

	[SpecialName]
	public override byte _0008_2009_2001_2004_2001_0005()
	{
		return 1;
	}
}
internal static class _0003_200A
{
	private static readonly bool m__0005;

	static _0003_200A()
	{
		try
		{
			_0003_200A.m__0005 = Type.GetType(_000F_0019._0005(-1057761837)) != null;
		}
		catch
		{
			_0003_200A.m__0005 = false;
		}
	}

	public static bool _0005()
	{
		return _0003_200A.m__0005;
	}
}
internal sealed class _0005
{
	private byte m__0005;

	private int _0002;

	private _0008_2009 _000F;

	public byte _0005()
	{
		return this.m__0005;
	}

	public void _0005(byte _0005)
	{
		this.m__0005 = _0005;
	}

	public int _0005()
	{
		return _0002;
	}

	public void _0005(int _0005)
	{
		_0002 = _0005;
	}

	public _0008_2009 _0005()
	{
		return _000F;
	}

	public void _0005(_0008_2009 _0005)
	{
		_000F = _0005;
	}
}
internal abstract class _0005_2000 : _0005_2009
{
	private new Type m__0005;

	public _0005_2000(int _0005)
		: base(_0005)
	{
	}

	public new Type _0005()
	{
		return this.m__0005;
	}

	public new void _0005(Type _0005)
	{
		this.m__0005 = _0005;
	}

	public abstract object _0005_2000_2001_2004_2001_0005();

	public abstract void _0005_2000_2001_2004_2001_0005(object _0005);

	public abstract bool _0005_2000_2001_2004_2001_0005(_0005_2000 _0005);
}
internal interface _0005_2001 : IDisposable
{
	int _0005_2001_2001_2004_2001_0005();

	void _0005_2001_2001_2004_2001_0005(int _0005, out byte _0002);

	void _0005_2001_2001_2004_2001_0002(int _0005, ref byte _0002);

	void _0005_2001_2001_2004_2001_0005();

	_0005_2001 _0005_2001_2001_2004_2001_0005();
}
internal sealed class _0005_2002 : _0005_2001, IDisposable
{
	private List<byte> m__0005 = new List<byte>();

	[SpecialName]
	public int _0005_2001_2001_2004_2001_0005()
	{
		return this.m__0005.Count;
	}

	public void _0005_2001_2001_2004_2001_0005()
	{
		this.m__0005.Clear();
	}

	public _0005_2001 _0005_2001_2001_2004_2001_0005()
	{
		return new _0005_2002();
	}

	public void Dispose()
	{
		this._0005_2001_2001_2004_2001_0005();
		this.m__0005 = null;
	}

	public void _0005_2001_2001_2004_2001_0005(int _0005, out byte _0002)
	{
		_0002 = this._0005(this.m__0005[_0005], _0005);
	}

	public void _0005_2001_2001_2004_2001_0002(int _0005, ref byte _0002)
	{
		int num = this.m__0005.Count;
		while (true)
		{
			if (num > _0005)
			{
				this.m__0005[_0005] = this._0002(_0002, _0005);
				return;
			}
			if (num == _0005)
			{
				break;
			}
			this.m__0005.Add(this._0002(0, num));
			num++;
		}
		this.m__0005.Add(this._0002(_0002, num));
	}

	private byte _0005(byte _0005, int _0002)
	{
		throw new NotImplementedException();
	}

	private byte _0002(byte _0005, int _0002)
	{
		throw new NotImplementedException();
	}
}
internal sealed class _0005_2003 : _0005_200A, IDisposable
{
	private sealed class _0005
	{
		public bool _0005;

		public _0005_200A _0002;
	}

	private readonly _0002_2006 m__0005;

	private readonly bool m__0002;

	private readonly bool _000F;

	private readonly int _0006;

	private readonly int _0008;

	private _0005 _0003;

	private bool _000E;

	private readonly object _0005_2009 = new object();

	public _0005_2003(bool _0005, _0002_2006 _0002, bool _000F = false)
	{
		this.m__0002 = _0005;
		this.m__0005 = _0002;
		this._000F = _000F;
		this._000F = true;
		int num = _0002._0005()._0005();
		_0006 = _0005_2003._0005(num, _0005);
		_0008 = _0005_2003._0002(num, _0005);
	}

	public bool _0005()
	{
		return this.m__0002;
	}

	[SpecialName]
	[CompilerGenerated]
	public int _0005_200A_2001_2004_2001_0005()
	{
		return _0006;
	}

	[SpecialName]
	[CompilerGenerated]
	public int _0005_200A_2001_2004_2001_0002()
	{
		return _0008;
	}

	private static int _0005(int _0005, bool _0002)
	{
		if (!_0002)
		{
			return (_0005 + 7) / 8;
		}
		return (_0005 - 1) / 8;
	}

	private static int _0002(int _0005, bool _0002)
	{
		if (!_0002)
		{
			return (_0005 - 1) / 8;
		}
		return (_0005 + 7) / 8;
	}

	public int _0005_200A_2001_2004_2001_0005(byte[] _0005, int _0002, int _000F, byte[] _0006, int _0008, RandomNumberGenerator _0003)
	{
		this._0002();
		_0005 obj = this._0003;
		try
		{
			return obj._0002._0005_200A_2001_2004_2001_0005(_0005, _0002, _000F, _0006, _0008, _0003);
		}
		catch when (obj._0005)
		{
			this._0005();
			obj = this._0003;
			return obj._0002._0005_200A_2001_2004_2001_0005(_0005, _0002, _000F, _0006, _0008, _0003);
		}
	}

	private void _0005()
	{
		lock (_0005_2009)
		{
			_0005 obj = _0003;
			if (!obj._0005)
			{
				return;
			}
			try
			{
				if (obj._0002 is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
			catch
			{
			}
			_0005_200A obj3 = _0005_2003_2001_2004_2001_0005(this.m__0002, this.m__0005);
			if (obj3 == null)
			{
				throw new InvalidOperationException();
			}
			_0003 = new _0005
			{
				_0005 = false,
				_0002 = obj3
			};
		}
	}

	private void _0002()
	{
		if (_000E)
		{
			return;
		}
		lock (_0005_2009)
		{
			if (_000E)
			{
				return;
			}
			_0005_200A obj;
			if (!_000F && (obj = _0005_2003_2001_2004_2001_0002(this.m__0002, this.m__0005)) != null)
			{
				_0003 = new _0005
				{
					_0005 = true,
					_0002 = obj
				};
			}
			else
			{
				obj = _0005_2003_2001_2004_2001_0005(this.m__0002, this.m__0005);
				if (obj == null)
				{
					throw new InvalidOperationException();
				}
				_0003 = new _0005
				{
					_0005 = false,
					_0002 = obj
				};
			}
			_000E = true;
		}
	}

	protected virtual _0005_200A _0005_2003_2001_2004_2001_0005(bool _0005, _0002_2006 _0002)
	{
		return new _0002_200A(_0005, _0002);
	}

	protected virtual _0005_200A _0005_2003_2001_2004_2001_0002(bool _0005, _0002_2006 _0002)
	{
		return _0008_2001._0005(_0005, _0002);
	}

	public void Dispose()
	{
		if (_0003?._0002 is IDisposable disposable)
		{
			disposable.Dispose();
			_0003 = null;
		}
	}
}
internal static class _0005_2004
{
	private static class _0005
	{
		public static readonly Dictionary<Type, int> _0005 = new Dictionary<Type, int>
		{
			{
				typeof(object),
				7
			},
			{
				typeof(byte),
				12
			},
			{
				typeof(sbyte),
				17
			},
			{
				typeof(short),
				26
			},
			{
				typeof(int),
				1
			},
			{
				typeof(long),
				13
			},
			{
				typeof(ushort),
				16
			},
			{
				typeof(uint),
				3
			},
			{
				typeof(ulong),
				14
			},
			{
				typeof(IntPtr),
				0
			},
			{
				typeof(UIntPtr),
				20
			},
			{
				typeof(float),
				22
			},
			{
				typeof(double),
				8
			},
			{
				typeof(bool),
				15
			},
			{
				typeof(char),
				6
			},
			{
				typeof(string),
				10
			}
		};
	}

	public static readonly Type _0005;

	public static readonly Type _0002;

	public static readonly Type _000F;

	public static readonly Type _0006;

	public static readonly Type _0008;

	public static readonly Assembly _0003;

	static _0005_2004()
	{
		_0005_2004._0005 = typeof(object);
		_0005_2004._0002 = typeof(ValueType);
		_000F = typeof(Enum);
		_0006 = typeof(Nullable<>);
		_0008 = typeof(void);
		_0003 = typeof(_0005_2004).Assembly;
	}

	public static bool _0005(Type _0005)
	{
		if (_0005.IsGenericType && !_0005.IsGenericTypeDefinition)
		{
			return _0005.GetGenericTypeDefinition() == _0006;
		}
		return false;
	}

	public static Type _0005(Type _0005)
	{
		while (_0005.HasElementType)
		{
			_0005 = _0005.GetElementType();
		}
		return _0005;
	}

	public static Type _0002(Type _0005)
	{
		if (_0005.HasElementType && !_0005.IsArray)
		{
			_0005 = _0005.GetElementType();
		}
		return _0005;
	}

	public static Stack<_000E_2002> _0005(Type _0005)
	{
		Stack<_000E_2002> stack = new Stack<_000E_2002>();
		Type type = _0005;
		while (true)
		{
			if (type.IsArray)
			{
				stack.Push(new _000E_2002
				{
					_0005 = 2,
					_0002 = type.GetArrayRank()
				});
			}
			else if (type.IsByRef)
			{
				stack.Push(new _000E_2002
				{
					_0005 = 1
				});
			}
			else
			{
				if (!type.IsPointer)
				{
					break;
				}
				stack.Push(new _000E_2002
				{
					_0005 = 0
				});
			}
			type = type.GetElementType();
		}
		return stack;
	}

	public static Stack<_000E_2002> _0005(string _0005)
	{
		string text = _0005;
		Stack<_000E_2002> stack = new Stack<_000E_2002>();
		while (true)
		{
			if (text.EndsWith(_000F_0019._0005(-1057760122), StringComparison.Ordinal))
			{
				stack.Push(new _000E_2002
				{
					_0005 = 1
				});
				text = text.Substring(0, text.Length - 1);
				continue;
			}
			if (text.EndsWith(_000F_0019._0005(-1057760114), StringComparison.Ordinal))
			{
				stack.Push(new _000E_2002
				{
					_0005 = 0
				});
				text = text.Substring(0, text.Length - 1);
				continue;
			}
			if (text.EndsWith(_000F_0019._0005(-1057760074), StringComparison.Ordinal))
			{
				stack.Push(new _000E_2002
				{
					_0005 = 2,
					_0002 = 1
				});
				text = text.Substring(0, text.Length - 2);
				continue;
			}
			if (!text.EndsWith(_000F_0019._0005(-1057760065), StringComparison.Ordinal))
			{
				break;
			}
			int num = 1;
			int num2 = -1;
			for (int num3 = text.Length - 2; num3 >= 0; num3--)
			{
				switch (text[num3])
				{
				case ',':
					num++;
					break;
				case '[':
					num2 = num3;
					num3 = -1;
					break;
				default:
					throw new InvalidOperationException(_000F_0019._0005(-1057760092));
				}
			}
			if (num2 < 0)
			{
				throw new InvalidOperationException(_000F_0019._0005(-1057760042));
			}
			text = text.Substring(0, num2);
			stack.Push(new _000E_2002
			{
				_0005 = 2,
				_0002 = num
			});
		}
		return stack;
	}

	public static Type _0005(Type _0005, Stack<_000E_2002> _0002)
	{
		Type type = _0005;
		while (_0002.Count > 0)
		{
			_000E_2002 obj = _0002.Pop();
			switch (obj._0005)
			{
			case 2:
				type = ((obj._0002 != 1) ? type.MakeArrayType(obj._0002) : type.MakeArrayType());
				break;
			case 1:
				type = type.MakeByRefType();
				break;
			case 0:
				type = type.MakePointerType();
				break;
			}
		}
		return type;
	}

	public static int _0005(Type _0005)
	{
		if (_0005_2004._0005._0005.TryGetValue(_0005, out var value))
		{
			return value;
		}
		if (_0005.IsArray)
		{
			return 9;
		}
		if (_0005.IsValueType)
		{
			if (_0005.IsSubclassOf(_000F))
			{
				return 19;
			}
			if (_0005_2004._0005(_0005))
			{
				return 5;
			}
			return 25;
		}
		return 4;
	}
}
internal sealed class _0005_2005
{
	private int m__0005;

	private bool _0002;

	public int _0005()
	{
		return this.m__0005;
	}

	public void _0005(int _0005)
	{
		this.m__0005 = _0005;
	}

	public bool _0005()
	{
		return _0002;
	}

	public void _0005(bool _0005)
	{
		_0002 = _0005;
	}
}
internal sealed class _0005_2006 : _0008_2009
{
	private int m__0005;

	private int m__0002;

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

	[SpecialName]
	public override byte _0008_2009_2001_2004_2001_0005()
	{
		return 3;
	}
}
internal static class _0005_2007
{
	private static readonly _000F_2007 m__0005;

	private static readonly byte[] _0002;

	private static _0005_2003 _000F;

	private static readonly object _0006;

	private static bool _0008;

	static _0005_2007()
	{
		_0005_2007.m__0005 = _000F_2007._0002(65537uL);
		_0002 = _0005();
		_0006 = new object();
	}

	private static void _0005()
	{
		if (_0008)
		{
			return;
		}
		lock (_0006)
		{
			if (!_0008)
			{
				_000F_2007 obj = new _000F_2007(1, _0002);
				_0002_2006 obj2 = new _0002_2006(_0005: false, obj, _0005_2007.m__0005);
				_000F = new _0005_2003(_0005: true, obj2);
				_0008 = true;
			}
		}
	}

	private static byte[] _0005()
	{
		return null;
	}

	public static bool _0005(object _0005, byte[] _0002, ulong _000F, int _0006)
	{
		if (_0002 == null)
		{
			return false;
		}
		if (_0005_2007._0005(_0005))
		{
			return _0006 switch
			{
				1 => throw new ArgumentNullException(_000F_0019._0005(-1057760011)), 
				2 => throw new NullReferenceException(_000F_0019._0005(-1057760011)), 
				0 => false, 
				_ => throw new ArgumentOutOfRangeException(_000F_0019._0005(-1057760007)), 
			};
		}
		_0005_2007._0005();
		byte[] array = _0008_2003._0005(_0005, _000F, _0005_2007._000F, null);
		return _0005_2007._0005(_0002, array);
	}

	private static bool _0005(byte[] _0005, byte[] _0002)
	{
		if (_0005.Length != _0002.Length)
		{
			return false;
		}
		for (int i = 0; i < _0005.Length; i++)
		{
			if (_0005[i] != _0002[i])
			{
				return false;
			}
		}
		return true;
	}

	public static byte[] _0005(object[] _0005, byte[] _0002, ulong _000F)
	{
		if (_0005 == null)
		{
			throw new ArgumentNullException(_000F_0019._0005(-1057760240));
		}
		if (_0002 == null)
		{
			throw new ArgumentNullException(_000F_0019._0005(-1057760249));
		}
		byte[] array2;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			for (int i = 0; i < _0005.Length; i++)
			{
				byte[] array = _0008_2003._0005(_0005[i]);
				memoryStream.Write(array, 0, array.Length);
			}
			array2 = memoryStream.ToArray();
		}
		return new _000E_2008(array2, (long)_000F)._0005(_0002);
	}

	internal static bool _0005(object _0005)
	{
		if (_0005 == null)
		{
			return true;
		}
		if (!(_0005 is string) && _0005 is IEnumerable enumerable)
		{
			foreach (object item in enumerable)
			{
				if (_0005_2007._0005(item))
				{
					return true;
				}
			}
		}
		return false;
	}
}
internal sealed class _0005_2008 : _000F
{
	private new UIntPtr m__0005;

	public _0005_2008()
		: base(20)
	{
	}

	public new UIntPtr _0005()
	{
		return this.m__0005;
	}

	public void _0005(UIntPtr _0005)
	{
		this.m__0005 = _0005;
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0005_2008 obj = new _0005_2008();
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
		this._0005((UIntPtr)_0005);
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		switch (_0005._0005())
		{
		case 20:
			this._0005(((_0005_2008)_0005)._0005());
			break;
		case 12:
			this._0005((UIntPtr)((_0002_2009_200B)_0005)._0005());
			break;
		case 1:
			this._0005((UIntPtr)(ulong)((_0006)_0005)._0005());
			break;
		case 16:
			this._0005((UIntPtr)((_0008_200A)_0005)._0005());
			break;
		case 3:
			this._0005((UIntPtr)((_0006_200B)_0005)._0005());
			break;
		case 13:
			this._0005((UIntPtr)(ulong)((_0003_2003)_0005)._0005());
			break;
		case 14:
			this._0005((UIntPtr)((_000E_2005)_0005)._0005());
			break;
		case 7:
			this._0005((UIntPtr)((_0008_2008)_0005)._0005());
			break;
		case 22:
			this._0005((UIntPtr)(ulong)((_0006_2000)_0005)._0005());
			break;
		case 19:
			this._0005(new UIntPtr(Convert.ToUInt64(((_0005_0019)_0005)._0005())));
			break;
		case 8:
			this._0005((UIntPtr)(ulong)((_000F_2006)_0005)._0005());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal abstract class _0005_2009 : _000F
{
	public _0005_2009(int _0005)
		: base(_0005)
	{
	}

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		throw new InvalidOperationException();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		throw new InvalidOperationException();
	}
}
internal interface _0005_200A
{
	int _0005_200A_2001_2004_2001_0005();

	int _0005_200A_2001_2004_2001_0002();

	int _0005_200A_2001_2004_2001_0005(byte[] _0005, int _0002, int _000F, byte[] _0006, int _0008, RandomNumberGenerator _0003);
}
internal sealed class _0006 : _000F
{
	private new int m__0005;

	public _0006()
		: base(1)
	{
	}

	public _0006(int _0005)
		: this()
	{
		this.m__0005 = _0005;
	}

	public new int _0005()
	{
		return this.m__0005;
	}

	public void _0005(int _0005)
	{
		this.m__0005 = _0005;
	}

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		return _0005();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		int num2;
		if (_0005 is ushort num)
		{
			num2 = num;
		}
		else if (_0005 is uint num3)
		{
			num2 = (int)num3;
		}
		else if (_0005 is long num4)
		{
			num2 = (int)num4;
		}
		else if (_0005 is ulong num5)
		{
			num2 = (int)num5;
		}
		else if (_0005 is float num6)
		{
			num2 = (int)num6;
		}
		else
		{
			num2 = ((!(_0005 is double num7)) ? Convert.ToInt32(_0005) : ((int)num7));
		}
		this._0005(num2);
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0006 obj = new _0006();
		obj._0005(this.m__0005);
		obj._0005(base._0005());
		return obj;
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		this._0005(_0005._0005() switch
		{
			15 => Convert.ToByte(((_0008_2006)_0005)._0005()), 
			12 => ((_0002_2009_200B)_0005)._0005(), 
			26 => ((_000E_2001)_0005)._0005(), 
			1 => ((_0006)_0005)._0005(), 
			17 => ((_0003_200B)_0005)._0005(), 
			16 => ((_0008_200A)_0005)._0005(), 
			13 => Convert.ToInt32(((_0003_2003)_0005)._0005()), 
			19 => Convert.ToInt32(((_0005_0019)_0005)._0005()), 
			7 => Convert.ToInt32(((_0008_2008)_0005)._0005()), 
			0 => (int)((_000F_2002)_0005)._0005(), 
			20 => (int)(uint)((_0005_2008)_0005)._0005(), 
			22 => (int)((_0006_2000)_0005)._0005(), 
			8 => (int)((_000F_2006)_0005)._0005(), 
			14 => (int)((_000E_2005)_0005)._0005(), 
			3 => (int)((_0006_200B)_0005)._0005(), 
			_ => throw new ArgumentOutOfRangeException(), 
		});
		return this;
	}
}
internal sealed class _0006_2000 : _000F
{
	private new float m__0005;

	public _0006_2000()
		: base(22)
	{
	}

	public new float _0005()
	{
		return this.m__0005;
	}

	public void _0005(float _0005)
	{
		this.m__0005 = _0005;
	}

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		return _0005();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		this._0005(Convert.ToSingle(_0005));
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0006_2000 obj = new _0006_2000();
		obj._0005(this.m__0005);
		obj._0005(base._0005());
		return obj;
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		switch (_0005._0005())
		{
		case 22:
			this._0005(((_0006_2000)_0005)._0005());
			break;
		case 12:
			this._0005((int)((_0002_2009_200B)_0005)._0005());
			break;
		case 26:
			this._0005(((_000E_2001)_0005)._0005());
			break;
		case 1:
			this._0005(((_0006)_0005)._0005());
			break;
		case 13:
			this._0005(((_0003_2003)_0005)._0005());
			break;
		case 17:
			this._0005(((_0003_200B)_0005)._0005());
			break;
		case 16:
			this._0005((int)((_0008_200A)_0005)._0005());
			break;
		case 3:
			this._0005(((_0006_200B)_0005)._0005());
			break;
		case 14:
			this._0005(((_000E_2005)_0005)._0005());
			break;
		case 8:
			this._0005((float)((_000F_2006)_0005)._0005());
			break;
		case 19:
			this._0005(Convert.ToSingle(((_0005_0019)_0005)._0005()));
			break;
		case 7:
			this._0005((float)((_0008_2008)_0005)._0005());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal static class _0006_2001
{
	public static int _0005(int _0005)
	{
		return _0005 & -16777216;
	}
}
internal static class _0006_2002
{
	private static readonly _000F_2007 m__0005;

	private static readonly _0008_2000 _0002;

	static _0006_2002()
	{
		_0006_2002.m__0005 = _000F_2007._0002(65537uL);
		_0002 = new _0008_2000();
	}

	public static Stream _0005(Stream _0005, byte[] _0002, string _000F)
	{
		byte[] array = Convert.FromBase64String(_000F);
		byte[] array2 = new byte[_0002.Length + array.Length];
		Buffer.BlockCopy(_0002, 0, array2, 0, _0002.Length);
		Buffer.BlockCopy(array, 0, array2, _0002.Length, array.Length);
		_000F_2007 obj = new _000F_2007(1, array2);
		_0002_2006 obj2 = new _0002_2006(_0005: false, obj, _0006_2002.m__0005);
		_0002_2004 obj3 = new _0002_2004(new _0005_2003(_0005: false, obj2));
		_000F_2009_200B obj4 = new _000F_2009_200B();
		obj4._0005(obj3._0005_200A_2001_2004_2001_0002());
		_000F_2009_200B obj5 = obj4;
		return new _000F_2008(new _0008_2009_200B(_0005, obj3), obj5, _0006_2002._0002);
	}
}
internal struct _0006_2003
{
	private int m__0005;

	private readonly byte _0002;

	public _0006_2003(int _0005, byte _0002)
	{
		this._0005(_0005);
		this._0002 = _0002;
	}

	[_0002_2003]
	public int _0005()
	{
		return this.m__0005;
	}

	public void _0005(int _0005)
	{
		this.m__0005 = _0005;
	}

	[_0002_2003]
	public byte _0005()
	{
		return _0002;
	}

	public override bool Equals(object _0005)
	{
		if (_0005 is _0006_2003 obj)
		{
			return this._0005(obj);
		}
		return false;
	}

	public bool _0005(_0006_2003 _0005)
	{
		return _0005._0005() == this._0005();
	}

	public static bool operator ==(_0006_2003 _0005, _0006_2003 _0002)
	{
		return _0005._0005(_0002);
	}

	public static bool operator !=(_0006_2003 _0005, _0006_2003 _0002)
	{
		return !(_0005 == _0002);
	}

	public override int GetHashCode()
	{
		return this._0005().GetHashCode();
	}

	public override string ToString()
	{
		return this._0005().ToString();
	}
}
internal static class _0006_2004
{
	public struct _0002
	{
		public uint _0005;

		public int _0002;

		public int _000F;

		public int _0006;

		public int _0008;

		public int _0003;
	}

	[SecurityCritical]
	public sealed class _0005 : SafeHandleZeroOrMinusOneIsInvalid
	{
		public override bool IsInvalid => handle == IntPtr.Zero;

		public _0005()
			: base(ownsHandle: true)
		{
		}

		protected override bool ReleaseHandle()
		{
			return _0005(handle) == 0;
		}
	}

	[SecurityCritical]
	public sealed class _000F : SafeHandleZeroOrMinusOneIsInvalid
	{
		public override bool IsInvalid => handle == IntPtr.Zero;

		public _000F()
			: base(ownsHandle: true)
		{
		}

		protected override bool ReleaseHandle()
		{
			return _0005(handle) == 0;
		}
	}

	public static void _0005(uint _0005)
	{
		if (_0005 != 0)
		{
			uint num = _0005;
			throw new InvalidOperationException(num.ToString());
		}
	}

	[DllImport("ncrypt.dll", EntryPoint = "NCryptFreeObject")]
	public static extern uint _0005(IntPtr _0005);

	[DllImport("ncrypt.dll", EntryPoint = "NCryptEncrypt")]
	public static extern uint _0005(_000F _0005, [MarshalAs(UnmanagedType.LPArray)] byte[] _0002, int _000F, IntPtr _0006, [MarshalAs(UnmanagedType.LPArray)] byte[] _0008, int _0003, out int _000E, int _0005_2009);

	[DllImport("ncrypt.dll", CharSet = CharSet.Unicode, EntryPoint = "NCryptImportKey")]
	public static extern uint _0005(_0005 _0005, IntPtr _0002, string _000F, IntPtr _0006, out _000F _0008, [MarshalAs(UnmanagedType.LPArray)] byte[] _0003, int _000E, uint _0005_2009);

	[DllImport("ncrypt.dll", CharSet = CharSet.Unicode, EntryPoint = "NCryptOpenStorageProvider")]
	public static extern uint _0005(out _0005 _0005, string _0002, uint _000F);
}
internal sealed class _0006_2005 : _0005_2009
{
	private new _000F m__0005;

	public _0006_2005()
		: base(2)
	{
	}

	public new _000F _0005()
	{
		return this.m__0005;
	}

	public void _0005(_000F _0005)
	{
		this.m__0005 = _0005;
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		if (_0005._0005() == 2)
		{
			this._0005(((_0006_2005)_0005)._0005());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0006_2005 obj = new _0006_2005();
		obj._0005(_0005());
		obj._0005(((_000F)this)._0005());
		return obj;
	}
}
internal sealed class _0006_2006
{
	private sealed class _0005
	{
		public byte[] _0005;

		public bool _0002;

		public _0005()
		{
		}

		public _0005(byte[] _0005, int _0002, int _000F, bool _0006)
		{
			this._0005(_0005, _0002, _000F, _0006);
		}

		public void _0005(byte[] _0005, int _0002, int _000F, bool _0006)
		{
			this._0005 = new byte[_000F];
			Buffer.BlockCopy(_0005, _0002, this._0005, 0, _000F);
			this._0002 = _0006;
		}
	}

	private readonly object m__0005 = new object();

	private _0005_200B[] m__0002;

	private Dictionary<int, _0005_200B> m__000F;

	private volatile bool _0006;

	private _000F_2009_200B _0008;

	private Dictionary<int, WeakReference> _0003;

	private object _000E;

	private int _0005_2009;

	private object[] _0002_2009;

	private int _000F_2009;

	public _0006_2006(_000F_2009_200B _0005)
	{
		_0008 = _0005;
	}

	private void _0005()
	{
		if (_0006)
		{
			return;
		}
		lock (this.m__0005)
		{
			if (!_0006)
			{
				this.m__0002 = new _0005_200B[_0008._000F()];
				for (int i = 0; i < _0008._000F(); i++)
				{
					this.m__0002[i] = new _0005_200B();
				}
				this.m__000F = new Dictionary<int, _0005_200B>();
				_0003 = new Dictionary<int, WeakReference>();
				_000E = new object();
				_0005_2009 = _0008._0006();
				_0002_2009 = new object[_0008._0008()];
				_0006 = true;
			}
		}
	}

	public void _0005(_0005_200B _0005)
	{
		this._0005();
		lock (this.m__0005)
		{
			if (this.m__000F.TryGetValue(_0005._0002, out var value) && value != null)
			{
				value._0006 = _0005._0006;
				return;
			}
			int num = 0;
			DateTime dateTime = this.m__0002[0]._0006;
			for (int i = 1; i < _0008._000F(); i++)
			{
				if (this.m__0002[i]._0006 < dateTime)
				{
					num = i;
				}
			}
			value = this.m__0002[num];
			if (value._0005 == null)
			{
				value._0005 = new byte[_0008._0005()];
			}
			else
			{
				this.m__000F[value._0002] = null;
			}
			this._0005(_0005, value);
			this.m__000F[value._0002] = value;
			if (this.m__000F.Count > _0008._000F() * 2)
			{
				_0002();
			}
		}
	}

	private void _0002()
	{
		Dictionary<int, _0005_200B> dictionary = this.m__000F;
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, _0005_200B> item in dictionary)
		{
			if (item.Value == null)
			{
				list.Add(item.Key);
			}
		}
		foreach (int item2 in list)
		{
			dictionary.Remove(item2);
		}
	}

	public bool _0005(int _0005, ref _0005_200B _0002)
	{
		if (!_0006)
		{
			return false;
		}
		lock (this.m__0005)
		{
			if (this.m__000F.TryGetValue(_0005, out var value) && value != null)
			{
				this._0005(value, _0002);
				return true;
			}
		}
		return false;
	}

	private void _0005(_0005_200B _0005, _0005_200B _0002)
	{
		_0005._0006 = DateTime.UtcNow;
		_0002._0002 = _0005._0002;
		_0002._000F = _0005._000F;
		_0002._0006 = _0005._0006;
		Buffer.BlockCopy(_0005._0005, 0, _0002._0005, 0, _0008._0005());
	}

	private void _0005(object _0005)
	{
		for (int i = 0; i < _0002_2009.Length; i++)
		{
			if (_0002_2009[i] == _0005)
			{
				return;
			}
		}
		_0002_2009[_000F_2009] = _0005;
		_000F_2009++;
		if (_000F_2009 == _0002_2009.Length)
		{
			_000F_2009 = 0;
		}
	}

	private void _000F()
	{
		if (_0003.Count < _0005_2009)
		{
			return;
		}
		Dictionary<int, WeakReference> dictionary = new Dictionary<int, WeakReference>();
		foreach (KeyValuePair<int, WeakReference> item in _0003)
		{
			if (item.Value.IsAlive)
			{
				dictionary.Add(item.Key, item.Value);
			}
		}
		_0003 = dictionary;
		_0005_2009 = Math.Max(dictionary.Count * 2, 10);
	}

	public void _0005(int _0005, byte[] _0002, int _000F, int _0006, bool _0008)
	{
		this._0005();
		lock (_000E)
		{
			_0005 obj;
			if (_0003.TryGetValue(_0005, out var value))
			{
				obj = value.Target as _0005;
				if (obj != null)
				{
					if (obj._0005.Length < _0006)
					{
						obj._0005(_0002, _000F, _0006, _0008);
					}
					goto IL_0074;
				}
			}
			this._000F();
			obj = new _0005(_0002, _000F, _0006, _0008);
			_0003[_0005] = new WeakReference(obj);
			goto IL_0074;
			IL_0074:
			this._0005(obj);
		}
	}

	public bool _0005(int _0005, byte[] _0002, int _000F, int _0006, out int _0008)
	{
		_0008 = 0;
		if (!this._0006)
		{
			return false;
		}
		lock (_000E)
		{
			if (!_0003.TryGetValue(_0005, out var value))
			{
				return false;
			}
			if (!(value.Target is _0005 obj))
			{
				return false;
			}
			int num = obj._0005.Length;
			_0008 = _0006;
			if (num < _0006)
			{
				if (!obj._0002)
				{
					return false;
				}
				_0008 = num;
			}
			Buffer.BlockCopy(obj._0005, 0, _0002, _000F, _0008);
			this._0005(obj);
			return true;
		}
	}
}
internal static class _0006_2007
{
	public static bool _0005(int[] _0005, int[] _0002)
	{
		if (_0005 == _0002)
		{
			return true;
		}
		if (_0005 == null || _0002 == null)
		{
			return false;
		}
		if (_0005.Length != _0002.Length)
		{
			return false;
		}
		for (int i = 0; i < _0005.Length; i++)
		{
			if (_0005[i] != _0002[i])
			{
				return false;
			}
		}
		return true;
	}
}
internal static class _0006_2008
{
	private static volatile int m__0005;

	private static volatile int _0002;

	public static void _0005(ref byte _0005)
	{
		_0005 = (byte)_0006_2008.m__0005;
		_0002 = _0005;
	}

	public static void _0005(ref int _0005)
	{
		_0005 = _0006_2008.m__0005;
		_0002 = _0005;
	}

	public static void _0005(ref long _0005)
	{
		_0005 = _0006_2008.m__0005;
		_0002 = (int)_0005;
	}

	public static void _0005(ref char _0005)
	{
		_0005 = (char)_0006_2008.m__0005;
		_0002 = _0005;
	}

	public static void _0005(Array _0005, int _0002, int _000F)
	{
		Array.Clear(_0005, _0002, _000F);
	}

	public static void _0005(Array _0005)
	{
		_0006_2008._0005(_0005, 0, _0005.GetLength(0));
	}
}
internal static class _0006_2009
{
	private static uint _0005(uint _0005, uint _0002, uint _000F, int _0006, uint _0008, uint[] _0003)
	{
		return (((_000F >> 5) ^ (_0002 << 2)) + ((_0002 >> 3) ^ (_000F << 4))) ^ ((_0005 ^ _0002) + (_0003[(_0006 & 3) ^ _0008] ^ _000F));
	}

	public static void _0005(byte[] _0005, int _0002, int _000F, byte[] _0006)
	{
		if (_0005.Length != 0 && _0005.Length != 0)
		{
			if (_0002 + _000F > _0005.Length || _000F % 4 != 0 || _000F < 8)
			{
				throw new ArgumentException(_000F_0019._0005(-1057761863));
			}
			if (_0006 == null || _0006.Length > 16)
			{
				throw new ArgumentNullException(_000F_0019._0005(-1057761876));
			}
			uint[] array = new uint[_000F / 4];
			_0006_2009._0005(_0005, _0002, _000F, array, 0);
			uint[] array2 = new uint[4];
			_0006_2009._0005(_0006, 0, _0006.Length, array2, 0);
			_0006_2009._0005(array, array2);
			_0006_2009._0005(array, 0, array.Length, _0005, _0002);
		}
	}

	private static void _0005(uint[] _0005, uint[] _0002)
	{
		int num = _0005.Length - 1;
		if (num < 1)
		{
			return;
		}
		uint num2 = _0005[num];
		uint num3 = 0u;
		int num4 = 6 + 52 / (num + 1);
		while (0 < num4--)
		{
			num3 += 2654435769u;
			uint num5 = (num3 >> 2) & 3;
			int i;
			uint num6;
			for (i = 0; i < num; i++)
			{
				num6 = _0005[i + 1];
				num2 = (_0005[i] += _0006_2009._0005(num3, num6, num2, i, num5, _0002));
			}
			num6 = _0005[0];
			num2 = (_0005[num] += _0006_2009._0005(num3, num6, num2, i, num5, _0002));
		}
	}

	private static uint[] _0005(byte[] _0005, int _0002, int _000F, uint[] _0006, int _0008)
	{
		if (_0002 + _000F > _0005.Length)
		{
			throw new ArgumentException();
		}
		int num = _000F / 4;
		if (_0008 + num > _0006.Length)
		{
			throw new ArgumentException();
		}
		int num2 = _0002 + _000F;
		for (int i = _0002; i < num2; i += 4)
		{
			_0006[_0008 + (i - _0002) / 4] = (uint)(_0005[i] | (_0005[i + 1] << 8) | (_0005[i + 2] << 16) | (_0005[i + 3] << 24));
		}
		return _0006;
	}

	private static void _0005(uint[] _0005, int _0002, int _000F, byte[] _0006, int _0008)
	{
		if (_0002 + _000F > _0005.Length)
		{
			throw new ArgumentException();
		}
		int num = _000F * 4;
		if (_0008 + num > _0006.Length)
		{
			throw new ArgumentException();
		}
		int num2 = _0008 + num;
		for (int i = _0008; i < num2; i += 4)
		{
			uint num3 = _0005[(i - _0008) / 4 + _0002];
			_0006[i] = (byte)num3;
			_0006[i + 1] = (byte)(num3 >> 8);
			_0006[i + 2] = (byte)(num3 >> 16);
			_0006[i + 3] = (byte)(num3 >> 24);
		}
	}
}
[_0002_2003]
internal struct _0006_200A(int _0005)
{
	public readonly int _0005 = _0005;
}
internal abstract class _0008 : IDisposable
{
	public abstract bool _0008_2001_2004_2001_0005();

	public abstract bool _0008_2001_2004_2001_0002();

	public abstract bool _0008_2001_2004_2001_000F();

	public abstract long _0008_2001_2004_2001_0005();

	public abstract long _0008_2001_2004_2001_0002();

	public abstract void _0008_2001_2004_2001_0005(long _0005);

	public virtual void _0008_2001_2004_2001_0005()
	{
		_0008_2001_2004_2001_0005(_0005: true);
		GC.SuppressFinalize(this);
	}

	public void Dispose()
	{
		this._0008_2001_2004_2001_0005();
	}

	protected virtual void _0008_2001_2004_2001_0005(bool _0005)
	{
	}

	public abstract void _0008_2001_2004_2001_0002();

	public abstract long _0008_2001_2004_2001_0005(long _0005, int _0002);

	public abstract void _0008_2001_2004_2001_0002(long _0005);

	public abstract int _0008_2001_2004_2001_0005(byte[] _0005, int _0002, int _000F);

	public virtual int _0008_2001_2004_2001_0005()
	{
		byte[] array = new byte[1];
		if (this._0008_2001_2004_2001_0005(array, 0, 1) == 0)
		{
			return -1;
		}
		return array[0];
	}

	public abstract void _0008_2001_2004_2001_0005(byte[] _0005, int _0002, int _000F);

	public virtual void _0008_2001_2004_2001_0005(byte _0005)
	{
		this._0008_2001_2004_2001_0005(new byte[1] { _0005 }, 0, 1);
	}
}
internal sealed class _0008_2000
{
	private object m__0005 = new object();

	private Dictionary<_000F_2009_200B, _0006_2006> _0002;

	internal _0006_2006 _0005(_000F_2009_200B _0005)
	{
		if (_0005 == null)
		{
			throw new ArgumentNullException();
		}
		lock (this.m__0005)
		{
			if (_0002 == null)
			{
				_0002 = new Dictionary<_000F_2009_200B, _0006_2006>();
			}
			if (!_0002.TryGetValue(_0005, out var value))
			{
				value = new _0006_2006(_0005);
				_0002[_0005] = value;
			}
			return value;
		}
	}
}
internal sealed class _0008_2001 : _0005_200A, IDisposable
{
	private static bool m__0005;

	protected _0006_2004._0005 _0002;

	protected _0006_2004._000F _000F;

	protected int _0006;

	private int _0008;

	private int _0003;

	private byte[] _000E;

	private byte[] _0005_2009;

	private bool _0002_2009;

	protected _0008_2001(bool _0005, _0002_2006 _0002)
	{
		if (_0002 == null)
		{
			throw new ArgumentNullException(_000F_0019._0005(-1057761842));
		}
		int num = _0002._0005()._0005();
		_0006 = _0008_2001._0005(num);
		this._0005(_0008_2001._0005(num, _0005));
		this._0002(_0008_2001._0002(num, _0005));
		_0006_2004._0005(_0006_2004._0005(out this._0002, _000F_0019._0005(-1057762786), 0u));
		byte[] array = _0008_2001_2001_2004_2001_0005(_0002, out var text);
		_0006_2004._0005(_0006_2004._0005(this._0002, IntPtr.Zero, text, IntPtr.Zero, out _000F, array, array.Length, 64u));
	}

	static _0008_2001()
	{
		_0008_2001.m__0005 = true;
	}

	public static _0008_2001 _0005(bool _0005, _0002_2006 _0002)
	{
		if (!_0008_2001.m__0005)
		{
			return null;
		}
		if (!_0003_2002._0002())
		{
			_0008_2001.m__0005 = false;
			return null;
		}
		_0008_2001 obj = null;
		try
		{
			obj = new _0008_2001(_0005, _0002);
			return obj;
		}
		catch
		{
			obj?.Dispose();
			_0008_2001.m__0005 = false;
			return null;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public int _0005_200A_2001_2004_2001_0005()
	{
		return _0008;
	}

	private void _0005(int _0005)
	{
		_0008 = _0005;
	}

	[SpecialName]
	[CompilerGenerated]
	public int _0005_200A_2001_2004_2001_0002()
	{
		return _0003;
	}

	private void _0002(int _0005)
	{
		_0003 = _0005;
	}

	private static int _0005(int _0005, bool _0002)
	{
		if (!_0002)
		{
			return (_0005 + 7) / 8;
		}
		return (_0005 - 1) / 8;
	}

	private static int _0002(int _0005, bool _0002)
	{
		if (!_0002)
		{
			return (_0005 - 1) / 8;
		}
		return (_0005 + 7) / 8;
	}

	private static int _0005(int _0005)
	{
		return (_0005 + 7) / 8;
	}

	private void _0005()
	{
		if (!_0002_2009)
		{
			_000E = new byte[_0006];
			_0005_2009 = new byte[_0006];
			_0002_2009 = true;
		}
	}

	public virtual int _0005_200A_2001_2004_2001_0005(byte[] _0005, int _0002, int _000F, byte[] _0006, int _0008, RandomNumberGenerator _0003)
	{
		this._0005();
		byte[] array = _000E;
		int num = array.Length - _000F;
		if (num > 0)
		{
			Array.Clear(array, 0, num);
		}
		Buffer.BlockCopy(_0005, _0002, array, num, _000F);
		_0006_2004._0005(_0006_2004._0005(this._000F, array, array.Length, IntPtr.Zero, _0005_2009, this._0006, out var num2, 1));
		int num3 = _0005_200A_2001_2004_2001_0002();
		int srcOffset = num2 - num3;
		Buffer.BlockCopy(_0005_2009, srcOffset, _0006, _0008, num3);
		return num3;
	}

	protected virtual byte[] _0008_2001_2001_2004_2001_0005(_0002_2006 _0005, out string _0002)
	{
		_0002 = _000F_0019._0005(-1057762784);
		return _0008_2001._0005(_0005);
	}

	protected static byte[] _0005(_0002_2006 _0005)
	{
		int num = Marshal.SizeOf(typeof(_0006_2004._0002));
		byte[] array = new byte[num + _0005._0002()._0006() + _0005._0005()._0006()];
		_0008_2001._0005(new _0006_2004._0002
		{
			_0005 = 826364754u,
			_0002 = _0005._0005()._0005(),
			_000F = _0005._0002()._0006(),
			_0006 = _0005._0005()._0006()
		}, array, 0);
		int num2 = num;
		num2 += _0005._0002()._0005(array, num2);
		num2 += _0005._0005()._0005(array, num2);
		return array;
	}

	protected static void _0005(_0006_2004._0002 _0005, byte[] _0002, int _000F)
	{
		int num = Marshal.SizeOf((object)_0005);
		if (_000F + num > _0002.Length)
		{
			throw new ArgumentException(_000F_0019._0005(-1057762724));
		}
		try
		{
		}
		finally
		{
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr((object)_0005, intPtr, false);
			Marshal.Copy(intPtr, _0002, _000F, num);
			Marshal.DestroyStructure(intPtr, typeof(_0006_2004._0002));
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public void Dispose()
	{
		if (this._0002 != null)
		{
			this._0002.Dispose();
			this._0002 = null;
		}
		if (_000F != null)
		{
			_000F.Dispose();
			_000F = null;
		}
	}
}
internal sealed class _0008_2002 : _0008_2009
{
	private string m__0005;

	private bool m__0002;

	private bool _000F;

	private _0005[] _0006 = new _0005[0];

	private int _0008 = -1;

	private int _0003 = -1;

	public string _0005()
	{
		return this.m__0005;
	}

	public void _0005(string _0005)
	{
		this.m__0005 = _0005;
	}

	public bool _0005()
	{
		return this.m__0002;
	}

	public void _0005(bool _0005)
	{
		this.m__0002 = _0005;
	}

	public bool _0002()
	{
		return _000F;
	}

	public void _0002(bool _0005)
	{
		_000F = _0005;
	}

	public _0005[] _0005()
	{
		return _0006;
	}

	public void _0005(_0005[] _0005)
	{
		_0006 = _0005;
	}

	public int _0005()
	{
		return _0008;
	}

	public void _0005(int _0005)
	{
		_0008 = _0005;
	}

	public int _0002()
	{
		return _0003;
	}

	public void _0002(int _0005)
	{
		_0003 = _0005;
	}

	[SpecialName]
	public override byte _0008_2009_2001_2004_2001_0005()
	{
		return 2;
	}
}
internal static class _0008_2003
{
	public static byte[] _0005(object _0005, ulong _0002, _0005_200A _000F, RandomNumberGenerator _0006)
	{
		return _0008_2003._0005(_0008_2003._0005(_0005), _0008_2003._0005(_0002), _000F, _0006);
	}

	public static byte[] _0005(byte[] _0005, byte[] _0002, _0005_200A _000F, RandomNumberGenerator _0006)
	{
		int num = _0005.Length;
		if (num == 0)
		{
			throw new ArgumentException();
		}
		int num2 = _000F._0005_200A_2001_2004_2001_0005();
		int num3 = _000F._0005_200A_2001_2004_2001_0002();
		int num4 = num % num2;
		int num5 = (num + (num2 - 1)) / num2;
		byte[] array;
		if (num4 == 0)
		{
			array = new byte[num];
			Buffer.BlockCopy(_0005, 0, array, 0, num);
		}
		else
		{
			int num6 = _0008_2003._0005(num4);
			byte[] bytes = new _000E_2009_200B(_0005, _0002, num6).GetBytes(num2);
			if (num5 == 1)
			{
				array = bytes;
			}
			else
			{
				array = new byte[num2 * num5];
				Buffer.BlockCopy(bytes, 0, array, num2 * (num5 - 1), num2);
			}
			Buffer.BlockCopy(_0005, 0, array, 0, _0005.Length);
		}
		_0006_2009._0005(array, 0, array.Length / 4 * 4, _0002);
		byte[] array2 = new byte[_000F._0005_200A_2001_2004_2001_0002() * num5];
		for (int i = 0; i < num5; i++)
		{
			_000F._0005_200A_2001_2004_2001_0005(array, num2 * i, num2, array2, num3 * i, _0006);
		}
		return array2;
	}

	private static int _0005(int _0005)
	{
		if (_0005 < 8)
		{
			return 200;
		}
		return 1;
	}

	public static byte[] _0005(object _0005)
	{
		if (!(_0005 is sbyte b))
		{
			if (!(_0005 is byte b2))
			{
				if (!(_0005 is short num))
				{
					if (!(_0005 is ushort num2))
					{
						if (!(_0005 is int num3))
						{
							if (!(_0005 is uint num4))
							{
								if (!(_0005 is long num5))
								{
									if (!(_0005 is ulong num6))
									{
										if (!(_0005 is byte[] result))
										{
											if (!(_0005 is string s))
											{
												if (_0005 is IEnumerable enumerable)
												{
													MemoryStream memoryStream = new MemoryStream();
													foreach (object item in enumerable)
													{
														byte[] array = _0008_2003._0005(item);
														memoryStream.Write(array, 0, array.Length);
													}
													return memoryStream.ToArray();
												}
												throw new ArgumentOutOfRangeException(_000F_0019._0005(-1057760163));
											}
											return Encoding.Unicode.GetBytes(s);
										}
										return result;
									}
									return _0008_2003._0005(num6);
								}
								return _0008_2003._0005(num5);
							}
							return _0008_2003._0005(num4);
						}
						return _0008_2003._0005(num3);
					}
					return _0008_2003._0005(num2);
				}
				return _0008_2003._0005(num);
			}
			return new byte[1] { b2 };
		}
		return new byte[1] { (byte)b };
	}

	private static byte[] _0005(short _0005)
	{
		return _0008_2003._0005((ushort)_0005);
	}

	private static byte[] _0005(ushort _0005)
	{
		byte[] array = new byte[2];
		array[1] = (byte)_0005;
		array[0] = (byte)(_0005 >> 8);
		return array;
	}

	private static byte[] _0005(int _0005)
	{
		return _0008_2003._0005((uint)_0005);
	}

	private static byte[] _0005(uint _0005)
	{
		byte[] array = new byte[4];
		array[3] = (byte)_0005;
		array[2] = (byte)(_0005 >> 8);
		array[1] = (byte)(_0005 >> 16);
		array[0] = (byte)(_0005 >> 24);
		return array;
	}

	private static byte[] _0005(long _0005)
	{
		return _0008_2003._0005((ulong)_0005);
	}

	private static byte[] _0005(ulong _0005)
	{
		byte[] array = new byte[8];
		array[7] = (byte)_0005;
		array[6] = (byte)(_0005 >> 8);
		array[5] = (byte)(_0005 >> 16);
		array[4] = (byte)(_0005 >> 24);
		array[3] = (byte)(_0005 >> 32);
		array[2] = (byte)(_0005 >> 40);
		array[1] = (byte)(_0005 >> 48);
		array[0] = (byte)(_0005 >> 56);
		return array;
	}
}
internal sealed class _0008_2004
{
	private int m__0005;

	public int _0005()
	{
		return this.m__0005;
	}

	public void _0005(int _0005)
	{
		this.m__0005 = _0005;
	}
}
internal sealed class _0008_2005 : _0008_2009
{
	private byte m__0005;

	private _0005 m__0002;

	private string _000F;

	private _0005[] _0006 = new _0005[0];

	private _0005[] _0008 = new _0005[0];

	private _0005 _0003;

	public byte _0005()
	{
		return this.m__0005;
	}

	public void _0005(byte _0005)
	{
		this.m__0005 = _0005;
	}

	public bool _0005()
	{
		return (this._0005() & 1) != 0;
	}

	public bool _0002()
	{
		return (this._0005() & 2) != 0;
	}

	public _0005 _0005()
	{
		return this.m__0002;
	}

	public void _0005(_0005 _0005)
	{
		this.m__0002 = _0005;
	}

	public string _0005()
	{
		return _000F;
	}

	public void _0005(string _0005)
	{
		_000F = _0005;
	}

	public _0005[] _0005()
	{
		return _0006;
	}

	public void _0005(_0005[] _0005)
	{
		_0006 = _0005;
	}

	public _0005[] _0002()
	{
		return _0008;
	}

	public void _0002(_0005[] _0005)
	{
		_0008 = _0005;
	}

	public _0005 _0002()
	{
		return _0003;
	}

	public void _0002(_0005 _0005)
	{
		_0003 = _0005;
	}

	[SpecialName]
	public override byte _0008_2009_2001_2004_2001_0005()
	{
		return 0;
	}
}
internal sealed class _0008_2006 : _000F
{
	private new bool m__0005;

	public _0008_2006()
		: base(15)
	{
	}

	public new bool _0005()
	{
		return this.m__0005;
	}

	public void _0005(bool _0005)
	{
		this.m__0005 = _0005;
	}

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		return _0005();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		this._0005(Convert.ToBoolean(_0005));
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		switch (_0005._0005())
		{
		case 15:
			this._0005(((_0008_2006)_0005)._0005());
			break;
		case 1:
			this._0005(Convert.ToBoolean(((_0006)_0005)._0005()));
			break;
		case 13:
			this._0005(Convert.ToBoolean(((_0003_2003)_0005)._0005()));
			break;
		case 26:
			this._0005(Convert.ToBoolean(((_000E_2001)_0005)._0005()));
			break;
		case 3:
			this._0005(Convert.ToBoolean(((_0006_200B)_0005)._0005()));
			break;
		case 14:
			this._0005(Convert.ToBoolean(((_000E_2005)_0005)._0005()));
			break;
		case 16:
			this._0005(Convert.ToBoolean(((_0008_200A)_0005)._0005()));
			break;
		case 0:
			this._0005(Convert.ToBoolean(((_000F_2002)_0005)._0005()));
			break;
		case 20:
			this._0005(Convert.ToBoolean(((_0005_2008)_0005)._0005()));
			break;
		case 7:
			this._0005(Convert.ToBoolean(((_0008_2008)_0005)._0005()));
			break;
		case 17:
			this._0005(Convert.ToBoolean(((_0003_200B)_0005)._0005()));
			break;
		case 12:
			this._0005(Convert.ToBoolean(((_0002_2009_200B)_0005)._0005()));
			break;
		case 19:
			this._0005(Convert.ToBoolean(((_0005_0019)_0005)._0005()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0008_2006 obj = new _0008_2006();
		obj._0005(this.m__0005);
		obj._0005(base._0005());
		return obj;
	}
}
internal sealed class _0008_2007 : _000F
{
	private new string m__0005;

	public _0008_2007()
		: base(10)
	{
	}

	public new string _0005()
	{
		return this.m__0005;
	}

	public void _0005(string _0005)
	{
		this.m__0005 = _0005;
	}

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		return _0005();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		this._0005((string)_0005);
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		switch (_0005._0005())
		{
		case 10:
			this._0005(((_0008_2007)_0005)._0005());
			break;
		case 7:
			this._0005((string)((_0008_2008)_0005)._0005());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0008_2007 obj = new _0008_2007();
		obj._0005(this.m__0005);
		obj._0005(base._0005());
		return obj;
	}
}
internal sealed class _0008_2008 : _000F
{
	private new object m__0005;

	public _0008_2008()
		: base(7)
	{
	}

	public new object _0005()
	{
		return this.m__0005;
	}

	public void _0005(object _0005)
	{
		this.m__0005 = _0005;
	}

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		return _0005();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		this._0005(_0005);
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		this._0005(_0005._000F_2001_2004_2001_0005());
		return this;
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0008_2008 obj = new _0008_2008();
		obj._0005(this.m__0005);
		((_000F)obj)._0005(base._0005());
		return obj;
	}
}
internal abstract class _0008_2009
{
	public abstract byte _0008_2009_2001_2004_2001_0005();
}
internal sealed class _0008_200A : _000F
{
	private new ushort m__0005;

	public _0008_200A()
		: base(16)
	{
	}

	public new ushort _0005()
	{
		return this.m__0005;
	}

	public void _0005(ushort _0005)
	{
		this.m__0005 = _0005;
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
			this._0005((ushort)(short)_0005);
		}
		else if (_0005 is int)
		{
			this._0005((ushort)(int)_0005);
		}
		else if (_0005 is long)
		{
			this._0005((ushort)(long)_0005);
		}
		else if (_0005 is uint)
		{
			this._0005((ushort)(uint)_0005);
		}
		else if (_0005 is ulong)
		{
			this._0005((ushort)(ulong)_0005);
		}
		else if (_0005 is float)
		{
			this._0005((ushort)(float)_0005);
		}
		else if (_0005 is double)
		{
			this._0005((ushort)(double)_0005);
		}
		else
		{
			this._0005(Convert.ToUInt16(_0005));
		}
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0008_200A obj = new _0008_200A();
		obj._0005(this.m__0005);
		obj._0005(base._0005());
		return obj;
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
			this._0005((ushort)((_000E_2001)_0005)._0005());
			break;
		case 1:
			this._0005((ushort)((_0006)_0005)._0005());
			break;
		case 17:
			this._0005((ushort)((_0003_200B)_0005)._0005());
			break;
		case 16:
			this._0005(((_0008_200A)_0005)._0005());
			break;
		case 3:
			this._0005((ushort)((_0006_200B)_0005)._0005());
			break;
		case 13:
			this._0005((ushort)((_0003_2003)_0005)._0005());
			break;
		case 14:
			this._0005((ushort)((_000E_2005)_0005)._0005());
			break;
		case 19:
			this._0005(Convert.ToUInt16(((_0005_0019)_0005)._0005()));
			break;
		case 7:
			this._0005(Convert.ToUInt16(((_0008_2008)_0005)._0005()));
			break;
		case 0:
			this._0005((ushort)(int)((_000F_2002)_0005)._0005());
			break;
		case 20:
			this._0005((ushort)(uint)((_0005_2008)_0005)._0005());
			break;
		case 22:
			this._0005((ushort)((_0006_2000)_0005)._0005());
			break;
		case 8:
			this._0005((ushort)((_000F_2006)_0005)._0005());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
[AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
[_000F_2005]
internal sealed class _000E : Attribute
{
	public readonly int _0005;

	public _000E(int _0005)
	{
		this._0005 = _0005;
	}
}
internal sealed class _000E_2000 : _0005_2009
{
	private new object m__0005;

	private FieldInfo _0002;

	private _0005_2009 _000F;

	public _000E_2000(FieldInfo _0005, object _0002)
		: this()
	{
		this._0005(_0005);
		this._0005(_0002);
	}

	public _000E_2000(FieldInfo _0005, object _0002, _0005_2009 _000F)
		: this(_0005, _0002)
	{
		this._0005(_000F);
	}

	private _000E_2000()
		: base(18)
	{
	}

	public new object _0005()
	{
		return this.m__0005;
	}

	private void _0005(object _0005)
	{
		this.m__0005 = _0005;
	}

	public new FieldInfo _0005()
	{
		return _0002;
	}

	private void _0005(FieldInfo _0005)
	{
		_0002 = _0005;
	}

	public new _0005_2009 _0005()
	{
		return _000F;
	}

	private void _0005(_0005_2009 _0005)
	{
		_000F = _0005;
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		if (_0005._0005() == 18)
		{
			_000E_2000 obj = (_000E_2000)_0005;
			this._0005(obj._0005());
			this._0005(obj._0005());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_000E_2000 obj = new _000E_2000();
		obj._0005(this._0005());
		obj._0005(this._0005());
		obj._0005(this._0005());
		((_000F)obj)._0005(((_000F)this)._0005());
		return obj;
	}
}
internal sealed class _000E_2001 : _000F
{
	private new short m__0005;

	public _000E_2001()
		: base(26)
	{
	}

	public new short _0005()
	{
		return this.m__0005;
	}

	public void _0005(short _0005)
	{
		this.m__0005 = _0005;
	}

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		return _0005();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		if (_0005 is int)
		{
			this._0005((short)(int)_0005);
		}
		else if (_0005 is long)
		{
			this._0005((short)(long)_0005);
		}
		else if (_0005 is ushort)
		{
			this._0005((short)(ushort)_0005);
		}
		else if (_0005 is uint)
		{
			this._0005((short)(uint)_0005);
		}
		else if (_0005 is ulong)
		{
			this._0005((short)(ulong)_0005);
		}
		else if (_0005 is float)
		{
			this._0005((short)(float)_0005);
		}
		else if (_0005 is double)
		{
			this._0005((short)(double)_0005);
		}
		else
		{
			this._0005(Convert.ToInt16(_0005));
		}
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_000E_2001 obj = new _000E_2001();
		obj._0005(this.m__0005);
		obj._0005(base._0005());
		return obj;
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
		case 17:
			this._0005(((_0003_200B)_0005)._0005());
			break;
		case 26:
			this._0005(((_000E_2001)_0005)._0005());
			break;
		case 1:
			this._0005((short)((_0006)_0005)._0005());
			break;
		case 13:
			this._0005((short)((_0003_2003)_0005)._0005());
			break;
		case 19:
			this._0005(Convert.ToInt16(((_0005_0019)_0005)._0005()));
			break;
		case 16:
			this._0005((short)((_0008_200A)_0005)._0005());
			break;
		case 3:
			this._0005((short)((_0006_200B)_0005)._0005());
			break;
		case 14:
			this._0005((short)((_000E_2005)_0005)._0005());
			break;
		case 8:
			this._0005((short)((_000F_2006)_0005)._0005());
			break;
		case 22:
			this._0005((short)((_0006_2000)_0005)._0005());
			break;
		case 0:
			this._0005((short)(int)((_000F_2002)_0005)._0005());
			break;
		case 7:
			this._0005(Convert.ToInt16(((_0008_2008)_0005)._0005()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal struct _000E_2002
{
	public int _0005;

	public int _0002;
}
internal static class _000E_2003
{
	private delegate void _0005(Array _0005, RuntimeFieldHandle _0002);

	private static readonly _0005 m__0005;

	static _000E_2003()
	{
		_000E_2003.m__0005 = RuntimeHelpers.InitializeArray;
	}

	public static void _0005(Array _0005, RuntimeFieldHandle _0002)
	{
		if (_0003_200A._0005())
		{
			_ = FieldInfo.GetFieldFromHandle(_0002).MetadataToken;
		}
		_000E_2003.m__0005(_0005, _0002);
	}
}
internal sealed class _000E_2004
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 256)]
	internal struct _0005
	{
	}

	internal static readonly _0005 _0005/* Not supported: data(00 01 02 02 03 03 03 03 04 04 04 04 04 04 04 04 05 05 05 05 05 05 05 05 05 05 05 05 05 05 05 05 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 06 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 07 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08 08) */;

	internal static readonly _0005 _0002/* Not supported: data(A3 D7 09 83 F8 48 F6 F4 B3 21 15 78 99 B1 AF F9 E7 2D 4D 8A CE 4C CA 2E 52 95 D9 1E 4E 38 44 28 0A DF 02 A0 17 F1 60 68 12 B7 7A C3 E9 FA 3D 53 96 84 6B BA F2 63 9A 19 7C AE E5 F5 F7 16 6A A2 39 B6 7B 0F C1 93 81 1B EE B4 1A EA D0 91 2F B8 55 B9 DA 85 3F 41 BF E0 5A 58 80 5F 66 0B D8 90 35 D5 C0 A7 33 06 65 69 45 00 94 56 6D 98 9B 76 97 FC B2 C2 B0 FE DB 20 E1 EB D6 E4 DD 47 4A 1D 42 ED 9E 6E 49 3C CD 43 27 D2 07 D4 DE C7 67 18 89 CB 30 1F 8D C6 8F AA C8 74 DC C9 5D 5C 31 A4 70 88 61 2C 9F 0D 2B 87 50 82 54 64 26 7D 03 40 34 4B 1C 73 D1 C4 FD 3B CC FB 7F AB E6 3E 5B A5 AD 04 23 9C 14 51 22 F0 29 79 71 7E FF 8C 0E E2 0C EF BC 72 75 6F 37 A1 EC D3 8E 62 8B 86 10 E8 08 77 11 BE 92 4F 24 C5 32 36 9D CF F3 A6 BB AC 5E 6C A9 13 57 25 B5 E3 BD A8 3A 01 05 59 2A 46) */;
}
internal sealed class _000E_2005 : _000F
{
	private new ulong m__0005;

	public _000E_2005()
		: base(14)
	{
	}

	public new ulong _0005()
	{
		return this.m__0005;
	}

	public void _0005(ulong _0005)
	{
		this.m__0005 = _0005;
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
			this._0005((ulong)(short)_0005);
		}
		else if (_0005 is int)
		{
			this._0005((ulong)(int)_0005);
		}
		else if (_0005 is long)
		{
			this._0005((ulong)(long)_0005);
		}
		else if (_0005 is float)
		{
			this._0005((ulong)(float)_0005);
		}
		else if (_0005 is double)
		{
			this._0005((ulong)(double)_0005);
		}
		else
		{
			this._0005(Convert.ToUInt64(_0005));
		}
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_000E_2005 obj = new _000E_2005();
		obj._0005(this.m__0005);
		obj._0005(base._0005());
		return obj;
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
			this._0005((ulong)((_000E_2001)_0005)._0005());
			break;
		case 1:
			this._0005((ulong)((_0006)_0005)._0005());
			break;
		case 17:
			this._0005((ulong)((_0003_200B)_0005)._0005());
			break;
		case 16:
			this._0005(((_0008_200A)_0005)._0005());
			break;
		case 3:
			this._0005(((_0006_200B)_0005)._0005());
			break;
		case 13:
			this._0005((ulong)((_0003_2003)_0005)._0005());
			break;
		case 14:
			this._0005(((_000E_2005)_0005)._0005());
			break;
		case 19:
			this._0005(Convert.ToUInt64(((_0005_0019)_0005)._0005()));
			break;
		case 7:
			this._0005(Convert.ToUInt64(((_0008_2008)_0005)._0005()));
			break;
		case 0:
			this._0005((ulong)(long)((_000F_2002)_0005)._0005());
			break;
		case 20:
			this._0005((ulong)((_0005_2008)_0005)._0005());
			break;
		case 22:
			this._0005((ulong)((_0006_2000)_0005)._0005());
			break;
		case 8:
			this._0005((ulong)((_000F_2006)_0005)._0005());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal sealed class _000E_2006 : _000F
{
	private new char m__0005;

	public _000E_2006()
		: base(6)
	{
	}

	public new char _0005()
	{
		return this.m__0005;
	}

	public void _0005(char _0005)
	{
		this.m__0005 = _0005;
	}

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		return _0005();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		this._0005(Convert.ToChar(_0005));
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		switch (_0005._0005())
		{
		case 15:
			this._0005(Convert.ToChar(((_0008_2006)_0005)._0005()));
			break;
		case 1:
			this._0005((char)((_0006)_0005)._0005());
			break;
		case 13:
			this._0005((char)((_0003_2003)_0005)._0005());
			break;
		case 26:
			this._0005((char)((_000E_2001)_0005)._0005());
			break;
		case 3:
			this._0005((char)((_0006_200B)_0005)._0005());
			break;
		case 14:
			this._0005((char)((_000E_2005)_0005)._0005());
			break;
		case 16:
			this._0005((char)((_0008_200A)_0005)._0005());
			break;
		case 0:
			this._0005((char)(int)((_000F_2002)_0005)._0005());
			break;
		case 20:
			this._0005((char)(uint)((_0005_2008)_0005)._0005());
			break;
		case 7:
			this._0005(Convert.ToChar(((_0008_2008)_0005)._0005()));
			break;
		case 17:
			this._0005((char)((_0003_200B)_0005)._0005());
			break;
		case 12:
			this._0005((char)((_0002_2009_200B)_0005)._0005());
			break;
		case 6:
			this._0005(((_000E_2006)_0005)._0005());
			break;
		case 19:
			this._0005(Convert.ToChar(((_0005_0019)_0005)._0005()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_000E_2006 obj = new _000E_2006();
		obj._0005(this.m__0005);
		obj._0005(base._0005());
		return obj;
	}
}
internal sealed class _000E_2007 : _000F
{
	private new object m__0005;

	public _000E_2007(object _0005)
		: base(25)
	{
		if (_0005 != null && !(_0005 is ValueType))
		{
			throw new ArgumentException();
		}
		this.m__0005 = _0005;
	}

	public new object _0005()
	{
		return this.m__0005;
	}

	public void _0005(object _0005)
	{
		if (_0005 != null && !(_0005 is ValueType))
		{
			throw new ArgumentException();
		}
		this.m__0005 = _0005;
	}

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		return _0005();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		this._0005(_0005);
	}

	private new static bool _0005(Type _0005)
	{
		if (_0005.IsGenericType && _0005.Namespace == _000F_0019._0005(-1057760246))
		{
			string name = _0005.Name;
			if (name == _000F_0019._0005(-1057760193) || name == _000F_0019._0005(-1057760224))
			{
				return false;
			}
		}
		return true;
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		switch (_0005._0005())
		{
		case 25:
		{
			object obj = ((_000E_2007)_0005)._0005();
			object obj2 = this._0005();
			if (obj2 != null && obj != null)
			{
				Type type = obj2.GetType();
				if (!type.IsPrimitive && !type.IsEnum && type == obj.GetType() && _000E_2007._0005(type))
				{
					FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					foreach (FieldInfo fieldInfo in fields)
					{
						fieldInfo.SetValue(obj2, fieldInfo.GetValue(obj));
					}
					break;
				}
			}
			this._0005(obj);
			break;
		}
		case 7:
			this._0005(((_0008_2008)_0005)._0005());
			break;
		default:
			this._0005(_0005._000F_2001_2004_2001_0005());
			break;
		}
		return this;
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_000E_2007 obj = new _000E_2007(this.m__0005);
		((_000F)obj)._0005(base._0005());
		return obj;
	}
}
internal sealed class _000E_2008 : _0003_2008
{
	public _000E_2008(byte[] _0005, long _0002)
		: base(_0005, _0002)
	{
	}

	public byte[] _0005(_0008 _0005, _000E_2009 _0002)
	{
		byte[] array = new byte[4];
		_000E_2008._0005(_0005, array, 0, array.Length);
		int num = _0003_2008._0005(base._0005(array, _0002: false), 0);
		int num2 = _0003_2008._0002(num);
		int value = num2 - 4;
		byte[] array2 = new byte[num2];
		_000E_2008._0005(_0005, array2, 4, value);
		Buffer.BlockCopy(array, 0, array2, 0, 4);
		byte[] src = base._0005(array2, _0002: false);
		byte[] array3 = new byte[num];
		Buffer.BlockCopy(src, 4, array3, 0, num);
		return array3;
	}

	public byte[] _0005(byte[] _0005)
	{
		byte[] array = base._0005(_0005, _0002: false);
		int num = _0003_2008._0005(array, 0);
		byte[] array2 = new byte[num];
		Buffer.BlockCopy(array, 4, array2, 0, num);
		return array2;
	}

	private static void _0005(_0008 _0005, byte[] _0002, int _000F, int? _0006)
	{
		int num = _0006 ?? (_0002.Length - _000F);
		int num2;
		while ((num2 = _0005._0008_2001_2004_2001_0005(_0002, _000F, num)) > 0)
		{
			_000F += num2;
			num -= num2;
		}
	}
}
internal interface _000E_2009
{
	int _000E_2009_2001_2004_2001_0005();

	byte[] _000E_2009_2001_2004_2001_0005();

	long _000E_2009_2001_2004_2001_0005();
}
internal static class _000E_200A
{
	public static _0005_2001 _0005()
	{
		return _0002() ?? new _0005_2002();
	}

	private static _0005_2001 _0002()
	{
		try
		{
			_0002_2001 obj = new _0002_2001();
			if (!_0005(obj))
			{
				obj.Dispose();
				return null;
			}
			return obj;
		}
		catch (Exception ex) when (!_0005(ex))
		{
			return null;
		}
	}

	private static bool _0005(Exception _0005)
	{
		if (!(_0005 is ThreadAbortException))
		{
			return _0005 is ThreadInterruptedException;
		}
		return true;
	}

	private static bool _0005(_0005_2001 _0005)
	{
		byte[] array = new byte[3] { 0, 130, 255 };
		for (int i = 0; i < array.Length; i++)
		{
			byte b = array[i];
			_0005._0005_2001_2001_2004_2001_0002(i, ref b);
		}
		if (_0005._0005_2001_2001_2004_2001_0005() != array.Length)
		{
			return false;
		}
		for (int j = 0; j < array.Length; j++)
		{
			_0005._0005_2001_2001_2004_2001_0005(j, out var b2);
			if (b2 != array[j])
			{
				return false;
			}
		}
		_0005._0005_2001_2001_2004_2001_0005();
		if (_0005._0005_2001_2001_2004_2001_0005() != 0)
		{
			return false;
		}
		return true;
	}
}
internal abstract class _000F
{
	private readonly int m__0005;

	private Type _0002;

	protected _000F(int _0005)
	{
		this.m__0005 = _0005;
	}

	public abstract object _000F_2001_2004_2001_0005();

	public abstract void _000F_2001_2004_2001_0005(object _0005);

	public int _0005()
	{
		return this.m__0005;
	}

	public abstract _000F _000F_2001_2004_2001_0005(_000F _0005);

	public abstract _000F _000F_2001_2004_2001_0005();

	public Type _0005()
	{
		return _0002;
	}

	public void _0005(Type _0005)
	{
		_0002 = _0005;
	}

	public static _000F _0005(object _0005, Type _0002)
	{
		if (_0005 is _000F result)
		{
			return result;
		}
		if (_0002 == null)
		{
			if (_0005 == null)
			{
				return new _0008_2008();
			}
			_0002 = _0005.GetType();
		}
		_0002 = _0005_2004._0002(_0002);
		_000F obj;
		switch (_0005_2004._0005(_0002))
		{
		case 10:
			obj = new _0008_2007();
			break;
		case 8:
			obj = new _000F_2006();
			break;
		case 22:
			obj = new _0006_2000();
			break;
		case 15:
			obj = new _0008_2006();
			break;
		case 6:
			obj = new _000E_2006();
			break;
		case 14:
			obj = new _000E_2005();
			break;
		case 3:
			obj = new _0006_200B();
			break;
		case 16:
			obj = new _0008_200A();
			break;
		case 13:
			obj = new _0003_2003();
			break;
		case 1:
			obj = new _0006();
			break;
		case 26:
			obj = new _000E_2001();
			break;
		case 12:
			obj = new _0002_2009_200B();
			break;
		case 17:
			obj = new _0003_200B();
			break;
		case 0:
			obj = new _000F_2002();
			break;
		case 20:
			obj = new _0005_2008();
			break;
		case 7:
			obj = new _0008_2008();
			if (_0005 != null && _0005.GetType() != _0005_2004._0005)
			{
				obj._0005(_0005.GetType());
			}
			break;
		case 9:
			obj = new _000F_2009();
			break;
		case 19:
		{
			Enum obj4;
			if (_0005 != null)
			{
				obj4 = (Enum)Enum.ToObject(_0002, _0005);
			}
			else
			{
				obj4 = ((!_0002.IsNested || !_0002.DeclaringType.ContainsGenericParameters) ? ((Enum)Activator.CreateInstance(_0002)) : ((Enum)Enum.Parse(_0002, _000F_0019._0005(-1057762749))));
			}
			return new _0005_0019(obj4);
		}
		case 5:
		{
			_0008_2008 obj3 = new _0008_2008();
			((_000F)obj3)._0005(_0002);
			obj = obj3;
			break;
		}
		case 25:
			if (_0005 == null)
			{
				if (_0002 != _0005_2004._0008)
				{
					_0005 = Activator.CreateInstance(_0002);
				}
			}
			else if (_0005.GetType() != _0002)
			{
				try
				{
					_0005 = Convert.ChangeType(_0005, _0002);
				}
				catch
				{
				}
			}
			return new _000E_2007(_0005);
		default:
			obj = new _0008_2008();
			break;
		}
		if (_0005 != null)
		{
			obj._000F_2001_2004_2001_0005(_0005);
		}
		return obj;
	}
}
internal sealed class _000F_2000
{
	private readonly _0002_2005 m__0005 = new _0002_2005();

	private readonly int _0002;

	private readonly int _000F;

	private _0002_2005 _0006;

	private _0002_2005 _0008;

	private readonly byte[] _0003;

	private readonly byte[] _000E;

	public _000F_2000()
	{
		_0002 = this.m__0005._0002();
		_000F = this.m__0005._0005();
		_0003 = new byte[_000F];
		_000E = new byte[_000F + _0002];
	}

	public void _0005(byte[] _0005)
	{
		this.m__0005._0002();
		int num = _0005.Length;
		if (num > _000F)
		{
			this.m__0005._0005(_0005, 0, num);
			this.m__0005._0005(_0003, 0);
			num = _0002;
		}
		else
		{
			Array.Copy(_0005, 0, _0003, 0, num);
		}
		Array.Clear(_0003, num, _000F - num);
		Array.Copy(_0003, 0, _000E, 0, _000F);
		_000F_2000._0005(_0003, _000F, (byte)54);
		_000F_2000._0005(_000E, _000F, (byte)92);
		_0008 = this.m__0005._0005();
		_0008._0005(_000E, 0, _000F);
		this.m__0005._0005(_0003, 0, _0003.Length);
		_0006 = this.m__0005._0005();
	}

	public int _0005()
	{
		return _0002;
	}

	public void _0005(byte[] _0005, int _0002, int _000F)
	{
		this.m__0005._0005(_0005, _0002, _000F);
	}

	public int _0005(byte[] _0005, int _0002)
	{
		this.m__0005._0005(_000E, _000F);
		this.m__0005._0002(_0008);
		this.m__0005._0005(_000E, _000F, this.m__0005._0002());
		int result = this.m__0005._0005(_0005, _0002);
		Array.Clear(_000E, _000F, this._0002);
		this.m__0005._0002(_0006);
		return result;
	}

	private static void _0005(byte[] _0005, int _0002, byte _000F)
	{
		for (int i = 0; i < _0002; i++)
		{
			_0005[i] ^= _000F;
		}
	}
}
internal sealed class _000F_2001
{
	private struct _0002
	{
		private readonly uint m__0005;

		private readonly object m__0002;

		public _0002(uint _0005)
		{
			this.m__0005 = _0005;
			m__0002 = null;
		}

		public _0002(uint _0005, object _0002)
		{
			this.m__0005 = _0005;
			this.m__0002 = _0002;
		}

		[_0002_2003]
		public uint _0005()
		{
			return this.m__0005;
		}

		[_0002_2003]
		public object _0005()
		{
			return m__0002;
		}
	}

	private delegate void _0002_2009(_000F_2001 _0005, global::_000F _0002);

	private static class _0003
	{
		public static readonly bool _0005;

		static _0003()
		{
			try
			{
				global::_000F_2001._0003._0005 = _0005();
			}
			catch
			{
				global::_000F_2001._0003._0005 = false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool _0005()
		{
			if (typeof(DynamicMethod).IsAbstract)
			{
				return false;
			}
			try
			{
				new DynamicMethod(string.Empty, typeof(void), Type.EmptyTypes);
			}
			catch (PlatformNotSupportedException)
			{
				return false;
			}
			return true;
		}
	}

	private struct _0003_2009(_0006_2003 _0005, _0002_2009 _0002)
	{
		public readonly byte _0005 = _0005._0005();

		public readonly _0002_2009 _0002 = _0002;
	}

	private struct _0005(MethodBase _0005, bool _0002) : IEquatable<_0005>
	{
		private readonly MethodBase m__0005 = _0005;

		private readonly bool _0002 = _0002;

		[_0002_2003]
		public MethodBase _0005()
		{
			return this.m__0005;
		}

		[_0002_2003]
		public bool _0005()
		{
			return _0002;
		}

		public override int GetHashCode()
		{
			return this._0005().GetHashCode() ^ this._0005().GetHashCode();
		}

		public override bool Equals(object _0005)
		{
			if (_0005 is _0005 obj)
			{
				return Equals(obj);
			}
			return false;
		}

		public bool Equals(_0005 _0005)
		{
			if (this._0005() == _0005._0005())
			{
				return this._0005() == _0005._0005();
			}
			return false;
		}
	}

	private static class _0005_2009
	{
		private static readonly Dictionary<MethodBase, MethodInfo> m__0005;

		static _0005_2009()
		{
			global::_000F_2001._0005_2009.m__0005 = new Dictionary<MethodBase, MethodInfo>();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static MethodBase _0005(_000F_2001 _0005, _0003_2009_200B _0002, MethodBase _000F, bool _0006)
		{
			lock (global::_000F_2001._0005_2009.m__0005)
			{
				if (global::_000F_2001._0005_2009.m__0005.TryGetValue(_000F, out var value))
				{
					return value;
				}
				Type returnType = ((!(_000F is MethodInfo methodInfo)) ? global::_000F_2001.m__0003_2009 : methodInfo.ReturnType);
				ParameterInfo[] parameters = _000F.GetParameters();
				Type[] array;
				if (_000F.IsStatic)
				{
					array = new Type[parameters.Length];
					for (int i = 0; i < parameters.Length; i++)
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				else
				{
					array = new Type[parameters.Length + 1];
					Type type = _000F.DeclaringType;
					if (type.IsValueType)
					{
						type = type.MakeByRefType();
						_0006 = false;
					}
					array[0] = type;
					for (int j = 0; j < parameters.Length; j++)
					{
						array[j + 1] = parameters[j].ParameterType;
					}
				}
				string empty = string.Empty;
				if (value == null)
				{
					value = new DynamicMethod(empty, returnType, array, _0005._0005(_0002._0005(), _0002: true), skipVisibility: true);
				}
				ILGenerator iLGenerator = ((DynamicMethod)value).GetILGenerator();
				for (int k = 0; k < array.Length; k++)
				{
					iLGenerator.Emit(OpCodes.Ldarg, k);
				}
				if (_000F is ConstructorInfo con)
				{
					iLGenerator.Emit(_0006 ? OpCodes.Callvirt : OpCodes.Call, con);
				}
				else
				{
					iLGenerator.Emit(_0006 ? OpCodes.Callvirt : OpCodes.Call, (MethodInfo)_000F);
				}
				iLGenerator.Emit(OpCodes.Ret);
				global::_000F_2001._0005_2009.m__0005.Add(_000F, value);
				return value;
			}
		}
	}

	private static class _0005_200A
	{
		private delegate void _0002<in _0005, in _0002, in _000F, in _0006>(_0005 _0005, _0002 _0002, _000F _000F, _0006 _0006);

		private delegate _0002 _0002_2009<in _0005, out _0002>(_0005 _0005);

		private delegate _0003 _0002_200A<in _0005, in _0002, in _000F, in _0006, in _0008, out _0003>(_0005 _0005, _0002 _0002, _000F _000F, _0006 _0006, _0008 _0008);

		private delegate void _0003<in _0005, in _0002, in _000F>(_0005 _0005, _0002 _0002, _000F _000F);

		private delegate _0002_2009 _0003_2009<in _0005, in _0002, in _000F, in _0006, in _0008, in _0003, in _000E, in _0005_2009, out _0002_2009>(_0005 _0005, _0002 _0002, _000F _000F, _0006 _0006, _0008 _0008, _0003 _0003, _000E _000E, _0005_2009 _0005_2009);

		private delegate void _0003_200A<in _0005, in _0002, in _000F, in _0006, in _0008, in _0003, in _000E, in _0005_2009, in _0002_2009>(_0005 _0005, _0002 _0002, _000F _000F, _0006 _0006, _0008 _0008, _0003 _0003, _000E _000E, _0005_2009 _0005_2009, _0002_2009 _0002_2009);

		private delegate _000F_2009 _0005<in _0005, in _0002, in _000F, in _0006, in _0008, in _0003, in _000E, in _0005_2009, in _0002_2009, out _000F_2009>(_0005 _0005, _0002 _0002, _000F _000F, _0006 _0006, _0008 _0008, _0003 _0003, _000E _000E, _0005_2009 _0005_2009, _0002_2009 _0002_2009);

		private delegate _000E _0005_2009<in _0005, in _0002, in _000F, in _0006, in _0008, in _0003, out _000E>(_0005 _0005, _0002 _0002, _000F _000F, _0006 _0006, _0008 _0008, _0003 _0003);

		private delegate _0006 _0005_200A<in _0005, in _0002, in _000F, out _0006>(_0005 _0005, _0002 _0002, _000F _000F);

		private delegate void _0006<in _0005, in _0002, in _000F, in _0006, in _0008, in _0003>(_0005 _0005, _0002 _0002, _000F _000F, _0006 _0006, _0008 _0008, _0003 _0003);

		private delegate void _0006_2009<in _0005, in _0002, in _000F, in _0006, in _0008, in _0003, in _000E>(_0005 _0005, _0002 _0002, _000F _000F, _0006 _0006, _0008 _0008, _0003 _0003, _000E _000E);

		private delegate _0005_2009 _0006_200A<in _0005, in _0002, in _000F, in _0006, in _0008, in _0003, in _000E, out _0005_2009>(_0005 _0005, _0002 _0002, _000F _000F, _0006 _0006, _0008 _0008, _0003 _0003, _000E _000E);

		private delegate void _0008();

		private delegate void _0008_2009<in _0005>(_0005 _0005);

		private delegate void _0008_200A<in _0005, in _0002>(_0005 _0005, _0002 _0002);

		private delegate _0008 _000E<in _0005, in _0002, in _000F, in _0006, out _0008>(_0005 _0005, _0002 _0002, _000F _000F, _0006 _0006);

		private delegate _000F _000E_2009<in _0005, in _0002, out _000F>(_0005 _0005, _0002 _0002);

		private delegate void _000F<in _0005, in _0002, in _000F, in _0006, in _0008>(_0005 _0005, _0002 _0002, _000F _000F, _0006 _0006, _0008 _0008);

		private delegate _0005 _000F_2009<out _0005>();

		private delegate void _000F_200A<in _0005, in _0002, in _000F, in _0006, in _0008, in _0003, in _000E, in _0005_2009>(_0005 _0005, _0002 _0002, _000F _000F, _0006 _0006, _0008 _0008, _0003 _0003, _000E _000E, _0005_2009 _0005_2009);

		private static readonly Dictionary<MethodBase, KeyValuePair<Type, MethodInfo>> m__0005;

		static _0005_200A()
		{
			global::_000F_2001._0005_200A.m__0005 = new Dictionary<MethodBase, KeyValuePair<Type, MethodInfo>>();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object _0005(object _0005, MethodBase _0002, out MethodInfo _000F)
		{
			KeyValuePair<Type, MethodInfo> keyValuePair = global::_000F_2001._0005_200A._0005(_0002);
			Delegate result = (Delegate)Activator.CreateInstance(keyValuePair.Key, _0005, _0002.MethodHandle.GetFunctionPointer());
			_000F = keyValuePair.Value;
			return result;
		}

		private static KeyValuePair<Type, MethodInfo> _0005(MethodBase _0005)
		{
			lock (global::_000F_2001._0005_200A.m__0005)
			{
				if (global::_000F_2001._0005_200A.m__0005.TryGetValue(_0005, out var value))
				{
					return value;
				}
				Type type = (_0005 as MethodInfo)?.ReturnType ?? global::_000F_2001.m__0003_2009;
				bool flag = type != global::_000F_2001.m__0003_2009;
				ParameterInfo[] parameters = _0005.GetParameters();
				if (parameters.Length > 9)
				{
					throw new Exception(string.Format(_000F_0019._0005(-1057762047), parameters.Length));
				}
				Type[] array = new Type[parameters.Length + (flag ? 1 : 0)];
				for (int i = 0; i < parameters.Length; i++)
				{
					Type parameterType = parameters[i].ParameterType;
					if (parameterType.IsByRef || parameterType.IsPointer)
					{
						throw new Exception(_000F_0019._0005(-1057761921));
					}
					array[i] = parameterType;
				}
				if (flag)
				{
					array[array.Length - 1] = type;
				}
				Type type2 = (flag ? global::_000F_2001._0005_200A._0005(array) : _0002(array));
				MethodInfo method = type2.GetMethod(_000F_0019._0005(-1057762130));
				value = new KeyValuePair<Type, MethodInfo>(type2, method);
				global::_000F_2001._0005_200A.m__0005.Add(_0005, value);
				return value;
			}
		}

		private static Type _0005(Type[] _0005)
		{
			return _0005.Length switch
			{
				1 => typeof(_000F_2009<>).MakeGenericType(_0005), 
				2 => typeof(_0002_2009<, >).MakeGenericType(_0005), 
				3 => typeof(_000E_2009<, , >).MakeGenericType(_0005), 
				4 => typeof(_0005_200A<, , , >).MakeGenericType(_0005), 
				5 => typeof(_000E<, , , , >).MakeGenericType(_0005), 
				6 => typeof(_0002_200A<, , , , , >).MakeGenericType(_0005), 
				7 => typeof(_0005_2009<, , , , , , >).MakeGenericType(_0005), 
				8 => typeof(_0006_200A<, , , , , , , >).MakeGenericType(_0005), 
				9 => typeof(_0003_2009<, , , , , , , , >).MakeGenericType(_0005), 
				10 => typeof(_0005<, , , , , , , , , >).MakeGenericType(_0005), 
				_ => null, 
			};
		}

		private static Type _0002(Type[] _0005)
		{
			return _0005.Length switch
			{
				0 => typeof(_0008), 
				1 => typeof(_0008_2009<>).MakeGenericType(_0005), 
				2 => typeof(_0008_200A<, >).MakeGenericType(_0005), 
				3 => typeof(_0003<, , >).MakeGenericType(_0005), 
				4 => typeof(_0002<, , , >).MakeGenericType(_0005), 
				5 => typeof(_000F<, , , , >).MakeGenericType(_0005), 
				6 => typeof(_0006<, , , , , >).MakeGenericType(_0005), 
				7 => typeof(_0006_2009<, , , , , , >).MakeGenericType(_0005), 
				8 => typeof(_000F_200A<, , , , , , , >).MakeGenericType(_0005), 
				9 => typeof(_0003_200A<, , , , , , , , >).MakeGenericType(_0005), 
				_ => null, 
			};
		}
	}

	private sealed class _0006
	{
		private string m__0005;

		private Type _0002;

		public string _0005()
		{
			return this.m__0005;
		}

		public void _0005(string _0005)
		{
			this.m__0005 = _0005;
		}

		public Type _0005()
		{
			return _0002;
		}

		public void _0005(Type _0005)
		{
			_0002 = _0005;
		}
	}

	private sealed class _0006_2009 : IDisposable
	{
		public _0002_2008 _0005;

		public _0005_2009_200B _0002;

		public global::_0008 _000F;

		public long _0006;

		public void Dispose()
		{
			IDisposable disposable = _0002;
			if (disposable != null)
			{
				disposable.Dispose();
				disposable = null;
			}
			if (_000F != null)
			{
				_000F.Dispose();
				_000F = null;
			}
		}
	}

	private static class _0008
	{
		public static _0002_2009 _0005;

		public static _0002_2009 _0002;

		public static _0002_2009 _000F;

		public static _0002_2009 _0006;

		public static _0002_2009 _0008;

		public static _0002_2009 _0003;

		public static _0002_2009 _000E;

		public static _0002_2009 _0005_2009;

		public static _0002_2009 _0002_2009;

		public static _0002_2009 _000F_2009;

		public static _0002_2009 _0006_2009;

		public static _0002_2009 _0008_2009;

		public static _0002_2009 _0003_2009;

		public static _0002_2009 _000E_2009;

		public static _0002_2009 _0005_200A;

		public static _0002_2009 _0002_200A;

		public static _0002_2009 _000F_200A;

		public static _0002_2009 _0006_200A;

		public static _0002_2009 _0008_200A;

		public static _0002_2009 _0003_200A;

		public static _0002_2009 _000E_200A;

		public static _0002_2009 _0005_2008;

		public static _0002_2009 _0002_2008;

		public static _0002_2009 _000F_2008;

		public static _0002_2009 _0006_2008;

		public static _0002_2009 _0008_2008;

		public static _0002_2009 _0003_2008;

		public static _0002_2009 _000E_2008;

		public static _0002_2009 _0005_2001;

		public static _0002_2009 _0002_2001;

		public static _0002_2009 _000F_2001;

		public static _0002_2009 _0006_2001;

		public static _0002_2009 _0008_2001;

		public static _0002_2009 _0003_2001;

		public static _0002_2009 _000E_2001;

		public static _0002_2009 _0005_200B;

		public static _0002_2009 _0002_200B;

		public static _0002_2009 _000F_200B;

		public static _0002_2009 _0006_200B;

		public static _0002_2009 _0008_200B;

		public static _0002_2009 _0003_200B;

		public static _0002_2009 _000E_200B;

		public static _0002_2009 _0005_2002;

		public static _0002_2009 _0002_2002;

		public static _0002_2009 _000F_2002;

		public static _0002_2009 _0006_2002;

		public static _0002_2009 _0008_2002;

		public static _0002_2009 _0003_2002;

		public static _0002_2009 _000E_2002;

		public static _0002_2009 _0005_2004;

		public static _0002_2009 _0002_2004;

		public static _0002_2009 _000F_2004;

		public static _0002_2009 _0006_2004;

		public static _0002_2009 _0008_2004;

		public static _0002_2009 _0003_2004;

		public static _0002_2009 _000E_2004;

		public static _0002_2009 _0005_2000;

		public static _0002_2009 _0002_2000;

		public static _0002_2009 _000F_2000;

		public static _0002_2009 _0006_2000;

		public static _0002_2009 _0008_2000;

		public static _0002_2009 _0003_2000;

		public static _0002_2009 _000E_2000;

		public static _0002_2009 _0005_2005;

		public static _0002_2009 _0002_2005;

		public static _0002_2009 _000F_2005;

		public static _0002_2009 _0006_2005;

		public static _0002_2009 _0008_2005;

		public static _0002_2009 _0003_2005;

		public static _0002_2009 _000E_2005;

		public static _0002_2009 _0005_2007;

		public static _0002_2009 _0002_2007;

		public static _0002_2009 _000F_2007;

		public static _0002_2009 _0006_2007;

		public static _0002_2009 _0008_2007;

		public static _0002_2009 _0003_2007;

		public static _0002_2009 _000E_2007;

		public static _0002_2009 _0005_2003;

		public static _0002_2009 _0002_2003;

		public static _0002_2009 _000F_2003;

		public static _0002_2009 _0006_2003;

		public static _0002_2009 _0008_2003;

		public static _0002_2009 _0003_2003;

		public static _0002_2009 _000E_2003;

		public static _0002_2009 _0005_2006;

		public static _0002_2009 _0002_2006;

		public static _0002_2009 _000F_2006;

		public static _0002_2009 _0006_2006;

		public static _0002_2009 _0008_2006;

		public static _0002_2009 _0003_2006;

		public static _0002_2009 _000E_2006;

		public static _0002_2009 _0005_2009_200B;

		public static _0002_2009 _0002_2009_200B;

		public static _0002_2009 _000F_2009_200B;

		public static _0002_2009 _0006_2009_200B;

		public static _0002_2009 _0008_2009_200B;

		public static _0002_2009 _0003_2009_200B;

		public static _0002_2009 _000E_2009_200B;

		public static _0002_2009 _0005_200A_200B;

		public static _0002_2009 _0002_200A_200B;

		public static _0002_2009 _000F_200A_200B;

		public static _0002_2009 _0006_200A_200B;

		public static _0002_2009 _0008_200A_200B;

		public static _0002_2009 _0003_200A_200B;

		public static _0002_2009 _000E_200A_200B;

		public static _0002_2009 _0005_2008_200B;

		public static _0002_2009 _0002_2008_200B;

		public static _0002_2009 _000F_2008_200B;

		public static _0002_2009 _0006_2008_200B;

		public static _0002_2009 _0008_2008_200B;

		public static _0002_2009 _0003_2008_200B;

		public static _0002_2009 _000E_2008_200B;

		public static _0002_2009 _0005_2001_200B;

		public static _0002_2009 _0002_2001_200B;

		public static _0002_2009 _000F_2001_200B;

		public static _0002_2009 _0006_2001_200B;

		public static _0002_2009 _0008_2001_200B;

		public static _0002_2009 _0003_2001_200B;

		public static _0002_2009 _000E_2001_200B;

		public static _0002_2009 _0005_200B_200B;

		public static _0002_2009 _0002_200B_200B;

		public static _0002_2009 _000F_200B_200B;

		public static _0002_2009 _0006_200B_200B;

		public static _0002_2009 _0008_200B_200B;

		public static _0002_2009 _0003_200B_200B;

		public static _0002_2009 _000E_200B_200B;

		public static _0002_2009 _0005_2002_200B;

		public static _0002_2009 _0002_2002_200B;

		public static _0002_2009 _000F_2002_200B;

		public static _0002_2009 _0006_2002_200B;

		public static _0002_2009 _0008_2002_200B;

		public static _0002_2009 _0003_2002_200B;

		public static _0002_2009 _000E_2002_200B;

		public static _0002_2009 _0005_2004_200B;

		public static _0002_2009 _0002_2004_200B;

		public static _0002_2009 _000F_2004_200B;

		public static _0002_2009 _0006_2004_200B;

		public static _0002_2009 _0008_2004_200B;

		public static _0002_2009 _0003_2004_200B;

		public static _0002_2009 _000E_2004_200B;

		public static _0002_2009 _0005_2000_200B;

		public static _0002_2009 _0002_2000_200B;

		public static _0002_2009 _000F_2000_200B;

		public static _0002_2009 _0006_2000_200B;

		public static _0002_2009 _0008_2000_200B;

		public static _0002_2009 _0003_2000_200B;

		public static _0002_2009 _000E_2000_200B;

		public static _0002_2009 _0005_2005_200B;

		public static _0002_2009 _0002_2005_200B;

		public static _0002_2009 _000F_2005_200B;

		public static _0002_2009 _0006_2005_200B;

		public static _0002_2009 _0008_2005_200B;

		public static _0002_2009 _0003_2005_200B;

		public static _0002_2009 _000E_2005_200B;

		public static _0002_2009 _0005_2007_200B;

		public static _0002_2009 _0002_2007_200B;

		public static _0002_2009 _000F_2007_200B;

		public static _0002_2009 _0006_2007_200B;

		public static _0002_2009 _0008_2007_200B;

		public static _0002_2009 _0003_2007_200B;

		public static _0002_2009 _000E_2007_200B;

		public static _0002_2009 _0005_2003_200B;

		public static _0002_2009 _0002_2003_200B;

		public static _0002_2009 _000F_2003_200B;

		public static _0002_2009 _0006_2003_200B;

		public static _0002_2009 _0008_2003_200B;

		public static _0002_2009 _0003_2003_200B;

		public static _0002_2009 _000E_2003_200B;

		public static _0002_2009 _0005_2006_200B;

		public static _0002_2009 _0002_2006_200B;

		public static _0002_2009 _000F_2006_200B;

		public static _0002_2009 _0006_2006_200B;

		public static _0002_2009 _0008_2006_200B;

		public static _0002_2009 _0003_2006_200B;

		public static _0002_2009 _000E_2006_200B;

		public static _0002_2009 _0005_2009_2005;

		public static _0002_2009 _0002_2009_2005;

		public static _0002_2009 _000F_2009_2005;

		public static _0002_2009 _0006_2009_2005;

		public static _0002_2009 _0008_2009_2005;

		public static _0002_2009 _0003_2009_2005;

		public static _0002_2009 _000E_2009_2005;

		public static _0002_2009 _0005_200A_2005;

		public static _0002_2009 _0002_200A_2005;

		public static _0002_2009 _000F_200A_2005;

		public static _0002_2009 _0006_200A_2005;

		public static _0002_2009 _0008_200A_2005;

		public static _0002_2009 _0003_200A_2005;

		public static _0002_2009 _000E_200A_2005;

		public static _0002_2009 _0005_2008_2005;

		public static _0002_2009 _0002_2008_2005;

		public static _0002_2009 _000F_2008_2005;

		public static _0002_2009 _0006_2008_2005;

		public static _0002_2009 _0008_2008_2005;

		public static _0002_2009 _0003_2008_2005;

		public static _0002_2009 _000E_2008_2005;

		public static _0002_2009 _0005_2001_2005;

		public static _0002_2009 _0002_2001_2005;

		public static _0002_2009 _000F_2001_2005;

		public static _0002_2009 _0006_2001_2005;

		public static _0002_2009 _0008_2001_2005;

		public static _0002_2009 _0003_2001_2005;

		public static _0002_2009 _000E_2001_2005;

		public static _0002_2009 _0005_200B_2005;

		public static _0002_2009 _0002_200B_2005;
	}

	private sealed class _0008_2009<_0005> : IComparer<KeyValuePair<int, _0005>>
	{
		private readonly Comparison<_0005> _0005;

		public _0008_2009(Comparison<_0005> _0005)
		{
			this._0005 = _0005;
		}

		public int Compare(KeyValuePair<int, _0005> _0005, KeyValuePair<int, _0005> _0002)
		{
			int num = this._0005(_0005.Value, _0002.Value);
			if (num == 0)
			{
				return _0002.Key.CompareTo(_0005.Key);
			}
			return num;
		}
	}

	private sealed class _000E
	{
	}

	private struct _000E_2009
	{
		public bool _0005;
	}

	private delegate object _000F(object _0005, object[] _0002);

	[Serializable]
	private sealed class _000F_2009
	{
		public static readonly _000F_2009 _0005;

		public static Comparison<_0003_2007> _0002;

		static _000F_2009()
		{
			global::_000F_2001._000F_2009._0005 = new _000F_2009();
		}

		internal int _0005(_0003_2007 _0005, _0003_2007 _0002)
		{
			if (_0005._0002() == _0002._0002())
			{
				return _0002._000F().CompareTo(_0005._000F());
			}
			return _0005._0002().CompareTo(_0002._0002());
		}
	}

	private bool m__0003_2001;

	private static readonly Dictionary<MethodBase, int> m__000F_200B;

	private static Type m__0003_2009;

	private Type m__0008_200B;

	private readonly Stack<_0002> m__0008_200A = new Stack<_0002>();

	private uint m__0008;

	private uint m__0002_200A;

	private _0003_2009_200B m__000E_2008;

	private static Type m__000E_2009;

	private uint? m__0006_2001;

	private Stack<_0006_2009> m__0003_2008;

	private long m__0002_2009;

	private readonly Stack<global::_000F> m__0003 = new Stack<global::_000F>(16);

	private static readonly Dictionary<int, object> m__000E_2001;

	private static object m__0006_2008;

	private static Dictionary<int, _0003_2009> m__0006_2009;

	private global::_000F[] m__0006_200A;

	private global::_000F m__0005_200B;

	private bool m__000F_2001;

	private static Type m__000E_200A;

	private global::_000F m__0005_2008;

	private _0003_2007[] m__0008_2008;

	private static Type m__000F;

	private global::_000F[] m__0002_2001;

	private static Type m__000F_2009;

	private static readonly Dictionary<_0005, _000F> m__0005_200A;

	private uint m__0006;

	private _0005_2009_200B m__0005_2009;

	private static Type m__0002_2008;

	private _0005_2009_200B m__000E;

	private static Type m__0003_200A;

	private readonly _0002_2007 m__000F_200A;

	private Stream m__0005;

	private byte[] m__0006_200B;

	private object m__0008_2009;

	private static readonly Dictionary<MethodBase, object> m__0002;

	private readonly Module m__0008_2001;

	private Type[] m__0002_200B;

	private Type[] m__000F_2008;

	private object[] m__0005_2001;

	public _000F_2001(_0002_2007 _0005, Module _0002)
	{
		this.m__000F_200A = _0005;
		this.m__0008_2001 = _0002;
		_0005_2009();
	}

	public _000F_2001(_0002_2007 _0005)
		: this(_0005, typeof(_000F_2001).Module)
	{
	}

	static _000F_2001()
	{
		global::_000F_2001.m__0006_2008 = new object();
		global::_000F_2001.m__0005_200A = new Dictionary<_0005, _000F>(256);
		global::_000F_2001.m__000F_200B = new Dictionary<MethodBase, int>(256);
		global::_000F_2001.m__0002 = new Dictionary<MethodBase, object>();
		global::_000F_2001.m__000E_2001 = new Dictionary<int, object>();
		global::_000F_2001.m__000F_2009 = typeof(_000E);
		global::_000F_2001.m__0003_2009 = typeof(void);
		global::_000F_2001.m__000F = typeof(object[]);
		global::_000F_2001.m__000E_200A = typeof(IntPtr);
		global::_000F_2001.m__000E_2009 = typeof(Assembly);
		global::_000F_2001.m__0002_2008 = typeof(MethodBase);
		global::_000F_2001.m__0003_200A = typeof(RuntimeHelpers);
	}

	private static void _000F_2004_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		global::_000F obj2 = _0005._0002();
		global::_0006 obj3 = new global::_0006();
		obj3._0005(_0006(obj2, obj) ? 1 : 0);
		_0005._0005((global::_000F)obj3);
	}

	private static void _0006_2005_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(_0005: false, _0002: false);
	}

	private static void _0005_2008_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(_0002);
	}

	private void _0005(Type _0005)
	{
		object obj = _0002()._000F_2001_2004_2001_0005();
		long num = _0002();
		Array array = (Array)_0002()._000F_2001_2004_2001_0005();
		this._0005(_0005, obj, num, array);
	}

	private static void _000E_2009(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0008(_0005: true);
	}

	private static void _000E_2000(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		Type elementType = _0005._0005(num, _0002: true);
		global::_000F obj = _0005._0002();
		int length;
		if (obj is global::_0006 obj2)
		{
			length = obj2._0005();
		}
		else if (obj is _000F_2002 obj3)
		{
			length = obj3._0005().ToInt32();
		}
		else
		{
			if (!(obj is _0005_2008 obj4))
			{
				throw new Exception();
			}
			length = (int)obj4._0005().ToUInt32();
		}
		Array array = Array.CreateInstance(elementType, length);
		global::_000F_2009 obj5 = new global::_000F_2009();
		obj5._0005(array);
		_0005._0005((global::_000F)obj5);
	}

	private static void _0002_2009_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(3);
	}

	private static void _0006_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		checked
		{
			_0005._0005((global::_000F)new global::_0006(obj._0005() switch
			{
				1 => unchecked((int)checked((byte)(uint)((global::_0006)obj)._0005())), 
				13 => (byte)(ulong)((_0003_2003)obj)._0005(), 
				19 => (byte)Convert.ToUInt64(((_0005_0019)obj)._0005()), 
				8 => (byte)((_000F_2006)obj)._0005(), 
				0 => (IntPtr.Size != 4) ? ((byte)(ulong)(long)((_000F_2002)obj)._0005()) : ((byte)(uint)(int)((_000F_2002)obj)._0005()), 
				_ => throw new InvalidOperationException(), 
			}));
		}
	}

	private static void _0003_200A_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003();
	}

	private static void _000F_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003(3);
	}

	private void _0008_2009(bool _0005)
	{
		global::_000F obj = _0002();
		this._0005((global::_000F)new global::_0006(obj._0005() switch
		{
			1 => (int)((!_0005) ? ((ushort)((global::_0006)obj)._0005()) : checked((uint)((global::_0006)obj)._0005())), 
			13 => (int)((!_0005) ? ((_0003_2003)obj)._0005() : checked((uint)((_0003_2003)obj)._0005())), 
			19 => (int)((!_0005) ? Convert.ToUInt64(((_0005_0019)obj)._0005()) : checked((uint)Convert.ToUInt64(((_0005_0019)obj)._0005()))), 
			8 => (int)((!_0005) ? ((uint)((_000F_2006)obj)._0005()) : checked((uint)((_000F_2006)obj)._0005())), 
			0 => (int)((IntPtr.Size != 4) ? ((!_0005) ? ((long)((_000F_2002)obj)._0005()) : checked((uint)(ulong)(long)((_000F_2002)obj)._0005())) : ((!_0005) ? ((int)((_000F_2002)obj)._0005()) : ((int)checked((uint)(int)((_000F_2002)obj)._0005())))), 
			20 => (int)((UIntPtr.Size != 4) ? ((!_0005) ? ((ulong)((_0005_2008)obj)._0005()) : checked((uint)(ulong)((_0005_2008)obj)._0005())) : ((!_0005) ? ((uint)((_0005_2008)obj)._0005()) : ((uint)((_0005_2008)obj)._0005()))), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	public object _0005(Stream _0005, string _0002, object[] _000F)
	{
		return this._0005(_0005, _0002, _000F, null, null, null);
	}

	private static void _0008_200A(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(((_0002_2009_200B)_0002)._0005());
	}

	private static void _000E_2009_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		if (global::_000F_2001._0002(_0005._0002(), obj))
		{
			uint num = ((_0006_200B)_0002)._0005();
			_0005._0005(num);
		}
	}

	private static void _0006_2007_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005_2009(_0005: false);
	}

	private static void _0008_2002(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(typeof(ushort));
	}

	private static void _0006_2002(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		IntPtr intPtr = checked(obj._0005() switch
		{
			1 => new IntPtr((uint)((global::_0006)obj)._0005()), 
			13 => new IntPtr((long)(ulong)((_0003_2003)obj)._0005()), 
			19 => new IntPtr((long)Convert.ToUInt64(((_0005_0019)obj)._0005())), 
			8 => new IntPtr((long)((_000F_2006)obj)._0005()), 
			_ => throw new InvalidOperationException(), 
		});
		_000F_2002 obj2 = new _000F_2002();
		obj2._0005(intPtr);
		_0005._0005((global::_000F)obj2);
	}

	private void _0005(long _0005)
	{
		this.m__000E._0005()._0008_2001_2004_2001_0005(_0005 - this.m__0002_2009);
	}

	private global::_000F[] _0005()
	{
		_0008_2004[] array = this.m__000E_2008._0005();
		int num = array.Length;
		global::_000F[] array2 = new global::_000F[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = global::_000F._0005(null, _0005(array[i]._0005(), _0002: false));
		}
		return array2;
	}

	private static void _000F_200A_200B(_000F_2001 _0005, global::_000F _0002)
	{
	}

	private void _0005(Stream _0005, string _0002)
	{
		this._0005(_0005, 0L, _0002);
	}

	private static void _0005_2002(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(1);
	}

	private static void _0005_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(2);
	}

	private static void _0005_2006(_000F_2001 _0005, global::_000F _0002)
	{
		global::_0006 obj = (global::_0006)_0002;
		MethodBase methodBase = _0005._0005(obj._0005());
		global::_000F[] array = _0005.m__0002_2001;
		foreach (global::_000F obj2 in array)
		{
			_0005._0005(obj2);
		}
		_0005._0005(methodBase, false);
	}

	private static void _0005_200B_200B(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		Type type = _0005._0005(num, _0002: true);
		long num2 = _0005._0002();
		Array array = (Array)_0005._0002()._000F_2001_2004_2001_0005();
		_0002_200A_200B obj = new _0002_200A_200B();
		obj._0005(array);
		obj._0005(type);
		obj._0005(num2);
		_0005._0005((global::_000F)obj);
	}

	private static _000F _0005(_0005 _0005)
	{
		lock (global::_000F_2001.m__0005_200A)
		{
			global::_000F_2001.m__0005_200A.TryGetValue(_0005, out var value);
			return value;
		}
	}

	private static void _0008(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(_0002);
	}

	private void _0008(bool _0005)
	{
		global::_000F obj = _0002();
		global::_000F obj2 = _0002();
		this._0005(_000F(obj2, obj, _0005));
	}

	private static void _0006_2009_2005(_000F_2001 _0005, global::_000F _0002)
	{
		throw new NotSupportedException(_000F_0019._0005(-1057762681));
	}

	private static Exception _0005(string _0005, string _0002)
	{
		return new MethodAccessException(global::_000F_2001._0005(_000F_0019._0005(-1057762093) + _0005 + _000F_0019._0005(-1057762049), _000F_0019._0005(-1057762073) + _0002 + _000F_0019._0005(-1057762049)));
	}

	private static void _000F_2007_200B(_000F_2001 _0005, global::_000F _0002)
	{
		throw new NotSupportedException(_000F_0019._0005(-1057763245));
	}

	private void _000F(int _0005)
	{
		this._0005(this.m__0002_2001[_0005]._000F_2001_2004_2001_0005());
	}

	private static void _000E_2006_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		checked
		{
			_0005._0005((global::_000F)new _0003_2003(obj._0005() switch
			{
				1 => unchecked((uint)((global::_0006)obj)._0005()), 
				13 => (long)(ulong)((_0003_2003)obj)._0005(), 
				19 => (long)Convert.ToUInt64(((_0005_0019)obj)._0005()), 
				8 => (long)((_000F_2006)obj)._0005(), 
				0 => (IntPtr.Size != 4) ? ((long)(ulong)(long)((_000F_2002)obj)._0005()) : unchecked((uint)(int)((_000F_2002)obj)._0005()), 
				_ => throw new InvalidOperationException(), 
			}));
		}
	}

	private static void _000E_200A_2005(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		FieldInfo fieldInfo = _0005._0005(num);
		global::_000F obj = _0005._0002();
		global::_0005_2009 obj2 = obj as global::_0005_2009;
		object obj3 = ((obj2 == null) ? obj._000F_2001_2004_2001_0005() : _0005._0005(obj2)._000F_2001_2004_2001_0005());
		_0005._0005((global::_000F)new _000E_2000(fieldInfo, obj3, obj2));
	}

	private static void _0008_2009(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		if (!_000F(_0005._0002(), obj))
		{
			uint num = ((_0006_200B)_0002)._0005();
			_0005._0005(num);
		}
	}

	private global::_000F _0006(global::_000F _0005, global::_000F _0002)
	{
		if (_0005._0005() == 1)
		{
			if (_0002._0005() == 1)
			{
				int num = ((global::_0006)_0005)._0005();
				int num2 = ((global::_0006)_0002)._0005();
				global::_0006 obj = new global::_0006();
				obj._0005(num & num2);
				return obj;
			}
			if (_0002._0005() == 19)
			{
				int num3 = ((global::_0006)_0005)._0005();
				Type underlyingType = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
				{
					long num4 = Convert.ToInt64(_0002._000F_2001_2004_2001_0005());
					return new _0003_2003(num3 & num4);
				}
				int num5 = Convert.ToInt32(_0002._000F_2001_2004_2001_0005());
				global::_0006 obj2 = new global::_0006();
				obj2._0005(num3 & num5);
				return obj2;
			}
		}
		if (_0005._0005() == 13)
		{
			if (_0002._0005() == 13)
			{
				long num6 = ((_0003_2003)_0005)._0005();
				long num7 = ((_0003_2003)_0002)._0005();
				_0003_2003 obj3 = new _0003_2003();
				obj3._0005(num6 & num7);
				return obj3;
			}
			if (_0002._0005() == 19)
			{
				int num8 = ((global::_0006)_0005)._0005();
				long num9 = Convert.ToInt64(_0002._000F_2001_2004_2001_0005());
				return new _0003_2003(num8 & num9);
			}
		}
		if (_0005._0005() == 19)
		{
			if (_0002._0005() == 1)
			{
				int num10 = ((global::_0006)_0002)._0005();
				Type underlyingType2 = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return new _0003_2003(Convert.ToInt64(_0002._000F_2001_2004_2001_0005()) & num10);
				}
				int num11 = Convert.ToInt32(_0005._000F_2001_2004_2001_0005());
				global::_0006 obj4 = new global::_0006();
				obj4._0005(num11 & num10);
				return obj4;
			}
			if (_0002._0005() == 13)
			{
				long num12 = Convert.ToInt64(_0005._000F_2001_2004_2001_0005());
				long num13 = ((_0003_2003)_0002)._0005();
				_0003_2003 obj5 = new _0003_2003();
				obj5._0005(num12 & num13);
				return obj5;
			}
			if (_0002._0005() == 19)
			{
				Type underlyingType3 = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
				Type underlyingType4 = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType3 == typeof(long) || underlyingType3 == typeof(ulong) || underlyingType4 == typeof(long) || underlyingType4 == typeof(ulong))
				{
					long num14 = Convert.ToInt64(_0005._000F_2001_2004_2001_0005());
					long num15 = Convert.ToInt64(_0002._000F_2001_2004_2001_0005());
					return new _0003_2003(num14 & num15);
				}
				int num16 = Convert.ToInt32(_0005._000F_2001_2004_2001_0005());
				int num17 = Convert.ToInt32(_0002._000F_2001_2004_2001_0005());
				return new global::_0006(num16 & num17);
			}
		}
		throw new InvalidOperationException();
	}

	private static global::_000F _000F(global::_000F _0005, global::_000F _0002, bool _000F)
	{
		if (_0005._0005() == 1)
		{
			if (_0002._0005() == 1)
			{
				if (!_000F)
				{
					int num = ((global::_0006)_0005)._0005();
					int num2 = ((global::_0006)_0002)._0005();
					return new global::_0006(num >> num2);
				}
				int num3 = ((global::_0006)_0005)._0005();
				int num4 = ((global::_0006)_0002)._0005();
				return new global::_0006(num3 >>> num4);
			}
			if (_0002._0005() == 19)
			{
				return global::_000F_2001._000F(_0005, new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())), _000F);
			}
		}
		if (_0005._0005() == 13)
		{
			if (_0002._0005() == 1)
			{
				if (!_000F)
				{
					long num5 = ((_0003_2003)_0005)._0005();
					int num6 = ((global::_0006)_0002)._0005();
					return new _0003_2003(num5 >> num6);
				}
				long num7 = ((_0003_2003)_0005)._0005();
				int num8 = ((global::_0006)_0002)._0005();
				return new _0003_2003(num7 >>> num8);
			}
			if (_0002._0005() == 19)
			{
				return global::_000F_2001._000F(_0005, new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())), _000F);
			}
		}
		if (_0005._0005() == 19)
		{
			Type underlyingType = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
			if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
			{
				return global::_000F_2001._000F(new _0003_2003(Convert.ToInt64(_0005._000F_2001_2004_2001_0005())), _0002, _000F);
			}
			return global::_000F_2001._000F(new global::_0006(Convert.ToInt32(_0005._000F_2001_2004_2001_0005())), _0002, _000F);
		}
		throw new InvalidOperationException();
	}

	private static void _0003_2005(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		bool flag = false;
		if (obj._0005() switch
		{
			1 => ((global::_0006)obj)._0005() != 0, 
			13 => ((_0003_2003)obj)._0005() != 0, 
			0 => ((_000F_2002)obj)._0005() != IntPtr.Zero, 
			20 => ((_0005_2008)obj)._0005() != UIntPtr.Zero, 
			19 => Convert.ToBoolean(((_0005_0019)obj)._0005()), 
			7 => ((_0008_2008)obj)._0005() != null, 
			_ => obj._000F_2001_2004_2001_0005() != null, 
		})
		{
			uint num = ((_0006_200B)_0002)._0005();
			_0005._0005(num);
		}
	}

	private static void _0006_2003_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0008_200A obj = (_0008_200A)_0002;
		_0006_2005 obj2 = new _0006_2005();
		obj2._0005(_0005.m__0002_2001[obj._0005()]);
		_0005._0005((global::_000F)obj2);
	}

	private static void _000E_200A(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		_0005._0005(_0005._0005(obj));
	}

	private static void _0002_2007_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		global::_000F obj2 = _0005._0002();
		_0005._0005((global::_000F)new global::_0006(global::_000F_2001._0005(obj2, obj) ? 1 : 0));
	}

	private global::_000F _0005()
	{
		return this.m__0005_200B ?? this.m__0003.Peek();
	}

	private static _0002_2008 _0005(_000F_2001 _0005)
	{
		global::_000F obj = _0005._0002();
		global::_000F obj2 = _0005._0002();
		global::_000F obj3 = _0005._0002();
		if (obj._0005() != 13)
		{
			throw new InvalidOperationException();
		}
		long num = ((_0003_2003)obj)._0005();
		int num2 = obj2._0005();
		if (num2 != 7 && num2 != 9)
		{
			throw new InvalidOperationException();
		}
		byte[] array = global::_0008_2003._0005(obj2._000F_2001_2004_2001_0005());
		if (obj3._0005() != 1)
		{
			throw new InvalidOperationException();
		}
		int num3 = ((global::_0006)obj3)._0005();
		_0002_2008 obj4 = new _0002_2008();
		obj4._0005(num3);
		obj4._0005(array);
		obj4._0005(num);
		return obj4;
	}

	private static void _0006_2008_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(0);
	}

	private static void _0003_2007_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		if (global::_000F_2001._0005(_0005._0002(), obj))
		{
			uint num = ((_0006_200B)_0002)._0005();
			_0005._0005(num);
		}
	}

	private static void _0005_2000_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(typeof(uint));
	}

	private static global::_000F _0003(global::_000F _0005, global::_000F _0002, bool _000F, bool _0006)
	{
		if (_0005._0005() == 1)
		{
			if (_0002._0005() == 1)
			{
				if (!_0006)
				{
					int num = ((global::_0006)_0005)._0005();
					int num2 = ((global::_0006)_0002)._0005();
					int num3 = ((!_000F) ? (num * num2) : checked(num * num2));
					return new global::_0006(num3);
				}
				uint num4 = (uint)((global::_0006)_0005)._0005();
				uint num5 = (uint)((global::_0006)_0002)._0005();
				uint num6 = ((!_000F) ? (num4 * num5) : checked(num4 * num5));
				return new global::_0006((int)num6);
			}
			if (_0002._0005() == 13)
			{
				return global::_000F_2001._000F(new _0003_2003(((global::_0006)_0005)._0005()), _0002, _000F, _0006);
			}
			if (_0002._0005() == 19)
			{
				Type underlyingType = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
				{
					return global::_000F_2001._000F(new _0003_2003(((global::_0006)_0005)._0005()), new _0003_2003(Convert.ToInt64(_0002._000F_2001_2004_2001_0005())), _000F, _0006);
				}
				return _0003(_0005, new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())), _000F, _0006);
			}
		}
		if (_0005._0005() == 13)
		{
			if (_0002._0005() == 13)
			{
				return global::_000F_2001._000F(_0005, _0002, _000F, _0006);
			}
			if (_0002._0005() == 1)
			{
				return global::_000F_2001._000F(_0005, new _0003_2003(((global::_0006)_0002)._0005()), _000F, _0006);
			}
			if (_0002._0005() == 19)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return global::_000F_2001._000F(_0005, new _0003_2003(Convert.ToInt64(_0002._000F_2001_2004_2001_0005())), _000F, _0006);
				}
				return global::_000F_2001._000F(_0005, new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())), _000F, _0006);
			}
		}
		if (_0005._0005() == 8 && _0002._0005() == 8)
		{
			_000F_2006 obj = new _000F_2006();
			obj._0005(((_000F_2006)_0005)._0005() * ((_000F_2006)_0002)._0005());
			return obj;
		}
		if (_0005._0005() == 19)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
			if (underlyingType3 == typeof(long) || underlyingType3 == typeof(ulong))
			{
				return _0003(new _0003_2003(Convert.ToInt64(_0005._000F_2001_2004_2001_0005())), _0002, _000F, _0006);
			}
			return _0003(new global::_0006(Convert.ToInt32(_0005._000F_2001_2004_2001_0005())), _0002, _000F, _0006);
		}
		throw new InvalidOperationException();
	}

	private int _0002()
	{
		return 1561836065;
	}

	private object _0005(int _0005)
	{
		switch (global::_0006_2001._0005(_0005))
		{
		case 16777216:
		case 33554432:
		case 452984832:
			return this.m__0008_2001.ModuleHandle.ResolveTypeHandle(_0005);
		case 67108864:
			return this.m__0008_2001.ModuleHandle.ResolveFieldHandle(_0005);
		case 100663296:
		case 721420288:
			return this.m__0008_2001.ModuleHandle.ResolveMethodHandle(_0005);
		case 167772160:
			try
			{
				return this.m__0008_2001.ModuleHandle.ResolveFieldHandle(_0005);
			}
			catch
			{
				try
				{
					return this.m__0008_2001.ModuleHandle.ResolveMethodHandle(_0005);
				}
				catch
				{
					throw new InvalidOperationException();
				}
			}
		default:
			throw new InvalidOperationException();
		}
	}

	private static void _0006_2006(_000F_2001 _0005, global::_000F _0002)
	{
		object obj = _0005._0002()._000F_2001_2004_2001_0005();
		long num = _0005._0002();
		Array array = (Array)_0005._0002()._000F_2001_2004_2001_0005();
		Type elementType = array.GetType().GetElementType();
		if (elementType == typeof(sbyte))
		{
			global::_000F obj2 = global::_000F._0005(obj, typeof(sbyte));
			((sbyte[])array)[num] = (sbyte)obj2._000F_2001_2004_2001_0005();
		}
		else if (elementType == typeof(byte))
		{
			global::_000F obj3 = global::_000F._0005(obj, typeof(byte));
			((byte[])array)[num] = (byte)obj3._000F_2001_2004_2001_0005();
		}
		else if (elementType == typeof(bool))
		{
			global::_000F obj4 = global::_000F._0005(obj, typeof(bool));
			((bool[])array)[num] = (bool)obj4._000F_2001_2004_2001_0005();
		}
		else if (elementType.IsEnum)
		{
			_0005._0005(elementType, obj, num, array);
		}
		else
		{
			_0005._0005(typeof(sbyte), obj, num, array);
		}
	}

	private global::_000F _0005(global::_000F _0005, global::_000F _0002, bool _000F)
	{
		if (_0005._0005() == 1)
		{
			if (_0002._0005() == 1)
			{
				if (!_000F)
				{
					int num = ((global::_0006)_0005)._0005();
					int num2 = ((global::_0006)_0002)._0005();
					return new global::_0006(num / num2);
				}
				int num3 = ((global::_0006)_0005)._0005();
				uint num4 = (uint)((global::_0006)_0002)._0005();
				return new global::_0006((int)((uint)num3 / num4));
			}
			if (_0002._0005() == 13)
			{
				return _0006(new _0003_2003(((global::_0006)_0005)._0005()), _0002, _000F);
			}
			if (_0002._0005() == 19)
			{
				Type underlyingType = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
				{
					return _0006(new _0003_2003(((global::_0006)_0005)._0005()), new _0003_2003(Convert.ToInt64(_0002._000F_2001_2004_2001_0005())), _000F);
				}
				return this._0005(_0005, (global::_000F)new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())), _000F);
			}
		}
		if (_0005._0005() == 13)
		{
			if (_0002._0005() == 13)
			{
				return _0006(_0005, _0002, _000F);
			}
			if (_0002._0005() == 1)
			{
				return _0006(_0005, new _0003_2003(((global::_0006)_0002)._0005()), _000F);
			}
			if (_0002._0005() == 19)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return _0006(_0005, new _0003_2003(Convert.ToInt64(_0002._000F_2001_2004_2001_0005())), _000F);
				}
				return _0006(_0005, new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())), _000F);
			}
		}
		if (_0005._0005() == 8 && _0002._0005() == 8)
		{
			_000F_2006 obj = new _000F_2006();
			obj._0005(((_000F_2006)_0005)._0005() / ((_000F_2006)_0002)._0005());
			return obj;
		}
		if (_0005._0005() == 19)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
			if (underlyingType3 == typeof(long) || underlyingType3 == typeof(ulong))
			{
				return this._0005((global::_000F)new _0003_2003(Convert.ToInt64(_0005._000F_2001_2004_2001_0005())), _0002, _000F);
			}
			return this._0005((global::_000F)new global::_0006(Convert.ToInt32(_0005._000F_2001_2004_2001_0005())), _0002, _000F);
		}
		throw new InvalidOperationException();
	}

	private global::_000F _0002(global::_000F _0005)
	{
		if (_0005._0005() == 1)
		{
			int num = ((global::_0006)_0005)._0005();
			global::_0006 obj = new global::_0006();
			obj._0005(~num);
			return obj;
		}
		if (_0005._0005() == 13)
		{
			long num2 = ((_0003_2003)_0005)._0005();
			_0003_2003 obj2 = new _0003_2003();
			obj2._0005(~num2);
			return obj2;
		}
		if (_0005._0005() == 19)
		{
			Type underlyingType = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
			if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
			{
				return new _0003_2003(~Convert.ToInt64(_0005._000F_2001_2004_2001_0005()));
			}
			return new global::_0006(~Convert.ToInt32(_0005._000F_2001_2004_2001_0005()));
		}
		throw new InvalidOperationException();
	}

	private static void _0002_2001(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002_2009(_0005: true);
	}

	private _0008_2009 _0005(_0005_2009_200B _0005)
	{
		switch (_0005._0005())
		{
		case 2:
		{
			_0008_2002 obj7 = new _0008_2002();
			obj7._0005(_0005._0005());
			obj7._0002(_0005._0005());
			obj7._0005(_0005._0005());
			obj7._0002(_0005._0008());
			obj7._0005(_0005._0008());
			_0008_2002 obj8 = obj7;
			int num5 = _0005._0006();
			global::_0005[] array3 = new global::_0005[num5];
			for (int k = 0; k < num5; k++)
			{
				int num6 = k;
				global::_0005 obj9 = new global::_0005();
				obj9._0005((byte)1);
				obj9._0005(_0005._0008());
				array3[num6] = obj9;
			}
			obj8._0005(array3);
			return obj8;
		}
		case 1:
		{
			global::_0003_2009 obj11 = new global::_0003_2009();
			global::_0005 obj12 = new global::_0005();
			obj12._0005((byte)1);
			obj12._0005(_0005._0008());
			obj11._0005(obj12);
			obj11._0005(_0005._0005());
			obj11._0005(_0005._0005());
			return obj11;
		}
		case 3:
		{
			_0005_2006 obj10 = new _0005_2006();
			obj10._0005(_0005._0008());
			obj10._0002(_0005._0008());
			return obj10;
		}
		case 0:
		{
			_0008_2005 obj2 = new _0008_2005();
			global::_0005 obj3 = new global::_0005();
			obj3._0005((byte)1);
			obj3._0005(_0005._0008());
			obj2._0005(obj3);
			obj2._0005(_0005._0005());
			obj2._0005(_0005._0005());
			global::_0005 obj4 = new global::_0005();
			obj4._0005((byte)1);
			obj4._0005(_0005._0008());
			obj2._0002(obj4);
			int num = _0005._0006();
			global::_0005[] array = new global::_0005[num];
			for (int i = 0; i < num; i++)
			{
				int num2 = i;
				global::_0005 obj5 = new global::_0005();
				obj5._0005((byte)1);
				obj5._0005(_0005._0008());
				array[num2] = obj5;
			}
			obj2._0005(array);
			int num3 = _0005._0006();
			global::_0005[] array2 = new global::_0005[num3];
			for (int j = 0; j < num3; j++)
			{
				int num4 = j;
				global::_0005 obj6 = new global::_0005();
				obj6._0005((byte)1);
				obj6._0005(_0005._0008());
				array2[num4] = obj6;
			}
			obj2._0002(array2);
			return obj2;
		}
		case 4:
		{
			_000F_2004 obj = new _000F_2004();
			obj._0005(_0005._0005());
			return obj;
		}
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	private static void _0002_2009_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(typeof(sbyte));
	}

	private static void _0003_2006_200B(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		Type type = _0005._0005(num, _0002: true);
		global::_000F obj = _0005._0002();
		if (_0005._0005(obj, type))
		{
			_0005._0005(obj);
		}
		else
		{
			_0005._0005((global::_000F)new _0008_2008());
		}
	}

	private static void _0008_2002_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(global::_000F_2001.m__000E_200A);
	}

	private static void _0002_2005(_000F_2001 _0005, global::_000F _0002)
	{
		uint num = ((_0006_200B)_0002)._0005();
		_0005._0005(num);
	}

	private static void _000E_2008_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(true);
	}

	private static void _0003_2002(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003();
	}

	private static void _0002_200A_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(_0002);
	}

	private static void _000E_2002(_000F_2001 _0005, global::_000F _0002)
	{
		global::_0006 obj = (global::_0006)_0002;
		MethodBase methodBase = _0005._0005(obj._0005());
		_0006_2009_200B obj2 = new _0006_2009_200B();
		obj2._0005(methodBase);
		_0005._0005((global::_000F)obj2);
	}

	private static void _000E_200A_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0008(_0005: false);
	}

	private static void _0002_2007(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		UIntPtr uIntPtr = obj._0005() switch
		{
			1 => new UIntPtr((uint)((global::_0006)obj)._0005()), 
			13 => new UIntPtr((ulong)((_0003_2003)obj)._0005()), 
			19 => new UIntPtr(Convert.ToUInt64(((_0005_0019)obj)._0005())), 
			8 => new UIntPtr((ulong)((_000F_2006)obj)._0005()), 
			_ => throw new InvalidOperationException(), 
		};
		_0005_2008 obj2 = new _0005_2008();
		obj2._0005(uIntPtr);
		_0005._0005((global::_000F)obj2);
	}

	private void _0005_2009(bool _0005)
	{
		global::_000F obj = _0002();
		bool flag = IntPtr.Size == 4;
		IntPtr intPtr;
		switch (obj._0005())
		{
		case 1:
		{
			int value = ((global::_0006)obj)._0005();
			intPtr = ((!_0005) ? new IntPtr(value) : new IntPtr(value));
			break;
		}
		case 13:
		{
			long num = ((_0003_2003)obj)._0005();
			if (flag)
			{
				intPtr = ((!_0005) ? new IntPtr((int)num) : new IntPtr(checked((int)num)));
			}
			else
			{
				intPtr = ((!_0005) ? new IntPtr(num) : new IntPtr(num));
			}
			break;
		}
		case 8:
		{
			double num2 = ((_000F_2006)obj)._0005();
			if (flag)
			{
				intPtr = ((!_0005) ? new IntPtr((int)num2) : new IntPtr(checked((int)num2)));
			}
			else
			{
				intPtr = ((!_0005) ? new IntPtr((long)num2) : new IntPtr(checked((long)num2)));
			}
			break;
		}
		case 19:
			intPtr = ((!_0005) ? new IntPtr((long)Convert.ToUInt64(((_0005_0019)obj)._0005())) : new IntPtr(checked((long)Convert.ToUInt64(((_0005_0019)obj)._0005()))));
			break;
		default:
			throw new InvalidOperationException();
		}
		_000F_2002 obj2 = new _000F_2002();
		obj2._0005(intPtr);
		this._0005((global::_000F)obj2);
	}

	private static void _0006_2002_200B(_000F_2001 _0005, global::_000F _0002)
	{
		Array array = (Array)_0005._0002()._000F_2001_2004_2001_0005();
		_0005._0005((global::_000F)new global::_0006(array.Length));
	}

	private static void _0005_2003_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(-1);
	}

	private static void _0008_2000(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		_0005._0005((global::_000F)new _0003_2003(obj._0005() switch
		{
			1 => (uint)((global::_0006)obj)._0005(), 
			13 => ((_0003_2003)obj)._0005(), 
			19 => (long)Convert.ToUInt64(((_0005_0019)obj)._0005()), 
			8 => (long)checked((ulong)((_000F_2006)obj)._0005()), 
			0 => (IntPtr.Size != 4) ? ((long)((_000F_2002)obj)._0005()) : ((uint)(int)((_000F_2002)obj)._0005()), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private static void _000E_2008(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		FieldInfo fieldInfo = _0005._0005(num);
		global::_000F obj = _0005._0002();
		global::_000F obj2 = _0005._0002();
		global::_0005_2009 obj3 = obj2 as global::_0005_2009;
		object obj4 = ((obj3 == null) ? obj2._000F_2001_2004_2001_0005() : _0005._0005(obj3)._000F_2001_2004_2001_0005());
		if (obj4 == null)
		{
			throw new NullReferenceException();
		}
		global::_000F obj5 = global::_000F._0005(obj._000F_2001_2004_2001_0005(), fieldInfo.FieldType);
		fieldInfo.SetValue(obj4, obj5._000F_2001_2004_2001_0005());
		if (obj3 != null && obj4 != null && obj4.GetType().IsValueType)
		{
			_0005._0005(obj3, global::_000F._0005(obj4, null));
		}
	}

	private long _0002()
	{
		global::_000F obj = _0002();
		return obj._0005() switch
		{
			1 => ((global::_0006)obj)._0005(), 
			0 => ((_000F_2002)obj)._0005().ToInt64(), 
			20 => (long)((_0005_2008)obj)._0005().ToUInt64(), 
			19 => Convert.ToInt64(((_0005_0019)obj)._0005()), 
			_ => throw new Exception(_000F_0019._0005(-1057762936)), 
		};
	}

	private static void _000F(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(0);
	}

	private static bool _0005(object _0005)
	{
		return RemotingServices.IsTransparentProxy(_0005);
	}

	private static void _0002_2004_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		if (_0008(_0005._0002(), obj))
		{
			uint num = ((_0006_200B)_0002)._0005();
			_0005._0005(num);
		}
	}

	private void _000E()
	{
		this.m__0005_200B = null;
		this.m__0005_2008 = null;
		this.m__0003.Clear();
	}

	private void _0005(MemberInfo _0005)
	{
		if (!global::_000F_2001._0005() || this.m__000E_2008._0002())
		{
			return;
		}
		bool flag = false;
		Assembly assembly = typeof(SecurityCriticalAttribute).Assembly;
		MemberInfo memberInfo = _0005;
		while (memberInfo != null)
		{
			object[] customAttributes = memberInfo.GetCustomAttributes(inherit: false);
			for (int i = 0; i < customAttributes.Length; i++)
			{
				Type type = customAttributes[i].GetType();
				if (type.Assembly == assembly)
				{
					string fullName = type.FullName;
					if (_000F_0019._0005(-1057763215).Equals(fullName, StringComparison.Ordinal))
					{
						flag = true;
						goto end_IL_009d;
					}
					if (_000F_0019._0005(-1057762431).Equals(fullName, StringComparison.Ordinal))
					{
						goto end_IL_009d;
					}
				}
			}
			memberInfo = memberInfo.DeclaringType;
			continue;
			end_IL_009d:
			break;
		}
		if (flag)
		{
			if (_0005 is MethodBase)
			{
				string text = global::_000F_2001._0005((MethodBase)_0005);
				throw global::_000F_2001._0005(this._0005(this.m__000E_2008), text);
			}
			if (_0005 is FieldInfo)
			{
				string text2 = _0005.DeclaringType.FullName + _000F_0019._0005(-1057761762) + _0005.Name;
				throw _0002(this._0005(this.m__000E_2008), text2);
			}
			if (_0005 is Type)
			{
				string fullName2 = ((Type)_0005).FullName;
				throw _000F(this._0005(this.m__000E_2008), fullName2);
			}
			throw new SecurityException(_000F_0019._0005(-1057762339));
		}
	}

	private static void _0002_2009(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0005();
		_0005._0005(obj._000F_2001_2004_2001_0005());
	}

	private static void _0008_2007_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000E_2009(_0005: true);
	}

	private static void _0003_2009_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(5);
	}

	private void _0002(int _0005)
	{
		this._0005((global::_000F)new global::_0006(_0005));
	}

	private static byte[] _0005(_0005_2009_200B _0005)
	{
		int num = _0005._0008();
		byte[] array = new byte[num];
		_0005._0005(array, 0, num);
		return array;
	}

	private void _0005_2009()
	{
		if (!this.m__000F_200A._0005())
		{
			lock (this.m__000F_200A)
			{
				if (!this.m__000F_200A._0005())
				{
					global::_000F_2001.m__0006_2009 = _0005(this.m__000F_200A);
					_000F();
					this.m__000F_200A._0005(_0005: true);
				}
			}
		}
		if (global::_000F_2001.m__0006_2009 == null)
		{
			global::_000F_2001.m__0006_2009 = _0005(this.m__000F_200A);
		}
	}

	private static void _0008_200A_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(2);
	}

	private static global::_000F _000F(global::_000F _0005, global::_000F _0002, bool _000F, bool _0006)
	{
		if (!_0006)
		{
			long num = ((_0003_2003)_0005)._0005();
			long num2 = ((_0003_2003)_0002)._0005();
			long num3 = ((!_000F) ? (num * num2) : checked(num * num2));
			return new _0003_2003(num3);
		}
		ulong num4 = (ulong)((_0003_2003)_0005)._0005();
		ulong num5 = (ulong)((_0003_2003)_0002)._0005();
		ulong num6 = ((!_000F) ? (num4 * num5) : checked(num4 * num5));
		return new _0003_2003((long)num6);
	}

	private static void _000E_2003_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		checked
		{
			_0005._0005((global::_000F)new global::_0006(obj._0005() switch
			{
				1 => unchecked((int)checked((ushort)(uint)((global::_0006)obj)._0005())), 
				13 => (ushort)(ulong)((_0003_2003)obj)._0005(), 
				19 => (ushort)Convert.ToUInt64(((_0005_0019)obj)._0005()), 
				8 => (ushort)((_000F_2006)obj)._0005(), 
				0 => (IntPtr.Size != 4) ? ((ushort)(ulong)(long)((_000F_2002)obj)._0005()) : ((ushort)(uint)(int)((_000F_2002)obj)._0005()), 
				_ => throw new InvalidOperationException(), 
			}));
		}
	}

	private _0008_2004[] _0005(_0005_2009_200B _0005)
	{
		_0008_2004[] array = new _0008_2004[_0005._0005()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = this._0005(_0005);
		}
		return array;
	}

	private static void _0006_200A_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(_0005: false);
	}

	private static void _0006_2006_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_0006 obj = (global::_0006)_0002;
		MethodBase methodBase = _0005._0005(obj._0005());
		_0005._0005(methodBase, false);
	}

	private void _0003(int _0005)
	{
		this._0005(this.m__0006_200A[_0005]._000F_2001_2004_2001_0005());
	}

	private static void _0006_2000(_000F_2001 _0005, global::_000F _0002)
	{
		global::_0006 obj = (global::_0006)_0002;
		MethodBase methodBase = _0005._0005(obj._0005());
		Type declaringType = methodBase.DeclaringType;
		Type type = _0005._0002()._000F_2001_2004_2001_0005().GetType();
		ParameterInfo[] parameters = methodBase.GetParameters();
		Type[] array = new Type[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			array[i] = parameters[i].ParameterType;
		}
		MethodBase methodBase2 = null;
		Type type2 = type;
		while (type2 != null && type2 != declaringType)
		{
			MethodInfo method = type2.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
			if (method != null && method.GetBaseDefinition() == methodBase)
			{
				methodBase2 = method;
				break;
			}
			type2 = type2.BaseType;
		}
		if (methodBase2 == null)
		{
			methodBase2 = methodBase;
		}
		_0006_2009_200B obj2 = new _0006_2009_200B();
		obj2._0005(methodBase2);
		_0005._0005((global::_000F)obj2);
	}

	private static void _0005_2001_200B(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		global::_0005 obj = _0005._0005(num);
		object obj2 = ((obj._0005() == 0) ? _0005._0005(obj._0005()) : (obj._0005()._0008_2009_2001_2004_2001_0005() switch
		{
			2 => (object)_0005._0005(num, _0002: true).TypeHandle, 
			0 => _0005._0005(num).MethodHandle, 
			1 => _0005._0005(num).FieldHandle, 
			_ => throw new InvalidOperationException(), 
		}));
		_0008_2008 obj3 = new _0008_2008();
		obj3._0005(obj2);
		_0005._0005((global::_000F)obj3);
	}

	private static void _000E_2001(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(global::_0005_2004._0005);
	}

	private void _000F(Type _0005)
	{
		long index = _0002();
		Array array = (Array)_0002()._000F_2001_2004_2001_0005();
		this._0005(global::_000F._0005(array.GetValue(index), _0005));
	}

	private static void _0008_2006(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		float num = obj._0005() switch
		{
			1 => ((global::_0006)obj)._0005(), 
			13 => ((_0003_2003)obj)._0005(), 
			19 => Convert.ToUInt64(((_0005_0019)obj)._0005()), 
			8 => (float)((_000F_2006)obj)._0005(), 
			_ => throw new InvalidOperationException(), 
		};
		_000F_2006 obj2 = new _000F_2006();
		obj2._0005(num);
		_0005._0005((global::_000F)obj2);
	}

	private static void _0006_2008(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003();
	}

	private void _0002(Type _0005)
	{
		global::_0005_2009 obj = (global::_0005_2009)_0002();
		this._0005(global::_000F._0005(this._0005(obj)._000F_2001_2004_2001_0005(), _0005));
	}

	private static void _0008_2000_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(typeof(int));
	}

	private static void _0006_200A_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		double num = obj._0005() switch
		{
			1 => (double)(uint)((global::_0006)obj)._0005(), 
			13 => (ulong)((_0003_2003)obj)._0005(), 
			19 => Convert.ToUInt64(((_0005_0019)obj)._0005()), 
			_ => throw new InvalidOperationException(), 
		};
		_000F_2006 obj2 = new _000F_2006();
		obj2._0005(num);
		_0005._0005((global::_000F)obj2);
	}

	private void _0003(bool _0005)
	{
		global::_000F obj = _0002();
		sbyte b = obj._0005() switch
		{
			1 => (!_0005) ? ((sbyte)((global::_0006)obj)._0005()) : checked((sbyte)((global::_0006)obj)._0005()), 
			13 => (!_0005) ? ((sbyte)((_0003_2003)obj)._0005()) : checked((sbyte)((_0003_2003)obj)._0005()), 
			19 => (!_0005) ? ((sbyte)Convert.ToUInt64(((_0005_0019)obj)._0005())) : checked((sbyte)Convert.ToUInt64(((_0005_0019)obj)._0005())), 
			8 => (!_0005) ? ((sbyte)((_000F_2006)obj)._0005()) : checked((sbyte)((_000F_2006)obj)._0005()), 
			0 => (IntPtr.Size != 4) ? ((!_0005) ? ((sbyte)(long)((_000F_2002)obj)._0005()) : checked((sbyte)(long)((_000F_2002)obj)._0005())) : ((!_0005) ? ((sbyte)(int)((_000F_2002)obj)._0005()) : checked((sbyte)(int)((_000F_2002)obj)._0005())), 
			_ => throw new InvalidOperationException(), 
		};
		global::_0006 obj2 = new global::_0006();
		obj2._0005(b);
		this._0005((global::_000F)obj2);
	}

	private static void _0006_2008_2005(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		global::_000F obj2 = _0005._0002();
		if ((obj2._0005() != 8) ? (!global::_000F_2001._0002(obj2, obj)) : (!_0008(obj2, obj)))
		{
			uint num = ((_0006_200B)_0002)._0005();
			_0005._0005(num);
		}
	}

	private static void _0005_2005_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(typeof(int));
	}

	private static void _0002_200A_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0006(((_0002_2009_200B)_0002)._0005());
	}

	private static global::_000F _0002(global::_000F _0005, global::_000F _0002, bool _000F)
	{
		if (_0005._0005() == 1)
		{
			if (_0002._0005() == 1)
			{
				if (!_000F)
				{
					int num = ((global::_0006)_0005)._0005();
					int num2 = ((global::_0006)_0002)._0005();
					return new global::_0006(num % num2);
				}
				int num3 = ((global::_0006)_0005)._0005();
				uint num4 = (uint)((global::_0006)_0002)._0005();
				return new global::_0006((int)((uint)num3 % num4));
			}
			if (_0002._0005() == 13)
			{
				return global::_000F_2001._0005((global::_000F)new _0003_2003(((global::_0006)_0005)._0005()), _0002, _000F);
			}
			if (_0002._0005() == 19)
			{
				Type underlyingType = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
				{
					return global::_000F_2001._0005((global::_000F)new _0003_2003(((global::_0006)_0005)._0005()), (global::_000F)new _0003_2003(Convert.ToInt64(_0002._000F_2001_2004_2001_0005())), _000F);
				}
				return global::_000F_2001._0002(_0005, new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())), _000F);
			}
		}
		if (_0005._0005() == 13)
		{
			if (_0002._0005() == 13)
			{
				return global::_000F_2001._0005(_0005, _0002, _000F);
			}
			if (_0002._0005() == 1)
			{
				return global::_000F_2001._0005(_0005, (global::_000F)new _0003_2003(((global::_0006)_0002)._0005()), _000F);
			}
			if (_0002._0005() == 19)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return global::_000F_2001._0005(_0005, (global::_000F)new _0003_2003(Convert.ToInt64(_0002._000F_2001_2004_2001_0005())), _000F);
				}
				return global::_000F_2001._0005(_0005, (global::_000F)new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())), _000F);
			}
		}
		if (_0005._0005() == 8 && _0002._0005() == 8)
		{
			_000F_2006 obj = new _000F_2006();
			obj._0005(((_000F_2006)_0005)._0005() % ((_000F_2006)_0002)._0005());
			return obj;
		}
		if (_0005._0005() == 19)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
			if (underlyingType3 == typeof(long) || underlyingType3 == typeof(ulong))
			{
				return global::_000F_2001._0002(new _0003_2003(Convert.ToInt64(_0005._000F_2001_2004_2001_0005())), _0002, _000F);
			}
			return global::_000F_2001._0002(new global::_0006(Convert.ToInt32(_0005._000F_2001_2004_2001_0005())), _0002, _000F);
		}
		throw new InvalidOperationException();
	}

	private static void _000E_2003(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(_0005: true);
	}

	private global::_0005 _0005(int _0005)
	{
		if (this.m__0005_2009 == null)
		{
			throw new InvalidOperationException();
		}
		lock (this.m__0005_2009._0005())
		{
			this.m__0005_2009._0005()._0008_2001_2004_2001_0005(_0005, 0);
			global::_0005 obj = new global::_0005();
			obj._0005(this.m__0005_2009._0005());
			if (obj._0005() == 0)
			{
				obj._0005(this.m__0005_2009._0008());
			}
			else
			{
				obj._0005(this._0005(this.m__0005_2009));
			}
			return obj;
		}
	}

	private static void _000E_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(0);
	}

	private _0008_2004 _0005(_0005_2009_200B _0005)
	{
		_0008_2004 obj = new _0008_2004();
		obj._0005(_0005._0008());
		return obj;
	}

	private global::_000F _0005(global::_000F _0005)
	{
		if (_0005._0005() == 1)
		{
			return new global::_0006(-((global::_0006)_0005)._0005());
		}
		if (_0005._0005() == 13)
		{
			return new _0003_2003(-((_0003_2003)_0005)._0005());
		}
		if (_0005._0005() == 8)
		{
			_000F_2006 obj = new _000F_2006();
			obj._0005(0.0 - ((_000F_2006)_0005)._0005());
			return obj;
		}
		if (_0005._0005() == 19)
		{
			Type underlyingType = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
			if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
			{
				return this._0005((global::_000F)new _0003_2003(Convert.ToInt64(_0005._000F_2001_2004_2001_0005())));
			}
			return this._0005((global::_000F)new global::_0006(Convert.ToInt32(_0005._000F_2001_2004_2001_0005())));
		}
		throw new InvalidOperationException();
	}

	private static void _0005(Exception _0005)
	{
		ExceptionDispatchInfo.Capture(_0005).Throw();
	}

	private static void _0005_2008(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002();
	}

	private global::_000F _000F(global::_000F _0005, global::_000F _0002)
	{
		if (_0005._0005() == 1)
		{
			if (_0002._0005() == 1)
			{
				int num = ((global::_0006)_0005)._0005();
				int num2 = ((global::_0006)_0002)._0005();
				return new global::_0006(num | num2);
			}
			if (_0002._0005() == 19)
			{
				int num3 = ((global::_0006)_0005)._0005();
				Type underlyingType = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
				{
					long num4 = Convert.ToInt64(_0002._000F_2001_2004_2001_0005());
					return new _0003_2003(num3 | num4);
				}
				int num5 = Convert.ToInt32(_0002._000F_2001_2004_2001_0005());
				return new global::_0006(num3 | num5);
			}
		}
		if (_0005._0005() == 13)
		{
			if (_0002._0005() == 13)
			{
				long num6 = ((_0003_2003)_0005)._0005();
				long num7 = ((_0003_2003)_0002)._0005();
				return new _0003_2003(num6 | num7);
			}
			if (_0002._0005() == 19)
			{
				int num8 = ((global::_0006)_0005)._0005();
				long num9 = Convert.ToInt64(_0002._000F_2001_2004_2001_0005());
				return new _0003_2003(num8 | num9);
			}
		}
		if (_0005._0005() == 19)
		{
			if (_0002._0005() == 1)
			{
				int num10 = ((global::_0006)_0002)._0005();
				Type underlyingType2 = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return new _0003_2003(Convert.ToInt64(_0002._000F_2001_2004_2001_0005()) | num10);
				}
				return new global::_0006(Convert.ToInt32(_0005._000F_2001_2004_2001_0005()) | num10);
			}
			if (_0002._0005() == 13)
			{
				long num11 = Convert.ToInt64(_0005._000F_2001_2004_2001_0005());
				long num12 = ((_0003_2003)_0002)._0005();
				return new _0003_2003(num11 | num12);
			}
			if (_0002._0005() == 19)
			{
				Type underlyingType3 = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
				Type underlyingType4 = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType3 == typeof(long) || underlyingType3 == typeof(ulong) || underlyingType4 == typeof(long) || underlyingType4 == typeof(ulong))
				{
					long num13 = Convert.ToInt64(_0005._000F_2001_2004_2001_0005());
					long num14 = Convert.ToInt64(_0002._000F_2001_2004_2001_0005());
					return new _0003_2003(num13 | num14);
				}
				int num15 = Convert.ToInt32(_0005._000F_2001_2004_2001_0005());
				int num16 = Convert.ToInt32(_0002._000F_2001_2004_2001_0005());
				return new global::_0006(num15 | num16);
			}
		}
		throw new InvalidOperationException();
	}

	private void _0005()
	{
		if (this.m__0008_200A.Count == 0)
		{
			if (this.m__000F_2001)
			{
				_0005(this.m__0008_2009);
			}
			return;
		}
		_0002 obj = this.m__0008_200A.Pop();
		if (obj._0005() != null)
		{
			_0008_2008 obj2 = new _0008_2008();
			obj2._000F_2001_2004_2001_0005(obj._0005());
			_0005((global::_000F)obj2);
		}
		else
		{
			_000E();
		}
		_0005(obj._0005());
	}

	public static void _0005<T>(T[] _0005, Comparison<T> _0002)
	{
		KeyValuePair<int, T>[] array = new KeyValuePair<int, T>[_0005.Length];
		for (int i = 0; i < _0005.Length; i++)
		{
			array[i] = new KeyValuePair<int, T>(i, _0005[i]);
		}
		Array.Sort(array, _0005, new _0008_2009<T>(_0002));
	}

	private static bool _0005(uint _0005, uint _0002, uint _000F)
	{
		if (_0005 >= _0002)
		{
			return _0005 <= _0002 + _000F;
		}
		return false;
	}

	private void _0006_2009(bool _0005)
	{
		global::_000F obj = _0002();
		this._0005((global::_000F)new global::_0006(obj._0005() switch
		{
			1 => (int)((!_0005) ? ((ushort)((global::_0006)obj)._0005()) : checked((ushort)(uint)((global::_0006)obj)._0005())), 
			13 => (!_0005) ? ((ushort)((_0003_2003)obj)._0005()) : checked((ushort)(ulong)((_0003_2003)obj)._0005()), 
			19 => (!_0005) ? ((ushort)Convert.ToUInt64(((_0005_0019)obj)._0005())) : checked((ushort)Convert.ToUInt64(((_0005_0019)obj)._0005())), 
			8 => (!_0005) ? ((ushort)((_000F_2006)obj)._0005()) : checked((ushort)((_000F_2006)obj)._0005()), 
			0 => (IntPtr.Size != 4) ? ((!_0005) ? ((ushort)(long)((_000F_2002)obj)._0005()) : checked((ushort)(ulong)(long)((_000F_2002)obj)._0005())) : ((!_0005) ? ((ushort)(int)((_000F_2002)obj)._0005()) : checked((ushort)(int)((_000F_2002)obj)._0005())), 
			20 => (UIntPtr.Size != 4) ? ((!_0005) ? ((ushort)(ulong)((_0005_2008)obj)._0005()) : checked((ushort)(ulong)((_0005_2008)obj)._0005())) : ((!_0005) ? ((ushort)(uint)((_0005_2008)obj)._0005()) : checked((ushort)(uint)((_0005_2008)obj)._0005())), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	[DebuggerNonUserCode]
	private MethodBase _0005(int _0005)
	{
		global::_0005 obj = this._0005(_0005);
		MethodBase methodBase = this._0005(_0005, obj);
		this._0005((MemberInfo)methodBase);
		return methodBase;
	}

	[DebuggerNonUserCode]
	private MethodBase _0005(int _0005, global::_0005 _0002)
	{
		lock (global::_000F_2001.m__000E_2001)
		{
			bool flag = true;
			if (flag && global::_000F_2001.m__000E_2001.TryGetValue(_0005, out var value))
			{
				return (MethodBase)value;
			}
			if (_0002._0005() == 0)
			{
				MethodBase methodBase = this.m__0008_2001.ResolveMethod(_0002._0005());
				if (flag)
				{
					global::_000F_2001.m__000E_2001.Add(_0005, methodBase);
				}
				return methodBase;
			}
			_0008_2005 obj = (_0008_2005)_0002._0005();
			if (obj._0002())
			{
				return this._0005(obj);
			}
			Type type = this._0005(obj._0005()._0005(), _0002: false);
			Type type2 = this._0005(obj._0002()._0005(), _0002: true);
			Type[] array = new Type[obj._0005().Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = this._0005(obj._0005()[i]._0005(), _0002: true);
			}
			if (type.IsGenericType)
			{
				flag = false;
			}
			if (obj._0005() == _000F_0019._0005(-1057763327))
			{
				ConstructorInfo constructorInfo = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.Any, array, null) ?? throw new Exception();
				if (flag)
				{
					global::_000F_2001.m__000E_2001.Add(_0005, constructorInfo);
				}
				return constructorInfo;
			}
			BindingFlags bindingAttr = global::_000F_2001._0005(obj._0005());
			MethodBase methodBase2 = null;
			try
			{
				methodBase2 = type.GetMethod(obj._0005(), bindingAttr, null, CallingConventions.Any, array, null);
			}
			catch (AmbiguousMatchException)
			{
				MethodInfo[] methods = type.GetMethods(bindingAttr);
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name != obj._0005() || methodInfo.ReturnType != type2)
					{
						continue;
					}
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if (parameters.Length != array.Length)
					{
						continue;
					}
					bool flag2 = false;
					for (int k = 0; k < array.Length; k++)
					{
						if (parameters[k].ParameterType != array[k])
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						methodBase2 = methodInfo;
						break;
					}
				}
			}
			if (methodBase2 == null)
			{
				throw new Exception(string.Format(_000F_0019._0005(-1057763275), type.Name, obj._0005()));
			}
			if (flag)
			{
				global::_000F_2001.m__000E_2001.Add(_0005, methodBase2);
			}
			return methodBase2;
		}
	}

	private static void _0005_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000E(_0005: false);
	}

	private static bool _0005(global::_000F _0005, global::_000F _0002)
	{
		bool result = false;
		switch (_0005._0005())
		{
		case 1:
			if (_0002._0005() == 19)
			{
				return global::_000F_2001._0005(_0005, (global::_000F)new global::_0006(Convert.ToInt32(((_0005_0019)_0002)._0005())));
			}
			result = ((global::_0006)_0005)._0005() < ((global::_0006)_0002)._0005();
			break;
		case 13:
			if (_0002._0005() == 19)
			{
				return global::_000F_2001._0005(_0005, (global::_000F)new _0003_2003(Convert.ToInt64(((_0005_0019)_0002)._0005())));
			}
			if (_0002._0005() == 1)
			{
				return global::_000F_2001._0005(_0005, (global::_000F)new _0003_2003(((global::_0006)_0002)._0005()));
			}
			result = ((_0003_2003)_0005)._0005() < ((_0003_2003)_0002)._0005();
			break;
		case 19:
			return global::_000F_2001._0005((global::_000F)new _0003_2003(Convert.ToInt64(((_0005_0019)_0005)._0005())), _0002);
		case 8:
			result = ((_000F_2006)_0005)._0005() < ((_000F_2006)_0002)._0005();
			break;
		}
		return result;
	}

	private static _0003_2007[] _0005(_0005_2009_200B _0005)
	{
		int num = _0005._0005();
		_0003_2007[] array = new _0003_2007[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = global::_000F_2001._0005(_0005);
		}
		return array;
	}

	private static void _000F_2006(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(_0005: true, _0002: false);
	}

	private void _000F(global::_000F _0005)
	{
		global::_0006 obj = (global::_0006)_0005;
		MethodBase methodBase = this._0005(obj._0005());
		if (this.m__0008_200B != null)
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			int num = 0;
			ParameterInfo[] array2 = parameters;
			foreach (ParameterInfo parameterInfo in array2)
			{
				array[num++] = parameterInfo.ParameterType;
			}
			MethodInfo method = this.m__0008_200B.GetMethod(methodBase.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if (method != null)
			{
				methodBase = method;
			}
			this.m__0008_200B = null;
		}
		this._0005(methodBase, true);
	}

	private static void _0002_2002(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0006(((_0008_200A)_0002)._0005());
	}

	private static void _0008_2001_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003();
	}

	private static void _000F_2006_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003(((_0008_200A)_0002)._0005());
	}

	private static void _0003_2004_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002_2009(_0005: false);
	}

	private static object _0002(MethodBase _0005, object _0002, object[] _000F, bool _0006)
	{
		if (!global::_000F_2001._0003._0005)
		{
			return global::_000F_2001._0005(_0005, _0002, _000F);
		}
		return global::_000F_2001._0005(_0005, _0002, _000F, _0006);
	}

	private static void _0006_2004_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003();
	}

	private static void _0003_2003(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		_0005._0005(obj._000F_2001_2004_2001_0005());
	}

	private static void _0002_2004(_000F_2001 _0005, global::_000F _0002)
	{
		object obj = _0005._0002()._000F_2001_2004_2001_0005();
		long num = _0005._0002();
		Array array = (Array)_0005._0002()._000F_2001_2004_2001_0005();
		Type elementType = array.GetType().GetElementType();
		if (elementType == typeof(long))
		{
			global::_000F obj2 = global::_000F._0005(obj, typeof(long));
			((long[])array)[num] = (long)obj2._000F_2001_2004_2001_0005();
		}
		else if (elementType == typeof(ulong))
		{
			global::_000F obj3 = global::_000F._0005(obj, typeof(ulong));
			((ulong[])array)[num] = (ulong)obj3._000F_2001_2004_2001_0005();
		}
		else if (elementType.IsEnum)
		{
			_0005._0005(elementType, obj, num, array);
		}
		else
		{
			_0005._0005(typeof(long), obj, num, array);
		}
	}

	private static string _0005(string _0005, string _0002)
	{
		string fullName = typeof(_000F_2001).Assembly.FullName;
		return _000F_0019._0005(-1057762859) + _0005 + _000F_0019._0005(-1057762877) + _0002 + _000F_0019._0005(-1057762831) + Environment.NewLine + Environment.NewLine + _000F_0019._0005(-1057762848) + fullName + _000F_0019._0005(-1057763055);
	}

	private static void _0005(object _0005)
	{
		throw _0005;
	}

	private static Exception _000F(string _0005, string _0002)
	{
		return new TypeLoadException(global::_000F_2001._0005(_000F_0019._0005(-1057762093) + _0005 + _000F_0019._0005(-1057762049), _000F_0019._0005(-1057761714) + _0002 + _000F_0019._0005(-1057762049)));
	}

	private static void _0002_2006(_000F_2001 _0005, global::_000F _0002)
	{
		throw new NotSupportedException(_000F_0019._0005(-1057761316));
	}

	private static void _0006_2001_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		if (!global::_000F_2001._0005(_0005._0002(), obj))
		{
			uint num = ((_0006_200B)_0002)._0005();
			_0005._0005(num);
		}
	}

	private void _0005(global::_0005_2009 _0005, global::_000F _0002)
	{
		switch (((global::_000F)_0005)._0005())
		{
		case 2:
			((_0006_2005)_0005)._0005()._000F_2001_2004_2001_0005(_0002);
			break;
		case 23:
			this.m__0006_200A[((global::_0002_2009)_0005)._0005()]._000F_2001_2004_2001_0005(_0002);
			break;
		case 18:
		{
			_000E_2000 obj3 = (_000E_2000)_0005;
			FieldInfo fieldInfo = obj3._0005();
			global::_000F obj4 = global::_000F._0005(_0002._000F_2001_2004_2001_0005(), fieldInfo.FieldType);
			fieldInfo.SetValue(obj3._0005(), obj4._000F_2001_2004_2001_0005());
			global::_0005_2009 obj5 = obj3._0005();
			if (obj5 != null && fieldInfo.DeclaringType.IsValueType)
			{
				this._0005(obj5, global::_000F._0005(obj3._0005(), null));
			}
			break;
		}
		case 11:
		case 24:
		{
			_0005_2000 obj = (_0005_2000)_0005;
			global::_000F obj2 = global::_000F._0005(_0002._000F_2001_2004_2001_0005(), obj._0005());
			obj._0005_2000_2001_2004_2001_0005(obj2._000F_2001_2004_2001_0005());
			break;
		}
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	private FieldInfo _0005(int _0005)
	{
		lock (global::_000F_2001.m__000E_2001)
		{
			bool flag = true;
			FieldInfo fieldInfo;
			if (flag && global::_000F_2001.m__000E_2001.TryGetValue(_0005, out var value))
			{
				fieldInfo = (FieldInfo)value;
			}
			else
			{
				global::_0005 obj = this._0005(_0005);
				fieldInfo = this._0005(_0005, obj, ref flag);
				if (flag)
				{
					global::_000F_2001.m__000E_2001.Add(_0005, fieldInfo);
				}
			}
			this._0005(fieldInfo);
			return fieldInfo;
		}
	}

	private static void _0002_2008(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005();
	}

	private static void _000E(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		Type t = _0005._0005(num, _0002: true);
		_0005._0005((global::_000F)new global::_0006(Marshal.SizeOf(t)));
	}

	private static void _0002(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		global::_000F obj2 = _0005._0002();
		_0005._0005((global::_000F)new global::_0006(_0008(obj2, obj) ? 1 : 0));
	}

	private static void _000F_2009(_000F_2001 _0005, global::_000F _0002)
	{
		if (_0005.m__0008_2009 == null)
		{
			throw new InvalidOperationException();
		}
		_0005._0005(_0005.m__0008_2009);
	}

	private static bool _000F(global::_000F _0005, global::_000F _0002)
	{
		bool result = false;
		switch (_0005._0005())
		{
		case 1:
			if (_0002._0005() == 19)
			{
				return _000F(_0005, (global::_000F)new global::_0006(Convert.ToInt32(((_0005_0019)_0002)._0005())));
			}
			result = (uint)((global::_0006)_0005)._0005() < (uint)((global::_0006)_0002)._0005();
			break;
		case 13:
			if (_0002._0005() == 19)
			{
				return _000F(_0005, (global::_000F)new _0003_2003(Convert.ToInt64(((_0005_0019)_0002)._0005())));
			}
			if (_0002._0005() == 1)
			{
				return _000F(_0005, (global::_000F)new _0003_2003(((global::_0006)_0002)._0005()));
			}
			result = (ulong)((_0003_2003)_0005)._0005() < (ulong)((_0003_2003)_0002)._0005();
			break;
		case 19:
			return _000F((global::_000F)new _0003_2003(Convert.ToInt64(((_0005_0019)_0005)._0005())), _0002);
		case 8:
		{
			double num = ((_000F_2006)_0005)._0005();
			double num2 = ((_000F_2006)_0002)._0005();
			result = num < num2 || double.IsNaN(num) || double.IsNaN(num2);
			break;
		}
		}
		return result;
	}

	private static void _0003_2008_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003();
	}

	private global::_000F _0005(global::_0005_2009 _0005)
	{
		switch (((global::_000F)_0005)._0005())
		{
		case 2:
			return ((_0006_2005)_0005)._0005();
		case 23:
			return this.m__0006_200A[((global::_0002_2009)_0005)._0005()];
		case 18:
		{
			_000E_2000 obj2 = (_000E_2000)_0005;
			return global::_000F._0005(obj2._0005().GetValue(obj2._0005()), null);
		}
		case 11:
		case 24:
		{
			_0005_2000 obj = (_0005_2000)_0005;
			return global::_000F._0005(obj._0005_2000_2001_2004_2001_0005(), obj._0005());
		}
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	private static void _0006_200A(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		if (obj._0005() != 1)
		{
			throw new InvalidOperationException();
		}
		int num = ((global::_0006)obj)._0005();
		Stack<_0006_2009> stack = _0005._0005();
		if (stack.Count < 2)
		{
			throw new InvalidOperationException();
		}
		using _0006_2009 obj2 = stack.Pop();
		if (obj2 == null || obj2._0005._000E_2009_2001_2004_2001_0005() != num)
		{
			throw new InvalidOperationException();
		}
		_0006_2009 obj3 = stack.Peek();
		_0005._0005(obj3);
		_0005.m__0002_200A += (uint)obj2._0005._0005();
		_0005._0005((long)_0005.m__0002_200A);
	}

	private void _000F()
	{
	}

	private static void _0002_2000_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		if (_000F(_0005._0002(), obj))
		{
			uint num = ((_0006_200B)_0002)._0005();
			_0005._0005(num);
		}
	}

	private static void _000F_2005(_000F_2001 _0005, global::_000F _0002)
	{
		object obj = _0005._0002()._000F_2001_2004_2001_0005();
		long num = _0005._0002();
		Array array = (Array)_0005._0002()._000F_2001_2004_2001_0005();
		Type elementType = array.GetType().GetElementType();
		if (elementType == typeof(int))
		{
			global::_000F obj2 = global::_000F._0005(obj, typeof(int));
			((int[])array)[num] = (int)obj2._000F_2001_2004_2001_0005();
		}
		else if (elementType == typeof(uint))
		{
			global::_000F obj3 = global::_000F._0005(obj, typeof(uint));
			((uint[])array)[num] = (uint)obj3._000F_2001_2004_2001_0005();
		}
		else if (elementType.IsEnum)
		{
			_0005._0005(elementType, obj, num, array);
		}
		else
		{
			_0005._0005(typeof(int), obj, num, array);
		}
	}

	private static void _000F_2003_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		if (!_0006(_0005._0002(), obj))
		{
			uint num = ((_0006_200B)_0002)._0005();
			_0005._0005(num);
		}
	}

	private static void _0006_200B_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(_0005: false, _0002: false);
	}

	private static void _0003_2004(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(1);
	}

	[Conditional("DEBUG")]
	public static void _0005(string _0005)
	{
	}

	private global::_000F[] _0005(object[] _0005)
	{
		_0005_2005[] array = this.m__000E_2008._0005();
		int num = array.Length;
		global::_000F[] array2 = new global::_000F[num];
		for (int i = 0; i < num; i++)
		{
			object obj = _0005[i];
			Type type = this._0005(array[i]._0005(), _0002: false);
			Type type2 = null;
			Type type3 = global::_0005_2004._0002(type);
			if (!(type3 == global::_0005_2004._0005) && !global::_0005_2004._0005(type3))
			{
				type2 = ((obj != null) ? obj.GetType() : type);
			}
			else
			{
				type2 = type;
			}
			if (obj != null && !type.IsAssignableFrom(type2) && type.IsByRef && !type.GetElementType().IsAssignableFrom(type2))
			{
				throw new ArgumentException(string.Format(_000F_0019._0005(-1057762216), type2, type));
			}
			array2[i] = global::_000F._0005(obj, type2);
		}
		if (!this.m__000E_2008._0005() && this._0005(this.m__000E_2008._0005(), _0002: false).IsValueType)
		{
			_0006_2005 obj2 = new _0006_2005();
			obj2._0005(array2[0]);
			array2[0] = obj2;
		}
		for (int j = 0; j < num; j++)
		{
			if (array[j]._0005())
			{
				int num2 = j;
				_0006_2005 obj3 = new _0006_2005();
				obj3._0005(array2[j]);
				array2[num2] = obj3;
			}
		}
		return array2;
	}

	private static void _000F_2001_2005(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		Type type = _0005._0005(num, _0002: true);
		_0005._0005(type);
	}

	private static void _0008_2003(_000F_2001 _0005, global::_000F _0002)
	{
		_0002_2008 obj = global::_000F_2001._0005(_0005);
		global::_0008 obj2 = _0005.m__000E._0005();
		long num = _0005._0005();
		byte[] array = new _000E_2008(obj._000E_2009_2001_2004_2001_0005(), obj._000E_2009_2001_2004_2001_0005())._0005(obj2, obj);
		_0006_2009 obj3 = new _0006_2009
		{
			_0005 = obj,
			_0006 = num
		};
		obj._0002(global::_0003_2008._0002(array.Length) - array.Length);
		obj3._0002 = new _0005_2009_200B(obj3._000F = new global::_0003(array, 0, array.Length, _0006: false));
		_0005._0005().Push(obj3);
		_0005._0005(obj3);
	}

	private static void _0005_2001(_000F_2001 _0005, global::_000F _0002)
	{
		throw new NotSupportedException(_000F_0019._0005(-1057762300));
	}

	private int _0005()
	{
		return 693773466;
	}

	private bool _0005(MethodBase _0005, object _0002, global::_000F[] _000F, object[] _0006, bool _0008, ref object _0003)
	{
		Type declaringType = _0005.DeclaringType;
		if (declaringType == null)
		{
			return false;
		}
		if (declaringType == global::_000F_2001.m__0003_200A && _0005.Name == _000F_0019._0005(-1057762527) && _0006.Length == 2 && _0005.ToString() == _000F_0019._0005(-1057762469))
		{
			global::_000E_2003._0005((Array)_0006[0], (RuntimeFieldHandle)_0006[1]);
			return true;
		}
		return false;
	}

	private static void _0002(ILGenerator _0005, Type _0002)
	{
		if (_0002.IsValueType || global::_0005_2004._0005(_0002).IsGenericParameter)
		{
			_0005.Emit(OpCodes.Box, _0002);
		}
	}

	private static void _000F_200A_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(typeof(sbyte));
	}

	private static void _0008_2005_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(typeof(float));
	}

	private static void _0005(ILGenerator _0005, int _0002)
	{
		switch (_0002)
		{
		case -1:
			_0005.Emit(OpCodes.Ldc_I4_M1);
			return;
		case 0:
			_0005.Emit(OpCodes.Ldc_I4_0);
			return;
		case 1:
			_0005.Emit(OpCodes.Ldc_I4_1);
			return;
		case 2:
			_0005.Emit(OpCodes.Ldc_I4_2);
			return;
		case 3:
			_0005.Emit(OpCodes.Ldc_I4_3);
			return;
		case 4:
			_0005.Emit(OpCodes.Ldc_I4_4);
			return;
		case 5:
			_0005.Emit(OpCodes.Ldc_I4_5);
			return;
		case 6:
			_0005.Emit(OpCodes.Ldc_I4_6);
			return;
		case 7:
			_0005.Emit(OpCodes.Ldc_I4_7);
			return;
		case 8:
			_0005.Emit(OpCodes.Ldc_I4_8);
			return;
		}
		if (_0002 > -129 && _0002 < 128)
		{
			_0005.Emit(OpCodes.Ldc_I4_S, (sbyte)_0002);
		}
		else
		{
			_0005.Emit(OpCodes.Ldc_I4, _0002);
		}
	}

	private string _0005(int _0005)
	{
		lock (global::_000F_2001.m__000E_2001)
		{
			bool flag = true;
			if (flag && global::_000F_2001.m__000E_2001.TryGetValue(_0005, out var value))
			{
				return (string)value;
			}
			global::_0005 obj = this._0005(_0005);
			if (obj._0005() == 0)
			{
				return this.m__0008_2001.ResolveString(obj._0005());
			}
			string text = ((_000F_2004)obj._0005())._0005();
			if (flag)
			{
				global::_000F_2001.m__000E_2001.Add(_0005, text);
			}
			return text;
		}
	}

	private void _0005(object _0005, uint _0002)
	{
		bool flag = _0005 != null;
		this.m__0008_2009 = _0005;
		if (flag)
		{
			this.m__0008_200A.Clear();
		}
		this.m__000F_2001 = flag;
		if (!flag)
		{
			this.m__0008_200A.Push(new _0002(_0002));
		}
		_0003_2007[] array = this.m__0008_2008;
		foreach (_0003_2007 obj in array)
		{
			if (!global::_000F_2001._0005(this.m__0006, obj._0002(), obj._000F()))
			{
				continue;
			}
			switch (obj._0002())
			{
			case 2:
				if (flag || !global::_000F_2001._0005(_0002, obj._0002(), obj._000F()))
				{
					this.m__0008_200A.Push(new _0002(obj._0005()));
				}
				break;
			case 1:
				if (flag)
				{
					this.m__0008_200A.Push(new _0002(obj._0005()));
				}
				break;
			case 4:
				if (flag)
				{
					this.m__0008_200A.Push(new _0002(obj._0006(), _0005));
				}
				break;
			case 0:
				if (flag)
				{
					Type type = _0005.GetType();
					Type type2 = this._0005(obj._0005(), _0002: true);
					if (type == type2 || type.IsSubclassOf(type2))
					{
						this.m__0008_200A.Push(new _0002(obj._0005(), _0005));
						this.m__000F_2001 = false;
					}
				}
				break;
			}
		}
		this._0005();
	}

	private void _0005(uint _0005)
	{
		this.m__0006_2001 = _0005;
	}

	private static bool _0002(global::_000F _0005, global::_000F _0002)
	{
		bool flag = false;
		switch (_0005._0005())
		{
		case 1:
			return (uint)((global::_0006)_0005)._0005() > (uint)((global::_0006)_0002)._0005();
		case 13:
			return (ulong)((_0003_2003)_0005)._0005() > (ulong)((_0003_2003)_0002)._0005();
		case 8:
		{
			double num3 = ((_000F_2006)_0005)._0005();
			double num4 = ((_000F_2006)_0002)._0005();
			return num3 > num4 || double.IsNaN(num3) || double.IsNaN(num4);
		}
		case 0:
			if (_0002._0005() == 7 && _0002._000F_2001_2004_2001_0005() == null)
			{
				return ((_000F_2002)_0005)._0005() != IntPtr.Zero;
			}
			return ((_000F_2002)_0005)._0005() != ((_000F_2002)_0002)._0005();
		case 20:
			if (_0002._0005() == 7 && _0002._000F_2001_2004_2001_0005() == null)
			{
				return ((_0005_2008)_0005)._0005() != UIntPtr.Zero;
			}
			return ((_0005_2008)_0005)._0005() != ((_0005_2008)_0002)._0005();
		case 7:
			return ((_0008_2008)_0005)._0005() != ((_0008_2008)_0002)._0005();
		case 25:
			if (_0002._0005() == 7 && _0002._000F_2001_2004_2001_0005() == null)
			{
				return true;
			}
			return ((_000E_2007)_0005)._0005() != ((_000E_2007)_0002)._0005();
		case 19:
		{
			long num = Convert.ToInt64(((_0005_0019)_0005)._0005());
			long num2 = ((_0002._0005() != 1) ? Convert.ToInt64(((_0005_0019)_0002)._0005()) : ((global::_0006)_0002)._0005());
			return num > num2;
		}
		default:
			return _0005._000F_2001_2004_2001_0005() != _0002._000F_2001_2004_2001_0005();
		}
	}

	private static void _0003_2000_200B(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		FieldInfo fieldInfo = _0005._0005(num);
		global::_000F obj = _0005._0002();
		if (obj is global::_0005_2009 obj2)
		{
			obj = _0005._0005(obj2);
		}
		object obj3 = obj._000F_2001_2004_2001_0005();
		if (obj3 == null)
		{
			throw new NullReferenceException();
		}
		_0005._0005(global::_000F._0005(fieldInfo.GetValue(obj3), fieldInfo.FieldType));
	}

	private static void _000F_2002(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(_0002);
	}

	private static void _0005_2008_200B(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		Type type = _0005._0005(num, _0002: true);
		global::_000F obj = global::_000F._0005(_0005._0002()._000F_2001_2004_2001_0005(), type);
		_0005._0005(obj);
	}

	private static BindingFlags _0005(bool _0005)
	{
		BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic;
		if (_0005)
		{
			return bindingFlags | BindingFlags.Static;
		}
		return bindingFlags | BindingFlags.Instance;
	}

	private static void _0008_200A_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003(_0005: false);
	}

	private static void _0003_200B(_000F_2001 _0005, global::_000F _0002)
	{
		Thread.MemoryBarrier();
	}

	private static void _0008_2009_200B(_000F_2001 _0005, global::_000F _0002)
	{
		throw new NotSupportedException(_000F_0019._0005(-1057761416));
	}

	private static bool _0006(global::_000F _0005, global::_000F _0002)
	{
		bool result = false;
		switch (_0005._0005())
		{
		case 1:
			if (_0002._0005() != 19)
			{
				result = ((_0002._0005() != 7 || _0002._000F_2001_2004_2001_0005() != null) ? (((global::_0006)_0005)._0005() == ((global::_0006)_0002)._0005()) : (((global::_0006)_0005)._0005() == 0));
			}
			else
			{
				result = ((global::_0006)_0005)._0005() == Convert.ToInt64(((_0005_0019)_0002)._0005());
			}
			break;
		case 13:
			if (_0002._0005() != 19)
			{
				result = ((_0002._0005() != 7 || _0002._000F_2001_2004_2001_0005() != null) ? (((_0003_2003)_0005)._0005() == ((_0003_2003)_0002)._0005()) : (((_0003_2003)_0005)._0005() == 0));
			}
			else
			{
				result = ((_0003_2003)_0005)._0005() == Convert.ToInt64(((_0005_0019)_0002)._0005());
			}
			break;
		case 0:
			if (_0002._0005() == 7 && _0002._000F_2001_2004_2001_0005() == null)
			{
				result = ((_000F_2002)_0005)._0005() == IntPtr.Zero;
			}
			else if (_0002._0005() != 1)
			{
				result = ((_0002._0005() != 13) ? (((_000F_2002)_0005)._0005() == ((_000F_2002)_0002)._0005()) : (((_000F_2002)_0005)._0005() == new IntPtr(((_0003_2003)_0002)._0005())));
			}
			else
			{
				result = ((_000F_2002)_0005)._0005() == new IntPtr(((global::_0006)_0002)._0005());
			}
			break;
		case 20:
			if (_0002._0005() == 7 && _0002._000F_2001_2004_2001_0005() == null)
			{
				result = ((_0005_2008)_0005)._0005() == UIntPtr.Zero;
			}
			else if (_0002._0005() != 1)
			{
				result = ((_0002._0005() != 13) ? (((_0005_2008)_0005)._0005() == ((_0005_2008)_0002)._0005()) : (((_0005_2008)_0005)._0005() == new UIntPtr((ulong)((_0003_2003)_0002)._0005())));
			}
			else
			{
				result = ((_0005_2008)_0005)._0005() == new UIntPtr((uint)((global::_0006)_0002)._0005());
			}
			break;
		case 7:
			result = _0005._000F_2001_2004_2001_0005() == _0002._000F_2001_2004_2001_0005();
			break;
		case 25:
			result = (_0002._0005() != 7 || _0002._000F_2001_2004_2001_0005() != null) && ((_000E_2007)_0005)._0005() == ((_000E_2007)_0002)._0005();
			break;
		case 19:
		{
			_0005_0019 obj9 = (_0005_0019)_0005;
			if (_0002._0005() == 19)
			{
				result = Convert.ToInt64(obj9._0005()) == Convert.ToInt64(((_0005_0019)_0002)._0005());
			}
			else if (obj9._0005() == null)
			{
				result = _0002._000F_2001_2004_2001_0005() == null;
			}
			else if (_0002._000F_2001_2004_2001_0005() != null)
			{
				result = Convert.ToInt64(obj9._0005()) == Convert.ToInt64(_0002._000F_2001_2004_2001_0005());
			}
			break;
		}
		case 8:
		{
			double d = ((_000F_2006)_0005)._0005();
			double num = ((_000F_2006)_0002)._0005();
			result = !double.IsNaN(d) && !double.IsNaN(num) && d.Equals(num);
			break;
		}
		case 11:
		case 24:
		{
			_0005_2000 obj7 = (_0005_2000)_0005;
			_0005_2000 obj8 = (_0005_2000)_0002;
			result = obj7._0005_2000_2001_2004_2001_0005(obj8);
			break;
		}
		case 18:
		{
			_000E_2000 obj5 = (_000E_2000)_0005;
			_000E_2000 obj6 = (_000E_2000)_0002;
			result = obj5._0005() == obj6._0005() && obj5._0005() == obj6._0005();
			break;
		}
		case 23:
		{
			global::_0002_2009 obj3 = (global::_0002_2009)_0005;
			global::_0002_2009 obj4 = (global::_0002_2009)_0002;
			result = obj3._0005() == obj4._0005();
			break;
		}
		case 2:
		{
			_0006_2005 obj = (_0006_2005)_0005;
			_0006_2005 obj2 = (_0006_2005)_0002;
			result = _0006(obj._0005(), obj2._0005());
			break;
		}
		default:
			result = _0005._000F_2001_2004_2001_0005() == _0002._000F_2001_2004_2001_0005();
			break;
		}
		return result;
	}

	private void _0005(ref _000E_2009 _0005)
	{
		if (_0005._0005)
		{
			Monitor.Exit(global::_000F_2001.m__0006_2008);
		}
	}

	private void _0005(_0006_2009 _0005)
	{
		this.m__000E = _0005._0002;
		this.m__0002_2009 = _0005._0006;
	}

	private void _0003_2009(bool _0005)
	{
		global::_000F obj = _0002();
		this._0005((global::_000F)new _0003_2003(obj._0005() switch
		{
			1 => (!_0005) ? ((uint)((global::_0006)obj)._0005()) : checked((uint)((global::_0006)obj)._0005()), 
			13 => (!_0005) ? ((_0003_2003)obj)._0005() : ((long)checked((ulong)((_0003_2003)obj)._0005())), 
			19 => (long)((!_0005) ? Convert.ToUInt64(((_0005_0019)obj)._0005()) : Convert.ToUInt64(((_0005_0019)obj)._0005())), 
			8 => (long)((!_0005) ? ((ulong)((_000F_2006)obj)._0005()) : checked((ulong)((_000F_2006)obj)._0005())), 
			0 => (IntPtr.Size != 4) ? ((!_0005) ? ((long)((_000F_2002)obj)._0005()) : ((long)checked((ulong)(long)((_000F_2002)obj)._0005()))) : ((!_0005) ? ((uint)(int)((_000F_2002)obj)._0005()) : checked((uint)(int)((_000F_2002)obj)._0005())), 
			20 => (long)((UIntPtr.Size != 4) ? ((!_0005) ? ((ulong)((_0005_2008)obj)._0005()) : ((ulong)((_0005_2008)obj)._0005())) : ((!_0005) ? ((uint)((_0005_2008)obj)._0005()) : ((uint)((_0005_2008)obj)._0005()))), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private static void _000F_2009_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(typeof(ushort));
	}

	private object _0005(Stream _0005, int _0002, object[] _000F, Type[] _0006, Type[] _0008, object[] _0003)
	{
		this.m__0005 = _0005;
		this._0005(_0005, _0002, null);
		return this._0005(_000F, _0006, _0008, _0003);
	}

	private static void _0002_2000(_000F_2001 _0005, global::_000F _0002)
	{
	}

	private global::_000F _0002(global::_000F _0005, global::_000F _0002)
	{
		if (_0005._0005() == 1)
		{
			if (_0002._0005() == 1)
			{
				int num = ((global::_0006)_0005)._0005();
				int num2 = ((global::_0006)_0002)._0005();
				return new global::_0006(num ^ num2);
			}
			if (_0002._0005() == 19)
			{
				int num3 = ((global::_0006)_0005)._0005();
				Type underlyingType = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
				{
					long num4 = Convert.ToInt64(_0002._000F_2001_2004_2001_0005());
					return new _0003_2003(num3 ^ num4);
				}
				int num5 = Convert.ToInt32(_0002._000F_2001_2004_2001_0005());
				return new global::_0006(num3 ^ num5);
			}
		}
		if (_0005._0005() == 13)
		{
			if (_0002._0005() == 13)
			{
				long num6 = ((_0003_2003)_0005)._0005();
				long num7 = ((_0003_2003)_0002)._0005();
				return new _0003_2003(num6 ^ num7);
			}
			if (_0002._0005() == 19)
			{
				int num8 = ((global::_0006)_0005)._0005();
				long num9 = Convert.ToInt64(_0002._000F_2001_2004_2001_0005());
				return new _0003_2003(num8 ^ num9);
			}
		}
		if (_0005._0005() == 19)
		{
			if (_0002._0005() == 1)
			{
				int num10 = ((global::_0006)_0002)._0005();
				Type underlyingType2 = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return new _0003_2003(Convert.ToInt64(_0002._000F_2001_2004_2001_0005()) ^ num10);
				}
				return new global::_0006(Convert.ToInt32(_0005._000F_2001_2004_2001_0005()) ^ num10);
			}
			if (_0002._0005() == 13)
			{
				long num11 = Convert.ToInt64(_0005._000F_2001_2004_2001_0005());
				long num12 = ((_0003_2003)_0002)._0005();
				return new _0003_2003(num11 ^ num12);
			}
			if (_0002._0005() == 19)
			{
				Type underlyingType3 = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
				Type underlyingType4 = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType3 == typeof(long) || underlyingType3 == typeof(ulong) || underlyingType4 == typeof(long) || underlyingType4 == typeof(ulong))
				{
					long num13 = Convert.ToInt64(_0005._000F_2001_2004_2001_0005());
					long num14 = Convert.ToInt64(_0002._000F_2001_2004_2001_0005());
					return new _0003_2003(num13 ^ num14);
				}
				int num15 = Convert.ToInt32(_0005._000F_2001_2004_2001_0005());
				int num16 = Convert.ToInt32(_0002._000F_2001_2004_2001_0005());
				return new global::_0006(num15 ^ num16);
			}
		}
		throw new InvalidOperationException();
	}

	private static void _000F_2001_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		checked
		{
			_0005._0005((global::_000F)new global::_0006(obj._0005() switch
			{
				1 => unchecked((int)checked((sbyte)(uint)((global::_0006)obj)._0005())), 
				13 => (sbyte)(ulong)((_0003_2003)obj)._0005(), 
				19 => (sbyte)Convert.ToUInt64(((_0005_0019)obj)._0005()), 
				8 => (sbyte)((_000F_2006)obj)._0005(), 
				0 => (IntPtr.Size != 4) ? ((sbyte)(ulong)(long)((_000F_2002)obj)._0005()) : ((sbyte)(uint)(int)((_000F_2002)obj)._0005()), 
				_ => throw new InvalidOperationException(), 
			}));
		}
	}

	private void _000F_2009()
	{
		_0002(_0005: false);
	}

	private static void _0006_2004(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		FieldInfo fieldInfo = _0005._0005(num);
		global::_000F obj = global::_000F._0005(_0005._0002()._000F_2001_2004_2001_0005(), fieldInfo.FieldType);
		fieldInfo.SetValue(null, obj._000F_2001_2004_2001_0005());
	}

	private void _000F(bool _0005, bool _0002)
	{
		global::_000F obj = this._0002();
		global::_000F obj2 = this._0002();
		this._0005(_0008(obj2, obj, _0005, _0002));
	}

	private void _0003()
	{
		global::_000F obj = _0002();
		global::_0005_2009 obj2 = (global::_0005_2009)_0002();
		_0005(obj2, obj);
	}

	private static void _0003_2003_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0006(_0005: false);
	}

	private void _0005(int _0005, Type[] _0002, Type[] _000F, bool _0006)
	{
		this.m__0005_2009._0005()._0008_2001_2004_2001_0005(_0005, 0);
		this._0005(this.m__0005_2009);
		_0003_2009_200B obj = this._0005(this.m__0005_2009);
		this._0005(obj);
		int num = obj._0005().Length;
		object[] array = new object[num];
		global::_000F[] array2 = new global::_000F[num];
		if ((this.m__0008_200B != null) & _0006)
		{
			int num2 = ((!obj._0005()) ? 1 : 0);
			Type[] array3 = new Type[num - num2];
			for (int num3 = num - 1; num3 >= num2; num3--)
			{
				array3[num3] = this._0005(obj._0005()[num3]._0005(), _0002: true);
			}
			MethodInfo method = this.m__0008_200B.GetMethod(obj._0005(), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array3, null);
			this.m__0008_200B = null;
			if (method != null)
			{
				this._0005((MethodBase)method, true);
				return;
			}
		}
		for (int num4 = num - 1; num4 >= 0; num4--)
		{
			global::_000F obj2 = (array2[num4] = this._0002());
			if (obj2 is global::_0005_2009 obj3)
			{
				obj2 = this._0005(obj3);
			}
			if (obj2._0005() != null)
			{
				obj2 = global::_000F._0005(null, obj2._0005())._000F_2001_2004_2001_0005(obj2);
			}
			global::_000F obj4 = global::_000F._0005(null, this._0005(obj._0005()[num4]._0005(), _0002: true))._000F_2001_2004_2001_0005(obj2);
			array[num4] = obj4._000F_2001_2004_2001_0005();
			if (((num4 == 0) & _0006) && !obj._0005() && array[num4] == null)
			{
				throw new NullReferenceException();
			}
		}
		_000F_2001 obj5 = new _000F_2001(this.m__000F_200A);
		object[] array4 = new object[1] { this.m__0008_2001.Assembly };
		object obj6;
		try
		{
			obj6 = obj5._0005(this.m__0005, _0005, array, _0002, _000F, array4);
		}
		finally
		{
			bool flag = !obj._0005();
			for (int i = 0; i < num; i++)
			{
				int num5;
				if (flag)
				{
					num5 = i + 1;
					if (num5 == num)
					{
						num5 = 0;
					}
				}
				else
				{
					num5 = i;
				}
				if (array2[num5] is global::_0005_2009 obj7)
				{
					this._0005(obj7, global::_000F._0005(array[num5], null));
				}
			}
		}
		Type type = obj5._0005(obj5.m__000E_2008._0002(), _0002: true);
		if (type != global::_000F_2001.m__0003_2009)
		{
			this._0005(global::_000F._0005(obj6, type));
		}
	}

	private static void _0006_2001(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		_0005._0005((global::_000F)new global::_0006(checked(obj._0005() switch
		{
			1 => (int)(uint)((global::_0006)obj)._0005(), 
			13 => (int)(ulong)((_0003_2003)obj)._0005(), 
			19 => (int)Convert.ToUInt64(((_0005_0019)obj)._0005()), 
			8 => (int)((_000F_2006)obj)._0005(), 
			0 => (IntPtr.Size != 4) ? ((int)(ulong)(long)((_000F_2002)obj)._0005()) : ((int)(uint)(int)((_000F_2002)obj)._0005()), 
			_ => throw new InvalidOperationException(), 
		})));
	}

	private static void _0008_2003_200B(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		_0005.m__0008_200B = _0005._0005(num, _0002: true);
	}

	private static void _000E_2001_2005(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		global::_000F obj2 = _0005._0002();
		_0005._0005(_0005._0002(obj2, obj));
	}

	private static void _0005_200A(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(7);
	}

	private static void _0003_2009_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0006_2009(_0005: true);
	}

	private static _000F _0002(_0005 _0005)
	{
		_000F value;
		lock (global::_000F_2001.m__0005_200A)
		{
			global::_000F_2001.m__0005_200A.TryGetValue(_0005, out value);
		}
		if (value != null)
		{
			return value;
		}
		MethodBase methodBase = _0005._0005();
		lock (global::_000F_2001.m__0002)
		{
			while (global::_000F_2001.m__0002.ContainsKey(methodBase))
			{
				Monitor.Wait(global::_000F_2001.m__0002);
			}
			global::_000F_2001.m__0002[methodBase] = null;
		}
		try
		{
			lock (global::_000F_2001.m__0005_200A)
			{
				global::_000F_2001.m__0005_200A.TryGetValue(_0005, out value);
			}
			if (value == null)
			{
				value = global::_000F_2001._0005(methodBase, _0005._0005());
				lock (global::_000F_2001.m__0005_200A)
				{
					global::_000F_2001.m__0005_200A[_0005] = value;
				}
			}
			return value;
		}
		finally
		{
			lock (global::_000F_2001.m__0002)
			{
				global::_000F_2001.m__0002.Remove(methodBase);
				Monitor.PulseAll(global::_000F_2001.m__0002);
			}
		}
	}

	private static void _0005_200A_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		global::_000F obj2 = _0005._0002();
		if ((obj2._0005() != 8) ? (!_0008(obj2, obj)) : (!global::_000F_2001._0002(obj2, obj)))
		{
			uint num = ((_0006_200B)_0002)._0005();
			_0005._0005(num);
		}
	}

	private static void _0002_200B_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005_2009(_0005: true);
	}

	private static void _000F_2003(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(4);
	}

	private static void _0005_2004(_000F_2001 _0005, global::_000F _0002)
	{
		_0002_2009_200B obj = (_0002_2009_200B)_0002;
		_0005._0005((int)obj._0005());
	}

	private static void _000E_2007_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		_0005._0005((global::_000F)new global::_0006(obj._0005() switch
		{
			1 => ((global::_0006)obj)._0005(), 
			13 => (int)checked((uint)(ulong)((_0003_2003)obj)._0005()), 
			19 => (int)checked((uint)Convert.ToUInt64(((_0005_0019)obj)._0005())), 
			8 => (int)checked((uint)((_000F_2006)obj)._0005()), 
			0 => (IntPtr.Size != 4) ? ((int)checked((uint)(ulong)(long)((_000F_2002)obj)._0005())) : ((int)((_000F_2002)obj)._0005()), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private static void _0003_200B_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		bool flag = false;
		if (obj._0005() switch
		{
			1 => ((global::_0006)obj)._0005() == 0, 
			13 => ((_0003_2003)obj)._0005() == 0, 
			0 => ((_000F_2002)obj)._0005() == IntPtr.Zero, 
			20 => ((_0005_2008)obj)._0005() == UIntPtr.Zero, 
			7 => ((_0008_2008)obj)._0005() == null, 
			19 => !Convert.ToBoolean(((_0005_0019)obj)._0005()), 
			_ => obj._000F_2001_2004_2001_0005() == null, 
		})
		{
			uint num = ((_0006_200B)_0002)._0005();
			_0005._0005(num);
		}
	}

	private void _0002(bool _0005)
	{
		uint num = this.m__0008;
		while (true)
		{
			try
			{
				while (!this.m__0003_2001)
				{
					if (this.m__0006_2001.HasValue)
					{
						this.m__0002_200A = this.m__0006_2001.Value;
						this._0005((long)this.m__0002_200A);
						this.m__0006_2001 = null;
					}
					else if (this.m__0002_200A >= num)
					{
						break;
					}
					_0002_2009();
				}
				break;
			}
			catch (object obj)
			{
				this._0005(obj, 0u);
				if (!_0005)
				{
					_0002(_0005: true);
					break;
				}
			}
		}
	}

	private static global::_000F _0006(global::_000F _0005, global::_000F _0002, bool _000F)
	{
		if (!_000F)
		{
			long num = ((_0003_2003)_0005)._0005();
			long num2 = ((_0003_2003)_0002)._0005();
			return new _0003_2003(num / num2);
		}
		long num3 = ((_0003_2003)_0005)._0005();
		ulong num4 = (ulong)((_0003_2003)_0002)._0005();
		return new _0003_2003((long)((ulong)num3 / num4));
	}

	private static void _0005_2009_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0008_200A obj = (_0008_200A)_0002;
		_0005._0005((int)obj._0005());
	}

	private static void _0008_2001_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0006_2009(_0005: false);
	}

	private static void _0003_2005_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		global::_000F obj2 = _0005._0002();
		_0005._0005((global::_000F)new global::_0006(global::_000F_2001._0002(obj2, obj) ? 1 : 0));
	}

	private static void _0006(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F_2009(_0005: false);
	}

	private static void _0006_2009_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(3);
	}

	private static void _0003_2000(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(_0005: true, _0002: true);
	}

	private static void _0003_2008_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0006(_0005: true);
	}

	private void _0006(global::_000F _0005)
	{
		if (((global::_0006)_0002())._0005() != 0)
		{
			this.m__0008_200A.Push(new _0002(this.m__0002_200A, this.m__0008_2009));
			this.m__000F_2001 = false;
		}
		this._0005();
	}

	private static void _000E_2005_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(6);
	}

	private static bool _0002()
	{
		return false;
	}

	private static void _000E_2008_200B(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		Type type = _0005._0005(num, _0002: true);
		_0005._0002(type);
	}

	private static void _0003_2008(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(_0005: true, _0002: false);
	}

	private static void _0006_2009(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003();
	}

	private static void _000E_200B_200B(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		FieldInfo fieldInfo = _0005._0005(num);
		_0005._0005(global::_000F._0005(fieldInfo.GetValue(null), fieldInfo.FieldType));
	}

	private void _0005(bool _0005)
	{
		global::_000F obj = _0002();
		long num = obj._0005() switch
		{
			1 => (!_0005) ? ((global::_0006)obj)._0005() : ((global::_0006)obj)._0005(), 
			13 => (!_0005) ? ((_0003_2003)obj)._0005() : ((_0003_2003)obj)._0005(), 
			19 => (!_0005) ? ((long)Convert.ToUInt64(((_0005_0019)obj)._0005())) : checked((long)Convert.ToUInt64(((_0005_0019)obj)._0005())), 
			8 => (!_0005) ? ((long)((_000F_2006)obj)._0005()) : checked((long)((_000F_2006)obj)._0005()), 
			0 => (!_0005) ? ((long)((_000F_2002)obj)._0005()) : ((long)((_000F_2002)obj)._0005()), 
			_ => throw new InvalidOperationException(), 
		};
		_0003_2003 obj2 = new _0003_2003();
		obj2._0005(num);
		this._0005((global::_000F)obj2);
	}

	private static void _000E_2006(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(_0005: true, _0002: false);
	}

	private bool _0005(Type _0005, global::_0005 _0002, out int _000F)
	{
		_000F = 0;
		_0008_2002 obj = (_0008_2002)_0002._0005();
		if (global::_0005_2004._0005(_0005).IsGenericParameter)
		{
			if (obj != null && !obj._0005())
			{
				return false;
			}
			return true;
		}
		Type type = this._0005(_0002._0005(), _0002: false);
		if (!global::_000E_200B._0005(_0005, type, out _000F))
		{
			return false;
		}
		return true;
	}

	private Stack<_0006_2009> _0005()
	{
		Stack<_0006_2009> stack = this.m__0003_2008;
		if (stack == null)
		{
			stack = (this.m__0003_2008 = new Stack<_0006_2009>());
			stack.Push(new _0006_2009
			{
				_0002 = this.m__000E,
				_000F = this.m__000E._0005(),
				_0006 = this.m__0002_2009
			});
		}
		return stack;
	}

	private static void _0002_2003_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(typeof(byte));
	}

	private static bool _0008(global::_000F _0005, global::_000F _0002)
	{
		bool result = false;
		switch (_0005._0005())
		{
		case 1:
			if (_0002._0005() == 19)
			{
				return _0008(_0005, new global::_0006(Convert.ToInt32(((_0005_0019)_0002)._0005())));
			}
			result = ((global::_0006)_0005)._0005() > ((global::_0006)_0002)._0005();
			break;
		case 13:
			if (_0002._0005() == 19)
			{
				return _0008(_0005, new _0003_2003(Convert.ToInt64(((_0005_0019)_0002)._0005())));
			}
			if (_0002._0005() == 1)
			{
				return _0008(_0005, new _0003_2003(((global::_0006)_0002)._0005()));
			}
			result = ((_0003_2003)_0005)._0005() > ((_0003_2003)_0002)._0005();
			break;
		case 19:
			return _0008(new _0003_2003(Convert.ToInt64(((_0005_0019)_0005)._0005())), _0002);
		case 8:
		{
			double num = ((_000F_2006)_0005)._0005();
			double num2 = ((_000F_2006)_0002)._0005();
			result = !double.IsNaN(num) && !double.IsNaN(num2) && num > num2;
			break;
		}
		}
		return result;
	}

	private bool _0005(MethodInfo _0005, _0008_2005 _0002, Type[] _000F, out int _0006)
	{
		_0006 = 0;
		if (!_0005.IsGenericMethodDefinition)
		{
			return false;
		}
		ParameterInfo[] parameters = _0005.GetParameters();
		if (parameters.Length != _0002._0005().Length)
		{
			return false;
		}
		if (_0005.GetGenericArguments().Length != _0002._0002().Length)
		{
			return false;
		}
		for (int i = -1; i < parameters.Length; i++)
		{
			Type type = ((i == -1) ? _0005.ReturnType : parameters[i].ParameterType);
			if (_000F != null && type.IsGenericParameter && type.DeclaringMethod != null)
			{
				type = _000F[type.GenericParameterPosition] ?? type;
			}
			global::_0005 obj = ((i == -1) ? _0002._0002() : _0002._0005()[i]);
			if (obj != null)
			{
				if (!this._0005(type, obj, out var num))
				{
					return false;
				}
				if (i >= 0)
				{
					_0006 += num;
				}
			}
		}
		return true;
	}

	private static void _0005_2007(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		string text = _0005._0005(num);
		_0008_2007 obj = new _0008_2007();
		obj._0005(text);
		_0005._0005((global::_000F)obj);
	}

	private string _0005(_0003_2009_200B _0005)
	{
		Type type = this._0005(_0005._0005(), _0002: false);
		_0005_2005[] array = _0005._0005();
		string[] array2 = new string[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = this._0005(array[i]._0005(), _0002: false)?.FullName;
		}
		string text = string.Join(_000F_0019._0005(-1057762925), array2);
		return type.FullName + _000F_0019._0005(-1057761762) + _0005._0005() + _000F_0019._0005(-1057762920) + text + _000F_0019._0005(-1057762944);
	}

	private static void _0005_2004_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(_0002);
	}

	private static void _0005(ILGenerator _0005, Type _0002)
	{
		if (_0002.IsValueType || global::_0005_2004._0005(_0002).IsGenericParameter)
		{
			_0005.Emit(OpCodes.Unbox_Any, _0002);
		}
		else
		{
			_000F(_0005, _0002);
		}
	}

	private static _000F _0005(MethodBase _0005, bool _0002)
	{
		DynamicMethod dynamicMethod = null;
		if (dynamicMethod == null)
		{
			dynamicMethod = new DynamicMethod(string.Empty, global::_0005_2004._0005, new Type[2]
			{
				global::_0005_2004._0005,
				global::_000F_2001.m__000F
			}, typeof(_000F_2001).Module, skipVisibility: true);
		}
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		ParameterInfo[] parameters = _0005.GetParameters();
		Type[] array = new Type[parameters.Length];
		bool flag = false;
		for (int i = 0; i < parameters.Length; i++)
		{
			Type type = parameters[i].ParameterType;
			if (type.IsByRef)
			{
				flag = true;
				type = type.GetElementType();
			}
			array[i] = type;
		}
		LocalBuilder[] array2 = new LocalBuilder[array.Length];
		if (array2.Length != 0)
		{
			dynamicMethod.InitLocals = true;
		}
		for (int j = 0; j < array.Length; j++)
		{
			array2[j] = iLGenerator.DeclareLocal(array[j]);
		}
		for (int k = 0; k < array.Length; k++)
		{
			iLGenerator.Emit(OpCodes.Ldarg_1);
			global::_000F_2001._0005(iLGenerator, k);
			iLGenerator.Emit(OpCodes.Ldelem_Ref);
			global::_000F_2001._0005(iLGenerator, array[k]);
			iLGenerator.Emit(OpCodes.Stloc, array2[k]);
		}
		if (flag)
		{
			iLGenerator.BeginExceptionBlock();
		}
		if (!_0005.IsStatic && !_0005.IsConstructor)
		{
			iLGenerator.Emit(OpCodes.Ldarg_0);
			Type declaringType = _0005.DeclaringType;
			if (declaringType.IsValueType)
			{
				iLGenerator.Emit(OpCodes.Unbox, declaringType);
				_0002 = false;
			}
			else
			{
				_000F(iLGenerator, declaringType);
			}
		}
		for (int l = 0; l < array.Length; l++)
		{
			if (parameters[l].ParameterType.IsByRef)
			{
				iLGenerator.Emit(OpCodes.Ldloca_S, array2[l]);
			}
			else
			{
				iLGenerator.Emit(OpCodes.Ldloc, array2[l]);
			}
		}
		if (_0005.IsConstructor)
		{
			iLGenerator.Emit(OpCodes.Newobj, (ConstructorInfo)_0005);
			global::_000F_2001._0002(iLGenerator, _0005.DeclaringType);
		}
		else
		{
			MethodInfo methodInfo = (MethodInfo)_0005;
			if (!_0002 || _0005.IsStatic)
			{
				iLGenerator.EmitCall(OpCodes.Call, methodInfo, null);
			}
			else
			{
				iLGenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
			}
			if (methodInfo.ReturnType == global::_000F_2001.m__0003_2009)
			{
				iLGenerator.Emit(OpCodes.Ldnull);
			}
			else
			{
				global::_000F_2001._0002(iLGenerator, methodInfo.ReturnType);
			}
		}
		if (flag)
		{
			LocalBuilder local = iLGenerator.DeclareLocal(global::_0005_2004._0005);
			iLGenerator.Emit(OpCodes.Stloc, local);
			iLGenerator.BeginFinallyBlock();
			for (int m = 0; m < array.Length; m++)
			{
				if (parameters[m].ParameterType.IsByRef)
				{
					iLGenerator.Emit(OpCodes.Ldarg_1);
					global::_000F_2001._0005(iLGenerator, m);
					iLGenerator.Emit(OpCodes.Ldloc, array2[m]);
					if (array2[m].LocalType.IsValueType || global::_0005_2004._0005(array2[m].LocalType).IsGenericParameter)
					{
						iLGenerator.Emit(OpCodes.Box, array2[m].LocalType);
					}
					iLGenerator.Emit(OpCodes.Stelem_Ref);
				}
			}
			iLGenerator.EndExceptionBlock();
			iLGenerator.Emit(OpCodes.Ldloc, local);
		}
		iLGenerator.Emit(OpCodes.Ret);
		return (_000F)dynamicMethod.CreateDelegate(typeof(_000F));
	}

	private long _0005(string _0005)
	{
		MemoryStream memoryStream = new MemoryStream(global::_0003_2006._0005(_0005));
		long result = new _0005_2009_200B(new _000F_2003(memoryStream, this._0005()))._0005();
		memoryStream.Dispose();
		return result;
	}

	private static void _0005_2003(_000F_2001 _0005, global::_000F _0002)
	{
		Debugger.Break();
	}

	private static void _000F_2007(_000F_2001 _0005, global::_000F _0002)
	{
		object obj = _0005._0002()._000F_2001_2004_2001_0005();
		long num = _0005._0002();
		Array array = (Array)_0005._0002()._000F_2001_2004_2001_0005();
		Type elementType = array.GetType().GetElementType();
		if (elementType == typeof(short))
		{
			global::_000F obj2 = global::_000F._0005(obj, typeof(short));
			((short[])array)[num] = (short)obj2._000F_2001_2004_2001_0005();
		}
		else if (elementType == typeof(ushort))
		{
			global::_000F obj3 = global::_000F._0005(obj, typeof(ushort));
			((ushort[])array)[num] = (ushort)obj3._000F_2001_2004_2001_0005();
		}
		else if (elementType == typeof(char))
		{
			global::_000F obj4 = global::_000F._0005(obj, typeof(char));
			((char[])array)[num] = (char)obj4._000F_2001_2004_2001_0005();
		}
		else if (elementType.IsEnum)
		{
			_0005._0005(elementType, obj, num, array);
		}
		else
		{
			_0005._0005(typeof(short), obj, num, array);
		}
	}

	private static global::_000F _0005(global::_000F _0005, global::_000F _0002, bool _000F, bool _0006)
	{
		if (_0005._0005() == 1)
		{
			if (_0002._0005() == 1)
			{
				if (!_0006)
				{
					int num = ((global::_0006)_0005)._0005();
					int num2 = ((global::_0006)_0002)._0005();
					int num3 = ((!_000F) ? (num + num2) : checked(num + num2));
					return new global::_0006(num3);
				}
				uint num4 = (uint)((global::_0006)_0005)._0005();
				uint num5 = (uint)((global::_0006)_0002)._0005();
				uint num6 = ((!_000F) ? (num4 + num5) : checked(num4 + num5));
				return new global::_0006((int)num6);
			}
			if (_0002._0005() == 13)
			{
				return global::_000F_2001._0002(new _0003_2003(((global::_0006)_0005)._0005()), _0002, _000F, _0006);
			}
			if (_0002._0005() == 19)
			{
				Type underlyingType = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
				{
					return global::_000F_2001._0002(new _0003_2003(((global::_0006)_0005)._0005()), new _0003_2003(Convert.ToInt64(_0002._000F_2001_2004_2001_0005())), _000F, _0006);
				}
				return global::_000F_2001._0005(_0005, new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())), _000F, _0006);
			}
		}
		if (_0005._0005() == 13)
		{
			if (_0002._0005() == 13)
			{
				return global::_000F_2001._0002(_0005, _0002, _000F, _0006);
			}
			if (_0002._0005() == 1)
			{
				return global::_000F_2001._0002(_0005, new _0003_2003(((global::_0006)_0002)._0005()), _000F, _0006);
			}
			if (_0002._0005() == 19)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return global::_000F_2001._0002(_0005, new _0003_2003(Convert.ToInt64(_0002._000F_2001_2004_2001_0005())), _000F, _0006);
				}
				return global::_000F_2001._0002(_0005, new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())), _000F, _0006);
			}
		}
		if (_0005._0005() == 8 && _0002._0005() == 8)
		{
			_000F_2006 obj = new _000F_2006();
			obj._0005(((_000F_2006)_0005)._0005() + ((_000F_2006)_0002)._0005());
			return obj;
		}
		if (_0005._0005() == 19)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
			if (underlyingType3 == typeof(long) || underlyingType3 == typeof(ulong))
			{
				return global::_000F_2001._0005(new _0003_2003(Convert.ToInt64(_0005._000F_2001_2004_2001_0005())), _0002, _000F, _0006);
			}
			return global::_000F_2001._0005(new global::_0006(Convert.ToInt32(_0005._000F_2001_2004_2001_0005())), _0002, _000F, _0006);
		}
		throw new InvalidOperationException();
	}

	private static void _0003(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(typeof(long));
	}

	private static void _0006_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005((global::_000F)new _0008_2008());
	}

	private static void _000E_2004(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(_0005: true, _0002: true);
	}

	private void _0005(_0005_2006 _0005)
	{
		global::_0005 obj = this._0005(_0005._0002());
		MethodBase methodBase = this._0005(_0005._0002(), obj);
		int num = _0005._0005();
		bool flag = (num & 0x40000000) != 0;
		num &= -1073741825;
		Type[] array = this.m__000F_2008;
		Type[] array2 = this.m__0002_200B;
		try
		{
			this.m__000F_2008 = ((methodBase is ConstructorInfo) ? null : methodBase.GetGenericArguments());
			this.m__0002_200B = methodBase.DeclaringType.GetGenericArguments();
			this._0005(num, this.m__000F_2008, this.m__0002_200B, flag);
		}
		finally
		{
			this.m__000F_2008 = array;
			this.m__0002_200B = array2;
		}
	}

	private void _0005(object _0005)
	{
		if (_0005 is Exception ex)
		{
			global::_000F_2001._0005(ex);
		}
		global::_000F_2001._0005(_0005);
	}

	private static void _0008_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0008(((_0008_200A)_0002)._0005());
	}

	private static Dictionary<int, _0003_2009> _0005(_0002_2007 _0005)
	{
		return new Dictionary<int, _0003_2009>(256)
		{
			{
				_0005._0002_2009._0005(),
				new _0003_2009(_0005._0002_2009, _0008_2001_200B)
			},
			{
				_0005._0006_2007._0005(),
				new _0003_2009(_0005._0006_2007, _0005_2000)
			},
			{
				_0005._0003_2009_2005._0005(),
				new _0003_2009(_0005._0003_2009_2005, _000E_200B)
			},
			{
				_0005._0002_2001_2005._0005(),
				new _0003_2009(_0005._0002_2001_2005, _0002_2008)
			},
			{
				_0005._0008_2005_200B._0005(),
				new _0003_2009(_0005._0008_2005_200B, _0008_2000_200B)
			},
			{
				_0005._0002_2004_200B._0005(),
				new _0003_2009(_0005._0002_2004_200B, _0002_2004_200B)
			},
			{
				_0005._0003_2008_2005._0005(),
				new _0003_2009(_0005._0003_2008_2005, _000F_2003_200B)
			},
			{
				_0005._0002_2000._0005(),
				new _0003_2009(_0005._0002_2000, _0008_2006)
			},
			{
				_0005._0003_2007_200B._0005(),
				new _0003_2009(_0005._0003_2007_200B, _0008_2000)
			},
			{
				_0005._0003_2001_2005._0005(),
				new _0003_2009(_0005._0003_2001_2005, _000E_2003)
			},
			{
				_0005._0002_2005_200B._0005(),
				new _0003_2009(_0005._0002_2005_200B, _0005_200A)
			},
			{
				_0005._000F_2002_200B._0005(),
				new _0003_2009(_0005._000F_2002_200B, _0003_2008_200B)
			},
			{
				_0005._0005_2008_2005._0005(),
				new _0003_2009(_0005._0005_2008_2005, _0008_2008)
			},
			{
				_0005._0008_200A_2005._0005(),
				new _0003_2009(_0005._0008_200A_2005, _0006_2009_200B)
			},
			{
				_0005._000E_2000_200B._0005(),
				new _0003_2009(_0005._000E_2000_200B, _0002_2001_2005)
			},
			{
				_0005._0006_2006_200B._0005(),
				new _0003_2009(_0005._0006_2006_200B, _0008_2005)
			},
			{
				_0005._0006_2005._0005(),
				new _0003_2009(_0005._0006_2005, _000F_2007)
			},
			{
				_0005._0005_200A_200B._0005(),
				new _0003_2009(_0005._0005_200A_200B, _0005_2008_200B)
			},
			{
				_0005._000E_2004._0005(),
				new _0003_2009(_0005._000E_2004, _0005_2003)
			},
			{
				_0005._0003_200B_200B._0005(),
				new _0003_2009(_0005._0003_200B_200B, _0006_2009_2005)
			},
			{
				_0005._000E_2008._0005(),
				new _0003_2009(_0005._000E_2008, _0008_2004_200B)
			},
			{
				_0005._0003_2004._0005(),
				new _0003_2009(_0005._0003_2004, _0008_200A_200B)
			},
			{
				_0005._0002_2008_2005._0005(),
				new _0003_2009(_0005._0002_2008_2005, _0002_2003_200B)
			},
			{
				_0005._0005_2006_200B._0005(),
				new _0003_2009(_0005._0005_2006_200B, _0006_2002_200B)
			},
			{
				_0005._000E_200B_2005._0005(),
				new _0003_2009(_0005._000E_200B_2005, _0002_2006)
			},
			{
				_0005._0003_200B_2005._0005(),
				new _0003_2009(_0005._0003_200B_2005, _0006_200A_200B)
			},
			{
				_0005._0005_200B_2005._0005(),
				new _0003_2009(_0005._0005_200B_2005, _0002_2005_200B)
			},
			{
				_0005._0006_2008._0005(),
				new _0003_2009(_0005._0006_2008, _0002_2006_200B)
			},
			{
				_0005._000E_2003_200B._0005(),
				new _0003_2009(_0005._000E_2003_200B, _0006_200B_200B)
			},
			{
				_0005._0002_2000_200B._0005(),
				new _0003_2009(_0005._0002_2000_200B, _0002_2002)
			},
			{
				_0005._0002_200B_200B._0005(),
				new _0003_2009(_0005._0002_200B_200B, _000F_2001)
			},
			{
				_0005._0006_200B._0005(),
				new _0003_2009(_0005._0006_200B, _0005_200B)
			},
			{
				_0005._0003_200B._0005(),
				new _0003_2009(_0005._0003_200B, _0005_200B_200B)
			},
			{
				_0005._0002_2003._0005(),
				new _0003_2009(_0005._0002_2003, _0008_2009_200B)
			},
			{
				_0005._000F_2004._0005(),
				new _0003_2009(_0005._000F_2004, _0005_2001)
			},
			{
				_0005._0006_2000._0005(),
				new _0003_2009(_0005._0006_2000, _0003_2005_200B)
			},
			{
				_0005._0006_2009._0005(),
				new _0003_2009(_0005._0006_2009, _0003_2005)
			},
			{
				_0005._0005_2000_200B._0005(),
				new _0003_2009(_0005._0005_2000_200B, _0002_2004)
			},
			{
				_0005._0008_2009_200B._0005(),
				new _0003_2009(_0005._0008_2009_200B, _0003_2007)
			},
			{
				_0005._000E_2009_2005._0005(),
				new _0003_2009(_0005._000E_2009_2005, _000E_2002_200B)
			},
			{
				_0005._000E_2007._0005(),
				new _0003_2009(_0005._000E_2007, _0003_2006)
			},
			{
				_0005._000F_2009_200B._0005(),
				new _0003_2009(_0005._000F_2009_200B, _0006_2004_200B)
			},
			{
				_0005._0005._0005(),
				new _0003_2009(_0005._0005, _0006_2006)
			},
			{
				_0005._000F_2006_200B._0005(),
				new _0003_2009(_0005._000F_2006_200B, _0006_2007)
			},
			{
				_0005._0005_2003._0005(),
				new _0003_2009(_0005._0005_2003, _000E_2005_200B)
			},
			{
				_0005._0002_2006._0005(),
				new _0003_2009(_0005._0002_2006, _0003_2002_200B)
			},
			{
				_0005._000E_2008_2005._0005(),
				new _0003_2009(_0005._000E_2008_2005, _000F)
			},
			{
				_0005._000F_2001._0005(),
				new _0003_2009(_0005._000F_2001, _0008_200B_200B)
			},
			{
				_0005._000E_2008_200B._0005(),
				new _0003_2009(_0005._000E_2008_200B, _0006_2006_200B)
			},
			{
				_0005._0002_2002_2005._0005(),
				new _0003_2009(_0005._0002_2002_2005, _000E_2006)
			},
			{
				_0005._0006_2002_2005._0005(),
				new _0003_2009(_0005._0006_2002_2005, _000F_2002_200B)
			},
			{
				_0005._000E_2006_200B._0005(),
				new _0003_2009(_0005._000E_2006_200B, _0006_2008_200B)
			},
			{
				_0005._0006_2002_200B._0005(),
				new _0003_2009(_0005._0006_2002_200B, _000E_2001)
			},
			{
				_0005._0008._0005(),
				new _0003_2009(_0005._0008, _0003_2008)
			},
			{
				_0005._000E_2001_2005._0005(),
				new _0003_2009(_0005._000E_2001_2005, _000E_2004_200B)
			},
			{
				_0005._0006_2009_2005._0005(),
				new _0003_2009(_0005._0006_2009_2005, _0005_2003_200B)
			},
			{
				_0005._0008_2005._0005(),
				new _0003_2009(_0005._0008_2005, _0002_2003)
			},
			{
				_0005._0006_200B_200B._0005(),
				new _0003_2009(_0005._0006_200B_200B, _0003_2002)
			},
			{
				_0005._0008_2006._0005(),
				new _0003_2009(_0005._0008_2006, _000E_2008_200B)
			},
			{
				_0005._0003_200A._0005(),
				new _0003_2009(_0005._0003_200A, _0008_2004)
			},
			{
				_0005._0008_2001_2005._0005(),
				new _0003_2009(_0005._0008_2001_2005, _000E_2001_2005)
			},
			{
				_0005._0003_2000._0005(),
				new _0003_2009(_0005._0003_2000, _0005_2002_200B)
			},
			{
				_0005._0006_2001._0005(),
				new _0003_2009(_0005._0006_2001, _0003_2004)
			},
			{
				_0005._0008_200B_200B._0005(),
				new _0003_2009(_0005._0008_200B_200B, _0005_2001_2005)
			},
			{
				_0005._0006_2003._0005(),
				new _0003_2009(_0005._0006_2003, _0005_2004)
			},
			{
				_0005._000E._0005(),
				new _0003_2009(_0005._000E, _0003_2000)
			},
			{
				_0005._0006_200B_2005._0005(),
				new _0003_2009(_0005._0006_200B_2005, _0002_2000_200B)
			},
			{
				_0005._0005_2008._0005(),
				new _0003_2009(_0005._0005_2008, _0005_2001_200B)
			},
			{
				_0005._0003_2006._0005(),
				new _0003_2009(_0005._0003_2006, _0005_2009_200B)
			},
			{
				_0005._0006_200A_200B._0005(),
				new _0003_2009(_0005._0006_200A_200B, _0002_200A_200B)
			},
			{
				_0005._0003_2006_200B._0005(),
				new _0003_2009(_0005._0003_2006_200B, _000F_200B)
			},
			{
				_0005._0008_2009_2005._0005(),
				new _0003_2009(_0005._0008_2009_2005, _0006_2002)
			},
			{
				_0005._000F_2007_200B._0005(),
				new _0003_2009(_0005._000F_2007_200B, _0005_2008)
			},
			{
				_0005._000F_2000_200B._0005(),
				new _0003_2009(_0005._000F_2000_200B, _0003_2009_200B)
			},
			{
				_0005._000F_2008._0005(),
				new _0003_2009(_0005._000F_2008, _0006_200B)
			},
			{
				_0005._0008_2004._0005(),
				new _0003_2009(_0005._0008_2004, _000E_2009_2005)
			},
			{
				_0005._0003_2009_200B._0005(),
				new _0003_2009(_0005._0003_2009_200B, _0003_2001)
			},
			{
				_0005._0005_200A_2005._0005(),
				new _0003_2009(_0005._0005_200A_2005, _000F_2008_2005)
			},
			{
				_0005._0006_2004._0005(),
				new _0003_2009(_0005._0006_2004, _000E_2002)
			},
			{
				_0005._0008_200B_2005._0005(),
				new _0003_2009(_0005._0008_200B_2005, _000F_2006_200B)
			},
			{
				_0005._0002_2005._0005(),
				new _0003_2009(_0005._0002_2005, _0002_2001)
			},
			{
				_0005._000F_2003_200B._0005(),
				new _0003_2009(_0005._000F_2003_200B, _0008_2008_2005)
			},
			{
				_0005._000F_2001_200B._0005(),
				new _0003_2009(_0005._000F_2001_200B, _0008_2009)
			},
			{
				_0005._000F_2005._0005(),
				new _0003_2009(_0005._000F_2005, _0003_200B_200B)
			},
			{
				_0005._0002_200A_2005._0005(),
				new _0003_2009(_0005._0002_200A_2005, _000F_2001_2005)
			},
			{
				_0005._0005_2009_2005._0005(),
				new _0003_2009(_0005._0005_2009_2005, _0006_2003_200B)
			},
			{
				_0005._0008_2003._0005(),
				new _0003_2009(_0005._0008_2003, _0006_2001)
			},
			{
				_0005._000E_200A_2005._0005(),
				new _0003_2009(_0005._000E_200A_2005, global::_000F_2001._0005)
			},
			{
				_0005._0006_2004_200B._0005(),
				new _0003_2009(_0005._0006_2004_200B, _0002_2000)
			},
			{
				_0005._0006._0005(),
				new _0003_2009(_0005._0006, _0002_2002_200B)
			},
			{
				_0005._0005_2002_2005._0005(),
				new _0003_2009(_0005._000F_2005_200B, _0003_200B)
			},
			{
				_0005._0002_2008._0005(),
				new _0003_2009(_0005._0002_2008, _0002_200B_2005)
			},
			{
				_0005._0002_200A._0005(),
				new _0003_2009(_0005._0002_200A, _0008_200A)
			},
			{
				_0005._000F_2000._0005(),
				new _0003_2009(_0005._000F_2000, _0006_2009)
			},
			{
				_0005._0006_2007_200B._0005(),
				new _0003_2009(_0005._0006_2007_200B, _0006_2004)
			},
			{
				_0005._000E_2005_200B._0005(),
				new _0003_2009(_0005._000E_2005_200B, _000F_2001_200B)
			},
			{
				_0005._000F_200B._0005(),
				new _0003_2009(_0005._000F_200B, _0006_2001_2005)
			},
			{
				_0005._000E_2003._0005(),
				new _0003_2009(_0005._000E_2003, _0006)
			},
			{
				_0005._000F_2004_200B._0005(),
				new _0003_2009(_0005._000F_2004_200B, _0006_2003)
			},
			{
				_0005._0008_2002_2005._0005(),
				new _0003_2009(_0005._0008_2002_2005, _0005_2000_200B)
			},
			{
				_0005._000F_2008_200B._0005(),
				new _0003_2009(_0005._000F_2008_200B, _000E_2009)
			},
			{
				_0005._0005_200B_200B._0005(),
				new _0003_2009(_0005._0005_200B_200B, _0005_2005)
			},
			{
				_0005._0008_2006_200B._0005(),
				new _0003_2009(_0005._0008_2006_200B, _0002_2007_200B)
			},
			{
				_0005._0005_2009._0005(),
				new _0003_2009(_0005._0005_2009, _0003_200A_2005)
			},
			{
				_0005._0002_2007_200B._0005(),
				new _0003_2009(_0005._0002_2007_200B, _0008_2003)
			},
			{
				_0005._0008_200B._0005(),
				new _0003_2009(_0005._0008_200B, _0003_2009_2005)
			},
			{
				_0005._0003_2008_200B._0005(),
				new _0003_2009(_0005._0003_2008_200B, _0005_2007)
			},
			{
				_0005._0003_2002._0005(),
				new _0003_2009(_0005._0003_2002, _0002_2009_200B)
			},
			{
				_0005._0005_2005_200B._0005(),
				new _0003_2009(_0005._0005_2005_200B, _0003_2007_200B)
			},
			{
				_0005._0005_2000._0005(),
				new _0003_2009(_0005._0005_2000, _000F_2004_200B)
			},
			{
				_0005._000E_2002._0005(),
				new _0003_2009(_0005._000E_2002, _0005_2002)
			},
			{
				_0005._000F_2009_2005._0005(),
				new _0003_2009(_0005._000F_2009_2005, _0002_2008_200B)
			},
			{
				_0005._0006_2001_2005._0005(),
				new _0003_2009(_0005._0006_2001_2005, _000E_2007)
			},
			{
				_0005._0006_200A_2005._0005(),
				new _0003_2009(_0005._0006_200A_2005, _0008_2005_200B)
			},
			{
				_0005._000F_200B_200B._0005(),
				new _0003_2009(_0005._000F_200B_200B, _000E_2000_200B)
			},
			{
				_0005._000F_2001_2005._0005(),
				new _0003_2009(_0005._000F_2001_2005, _0006_2008_2005)
			},
			{
				_0005._0008_2007._0005(),
				new _0003_2009(_0005._0008_2007, _0002_200B)
			},
			{
				_0005._000E_200A._0005(),
				new _0003_2009(_0005._000E_200A, _0008_2002_200B)
			},
			{
				_0005._0003_2008._0005(),
				new _0003_2009(_0005._0003_2008, _0008_2007)
			},
			{
				_0005._0005_2004._0005(),
				new _0003_2009(_0005._0005_2004, _0008)
			},
			{
				_0005._0002_2009_2005._0005(),
				new _0003_2009(_0005._0002_2009_2005, _0006_2008)
			},
			{
				_0005._000F_2009._0005(),
				new _0003_2009(_0005._000F_2009, _000E_2008)
			},
			{
				_0005._0008_2002_200B._0005(),
				new _0003_2009(_0005._0008_2002_200B, _0002_2009_2005)
			},
			{
				_0005._000F._0005(),
				new _0003_2009(_0005._000F, _0008_2003_200B)
			},
			{
				_0005._0002_2004._0005(),
				new _0003_2009(_0005._0002_2004, _000F_2008_200B)
			},
			{
				_0005._0008_2003_200B._0005(),
				new _0003_2009(_0005._0008_2003_200B, _0006_2000)
			},
			{
				_0005._0005_2005._0005(),
				new _0003_2009(_0005._0005_2005, _0005_200B_2005)
			},
			{
				_0005._0008_200A_200B._0005(),
				new _0003_2009(_0005._0008_200A_200B, _000F_2005)
			},
			{
				_0005._0008_2008._0005(),
				new _0003_2009(_0005._0008_2008, _0003_2003_200B)
			},
			{
				_0005._000E_2009._0005(),
				new _0003_2009(_0005._000E_2009, _0005_2006_200B)
			},
			{
				_0005._0008_2001_200B._0005(),
				new _0003_2009(_0005._0008_2001_200B, _0008_2001_2005)
			},
			{
				_0005._0003_2005_200B._0005(),
				new _0003_2009(_0005._0003_2005_200B, _0008_2008_200B)
			},
			{
				_0005._0002_200B_2005._0005(),
				new _0003_2009(_0005._0002_200B_2005, _000E_200A_200B)
			},
			{
				_0005._000E_2001_200B._0005(),
				new _0003_2009(_0005._000E_2001_200B, _000F_2005_200B)
			},
			{
				_0005._0008_2004_200B._0005(),
				new _0003_2009(_0005._0008_2004_200B, _0002_200B_200B)
			},
			{
				_0005._0003_2000_200B._0005(),
				new _0003_2009(_0005._0003_2000_200B, _000E_2004)
			},
			{
				_0005._0008_2002._0005(),
				new _0003_2009(_0005._0008_2002, _0003_2000_200B)
			},
			{
				_0005._0005_2002_200B._0005(),
				new _0003_2009(_0005._0005_2002_200B, _000F_2006)
			},
			{
				_0005._0003_2001_200B._0005(),
				new _0003_2009(_0005._0003_2001_200B, _0005_200A_200B)
			},
			{
				_0005._0003_2007._0005(),
				new _0003_2009(_0005._0003_2007, _000E_200A_2005)
			},
			{
				_0005._0003_2004_200B._0005(),
				new _0003_2009(_0005._0003_2004_200B, _0005_200A_2005)
			},
			{
				_0005._0003._0005(),
				new _0003_2009(_0005._0003, _0002_2001_200B)
			},
			{
				_0005._000F_200A_200B._0005(),
				new _0003_2009(_0005._000F_200A_200B, _0002_200A)
			},
			{
				_0005._0003_200A_200B._0005(),
				new _0003_2009(_0005._0003_200A_200B, _0006_2005_200B)
			},
			{
				_0005._0008_2000_200B._0005(),
				new _0003_2009(_0005._0008_2000_200B, _000F_2000_200B)
			},
			{
				_0005._000F_2002_2005._0005(),
				new _0003_2009(_0005._000F_2002_2005, _000E_2003_200B)
			},
			{
				_0005._0006_2006._0005(),
				new _0003_2009(_0005._0006_2006, _0008_200A_2005)
			},
			{
				_0005._0006_2001_200B._0005(),
				new _0003_2009(_0005._0006_2001_200B, _000F_2008)
			},
			{
				_0005._000E_200B._0005(),
				new _0003_2009(_0005._000E_200B, _0003_2004_200B)
			},
			{
				_0005._000E_2001._0005(),
				new _0003_2009(_0005._000E_2001, _0006_2005)
			},
			{
				_0005._0008_2008_2005._0005(),
				new _0003_2009(_0005._0008_2008_2005, _000E_200A)
			},
			{
				_0005._0008_2009._0005(),
				new _0003_2009(_0005._0008_2009, _000E_2006_200B)
			},
			{
				_0005._000F_200A_2005._0005(),
				new _0003_2009(_0005._000F_200A_2005, _0008_200B)
			},
			{
				_0005._0008_200A._0005(),
				new _0003_2009(_0005._0008_200A, _0006_2001_200B)
			},
			{
				_0005._0006_2008_2005._0005(),
				new _0003_2009(_0005._0006_2008_2005, _0003_2003)
			},
			{
				_0005._0005_2001_200B._0005(),
				new _0003_2009(_0005._0005_2001_200B, _0006_200A_2005)
			},
			{
				_0005._000E_2000._0005(),
				new _0003_2009(_0005._000E_2000, _0008_2006_200B)
			},
			{
				_0005._000E_2002_200B._0005(),
				new _0003_2009(_0005._000E_2002_200B, _0008_2001)
			},
			{
				_0005._0003_200A_2005._0005(),
				new _0003_2009(_0005._0003_200A_2005, _0002_200A_2005)
			},
			{
				_0005._000F_2003._0005(),
				new _0003_2009(_0005._000F_2003, _000F_2009_200B)
			},
			{
				_0005._0005_2001_2005._0005(),
				new _0003_2009(_0005._0005_2001_2005, _000E_2005)
			},
			{
				_0005._000E_2009_200B._0005(),
				new _0003_2009(_0005._000E_2009_200B, _000F_200A)
			},
			{
				_0005._000F_2005_200B._0005(),
				new _0003_2009(_0005._000F_2005_200B, _000F_200A_200B)
			},
			{
				_0005._0003_2003_200B._0005(),
				new _0003_2009(_0005._0003_2003_200B, _0008_2007_200B)
			},
			{
				_0005._0006_2002._0005(),
				new _0003_2009(_0005._0006_2002, _0005_2005_200B)
			},
			{
				_0005._0002._0005(),
				new _0003_2009(_0005._0002, _000F_2003)
			},
			{
				_0005._0003_2001._0005(),
				new _0003_2009(_0005._0003_2001, _0003_2006_200B)
			},
			{
				_0005._000F_2008_2005._0005(),
				new _0003_2009(_0005._000F_2008_2005, _0003_2009)
			},
			{
				_0005._000F_2002._0005(),
				new _0003_2009(_0005._000F_2002, _000F_200B_200B)
			},
			{
				_0005._0005_2009_200B._0005(),
				new _0003_2009(_0005._0005_2009_200B, _0005_2009)
			},
			{
				_0005._000E_2005._0005(),
				new _0003_2009(_0005._000E_2005, _000E_2008_2005)
			},
			{
				_0005._0006_200A._0005(),
				new _0003_2009(_0005._0006_200A, _0002)
			},
			{
				_0005._000F_2006._0005(),
				new _0003_2009(_0005._000F_2006, _0003)
			},
			{
				_0005._0003_2002_2005._0005(),
				new _0003_2009(_0005._0003_2002_2005, _0008_2009_2005)
			},
			{
				_0005._0005_200A._0005(),
				new _0003_2009(_0005._0005_200A, _0003_2001_2005)
			},
			{
				_0005._0005_2004_200B._0005(),
				new _0003_2009(_0005._0005_2004_200B, _000F_2007_200B)
			},
			{
				_0005._0005_2002._0005(),
				new _0003_2009(_0005._0005_2002, _0005_2004_200B)
			},
			{
				_0005._000E_2007_200B._0005(),
				new _0003_2009(_0005._000E_2007_200B, _0003_2001_200B)
			},
			{
				_0005._0003_2002_200B._0005(),
				new _0003_2009(_0005._0003_2002_200B, _0005_2009_2005)
			},
			{
				_0005._000E_2006._0005(),
				new _0003_2009(_0005._000E_2006, _0003_2008_2005)
			},
			{
				_0005._0006_2005_200B._0005(),
				new _0003_2009(_0005._0006_2005_200B, _000F_2009)
			},
			{
				_0005._0002_2007._0005(),
				new _0003_2009(_0005._0002_2007, _0002_2008_2005)
			},
			{
				_0005._0008_2008_200B._0005(),
				new _0003_2009(_0005._0008_2008_200B, _000F_2009_2005)
			},
			{
				_0005._0005_2008_200B._0005(),
				new _0003_2009(_0005._0005_2008_200B, _000E)
			},
			{
				_0005._000F_200B_2005._0005(),
				new _0003_2009(_0005._000F_200B_2005, _000F_2004)
			},
			{
				_0005._0005_2003_200B._0005(),
				new _0003_2009(_0005._0005_2003_200B, _0005_2007_200B)
			},
			{
				_0005._0002_200A_200B._0005(),
				new _0003_2009(_0005._0002_200A_200B, _0002_2009)
			},
			{
				_0005._0002_200B._0005(),
				new _0003_2009(_0005._0002_200B, _0006_200A)
			},
			{
				_0005._0003_2003._0005(),
				new _0003_2009(_0005._0003_2003, _000E_2009_200B)
			},
			{
				_0005._0006_2009_200B._0005(),
				new _0003_2009(_0005._0006_2009_200B, _000E_2000)
			},
			{
				_0005._000F_2007._0005(),
				new _0003_2009(_0005._000F_2007, _0005_2006)
			},
			{
				_0005._0002_2008_200B._0005(),
				new _0003_2009(_0005._0002_2008_200B, _0006_2000_200B)
			},
			{
				_0005._000E_2004_200B._0005(),
				new _0003_2009(_0005._000E_2004_200B, _0006_2007_200B)
			},
			{
				_0005._0002_2003_200B._0005(),
				new _0003_2009(_0005._0002_2003_200B, _000F_2000)
			},
			{
				_0005._0006_2000_200B._0005(),
				new _0003_2009(_0005._0006_2000_200B, _0002_2005)
			},
			{
				_0005._0002_2002._0005(),
				new _0003_2009(_0005._0002_2002, _000F_2002)
			},
			{
				_0005._0005_2006._0005(),
				new _0003_2009(_0005._0005_2006, _0003_200A_200B)
			},
			{
				_0005._0008_2007_200B._0005(),
				new _0003_2009(_0005._0008_2007_200B, _000E_2001_200B)
			},
			{
				_0005._0002_2006_200B._0005(),
				new _0003_2009(_0005._0002_2006_200B, _000E_200B_200B)
			},
			{
				_0005._0005_2001._0005(),
				new _0003_2009(_0005._0005_2001, _0005_2008_2005)
			},
			{
				_0005._0002_2009_200B._0005(),
				new _0003_2009(_0005._0002_2009_200B, _0002_2007)
			},
			{
				_0005._000E_200A_200B._0005(),
				new _0003_2009(_0005._000E_200A_200B, _000F_200A_2005)
			},
			{
				_0005._0008_2000._0005(),
				new _0003_2009(_0005._0008_2000, _000E_2007_200B)
			},
			{
				_0005._0006_2008_200B._0005(),
				new _0003_2009(_0005._0006_2008_200B, _0003_200A)
			},
			{
				_0005._0003_2009._0005(),
				new _0003_2009(_0005._0003_2009, _0008_2002)
			}
		};
	}

	private static void _0002_2008_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		global::_000F obj2 = _0005._0002();
		_0005._0005(_0005._0006(obj2, obj));
	}

	private static void _0005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(typeof(double));
	}

	private static void _0005_200A_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(typeof(uint));
	}

	private Type _0005(int _0005, global::_0005 _0002, ref bool _000F, bool _0006)
	{
		if (_0002._0005() == 0)
		{
			return this.m__0008_2001.ResolveType(_0002._0005());
		}
		_0008_2002 obj = (_0008_2002)_0002._0005();
		Type type = null;
		if (obj._0005())
		{
			if (obj._0002() != -1)
			{
				if (this.m__000F_2008 == null)
				{
					throw new InvalidOperationException(_000F_0019._0005(-1057761625));
				}
				type = this.m__000F_2008[obj._0002()];
			}
			else
			{
				if (obj._0005() == -1)
				{
					throw new Exception();
				}
				if (this.m__0002_200B == null)
				{
					throw new InvalidOperationException(_000F_0019._0005(-1057761580));
				}
				type = this.m__0002_200B[obj._0005()];
			}
			Stack<_000E_2002> stack = global::_0005_2004._0005(obj._0005());
			type = global::_0005_2004._0005(type, stack);
			_000F = false;
			return type;
		}
		string text = obj._0005();
		try
		{
			type = Type.GetType(text);
		}
		catch (BadImageFormatException)
		{
		}
		if (type == null)
		{
			int num = text.IndexOf(',');
			string text2 = text.Substring(0, num);
			string text3 = text.Substring(num + 1).Trim();
			Assembly assembly = global::_0005_2004._0003;
			if (text3.Equals(assembly.FullName, StringComparison.OrdinalIgnoreCase))
			{
				type = ((!text2.Equals(_000F_0019._0005(-1057761595), StringComparison.Ordinal)) ? assembly.GetType(text2) : global::_000F_2001.m__000F_2009);
			}
			else
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				foreach (Assembly assembly2 in assemblies)
				{
					string value = null;
					try
					{
						value = assembly2.Location;
					}
					catch (NotSupportedException)
					{
					}
					if (string.IsNullOrEmpty(value) && assembly2.FullName.Equals(text3, StringComparison.OrdinalIgnoreCase))
					{
						type = assembly2.GetType(text2);
						if (type != null)
						{
							break;
						}
					}
				}
			}
			if (type == null && text2.StartsWith(_000F_0019._0005(-1057761548), StringComparison.Ordinal) && text2.Contains(_000F_0019._0005(-1057761762)))
			{
				try
				{
					Type[] types = Assembly.Load(text3).GetTypes();
					foreach (Type type2 in types)
					{
						if (type2.FullName == text2)
						{
							type = type2;
							break;
						}
					}
				}
				catch
				{
				}
			}
		}
		if (type == null)
		{
			throw new TypeLoadException(string.Format(_000F_0019._0005(-1057761786), text));
		}
		if (obj._0002())
		{
			if (obj._0005().Length != 0)
			{
				Type[] array = new Type[obj._0005().Length];
				for (int j = 0; j < obj._0005().Length; j++)
				{
					array[j] = this._0005(obj._0005()[j]._0005(), _0006);
				}
				Type genericTypeDefinition = global::_0005_2004._0005(type).GetGenericTypeDefinition();
				Stack<_000E_2002> stack2 = global::_0005_2004._0005(type);
				type = genericTypeDefinition.MakeGenericType(array);
				type = global::_0005_2004._0005(type, stack2);
			}
			_000F = false;
		}
		return type;
	}

	private static void _000F(ILGenerator _0005, Type _0002)
	{
		if (!(_0002 == global::_0005_2004._0005))
		{
			_0005.Emit(OpCodes.Castclass, _0002);
		}
	}

	private static void _000F_200A(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003(2);
	}

	private static void _0003_200A_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003();
	}

	public static object _0005(Type _0005)
	{
		if (_0005.IsValueType)
		{
			return Activator.CreateInstance(_0005);
		}
		return null;
	}

	private void _0006()
	{
		this.m__0003_2001 = true;
	}

	private void _0005(Stream _0005, long _0002, string _000F)
	{
		int num = this._0002();
		_000F_2003 obj = new _000F_2003(_0005, num);
		this.m__0005_2009 = new _0005_2009_200B(obj);
		if (_000F != null)
		{
			_0002 = this._0005(_000F);
		}
		global::_0008 obj2 = this.m__0005_2009._0005();
		lock (obj2)
		{
			obj2._0008_2001_2004_2001_0005(_0002, 0);
			this._0005(this.m__0005_2009);
			this.m__000E_2008 = this._0005(this.m__0005_2009);
			this.m__0008_2008 = global::_000F_2001._0005(this.m__0005_2009);
			this.m__0006_200B = global::_000F_2001._0005(this.m__0005_2009);
		}
		_0008();
	}

	private void _0006(int _0005)
	{
		global::_000F obj = _0002();
		this.m__0002_2001[_0005]._000F_2001_2004_2001_0005(obj);
	}

	private static void _000E_2009_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(typeof(double));
	}

	private static void _000E_2002_200B(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		FieldInfo fieldInfo = _0005._0005(num);
		_0005._0005((global::_000F)new _000E_2000(fieldInfo, null));
	}

	private static object _0005(MethodBase _0005, object _0002, object[] _000F, bool _0006)
	{
		_0005 obj = new _0005(_0005, _0006);
		_000F obj2 = global::_000F_2001._0005(obj);
		if (obj2 == null)
		{
			bool flag;
			lock (global::_000F_2001.m__000F_200B)
			{
				global::_000F_2001.m__000F_200B.TryGetValue(_0005, out var value);
				flag = value >= 50;
				if (!flag)
				{
					global::_000F_2001.m__000F_200B[_0005] = value + 1;
				}
			}
			if (!flag && (_0006 || _0002 != null || _0005.IsStatic || _0005.IsConstructor) && !global::_000F_2001._0005(_0005) && (_0005.CallingConvention & CallingConventions.Any) != CallingConventions.VarArgs)
			{
				return global::_000F_2001._0005(_0005, _0002, _000F);
			}
			obj2 = global::_000F_2001._0002(obj);
			lock (global::_000F_2001.m__000F_200B)
			{
				global::_000F_2001.m__000F_200B.Remove(_0005);
			}
		}
		return obj2(_0002, _000F);
	}

	private static void _000E_2001_200B(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		Type type = _0005._0005(num, _0002: true);
		_0005._000F(type);
	}

	private static void _0006_2001_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000E(_0005: true);
	}

	private static void _0005_200B_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003();
	}

	private static void _0002_200B_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003_2009(_0005: true);
	}

	private static void _000F_2005_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003_2009(_0005: false);
	}

	private static void _0008_2008_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(typeof(float));
	}

	private void _0002(bool _0005, bool _0002)
	{
		global::_000F obj = this._0002();
		global::_000F obj2 = this._0002();
		this._0005(_0003(obj2, obj, _0005, _0002));
	}

	private global::_000F _0005(_0005_2009_200B _0005, byte _0002)
	{
		switch (_0002)
		{
		case 11:
			return null;
		case 0:
		{
			this.m__0002_200A++;
			_0003_200B obj2 = new _0003_200B();
			obj2._0005(_0005._0005());
			return obj2;
		}
		case 2:
		case 6:
			this.m__0002_200A += 4u;
			return new global::_0006(_0005._0008());
		case 10:
			this.m__0002_200A += 8u;
			return new _0003_2003(_0005._0005());
		case 3:
		case 7:
		{
			this.m__0002_200A++;
			_0002_2009_200B obj7 = new _0002_2009_200B();
			obj7._0005(_0005._0005());
			return obj7;
		}
		case 5:
		case 12:
		{
			this.m__0002_200A += 2u;
			_0008_200A obj6 = new _0008_200A();
			obj6._0005(_0005._0005());
			return obj6;
		}
		case 4:
		{
			this.m__0002_200A += 4u;
			_0006_2000 obj5 = new _0006_2000();
			obj5._0005(_0005._0005());
			return obj5;
		}
		case 8:
		{
			this.m__0002_200A += 8u;
			_000F_2006 obj4 = new _000F_2006();
			obj4._0005(_0005._0005());
			return obj4;
		}
		case 1:
		{
			this.m__0002_200A += 4u;
			_0006_200B obj3 = new _0006_200B();
			obj3._0005(_0005._0005());
			return obj3;
		}
		case 9:
		{
			int num = _0005._0008();
			global::_0006[] array = new global::_0006[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new global::_0006(_0005._0008());
			}
			this.m__0002_200A += (uint)((num + 1) * 4);
			global::_000F_2009 obj = new global::_000F_2009();
			obj._0005(array);
			return obj;
		}
		default:
			throw new Exception(_000F_0019._0005(-1057761736));
		}
	}

	private static void _0008_2008_200B(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		Type type = _0005._0005(num, _0002: true);
		global::_000F obj = _0005._0002();
		if (_0005._0005(obj, type))
		{
			_0005._0005(obj);
			return;
		}
		throw new InvalidCastException();
	}

	private static global::_000F _0008(global::_000F _0005, global::_000F _0002, bool _000F, bool _0006)
	{
		if (_0005._0005() == 1)
		{
			if (_0002._0005() == 1)
			{
				if (!_0006)
				{
					int num = ((global::_0006)_0005)._0005();
					int num2 = ((global::_0006)_0002)._0005();
					int num3 = ((!_000F) ? (num - num2) : checked(num - num2));
					return new global::_0006(num3);
				}
				uint num4 = (uint)((global::_0006)_0005)._0005();
				uint num5 = (uint)((global::_0006)_0002)._0005();
				uint num6 = ((!_000F) ? (num4 - num5) : checked(num4 - num5));
				return new global::_0006((int)num6);
			}
			if (_0002._0005() == 13)
			{
				return global::_000F_2001._0006(new _0003_2003(((global::_0006)_0005)._0005()), _0002, _000F, _0006);
			}
			if (_0002._0005() == 19)
			{
				Type underlyingType = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
				{
					return global::_000F_2001._0006(new _0003_2003(((global::_0006)_0005)._0005()), new _0003_2003(Convert.ToInt64(_0002._000F_2001_2004_2001_0005())), _000F, _0006);
				}
				return _0008(_0005, new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())), _000F, _0006);
			}
		}
		if (_0005._0005() == 13)
		{
			if (_0002._0005() == 13)
			{
				return global::_000F_2001._0006(_0005, _0002, _000F, _0006);
			}
			if (_0002._0005() == 1)
			{
				return global::_000F_2001._0006(_0005, new _0003_2003(((global::_0006)_0002)._0005()), _000F, _0006);
			}
			if (_0002._0005() == 19)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(_0002._000F_2001_2004_2001_0005().GetType());
				if (underlyingType2 == typeof(long) || underlyingType2 == typeof(ulong))
				{
					return global::_000F_2001._0006(_0005, new _0003_2003(Convert.ToInt64(_0002._000F_2001_2004_2001_0005())), _000F, _0006);
				}
				return global::_000F_2001._0006(_0005, new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())), _000F, _0006);
			}
		}
		if (_0005._0005() == 8 && _0002._0005() == 8)
		{
			_000F_2006 obj = new _000F_2006();
			obj._0005(((_000F_2006)_0005)._0005() - ((_000F_2006)_0002)._0005());
			return obj;
		}
		if (_0005._0005() == 19)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
			if (underlyingType3 == typeof(long) || underlyingType3 == typeof(ulong))
			{
				return _0008(new _0003_2003(Convert.ToInt64(_0005._000F_2001_2004_2001_0005())), _0002, _000F, _0006);
			}
			return _0008(new global::_0006(Convert.ToInt32(_0005._000F_2001_2004_2001_0005())), _0002, _000F, _0006);
		}
		throw new InvalidOperationException();
	}

	private void _000F_2009(bool _0005)
	{
		global::_000F obj = _0002();
		int num = obj._0005() switch
		{
			1 => (!_0005) ? ((global::_0006)obj)._0005() : ((global::_0006)obj)._0005(), 
			13 => (int)((!_0005) ? ((_0003_2003)obj)._0005() : checked((int)((_0003_2003)obj)._0005())), 
			19 => (!_0005) ? ((int)Convert.ToUInt64(((_0005_0019)obj)._0005())) : checked((int)Convert.ToUInt64(((_0005_0019)obj)._0005())), 
			8 => (!_0005) ? ((int)((_000F_2006)obj)._0005()) : checked((int)((_000F_2006)obj)._0005()), 
			0 => (int)((IntPtr.Size != 4) ? ((!_0005) ? ((long)((_000F_2002)obj)._0005()) : checked((int)(long)((_000F_2002)obj)._0005())) : ((!_0005) ? ((int)((_000F_2002)obj)._0005()) : ((int)((_000F_2002)obj)._0005()))), 
			_ => throw new InvalidOperationException(), 
		};
		global::_0006 obj2 = new global::_0006();
		obj2._0005(num);
		this._0005((global::_000F)obj2);
	}

	private static void _000F_2000(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(global::_0005_2004._0005);
	}

	private static string _0005(MethodBase _0005)
	{
		Type declaringType = _0005.DeclaringType;
		ParameterInfo[] parameters = _0005.GetParameters();
		string[] array = new string[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			ParameterInfo parameterInfo = parameters[i];
			array[i] = string.Format(_000F_0019._0005(-1057761695), parameterInfo.ParameterType, parameterInfo.Name);
		}
		string text = string.Join(_000F_0019._0005(-1057762925), array);
		return declaringType.FullName + _000F_0019._0005(-1057761762) + _0005.Name + _000F_0019._0005(-1057762920) + text + _000F_0019._0005(-1057762944);
	}

	private _0005_2005[] _0005(_0005_2009_200B _0005)
	{
		_0005_2005[] array = new _0005_2005[_0005._0005()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = this._0005(_0005);
		}
		return array;
	}

	private void _000F(bool _0005)
	{
		global::_000F obj = _0002();
		bool flag = IntPtr.Size == 4;
		checked
		{
			IntPtr intPtr;
			switch (obj._0005())
			{
			case 1:
			{
				int num = ((global::_0006)obj)._0005();
				if (flag)
				{
					intPtr = ((!_0005) ? new IntPtr(num) : new IntPtr((int)(uint)num));
				}
				else
				{
					intPtr = ((!_0005) ? new IntPtr(unchecked((uint)num)) : new IntPtr((uint)num));
				}
				break;
			}
			case 13:
			{
				long num2 = ((_0003_2003)obj)._0005();
				if (flag)
				{
					intPtr = ((!_0005) ? new IntPtr(unchecked((int)num2)) : new IntPtr((int)(ulong)num2));
				}
				else
				{
					intPtr = ((!_0005) ? new IntPtr(num2) : new IntPtr((long)(ulong)num2));
				}
				break;
			}
			case 8:
			{
				double num3 = ((_000F_2006)obj)._0005();
				if (flag)
				{
					intPtr = ((!_0005) ? new IntPtr(unchecked((int)(ulong)num3)) : new IntPtr((int)(ulong)num3));
				}
				else
				{
					intPtr = ((!_0005) ? new IntPtr(unchecked((long)num3)) : new IntPtr((long)(ulong)num3));
				}
				break;
			}
			case 19:
				intPtr = ((!_0005) ? new IntPtr(Convert.ToInt64(((_0005_0019)obj)._0005())) : new IntPtr(Convert.ToInt64(((_0005_0019)obj)._0005())));
				break;
			default:
				throw new InvalidOperationException();
			}
			_000F_2002 obj2 = new _000F_2002();
			obj2._0005(intPtr);
			this._0005((global::_000F)obj2);
		}
	}

	private static void _0005_2009(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003(_0005: true);
	}

	private void _0002_2009(bool _0005)
	{
		global::_000F obj = _0002();
		short num = obj._0005() switch
		{
			1 => (!_0005) ? ((short)((global::_0006)obj)._0005()) : checked((short)((global::_0006)obj)._0005()), 
			13 => (!_0005) ? ((short)((_0003_2003)obj)._0005()) : checked((short)((_0003_2003)obj)._0005()), 
			19 => (!_0005) ? ((short)Convert.ToUInt64(((_0005_0019)obj)._0005())) : checked((short)Convert.ToUInt64(((_0005_0019)obj)._0005())), 
			8 => (!_0005) ? ((short)((_000F_2006)obj)._0005()) : checked((short)((_000F_2006)obj)._0005()), 
			0 => (IntPtr.Size != 4) ? ((!_0005) ? ((short)(long)((_000F_2002)obj)._0005()) : checked((short)(long)((_000F_2002)obj)._0005())) : ((!_0005) ? ((short)(int)((_000F_2002)obj)._0005()) : checked((short)(int)((_000F_2002)obj)._0005())), 
			_ => throw new InvalidOperationException(), 
		};
		global::_0006 obj2 = new global::_0006();
		obj2._0005(num);
		this._0005((global::_000F)obj2);
	}

	private static void _000E_2004_200B(_000F_2001 _0005, global::_000F _0002)
	{
	}

	private static void _0008_2009_2005(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		checked
		{
			_0005._0005((global::_000F)new global::_0006(obj._0005() switch
			{
				1 => unchecked((int)checked((short)(uint)((global::_0006)obj)._0005())), 
				13 => (short)(ulong)((_0003_2003)obj)._0005(), 
				19 => (short)Convert.ToUInt64(((_0005_0019)obj)._0005()), 
				8 => (short)((_000F_2006)obj)._0005(), 
				0 => (IntPtr.Size != 4) ? ((short)(ulong)(long)((_000F_2002)obj)._0005()) : ((short)(uint)(int)((_000F_2002)obj)._0005()), 
				_ => throw new InvalidOperationException(), 
			}));
		}
	}

	private static void _000F_2008_200B(_000F_2001 _0005, global::_000F _0002)
	{
		MethodBase methodBase = ((_0006_2009_200B)_0005._0002())._0005();
		_0005._0005(methodBase, false);
	}

	private static void _0003_2001(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F_2009(_0005: true);
	}

	private void _0005(global::_000F _0005)
	{
		if (_0005 == null)
		{
			throw new ArgumentNullException(_000F_0019._0005(-1057761405));
		}
		global::_000F obj;
		if (_0005._0005() != null)
		{
			obj = _0005;
		}
		else
		{
			switch (_0005._0005())
			{
			case 22:
			{
				_000F_2006 obj10 = new _000F_2006();
				obj10._0005(((_0006_2000)_0005)._0005());
				obj10._0005(_0005._0005());
				obj = obj10;
				break;
			}
			case 12:
			{
				global::_0006 obj9 = new global::_0006(((_0002_2009_200B)_0005)._0005());
				obj9._0005(_0005._0005());
				obj = obj9;
				break;
			}
			case 26:
			{
				global::_0006 obj8 = new global::_0006(((_000E_2001)_0005)._0005());
				obj8._0005(_0005._0005());
				obj = obj8;
				break;
			}
			case 17:
			{
				global::_0006 obj11 = new global::_0006(((_0003_200B)_0005)._0005());
				obj11._0005(_0005._0005());
				obj = obj11;
				break;
			}
			case 16:
			{
				global::_0006 obj6 = new global::_0006(((_0008_200A)_0005)._0005());
				obj6._0005(_0005._0005());
				obj = obj6;
				break;
			}
			case 3:
			{
				global::_0006 obj5 = new global::_0006((int)((_0006_200B)_0005)._0005());
				obj5._0005(_0005._0005());
				obj = obj5;
				break;
			}
			case 14:
			{
				_0003_2003 obj7 = new _0003_2003((long)((_000E_2005)_0005)._0005());
				obj7._0005(_0005._0005());
				obj = obj7;
				break;
			}
			case 15:
			{
				global::_0006 obj4 = new global::_0006(((_0008_2006)_0005)._0005() ? 1 : 0);
				obj4._0005(_0005._0005());
				obj = obj4;
				break;
			}
			case 6:
			{
				global::_0006 obj3 = new global::_0006(((_000E_2006)_0005)._0005());
				obj3._0005(_0005._0005());
				obj = obj3;
				break;
			}
			case 7:
			{
				object obj2 = _0005._000F_2001_2004_2001_0005();
				if (obj2 == null)
				{
					obj = _0005;
					break;
				}
				Type type = obj2.GetType();
				if (type.HasElementType && !type.IsArray)
				{
					type = type.GetElementType();
				}
				obj = ((!(type != null) || type.IsValueType || type.IsEnum) ? global::_000F._0005(obj2, type) : _0005);
				break;
			}
			default:
				obj = _0005;
				break;
			}
		}
		if (this.m__0005_200B != null)
		{
			if (this.m__0005_2008 != null)
			{
				this.m__0003.Push(this.m__0005_2008);
			}
			this.m__0005_2008 = this.m__0005_200B;
		}
		this.m__0005_200B = obj;
	}

	private object _0005(object[] _0005, Type[] _0002, Type[] _000F, object[] _0006)
	{
		this._0002();
		if (_0005 == null)
		{
			_0005 = global::_0003_2005<object>._0005;
		}
		this.m__0005_2001 = _0006;
		this.m__000F_2008 = _0002;
		this.m__0002_200B = _000F;
		this.m__0002_2001 = this._0005(_0005);
		this.m__0006_200A = this._0005();
		try
		{
			global::_0003 obj = new global::_0003(this.m__0006_200B);
			try
			{
				using (this.m__000E = new _0005_2009_200B(obj))
				{
					this.m__0008 = (uint)((global::_0008)obj)._0008_2001_2004_2001_0005();
					this.m__0003_2001 = false;
					this.m__0006_2001 = null;
					this.m__0006 = 0u;
					this.m__0002_200A = 0u;
					_000E();
					_000F_2009();
				}
			}
			finally
			{
				((IDisposable)obj).Dispose();
			}
			Type type = this._0005(this.m__000E_2008._0002(), _0002: false);
			if (type != global::_000F_2001.m__0003_2009 && this._0005())
			{
				return global::_000F._0005(null, type)._000F_2001_2004_2001_0005(this._0002())._000F_2001_2004_2001_0005();
			}
			return null;
		}
		finally
		{
			for (int i = 0; i < this.m__000E_2008._0005().Length; i++)
			{
				_0005_2005 obj2 = this.m__000E_2008._0005()[i];
				if (obj2._0005())
				{
					_0006_2005 obj3 = (_0006_2005)this.m__0002_2001[i];
					Type type2 = this._0005(obj2._0005(), _0002: false);
					_0005[i] = global::_000F._0005(null, type2.GetElementType())._000F_2001_2004_2001_0005(obj3._0005())._000F_2001_2004_2001_0005();
				}
			}
			this.m__0005_2001 = null;
			this.m__0002_2001 = null;
			this.m__0006_200A = null;
		}
	}

	private void _0005(ref _000E_2009 _0005, MethodBase _0002, bool _000F)
	{
		bool flag = false;
		if (_0002.DeclaringType == typeof(Interlocked) && _0002.IsStatic)
		{
			string name = _0002.Name;
			if (name == _000F_0019._0005(-1057762632) || name == _000F_0019._0005(-1057762642) || name == _000F_0019._0005(-1057762600) || name == _000F_0019._0005(-1057762616) || name == _000F_0019._0005(-1057762565) || name == _000F_0019._0005(-1057762581))
			{
				flag = true;
			}
		}
		if (flag)
		{
			try
			{
			}
			finally
			{
				Monitor.Enter(global::_000F_2001.m__0006_2008);
				_0005._0005 = true;
			}
		}
	}

	private static void _0003_2007(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(((_0008_200A)_0002)._0005());
	}

	private static void _0003_2002_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0006();
	}

	private void _0005(_0003_2009_200B _0005)
	{
		if (global::_000F_2001._0005() && !this.m__000E_2008._0002() && _0005._0002() && !_0005._000F())
		{
			string text = this._0005(_0005);
			throw global::_000F_2001._0005(this._0005(this.m__000E_2008), text);
		}
	}

	private void _0008(int _0005)
	{
		global::_0002_2009 obj = new global::_0002_2009();
		obj._0005(_0005);
		this._0005((global::_000F)obj);
	}

	private static Exception _0002(string _0005, string _0002)
	{
		return new FieldAccessException(global::_000F_2001._0005(_000F_0019._0005(-1057762093) + _0005 + _000F_0019._0005(-1057762049), _000F_0019._0005(-1057761657) + _0002 + _000F_0019._0005(-1057762049)));
	}

	private static void _0002_200A(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(global::_0005_2004._0005);
	}

	[Conditional("DEBUG")]
	private void _0002(object _0005)
	{
	}

	private static global::_000F _0006(global::_000F _0005, global::_000F _0002, bool _000F, bool _0006)
	{
		if (!_0006)
		{
			long num = ((_0003_2003)_0005)._0005();
			long num2 = ((_0003_2003)_0002)._0005();
			long num3 = ((!_000F) ? (num - num2) : checked(num - num2));
			return new _0003_2003(num3);
		}
		ulong num4 = (ulong)((_0003_2003)_0005)._0005();
		ulong num5 = (ulong)((_0003_2003)_0002)._0005();
		ulong num6 = ((!_000F) ? (num4 - num5) : checked(num4 - num5));
		return new _0003_2003((long)num6);
	}

	private static void _0005_2007_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0006(_0002);
	}

	private static void _0006_2007(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(_0005: false, _0002: false);
	}

	private void _0008()
	{
		_0005(this.m__0008_2008, global::_000F_2001._000F_2009._0005._0005);
	}

	private bool _0005(_000E_2000 _0005)
	{
		if (!_0005._0005().IsInitOnly)
		{
			return true;
		}
		if (_0005._0005().IsStatic != this.m__000E_2008._0005())
		{
			return false;
		}
		if (this.m__000E_2008._0005() && this.m__000E_2008._0005() != _000F_0019._0005(-1057761378))
		{
			return false;
		}
		Type type = _0005._0005().DeclaringType;
		if (type.IsGenericType)
		{
			type = type.GetGenericTypeDefinition();
		}
		return this._0005(this.m__000E_2008._0005(), _0002: true) == type;
	}

	private static void _000F_2002_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000E_2009(_0005: false);
	}

	private void _0006(bool _0005)
	{
		global::_000F obj = _0002();
		global::_000F obj2 = _0002();
		this._0005(_0002(obj2, obj, _0005));
	}

	private static void _000F_2008(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		global::_000F obj2 = _0005._0002();
		_0005._0005(_0005._0005(obj2, obj));
	}

	private bool _0005(global::_000F _0005, Type _0002)
	{
		object obj = _0005._000F_2001_2004_2001_0005();
		if (obj == null)
		{
			return true;
		}
		Type type = _0005._0005() ?? obj.GetType();
		if (type == _0002 || _0002.IsAssignableFrom(type))
		{
			return true;
		}
		if (!type.IsValueType && !_0002.IsValueType)
		{
			if (Marshal.IsComObject(obj))
			{
				IntPtr intPtr = IntPtr.Zero;
				try
				{
					intPtr = Marshal.GetComInterfaceForObject(obj, _0002);
				}
				catch (ArgumentException)
				{
				}
				catch (InvalidCastException)
				{
				}
				if (intPtr != IntPtr.Zero)
				{
					try
					{
						Marshal.Release(intPtr);
					}
					catch
					{
					}
					return true;
				}
			}
			else if (global::_000F_2001._0005(obj))
			{
				return true;
			}
		}
		return false;
	}

	private static void _0008_200B_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003(0);
	}

	private static void _0002_2001_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003(1);
	}

	private static void _000F_2004(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(_0002);
	}

	private static void _000F_2000_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		global::_000F obj2 = _0005._0002();
		_0005._0005((global::_000F)new global::_0006(_000F(obj2, obj) ? 1 : 0));
	}

	private void _0005(_0005_2009_200B _0005)
	{
	}

	private Type _0005(int _0005, bool _0002)
	{
		Type type;
		lock (global::_000F_2001.m__000E_2001)
		{
			bool flag = true;
			if (flag && global::_000F_2001.m__000E_2001.TryGetValue(_0005, out var value))
			{
				type = (Type)value;
			}
			else
			{
				global::_0005 obj = this._0005(_0005);
				type = this._0005(_0005, obj, ref flag, _0002);
				if (flag)
				{
					global::_000F_2001.m__000E_2001.Add(_0005, type);
				}
			}
		}
		if (_0002)
		{
			this._0005((MemberInfo)type);
		}
		return type;
	}

	private static void _0008_2004_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(1);
	}

	private static void _0002_2003(_000F_2001 _0005, global::_000F _0002)
	{
		_0002_2009_200B obj = (_0002_2009_200B)_0002;
		_0006_2005 obj2 = new _0006_2005();
		obj2._0005(_0005.m__0002_2001[obj._0005()]);
		_0005._0005((global::_000F)obj2);
	}

	private static _0003_2007 _0005(_0005_2009_200B _0005)
	{
		_0003_2007 obj = new _0003_2007();
		obj._0002(_0005._0005());
		obj._0005(_0005._0008());
		obj._0005(_0005._0005());
		obj._0002(_0005._0005());
		obj._000F(_0005._0005());
		obj._0006(_0005._0005());
		return obj;
	}

	[_0003_2000(2)]
	private bool _0005([_0005_200A_200B(1)] MethodBase _0005, object _0002, ref object _000F, [_0005_200A_200B(new byte[] { 1, 2 })] object[] _0006)
	{
		Type declaringType = _0005.DeclaringType;
		if (declaringType == null)
		{
			return false;
		}
		if (global::_0005_2004._0005(declaringType))
		{
			string name = _0005.Name;
			if (name.Equals(_000F_0019._0005(-1057761282), StringComparison.Ordinal))
			{
				_000F = _0002 != null;
			}
			else if (name.Equals(_000F_0019._0005(-1057761299), StringComparison.Ordinal))
			{
				if (_0002 == null)
				{
					return ((bool?)null).Value;
				}
				_000F = _0002;
			}
			else if (name.Equals(_000F_0019._0005(-1057761507), StringComparison.Ordinal))
			{
				switch (_0006.Length)
				{
				case 0:
					_000F = _0002;
					break;
				case 1:
					if (_0002 != null)
					{
						_000F = _0002;
					}
					else
					{
						_000F = _0006[0];
					}
					break;
				default:
					return false;
				}
			}
			else
			{
				if (_0002 != null || _0005.IsStatic)
				{
					return false;
				}
				_000F = null;
			}
			return true;
		}
		if (declaringType == global::_000F_2001.m__000E_2009)
		{
			string name2 = _0005.Name;
			if (name2.Equals(_000F_0019._0005(-1057761483), StringComparison.Ordinal))
			{
				_000F = global::_0005_2004._0003;
				return true;
			}
			if (this.m__0005_2001 != null && name2.Equals(_000F_0019._0005(-1057761496), StringComparison.Ordinal))
			{
				object[] array = this.m__0005_2001;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] is Assembly assembly)
					{
						_000F = assembly;
						return true;
					}
				}
			}
		}
		else if (declaringType == global::_000F_2001.m__0002_2008)
		{
			if (_0005.Name.Equals(_000F_0019._0005(-1057761471), StringComparison.Ordinal))
			{
				if (this.m__0005_2001 != null)
				{
					object[] array = this.m__0005_2001;
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i] is MethodBase methodBase)
						{
							_000F = methodBase;
							return true;
						}
					}
				}
				_000F = MethodBase.GetCurrentMethod();
				return true;
			}
		}
		else if (declaringType.IsArray && declaringType.GetArrayRank() >= 2)
		{
			return this._0002(_0005, _0002, ref _000F, _0006);
		}
		return false;
	}

	private static void _000F_200B_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0003(((_0002_2009_200B)_0002)._0005());
	}

	private void _0005(int _0005)
	{
		global::_000F obj = _0002();
		if (obj is global::_0005_2009)
		{
			this.m__0006_200A[_0005] = obj;
		}
		else
		{
			this.m__0006_200A[_0005]._000F_2001_2004_2001_0005(obj);
		}
	}

	private static void _0002_2005_200B(_000F_2001 _0005, global::_000F _0002)
	{
		throw new NotSupportedException(_000F_0019._0005(-1057763089));
	}

	private long _0005()
	{
		return this.m__000E._0005()._0008_2001_2004_2001_0002() + this.m__0002_2009;
	}

	private void _0002_2009()
	{
		this.m__0006 = this.m__0002_200A;
		int key = this.m__000E._0008();
		this.m__0002_200A += 4u;
		global::_000F_2001.m__0006_2009.TryGetValue(key, out var value);
		value._0002(this, _0005(this.m__000E, value._0005));
	}

	private static void _0003_2001_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(typeof(byte));
	}

	private static void _000F_2008_2005(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		Type type = _0005._0005(num, _0002: true);
		global::_0005_2009 obj = (global::_0005_2009)_0005._0002();
		if (type.IsValueType)
		{
			object obj2 = _0005._0005(obj)._000F_2001_2004_2001_0005();
			if (global::_0005_2004._0005(type))
			{
				_0008_2008 obj3 = new _0008_2008();
				((global::_000F)obj3)._0005(type);
				_0005._0005(obj, obj3);
				return;
			}
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
			foreach (FieldInfo fieldInfo in fields)
			{
				fieldInfo.SetValue(obj2, global::_000F_2001._0005(fieldInfo.FieldType));
			}
		}
		else
		{
			_0005._0005(obj, new _0008_2008());
		}
	}

	private FieldInfo _0005(int _0005, global::_0005 _0002, ref bool _000F)
	{
		if (_0002._0005() == 0)
		{
			_000F = false;
			return this.m__0008_2001.ResolveField(_0002._0005());
		}
		global::_0003_2009 obj = (global::_0003_2009)_0002._0005();
		Type type = this._0005(obj._0005()._0005(), _0002: false);
		if (type.IsGenericType)
		{
			_000F = false;
		}
		return type.GetField(bindingAttr: global::_000F_2001._0005(obj._0005()), name: obj._0005());
	}

	private static void _000F_2001(_000F_2001 _0005, global::_000F _0002)
	{
		throw new NotSupportedException(_000F_0019._0005(-1057762245));
	}

	private _0003_2009_200B _0005(_0005_2009_200B _0005)
	{
		_0003_2009_200B obj = new _0003_2009_200B();
		obj._0005(this._0005(_0005));
		obj._0005(this._0005(_0005));
		obj._0002(_0005._0008());
		obj._0005(_0005._0005());
		obj._0005(_0005._0008());
		obj._0005(_0005._0005());
		return obj;
	}

	private bool _0005()
	{
		if (this.m__0005_200B == null)
		{
			return this.m__0003.Count != 0;
		}
		return true;
	}

	private static void _0005_2009_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		uint num = obj._0005() switch
		{
			1 => (uint)((global::_0006)obj)._0005(), 
			13 => (uint)((_0003_2003)obj)._0005(), 
			19 => (uint)Convert.ToInt64(obj._000F_2001_2004_2001_0005()), 
			_ => throw new InvalidOperationException(), 
		};
		global::_0006[] array = (global::_0006[])((global::_000F_2009)_0002)._0005();
		if (num < array.Length)
		{
			uint num2 = (uint)array[num]._0005();
			_0005._0005(num2);
		}
	}

	private static void _0008_2008(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		_0005._0005(_0005._0002(obj));
	}

	private static object _0005(MethodBase _0005, object _0002, object[] _000F)
	{
		if (_0005.IsConstructor)
		{
			try
			{
				return Activator.CreateInstance(_0005.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, _000F, null);
			}
			catch (AmbiguousMatchException)
			{
				return ((ConstructorInfo)_0005).Invoke(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, _000F, null);
			}
		}
		return _0005.Invoke(_0002, _000F);
	}

	private static void _0008_2007(_000F_2001 _0005, global::_000F _0002)
	{
		_000F_2006 obj = (_000F_2006)_0005._0002();
		if (double.IsNaN(obj._0005()) || double.IsInfinity(obj._0005()))
		{
			throw new OverflowException(_000F_0019._0005(-1057761399));
		}
		_0005._0005((global::_000F)obj);
	}

	private static void _0005_2001_2005(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		bool flag = (num & int.MinValue) != 0;
		bool flag2 = (num & 0x40000000) != 0;
		num &= 0x3FFFFFFF;
		if (flag)
		{
			_0005._0005(num, null, null, flag2);
			return;
		}
		_0005_2006 obj = (_0005_2006)_0005._0005(num)._0005();
		_0005._0005(obj);
	}

	private global::_000F _0002()
	{
		global::_000F obj = this.m__0005_200B;
		if (obj != null)
		{
			this.m__0005_200B = this.m__0005_2008;
			this.m__0005_2008 = null;
			return obj;
		}
		return this.m__0003.Pop();
	}

	private static void _0002_200B(_000F_2001 _0005, global::_000F _0002)
	{
		int num = ((global::_0006)_0002)._0005();
		Type type = _0005._0005(num, _0002: true);
		global::_000F obj = global::_000F._0005(_0005._0002()._000F_2001_2004_2001_0005(), type);
		obj._0005(type);
		_0005._0005(obj);
	}

	private static void _0003_2006(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		double num = obj._0005() switch
		{
			1 => ((global::_0006)obj)._0005(), 
			13 => ((_0003_2003)obj)._0005(), 
			19 => Convert.ToUInt64(((_0005_0019)obj)._0005()), 
			8 => ((_000F_2006)obj)._0005(), 
			_ => throw new InvalidOperationException(), 
		};
		_000F_2006 obj2 = new _000F_2006();
		obj2._0005(num);
		_0005._0005((global::_000F)obj2);
	}

	private static void _0002_2002_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(2);
	}

	private static void _000F_2009_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0008_2009(_0005: false);
	}

	private void _0005(Type _0005, object _0002, long _000F, Array _0006)
	{
		global::_000F obj = global::_000F._0005(_0002, _0005);
		_0006.SetValue(obj._000F_2001_2004_2001_0005(), _000F);
	}

	private static void _0008_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(typeof(double));
	}

	private static void _0006_2003(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(global::_000F_2001.m__000E_200A);
	}

	public object _0005(Stream _0005, string _0002, object[] _000F, Type[] _0006, Type[] _0008, object[] _0003)
	{
		this.m__0005 = _0005;
		this._0005(_0005, _0002);
		return this._0005(_000F, _0006, _0008, _0003);
	}

	private static bool _0005()
	{
		return false;
	}

	private static void _0003_200A(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		if (_0006(_0005._0002(), obj))
		{
			uint num = ((_0006_200B)_0002)._0005();
			_0005._0005(num);
		}
	}

	private void _000E(bool _0005)
	{
		global::_000F obj = _0002();
		this._0005((global::_000F)new global::_0006(obj._0005() switch
		{
			1 => (int)((!_0005) ? ((byte)((global::_0006)obj)._0005()) : checked((byte)(uint)((global::_0006)obj)._0005())), 
			13 => (!_0005) ? ((byte)((_0003_2003)obj)._0005()) : checked((byte)(ulong)((_0003_2003)obj)._0005()), 
			19 => (!_0005) ? ((byte)Convert.ToUInt64(((_0005_0019)obj)._0005())) : checked((byte)Convert.ToUInt64(((_0005_0019)obj)._0005())), 
			8 => (!_0005) ? ((byte)((_000F_2006)obj)._0005()) : checked((byte)((_000F_2006)obj)._0005()), 
			0 => (IntPtr.Size != 4) ? ((!_0005) ? ((byte)(long)((_000F_2002)obj)._0005()) : checked((byte)(ulong)(long)((_000F_2002)obj)._0005())) : ((!_0005) ? ((byte)(int)((_000F_2002)obj)._0005()) : checked((byte)(int)((_000F_2002)obj)._0005())), 
			20 => (UIntPtr.Size != 4) ? ((!_0005) ? ((byte)(ulong)((_0005_2008)obj)._0005()) : checked((byte)(ulong)((_0005_2008)obj)._0005())) : ((!_0005) ? ((byte)(uint)((_0005_2008)obj)._0005()) : checked((byte)(uint)((_0005_2008)obj)._0005())), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private MethodBase _0005(_0008_2005 _0005)
	{
		Type type = this._0005(_0005._0005()._0005(), _0002: false);
		BindingFlags bindingAttr = global::_000F_2001._0005(_0005._0005());
		Type[] array = null;
		global::_0005[] array2 = _0005._0002();
		if (array2 != null)
		{
			array = new Type[array2.Length];
			for (int i = 0; i < array.Length; i++)
			{
				global::_0005 obj = array2[i];
				if (obj != null)
				{
					array[i] = this._0005(obj._0005(), _0002: true);
				}
			}
		}
		MemberInfo[] member = type.GetMember(_0005._0005(), MemberTypes.Method, bindingAttr);
		MethodInfo methodInfo = null;
		int num = -1;
		MemberInfo[] array3 = member;
		for (int j = 0; j < array3.Length; j++)
		{
			MethodInfo methodInfo2 = (MethodInfo)array3[j];
			if (this._0005(methodInfo2, _0005, array, out var num2) && num2 > num)
			{
				methodInfo = methodInfo2;
				num = num2;
			}
		}
		if (methodInfo == null)
		{
			throw new Exception(string.Format(_000F_0019._0005(-1057763275), type.Name, _0005._0005()));
		}
		return methodInfo.MakeGenericMethod(array);
	}

	private static void _0006_2000_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(_0002);
	}

	private static void _000E_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(8);
	}

	private void _0002(global::_000F _0005)
	{
		int num = ((global::_0006)_0005)._0005();
		MethodBase methodBase = this._0005(num);
		Type declaringType = methodBase.DeclaringType;
		ParameterInfo[] parameters = methodBase.GetParameters();
		int num2 = parameters.Length;
		object[] array = new object[num2];
		Dictionary<int, global::_0005_2009> dictionary = new Dictionary<int, global::_0005_2009>();
		for (int num3 = num2 - 1; num3 >= 0; num3--)
		{
			global::_000F obj = _0002();
			if (obj is global::_0005_2009 obj2)
			{
				dictionary.Add(num3, obj2);
				obj = this._0005(obj2);
			}
			if (obj._0005() != null)
			{
				obj = global::_000F._0005(null, obj._0005())._000F_2001_2004_2001_0005(obj);
			}
			global::_000F obj3 = global::_000F._0005(null, parameters[num3].ParameterType)._000F_2001_2004_2001_0005(obj);
			array[num3] = obj3._000F_2001_2004_2001_0005();
		}
		object obj4;
		try
		{
			obj4 = _0002(methodBase, null, array, _0006: false);
		}
		catch (TargetInvocationException ex)
		{
			Exception ex2 = ex.InnerException ?? ex;
			this._0005((object)ex2);
			return;
		}
		foreach (KeyValuePair<int, global::_0005_2009> item in dictionary)
		{
			this._0005(item.Value, global::_000F._0005(array[item.Key], null));
		}
		this._0005(global::_000F._0005(obj4, declaringType));
	}

	private _0005_2005 _0005(_0005_2009_200B _0005)
	{
		_0005_2005 obj = new _0005_2005();
		obj._0005(_0005._0008());
		obj._0005(_0005._0005());
		return obj;
	}

	private static void _0008_2001(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(typeof(float));
	}

	private static void _0002_2008_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(false);
	}

	private static void _000E_2000_200B(_000F_2001 _0005, global::_000F _0002)
	{
		global::_000F obj = _0005._0002();
		global::_000F obj2 = _0005._0002();
		_0005._0005(_0005._000F(obj2, obj));
	}

	private static global::_000F _0002(global::_000F _0005, global::_000F _0002, bool _000F, bool _0006)
	{
		if (!_0006)
		{
			long num = ((_0003_2003)_0005)._0005();
			long num2 = ((_0003_2003)_0002)._0005();
			long num3 = ((!_000F) ? (num + num2) : checked(num + num2));
			return new _0003_2003(num3);
		}
		ulong num4 = (ulong)((_0003_2003)_0005)._0005();
		ulong num5 = (ulong)((_0003_2003)_0002)._0005();
		ulong num6 = ((!_000F) ? (num4 + num5) : checked(num4 + num5));
		return new _0003_2003((long)num6);
	}

	private global::_000F _0005(global::_000F _0005, global::_000F _0002)
	{
		if (_0005._0005() == 1)
		{
			if (_0002._0005() == 1)
			{
				int num = ((global::_0006)_0005)._0005();
				int num2 = ((global::_0006)_0002)._0005();
				return new global::_0006(num << num2);
			}
			if (_0002._0005() == 19)
			{
				return this._0005(_0005, (global::_000F)new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())));
			}
		}
		if (_0005._0005() == 13)
		{
			if (_0002._0005() == 1)
			{
				long num3 = ((_0003_2003)_0005)._0005();
				int num4 = ((global::_0006)_0002)._0005();
				return new _0003_2003(num3 << num4);
			}
			if (_0002._0005() == 19)
			{
				return this._0005(_0005, (global::_000F)new global::_0006(Convert.ToInt32(_0002._000F_2001_2004_2001_0005())));
			}
		}
		if (_0005._0005() == 19)
		{
			Type underlyingType = Enum.GetUnderlyingType(_0005._000F_2001_2004_2001_0005().GetType());
			if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
			{
				return this._0005((global::_000F)new _0003_2003(Convert.ToInt64(_0005._000F_2001_2004_2001_0005())), _0002);
			}
			return this._0005((global::_000F)new global::_0006(Convert.ToInt32(_0005._000F_2001_2004_2001_0005())), _0002);
		}
		throw new InvalidOperationException();
	}

	private static void _0003_2001_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(typeof(short));
	}

	public void _0005(Stream _0005, string _0002, object[] _000F)
	{
		this._0005(_0005, _0002, _000F);
	}

	private void _0005(MethodBase _0005, bool _0002)
	{
		bool flag = !_0002 && this._0005(_0005);
		if (flag && global::_000F_2001._0003._0005)
		{
			_0005 = global::_000F_2001._0005_2009._0005(this, this.m__000E_2008, _0005, _0002);
		}
		ParameterInfo[] parameters = _0005.GetParameters();
		int num = parameters.Length;
		global::_000F[] array = new global::_000F[num];
		object[] array2 = new object[num];
		_000E_2009 obj = default;
		try
		{
			this._0005(ref obj, _0005, _0002);
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				global::_000F obj2 = (array[num2] = this._0002());
				if (obj2 is global::_0005_2009 obj3)
				{
					obj2 = this._0005(obj3);
				}
				if (obj2._0005() != null)
				{
					obj2 = global::_000F._0005(null, obj2._0005())._000F_2001_2004_2001_0005(obj2);
				}
				global::_000F obj4 = global::_000F._0005(null, parameters[num2].ParameterType)._000F_2001_2004_2001_0005(obj2);
				array2[num2] = obj4._000F_2001_2004_2001_0005();
			}
			global::_000F obj5 = null;
			if (!_0005.IsStatic)
			{
				obj5 = this._0002();
				if (obj5 != null && obj5._0005() != null)
				{
					obj5 = global::_000F._0005(null, obj5._0005())._000F_2001_2004_2001_0005(obj5);
				}
			}
			object obj6 = null;
			object obj7 = null;
			try
			{
				if (_0005.IsConstructor)
				{
					obj6 = Activator.CreateInstance(_0005.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, array2, null);
					if (!(obj5 is global::_0005_2009))
					{
						throw new InvalidOperationException();
					}
					obj7 = obj6;
				}
				else
				{
					if (obj5 != null)
					{
						global::_000F obj8 = obj5;
						if (obj5 is global::_0005_2009 obj9)
						{
							obj8 = this._0005(obj9);
						}
						obj7 = obj8._000F_2001_2004_2001_0005();
					}
					try
					{
						if (!this._0005(_0005, obj7, ref obj6, array2))
						{
							if (_0002 && !_0005.IsStatic && obj7 == null)
							{
								throw new NullReferenceException();
							}
							if (!this._0005(_0005, obj7, array, array2, _0002, ref obj6))
							{
								MethodBase methodBase = _0005;
								object obj10 = obj7;
								if (flag && !global::_000F_2001._0003._0005)
								{
									obj10 = global::_000F_2001._0005_200A._0005(obj7, _0005, out var methodInfo);
									methodBase = methodInfo;
								}
								obj6 = global::_000F_2001._0002(methodBase, obj10, array2, _0002);
							}
						}
					}
					catch (TargetInvocationException ex)
					{
						Exception ex2 = ex.InnerException ?? ex;
						this._0005((object)ex2);
					}
				}
			}
			finally
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] is global::_0005_2009 obj11)
					{
						object obj12 = array2[i];
						this._0005(obj11, global::_000F._0005(obj12, null));
					}
				}
				if (obj7 != null && obj5 is global::_0005_2009 obj13)
				{
					bool flag2 = true;
					if (obj13 is _000E_2000 obj14)
					{
						flag2 = this._0005(obj14);
					}
					if (flag2)
					{
						this._0005(obj13, global::_000F._0005(obj7, _0005.DeclaringType));
					}
				}
			}
			MethodInfo methodInfo2 = _0005 as MethodInfo;
			if (methodInfo2 != null)
			{
				Type returnType = methodInfo2.ReturnType;
				if (returnType != global::_000F_2001.m__0003_2009)
				{
					this._0005(global::_000F._0005(obj6, returnType));
				}
			}
		}
		finally
		{
			this._0005(ref obj);
		}
	}

	[_0003_2000(2)]
	private bool _0002([_0005_200A_200B(1)] MethodBase _0005, object _0002, ref object _000F, [_0005_200A_200B(new byte[] { 1, 2 })] object[] _0006)
	{
		if (!_0005.IsStatic && _0002 != null && _0005.Name.Equals(_000F_0019._0005(-1057761700), StringComparison.Ordinal) && _0005 is MethodInfo { ReturnType: var returnType } && returnType.IsByRef)
		{
			Type elementType = returnType.GetElementType();
			int num = _0006.Length;
			if (num >= 1 && _0006[0] is int)
			{
				int[] array = new int[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = (int)_0006[i];
				}
				_0002_2000 obj = new _0002_2000();
				obj._0005((Array)_0002);
				obj._0005(array);
				obj._0005(elementType);
				_000F = obj;
				return true;
			}
		}
		return false;
	}

	private static void _000E_2007(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0008_2009(_0005: true);
	}

	private static void _0002_2006_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(3);
	}

	private static bool _0005(MethodBase _0005)
	{
		ParameterInfo[] parameters = _0005.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			if (parameters[i].ParameterType.IsByRef)
			{
				return true;
			}
		}
		return false;
	}

	private static void _0008_2006_200B(_000F_2001 _0005, global::_000F _0002)
	{
		throw new NotSupportedException(_000F_0019._0005(-1057762559));
	}

	private void _000E_2009(bool _0005)
	{
		global::_000F obj = _0002();
		global::_000F obj2 = _0002();
		this._0005(this._0005(obj2, obj, _0005));
	}

	private static void _0003_2009(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(typeof(long));
	}

	private static void _0008_2004(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._000F(_0005: true, _0002: true);
	}

	private bool _0005(MethodBase _0005)
	{
		if (!_0005.IsVirtual)
		{
			return false;
		}
		if (this._0005(this.m__000E_2008._0005(), _0002: true).IsSubclassOf(_0005.DeclaringType))
		{
			return true;
		}
		return false;
	}

	private static void _0005_2000(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0008(((_0002_2009_200B)_0002)._0005());
	}

	private static void _0005_2002_200B(_000F_2001 _0005, global::_000F _0002)
	{
		uint num = ((_0006_200B)_0002)._0005();
		_0005._0005(null, num);
	}

	private static void _0002_2001_2005(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0002(typeof(short));
	}

	private static void _0005_2006_200B(_000F_2001 _0005, global::_000F _0002)
	{
		_0005._0005(global::_000F_2001.m__000E_200A);
	}

	private static global::_000F _0005(global::_000F _0005, global::_000F _0002, bool _000F)
	{
		if (!_000F)
		{
			long num = ((_0003_2003)_0005)._0005();
			long num2 = ((_0003_2003)_0002)._0005();
			return new _0003_2003(num % num2);
		}
		long num3 = ((_0003_2003)_0005)._0005();
		ulong num4 = (ulong)((_0003_2003)_0002)._0005();
		return new _0003_2003((long)((ulong)num3 % num4));
	}

	private void _0005(bool _0005, bool _0002)
	{
		global::_000F obj = this._0002();
		global::_000F obj2 = this._0002();
		this._0005(global::_000F_2001._0005(obj2, obj, _0005, _0002));
	}

	private void _0002()
	{
		if (this.m__000E_2008._0005())
		{
			Type type = _0005(this.m__000E_2008._0005(), _0002: false);
			if (type != null)
			{
				RuntimeHelpers.RunClassConstructor(type.TypeHandle);
			}
		}
	}
}
internal sealed class _000F_2002 : _000F
{
	private new IntPtr m__0005;

	public _000F_2002()
		: base(0)
	{
	}

	public new IntPtr _0005()
	{
		return this.m__0005;
	}

	public void _0005(IntPtr _0005)
	{
		this.m__0005 = _0005;
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_000F_2002 obj = new _000F_2002();
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
		this._0005((IntPtr)_0005);
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		switch (_0005._0005())
		{
		case 0:
			this._0005(((_000F_2002)_0005)._0005());
			break;
		case 12:
			this._0005((IntPtr)((_0002_2009_200B)_0005)._0005());
			break;
		case 26:
			this._0005((IntPtr)((_000E_2001)_0005)._0005());
			break;
		case 1:
			this._0005((IntPtr)((_0006)_0005)._0005());
			break;
		case 17:
			this._0005((IntPtr)((_0003_200B)_0005)._0005());
			break;
		case 16:
			this._0005((IntPtr)((_0008_200A)_0005)._0005());
			break;
		case 3:
			this._0005((IntPtr)((_0006_200B)_0005)._0005());
			break;
		case 13:
			this._0005((IntPtr)((_0003_2003)_0005)._0005());
			break;
		case 14:
			this._0005((IntPtr)(long)((_000E_2005)_0005)._0005());
			break;
		case 7:
			this._0005((IntPtr)((_0008_2008)_0005)._0005());
			break;
		case 22:
			this._0005((IntPtr)(long)((_0006_2000)_0005)._0005());
			break;
		case 19:
			this._0005(new IntPtr(Convert.ToInt64(((_0005_0019)_0005)._0005())));
			break;
		case 8:
			this._0005((IntPtr)(long)((_000F_2006)_0005)._0005());
			break;
		case 21:
		{
			_0006_2009_200B obj = (_0006_2009_200B)_0005;
			this._0005(obj._0005());
			break;
		}
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal sealed class _000F_2003 : _0008
{
	private readonly int m__0005;

	private readonly Stream _0002;

	public _000F_2003(Stream _0005, int _0002)
	{
		this._0002 = _0005;
		this.m__0005 = _0002 ^ -559030707;
	}

	public Stream _0005()
	{
		return _0002;
	}

	[SpecialName]
	public override bool _0008_2001_2004_2001_0005()
	{
		return _0005().CanRead;
	}

	[SpecialName]
	public override bool _0008_2001_2004_2001_000F()
	{
		return _0005().CanSeek;
	}

	[SpecialName]
	public override bool _0008_2001_2004_2001_0002()
	{
		return _0005().CanWrite;
	}

	public override void _0008_2001_2004_2001_0002()
	{
		_0005().Flush();
	}

	[SpecialName]
	public override long _0008_2001_2004_2001_0005()
	{
		return _0005().Length;
	}

	[SpecialName]
	public override long _0008_2001_2004_2001_0002()
	{
		return _0005().Position;
	}

	[SpecialName]
	public override void _0008_2001_2004_2001_0005(long _0005)
	{
		this._0005().Position = _0005;
	}

	private byte _0005(byte _0005, uint _0002)
	{
		byte b = (byte)((uint)this.m__0005 ^ _0002);
		return (byte)(_0005 ^ b);
	}

	public override void _0008_2001_2004_2001_0005(byte[] _0005, int _0002, int _000F)
	{
		uint num = (uint)((_0008)this)._0008_2001_2004_2001_0002();
		byte[] array = new byte[_000F];
		for (uint num2 = 0u; num2 < _000F; num2++)
		{
			array[num2] = this._0005(_0005[num2 + _0002], num + num2);
		}
		this._0005().Write(array, 0, _000F);
	}

	public override int _0008_2001_2004_2001_0005(byte[] _0005, int _0002, int _000F)
	{
		uint num = (uint)((_0008)this)._0008_2001_2004_2001_0002();
		int num2 = this._0005().Read(_0005, _0002, _000F);
		int num3 = _0002 + num2;
		for (int i = _0002; i < num3; i++)
		{
			_0005[i] = this._0005(_0005[i], num++);
		}
		return num2;
	}

	public override long _0008_2001_2004_2001_0005(long _0005, int _0002)
	{
		SeekOrigin origin = _0002 switch
		{
			0 => SeekOrigin.Begin, 
			1 => SeekOrigin.Current, 
			2 => SeekOrigin.End, 
			_ => throw new ArgumentException(), 
		};
		return this._0005().Seek(_0005, origin);
	}

	public override void _0008_2001_2004_2001_0002(long _0005)
	{
		this._0005().SetLength(_0005);
	}
}
internal sealed class _000F_2004 : _0008_2009
{
	private string m__0005;

	public string _0005()
	{
		return this.m__0005;
	}

	public void _0005(string _0005)
	{
		this.m__0005 = _0005;
	}

	[SpecialName]
	public override byte _0008_2009_2001_2004_2001_0005()
	{
		return 4;
	}
}
[_000F_2005]
internal sealed class _000F_2005 : Attribute
{
}
internal sealed class _000F_2006 : _000F
{
	private new double m__0005;

	public _000F_2006()
		: base(8)
	{
	}

	public new double _0005()
	{
		return this.m__0005;
	}

	public void _0005(double _0005)
	{
		this.m__0005 = _0005;
	}

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		return _0005();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		this._0005(Convert.ToDouble(_0005));
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_000F_2006 obj = new _000F_2006();
		obj._0005(this.m__0005);
		obj._0005(base._0005());
		return obj;
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		switch (_0005._0005())
		{
		case 8:
			this._0005(((_000F_2006)_0005)._0005());
			break;
		case 22:
			this._0005(((_0006_2000)_0005)._0005());
			break;
		case 12:
			this._0005((int)((_0002_2009_200B)_0005)._0005());
			break;
		case 26:
			this._0005(((_000E_2001)_0005)._0005());
			break;
		case 1:
			this._0005(((_0006)_0005)._0005());
			break;
		case 13:
			this._0005(((_0003_2003)_0005)._0005());
			break;
		case 17:
			this._0005(((_0003_200B)_0005)._0005());
			break;
		case 16:
			this._0005((int)((_0008_200A)_0005)._0005());
			break;
		case 3:
			this._0005(((_0006_200B)_0005)._0005());
			break;
		case 14:
			this._0005(((_000E_2005)_0005)._0005());
			break;
		case 7:
			this._0005((double)((_0008_2008)_0005)._0005());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal sealed class _000F_2007
{
	private static readonly int[] m__0005;

	public static readonly _000F_2007 _0002;

	public static readonly _000F_2007 _000F;

	private static readonly byte[] m__0006;

	private int[] _0008;

	private int _0003;

	private int _000E = -1;

	private int _0005_2009;

	static _000F_2007()
	{
		_000F_2007.m__0005 = new int[0];
		_000F_2007.m__0006 = new byte[256]
		{
			0, 1, 2, 2, 3, 3, 3, 3, 4, 4,
			4, 4, 4, 4, 4, 4, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 6, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8
		};
		_000F_2007._0002 = new _000F_2007(0, _000F_2007.m__0005, _000F: false);
		_000F_2007._0002._000E = 0;
		_000F_2007._000F = _0005(1uL);
	}

	public _000F_2007(int _0005, int[] _0002, bool _000F)
	{
		if (_000F)
		{
			int i;
			for (i = 0; i < _0002.Length && _0002[i] == 0; i++)
			{
			}
			if (i == _0002.Length)
			{
				_0003 = 0;
				_0008 = _000F_2007.m__0005;
				return;
			}
			_0003 = _0005;
			if (i == 0)
			{
				_0008 = _0002;
				return;
			}
			_0008 = new int[_0002.Length - i];
			Array.Copy(_0002, i, _0008, 0, _0008.Length);
		}
		else
		{
			_0003 = _0005;
			_0008 = _0002;
		}
	}

	public _000F_2007(int _0005, byte[] _0002)
		: this(_0005, _0002, 0, _0002.Length)
	{
	}

	public _000F_2007(int _0005, byte[] _0002, int _000F, int _0006)
	{
		if (_0005 == 0)
		{
			_0003 = 0;
			_0008 = _000F_2007.m__0005;
		}
		else
		{
			_0008 = _000F_2007._0005(_0002, _000F, _0006);
			_0003 = ((_0008.Length >= 1) ? _0005 : 0);
		}
	}

	public int[] _0005()
	{
		return _0008;
	}

	private static int _0005(int _0005)
	{
		return (_0005 + 8 - 1) / 8;
	}

	private static int[] _0005(byte[] _0005, int _0002, int _000F)
	{
		int num = _0002 + _000F;
		int i;
		for (i = _0002; i < num && _0005[i] == 0; i++)
		{
		}
		if (i >= num)
		{
			return _000F_2007.m__0005;
		}
		int num2 = (num - i + 3) / 4;
		int num3 = (num - i) % 4;
		if (num3 == 0)
		{
			num3 = 4;
		}
		if (num2 < 1)
		{
			return _000F_2007.m__0005;
		}
		int[] array = new int[num2];
		int num4 = 0;
		int num5 = 0;
		for (int j = i; j < num; j++)
		{
			num4 <<= 8;
			num4 |= _0005[j] & 0xFF;
			num3--;
			if (num3 <= 0)
			{
				array[num5] = num4;
				num5++;
				num3 = 4;
				num4 = 0;
			}
		}
		if (num5 < array.Length)
		{
			array[num5] = num4;
		}
		return array;
	}

	private static int _0005(int _0005, int _0002, int[] _000F)
	{
		while (true)
		{
			if (_0002 >= _000F.Length)
			{
				return 0;
			}
			if (_000F[_0002] != 0)
			{
				break;
			}
			_0002++;
		}
		int num = 32 * (_000F.Length - _0002 - 1);
		int num2 = _000F[_0002];
		return num + _000F_2007._0002(num2);
	}

	public int _0005()
	{
		if (_000E == -1)
		{
			_000E = ((_0003 != 0) ? _0005(_0003, 0, _0008) : 0);
		}
		return _000E;
	}

	private static int _0002(int _0005)
	{
		uint num = (uint)_0005 >> 24;
		if (num != 0)
		{
			return 24 + _000F_2007.m__0006[num];
		}
		num = (uint)_0005 >> 16;
		if (num != 0)
		{
			return 16 + _000F_2007.m__0006[num];
		}
		num = (uint)_0005 >> 8;
		if (num != 0)
		{
			return 8 + _000F_2007.m__0006[num];
		}
		return _000F_2007.m__0006[_0005];
	}

	public int _0005(object _0005)
	{
		return this._0005((_000F_2007)_0005);
	}

	private static int _0005(int _0005, int[] _0002, int _000F, int[] _0006)
	{
		while (_0005 != _0002.Length && _0002[_0005] == 0)
		{
			_0005++;
		}
		while (_000F != _0006.Length && _0006[_000F] == 0)
		{
			_000F++;
		}
		return _000F_2007._0002(_0005, _0002, _000F, _0006);
	}

	private static int _0002(int _0005, int[] _0002, int _000F, int[] _0006)
	{
		int num = _0002.Length - _0006.Length - (_0005 - _000F);
		if (num != 0)
		{
			if (num >= 0)
			{
				return 1;
			}
			return -1;
		}
		while (_0005 < _0002.Length)
		{
			uint num2 = (uint)_0002[_0005++];
			uint num3 = (uint)_0006[_000F++];
			if (num2 != num3)
			{
				if (num2 >= num3)
				{
					return 1;
				}
				return -1;
			}
		}
		return 0;
	}

	public int _0005(_000F_2007 _0005)
	{
		if (_0003 >= _0005._0003)
		{
			if (_0003 <= _0005._0003)
			{
				if (_0003 != 0)
				{
					return _0003 * _0002(0, _0008, 0, _0005._0008);
				}
				return 0;
			}
			return 1;
		}
		return -1;
	}

	public override bool Equals(object _0005)
	{
		if (_0005 == this)
		{
			return true;
		}
		if (!(_0005 is _000F_2007 obj))
		{
			return false;
		}
		if (_0003 == obj._0003)
		{
			return this._0005(obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		int num = _0008.Length;
		if (_0008.Length != 0)
		{
			num ^= _0008[0];
			if (_0008.Length > 1)
			{
				num ^= _0008[_0008.Length - 1];
			}
		}
		return num;
	}

	private bool _0005(_000F_2007 _0005)
	{
		_ = _0005._0008;
		if (_0008.Length != _0005._0008.Length)
		{
			return false;
		}
		for (int i = 0; i < _0008.Length; i++)
		{
			if (_0008[i] != _0005._0008[i])
			{
				return false;
			}
		}
		return true;
	}

	public _000F_2007 _0005(_000F_2007 _0005, _000F_2007 _0002)
	{
		if (_0002.Equals(_000F_2007._000F))
		{
			return _000F_2007._0002;
		}
		if (_0005._0003 == 0)
		{
			return _000F_2007._000F;
		}
		if (_0003 == 0)
		{
			return _000F_2007._0002;
		}
		_000F_2007 obj = this;
		if (!_0005.Equals(_000F_2007._000F))
		{
			obj = _000F_2007._0005(obj, _0005._0008[0], _0002);
		}
		return obj;
	}

	private static _000F_2007 _0005(_000F_2007 _0005, int _0002, _000F_2007 _000F)
	{
		int num = _000F._0008.Length;
		int num2 = 32 * num;
		bool flag = _000F._0005() + 2 <= num2;
		uint num3 = (uint)_000F._0002();
		_0005 = _0005._0005(num2)._0005(_000F);
		int[] array = new int[num + 1];
		int[] array2 = _0005._0008;
		if (array2.Length < num)
		{
			int[] array3 = new int[num];
			Buffer.BlockCopy(array2, 0, array3, num - array2.Length, array2.Length * 4);
			array2 = array3;
		}
		int[] array4 = _000F_2007._0005(array2);
		_000F_2007._0005(array, array4, _000F._0008, num3, flag);
		int[] array5 = _000F_2007._0005(_0002);
		int num4 = array5[0];
		int num5 = num4 >> 8;
		num5--;
		int num6 = 1;
		while ((num4 = array5[num6++]) != -1)
		{
			int num7 = num5 + 1;
			for (int i = 0; i < num7; i++)
			{
				_000F_2007._0005(array, array4, _000F._0008, num3, flag);
			}
			_000F_2007._0005(array, array4, array2, _000F._0008, num3, flag);
			num5 = num4 >> 8;
		}
		for (int j = 0; j < num5; j++)
		{
			_000F_2007._0005(array, array4, _000F._0008, num3, flag);
		}
		_000F_2007._0005(array4, _000F._0008, num3);
		return new _000F_2007(1, array4, _000F: true);
	}

	private static int _000F(int _0005)
	{
		int num = _0005 + (((_0005 + 1) & 4) << 1);
		num *= 2 - _0005 * num;
		num *= 2 - _0005 * num;
		return num * (2 - _0005 * num);
	}

	private int _0002()
	{
		if (_0005_2009 != 0)
		{
			return _0005_2009;
		}
		int num = -_0008[_0008.Length - 1];
		return _0005_2009 = _000F(num);
	}

	private static void _0005(int[] _0005, int[] _0002, uint _000F)
	{
		int num = _0002.Length;
		for (int num2 = num - 1; num2 >= 0; num2--)
		{
			uint num3 = (uint)_0005[num - 1];
			ulong num4 = num3 * _000F;
			ulong num5 = num4 * (uint)_0002[num - 1] + num3;
			num5 >>= 32;
			for (int num6 = num - 2; num6 >= 0; num6--)
			{
				num5 += num4 * (uint)_0002[num6] + (uint)_0005[num6];
				_0005[num6 + 1] = (int)num5;
				num5 >>= 32;
			}
			_0005[0] = (int)num5;
		}
		if (_000F_2007._0005(0, _0005, 0, _0002) >= 0)
		{
			_000F_2007._0005(0, _0005, 0, _0002);
		}
	}

	private static void _0005(int[] _0005, int[] _0002, int[] _000F, int[] _0006, uint _0008, bool _0003)
	{
		int num = _0006.Length;
		if (num == 1)
		{
			_0002[0] = (int)_000F_2007._0005((uint)_0002[0], (uint)_000F[0], (uint)_0006[0], _0008);
			return;
		}
		uint num2 = (uint)_000F[num - 1];
		ulong num3 = (uint)_0002[num - 1];
		ulong num4 = num3 * num2;
		ulong num5 = (uint)(int)num4 * _0008;
		ulong num6 = num5 * (uint)_0006[num - 1];
		num4 += (uint)num6;
		num4 = (num4 >> 32) + (num6 >> 32);
		for (int num7 = num - 2; num7 >= 0; num7--)
		{
			ulong num8 = num3 * (uint)_000F[num7];
			num6 = num5 * (uint)_0006[num7];
			num4 += (num8 & 0xFFFFFFFFu) + (uint)num6;
			_0005[num7 + 2] = (int)num4;
			num4 = (num4 >> 32) + (num8 >> 32) + (num6 >> 32);
		}
		_0005[1] = (int)num4;
		int num9 = (int)(num4 >> 32);
		for (int num10 = num - 2; num10 >= 0; num10--)
		{
			uint num11 = (uint)_0005[num];
			ulong num12 = (uint)_0002[num10];
			ulong num13 = num12 * num2;
			ulong num14 = (num13 & 0xFFFFFFFFu) + num11;
			ulong num15 = (uint)(int)num14 * _0008;
			ulong num16 = num15 * (uint)_0006[num - 1];
			num14 += (uint)num16;
			num14 = (num14 >> 32) + (num13 >> 32) + (num16 >> 32);
			for (int num17 = num - 2; num17 >= 0; num17--)
			{
				num13 = num12 * (uint)_000F[num17];
				num16 = num15 * (uint)_0006[num17];
				num14 += (num13 & 0xFFFFFFFFu) + (uint)num16 + (uint)_0005[num17 + 1];
				_0005[num17 + 2] = (int)num14;
				num14 = (num14 >> 32) + (num13 >> 32) + (num16 >> 32);
			}
			num14 += (uint)num9;
			_0005[1] = (int)num14;
			num9 = (int)(num14 >> 32);
		}
		_0005[0] = num9;
		if (!_0003 && _000F_2007._0005(0, _0005, 0, _0006) >= 0)
		{
			_000F_2007._0005(0, _0005, 0, _0006);
		}
		Array.Copy(_0005, 1, _0002, 0, num);
	}

	private static void _0005(int[] _0005, int[] _0002, int[] _000F, uint _0006, bool _0008)
	{
		int num = _000F.Length;
		if (num == 1)
		{
			uint num2 = (uint)_0002[0];
			_0002[0] = (int)_000F_2007._0005(num2, num2, (uint)_000F[0], _0006);
			return;
		}
		ulong num3 = (uint)_0002[num - 1];
		ulong num4 = num3 * num3;
		ulong num5 = (uint)(int)num4 * _0006;
		ulong num6 = num5 * (uint)_000F[num - 1];
		num4 += (uint)num6;
		num4 = (num4 >> 32) + (num6 >> 32);
		for (int num7 = num - 2; num7 >= 0; num7--)
		{
			ulong num8 = num3 * (uint)_0002[num7];
			num6 = num5 * (uint)_000F[num7];
			num4 += (num6 & 0xFFFFFFFFu) + (uint)((int)num8 << 1);
			_0005[num7 + 2] = (int)num4;
			num4 = (num4 >> 32) + (num8 >> 31) + (num6 >> 32);
		}
		_0005[1] = (int)num4;
		int num9 = (int)(num4 >> 32);
		for (int num10 = num - 2; num10 >= 0; num10--)
		{
			uint num11 = (uint)_0005[num];
			ulong num12 = num11 * _0006;
			ulong num13 = num12 * (uint)_000F[num - 1] + num11;
			num13 >>= 32;
			for (int num14 = num - 2; num14 > num10; num14--)
			{
				num13 += num12 * (uint)_000F[num14] + (uint)_0005[num14 + 1];
				_0005[num14 + 2] = (int)num13;
				num13 >>= 32;
			}
			ulong num15 = (uint)_0002[num10];
			ulong num16 = num15 * num15;
			ulong num17 = num12 * (uint)_000F[num10];
			num13 += (num16 & 0xFFFFFFFFu) + (uint)num17 + (uint)_0005[num10 + 1];
			_0005[num10 + 2] = (int)num13;
			num13 = (num13 >> 32) + (num16 >> 32) + (num17 >> 32);
			for (int num18 = num10 - 1; num18 >= 0; num18--)
			{
				ulong num19 = num15 * (uint)_0002[num18];
				ulong num20 = num12 * (uint)_000F[num18];
				num13 += (num20 & 0xFFFFFFFFu) + (uint)((int)num19 << 1) + (uint)_0005[num18 + 1];
				_0005[num18 + 2] = (int)num13;
				num13 = (num13 >> 32) + (num19 >> 31) + (num20 >> 32);
			}
			num13 += (uint)num9;
			_0005[1] = (int)num13;
			num9 = (int)(num13 >> 32);
		}
		_0005[0] = num9;
		if (!_0008 && _000F_2007._0005(0, _0005, 0, _000F) >= 0)
		{
			_000F_2007._0005(0, _0005, 0, _000F);
		}
		Array.Copy(_0005, 1, _0002, 0, num);
	}

	private static uint _0005(uint _0005, uint _0002, uint _000F, uint _0006)
	{
		ulong num = (ulong)_0005 * (ulong)_0002;
		uint num2 = (uint)(int)num * _0006;
		ulong num3 = _000F;
		ulong num4 = num3 * num2;
		num += (uint)num4;
		num = (num >> 32) + (num4 >> 32);
		if (num > num3)
		{
			num -= num3;
		}
		return (uint)num;
	}

	private static int[] _0005(int _0005)
	{
		int num = _0002(_0005);
		int[] array = new int[num + 2];
		int num2 = 0;
		int i = 33 - num;
		_0005 <<= i;
		int num3 = 0;
		for (; i < 32; i++)
		{
			if (_0005 < 0)
			{
				array[num2++] = 1 | (num3 << 8);
				num3 = 0;
			}
			else
			{
				num3++;
			}
			_0005 <<= 1;
		}
		array[num2++] = 1 | (num3 << 8);
		array[num2] = -1;
		return array;
	}

	private static int[] _0005(int[] _0005, int _0002)
	{
		int num = _0002 >>> 5;
		int num2 = _0002 & 0x1F;
		int num3 = _0005.Length;
		int[] array;
		if (num2 == 0)
		{
			array = new int[num3 + num];
			_0005.CopyTo(array, 0);
		}
		else
		{
			int num4 = 0;
			int num5 = 32 - num2;
			int num6 = _0005[0] >>> num5;
			if (num6 != 0)
			{
				array = new int[num3 + num + 1];
				array[num4++] = num6;
			}
			else
			{
				array = new int[num3 + num];
			}
			int num7 = _0005[0];
			for (int i = 0; i < num3 - 1; i++)
			{
				int num8 = _0005[i + 1];
				array[num4++] = (num7 << num2) | (num8 >>> num5);
				num7 = num8;
			}
			array[num4] = _0005[num3 - 1] << num2;
		}
		return array;
	}

	private _000F_2007 _0005(int _0005)
	{
		if (_0003 == 0 || _0008.Length == 0)
		{
			return _000F_2007._0002;
		}
		if (_0005 == 0)
		{
			return this;
		}
		_000F_2007 obj = new _000F_2007(_0003, _000F_2007._0005(_0008, _0005), _000F: true);
		if (_000E != -1)
		{
			obj._000E = _000E + _0005;
		}
		return obj;
	}

	private static void _0005(int _0005, int[] _0002, int _000F)
	{
		int num = (_000F >>> 5) + _0005;
		int num2 = _000F & 0x1F;
		int num3 = _0002.Length - 1;
		if (num != _0005)
		{
			int num4 = num - _0005;
			for (int num5 = num3; num5 >= num; num5--)
			{
				_0002[num5] = _0002[num5 - num4];
			}
			for (int num6 = num - 1; num6 >= _0005; num6--)
			{
				_0002[num6] = 0;
			}
		}
		if (num2 != 0)
		{
			int num7 = 32 - num2;
			int num8 = _0002[num3];
			for (int num9 = num3; num9 > num; num9--)
			{
				int num10 = _0002[num9 - 1];
				_0002[num9] = (num8 >>> num2) | (num10 << num7);
				num8 = num10;
			}
			_0002[num] >>>= num2;
		}
	}

	private static void _0005(int _0005, int[] _0002)
	{
		int num = _0002.Length;
		int num2 = _0002[num - 1];
		while (--num > _0005)
		{
			int num3 = _0002[num - 1];
			_0002[num] = (num2 >>> 1) | (num3 << 31);
			num2 = num3;
		}
		_0002[_0005] >>>= 1;
	}

	public int _000F()
	{
		return _0003;
	}

	private static int[] _0005(int _0005, int[] _0002, int _000F, int[] _0006)
	{
		int num = _0002.Length;
		int num2 = _0006.Length;
		int num3 = 0;
		do
		{
			long num4 = (_0002[--num] & 0xFFFFFFFFu) - (_0006[--num2] & 0xFFFFFFFFu) + num3;
			_0002[num] = (int)num4;
			num3 = (int)(num4 >> 63);
		}
		while (num2 > _000F);
		if (num3 != 0)
		{
			while (--_0002[--num] == -1)
			{
			}
		}
		return _0002;
	}

	public byte[] _0005()
	{
		if (_0003 == 0)
		{
			return new byte[0];
		}
		byte[] array = new byte[_0005(this._0005())];
		_0005(array, 0);
		return array;
	}

	public int _0006()
	{
		return _0005((byte[])null, 0);
	}

	public int _0005(byte[] _0005, int _0002)
	{
		if (_0003 == 0)
		{
			return 0;
		}
		int num = _000F_2007._0005(this._0005());
		if (_0005 == null)
		{
			return num;
		}
		int num2 = _0008.Length;
		int num3 = _0002 + num;
		if (num3 > _0005.Length)
		{
			throw new IndexOutOfRangeException();
		}
		while (num2 > 1)
		{
			uint num4 = (uint)_0008[--num2];
			_0005[--num3] = (byte)num4;
			_0005[--num3] = (byte)(num4 >> 8);
			_0005[--num3] = (byte)(num4 >> 16);
			_0005[--num3] = (byte)(num4 >> 24);
		}
		uint num5;
		for (num5 = (uint)_0008[0]; num5 > 255; num5 >>= 8)
		{
			_0005[--num3] = (byte)num5;
		}
		_0005[--num3] = (byte)num5;
		return num;
	}

	private static _000F_2007 _0005(ulong _0005)
	{
		int num = (int)(_0005 >> 32);
		int num2 = (int)_0005;
		if (num != 0)
		{
			return new _000F_2007(1, new int[2] { num, num2 }, _000F: false);
		}
		if (num2 != 0)
		{
			return new _000F_2007(1, new int[1] { num2 }, _000F: false);
		}
		return _000F_2007._0002;
	}

	public static _000F_2007 _0002(ulong _0005)
	{
		return _000F_2007._0005(_0005);
	}

	private static int[] _0005(int[] _0005, int[] _0002)
	{
		int i;
		for (i = 0; i < _0005.Length && _0005[i] == 0; i++)
		{
		}
		int j;
		for (j = 0; j < _0002.Length && _0002[j] == 0; j++)
		{
		}
		int num = _000F_2007._0002(i, _0005, j, _0002);
		if (num > 0)
		{
			int num2 = _000F_2007._0005(1, j, _0002);
			int num3 = _000F_2007._0005(1, i, _0005);
			int num4 = num3 - num2;
			int k = 0;
			int num5 = num2;
			int[] array;
			if (num4 > 0)
			{
				array = _000F_2007._0005(_0002, num4);
				num5 += num4;
			}
			else
			{
				int num6 = _0002.Length - j;
				array = new int[num6];
				Array.Copy(_0002, j, array, 0, num6);
			}
			while (true)
			{
				if (num5 < num3 || _000F_2007._0002(i, _0005, k, array) >= 0)
				{
					_000F_2007._0005(i, _0005, k, array);
					while (_0005[i] == 0)
					{
						if (++i == _0005.Length)
						{
							return _0005;
						}
					}
					num3 = 32 * (_0005.Length - i - 1) + _000F_2007._0002(_0005[i]);
					if (num3 <= num2)
					{
						if (num3 < num2)
						{
							return _0005;
						}
						num = _000F_2007._0002(i, _0005, j, _0002);
						if (num <= 0)
						{
							break;
						}
					}
				}
				num4 = num5 - num3;
				if (num4 == 1)
				{
					int num7 = array[k] >>> 1;
					uint num8 = (uint)_0005[i];
					if ((uint)num7 > num8)
					{
						num4++;
					}
				}
				if (num4 < 2)
				{
					_000F_2007._0005(k, array);
					num5--;
				}
				else
				{
					_000F_2007._0005(k, array, num4);
					num5 -= num4;
				}
				for (; array[k] == 0; k++)
				{
				}
			}
		}
		if (num == 0)
		{
			Array.Clear(_0005, i, _0005.Length - i);
		}
		return _0005;
	}

	private _000F_2007 _0005(_000F_2007 _0005)
	{
		if (_0003 == 0)
		{
			return _000F_2007._0002;
		}
		if (_0002(0, _0008, 0, _0005._0008) < 0)
		{
			return this;
		}
		int[] array = (int[])_0008.Clone();
		array = _000F_2007._0005(array, _0005._0008);
		return new _000F_2007(_0003, array, _000F: true);
	}

	private static int[] _0005(int[] _0005)
	{
		int[] array = new int[_0005.Length];
		Buffer.BlockCopy(_0005, 0, array, 0, _0005.Length * 4);
		return array;
	}
}
internal sealed class _000F_2008 : Stream
{
	private bool m__0005;

	private Stream _0002;

	private _0005_200B[] _000F;

	private _000F_2009_200B _0006;

	private _0008_2000 _0008;

	private _0006_2006 _0003;

	private bool _000E;

	private byte[] _0005_2009;

	private int _0002_2009;

	private int _000F_2009;

	public override bool CanRead => true;

	public override bool CanSeek => true;

	public override bool CanWrite => false;

	public override long Length => _0002.Length;

	public override long Position
	{
		get
		{
			return _0002.Position + (_0002_2009 - _000F_2009);
		}
		set
		{
			Seek(value, SeekOrigin.Begin);
		}
	}

	public _000F_2008(Stream _0005, _000F_2009_200B _0002 = null, _0008_2000 _000F = null, bool _0006 = false)
	{
		this._0002 = _0005;
		this.m__0005 = _0006;
		_0008 = _000F;
		this._0006 = _0002;
		if (this._0006 == null)
		{
			this._0006 = _000F_2009_200B._0005();
		}
		if (this._0006._0002() == 0)
		{
			throw new ArgumentException(_000F_0019._0005(-1057761842));
		}
		if (this._0006._000F() == 0)
		{
			throw new ArgumentException(_000F_0019._0005(-1057761842));
		}
		if (!this._0002.CanRead)
		{
			throw new ArgumentException(_000F_0019._0005(-1057761793));
		}
		if (!this._0002.CanSeek)
		{
			throw new ArgumentException(_000F_0019._0005(-1057761793));
		}
	}

	private void _0005()
	{
		if (!_000E)
		{
			_000F = new _0005_200B[_0006._0002()];
			for (int i = 0; i < _0006._0002(); i++)
			{
				_000F[i] = new _0005_200B();
			}
			if (_0008 != null)
			{
				_0003 = _0008._0005(_0006);
			}
			_000E = true;
		}
	}

	protected override void Dispose(bool _0005)
	{
		try
		{
			if (_0005 && !this.m__0005)
			{
				_0002.Close();
			}
		}
		finally
		{
			base.Dispose(_0005);
		}
	}

	public override void SetLength(long _0005)
	{
		throw new NotSupportedException();
	}

	public override void Write(byte[] _0005, int _0002, int _000F)
	{
		throw new NotSupportedException();
	}

	public override void Flush()
	{
	}

	private int _0005(byte[] _0005, int _0002, int _000F)
	{
		int num = _000F_2009 - _0002_2009;
		if (num <= 0)
		{
			return 0;
		}
		if (num > _000F)
		{
			num = _000F;
		}
		Buffer.BlockCopy(_0005_2009, _0002_2009, _0005, _0002, num);
		_0002_2009 += num;
		return num;
	}

	private void _0005(int _0005)
	{
		int num = (int)_0002.Position;
		if (num >= _0002.Length)
		{
			return;
		}
		int num2 = num + _0005;
		_0005_200B[] array = _000F;
		foreach (_0005_200B obj in array)
		{
			if (obj._0002 <= num && obj._000F >= num2)
			{
				_0005_2009 = obj._0005;
				_000F_2009 = obj._000F - obj._0002;
				_0002_2009 = num - obj._0002;
				_0002.Position = obj._000F;
				obj._0006 = DateTime.UtcNow;
				return;
			}
		}
		int num3 = 0;
		DateTime dateTime = _000F[0]._0006;
		for (int j = 1; j < _000F.Length; j++)
		{
			if (_000F[j]._0006 < dateTime)
			{
				num3 = j;
			}
		}
		_0005_200B obj2 = _000F[num3];
		if (obj2._0005 == null)
		{
			obj2._0005 = new byte[_0006._0005()];
		}
		int num4 = num;
		num = this._0005(num);
		if (num < 0)
		{
			num = 0;
		}
		num2 = num + _0006._0005();
		if (_0003 == null || !_0003._0005(num, ref obj2))
		{
			obj2._0002 = num;
			obj2._0006 = DateTime.UtcNow;
			_0005_2009 = obj2._0005;
			_0002.Position = num;
			_000F_2009 = _0002.Read(_0005_2009, 0, num2 - num);
			_0002_2009 = num4 - num;
			obj2._000F = num + _000F_2009;
			if (_0003 != null)
			{
				_0003._0005(obj2);
			}
		}
		else
		{
			_0005_2009 = obj2._0005;
			_000F_2009 = obj2._000F - num;
			_0002.Position = obj2._000F;
			_0002_2009 = num4 - num;
		}
	}

	private int _0005(int _0005)
	{
		return _0005 - _0005 % _0006._0005();
	}

	public override int Read(byte[] _0005, int _0002, int _000F)
	{
		if (_0005 == null)
		{
			throw new ArgumentNullException(_000F_0019._0005(-1057761824));
		}
		if (_0002 < 0)
		{
			throw new ArgumentOutOfRangeException(_000F_0019._0005(-1057762025));
		}
		if (_000F < 0)
		{
			throw new ArgumentOutOfRangeException(_000F_0019._0005(-1057762022));
		}
		if (_0005.Length - _0002 < _000F)
		{
			throw new ArgumentException();
		}
		int num = _0002;
		int num2 = this._0005(_0005, _0002, _000F);
		if (num2 == _000F)
		{
			return num2;
		}
		int num3 = num2;
		if (num2 > 0)
		{
			_000F -= num2;
			_0002 += num2;
		}
		_0002_2009 = (_000F_2009 = 0);
		this._0005();
		if (_000F >= _0006._0005())
		{
			if (_0003 == null)
			{
				return this._0002.Read(_0005, _0002, _000F) + num3;
			}
			int num4 = (int)this._0002.Position - num3;
			if (_0003._0005(num4, _0005, num, _000F + num3, out var num5))
			{
				this._0002.Seek(num5 - num3, SeekOrigin.Current);
				return num5;
			}
			num5 = this._0002.Read(_0005, _0002, _000F);
			if (num5 != 0)
			{
				_0003._0005(num4, _0005, num, num5 + num3, num5 < _000F);
			}
			return num5 + num3;
		}
		this._0005(_000F);
		num2 = this._0005(_0005, _0002, _000F);
		return num2 + num3;
	}

	public override long Seek(long _0005, SeekOrigin _0002)
	{
		if (_000F_2009 - _0002_2009 > 0 && _0002 == SeekOrigin.Current)
		{
			_0005 -= _000F_2009 - _0002_2009;
		}
		long position = Position;
		long num = this._0002.Seek(_0005, _0002);
		_0002_2009 = (int)(num - (position - _0002_2009));
		if (0 <= _0002_2009 && _0002_2009 < _000F_2009)
		{
			this._0002.Seek(_000F_2009 - _0002_2009, SeekOrigin.Current);
		}
		else
		{
			_0002_2009 = (_000F_2009 = 0);
		}
		return num;
	}
}
internal sealed class _000F_2009 : _000F
{
	private new Array m__0005;

	public _000F_2009()
		: base(9)
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

	[SpecialName]
	public override object _000F_2001_2004_2001_0005()
	{
		return _0005();
	}

	[SpecialName]
	public override void _000F_2001_2004_2001_0005(object _0005)
	{
		this._0005((Array)_0005);
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_000F_2009 obj = new _000F_2009();
		obj._0005(this.m__0005);
		obj._0005(base._0005());
		return obj;
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		switch (_0005._0005())
		{
		case 9:
			this._0005(((_000F_2009)_0005)._0005());
			break;
		case 7:
			this._0005((Array)((_0008_2008)_0005)._0005());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal sealed class _000F_200A
{
	[Conditional("DEBUG")]
	public static void _0005(string _0005)
	{
	}
}
