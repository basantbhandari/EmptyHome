using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowToPlayer : MonoBehaviour
{



    public GameObject player;
    private Transform  playerTransform;
    // Start is called before the first frame update
    void Start()
    {

        playerTransform = player.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        //current camera position
        Vector3 temp = transform.position;
        temp.x = playerTransform.position.x + 1;
        transform.position = temp;

        
    }






}
