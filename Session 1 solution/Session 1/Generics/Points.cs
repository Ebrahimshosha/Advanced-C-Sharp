using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1.Generics
{
    internal class Points : IComparable<Points>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Points(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }

        // CompareTo Before Generic
        #region public int CompareTo(object? obj)

        //public int CompareTo(object? obj)
        //{
        //    //Points PassedPoint = (Points)obj; // UnSafe

        //    #region Is Conditional Operator → This not The best

        //    /// This Operator will return True at 3 Cases :
        //    /// 1. Obj is point
        //    /// 2. obj is an object from another class inheriting from point
        //    /// 3. obj is Null

        //    //if (obj is Points passedPoint)
        //    //{
        //    //    if (passedPoint == null) return 1;
        //    //    if (this.X == PassedPoint.X)
        //    //        return this.Y.CompareTo(PassedPoint.Y);
        //    //    else
        //    //        return this.Y.CompareTo(PassedPoint.Y);
        //    //}
        //    //return 1; Not the best because U suppose this > object that passed regardless its type

        //    #endregion

        //    #region as Casting Operator

        //    // casting Will succeed if obj is point 
        //    // if Casting Failed , will return Null → Zero Exceptions will be Throw
        //    //Points PassedPoint = obj as Points;

        //    //if (PassedPoint == null) return 1; // this > obj that passed regardless its type

        //    //if (this.X == PassedPoint.X)
        //    //    return this.Y.CompareTo(PassedPoint.Y);
        //    //else
        //    //    return this.Y.CompareTo(PassedPoint.Y);


        //    #endregion

        //}

        #endregion

        // CompareTo After Generic
        public int CompareTo(Points? PassedPoint)
        {
            if (PassedPoint == null) return 1;
            if (this.X == PassedPoint.X)
                return this.Y.CompareTo(PassedPoint.Y);
            else
                return this.Y.CompareTo(PassedPoint.Y);

        }
    }
}
