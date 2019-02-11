using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVessels{

    void Move();

    void Attack();

    int GetX();

    int GetY();

    int GetWidth();

    int GetHeight();
    
}
