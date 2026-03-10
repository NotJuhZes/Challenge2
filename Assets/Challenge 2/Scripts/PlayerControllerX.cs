using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool atiracao = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && atiracao == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            atiracao = false;
            Invoke("tiracao", 1);

        }
    }
    void tiracao()
    {
        atiracao = true;
    }
}
