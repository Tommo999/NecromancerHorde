using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeusBeam : MonoBehaviour {

    public float Damage = 500;

    private void OnEnable()
    {
        StartCoroutine("Disable");
    }

    IEnumerator Disable()
    {
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.GetComponent<EnemyHealth>())
        {
            other.gameObject.GetComponent<EnemyHealth>().Health -= Damage * Time.deltaTime;
                PlayerPrefs.SetFloat("UltimateDamage", PlayerPrefs.GetFloat("UltimateDamage") + Damage * Time.deltaTime);
        }
    }
}