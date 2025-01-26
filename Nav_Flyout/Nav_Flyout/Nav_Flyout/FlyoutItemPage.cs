using System;
using System.Collections.Generic;
using System.Text;

namespace Nav_Flyout.DataModel
{
    internal class FlyItemPage
    {
        public string Title { get; set; }
        public string IconSource { get; set; }
        public Type TargetPage { get; set; }
    }
}
