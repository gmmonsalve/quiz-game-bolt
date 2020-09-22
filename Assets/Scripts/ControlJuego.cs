using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ludiq;
using UnityAndroidBluetooth;

public class ControlJuego : MonoBehaviour
{
    BluetoothControl control;
    bool left = false;
    bool right = false;


    void Start()
    {
        control = BluetoothControl.Instance;    
    }

    public bool botonPresionado(string name){
        return control.GetButton(name).IsPressed;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
