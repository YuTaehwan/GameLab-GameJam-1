using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DeletableBlock : BlockBase, IDeletable
{
    private SpriteRenderer sr;

    private bool deletable;
    private Action<GameObject> onDeleteCallback;
    private Action<GameObject> onHoverCallback;
    private Action<GameObject> onExitHoverCallback;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        deletable = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetDeletable(bool deletable)
    {
        this.deletable = deletable;
    }

    public void SetOnDeleteCallback(Action<GameObject> callback)
    {
        onDeleteCallback = callback;
    }

    public void SetOnHoverCallback(Action<GameObject> callback)
    {
        onHoverCallback = callback;
    }

    public void SetOnExitHoverCallback(Action<GameObject> callback)
    {
        onExitHoverCallback = callback;
    }

    public void OnMouseDown()
    {
        Debug.Log("click");
        if (!EventSystem.current.IsPointerOverGameObject() && deletable)
        {
            onDeleteCallback(this.gameObject);
        }
    }

    public void OnMouseOver()
    {
        Debug.Log("hover");
        if (deletable)
            onHoverCallback(this.gameObject);
    }

    public void OnMouseExit()
    {
        Debug.Log("exit");
        onExitHoverCallback(this.gameObject);
    }
}
