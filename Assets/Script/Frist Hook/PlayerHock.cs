using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHock : MonoBehaviour
{
    public LineRenderer line;
    public Transform hook;
    public Vector2 mousedir;

    public bool isHookActive;
    public bool isLineMax;
    public bool isAttach;

    private void Start()
    {
        line.positionCount = 2;
        line.endWidth = line.startWidth = 0.15f;
        line.SetPosition(0, transform.position);
        line.SetPosition(1, hook.position);
        line.useWorldSpace = true;
        isAttach = false;
    }

    private void Update()
    {
        line.SetPosition(0, transform.position);
        line.SetPosition(1, hook.position);
        if (Input.GetMouseButtonDown(0))
        {
            hook.position = transform.position;
            mousedir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            isHookActive = true;
            isLineMax = false;
            hook.gameObject.SetActive(true);
        }

        if (isHookActive && !isLineMax && !isAttach)
        {
            hook.Translate(mousedir.normalized * Time.deltaTime * 15);

            if(Vector2.Distance(transform.position, hook.position) > 5)
            {
                isLineMax = true;
            }
        }
        else if (isHookActive && isLineMax && !isAttach)
        {
            hook.position = Vector2.MoveTowards(hook.position, transform.position, Time.deltaTime * 15);
            if(Vector2.Distance(transform.position, hook.position) < 0.1f)
            {
                isHookActive = false;
                isLineMax = false;
                hook.gameObject.SetActive(false);
            }
        }
        else if (isAttach)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isAttach = false;
                isHookActive = false;
                isLineMax = false;
                hook.GetComponent<Hooking>().joint2D.enabled = false;
                hook.gameObject.SetActive(false);
            }
            
        }
    }
}
