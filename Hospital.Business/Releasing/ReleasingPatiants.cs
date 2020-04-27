using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Business.Releasing
{
    public static class ReleasingPatiants
    {
        public static double Release(int Day, int Amount)
        {
            return (Day * Amount);
        }
    }
}
