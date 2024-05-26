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

    IEnumerator DestroyDeathEffect()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Destroy(gameObject);
    }
}
