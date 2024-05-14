using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Horse : GrassFeedMammal , IFourLeggedMammal
    {
        public bool HasPAws { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AreCopite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int ReturnSpeed()
        {
            return 60;
        }

        public override void Speed()
        {
            throw new NotImplementedException();
        }
    }
}
