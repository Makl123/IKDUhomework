using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 21;
    public int addedAge = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(21+1);
        // Debug.Log(currentAge+1);
        ComputeAge();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ComputeAge()
        /// <summary>
        /// Computes modified age
        /// </summary>
    {
        Debug.Log(currentAge+addedAge);
    }
    
}