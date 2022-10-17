using System;

namespace BulkCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new Process();
            process.LoadFile("product_wrk");
        }
    }
}
