using UnityEngine;
using System.Collections;

public class Question15_RandomButtonPos : MonoBehaviour {

    private RectTransform rect;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    public void RandomPosition()
    {
        rect.position = new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), 0);
    }
}