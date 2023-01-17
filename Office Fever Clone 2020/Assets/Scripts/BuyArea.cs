using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyArea : MonoBehaviour
{
    public Image progressImage;
    public GameObject deskGameObject;
    public GameObject buyGameObject;

    public float cost;
    public float currentMoney;
    public float progress;

    public void Buy(int goldAmount)
    {
        currentMoney += goldAmount;
        progress = currentMoney / cost;
        progressImage.fillAmount = progress;
        if(progress >= 1)
        {
            buyGameObject.SetActive(false);
            deskGameObject.SetActive(true);
            this.enabled = false;
        }
    }
}
