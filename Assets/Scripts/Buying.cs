using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TrialGame1
{
    public class Buying : MonoBehaviour
    {
        public static void PackBuying(Pack pack)
        {
            Debug.Log("You successfully bought " + pack.CoinsAmount + " coins for $" + pack.Price);
        }
    }
}
