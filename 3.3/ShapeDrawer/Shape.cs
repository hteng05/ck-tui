using System;
using SplashKitSDK;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShapeDrawer
{
	public class Shape
	{
		private Color _color;
		private float _x, _y;
		private int _width, _height;
        private bool _selected;
        public Shape()
		{
            _color = Color.Chocolate;
			_x = 0.0f;
			_y = 0.0f;
			_width = 148;
			_height = 148;
        }
		public Color Color
		{
			get
			{
				return _color;
			}
            set
			{ 
                _color = value;
            }
        }

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public int Width
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

        public int Height
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
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }
        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
            if (_selected)
            {
                DrawOutline();
            }
        }

        public bool IsAt(Point2D pt)
        {
            if ((pt.X >= _x) && (pt.X <= _x + _width) && (pt.Y >= _y) && (pt.Y <= _y + _height))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //my ID: 104700948 => last digit: 8 => value = 13
        public void DrawOutline()
        {
            int value = 13;
            SplashKit.DrawRectangle(Color.Black, _x - value, _y - value , _width + value*2, _height + value*2);
        }
    }
}

