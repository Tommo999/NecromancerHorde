using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBorderScript : MonoBehaviour {

    public Transform[] SideImagesPos = new Transform[4]; //stores the different positions for the square
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Slot 1") && SideImagesPos[0] != null)
        {
            this.transform.position = SideImagesPos[0].position;
        }
        if (Input.GetButton("Slot 2") && SideImagesPos[1] != null)
        {
            this.transform.position = SideImagesPos[1].position;
        }
        if (Input.GetButton("Slot 3") && SideImagesPos[2] != null)
        {
            this.transform.position = SideImagesPos[2].position;
        }
        if (Input.GetButton("Slot 4") && SideImagesPos[3] != null)
        {
            this.transform.position = SideImagesPos[3].position;
        }

        //You press the button and if the position exists
        //sets the border to the correct position

    }
}
