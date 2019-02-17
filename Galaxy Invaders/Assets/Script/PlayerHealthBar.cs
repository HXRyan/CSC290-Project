using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthBar : MonoBehaviour
{

    protected int maxHP, currHP = 3;

    public Sprite HealthBarSprite;

    void getHit()
    {
        if(currHP > 0)
        {
            currHP--;
        }
    }
}
