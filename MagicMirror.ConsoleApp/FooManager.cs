using MagicMirror.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagicMirror.ConsoleApp
{
    public class FooManager:IDisposable
    {

        private IFooRepo _repo;

        public FooManager(IFooRepo repo)
        {
            _repo = repo;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void KillSelf()
        {
            _repo.AddFoo();
        }
    }
}
