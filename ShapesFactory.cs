using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_05_19404086
{
    /// <summary>
    /// Used Factory Creational Pattern for saving the complexity and on user to create each class seperately, the user doesn't
    /// have get into the complexity of creating objects they can simply use factory classes and create the required object.
    /// </summary>
    interface ShapesFactory
    {
        public string ID { get; set; }

        public Shape CreateShape();
    }

    class CircleFactory : ShapesFactory
    {
        public int X { get; set; }        // circle centre x-coordinate
        public int Y { get; set; }        // circle centre y-coordinate
        public int R { get; set; }
        public string ID { get; set; }

        internal ShapesFactory ShapesFactory
        {
            get => default;
            set
            {
            }
        }

        public Circle Circle
        {
            get => default;
            set
            {
            }
        }

        public Shape Shape { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public CircleFactory()
        {
            ID = "C100"; X = 100; Y = 100; R = 100;
        }

        public CircleFactory(string id, int x, int y, int r) { ID = id; X = x; Y = y; R = r; }

        public Shape CreateShape()
        {
            return new Circle(ID, X,Y,R);
        }
    }

    class RectangleFactory : ShapesFactory
    {
        public int X { get; set; }        // Rectangle centre x-coordinate
        public int Y { get; set; }        // Rectangle centre y-coordinate
        public int W { get; set; }        // Rectangle width
        public int H { get; set; }        // Rectangle height
        public string ID { get; set; }

        internal ShapesFactory ShapesFactory
        {
            get => default;
            set
            {
            }
        }

        public Rectangle Rectangle
        {
            get => default;
            set
            {
            }
        }

        public RectangleFactory()
        {
            ID = "R100"; X = 100; Y = 100; W = 100; H = 100;
        }

        public RectangleFactory(string id, int x, int y, int w, int h) { ID = id; X = x; Y = y; W = w; H = h; }

        public Shape CreateShape()
        {
            return new Rectangle(ID, X, Y, W, H);
        }
    }

    class EllipseFactory : ShapesFactory
    {
        public int X { get; set; }        // Ellipse centre x-coordinate
        public int Y { get; set; }        // Ellipse centre y-coordinate
        public int RX { get; set; }       // Ellipse radius x
        public int RY { get; set; }       // Ellipse radius y
        public string ID { get; set; }

        internal ShapesFactory ShapesFactory
        {
            get => default;
            set
            {
            }
        }

        public Ellipse Ellipse
        {
            get => default;
            set
            {
            }
        }

        public EllipseFactory()
        {
            ID = "E100"; X = 100; Y = 100; RX = 100; RY = 100;
        }

        public EllipseFactory(string id, int x, int y, int rx, int ry) { ID = id; X = x; Y = y; RX = rx; RY = ry; }

        public Shape CreateShape()
        {
            return new Ellipse(ID, X, Y, RX, RY);
        }
    }

    class LineFactory : ShapesFactory
    {
        public int X1 { get; set; }        // Line centre x1-coordinate
        public int Y1 { get; set; }        // Line centre y1-coordinate
        public int X2 { get; set; }        // Line  x2-coordinate
        public int Y2 { get; set; }        // Line  y2-coordinate
        public string ID { get; set; }

        internal ShapesFactory ShapesFactory
        {
            get => default;
            set
            {
            }
        }

        public Line Line
        {
            get => default;
            set
            {
            }
        }

        public LineFactory()
        {
            ID = "L100"; X1 = 100; Y1 = 100; X2 = 100; Y2 = 100;
        }

        public LineFactory(string id, int x1, int y1, int x2, int y2) { ID = id; X1 = x1; Y1 = y1; X2 = x2; Y2 = y2; }

        public Shape CreateShape()
        {
            return new Line(ID, X1, Y1, X2, Y2);
        }
    }

    class PolyLineFactory : ShapesFactory
    {
        public string P { get; set; } //String P(points) for the polyline
        
        public string ID { get; set; }

        internal ShapesFactory ShapesFactory
        {
            get => default;
            set
            {
            }
        }

        public PolyLine PolyLine
        {
            get => default;
            set
            {
            }
        }

        public PolyLineFactory()
        {
            ID = "P100"; P = "60 110 65 120 70 115 75 130 80 125 85 140 90 135 95 150 100 145";
        }

        public PolyLineFactory(string id, string p) { ID = id; P = p; }

        public Shape CreateShape()
        {
            return new PolyLine(ID, P);
        }
    }

    class PolygonFactory : ShapesFactory
    {
        public string PG { get; set; } //String P(points) for the polygon

        public string ID { get; set; }

        internal ShapesFactory ShapesFactory
        {
            get => default;
            set
            {
            }
        }

        public Polygon Polygon
        {
            get => default;
            set
            {
            }
        }

        public PolygonFactory()
        {
            ID = "P100"; PG = "50 160 55 180 70 180 60 190 65 205 50 195 35 205 40 190 30 180 45 180";
        }

        public PolygonFactory(string id, string pg) { ID = id; PG = pg; }

        public Shape CreateShape()
        {
            return new Polygon(ID, PG);
        }
    }

    class PathFactory : ShapesFactory
    {
        

        public string ID { get; set; }

        public string PT { get; set; }    //String Path(points) for the Path

        internal ShapesFactory ShapesFactory
        {
            get => default;
            set
            {
            }
        }

        public Path Path
        {
            get => default;
            set
            {
            }
        }

        public PathFactory() { ID = "PT100"; PT = "M20,230 Q40,205 50,230 T90,230"; }

        public PathFactory(string id, string pt) { ID = id; PT = pt; }

        public Shape CreateShape()
        {
            return new Path(ID, PT);
        }
    }
}
