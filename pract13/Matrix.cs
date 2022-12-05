using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract13
{
    class Matrix
    {
        private int _row;
        private int _column;
        private int _maxRandonValue = 10;
        private int _minRandonValue = 1;
        public int Row { get { return _row; } set { _row = value; } }
        public int Column { get { return _column; } set { _column = value; } }
        public int MaxRange { get { return _maxRandonValue; } set { _maxRandonValue = value; } }
        public int MinRange { get { return _minRandonValue; } set { _minRandonValue = value; } }

        public Matrix (int Row, int Column)
        {
            _row = Row;
            _column = Column;
        }
        public Matrix(int Row, int Column, int MaxRange, int MinRange)
        {
            _row = Row;
            _column = Column;
            _maxRandonValue = MaxRange;
            _minRandonValue = MinRange;
        }
        //public int[] CreateMatrix()
        //{
        //    Random rnd = new();
        //    for (int i = 0; i < Row; i++)
        //    {
        //        for (int j = 0; j < Column; j++)
        //        {
        //            rnd.Next(MinRange,MaxRange);
        //        }
        //    }

        //}
    }
}
