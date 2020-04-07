using System;

namespace WCFServer
{
    public class TestService : Data.ITest
    {
        public DateTime GetServerTime()
        {
            return DateTime.Now;
        }
    }
}
