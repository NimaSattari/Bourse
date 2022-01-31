using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HesabKon : MonoBehaviour
{
    [SerializeField] Text Money;
    [SerializeField] Text Day;
    [SerializeField] Text Percent;
    [SerializeField] Text profit;
    [SerializeField] Text profittext;
    [SerializeField] Text loss;
    [SerializeField] Text losstext;
    float money;
    float day;
    float percent;

    public void Profit()
    {
        money = float.Parse(Money.text);
        day = float.Parse(Day.text);
        percent = float.Parse(Percent.text);
        for (int i = 0; day > i; day--)
        {
            money = ((money * percent) / 100) + money;
        }
        loss.gameObject.SetActive(false);
        losstext.gameObject.SetActive(false);
        profit.gameObject.SetActive(true);
        profittext.gameObject.SetActive(true);
        profit.text = money.ToString();
    }
    public void Loss()
    {
        money = float.Parse(Money.text);
        day = float.Parse(Day.text);
        percent = float.Parse(Percent.text);
        for (int i = 0; day > i; day--)
        {
            money = money - ((money * percent) / 100);
        }
        profit.gameObject.SetActive(false);
        profittext.gameObject.SetActive(false);
        loss.gameObject.SetActive(true);
        losstext.gameObject.SetActive(true);
        loss.text = money.ToString();
    }
}