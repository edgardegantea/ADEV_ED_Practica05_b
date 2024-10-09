using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;

public class ArrayCubos : MonoBehaviour
{

    public GameObject cubePrefab;
    public int numeroDeCubos = 10;
    private GameObject[] cubos;
    

    void Start()
    {
        cubos = new GameObject[numeroDeCubos];

        for (int i = 0; i < numeroDeCubos; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            GameObject cubo = Instantiate(cubePrefab, randomPosition, Quaternion.identity);
            cubos[i] = cubo;
        }
    }


    void Update()
    {
        for (int i = 0; i < cubos.Length; i++)
        {
            if (cubos[i] == null)
            {
                float moveY = Mathf.Sin(Time.time * 2) * 2f;
                cubos[i].transform.position += new Vector3(0, moveY * Time.deltaTime, 0);
            }
        }
    }
}
