using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles :MonoBehaviour
{
    protected Transform protectile;
    protected int x, y, width, length = 0;
    int GetX()
    {
        return this.x;
    }

    int GetY()
    {
        return this.y;
    }

    int GetWidth() {
        return this.width;
    }
   

    int GetLength()
    {
        return this.length;
    }

}

