using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolBarImageManager : MonoBehaviour {

    ClassController ClassC;
    public Sprite[] EquipmentImages;
    public Sprite[] FireImages;
    public Sprite[] LightningImages;
    public Sprite[] EarthImages;

    public Image Primary;
    public Image Secondary;
    public Image Ultimate;
    public Image Melee;

	// Use this for initialization
	void Start () {
        if(FindObjectOfType<ClassController>())
        ClassC = FindObjectOfType<ClassController>();
	}
	
	// Update is called once per frame
	void Update () {
		if(ClassC != null)
        {
            if(ClassC.ChosenClass == "Fire")
            {
                EquipmentImages = FireImages;
            }
            if (ClassC.ChosenClass == "Lightning")
            {
                EquipmentImages = LightningImages;
            }
            if (ClassC.ChosenClass == "Earth")
            {
                EquipmentImages = EarthImages;
            }

            Primary.sprite = EquipmentImages[0];
            Secondary.sprite = EquipmentImages[1];
            Ultimate.sprite = EquipmentImages[2];
            Melee.sprite = EquipmentImages[3];
        }
	}
}
