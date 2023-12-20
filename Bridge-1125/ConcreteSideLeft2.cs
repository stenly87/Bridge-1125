using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge_1125
{
    public class ConcreteSideLeft2 : AbstractSideLeft
    {
        public ConcreteSideLeft2(AbstractSideRight abstractSideRight) : base(abstractSideRight)
        {
        }

        public override void Operation()
        {
            throw new NotImplementedException();
        }
    }
}