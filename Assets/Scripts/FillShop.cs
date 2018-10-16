﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TrialGame1
{
    public class FillShop : MonoBehaviour
    {
        public GameObject Content;
        public GameObject PackPrefab;
        public List<Pack> packs;
        
        const float PACK_HEIGHT = 70;

        void Start()
        {
            SortPacks(packs, true);
            Content.GetComponent<RectTransform>().sizeDelta = new Vector2(0, PACK_HEIGHT * packs.Count);

            int index = 0;
            foreach (var pack in packs)
            {
                CreatePack(pack, index);
                index++;
            }
        }

        private void SortPacks(List<Pack> packs, bool isDesc = false)
        {
            packs.Sort(new Comparison<Pack>((Pack p1, Pack p2) => p1.CoinsAmount.CompareTo(p2.CoinsAmount)));
            if (isDesc)
                packs.Reverse();
        }

        private void CreatePack(Pack pack, int index)
        {
            GameObject currPrefab = Instantiate(PackPrefab);
            currPrefab.transform.SetParent(Content.transform, false);

            SetDefaultPackRectTransform(currPrefab, index);

            Transform packBoxTransform = currPrefab.transform.GetChild(0);

            //0 - CoinsCountTxt
            packBoxTransform.GetChild(0).GetComponent<Text>().text = pack.CoinsAmount.ToString();
            //1 - CoinsIconImg
            packBoxTransform.GetChild(1).GetComponent<Image>().sprite =
                    Resources.Load<Sprite>("Coins/" + pack.CoinsImgName);
            //2 - BonusIconImg
            if (pack.BonusImgName != null && pack.BonusImgName != "")
                packBoxTransform.GetChild(2).GetComponent<Image>().sprite =
                    Resources.Load<Sprite>("Bonuses/" + pack.BonusImgName);
            //3 - PriceTxt
            packBoxTransform.GetChild(3).GetComponent<Button>().onClick.AddListener(delegate { Buying.PackBuying(pack); });
            packBoxTransform.GetChild(3).GetChild(0).GetComponent<Text>().text = "$" + pack.Price.ToString();
            //4 - PopularityIconImg
            if (pack.PopularityImgName != null && pack.PopularityImgName != "")
                packBoxTransform.GetChild(4).GetComponent<Image>().sprite =
                    Resources.Load<Sprite>("PopularityIcons/" + pack.PopularityImgName);
        }

        private void SetDefaultPackRectTransform(GameObject currPrefab, int index)
        {
            RectTransform thisRT = currPrefab.GetComponent<RectTransform>();
            thisRT.localPosition = new Vector3(-25, -PACK_HEIGHT * (packs.Count + index + 0.5f), 0);
            thisRT.sizeDelta = new Vector2(-50, PACK_HEIGHT);
            thisRT.anchorMin = new Vector2(0, 1);
            thisRT.anchorMax = new Vector2(1, 1);
        }
    }
}
