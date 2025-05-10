
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
   public GameObject PauseMenu;

   public void Pause()
   {
       PauseMenu.SetActive(true);
       Time.timeScale = 0;
   }

   public void UnPause()
   {
       PauseMenu.SetActive(false);
        Time.timeScale = 1;
   }

   
   public void Restart()
   {
       Time.timeScale = 1;
       SceneManager.LoadScene("RunAndDodge");
   }
}
