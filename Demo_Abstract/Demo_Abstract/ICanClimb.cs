using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract
{
    internal interface ICanClimbJump
    {
        // ko ghi abstract vì nó kế thừa
        // ko ghi public vì mặt định là public
        void Climb();
        void Jump();
    }
}
