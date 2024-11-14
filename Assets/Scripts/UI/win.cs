using UnityEngine;
using UnityEngine.SceneManagement;
public class win : MonoBehaviour
{
    [SerializeField] private GameObject WIN;

    private bool isWIN = false;

    void Start()
    {
        WIN.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D c)
    {   
        if (c.gameObject.CompareTag("Player")){
            WINNING();
        }
    }

    private void WINNING()
    {
        WIN.SetActive(true);
        Time.timeScale = 0f; 
        isWIN = true;
    }

    public void MainLagi()
    {
        SceneManager.LoadScene("Game");
        WIN.SetActive(false);
        Time.timeScale = 1f; 
        isWIN = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }


}
