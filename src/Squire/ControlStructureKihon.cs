using System;
using NUnit.Framework;
using Squire.Framework;
using System.Collections.Generic;

namespace Squire
{
    [TestFixture]
    public class ControlStructureKihon : ControlStructuresKihonBase
    {
        /*
         * This Kihon uses ITarget extensively.  It has a method called Hit() and
         * a property called IsValid.  So "Call_Hit_On_a" means "a.Hit();"
         */
        protected override void Call_Hit_On_a_If_val_Is_True_Else_Call_Hit_On_b(bool val, ITarget a, ITarget b)
        {
            if(val)
            {
                a.Hit();
            }
            else
            {
                b.Hit();
            }
        }

        protected override void Call_Hit_On_a_Once_For_Each_Member_Of_list(ITarget a, List<string> list)
        {
            foreach (var item in list)
                a.Hit();
        }

        protected override void Call_Hit_On_a_While_a_IsValid_Is_True(ITarget a)
        {
            while (a.IsValid)
                a.Hit();
        }

        protected override void n_Times_Call_Hit_On_a(int n, ITarget a)
        {
            for (int i = 0; i < n; i++)
                a.Hit();
        }

        protected override void Call_Hit_On_a_Once_And_Loop_Until_IsValid_Is_False(ITarget a)
        {
            do
            {
                a.Hit();
            } while (a.IsValid);
        }
    }
}
