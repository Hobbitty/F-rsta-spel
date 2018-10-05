using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerScript : MonoBehaviour
{
    //variabel för att hålla koll på hur mycket tid som har passerat
    public float timeHasPassed;


    void Start()
    {
        //säger till unity att använda funktionen "Timer" efter 1 sekund och sedan reptera funktionen varje sekund.
        InvokeRepeating("Timer", 1f, 1f);
    }


    void Update()
    {

    }
    
    void Timer()
    {
        //lägger till 1 på timeHasPassed värdet.
        timeHasPassed += 1;
        //printar hur lång tid som har passerat.
        Debug.Log(string.Format("Timer {0}", timeHasPassed));
    }

}
