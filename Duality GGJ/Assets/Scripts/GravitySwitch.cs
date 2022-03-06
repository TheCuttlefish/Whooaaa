using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GravitySwitch : MonoBehaviour
{

    public Transform player;
    public ParticleSystem up, down;
    // Start is called before the first frame update
    public Color upColour, downColour;
    Color currentColour;
    private void Awake()
    {
        currentColour = downColour;
        Physics2D.gravity = new Vector2(0,-9.81f);
        
    }

    // cam pos was in late update

        // Update is called once per frame
        void Update()
    {
        transform.position -= (transform.position - (player.position + new Vector3(0, 0, 0))) / .1f * Time.deltaTime;
        Camera.main.backgroundColor -= (Camera.main.backgroundColor - currentColour) / 10;

        if (Input.GetButtonDown("Reset"))
        {
          
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetButtonDown("Cancel"))
        {
            SceneManager.LoadScene(0);
        }



        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
        {
            if (Physics2D.gravity.y < 0) {

                up.Play();
                currentColour = upColour;

            }
            else {


                down.Play();
                currentColour = downColour;
            }

            Physics2D.gravity = -Physics2D.gravity;
        }
    }
}
