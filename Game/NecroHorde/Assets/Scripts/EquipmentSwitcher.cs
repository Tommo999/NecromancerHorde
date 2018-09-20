using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSwitcher : MonoBehaviour {

    //Notes on equipment
    //1 & 2 is Magic
    //3 is Melee
    //4 is Potion or Thrown
    //F to toggle Torch
    //M to toggle Map

    public GameObject[] Equipments = new GameObject[4];

    public GameObject Torch;
    public GameObject Map;

    private void Start()
    {
        foreach (GameObject Equipment in Equipments)
        {
            if (Equipment != null)
            Equipment.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update () {
        //Equip Magic 1
		if (Input.GetKeyDown(KeyCode.Alpha1) && Equipments[0] != null)
        {
            foreach (GameObject Equipment in Equipments)
            {
                if (Equipment != null)
                {
                    Equipment.SetActive(false);
                }
            }
            Equipments[0].SetActive(true);
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

        //Equip Melee
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

        //Equip Thrown
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
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (Torch.activeSelf)
            {
                Torch.SetActive(false);
            }
            else
            {
                Torch.SetActive(true);
                Map.SetActive(false);
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
