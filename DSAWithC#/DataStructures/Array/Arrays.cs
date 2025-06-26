using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSAWithC_.DataStructures.Questions;
using Microsoft.VisualBasic;

namespace DSAWithC_.DataStructures
{
    public class Arrays
    {
        public void RunAll()
        {
            int[] arr = [0, 3, 5, 0, 5, 3, 2];
            ReverseAnArray.ReverseArray(arr);
            LargeAnd2Large.LargeAnd2ndLarge(arr);
            MoveAllZero.MoveAllZeroToEnd(arr);
        }
    }
}