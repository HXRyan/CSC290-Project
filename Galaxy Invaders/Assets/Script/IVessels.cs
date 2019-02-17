using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IVessels: MonoBehaviour{
    protected int x, y, width, length = 0;

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
