using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEndUI : MonoBehaviour
{

    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private Image crossfade;
    [SerializeField] private int nextLevelIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu.SetActive(false);
        crossfade.CrossFadeAlpha(0,1f,true);
    }

    private void OnEnable()
    {
        GameEvents.raceEnd += EnableGameOver;
        GameEvents.Quit += Quit;
        
    }
    
    private void OnDisable()
    {
        GameEvents.raceEnd -= EnableGameOver;
        GameEvents.Quit -= Quit;
    }
    
    private void EnableGameOver()
    {
        gameOverMenu.SetActive(true);
        
    }

    public void QuitButton()
    {
        GameEvents.CallQuit();
    }

    public void RestartLevel()
    {
        StartCoroutine(RestartCoroutine());
    }

    private IEnumerator RestartCoroutine()
    {
        crossfade.CrossFadeAlpha(1,1f,true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    private IEnumerator NextLevelCoroutine()
    {
        crossfade.CrossFadeAlpha(1,1f,true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(nextLevelIndex);
    }

    public void NextLevel()
    {
        StartCoroutine(NextLevelCoroutine());
        
    }

    public void Quit()
    {
        StartCoroutine(QuitCoroutine());
    }
    
    private IEnumerator QuitCoroutine()
    {
        crossfade.CrossFadeAlpha(1,1f,true);
        yield return new WaitForSeconds(1);
        Application.Quit();
    }
    
}
