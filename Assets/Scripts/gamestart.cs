using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gamestart : MonoBehaviour
{
    public void GameStartBtn(){
      SceneManager.LoadScene("Clicker");
    }
}
