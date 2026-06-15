using UnityEngine;

public class CounterModel
{
    private int count;

    public int Count { get { return count; } }

    public void Increment()
    {
        count++;
    }

    public void Reset()
    {
        count = 0;
    }
}
