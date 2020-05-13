using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamaManager : MonoBehaviour
{

    public GameObject winningMessage;
  



    private void OnCollisionEnter2D(Collision2D collision)
    {
        winningMessage.SetActive(true);
        Time.timeScale = 0;
    }

    public void  Retry() {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");

    }




}
