using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace TrialGame1
{
    public enum SpriteType
    {
        Coins_01,
        Coins_02,
        Coins_03,
        Coins_04,
        Coins_05,
        Coins_07,
        Coins_09,
        Coins_12,
        Best_Deal,
        Most_Popular,
        //CloseButton,
        EmptyImg,
        PriceButton,
        RoundedRectangle,
        //RoundedRectangleHead,
        //Window
    }
    
    public class AtlasReader : MonoBehaviour
    {
        public SpriteType thisType;
        public SpriteAtlas atlas;

        void Start()
        {
            GetComponent<Image>().sprite = atlas.GetSprite(thisType.ToString());
        }
    }
}