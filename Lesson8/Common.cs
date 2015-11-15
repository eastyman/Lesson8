using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Common<T> where T:Liq
    {
        private T param;
        public Common(T param)
        {
            this.param = param;
        }

        public void Info()
        {
            param.Info();
        }
    }
}
