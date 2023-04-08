
namespace StrategyChess
{
    internal class Game
    {
        private readonly PictureBox _pictureBox;
        private readonly Bitmap     _bitmap;
        private readonly Graphics   _graphics;
        private readonly Pen        _pen;
        private readonly SolidBrush _brush1;
        private readonly SolidBrush _brush2;

        private readonly float      _w;
        private readonly float      _h;
        private readonly float      _x;
        private readonly float      _y;

        public Game(PictureBox box)
        {
            _pictureBox = box;
            _bitmap = new Bitmap(box.Width, box.Height);
            _graphics = Graphics.FromImage(_bitmap);
            _pen = new Pen(Color.Black, 2);
            _brush1 = new SolidBrush(Color.Red);
            _brush2 = new SolidBrush(Color.Yellow);

            _w = _pictureBox.Width;
            _h = _pictureBox.Height;
            _x = _w / 8;
            _y = _h / 8;

            DrawGrid();
        }

        public void OnPieceSwitched(int index)
        {
            DrawGrid();
            DrawTile(_brush1, 4, 4);

            IPiece piece = index switch
            {
                0 => new Pawn(), 
                1 => new Knight(),
                2 => new Bishop(),
                3 => new Rook(),
                4 => new Queen(),
                5 => new King(),
                _ => new Pawn()
            };
            
            Tuple<int, int>[] points = piece.GetAvailableTiles();
            foreach (var point in points)
            {
                DrawTile(_brush2, 4 - point.Item1, 4 - point.Item2);
            }
        }

        private void DrawGrid()
        {
            _graphics.FillRectangle(new SolidBrush(Color.White), _graphics.VisibleClipBounds);

            for (int i = 0; i < 9; i++)
            {
                _graphics.DrawLine(_pen, 0, _y * i, _w, _y * i);
                _graphics.DrawLine(_pen, _x * i, 0, _x * i, _h);
            }

            _graphics.Save();
            _pictureBox.Image = _bitmap;         
        }

        private void DrawTile(Brush brush, int x, int y)
        {
            _graphics.FillRectangle(brush, (x - 1) * _x, (y - 1) * _y, _x, _y);
            _graphics.Save();
            _pictureBox.Image = _bitmap;
        }
    }
}