using System.Windows.Forms;

namespace ColorsDesktop
{
    public class MyListViewItem : ListViewItem
    {
        public MyListViewItem(string text) : base(text)
        {}

        internal object detailObject { get; set; }
    
    }
}
