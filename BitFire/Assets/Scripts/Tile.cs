using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {
    
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Z { get; private set; }

    public Tile(int _x,int _y, int _z){

        X = _x;
        Y = _y;
        Z = _z;
    }



}
