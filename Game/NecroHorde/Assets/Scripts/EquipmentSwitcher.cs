using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSwitcher : MonoBehaviour {

    //Notes on equipment
    //1, 2 & 3 are Magic
    //4 is melee
    //F to toggle Torch
    //M to toggle Map

    public GameObject[] Equipments = new GameObject[4]; //stores the used equipment in an array

    //stores the equipment for different classes
    public GameObject[] FireEquipment = new GameObject[4];
    public GameObject[] LightningEquipment = new GameObject[4];
    public GameObject[] EarthEquipment = new GameObject[4];

    public ClassController ClassC; //stores the class controller for easy calling

    public GameObject Torch; //stores the torch
    public GameObject Map; //stores the map

    private void Start()
    {
        ClassC = FindObjectOfType<ClassController>();

        if(ClassC != null)
        {
            if(ClassC.ChosenClass == "Fire")
            {
                Equipments = FireEquipment;
            }
            if(ClassC.ChosenClass == "Lightning")
            {
                Equipments = LightningEquipment;
            }
            if(ClassC.ChosenClass == "Earth")
            {
                Equipments = EarthEquipment;
            }
        }

        foreach (GameObject Equipment in Equipments) //does the actions for each equipment
        {
            if (Equipment != null) //will activate if the equipment has something assigned
            Equipment.SetActive(false); //makes the equiment uninteractable
        }
    }

    public void UnequipAll()
    {
        foreach (GameObject Equipment in Equipments) //goes through all equipments
        {
            if (Equipment != null) //checks to see if the equipment is assiged
            {
                Equipment.SetActive(false); //deactivates the equipment
            }
        }
    }

    // Update is called once per frame
    void Update () {
        //Equip Magic 1
		if (Input.GetButtonDown("Slot 1") && Equipments[0] != null) //activates when 1 is pressed and the equipment is assigned
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
        if (Input.GetButtonDown("Slot 2") && Equipments[1] != null)
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
        if (Input.GetButtonDown("Slot 3") && Equipments[2] != null)
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
        if (Input.GetButtonDown("Slot 4") && Equipments[3] != null)
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
