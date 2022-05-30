using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    
    public static GameManager Instance { get; set; }
   
    private void Awake()
    {

        SingletonThisGameObject();
        
    }
     void SingletonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void IncreaseScore()
    {
        
       
    }
    
    public void RestartGame()
    {
        StartCoroutine(RestartGameAsync());
    }
    private IEnumerator RestartGameAsync()
    {
        yield return SceneManager.LoadSceneAsync("GameScene");
    }
    
}
