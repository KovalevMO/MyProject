using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHPtoken : MonoBehaviour

{
    [SerializeField] private float Heal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var hc = other.GetComponent<HealthController>();
            hc.CurrentHealth += Heal;
            Debug.Log(hc.CurrentHealth);
            Destroy(gameObject);
        }
    }
}
