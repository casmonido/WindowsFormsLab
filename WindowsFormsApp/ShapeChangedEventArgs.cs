using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class ShapeChangedEventArgs : EventArgs
    {
        private ShapeEnum _curShape;

        public ShapeChangedEventArgs()
        { }
        public ShapeChangedEventArgs(ShapeEnum shape)
        {
            this._curShape = shape;
        } 

        public ShapeEnum Shape
        {
            get
            {
                return this._curShape;
            }
            set
            {
                this._curShape = value;
            }
        }
    }
}
