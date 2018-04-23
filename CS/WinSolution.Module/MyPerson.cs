using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;

namespace WinSolution.Module {
    [DefaultClassOptions]
    public class MyPerson : Person {
        public MyPerson(Session session) : base(session) { }
    }
}
