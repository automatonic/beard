using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mona;

namespace Beard
{
    public static class Templates
    {
        static Templates()
        {
            
        }



        public static void Compile(Stream input, Stream output)
        {
            input.CopyTo(output);
        }
    }
}
