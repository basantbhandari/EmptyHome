using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public Transform enamyTree;
    public Transform enamyTree180;
    public Transform destination;

    private const float ENAMY_WIDTH = 0.2673f;
    private const float ENAMY_HEIGHT_MIN = 0.25f;
    private const float ENAMY_HEIGHT_MAX = 0.45f;

    private const float ENAMY_Y_POSITION_MIN = -5f;
    private const float ENAMY_Y_POSITION_MAX = 5f;

    private const float CAMERA_ORTHO_SIZE = 5f;
    private void Start()
    {
        for (int i =  1; i <=500; i++ ) {

            float rand_y_position = Random.Range(ENAMY_Y_POSITION_MIN, ENAMY_Y_POSITION_MAX);
            float rand_enamy_height = Random.Range(ENAMY_HEIGHT_MIN, ENAMY_HEIGHT_MAX);


            if ((i % 2) == 0)
            {

                CreateEnamy(rand_enamy_height, 9*i, rand_y_position, false);
            }
            else {

                CreateEnamy(rand_enamy_height, 9*i, rand_y_position, true);

            }

            if (i == 500) {


                Transform dest = Instantiate(destination);
                dest.position = new Vector3(5* i + 5, 0);

            }



        }




        

    }


    private void CreateEnamy(float height, float xPosition , float yPosition, bool isInverted ) {

        if (isInverted)
        {

            Transform enamy = Instantiate(enamyTree180);
            enamy.position = new Vector3(xPosition, yPosition);


            SpriteRenderer enamySpriteRenderer = enamy.GetComponent<SpriteRenderer>();
            enamySpriteRenderer.size = new Vector2(ENAMY_WIDTH, height);

        }
        else
        {
            Transform enamy = Instantiate(enamyTree);
            enamy.position = new Vector3(xPosition, yPosition);


            SpriteRenderer enamySpriteRenderer = enamy.GetComponent<SpriteRenderer>();
            enamySpriteRenderer.size = new Vector2(ENAMY_WIDTH, height);
        }






    }


}
