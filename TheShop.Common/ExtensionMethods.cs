
namespace TheShop.Common
{
    public static class ExtensionMethods
    {
        public static bool IsNull(this object i)
        {
            return i == null;
        }


        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

    }
}
