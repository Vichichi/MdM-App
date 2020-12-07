using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadIntro : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(loadScene(5));
    }

    IEnumerator loadScene(float WaitSecs)
    {
        yield return new WaitForSeconds(WaitSecs);
        Application.LoadLevel(1);
    }
}
