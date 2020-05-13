using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathCreater : MonoBehaviour
{


    public GameObject pathPrefabs;

     pathscript activeLine;
    




    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) {
            GameObject lineGo =    Instantiate(pathPrefabs);
            activeLine = lineGo.GetComponent<pathscript>();
        }

        if (Input.GetMouseButtonUp(0)) {

            activeLine = null;

        }




        if (activeLine != null) {

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePos);
        }
        
    }
}
