using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkCreator : MonoBehaviour
{
    public GameObject block;

    public int size;
    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                float perlinValue = PerlinCreator.perlin[i, j];
                Color colorValue = perlinValue > 0.2f ? Color.white : Color.black;
                GameObject prefab = Instantiate(block, new Vector3(i*4, j*4, 0), Quaternion.identity);
                prefab.GetComponent<SpriteRenderer>().color = colorValue;
                if (perlinValue < 0.1f)
                {
                }

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
