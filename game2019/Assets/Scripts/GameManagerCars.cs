using System;
using System.Linq;
using UnityEngine;
// TODO:y position correct;
public class GameManagerCars : MonoBehaviour
{
    public GameObject Parent;
    public string CarName = string.Empty;

    private GameObject[] _loadedCarsArr;
    private GameObject[] _loadedCarsObjectArr;
    private int _showCarIndex = Menu.ShowCarIndex;
    private GameObject _institateCar;

    private void Start()
    {
        try
        {
            _loadedCarsObjectArr = Resources.LoadAll<GameObject>("MainPlayer");     //Assests/Resources/MainPlayer
            for (int i = 0; i < _loadedCarsObjectArr.Length; i++)
            {
                Cars Car = new Cars();
                Car.SetIdAndName(_loadedCarsObjectArr[i].name);
                Debug.Log($"ID -- {Car.ID}, Name -- {Car.Name}");
                if(_showCarIndex == Car.ID)
                {
                    Instantiate(_loadedCarsObjectArr[i], Parent.transform);
                    return;
                }

            }
        }
        catch (Exception e)
        {
            Debug.Log("Failed with the following exception: ");
            Debug.Log(e);
        }
    }
}