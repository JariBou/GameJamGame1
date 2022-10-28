using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class PerlinCreator : MonoBehaviour
{
    public int size = 256;
    public int seed = -1;


    private void Awake()
    {
        if (seed == -1)
        {
            seed = Random.Range(-10000, 10000);
        }
        createPerlin();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static float[,] perlin;

    void createPerlin()
    {
        perlin = new float[size,size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                perlin[i, j] = Random.Range(0f, 1f);
            }
        }
        
    }

}
