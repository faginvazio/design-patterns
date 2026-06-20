using UnityEngine;

public abstract class BuffDecorator : IBuff
{
    protected IBuff innerBuff;
    public int Duration { get; set; }

    public BuffDecorator(IBuff innerBuff, int duration)
    {
        this.innerBuff = innerBuff;
        Duration = duration;
    }

    public IBuff InnerBuff { get { return innerBuff; } set { innerBuff = value; } }

    public virtual int GetAttackModifier()
    {
        return innerBuff.GetAttackModifier();
    }

    public virtual int GetDefenseModifier()
    {
        return innerBuff.GetDefenseModifier();
    }

    public virtual IBuff Tick()
    {
        Duration--;
        innerBuff = innerBuff.Tick();
        return this;
    }

    public virtual IBuff RemoveDecorator<T>() where T : IBuff
    {
        if (this is T)
        {  
            return innerBuff; 
        }
        else if (innerBuff is BuffDecorator)
        {
            innerBuff = innerBuff.RemoveDecorator<T>();
        }
        return this;
    }

    
}
