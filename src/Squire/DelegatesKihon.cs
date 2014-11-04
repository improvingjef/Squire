using NUnit.Framework;
using Squire.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Squire
{
    [TestFixture]
    public class DelegatesKihon : DelegatesKihonBase
    {
        public override Action Return_An_Action_That_Calls_Hit_On_a(ITarget a)
        {
            return () => a.Hit();
        }

        public override Action<ITarget> Return_An_Action_That_Calls_Hit_On_Its_Parameter()
        {
            return a => a.Hit();
        }

        public override Expression<Func<bool>> Return_An_Expression_That_Is_a_or_b(bool a, bool b)
        {
            return () => a || b;
        }
    }
}
