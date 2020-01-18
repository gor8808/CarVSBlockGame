using UnityEngine;
using UnityEngine.UI;
public class CarShow : MonoBehaviour
{
    public Dropdown Dropdown;
    public GameObject Parent;
    public GameObject Range;
    public ColorPicker Picker;
    Material[] _material;
    GameObject[] _loadedCarsObjectArr;
    GameObject _instantiateCar;
    Color _color;
    void Start()
    {
        _loadedCarsObjectArr = Resources.LoadAll<GameObject>("PlayerCarShow");     //Assests/Resources/PlayerNew
        _material = Resources.LoadAll<Material>("PlayerMaterial");
    }
    void Update()
    {
        Picker.onValueChanged.AddListener(color =>
        {
            _material[0].color = color;
            _color = color;
        });

        _material[0].color = Picker.CurrentColor;

        Picker.CurrentColor = _color;
    }
    public void OnCarChange()
    {
        Range.SetActive(false);

        if(_instantiateCar != null)
        {
            Destroy(_instantiateCar);
        }
        Debug.Log($"{Dropdown.value}");
        for (int i = 0; i < _loadedCarsObjectArr.Length; i++)
        {
            Cars Car = new Cars();
            Car.SetIdAndName(_loadedCarsObjectArr[i].name);
            Debug.Log($"ID -- {Car.ID}, Name -- {Car.Name}");
            if (Dropdown.value == Car.ID)
            {
                _instantiateCar = Instantiate(_loadedCarsObjectArr[i], Parent.transform);
                return;
            }

        }
    }
    public void CarWithRandomColors()
    {
        Color color = RandomColor();
        _material[0].color = color;
        _color = color;
    }
    Color RandomColor()
        => new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
}
