using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public enum Symbol
    {
        _null,
        a,
        b
    }
    public class Z2Group : IGroup<Symbol>
    {

        public List<Symbol> SET
        {
            get => new Symbol().Enums();
        }

        public bool HasIdentity()
        {
            return Identity() != Symbol._null;
        }

        public Symbol Identity()
        {
            bool _accepted(Symbol e)
            {
                foreach (var x in this.SET)
                {
                    if (Operator(x, e) != Operator(e, x) || Operator(x, e) != x)
                        return false;
                }
                return true;
            }
            foreach (var e in this.SET)
            {
                if (_accepted(e))
                    return e;
            }
            return Symbol._null;
        }

        public Symbol Inverse(Symbol a)
        {
            if (Identity() == Symbol._null)
                return Symbol._null;

            foreach (var x in this.SET)
                if (Operator(x, a) == Operator(a, x) && Operator(x, a) == Identity())
                    return x;

            return Symbol._null;
        }

        public bool IsAssociated()
        {
            foreach (var a in this.SET)
            {
                foreach (var b in this.SET)
                {
                    foreach (var c in this.SET)
                    {
                        if (Operator(a, Operator(b, c)) != Operator(Operator(a, b), c))
                            return false;
                    }
                }
            }

            return true;
        }

        public Symbol Operator(Symbol l, Symbol r)
        {
            //if (l == Symbol.a && r == Symbol.a)
            //    return Symbol.a;


            //else if (l == Symbol.a && r == Symbol.b)
            //    return Symbol.b;


            //else if (l == Symbol.b && r == Symbol.a)
            //    return Symbol.b;


            return l & r;

        }
    }
}
