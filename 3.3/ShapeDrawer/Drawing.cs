using System;
using SplashKitSDK;
namespace ShapeDrawer
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;
        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;

        }
        public Drawing() : this(Color.White)
        {
        }
        public int ShapeCount
        {
            get
            {
                return _shapes.Count;
            }
        }
        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }
        public void RemoveShape(Shape s)
        {
            _ = _shapes.Remove(s);
        }
        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            for (int i=0; i<_shapes.Count; i++)
            {
                _shapes[i].Draw();
            }
        }
        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                s.Selected = s.IsAt(pt);
            }
        }
        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result = new List<Shape>();

                foreach (Shape s in _shapes)
                {
                    if (s.Selected)
                    {
                        result.Add(s);
                    }
                }return result;
            }
        }
    }
}

