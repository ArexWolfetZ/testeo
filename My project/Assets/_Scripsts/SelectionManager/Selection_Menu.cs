using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Selection_Menu : MonoBehaviour
{
    [Header("UI")]
    public Image carImage;
    public TextMeshProUGUI carName;
    public Scrollbar speedScrollbar;
    public Scrollbar brakeScrollbar;
    public Scrollbar angleScrollbar;

    [Header("Cars")]
    public CamMovement2 cam;
    public CarSo[] cars;
    private int index;
    private CarSo selectedCar;

    private float maxScrollbar = 2000;
    private float maxScrollbarAngle = 60;

    public Transform starPos;



    void Start()
    {
        index = 0;
        selectedCar = cars[index];
        UptateUI();
    }
    //Metodo oara actualizar el Ui
    public void UptateUI()
    {
        carImage.sprite = selectedCar.carImage;
        carName.text = selectedCar.carName;
        speedScrollbar.size = selectedCar.speed / maxScrollbar;
        brakeScrollbar.size = selectedCar.brake / maxScrollbar;
        angleScrollbar.size = selectedCar.angle / maxScrollbarAngle;
    }

    //cambio de derecha a izquierda
    public void ChangeCharacter(bool isButtonRight)
    {
        if(isButtonRight)
        {
            index=(index+1)%cars.Length;
            UptateUI();
        }
        else
        {
            index = (index - 1 + cars.Length) % cars.Length;
            UptateUI();
        }
        selectedCar = cars[index];
        
    }
    //Metodo de seleccion
    public void SelectCar()
    {
        GameObject prefabSelected = Instantiate(selectedCar.carPrefab, starPos.position, Quaternion.identity);
        cam.target = prefabSelected.transform;
    }
}
