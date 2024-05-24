using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEffectDestruction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyDeathEffect());     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DestroyDeathEffect()
    {
        yield return new WaitForSeconds(3f);

        Destroy(gameObject);
    }
}
