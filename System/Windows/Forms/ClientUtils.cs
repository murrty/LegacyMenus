//----------------------
// <auto-generated>
//     Backwards compatibility with Menus.
// </auto-generated>
//----------------------
// System.Windows.Forms.ClientUtils
#if NETCOREAPP3_1_OR_GREATER
namespace System.Windows.Forms;
internal static class ClientUtils {
    public static bool IsEnumValid(Enum enumValue, int value, int minValue, int maxValue) {
        return value >= minValue && value <= maxValue;
    }
}
#endif