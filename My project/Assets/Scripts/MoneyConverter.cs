using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MoneyConverter
{

    public static string ConvertMoneyToText(long money)
    {
        float amount;
        if (money < 1000)
        {
            return money.ToString();
        } else if (money >= 1000 && money < 1000000)
        {
            amount = (float)money / 1000;
            return amount.ToString("F1") + "k";
        } else if (money >= 1000000 && money < 1000000000)
        {
            amount = (float)money / 1000000;
            return amount.ToString("F1") + "m";
        }
        else if (money >= 1000000000 && money < 1000000000000)
        {
            amount = (float)money / 1000000000;
            return amount.ToString("F1") + "b";
        }
        else if (money >= 1000000000000 && money < 1000000000000000)
        {
            amount = (float)money / 1000000000000;
            return amount.ToString("F1") + "t";
        }
        else if (money >= 1000000000000000 && money < 1000000000000000000)
        {
            amount = (float)money / 1000000000000000;
            return amount.ToString("F1") + "quad";
        }
        else
        {
            amount = (float)money / 1000000000000000000;
            return amount.ToString("F1") + "quint";
        }
    }
}
