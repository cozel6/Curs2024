using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Sheep : GrassFeedMammal
    {
        public override int ReturnSpeed()
        {
            return 10;
        }

        public override void Speed()
        {
            throw new NotImplementedException();
        }
    }
}
