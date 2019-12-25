using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ScrollRectSnap : MonoBehaviour {

    public RectTransform panel;
    public Button[] buttons;
    public RectTransform center;
    public float[] distance;

    private bool dragging = false;
    private int buttonDistance;
    private int minButtonNum;
    private int ButtonLength;

    public void Start()
    {
        ButtonLength = buttons.Length;
        distance = new float[ButtonLength];

        var but1 = buttons[1].GetComponent<RectTransform>().anchoredPosition.x;
        var but2 = buttons[0].GetComponent<RectTransform>().anchoredPosition.x;
        buttonDistance = (int)Mathf.Abs(but1 - but2);
    }

    void Update()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            distance[i] = Mathf.Abs(center.GetComponent<RectTransform>().position.x - buttons[i].GetComponent<RectTransform>().position.x);
        }

        float minDistance = Mathf.Min(distance);

        for (int a = 0; a < buttons.Length; a++)
        {
            if (minDistance == distance[a])
            {
                minButtonNum = a;
            }
        }

        if (!dragging)
        {
            LerpToButton(minButtonNum * -buttonDistance);
        }
    }

    private void LerpToButton(int position)
    {
        float newX = Mathf.Lerp(panel.anchoredPosition.x, position, Time.fixedDeltaTime * 10f);
        Vector2 newPosition = new Vector2(newX, panel.anchoredPosition.y);
        panel.anchoredPosition = newPosition;
    }

    public void StartDrag()
    {
        dragging = true;
    }

    public void EndDrag()
    {
        dragging = false;
    }
}
