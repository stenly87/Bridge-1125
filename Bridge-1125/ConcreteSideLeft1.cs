using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge_1125
{
    public class ConcreteSideLeft1 : AbstractSideLeft
    {
        public ConcreteSideLeft1(AbstractSideRight abstractSideRight) : base(abstractSideRight)
        {
        }

        public override void Operation()
        {
            throw new NotImplementedException();
        }
    }
}