using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vessels: MonoBehaviour{
    protected int x, y, width, length = 0;

    public Sprite Vessel;
    public Sprite HealthBarSprite;

    void Move() {
    }

    void Attack()
    {

    }

    int GetX()
    {
        return this.x;
    }

    int GetY()
    {
        return this.y;
    }

    int GetWidth()
    {
        return this.width;
    }

    int GetLength()
    {
        return this.length;
    }
    
}
