using UnityEngine;

public class TerrainGen
{
    public Chunk ChunkGen(Chunk chunk)
    {
        for (int x = chunk.worldPosition.x; x < chunk.worldPosition.x + Chunk.chunkSize; x++)
        {
            for (int z = chunk.worldPosition.z; z < chunk.worldPosition.z + Chunk.chunkSize; z++)
            {
                chunk.SetBlock(x - chunk.worldPosition.x, 0, z - chunk.worldPosition.z, new Block());
            }
        }
        return chunk;
    }
}