//Packages
using UnityEngine;
using UnityEngine.UI;
//For input
using UnityEngine.InputSystem;

public class mrSharpSpawner : MonoBehaviour
{
    //Shove the prefab inside
    public GameObject mrSharpVar;
    public Text scoreText; // Drag UI Text 
    public Text gameOverText; // More UI
    // public float spawnDelay; (Nope)
    
    private int score = 0; //score count
    public AudioClip spawnSound; // SOUND!!!!!

    private bool isGameOver = false; //bool if player hits sir sharp 
    // private float spawnTimer = 0f; (Works better without)
    private float soundTimer = 0f; // Timer for sound
    private AudioSource audioSource; //Main source

    void Start()
    {
        //Do not enable the game over text
        if (gameOverText != null)
            gameOverText.enabled = false;
        //Initialize the score number
        UpdateScoreText();
    }

    void Update()
    {
        //go back to default if game over
        if (isGameOver)
            return; // Stop

        //From tut, spawn cubes every frame, random color
            GameObject cubeGO = Instantiate<GameObject>(mrSharpVar);
            cubeGO.tag = "Cube"; //Fixing background issue
            Material mat = cubeGO.GetComponent<Renderer>().material;
            mat.color = Random.ColorHSV(0, 1, 0.5f, 1, 0.75f, 1);


            // Sound timer, every 0.5 seconds
            soundTimer += Time.deltaTime;
            if (soundTimer >= 0.5f)
            {
                if (spawnSound != null && audioSource != null)
                {
                    audioSource.PlayOneShot(spawnSound);
                }
                soundTimer = 0f; // Reset
            }
            
        // Check for clicks, idk google told me this
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            CheckClick();
        }
    }
    
    void CheckClick()
    {
        // finding mouse pos
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        //raycasting
        Ray ray = Camera.main.ScreenPointToRay(mousePosition);
        //declaring hit
        RaycastHit hit;
//fixing the wall issue
        if (Physics.Raycast(ray, out hit))
        {
            // Only game over if we hit a "Cube" tag, jesus christ
            if (hit.collider.CompareTag("Cube"))
            {
                Debug.Log("HIT!" + hit.collider.name);
                GameOver();
            }
            else
            {
                // Hit floor, still update score
                Debug.Log("MISS!");
                score++;
                UpdateScoreText();
            }
        }
        else //normal non-cube clicks, update score
        {
            Debug.Log("MISS!");
            score++;
            UpdateScoreText();
        }
    }


    void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score; //printing the number
    }

    void GameOver()
    {
        isGameOver = true;
        // display game over and final score
        if (gameOverText != null)
        {
            gameOverText.enabled = true;
            gameOverText.text = "GAME OVER!\nFinal Score: " + score;
        }
        //sending to log to make sure its working
        Debug.Log("Game Over! Final Score: " + score);
    }
}
