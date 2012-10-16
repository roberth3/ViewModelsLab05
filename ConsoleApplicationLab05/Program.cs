using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ViewModelUnitTest;

namespace ConsoleApplicationLab05
{
    class Program
    {
        static void Main(string[] args)
        {

            UserProfileUnitTest test = new UserProfileUnitTest();

            test.ConfigureTest();
        }
    }
}
