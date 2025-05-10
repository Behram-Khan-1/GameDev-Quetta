using Unity.VisualScripting;
using UnityEngine;
public class Tutorial : MonoBehaviour
{
    // 1 2 3 4 5 6 7 8 integer number
    
    // 1.1 2.2 3.3 4.4 5.6 9.8 3.14 decimal number/ float number

    // BehramKhan  textual data / string data

    // true, false // boolean data, bool, 1, 0 

    int Num1 = 5;
    int Num3 = 6;
    float Num2 = 1.1f;
    string Name = " Behram ";
    bool isAlive = true; //1 or 0

    void Awake()
    {
        
    }

    //Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log(Num1);
        Debug.Log(Num2);
        Debug.Log(Name);
        Debug.Log(isAlive);

        if(Num2 > Num1)
        {
            Debug.Log("Num1 is greater than Num2");
        }
        else
        {
            Debug.Log("Num2 is greater than Num1");
        }

        int sum = Num1 + Num3;
        int mul = Num1 * Num3;
        int division = Num1 / Num3;
        // int sum = Num1 - Num3;
    }

    // This is a comment
    
     // afddasdfasdf ffffffffffffffff
     // asaaaaaaaaaaaaaaaaaaa
     // aaaaaaaaaaaaaaaaaaaaaaaaaaaa

     /*
     This is a multiLine Comment
     */

    // Update is called once per frame
    void Update()
    {
        
    }
}