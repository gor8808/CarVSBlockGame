using UnityEngine;
using System;
public class GameManagerForCubes : MonoBehaviour
{
    public Transform Player;
    GameObject[] _cubes;
    float _randomNumberX;
    float _randomNumberZ;
    void Start()
    {
        _cubes = Resources.LoadAll<GameObject>("Obsticales");
        GenCubes();

    }
    void FixedUpdate()
    {
        int cordinateZ = Convert.ToInt32(Player.position.z);
        if(cordinateZ % 200 == 0)
        {
            Debug.Log(cordinateZ);
        }
        //Debug.Log(Player.position.z);
    }
    void GenCubes()
    {
        for (int i = 0; i < 40; i++)
        {

            _randomNumberX = UnityEngine.Random.Range(-6.22f, 7.253f);
            _randomNumberZ = UnityEngine.Random.Range(5f, 300f);
            Vector3 position = new Vector3(_randomNumberX, 1f, _randomNumberZ);
            Instantiate(_cubes[0], position, Quaternion.identity);
        }
    }
}
