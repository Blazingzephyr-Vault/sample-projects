using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Formulas
{
    public delegate float Function(ref float x, float xm);
    public delegate float Function1(ref float x, float xm);

    public partial class Form1 : Form
    {
        private readonly Graphics _graphics;
        private readonly Pen _axis;
        private float _thickness;

        private readonly int _width;
        private readonly int _half_width;
        private readonly int _height;
        private readonly int _half_height;

        private readonly List<Tuple<Function[], Color, Func<float, float, float>>> _functions = new ()
        {
            Tuple.Create(
                new Function[1] { (ref float x, float ym) => x * ym },
                Color.Green,
                new Func<float, float, float>((float x, float xm) => x * xm)
            ),

            Tuple.Create(
                new Function[1] { (ref float x, float ym) => x * x * 0.01f / ym },
                Color.Red,
                new Func<float, float, float>((float x, float xm) => -1 * x * xm)
            ),

            Tuple.Create(
                new Function[1] { (ref float x, float ym) => x * x * x * 0.01f / ym },
                Color.LightBlue,
                new Func<float, float, float>((float x, float xm) => x * xm)
            ),

            Tuple.Create(
                new Function[2]
                {
                    (ref float x, float ym) => {
                        if (x > 0)
                        {
                            return 1 / x / 0.0050f * ym;
                        }
                        else
                        {
                            x = -0.00001f;
                            return 1 / -0.0001f / 0.0050f * ym;
                        }
                    },

                    (ref float x, float ym) => {
                        if (x < 0)
                        {
                            return 1 / x / 0.0050f * ym;
                        }
                        else
                        {
                            x = 0.00001f;
                            return 1 / 0.0001f / 0.0050f * ym;
                        }
                    }
                },
                Color.FromArgb(255, 0, 255),
                new Func<float, float, float>((float x, float xm) => -1 * x * xm)
            )
        };
        private readonly List<bool> _functionsEnabled = new()
        {
            false,
            false,
            false,
            false
        };

        public Form1()
        {
            InitializeComponent();
            _axis = new Pen(Color.White);
            _width = pictureBox.Width;
            _half_width = _width / 2;
            _height = pictureBox.Height;
            _half_height = _height / 2;
            _graphics = pictureBox.CreateGraphics();
        }

        private void DrawGrid()
        {
            _graphics.DrawLine(_axis, 0, _height / 2, _width, _height / 2);
            _graphics.DrawLine(_axis, _width / 2, 0, _width / 2, _height);
        }

        private void DrawGraph(Function[] piecewiseGraphs, Color color, Func<float, float, float> multiply)
        {
            foreach (Function piecewiseGraph in piecewiseGraphs)
            {
                Collection<PointF> points = new Collection<PointF>();
                for (int i = -_half_width; i < _half_width; i++)
                {
                    float x1 = i;
                    var y1  = piecewiseGraph(ref x1, (float)yMultiplier.Value) * -1;

                    float x2 = multiply(x1, (float)xMultiplier.Value) + _half_width;
                    float y2 = y1 + _half_height;

                    if (y2 > 0 && y2 < _height)
                    {
                        points.Add(new PointF(x2, y2));
                    }
                }

                Pen pen = new (color, _thickness);
                _graphics.DrawCurve(pen, points.ToArray());
            }
        }

        private void Draw(object sender, EventArgs e)
        {
            _graphics.Clear(Color.Black);
            DrawGrid();

            for (int i = 0; i < _functions.Count; i++)
            {
                if (_functionsEnabled[i])
                {
                    var (functions, colors, multiply) = _functions[i]; 
                    DrawGraph(functions, colors, multiply);
                }
            }
        }

        private void UpdateThickness(object sender, EventArgs e) => _thickness = (float)penThickness.Value;
        private void GraphSelected(object sender, ItemCheckEventArgs e) => _functionsEnabled[e.Index] = e.NewValue == CheckState.Checked;
    }
}