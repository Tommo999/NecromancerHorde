using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthquakeArmor : MonoBehaviour {

    UnityStandardAssets.Characters.FirstPerson.FirstPersonController FPC;
    Earthquake EQ;

    public float Damage = 100;

	// Use this for initialization
	void Start () {
        FPC = FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
        EQ = FindObjectOfType<Earthquake>();
	}

    private void OnEnable()
    {
        StartCoroutine("Reset");
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(10);
        FPC.m_RunSpeed /= EQ.SpeedMultiplier;
        FPC.m_WalkSpeed /= EQ.SpeedMultiplier;
        gameObject.SetActive(false);
        EQ.PH.maxhealth /= EQ.HealthMultiplier;
        EQ.PH.health = EQ.PH.maxhealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<EnemyHealth>() != null && Input.GetAxis("Vertical") > 0.5f)
        {
            other.GetComponent<EnemyHealth>().Health -= Damage;
            PlayerPrefs.SetFloat("UltimateDamage", PlayerPrefs.GetFloat("UltimateDamage") + Damage);
        }
    }
}
