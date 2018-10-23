using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSwitcher : MonoBehaviour {

    //Notes on equipment
    //1, 2 & 3 are Magic
    //4 is melee
    //F to toggle Torch
    //M to toggle Map

    public GameObject[] Equipments = new GameObject[4]; //stores the different equipment in an array

    public GameObject Torch; //stores the torch
    public GameObject Map; //stores the map

    private void Start()
    {
        foreach (GameObject Equipment in Equipments) //does the actions for each equipment
        {
            if (Equipment != null) //will activate if the equipment has something assigned
            Equipment.SetActive(false); //makes the equiment uninteractable
        }
    }

    // Update is called once per frame
    void Update () {
        //Equip Magic 1
		if (Input.GetKeyDown(KeyCode.Alpha1) && Equipments[0] != null) //activates when 1 is pressed and the equipment is assigned
        {
            foreach (GameObject Equipment in Equipments) //goes through all equipments
            {
                if (Equipment != null) //checks to see if the equipment is assiged
                {
                    Equipment.SetActive(false); //deactivates the equipment
                }
            }
            Equipments[0].SetActive(true); //activates the desired equipment
        }

        //Equip Magic 2
        if (Input.GetKeyDown(KeyCode.Alpha2) && Equipments[1] != null)
        {
            foreach (GameObject Equipment in Equipments)
            {
                if (Equipment != null)
                {
                    Equipment.SetActive(false);
                }
            }
            Equipments[1].SetActive(true);
        }

        //Equip Magic 3
        if (Input.GetKeyDown(KeyCode.Alpha3) && Equipments[2] != null)
        {
            foreach (GameObject Equipment in Equipments)
            {
                if (Equipment != null)
                {
                    Equipment.SetActive(false);
                }
            }
            Equipments[2].SetActive(true);
        }

        //Equip Melee
        if (Input.GetKeyDown(KeyCode.Alpha4) && Equipments[3] != null)
        {
            foreach (GameObject Equipment in Equipments)
            {
                if (Equipment != null)
                {
                    Equipment.SetActive(false);
                }
            }
            Equipments[3].SetActive(true);
        }

        //Extra Equipment
        //None can be active at same time

        //Torch
        if(Input.GetKeyDown(KeyCode.F)) //activates if 'F' is pressed
        {
            if (Torch.activeSelf) //activates if the torch is already active
            {
                Torch.SetActive(false); //deactivates the torch
            }
            else //activates if the torch is not active
            {
                Torch.SetActive(true); //activates the torch
                Map.SetActive(false); //deactivates the map
            }
        }

        //Map
        if(Input.GetKeyDown(KeyCode.M))
        {
            if (Map.activeSelf)
            {
                Map.SetActive(false);
            }
            else
            {
                Map.SetActive(true);
                Torch.SetActive(false);
            }
        }
    }
}
