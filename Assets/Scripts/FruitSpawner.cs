using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject _fruitToSpawn;

    private void OnMouseDown()
    {
        Instantiate(_fruitToSpawn);
    }
}
