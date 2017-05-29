using NLog;
using System;

namespace Opg17Log
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Trace("Enter Main");
            logger.Trace("Calling test1");
            test1(5, 5);
            logger.Trace("Return from test1");
            logger.Trace("Calling test2");
            test2();
            logger.Trace("Return from test2");
            logger.Trace("Exit Main");
        }

        static void test1(int i, int x)
        {
            logger.Trace("Enter test1 i, x {0} {1}", i, x);
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(3000);
            logger.Trace("Exit test1");
        }

        static void test2()
        {
            logger.Trace("Enter test2");
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                // mangler log
            }
            logger.Trace("Exit test2");
        }
    }
}
