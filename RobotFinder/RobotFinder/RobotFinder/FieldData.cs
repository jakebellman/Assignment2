using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RobotFinder
{
	public class FieldData
	{
		private int _M ,_N,_x1,_y1,_xg,_yg;

		List<int> _xs = new List<int>(); List<int> _ys = new List<int>();List<int> _width = new List<int>();List<int> _height = new List<int>();
		List<int> _deadcellx = new List<int>(); List<int> _deadcelly = new List<int>();


		public FieldData()
		{
			
			List<String> lines = File.ReadAllLines(@"C:\Users\Archie\Desktop\RobotFinder\WriteText.txt").ToList();


			foreach (var line in lines)
			{
				if(line == lines[0])
				{

					string[] entries = line.Split('[',',',']');

					_M = Int32.Parse(entries[1]);
					_N = Int32.Parse(entries[2]);

					Console.WriteLine(_M);
				}
				else if(line == lines[1])
				{

					string[] entries = line.Split('(',',',')');
					_x1 = Int32.Parse(entries[1]);
					_y1= Int32.Parse(entries[2]);

					Console.WriteLine(_x1);
				}
				else if(line == lines[2])
				{

					string[] entries = line.Split('(',',',')');
					_xg = Int32.Parse(entries[1]);
					_yg= Int32.Parse(entries[2]);

					Console.WriteLine(_xg);
				}
				else
				{
					string[] entries = line.Split('(',',',')');

					_xs.Add( Int32.Parse(entries[1]));
					_ys.Add( Int32.Parse(entries[2]));
					_width.Add( Int32.Parse(entries[3]));
					_height.Add( Int32.Parse(entries[4]));

				}
			}

		}
	


	public int M
	{
		get
		{
			return _M;
		}

		set
		{
			_M = value;
		}
	}
	public int N
	{
		get
		{
			return _N;
		}

		set
		{
			_N = value;
		}
	}
	public int x1
	{
		get
		{
			return _x1;
		}

		set
		{
			_x1 = value;
		}
	}
	public int y1
	{
		get
		{
			return _y1;
		}

		set
		{
			_y1 = value;
		}
	}
	public int xg
	{
		get
		{
			return _xg;
		}

		set
		{
			_xg = value;
		}
	}
	public int yg
	{
		get
		{
			return _yg;
		}

		set
		{
			_xg = value;
		}
	}
		public List<int> xs
	{
		get
		{
			return _xs;
		}

		set
		{
			_xs = value;
		}
	}
		public List<int> ys
	{
		get
		{
			return _ys;
		}

		set
		{
			_ys = value;
		}
	}
		public List<int> width
	{
		get
		{
			return _width;
		}

		set
		{
			_width = value;
		}
	}
		public  List<int> height
	{
		get
		{
			return _height;
		}

		set
		{
			_height = value;
		}
	}
		public  List<int> DeadCellx	
		{
			get
			{
				return _deadcellx;
			}

			set
			{
				_deadcellx = value;
			}
		}
		public  List<int> DeadCelly
		{
			get
			{
				return _deadcelly;
			}

			set
			{
				_deadcelly = value;
			}
		}
	}
}
