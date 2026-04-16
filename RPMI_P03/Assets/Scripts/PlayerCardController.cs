using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerCardController : MonoBehaviour
{

    public AudioSource pickCardAS;
    public AudioSource dropCardAS;

    public GameObject combatController;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {

        GetComponent<SpriteRenderer>().sortingLayerName = "Selected Cards";
        GetComponent<BoxCollider2D>().enabled = false;
        if (!pickCardAS.isPlaying)
        {
            pickCardAS.pitch = Random.Range(0.95f, 1.05f);
            pickCardAS.Play();
        }
       

    }
    private void OnMouseDrag()
    {
        
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;
        transform.position = newPosition;

    }
    private void OnMouseUp()
    {
        GetComponent<BoxCollider2D>().enabled = true;
        GetComponent<SpriteRenderer>().sortingLayerName = "Default";

        if (!dropCardAS.isPlaying)
        {
            dropCardAS.pitch = Random.Range(0.95f, 1.05f);
            dropCardAS.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (!collision.gameObject.GetComponent<OppCardController>().inCombat)
        {
           GameObject cs = Instantiate(combatController, transform.position, Quaternion.identity);
            cs.GetComponent<CombatController>().playerCard = GetComponent<CardStatController>();
            cs.GetComponent<CombatController>().oppCard = GetComponent<CardStatController>();
        }

    }
}

