using System.Collections;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public CardStatController playerCard;
    public CardStatController oppCard;

    public Transform PlayerPos;
    public Transform oppPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CardLocate();

        if (playerCard.GetAttack() >= oppCard.GetAttack())
        {
            StartCoroutine (PlayerAttack());
        }
        else
        {
            StartCoroutine (OppAttack());
        }
    }

    private void CardLocate()
    {
        playerCard.transform.parent = PlayerPos;
        playerCard.transform.localPosition = Vector3.zero;
        oppCard.transform.parent = oppPos;
        oppCard.transform.localPosition = Vector3.zero;
    }

    private IEnumerator PlayerAttack()
    {
        yield return new WaitForSeconds(1);
        Destroy(oppCard.gameObject);
    }

    private IEnumerator OppAttack()
    {
        yield return new WaitForSeconds(1);
        Destroy(playerCard.gameObject);
    }

}
