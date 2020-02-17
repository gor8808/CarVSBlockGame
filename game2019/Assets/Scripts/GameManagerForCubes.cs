using UnityEngine;
using System;
public class GameManagerForCubes : MonoBehaviour
{
    public Transform Player;
    public Transform Ground;
    public Rigidbody Rb;
    public Vector3 GroundOffset;
    GameObject[] _sideWalks;
    GameObject[] _cubes;
    GameObject[] _cubesPrefab;
    int _difficultyIndex = Menu.DifficultyIndex;
    float _randomNumberX;
    float _randomNumberZ;
    float _randomNumberY;
    int _count = 10;
    int _lastCordinate = 200;
    float _beforeGen = 50f;
    int _countAdd = 10;
    int _maxCubesCount = 40;


    int n = 1;
    void Start()
    {
        _cubesPrefab = Resources.LoadAll<GameObject>("Obsticales");
        _sideWalks = GameObject.FindGameObjectsWithTag("SideWalk");
        GenCubes(Player.transform.position.z + 10, 200, 10);
        switch (_difficultyIndex)
        {
            case 0:
                for (int i = 0; i < _sideWalks.Length; i++)
                {
                    _sideWalks[i].transform.position =
                        new Vector3(
                            _sideWalks[i].transform.position.x,
                            0.7f,
                            _sideWalks[i].transform.position.z
                        );
                }
                _beforeGen = 20f;
                _countAdd = 5;
                _maxCubesCount = 20;
                break;
            case 1:
                for (int i = 0; i < _sideWalks.Length; i++)
                {
                    _sideWalks[i].transform.position =
                        new Vector3(
                            _sideWalks[i].transform.position.x,
                            0.5f,
                            _sideWalks[i].transform.position.z
                        );
                }
                _beforeGen = 20f;
                _countAdd = 7;
                _maxCubesCount = 25;
                break;
            case 2:
                for (int i = 0; i < _sideWalks.Length; i++)
                {
                    Destroy(_sideWalks[i]);
                }
                _beforeGen = 20f;
                _countAdd = 10;
                _maxCubesCount = 35;
                break;
        }
    }
    void FixedUpdate()
    {
        Ground.transform.position =
           new Vector3(
           Ground.transform.position.x,
           Ground.transform.position.y,
           Player.transform.position.z - GroundOffset.z
        );
        int cordinateZ = Convert.ToInt32(Player.position.z);
        if (n % 2 == 0) 
            PlayerMovement.MovementSpeed = 5f;
        else
            PlayerMovement.MovementSpeed = 800f;
        if (cordinateZ > _lastCordinate * n)
        {   
            _cubes = GameObject.FindGameObjectsWithTag("Obstacle");
            Debug.Log($"Destroying {_cubes.Length} obstacles");
            for (int i = 0; i < _cubes.Length - _count; i++)
            {
                Destroy(_cubes[i]);
            }
            if (_count > _maxCubesCount)
                _count = _countAdd;
            GenCubes((_lastCordinate * n) + _beforeGen, ((n + 1) * 200f) + _beforeGen, _count += _countAdd);
            n++;
        }
    }
    void GenCubes(float start,float end,int count)
    {
        for (int i = 0; i < count; i++)
        {
            _randomNumberX = UnityEngine.Random.Range(-7f, 8f);
            _randomNumberY = UnityEngine.Random.Range(10f, 30f);
            _randomNumberZ = UnityEngine.Random.Range(start, end);
            Vector3 position = new Vector3(_randomNumberX, _randomNumberY, _randomNumberZ);
            Instantiate(_cubesPrefab[0], position, Quaternion.identity);
        }
    }
}
