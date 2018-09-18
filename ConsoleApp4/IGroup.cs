using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public interface IGroup<T>
    {
        List<T> SET { get; }
        T Operator(T a, T b);

        T Inverse(T a);
        T Identity();

        bool IsAssociated();
        bool HasIdentity();
    }

    public static class IGroupExt
    {

        public static bool IsGroup<T>(this IGroup<T> group)
        {
            foreach (var item in group.SET)
            {
                if ((int)(object)(group.Inverse(item)) == 0)
                    return false;
            }
            return group.HasIdentity() && group.IsAssociated();
        }

        public static List<T> Enums<T>(this T _enum)
        {
            var L = Enum.GetValues(typeof(T)).Cast<T>().ToList();
            L.RemoveAt(0);
            return L;
        }
    }
}
