using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Healthbar
{
    private Canvas _canvas;
    private Scrollbar _scrollbar;

    public Healthbar(Canvas canvas, Scrollbar scrollbar)
    {
        _canvas = canvas;
        _scrollbar = scrollbar;
    }
    
    public Scrollbar Scrollbar => _scrollbar;
}
