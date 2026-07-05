using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace App2
{
    class ListComparer : System.Collections.IComparer
    {
        private int Col;
        private bool Inc = true;

        static int LastC = -1;
        static bool LastInc = true;

        public ListComparer(int column)
        {
            Col = column;
            Inc = (LastC == Col) ? !LastInc : true;

            LastC = Col;
            LastInc = Inc;
        }


        public int Compare(object x, object y)
        {
            string xStr = ((ListViewItem)x).SubItems[Col].Text;
            string yStr = ((ListViewItem)y).SubItems[Col].Text;

            int xV=0, yV=0;
            bool num1 = int.TryParse(xStr, out xV);
            bool num2 = int.TryParse(yStr, out yV);

            if(num1 && num2)
            {
                if(Inc) return (xV>yV) ? 1 : -1;
                else return (xV>yV) ? -1 : 1;
            }
            else
            {
                if (Inc)
                    return string.Compare(((ListViewItem)x).SubItems[Col].Text, ((ListViewItem)y).SubItems[Col].Text);
                else
                    return string.Compare(((ListViewItem)y).SubItems[Col].Text, ((ListViewItem)x).SubItems[Col].Text);
            }
        }
    }
}
