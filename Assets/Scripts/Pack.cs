using UnityEngine;

namespace TrialGame1
{
    [CreateAssetMenu()]
    public class Pack : ScriptableObject
    {
        public int CoinsAmount;
        public string CoinsImgName;
        public string BonusImgName;
        public double Price;
        public string PopularityImgName;

        public Pack(int coinsAmount, string coinsImgName, string bonusImgName, double price, string popularityImgName)
        {
            CoinsAmount = coinsAmount;
            CoinsImgName = coinsImgName;
            BonusImgName = bonusImgName;
            Price = price;
            PopularityImgName = popularityImgName;
        }
    }
}
