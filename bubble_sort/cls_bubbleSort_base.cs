// This class will be the base class,
// Declarations, constructors, destroyers, etc...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bubble_sort
{
    static class cls_bubbleSort_base
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // 20170918 : YRM : Bubble Sort testing
            //-------------------------------------
            int[] sort_array_me = { 8, 1, 5, 7, 6, 7, 2, 9 };

            int[] sorted_array = cls_bubbleSort_logic.BubbleSort(sort_array_me);

            Console.Write(sorted_array);
            //-------------------------------------


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ui_bubbleSort());
 

        }
    }
}
