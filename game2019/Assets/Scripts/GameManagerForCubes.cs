using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerForCubes : MonoBehaviour
{
    GameObject[] _cubes;
    float _randomNumber;
    void Start()
    {
        _cubes = Resources.LoadAll<GameObject>("Obsticales");
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < 3; i++)
            {
                _randomNumber = Random.Range(-4.5f, 4.5f);
                Vector3 position= new Vector3(_randomNumber,1f, 5.75f);
                Instantiate(_cubes[0],position, Quaternion.identity);
            }

        }
    }
}
