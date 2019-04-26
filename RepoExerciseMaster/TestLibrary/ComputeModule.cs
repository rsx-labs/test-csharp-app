using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public static class ComputeModule
    {
        public static Task<int> AddIntegerAsync(int value1, int value2)
        {
            return Task.Run<int>(() => value1 + value2);
        }
    }
}
