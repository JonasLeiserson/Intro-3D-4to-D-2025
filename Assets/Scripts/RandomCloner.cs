using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCloner : MonoBehaviour
{
    public int randomNumber;
    public int min;
    public int max;

    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;

    public void CloneRandom()
    {
        randomNumber = Random.Range(min,max + 1);
        GameObject clone = prefab1;
        if (randomNumber == 0)
        {
            clone = prefab1;
        }
        else if (randomNumber == 1)
        {
            clone = prefab2;
        }
        else if (randomNumber == 2)
        {
            clone = prefab3;
        }

        Instantiate(clone);

    }
}
