using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBorderScript : MonoBehaviour {

    public Transform[] SideImagesPos = new Transform[4];
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1) && SideImagesPos[0] != null)
        {
            this.transform.position = SideImagesPos[0].position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && SideImagesPos[1] != null)
        {
            this.transform.position = SideImagesPos[1].position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && SideImagesPos[2] != null)
        {
            this.transform.position = SideImagesPos[2].position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && SideImagesPos[3] != null)
        {
            this.transform.position = SideImagesPos[3].position;
        }
    }
}
