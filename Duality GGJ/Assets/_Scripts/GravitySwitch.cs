using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



// this class is a bit messy... it controls gravity, changes scenes and controls camera....
// ideally this functionality should be in 3 classes, but I places them all in 1 since my behavious are simple.... 
public class GravitySwitch : MonoBehaviour
{

    public Transform player;
    public ParticleSystem up, down;
    public Color upColour, downColour;
    Color currentColour;

    private void Awake()
    {
        currentColour = downColour;
        Physics2D.gravity = new Vector2(0,-9.81f);
        
    }

    void Update()
    {
        CamControl();
        GravityControl();
        SceneControl();
    }

    void CamControl()
    {
        transform.position -= (transform.position - (player.position + new Vector3(0, 0, 0))) / .1f * Time.deltaTime;
        Camera.main.backgroundColor -= (Camera.main.backgroundColor - currentColour) / 10;
    }

    void GravityControl()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
        {
            if (Physics2D.gravity.y < 0) {

                up.Play(); //-- particles
                currentColour = upColour;

            }
            else {

                down.Play(); //-- particles
                currentColour = downColour;
            }

            Physics2D.gravity = -Physics2D.gravity;
        }

    }

    void SceneControl()
    {
        if (Input.GetButtonDown("Reset")) SceneManager.LoadScene(SceneManager.GetActiveScene().name);//reset current stage
        if (Input.GetButtonDown("Cancel")) SceneManager.LoadScene(0);// go back to menu
    }

}
