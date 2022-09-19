using System.Threading.Tasks;

namespace async_processing;

public class AsyncFunc
{
    public async Task ThrowSomeAsyncException()
    {
        Thread.Sleep(1000);
        throw new Exception("Exception");
    }

    public async Task<int> DoubleTheValueInGenericEntry(int entry, int delay)
    {
        Thread.Sleep(delay);
        return entry * 2;
    }

}
