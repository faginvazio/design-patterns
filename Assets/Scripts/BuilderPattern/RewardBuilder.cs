using UnityEngine;

public class RewardBuilder
{
    private Reward reward = new Reward();


    public RewardBuilder AddGold(int amount)
    {
        reward.Gold += amount;
        return this;
    }
    public RewardBuilder AddExp(int amount)
    {
        reward.Exp += amount;
        return this;
    }
    public RewardBuilder AddItem(string item)
    {
        reward.Items.Add(item);
        return this;
    }


    public Reward Build() => reward;
}
