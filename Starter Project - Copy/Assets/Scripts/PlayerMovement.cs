using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 8f;

    public AudioSource engineSound;
    // Start is called before the first frame update
    void Start()
    {
        engineSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 leftRight = new Vector3(horizontalInput, 0f, 0f);
        transform.position += leftRight * playerSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            engineSound.Play();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            engineSound.Play();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            engineSound.Play();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            engineSound.Play();
        }
    }

     private void OnTriggerEnter2D(Collider2D hitting)
    {
        if(hitting.tag == "Asteroid")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
    
}
