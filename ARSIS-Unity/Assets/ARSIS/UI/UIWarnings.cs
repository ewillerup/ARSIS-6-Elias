using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWarnings : MonoBehaviour
{
    float suitPressure;
    float o2Rate;
    float secondaryO2Pack;

    void Awake() {
        suitPressure = 0;
        o2Rate = 0;
        secondaryO2Pack = 0;
    }
    
    void Update() {
        if (suitPressure > 5.0) {
            // Warning: Suit pressure high
            if (o2Rate > 2.0) {
                // Warning: O2 use high
                TerminateEVA();
            }
        }
    }



    void TerminateEVA() {
        // Ingress airlock
        // Connect SCU
        // Connect UIA Power EV is ON (LED ON)
        // Check UIA EMU-1 is OPEN
        
    }
}