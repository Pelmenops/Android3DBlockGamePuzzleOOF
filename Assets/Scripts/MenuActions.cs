using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour
{
   public void StartGame(){ SceneManager.LoadScene("level1 1"); }

   public void BackToMenu(){ SceneManager.LoadScene("start"); }

   public void Levels(){ SceneManager.LoadScene("levels"); }

   public void ChooseLvL(int x){  SceneManager.LoadScene(x); }


    public void Exit()
   { Debug.Log("Exit Game Now!");
   Application.Quit(); }

   public void RestartLvL(){ SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }

   
}

