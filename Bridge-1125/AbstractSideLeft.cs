using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge_1125
{
    public abstract class AbstractSideLeft
    {
        public AbstractSideLeft(AbstractSideRight abstractSideRight)
        {
            this.Right = abstractSideRight;
        }

        public AbstractSideRight Right
        {
            get;set;
        }

        public abstract void Operation();
    }
}