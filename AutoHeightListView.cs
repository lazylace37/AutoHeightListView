using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AutoHeightListView
{
    public class AutoHeightListView : ListView
    {
        [Obsolete]
        protected override SizeRequest OnSizeRequest(
            double widthConstraint,
            double heightConstraint)
        {
            return new SizeRequest(new Size(widthConstraint, heightConstraint),
                new Size(widthConstraint, heightConstraint));
        }

        protected override SizeRequest OnMeasure(double widthConstraint,
            double heightConstraint)
        {
            Size oMinimumSize = new Size(40, 40);
            if (ItemsSource is IList itemsSource)
            {
                double dForcedRowHeight = this.RowHeight;
                double dHeaderHeight = 0d;
                if (this.TemplatedItems != null && this.TemplatedItems.Count > 0)
                {
                    dForcedRowHeight = TemplatedItems.ElementAt(0).Height;
                }

                if (this.Header != null)
                    dHeaderHeight = ((VisualElement)this.Header).Height;

                Size oDesiredSize = new Size(this.Width, itemsSource.Count * dForcedRowHeight + dHeaderHeight);
                return new SizeRequest(oDesiredSize, oMinimumSize);
            }

            return new SizeRequest(oMinimumSize);
        }
    }
}
