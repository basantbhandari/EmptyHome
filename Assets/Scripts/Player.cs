using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public GameObject restartButton;




    private void OnTriggerEnter2D(Collider2D collision)
    {
        restartButton.SetActive(true);
        Time.timeScale = 0;
    }



    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }





}
