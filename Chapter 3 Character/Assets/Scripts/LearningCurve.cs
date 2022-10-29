using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    /// <summary>
    /// Here we declare our variables that we are going to use.
    /// The string data type has been assigned to the names since they are characters.
    /// The int data type has been assigned to the level, since it is going to show a simple integer without decimals.
    /// Additionally, the names have the public access modifier on, which means that in Unity it can be changed.
    /// Therefore, the start level has been given a private access modifier, since it has been assigned an initial value and won't be changed. 
    /// </summary>
    public string FirstName = "John";
    public string LastName = "Doe";
    private int StartLevel = 1;
    
    
    // Start is called before the first frame update
    
    /// <summary>
    /// In our Start() Method, we are using the Debug.Log method to print out a written message, using our previous variables
    /// Beneath, we are calling the method "A Simple Message", which prints out its own message.
    /// </summary>
    void Start()
    {
        Debug.Log($"Hi, my name is {FirstName} {LastName}, and I'm on level {StartLevel}");
        ASimpleMessage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// In this method, we declare two different integers, which we are going to use in a new message
    /// The Start Level Integer adds the values of our previous integers, and is therefore assigned the value of them added together.
    /// The FirstName and LastName strings have been given a new value. Since it is in a separate method, it will be given the new value.
    /// As in the Start() Method, the Debug.Log method to print out a new message.
    /// </summary>
    public void ASimpleMessage()
    {
        int TheFirstLevel = 1;
        int AddedLevel = 6;
        StartLevel = TheFirstLevel + AddedLevel;
        FirstName = "Ada";
        LastName = "Lovelace";
        
        Debug.Log($"Hi, my name is {FirstName} {LastName} and I'm on level {StartLevel}");

    }
    
    
    
}
