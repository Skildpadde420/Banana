using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banana
{
    class Banana
    {
        #region Members
        #endregion

        #region Constructor
        public Banana()
        {
        }
        public Banana(string name, int size, string color)
        {
            Name = name;
            Size = size;
            Color = color;
        }
        #endregion

        #region Properties
        public string Name{ get; set; }
        public int Size{ get; set; }
        public string Color{ get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
