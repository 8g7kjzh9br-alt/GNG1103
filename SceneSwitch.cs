using UnityEngine; 
using Unity.UI; 
using UnityEngine.SceneManagement; 
 
public class SceneSwitch: MonoBehaviour 
{ 
    //function to switch from StartScene to NewScene 
    public void LoadNewScene() 
    { 
        SceneManager.LoadScene("WHMIS Scene"); 
    } 
    //function to switch from NewScene to StartScene 
    public void LoadStartScene() 
    { 
        SceneManager.LoadScene("beginButton"); 
    } 
}