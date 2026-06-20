using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public static class BuffExtensions
{
    public static IBuff RemoveDecorator<T>(this IBuff buff) where T : IBuff
    {
        if (buff is T)
        {
            return ((BuffDecorator)buff).InnerBuff;
        }
        else if (buff is BuffDecorator decorator)
        {
            decorator.InnerBuff = decorator.InnerBuff.RemoveDecorator<T>();
            return decorator;
        }
        else
        {
            return buff;
        }
    }

    public static List<IBuff> GetBuffList(this IBuff buff)
    {
        List<IBuff> buffList = new List<IBuff>();
        IBuff current = buff;
        while (current is BuffDecorator decorator)
        {
            buffList.Add(current);
            current = decorator.InnerBuff;
        }
        return buffList;
    }


}
