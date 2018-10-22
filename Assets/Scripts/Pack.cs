using UnityEngine;

namespace TrialGame1
{
    [CreateAssetMenu()]
    public class Pack : ScriptableObject
    {
        public int CoinsAmount;
        public SpriteType CoinsImgName;
        public int BonusAmount;
        public double Price;
        public SpriteType PopularityImgName;

        public Pack(int coinsAmount, SpriteType coinsImgName, int bonusAmount, double price, SpriteType popularityImgName)
        {
            CoinsAmount = coinsAmount;
            CoinsImgName = coinsImgName;
            BonusAmount = bonusAmount;
            Price = price;
            PopularityImgName = popularityImgName;
        }
    }
}
