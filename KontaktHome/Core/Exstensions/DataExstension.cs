using System.Data;
using System.Windows.Forms;



namespace KontaktHome.Core.Exstensions
{
    static partial class GetCurretnRow
    {
        internal static T GetCurrentRow<T>(this BindingSource bindingsource)
            where T : DataRow
        {
            var row = (bindingsource?.Current as DataRowView)?.Row as T;
            return row;
        }
    }
}
