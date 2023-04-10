using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// rian256
// Script to show you just got possessed using a canvas and an GameObject as a trigger
public class PossessedTrigger : MonoBehaviour
{
    public GameObject PossessCanvas;

    void OnTriggerEnter(Collider player) {
        if (player.tag == "Player")
        {
            StartCoroutine(GetPossessed());
            Debug.Log("You just got Possessed");
        }
    }

    IEnumerator GetPossessed() 
    {
        yield return new WaitForSeconds(3);
        PossessCanvas.SetActive(true);
    }


    void OnTriggerExit(Collider player)
    {
        StartCoroutine(endPossessed());
    }

    IEnumerator endPossessed()
    {
        yield return new WaitForSeconds(5);
        PossessCanvas.SetActive(false);
        Destroy(gameObject);
        Debug.Log("Released");
    }

}
