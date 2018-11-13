using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfacePlay
{
    public class Util
    {

        // bubblesort
        public static void BubbleSort(ISuperSortable[] iso)
        {
            ISuperSortable swop;
            for (int i = iso.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (iso[j].CompareItems(iso[j + 1]) > 0)
                    {
                        swop = iso[j];
                        iso[j] = iso[j + 1];
                        iso[j + 1] = swop;
                    }
                }
            }
        }

    }
}