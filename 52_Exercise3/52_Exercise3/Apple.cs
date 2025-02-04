using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_Exercise3
{
    internal class Apple
    {
        #region Fields

        float amountLeft;
        bool organic;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the amount of apple left
        /// </summary>
        public float AmountLeft
        {
            get { return amountLeft; }
        }

        /// <summary>
        /// Gets a value indicating whether the apple is organic
        /// </summary>
        public Boolean Organic
        {
            get { return organic; }
        }

        #endregion

        #region Methods

        public void TakeBite(float size)
        {
            amountLeft -= size;
        }

        #endregion

    }
}
