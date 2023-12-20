using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge_1125
{
    public class Client
    {
        AbstractSideLeft left;
        AbstractSideRight right;
        public Client()
        {
            right = new ConcreteSideRight1();
            left = new ConcreteSideLeft1(right);
        }

        public void ChangeElementLeft(AbstractSideLeft left)
        {
            this.left = left;
            left.Right = right;
        }

        public void ChangeElementRight(AbstractSideRight right)
        {
            left.Right = right;
        }
    }
}