using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inside
{
    public class Son:Parent
    {
    public int publicNumber = 10;
    private int privateNumber =20;

    public int PrivateNumber{
        get{return privateNumber;}
    }
    public int PrivateParent{
        get{return PrivateParentNumber;}
    }
    public int ProtectedParentOut{
        get{return ProtectedParentNumber;}
    }
    }
}