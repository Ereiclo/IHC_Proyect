using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToggleNavLabel : MonoBehaviour
{
    [SerializeField]
    public Button b1;
    [SerializeField]
    public TextMeshProUGUI b1text;
    private bool textState = false;

    void Start()
    {
        b1text = b1.GetComponentInChildren<TextMeshProUGUI>();
        btnSetOff();
    }

    public void btnToggle() {
        textState = !textState;
        if (textState)
        {
            btnSetOn();
        }
        else { 
            btnSetOff();
        }
    }

    public void btnSetOn()
    {
        b1text.text = "Desactivar\nNavegación";
    }

    public void btnSetOff()
    {
        b1text.text = "Activar\nNavegación";
    }
}