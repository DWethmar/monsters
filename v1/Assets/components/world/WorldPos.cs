using UnityEngine;
using System.Collections;
using System;

[Serializable]
public struct WorldPosition
{
    public static int worldMinSize = 8;
    public static int worldMaxSize = 8;

    public int x, y, z;

    public WorldPosition(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override bool Equals(object obj)
    {
        if (GetHashCode() == obj.GetHashCode())
            return true;
        return false;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = Chunk.chunkSize * 3;

            hash = hash * worldMinSize * worldMaxSize + x.GetHashCode();
            hash = hash * worldMinSize * worldMaxSize + y.GetHashCode();
            hash = hash * worldMinSize * worldMaxSize + z.GetHashCode();

            return hash;
        }
    }
}