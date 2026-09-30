using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

internal sealed class _0002_0019 : Form
{
	private sealed class _0002
	{
		public string _0005;

		internal IEnumerable<string> _0005(string _0005)
		{
			return Directory.GetFiles(this._0005, _0005, SearchOption.AllDirectories);
		}
	}

	private delegate void _0002_2009(object _0005, EventArgs _0002);

	private sealed class _0003
	{
		public string _0005;

		public _0002_0019 _0002;

		public string _000F;

		public string _0006;

		public bool _0008;

		internal void _0005()
		{
			this._0005 = this._0002._0003_2008.Items[this._0002._0003_2008.SelectedIndex].ToString().Trim();
		}

		internal void _0002()
		{
			this._0002._0008_2008.Style = ProgressBarStyle.Blocks;
		}

		internal void _000F()
		{
			this._0002._0008_2008.Value = 100;
		}
	}

	[Serializable]
	private sealed class _0005
	{
		public static readonly _0005 _0005;

		public static Func<string, char> _0002;

		public static Func<_0008_2001_200B, string> _000F;

		static _0005()
		{
			_0002_0019._0005._0005 = new _0005();
		}

		internal char _0005(string _0005)
		{
			return _0005[_000E_200A.Next(_0005.Length)];
		}

		internal string _0005(_0008_2001_200B _0005)
		{
			return string.Format(_000F_0019._0005(-1057759320), _0005._0005(), _0005._0005(), _0005._0002(), _0005._0005().Ticks, _0005._0002().Ticks);
		}
	}

	internal enum _0005_0019 : long
	{

	}

	private sealed class _0005_2009
	{
		public int _0005;

		public _000E _0002;

		internal void _0005()
		{
			_0002._000F._0002._0006_2008.Text = string.Format(_000F_0019._0005(-1057759666), this._0005 + 1, _0002._0002);
			_0002._000F._0002._0008_2008.Value = (100 * this._0005 + 1) / _0002._0002;
		}
	}

	private sealed class _0006
	{
		public _0002_0019 _0005;

		public bool _0002;

		internal void _0005()
		{
			this._0005._0002_2002.Enabled = _0002;
			this._0005._0005_2001.Enabled = _0002;
			this._0005._0006_2001.Enabled = _0002;
			this._0005._0006_200B.Enabled = _0002;
			this._0005._0008_200B.Enabled = _0002;
			this._0005._0003_200B.Enabled = _0002;
			this._0005._000E_200B.Enabled = _0002;
			this._0005._0005_2002.Enabled = _0002;
			this._0005._000E_2001.Enabled = _0002;
			this._0005._0003_2001.Enabled = _0002;
			this._0005._0003_2008.Enabled = _0002;
			this._0005._0002_2001.Enabled = _0002;
			this._0005._000F_200B.Enabled = _0002;
			this._0005._0002_200B.Text = (_0002 ? _000F_0019._0005(-1057759376) : _000F_0019._0005(-1057759411));
			this._0005._0002_200B.ForeColor = (_0002 ? Color.DarkBlue : Color.Red);
			this._0005._0002_200B.Click -= (_0002 ? new EventHandler(this._0005._0008) : new EventHandler(this._0005._000F));
			this._0005._0002_200B.Click += (_0002 ? new EventHandler(this._0005._000F) : new EventHandler(this._0005._0008));
			this._0005._0005_200B.Visible = _0002;
			this._0005._0006_2008.Text = ((!_0002) ? _000F_0019._0005(-1057759388) : string.Empty);
			this._0005._0006_2008.Visible = !_0002;
			this._0005._0008_2008.Value = 0;
			this._0005._0008_2008.Style = ProgressBarStyle.Marquee;
			this._0005._0008_2008.Visible = !_0002;
		}
	}

	private sealed class _0008
	{
		public string[] _0005;

		public int _0002;

		public Func<string, IEnumerable<string>> _000F;

		internal IEnumerable<string> _0005(string _0005)
		{
			return Directory.GetFiles(this._0005[_0002], _0005, SearchOption.AllDirectories);
		}
	}

	private sealed class _000E
	{
		public string _0005;

		public int _0002;

		public _0003 _000F;

		internal void _0005()
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = false;
			folderBrowserDialog.Description = _000F_0019._0005(-1057759599);
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				this._0005 = folderBrowserDialog.SelectedPath + string.Format(_000F_0019._0005(-1057759535), _000F._000F, _000F._0006);
				if (!Directory.Exists(this._0005))
				{
					this._0005 = folderBrowserDialog.SelectedPath + _000F_0019._0005(-1057759496);
				}
				if (!Directory.Exists(this._0005))
				{
					_000F._0008 = true;
					_000F._0002.Invoke(new _0002_2009(_000F._0002._0008), null, null);
					MessageBox.Show(_000F_0019._0005(-1057759717), _000F_0019._0005(-1057759649), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				_000F._0008 = true;
				_000F._0002.Invoke(new _0002_2009(_000F._0002._0008), null, null);
			}
		}
	}

	private sealed class _000F
	{
		public _0002_0019 _0005;

		public string _0002;

		internal void _0005()
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = this._0005.m__000E;
			saveFileDialog.Title = _000F_0019._0005(-1057759282);
			saveFileDialog.CheckFileExists = false;
			saveFileDialog.CheckPathExists = true;
			saveFileDialog.DefaultExt = _000F_0019._0005(-1057759478);
			saveFileDialog.Filter = _000F_0019._0005(-1057759437);
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.FileName = _000F_0019._0005(-1057759447);
			saveFileDialog.RestoreDirectory = true;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				_0002 = saveFileDialog.FileName;
			}
			else
			{
				this._0005.m__0008_2009 = false;
			}
		}
	}

	private bool m__0005;

	private Thread m__0002;

	private int m__000F;

	private int m__0006;

	private Version m__0008;

	private string[] m__0003;

	private string m__000E;

	private string m__0005_2009;

	private string[] m__0002_2009;

	private List<string> m__000F_2009;

	private int m__0006_2009;

	private bool m__0008_2009;

	private byte[] m__0003_2009;

	private byte[] _000E_2009;

	private byte[] _0005_200A;

	private string _0002_200A;

	private string _000F_200A;

	private string _0006_200A;

	private string _0008_200A;

	private static readonly char[] _0003_200A;

	private static Random _000E_200A;

	private string _0005_2008;

	private IContainer _0002_2008;

	private GroupBox _000F_2008;

	private Label _0006_2008;

	private ProgressBar _0008_2008;

	private ComboBox _0003_2008;

	private Label _000E_2008;

	private Button _0005_2001;

	private TextBox _0002_2001;

	private Label _000F_2001;

	private Button _0006_2001;

	private Label _0008_2001;

	private NumericUpDown _0003_2001;

	private NumericUpDown _000E_2001;

	private LinkLabel _0005_200B;

	private Button _0002_200B;

	private CheckBox _000F_200B;

	private LinkLabel _0006_200B;

	private CheckBox _0008_200B;

	private CheckBox _0003_200B;

	private CheckBox _000E_200B;

	private CheckBox _0005_2002;

	private GroupBox _0002_2002;

	private Button _000F_2002;

	private Button _0006_2002;

	private TextBox _0008_2002;

	private Button _0003_2002;

	private CheckBox _000E_2002;

	private Button _0005_2004;

	private RadioButton _0002_2004;

	private RadioButton _000F_2004;

	internal _0002_0019()
	{
		_002Ector_1(ref this.m__0005, ref this.m__000F, ref this.m__0006, ref this.m__0008, ref this.m__0003, ref this.m__000E, ref this.m__0005_2009, ref this.m__000F_2009, ref this.m__0008_2009, ref this.m__0003_2009, ref _000E_2009, ref _0005_200A, ref _0002_200A, ref _000F_200A, ref _0006_200A, ref _0008_200A, ref _0005_2008);
		base._002Ector();
		_002Ector_2();
	}

	static _0002_0019()
	{
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "!8#cNe'cY;", (object[])null);
	}

	private bool _0005(string _0005)
	{
		object[] array = new object[2] { this, _0005 };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "@+WrYe'cY=", array);
	}

	private string _0005(string _0005, int _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "H.UTre'cY?", array);
	}

	private string _0005()
	{
		object[] array = new object[1] { this };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "Yh.FTe'cY@", array);
	}

	private string _0002()
	{
		object[] array = new object[1] { this };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "&(f@]e'cY@", array);
	}

	private string _0005(string _0005)
	{
		object[] array = new object[2] { this, _0005 };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "0@n\\'e'cY5", array);
	}

	private void _0005(object _0005, EventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "5M\"B7e'cX)", array);
	}

	private void _0005(object _0005, KeyPressEventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "h:C-+e'cX>", array);
	}

	private void _0002(object _0005, EventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "rRTNKe'cXS", array);
	}

	private bool _0005()
	{
		object[] array = new object[1] { this };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "Ct@.de'cW5", array);
	}

	private string _000F()
	{
		object[] array = new object[1] { this };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "WRfVLe'cY\"", array);
	}

	private void _0005()
	{
		object[] array = new object[1] { this };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "l.4D7e'cVF", array);
	}

	private bool _0005(bool _0005, bool _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "iRZQ/e'cY:", array);
	}

	private bool _0002()
	{
		object[] array = new object[1] { this };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "_q*Afe'cW8", array);
	}

	private string _0006()
	{
		object[] array = new object[1] { this };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "A_,D]e'cX_", array);
	}

	private string _0002(string _0005)
	{
		object[] array = new object[2] { this, _0005 };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "Q.FL8e'cX.", array);
	}

	private string _000F(string _0005)
	{
		object[] array = new object[2] { this, _0005 };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), ">h7HTe'cX9", array);
	}

	private string _0005(_0006_2001_200B _0005)
	{
		object[] array = new object[2] { this, _0005 };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "f%/C$e'cX0", array);
	}

	private static string _0005(string _0005, char[] _0002)
	{
		object[] array = new object[2] { _0005, _0002 };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "ak#\"le'cWr", array);
	}

	private static string _0005(string _0005)
	{
		object[] array = new object[1] { _0005 };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "imuZ0e'cX$", array);
	}

	private string _0005(string _0005, Func<string, string> _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "pX[mEe'cXR", array);
	}

	private byte[] _0005(string _0005)
	{
		object[] array = new object[2] { this, _0005 };
		return (byte[])_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "He-`se'cXW", array);
	}

	private string _0006(string _0005)
	{
		object[] array = new object[2] { this, _0005 };
		return (string)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "51\\96e'cWs", array);
	}

	private bool _000F()
	{
		object[] array = new object[1] { this };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "<S#^Me'cXo", array);
	}

	private bool _0006()
	{
		object[] array = new object[1] { this };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "iRZQ/e'cX[", array);
	}

	private bool _0005(string _0005, bool _0002, string _000F, bool _0006)
	{
		object[] array = new object[5] { this, _0005, _0002, _000F, _0006 };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "1=k\"*e'cXI", array);
	}

	private void _0005(bool _0005)
	{
		object[] array = new object[2] { this, _0005 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "\"4l#Pe'cXs", array);
	}

	private bool _0008()
	{
		object[] array = new object[1] { this };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "!7o]Me'cX`", array);
	}

	private void _000F(object _0005, EventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "rmoWLe'cX<", array);
	}

	private void _0006(object _0005, EventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "jOVl2e'cW4", array);
	}

	private void _0008(object _0005, EventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "+P,)me'cW6", array);
	}

	private void _0005(string[] _0005, bool _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "f[eU&e'cXe", array);
	}

	private void _0005(object _0005)
	{
		object[] array = new object[2] { this, _0005 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), ":\"IkEe'cY&", array);
	}

	private void _0005(string _0005, bool _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), ">h7HTe'cX4", array);
	}

	private void _0005(string _0005)
	{
		object[] array = new object[2] { this, _0005 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "o%)@@e'cWs", array);
	}

	private void _0002()
	{
		object[] array = new object[1] { this };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "[FWmXe'cVI", array);
	}

	private void _0003(object _0005, EventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "@FiuYe'cXZ", array);
	}

	private void _000E(object _0005, EventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "pt\"!Fe'cX`", array);
	}

	private void _0005_2009(object _0005, EventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "g=Fg(e'cY7", array);
	}

	private void _0002_2009(object _0005, EventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "%+`tYe'cX.", array);
	}

	private void _000F()
	{
		object[] array = new object[1] { this };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "kgn;6e'cVL", array);
	}

	private void _0005(object _0005, LinkLabelLinkClickedEventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "f%/C$e'cX%", array);
	}

	private void _0005(object _0005, MouseEventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "+kG2ne'cXR", array);
	}

	private void _0006()
	{
		object[] array = new object[1] { this };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "*S/cje'cVL", array);
	}

	private int _0005(byte[] _0005, byte[] _0002, int _000F, int _0006)
	{
		object[] array = new object[5] { this, _0005, _0002, _000F, _0006 };
		return (int)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "[FWmXe'cXX", array);
	}

	private void _000F_2009(object _0005, EventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "Rb$$=e'cWp", array);
	}

	private void _0006_2009(object _0005, EventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "O4Mk2e'cX\"", array);
	}

	private void _0008_2009(object _0005, EventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "e(3(!e'cXO", array);
	}

	private bool _0005(string _0005, bool _0002, bool _000F, bool _0006)
	{
		object[] array = new object[5] { this, _0005, _0002, _000F, _0006 };
		return (bool)_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "+P,)me'cWM", array);
	}

	private void _0003_2009(object _0005, EventArgs _0002)
	{
		object[] array = new object[3] { this, _0005, _0002 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "mafq<e'cXU", array);
	}

	protected override void Dispose(bool _0005)
	{
		object[] array = new object[2] { this, _0005 };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "9\\.bDe'cX]", array);
	}

	private void _0008()
	{
		object[] array = new object[1] { this };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "g=Fg(e'cVn", array);
	}

	private static void _002Ector_1(ref bool P_0, ref int P_1, ref int P_2, ref Version P_3, ref string[] P_4, ref string P_5, ref string P_6, ref List<string> P_7, ref bool P_8, ref byte[] P_9, ref byte[] P_10, ref byte[] P_11, ref string P_12, ref string P_13, ref string P_14, ref string P_15, ref string P_16)
	{
		object[] array = new object[17]
		{
			P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7, P_8, P_9,
			P_10, P_11, P_12, P_13, P_14, P_15, P_16
		};
		_000F_2001 obj = _0003_200B_200B._0006_2002_200B();
		Stream stream = _0003_200B_200B._0002_2002_200B();
		try
		{
			obj._0005(stream, "1Y1++e'cV`", array);
		}
		finally
		{
			P_0 = (bool)array[0];
			P_1 = (int)array[1];
			P_2 = (int)array[2];
			P_3 = (Version)array[3];
			P_4 = (string[])array[4];
			P_5 = (string)array[5];
			P_6 = (string)array[6];
			P_7 = (List<string>)array[7];
			P_8 = (bool)array[8];
			P_9 = (byte[])array[9];
			P_10 = (byte[])array[10];
			P_11 = (byte[])array[11];
			P_12 = (string)array[12];
			P_13 = (string)array[13];
			P_14 = (string)array[14];
			P_15 = (string)array[15];
			P_16 = (string)array[16];
		}
	}

	private void _002Ector_2()
	{
		object[] array = new object[1] { this };
		_0003_200B_200B._0006_2002_200B()._0005(_0003_200B_200B._0002_2002_200B(), "!nPoOe'cVE", array);
	}
}
internal sealed class _0002_200B : SymmetricAlgorithm
{
	private sealed class _0002 : ICryptoTransform, IDisposable
	{
		private readonly byte[] m__0005;

		private readonly byte[] m__0002;

		private readonly SymmetricAlgorithm[] _000F;

		private ICryptoTransform[] _0006;

		private readonly bool _0008;

		private readonly int _0003;

		public int InputBlockSize => _0003;

		public int OutputBlockSize => _0003;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => true;

		public _0002(SymmetricAlgorithm[] _0005, byte[] _0002, byte[] _000F, bool _0006)
		{
			this.m__0005 = _0002;
			this.m__0002 = _000F;
			this._000F = _0005;
			_0008 = _0006;
			_0003 = _0005[_0005.Length - 1].BlockSize / 8;
		}

		public void Dispose()
		{
			if (_0006 != null)
			{
				ICryptoTransform[] array = _0006;
				for (int i = 0; i < array.Length; i++)
				{
					array[i]?.Dispose();
				}
				_0006 = null;
			}
		}

		private void _0005()
		{
			SymmetricAlgorithm[] array = _000F;
			int num = array.Length;
			if (_0006 == null)
			{
				ICryptoTransform[] array2 = new ICryptoTransform[num];
				int num2 = 0;
				for (int i = 0; i < num; i++)
				{
					SymmetricAlgorithm symmetricAlgorithm = array[i];
					int num3 = symmetricAlgorithm.KeySize / 8;
					byte[] array3 = new byte[num3];
					Buffer.BlockCopy(this.m__0005, num2, array3, 0, num3);
					num2 += num3;
					byte[] rgbIV = new byte[symmetricAlgorithm.BlockSize / 8];
					ICryptoTransform cryptoTransform = (_0008 ? symmetricAlgorithm.CreateEncryptor(array3, rgbIV) : symmetricAlgorithm.CreateDecryptor(array3, rgbIV));
					array2[i] = cryptoTransform;
				}
				_0006 = array2;
			}
		}

		public byte[] TransformFinalBlock(byte[] _0005, int _0002, int _000F)
		{
			byte[] array = new byte[_000F];
			TransformBlock(_0005, _0002, _000F, array, 0);
			return array;
		}

		public int TransformBlock(byte[] _0005, int _0002, int _000F, byte[] _0006, int _0008)
		{
			Buffer.BlockCopy(_0005, _0002, _0006, _0008, _000F);
			this._0005();
			if (this._0008)
			{
				this._0005(_0006, _0008, _000F);
			}
			else
			{
				this._0002(_0006, _0008, _000F);
			}
			return _000F;
		}

		private void _0005(byte[] _0005, int _0002, int _000F)
		{
			byte[] array = new byte[this.m__0002.Length];
			Buffer.BlockCopy(this.m__0002, 0, array, 0, array.Length);
			int num = 0;
			ICryptoTransform[] array2 = _0006;
			foreach (ICryptoTransform cryptoTransform in array2)
			{
				int inputBlockSize = cryptoTransform.InputBlockSize;
				int num2 = (_000F - num) & ~(inputBlockSize - 1);
				int num3 = num + num2;
				for (int j = num; j < num3; j += inputBlockSize)
				{
					int num4 = j + _0002;
					_0002_200B._0002._0005(_0005, num4, array, 0, inputBlockSize);
					cryptoTransform.TransformBlock(_0005, num4, inputBlockSize, _0005, num4);
					Buffer.BlockCopy(_0005, num4, array, 0, inputBlockSize);
				}
				num = num3;
				if (num3 == _000F)
				{
					break;
				}
			}
		}

		private void _0002(byte[] _0005, int _0002, int _000F)
		{
			byte[] array = new byte[this.m__0002.Length];
			Buffer.BlockCopy(this.m__0002, 0, array, 0, array.Length);
			byte[] array2 = new byte[array.Length];
			int num = 0;
			ICryptoTransform[] array3 = _0006;
			foreach (ICryptoTransform cryptoTransform in array3)
			{
				int inputBlockSize = cryptoTransform.InputBlockSize;
				int num2 = (_000F - num) & ~(inputBlockSize - 1);
				int num3 = num + num2;
				for (int j = num; j < num3; j += inputBlockSize)
				{
					int num4 = j + _0002;
					Buffer.BlockCopy(_0005, num4, array2, 0, inputBlockSize);
					cryptoTransform.TransformBlock(_0005, num4, inputBlockSize, _0005, num4);
					_0002_200B._0002._0005(_0005, num4, array, 0, inputBlockSize);
					Buffer.BlockCopy(array2, 0, array, 0, inputBlockSize);
				}
				num = num3;
				if (num3 == _000F)
				{
					break;
				}
			}
		}

		private static void _0005(byte[] _0005, int _0002, byte[] _000F, int _0006, int _0008)
		{
			for (int i = 0; i < _0008; i++)
			{
				_0005[_0002 + i] ^= _000F[_0006 + i];
			}
		}
	}

	[Serializable]
	private sealed class _0005
	{
		public static readonly _0005 _0005;

		public static Comparison<SymmetricAlgorithm> _0002;

		static _0005()
		{
			_0002_200B._0005._0005 = new _0005();
		}

		internal int _0005(SymmetricAlgorithm _0005, SymmetricAlgorithm _0002)
		{
			return _0002.BlockSize.CompareTo(_0005.BlockSize);
		}
	}

	private readonly SymmetricAlgorithm[] m__0005;

	private readonly int m__0002;

	public override byte[] IV
	{
		get
		{
			return base.IV;
		}
		set
		{
			IVValue = (byte[])value.Clone();
		}
	}

	public _0002_200B(params SymmetricAlgorithm[] _0005)
	{
		_0005 = (SymmetricAlgorithm[])_0005.Clone();
		Array.Sort(_0005, _0002_200B._0005._0005._0005);
		this.m__0005 = _0005;
		int num = 0;
		SymmetricAlgorithm[] array = _0005;
		foreach (SymmetricAlgorithm symmetricAlgorithm in array)
		{
			num += symmetricAlgorithm.KeySize;
			symmetricAlgorithm.Mode = CipherMode.ECB;
			symmetricAlgorithm.Padding = PaddingMode.None;
		}
		BlockSizeValue = _0005[_0005.Length - 1].BlockSize;
		LegalBlockSizesValue = new KeySizes[1]
		{
			new KeySizes(BlockSizeValue, BlockSizeValue, 0)
		};
		KeySizeValue = num;
		LegalKeySizesValue = new KeySizes[1]
		{
			new KeySizes(num, num, 0)
		};
		this.m__0002 = _0005[0].BlockSize;
		Mode = CipherMode.ECB;
		Padding = PaddingMode.None;
	}

	public int _0005()
	{
		return this.m__0002;
	}

	public override ICryptoTransform CreateDecryptor(byte[] _0005, byte[] _0002)
	{
		return this._0005(_0005, _0002, _000F: false);
	}

	public override ICryptoTransform CreateEncryptor(byte[] _0005, byte[] _0002)
	{
		return this._0005(_0005, _0002, _000F: true);
	}

	private ICryptoTransform _0005(byte[] _0005, byte[] _0002, bool _000F)
	{
		if (_0005.Length * 8 != KeySize)
		{
			throw new ArgumentException(_000F_0019._0005(-1057762741), _000F_0019._0005(-1057762717));
		}
		if (_0002.Length * 8 != this._0005())
		{
			throw new ArgumentException(_000F_0019._0005(-1057759850), _000F_0019._0005(-1057759871));
		}
		return new _0002(this.m__0005, _0005, _0002, _000F);
	}

	public override void GenerateIV()
	{
		throw new NotSupportedException();
	}

	public override void GenerateKey()
	{
		throw new NotSupportedException();
	}
}
internal sealed class _0003_200B : _000F
{
	private new sbyte m__0005;

	public _0003_200B()
		: base(17)
	{
	}

	public new sbyte _0005()
	{
		return this.m__0005;
	}

	public void _0005(sbyte _0005)
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
		if (_0005 is byte)
		{
			this._0005((sbyte)(byte)_0005);
		}
		else if (_0005 is short)
		{
			this._0005((sbyte)(short)_0005);
		}
		else if (_0005 is int)
		{
			this._0005((sbyte)(int)_0005);
		}
		else if (_0005 is long)
		{
			this._0005((sbyte)(long)_0005);
		}
		else if (_0005 is ushort)
		{
			this._0005((sbyte)(ushort)_0005);
		}
		else if (_0005 is uint)
		{
			this._0005((sbyte)(uint)_0005);
		}
		else if (_0005 is ulong)
		{
			this._0005((sbyte)(ulong)_0005);
		}
		else if (_0005 is float)
		{
			this._0005((sbyte)(float)_0005);
		}
		else if (_0005 is double)
		{
			this._0005((sbyte)(double)_0005);
		}
		else
		{
			this._0005(Convert.ToSByte(_0005));
		}
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0003_200B obj = new _0003_200B();
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
			this._0005(Convert.ToSByte(((_0008_2006)_0005)._0005()));
			break;
		case 17:
			this._0005(((_0003_200B)_0005)._0005());
			break;
		case 19:
			this._0005(Convert.ToSByte(((_0005_0019)_0005)._0005()));
			break;
		case 12:
			this._0005((sbyte)((_0002_2009_200B)_0005)._0005());
			break;
		case 26:
			this._0005((sbyte)((_000E_2001)_0005)._0005());
			break;
		case 1:
			this._0005((sbyte)((_0006)_0005)._0005());
			break;
		case 16:
			this._0005((sbyte)((_0008_200A)_0005)._0005());
			break;
		case 3:
			this._0005((sbyte)((_0006_200B)_0005)._0005());
			break;
		case 13:
			this._0005((sbyte)((_0003_2003)_0005)._0005());
			break;
		case 14:
			this._0005((sbyte)((_000E_2005)_0005)._0005());
			break;
		case 7:
			this._0005(Convert.ToSByte(((_0008_2008)_0005)._0005()));
			break;
		case 0:
			this._0005((sbyte)(int)((_000F_2002)_0005)._0005());
			break;
		case 22:
			this._0005((sbyte)((_0006_2000)_0005)._0005());
			break;
		case 8:
			this._0005((sbyte)((_000F_2006)_0005)._0005());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal sealed class _0005_0019 : _000F
{
	private new enum _0005
	{
		Value
	}

	private new Enum m__0005;

	public _0005_0019()
		: base(19)
	{
	}

	public _0005_0019(Enum _0005)
		: this()
	{
		this.m__0005 = (Enum)(_0005 ?? ((object)_0005_0019._0005.Value));
	}

	public new Enum _0005()
	{
		return this.m__0005;
	}

	public void _0005(Enum _0005)
	{
		if (_0005 == null)
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
		this._0005((Enum)Enum.Parse(this._0005().GetType(), _0005.ToString()));
	}

	public override _000F _000F_2001_2004_2001_0005(_000F _0005)
	{
		base._0005(_0005._0005());
		switch (_0005._0005())
		{
		case 19:
		{
			Type type = this.m__0005.GetType();
			Enum obj = ((_0005_0019)_0005)._0005();
			if (obj.GetType() == type)
			{
				this._0005(obj);
			}
			else
			{
				this._0005((Enum)Enum.ToObject(type, obj));
			}
			break;
		}
		case 26:
			this._0005((Enum)Enum.ToObject(this.m__0005.GetType(), ((_000E_2001)_0005)._0005()));
			break;
		case 1:
			this._0005((Enum)Enum.ToObject(this.m__0005.GetType(), ((_0006)_0005)._0005()));
			break;
		case 13:
			this._0005((Enum)Enum.ToObject(this.m__0005.GetType(), ((_0003_2003)_0005)._0005()));
			break;
		case 16:
			this._0005((Enum)Enum.ToObject(this.m__0005.GetType(), ((_0008_200A)_0005)._0005()));
			break;
		case 3:
			this._0005((Enum)Enum.ToObject(this.m__0005.GetType(), ((_0006_200B)_0005)._0005()));
			break;
		case 14:
			this._0005((Enum)Enum.ToObject(this.m__0005.GetType(), ((_000E_2005)_0005)._0005()));
			break;
		case 17:
			this._0005((Enum)Enum.ToObject(this.m__0005.GetType(), ((_0003_200B)_0005)._0005()));
			break;
		case 12:
			this._0005((Enum)Enum.ToObject(this.m__0005.GetType(), ((_0002_2009_200B)_0005)._0005()));
			break;
		case 7:
			this._0005((Enum)Enum.ToObject(this.m__0005.GetType(), ((_0008_2008)_0005)._0005()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0005_0019 obj = new _0005_0019(this.m__0005);
		obj._0005(base._0005());
		return obj;
	}
}
internal sealed class _0005_200B
{
	public byte[] _0005;

	public int _0002;

	public int _000F;

	public DateTime _0006 = DateTime.UtcNow.AddTicks(1L);
}
internal sealed class _0006_200B : _000F
{
	private new uint m__0005;

	public _0006_200B()
		: base(3)
	{
	}

	public new uint _0005()
	{
		return this.m__0005;
	}

	public void _0005(uint _0005)
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
			this._0005((uint)(short)_0005);
		}
		else if (_0005 is int)
		{
			this._0005((uint)(int)_0005);
		}
		else if (_0005 is long)
		{
			this._0005((uint)(long)_0005);
		}
		else if (_0005 is ulong)
		{
			this._0005((uint)(ulong)_0005);
		}
		else if (_0005 is float)
		{
			this._0005((uint)(float)_0005);
		}
		else if (_0005 is double)
		{
			this._0005((uint)(double)_0005);
		}
		else
		{
			this._0005(Convert.ToUInt32(_0005));
		}
	}

	public override _000F _000F_2001_2004_2001_0005()
	{
		_0006_200B obj = new _0006_200B();
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
			this._0005((uint)((_000E_2001)_0005)._0005());
			break;
		case 1:
			this._0005((uint)((_0006)_0005)._0005());
			break;
		case 17:
			this._0005((uint)((_0003_200B)_0005)._0005());
			break;
		case 16:
			this._0005(((_0008_200A)_0005)._0005());
			break;
		case 3:
			this._0005(((_0006_200B)_0005)._0005());
			break;
		case 13:
			this._0005((uint)((_0003_2003)_0005)._0005());
			break;
		case 14:
			this._0005((uint)((_000E_2005)_0005)._0005());
			break;
		case 19:
			this._0005(Convert.ToUInt32(((_0005_0019)_0005)._0005()));
			break;
		case 7:
			this._0005(Convert.ToUInt32(((_0008_2008)_0005)._0005()));
			break;
		case 0:
			this._0005((uint)(int)((_000F_2002)_0005)._0005());
			break;
		case 20:
			this._0005((uint)((_0005_2008)_0005)._0005());
			break;
		case 22:
			this._0005((uint)((_0006_2000)_0005)._0005());
			break;
		case 8:
			this._0005((uint)((_000F_2006)_0005)._0005());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this;
	}
}
internal static class _0008_200B
{
	private static readonly bool m__0005;

	static _0008_200B()
	{
		_0008_200B.m__0005 = _0005();
	}

	private static bool _0005()
	{
		try
		{
			if (Environment.Version.Major < 4)
			{
				return false;
			}
			Assembly assembly = typeof(_000F_2001).Assembly;
			Assembly assembly2 = typeof(SecurityCriticalAttribute).Assembly;
			bool result = false;
			object[] customAttributes = assembly.GetCustomAttributes(inherit: false);
			foreach (object obj in customAttributes)
			{
				if (obj is AllowPartiallyTrustedCallersAttribute)
				{
					result = true;
					continue;
				}
				Type type = obj.GetType();
				if (type.Assembly == assembly2 && _000F_0019._0005(-1057759820).Equals(type.FullName, StringComparison.Ordinal) && (byte)type.GetProperty(_000F_0019._0005(-1057759783)).GetValue(obj, null) != 2)
				{
					return false;
				}
			}
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static bool _0002()
	{
		return _0008_200B.m__0005;
	}
}
internal static class _000E_200B
{
	public static bool _0005(Type _0005, Type _0002, out int _000F)
	{
		_000F = 0;
		if (_0005 == _0002)
		{
			_000F = 1;
			return true;
		}
		if (_0005 == null || _0002 == null)
		{
			return false;
		}
		if (_0005.IsByRef)
		{
			if (!_0002.IsByRef)
			{
				return false;
			}
			return _000E_200B._0005(_0005.GetElementType(), _0002.GetElementType(), out _000F);
		}
		if (_0002.IsByRef)
		{
			return false;
		}
		if (_0005.IsPointer)
		{
			if (!_0002.IsPointer)
			{
				return false;
			}
			return _000E_200B._0005(_0005.GetElementType(), _0002.GetElementType(), out _000F);
		}
		if (_0002.IsPointer)
		{
			return false;
		}
		if (_0005.IsArray)
		{
			if (!_0002.IsArray)
			{
				return false;
			}
			if (_0005.GetArrayRank() != _0002.GetArrayRank())
			{
				return false;
			}
			return _000E_200B._0005(_0005.GetElementType(), _0002.GetElementType(), out _000F);
		}
		if (_0002.IsArray)
		{
			return false;
		}
		if (_0005.IsGenericType != _0002.IsGenericType)
		{
			return false;
		}
		if (_0005.IsGenericType)
		{
			Type type = (_0005.IsGenericTypeDefinition ? _0005 : _0005.GetGenericTypeDefinition());
			Type type2 = (_0002.IsGenericTypeDefinition ? _0002 : _0002.GetGenericTypeDefinition());
			if (type != type2)
			{
				return false;
			}
			Type[] genericArguments = _0005.GetGenericArguments();
			Type[] genericArguments2 = _0002.GetGenericArguments();
			if (genericArguments.Length != genericArguments2.Length)
			{
				return false;
			}
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (_000E_200B._0005(genericArguments[i], genericArguments2[i], out var num))
				{
					_000F += num;
				}
			}
		}
		else if (_0005 != _0002)
		{
			return false;
		}
		_000F++;
		return true;
	}
}
internal static class _000F_0019
{
	private sealed class _0002
	{
		private Stream m__0005;

		private byte[] m__0002;

		public _0002(Stream _0005)
		{
			this.m__0005 = _0005;
			m__0002 = new byte[4];
		}

		public Stream _0005()
		{
			return this.m__0005;
		}

		public short _0005()
		{
			_0005(2);
			return (short)(m__0002[0] | (m__0002[1] << 8));
		}

		public int _0005()
		{
			_0005(4);
			return m__0002[0] | (m__0002[1] << 8) | (m__0002[2] << 16) | (m__0002[3] << 24);
		}

		private static void _0005()
		{
			throw new EndOfStreamException();
		}

		private void _0005(int _0005)
		{
			int num = 0;
			int num2 = 0;
			if (_0005 == 1)
			{
				num2 = this.m__0005.ReadByte();
				if (num2 == -1)
				{
					_000F_0019._0002._0005();
				}
				m__0002[0] = (byte)num2;
				return;
			}
			do
			{
				num2 = this.m__0005.Read(m__0002, num, _0005 - num);
				if (num2 == 0)
				{
					_000F_0019._0002._0005();
				}
				num += num2;
			}
			while (num < _0005);
		}

		public void _0005()
		{
			Stream stream = this.m__0005;
			this.m__0005 = null;
			stream?.Close();
			m__0002 = null;
		}

		public byte[] _0005(int _0005)
		{
			if (_0005 < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[_0005];
			int num = 0;
			do
			{
				int num2 = this.m__0005.Read(array, num, _0005);
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
	}

	private enum _0005
	{

	}

	private static int _0005_2009;

	private static _0005 _0002_2009;

	private static int _0008;

	private static _0002 m__0002;

	private static int _000E;

	private static byte[] _000F;

	private static byte[] _0003;

	private static short _0006;

	private static ConcurrentDictionary<int, string> m__0005;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _000F_0019()
	{
		int num = 1449404152;
		int num2 = -731206812 - num;
		_000F_0019.m__0005 = new ConcurrentDictionary<int, string>();
		int num3 = 2;
		StackTrace stackTrace = new StackTrace(num3, fNeedFileInfo: false);
		num3 -= 2;
		StackFrame frame = stackTrace.GetFrame(num3);
		int num4 = num3;
		if (frame == null)
		{
			stackTrace = new StackTrace();
			num4 = 1;
			frame = stackTrace.GetFrame(num4);
		}
		int num5 = ~(-(-(~(~(-(~(-(~(-(~((num + 952055779) ^ num2))))))))))) ^ ~(-(~(-(-(~(~(-(-(~(~((0x395B3B56 ^ num) + num2)))))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num5 ^= ~(-(-(~(-(~(~(-(-(~(~(350772596 + num - num2)))))))))));
		}
		Type type = methodBase?.DeclaringType;
		if (type == typeof(RuntimeMethodHandle))
		{
			_0002_2009 |= (_0005)4;
			num5 ^= -664951373 - num + num2 + num3;
		}
		else if (type == null)
		{
			if (_0005(stackTrace, num4))
			{
				num5 ^= -(~(-(~(~(-(-(~(~((731185017 + num) ^ num2))))))))) - num3;
				_0002_2009 = (_0005)0x10 | _0002_2009;
			}
			else
			{
				num5 ^= -(~(~(-(-(~(-(~(~(-664989225 - num + num2)))))))));
				_0002_2009 = (_0005)1 | _0002_2009;
			}
		}
		else
		{
			_0002_2009 = (_0005)0x10 | _0002_2009;
			num5 ^= ~(-(-(~(~(-(~(-(~((num ^ 0x2862007D) - num2))))))))) - num3;
		}
		_0005_2009 = num5 + _0005_2009;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string _0005(int _0005)
	{
		if (_000F_0019.m__0005.TryGetValue(_0005, out var value))
		{
			return value;
		}
		return _000F_0019._0005(_0005, _0002: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string _0005(int _0005, bool _0002)
	{
		int num = -2102767;
		int num2 = -1448566933 + num;
		string value = null;
		byte[] array;
		int num20;
		int num21;
		int num22;
		int num23;
		byte[] array4;
		byte[] array3;
		int num24;
		while (true)
		{
			bool lockTaken = false;
			ConcurrentDictionary<int, string> obj = _000F_0019.m__0005;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				int num7;
				if (_000F_0019.m__0002 == null)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					Assembly callingAssembly;
					try
					{
						callingAssembly = Assembly.GetCallingAssembly();
					}
					catch (PlatformNotSupportedException)
					{
						callingAssembly = executingAssembly;
					}
					_0008 |= (num ^ -1454382313) + num2;
					StringBuilder stringBuilder = new StringBuilder();
					int num3 = (-1989241973 - num) ^ num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = (0x364D4395 ^ num) - num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = (-1989962869 - num) ^ num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = num + 1990175868 + num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = (num ^ 0x36504397) - num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = num + 1990372472 + num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = (0x56574394 ^ num) - num2;
					stringBuilder.Append((char)num3);
					Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
					int num4 = 2;
					StackTrace stackTrace = new StackTrace(num4, fNeedFileInfo: false);
					_0008 ^= (1448573403 - num + num2) | num4;
					num4 -= 2;
					StackFrame frame = stackTrace.GetFrame(num4);
					int num5 = num4;
					if (frame == null)
					{
						stackTrace = new StackTrace();
						num5 = 1;
						frame = stackTrace.GetFrame(num5);
					}
					MethodBase methodBase = frame?.GetMethod();
					_0008 ^= num4 + (-1448566805 + num - num2);
					Type type = methodBase?.DeclaringType;
					if (frame == null)
					{
						_0008 ^= (num ^ -1448794842) + num2;
					}
					bool flag = type == typeof(RuntimeMethodHandle);
					_0008 ^= -1452772307 - num - num2;
					if (!flag)
					{
						flag = type == null;
						if (flag)
						{
							if (_000F_0019._0005(stackTrace, num5))
							{
								flag = false;
							}
							else
							{
								_0008 ^= (num ^ -1448794874) + num2;
							}
						}
					}
					if (flag == (stackTrace != null))
					{
						_0008 = 0x20 ^ _0008;
					}
					_0008 ^= ((-1452770773 - num) ^ num2) | (num4 + 1);
					_000F_0019.m__0002 = new _0002(manifestResourceStream);
					short num6 = (short)(_000F_0019.m__0002._0005() ^ (short)(~(-(-(~(~(-(~(-(~(-(~(num + 1452770587 + num2)))))))))))));
					if (num6 == 0)
					{
						_0006 = (short)(_000F_0019.m__0002._0005() ^ (short)(~(-(-(~(~(-(-(~(~(-(~(-1452801126 - num - num2)))))))))))));
					}
					else
					{
						_000F = _000F_0019.m__0002._0005(num6);
					}
					callingAssembly = executingAssembly;
					AssemblyName assemblyName = _000F_0019._0005(callingAssembly);
					_0003 = _000F_0019._0005(assemblyName);
					num7 = _0005_2009;
					_0005_2009 = 0;
					long num8 = _0008_200B_200B._0005();
					num7 ^= (int)num8;
					num7 ^= 0x23D52FA6 ^ num ^ num2;
					int num9 = num7;
					int num10 = 0;
					global::_0008_2008_200B<int> obj2 = null;
					int num11 = 0;
					int num12 = 0;
					int num13 = 0;
					int num14 = 0;
					int num15 = 0;
					num14 = num9;
					num11 = num14 ^ (845740958 - num + num2);
					num15 = 0;
					num13 = num11 * ((0x56577438 ^ num) - num2) % ((-1475367262 - num) ^ num2);
					obj2 = null;
					num12 = num13;
					num15 = (0x565763E0 ^ num) - num2;
					num10 = 0;
					obj2 = ((global::_0002_2008_200B<int>)new _0003_2008_200B._000F((1448566931 - num) | num2)
					{
						_0008 = num12
					}).GetEnumerator();
					try
					{
						while (((_000F_2008_200B)obj2)._000F_2008_200B_2001_2004_2001_0005())
						{
							num10 = obj2._000F_2008_200B_2001_2004_2001_0005();
							num13 ^= num10 - num15;
							num15 -= 3 + num13 >> 8;
						}
					}
					finally
					{
						obj2?._0006_2008_200B_2001_2004_2001_0005();
					}
					int num16 = num13;
					num7 ^= ~(-(~(-(-(~(~(-(~(-2084298698 ^ num ^ num2)))))))));
					num7 = num16 + num7;
					_0008 = (_0008 & (num + 1721207781 + num2)) ^ (0x565779E9 ^ num ^ num2);
					_000E = num7;
					if (((uint)_0002_2009 & (uint)(-(~(-(~(-(~(~(-(~(num + 1452772452 + num2))))))))))) == 0)
					{
						_0008 = (num ^ 0x5656DF27) - num2;
					}
				}
				else
				{
					num7 = _000E;
				}
				if (_0008 == num + 1452816429 + num2)
				{
					value = new string(new char[3]
					{
						(char)(0x56576335 ^ num ^ num2),
						'0',
						(char)(1448567021 - num + num2)
					});
					return value;
				}
				int num17 = _0005 ^ ((-1995815920 ^ num) - num2) ^ num7;
				num17 ^= -963564981 + num + num2;
				_000F_0019.m__0002._0005().Position = num17;
				if (_000F != null)
				{
					array = _000F;
				}
				else
				{
					short num18 = ((_0006 != -1) ? _0006 : ((short)(_000F_0019.m__0002._0005() ^ ((0x5657D222 ^ num) - num2) ^ num17)));
					if (num18 == 0)
					{
						array = null;
					}
					else
					{
						array = _000F_0019.m__0002._0005(num18);
						for (int num19 = 0; num19 != array.Length; num19 = 1 + num19)
						{
							array[num19] ^= (byte)(_000E >> ((3 & num19) << 3));
						}
					}
				}
				num20 = _000F_0019.m__0002._0005() ^ num17 ^ -(~(-(~(~(-(-(~(-(~(~(346448841 - num + num2))))))))))) ^ num7;
				if (num20 == ((num + 1452772465) | num2))
				{
					byte[] array2 = _000F_0019.m__0002._0005(4);
					_0005 = ((num ^ 0x67F79943) + num2) ^ num7;
					_0005 = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -_0005;
					goto IL_0013;
				}
				num21 = -1451164653 - num - num2;
				num22 = _0008;
				num23 = num20;
				num24 = num22 - 12;
				num20 &= (num ^ -1717003118) + num2;
				array3 = _000F_0019.m__0002._0005(num20);
				array4 = _0003;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
			break;
			IL_0013:
			if (_000F_0019.m__0005.TryGetValue(_0005, out value))
			{
				return value;
			}
		}
		bool flag2 = (num23 & (num + -911696021 - num2)) != 0;
		bool flag3 = (num23 & (-698915987 ^ num ^ num2)) != 0;
		bool flag4 = (num23 & (-1768453005 + num + num2)) != 0;
		byte[] array5 = array;
		byte[] array6 = array3;
		byte[] array7 = array5;
		int num25 = 0;
		byte b = 0;
		uint num26 = 0u;
		int num27 = 0;
		ushort num28 = 0;
		byte b2 = 0;
		byte b3 = 0;
		byte b4 = 0;
		b3 = array7[1];
		num27 = array6.Length;
		b2 = (byte)((num27 + 11) ^ (b3 + 7));
		num26 = (uint)((array7[0] | (array7[2] << 8)) + (b2 << 3));
		num25 = 0;
		num28 = 0;
		while (num25 < num27)
		{
			if ((1 & num25) == 0)
			{
				num26 = (uint)((int)num26 * (0x56542090 ^ num ^ num2) + (-1450241456 - num - num2));
				num28 = (ushort)(num26 >> 16);
			}
			b = (byte)num28;
			num28 >>= 8;
			b4 = array6[num25];
			array6[num25] = (byte)(b4 ^ b3 ^ (b2 + 3) ^ b);
			num25 = 1 + num25;
			b2 = b4;
		}
		array3 = array6;
		if (array4 != null != (num22 != num21))
		{
			for (int num29 = 0; num29 < num20; num29 = 1 + num29)
			{
				byte b5 = array4[num29 & 7];
				b5 = (byte)((b5 << 3) | (b5 >> 5));
				array3[num29] ^= b5;
			}
		}
		int num30;
		byte[] array8;
		if (!flag3)
		{
			num30 = num20;
			array8 = array3;
		}
		else
		{
			num30 = array3[2] | (array3[0] << 16) | (array3[3] << 8) | (array3[1] << 24);
			array8 = new byte[num30];
			_000F_0019._0005(array3, 4, array8);
		}
		if (flag2 && num24 == num21 - 12)
		{
			char[] array9 = new char[num30];
			for (int i = 0; i < num30; i++)
			{
				array9[i] = (char)array8[i];
			}
			value = new string(array9);
		}
		else
		{
			char[] array10 = new char[num30 / 2];
			int num31 = 0;
			int num32 = 0;
			while (num31 < num30)
			{
				array10[num32++] = (char)(array8[num31] | (array8[1 + num31] << 8));
				num31 = 2 + num31;
			}
			value = new string(array10);
		}
		num24 += 1452772594 + num + num2 + (3 & num24) << 5;
		if (num24 != num21 - 12 + ((0x56576312 ^ num ^ num2) + ((num21 - 12) & 3) << 5))
		{
			int num33 = (_0005 + num20) ^ (-1451835899 - num - num2) ^ (num24 & (0x56576660 ^ num ^ num2));
			StringBuilder stringBuilder = new StringBuilder();
			int num3 = -1452772379 - num - num2;
			stringBuilder.Append((char)(byte)num3);
			value = num33.ToString(stringBuilder.ToString());
		}
		if (!flag4 & _0002)
		{
			value = string.Intern(value);
			_000F_0019.m__0005[_0005] = value;
		}
		return value;
	}

	private static AssemblyName _0005(Assembly _0005)
	{
		try
		{
			return _0005.GetName();
		}
		catch
		{
			return new AssemblyName(_0005.FullName);
		}
	}

	private static byte[] _0005(AssemblyName _0005)
	{
		byte[] array = _0005.GetPublicKeyToken();
		if (array != null && array.Length == 0)
		{
			array = null;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0005(StackTrace _0005, int _0002)
	{
		Assembly assembly = _0005.GetFrame(++_0002)?.GetMethod()?.DeclaringType?.Assembly;
		if (assembly != null)
		{
			AssemblyName assemblyName = _000F_0019._0005(assembly);
			byte[] array = _000F_0019._0005(assemblyName);
			if (array != null && array.Length == 8 && array[0] == 183 && array[7] == 137)
			{
				return true;
			}
		}
		while (true)
		{
			StackFrame frame = _0005.GetFrame(++_0002);
			if (frame == null)
			{
				break;
			}
			assembly = frame.GetMethod()?.DeclaringType?.Assembly;
			if (assembly != null && assembly == typeof(_000F_0019).Assembly)
			{
				return true;
			}
		}
		return false;
	}

	private static void _0005(byte[] _0005, int _0002, byte[] _000F)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 128;
		int num4 = _000F.Length;
		while (num < num4)
		{
			if ((num3 <<= 1) == 256)
			{
				num3 = 1;
				num2 = _0005[_0002++];
			}
			if ((num2 & num3) != 0)
			{
				int num5 = (_0005[_0002] >> 2) + 3;
				int num6 = ((_0005[_0002] << 8) | _0005[_0002 + 1]) & 0x3FF;
				_0002 += 2;
				int num7 = num - num6;
				if (num7 < 0)
				{
					break;
				}
				while (--num5 >= 0 && num < num4)
				{
					_000F[num++] = _000F[num7++];
				}
			}
			else
			{
				_000F[num++] = _0005[_0002++];
			}
		}
	}
}
internal sealed class _000F_200B
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
	internal struct _0005
	{
	}

	internal static readonly _0005 _0005/* Not supported: data(B1 84 1C 03 ED 5E 09 00 39 1C 00 00 55 00 00 00 01 00 00 00) */;
}
