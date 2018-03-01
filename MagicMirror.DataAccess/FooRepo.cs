using System;
using System.Collections.Generic;
using System.Text;

namespace MagicMirror.DataAccess
{
    public class FooRepo : IFooRepo
    {
        public void AddFoo()
        {
            throw new ArgumentException("ZAP MUFUGGA");
        }

        public void DeleteFoo()
        {
            throw new NotImplementedException();
        }
    }
}
