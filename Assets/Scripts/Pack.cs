using UnityEngine;

namespace TrialGame1
{
    [CreateAssetMenu()]
    public class Pack : ScriptableObject
    {
        public int CoinsAmount;
        public string CoinsImgName;
        public int BonusAmount;
        public double Price;
        public string PopularityImgName;

        public Pack(int coinsAmount, string coinsImgName, int bonusAmount, double price, string popularityImgName)
        {
            CoinsAmount = coinsAmount;
            CoinsImgName = coinsImgName;
            BonusAmount = bonusAmount;
            Price = price;
            PopularityImgName = popularityImgName;
        }
    }
}
