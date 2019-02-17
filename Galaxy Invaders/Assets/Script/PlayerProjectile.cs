using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : IProjectiles{
    

    public PlayerProjectile(int x, int y, int width, int length)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.length = length;
    }

}
   