using System;
using System.Threading;

namespace SilverlightDemo
{
    public class AsyncCalculator
    {
        public event Action<int> AsyncronousAddCompleted;

        public void AddAsyncronously(int x, int y)
        {
            int sum = x + y;
            Thread.Sleep(TimeSpan.FromSeconds(3));
            if (AsyncronousAddCompleted != null)
                AsyncronousAddCompleted(sum);
        }
    }
}
