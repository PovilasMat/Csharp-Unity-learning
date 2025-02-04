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

        /// <summary>
        /// Constructor for the Apple class
        /// </summary>
        /// <param name="amountLeft"></param>
        /// <param name="organic"></param>
        #region Constructors

        /// <summary>
        /// Constructor for the Apple class with specific amount left
        /// </summary>
        /// <param name="amountLeft">the ratio of an apple that's left</param>
        /// <param name="organic"></param>
        public Apple(float amountLeft, bool organic)
        {
            this.amountLeft = amountLeft;
            this.organic = organic;
        }

        public Apple(bool organic) : this(1.0F, organic)
        {
            this.organic = organic;
        }
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
