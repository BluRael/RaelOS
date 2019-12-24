using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace RAELOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            //TEST SECTION
            //Tests are held in the "Tests.*" class.
            //Example: Tests.KeyboardTypeOut();
            //Change the line below to enable a testing mode
            Tests.NoDebug();

            //Boot Sequence Start

        }
    }
}
