using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Count : MonoBehaviour
{

    public Text countTxt;

        private void Start()
        {
            CountDown();
        }

    public void CountDown()
    {
        Sequence seq = DOTween.Sequence();
        seq.SetUpdate(true);
        seq.OnRewind(() =>
        {
            countTxt.text = $"3";
            countTxt.gameObject.SetActive(true);
        });
        seq.InsertCallback(1f, () => countTxt.text = "2");
        seq.InsertCallback(2f, () => countTxt.text = "1");
        seq.InsertCallback(3f, () => countTxt.text = "GO");
        seq.OnComplete(() => countTxt.gameObject.SetActive(false));
    }

}
