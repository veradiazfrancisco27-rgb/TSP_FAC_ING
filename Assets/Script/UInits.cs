using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.AI;

public class UInits : MonoBehaviour
{
    //Variables de Control
    static int currentIndex = 0;

    //Variables de Objetos
    [SerializeField]
    public List<string> message;

    [SerializeField]
    public TextMeshProUGUI texts;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentIndex = 0;        
    }

    public void CycleText()
    {
        currentIndex = (currentIndex+1) % message.Count;
        UpddateText();
    }

    public void UpddateText()
    {
        if (message.Count >0 && texts != null)
        {
            texts.text = message[currentIndex];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
