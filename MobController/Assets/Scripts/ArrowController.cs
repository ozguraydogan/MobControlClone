using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ArrowController : MonoBehaviour
{
    [Header("Swap")]
    private Vector3 firsPosition;
    private Vector3 lastPosition;
    private float move;
    [Header("Swerve")]
    public float swerveSpeed;
    [SerializeField] private float amount=0.9f;
    
    private bool isTrue;

    private Vector3 clamp;
    
    public Transform cubeRoot;
    
    // asker
    [SerializeField] private GameObject soldier;
    //[SerializeField] private Transform firePoint;

    
    private void Start()
    {
       // Camera.main.transform.parent = cubeRoot.transform;
    }

    private void Update()
    {
        
        #region Swap

        if (Input.GetMouseButtonDown(0))
        {
            firsPosition=Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
        
        else if (Input.GetMouseButton(0))
        {

            lastPosition= Camera.main.ScreenToViewportPoint(Input.mousePosition);
            move = lastPosition.x - firsPosition.x;
        }
        
        else if (Input.GetMouseButtonUp(0))
        {
            move = 0;
        }
        #endregion
    }

    private void FixedUpdate()
    {
        #region Move
        float swerveAmount = Time.deltaTime * swerveSpeed * move;
        clamp = cubeRoot.localPosition;
        clamp.x += swerveAmount;
        clamp.x = Mathf.Clamp(clamp.x, -amount, amount);
        cubeRoot.localPosition = clamp;
        #endregion
        
        
    }
}
