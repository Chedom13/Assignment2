using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int dim1, int dim2, int dim3)
        {
            string result;
            if (dim1 < 1 || dim2 < 1 || dim3 < 1)
                result = "Cannot form a triangle";
            else if (dim1 == dim2 && dim2 == dim3)
                result = "Equilateral";
            else if ((dim1 == dim2 && dim1 != dim3) || (dim1 != dim2 && dim1 == dim3) || (dim2 == dim3 && dim2 != dim1))
                result = "Isosceles";
            else
                result = "Scalene";
            return result;
        }
    }
}
