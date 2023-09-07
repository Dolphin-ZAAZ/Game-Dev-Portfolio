using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstakillRune : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("SpawningSystem").GetComponent<Spawning>().downtimeTimer > 0f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            GameObject.Find("PlayerCharacter").GetComponent<PlayerBehaviour>().instaActive = true;
            Destroy(this.gameObject);
        }
    }
}
