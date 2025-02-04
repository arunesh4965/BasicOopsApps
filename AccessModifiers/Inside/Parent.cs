using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;

namespace Inside
{
    public class Parent : GrantParent
    {
        private int PrivateParentNumber =20;

        protected int ProtectedParentNumber = 40;

        internal int InternalParentNumber = 50;

        public int GrandParentInternalOut
        {
            get {return InternalGrantParentNumber;}
        }
        public int ProtectedInternalOut{
            get{ return ProtectedInternalNumber;}
        }
    }
}