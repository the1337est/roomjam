using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{

    public static Vector3 ToWhole(this Vector3 obj)
    {
        int x = (int)obj.x;
        int y = (int)obj.y;
        int z = (int)obj.z;
        Vector3 vec = new Vector3((float)x, (float)y, (float)z);
        return vec;
    }

}
