using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextscenebutton : MonoBehaviour
{
    public int levelGenerate;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        levelGenerate = Random.Range(3,10);
        SceneManager.LoadScene(levelGenerate);
        Destroy(other.gameObject);
        Debug.Log("OnTriggerEnter");
        Debug.Log(other.gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
        Debug.Log(collision.collider.gameObject);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("OnControllerColliderHit");
    }
}