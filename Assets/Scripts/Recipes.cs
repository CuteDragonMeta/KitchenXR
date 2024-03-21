using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Recipes : MonoBehaviour
{
    
        
     public TextMeshProUGUI ingredients;
    String[] Foodlist = {
        "Hetta upp olja i en gryta, stek lök, vitlök, chili och tomatpuré under omrörning någon minut. Tillsätt resten av ingredienserna och låt koka under lock ca 15 min. Skölj av bönorna i kallt vatten och häll i grytan. Låt sjuda ytterligare 5 min.",
        "Koka upp buljongen och häll upp i termos. Lägg i ingefäran. Strimla salladslök och chili. Grovhacka koriandern. Skär tofun i små tärningar och lägg tillsammans med alla grönsaker och nudlar i 2 burkar med lock (som man kan äta direkt ur.) Eller lägg i 2 skålar. Häll över buljongen vid servering. Låt stå någon minut så att nudlarna hinner svälla innan soppan ska ätas.",
        "Hacka lök och vitlök, Hetta upp hälften av oljan och stek lök, vitlök, lagerblad och kardemummakapslar tills löken får färg. Tillsätt ingefära, torra kryddor och 1 dl vatten, Stek under omrörning till en tjock kryddpasta, ca 30 sekunder. Häll i krossade tomater, sirap och resten av vattnet. Koka upp och sjud under lock ca 30 min. Tillsätt grädden och koka upp igen. Lyft ur lagerblad och kardemummakapslar och mixa såsen slät. Tärna tofun. Hetta upp resten av oljan i en stekpanna och stek tofun runt om tills den får fin färg. Pudra över curry och salta. Lägg den stekta tofun i såsen och sjud 1-2 min. Pressa i limesaft och rör om. Smaka av med salt. Servera grytan med limeklyftor, koriander och ris."
    };
    int i = 0;
    public void OnButtonClick()
    {
        if( i < 3){
        ingredients.text = Foodlist[i];
         i++;
        }else{
            i = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
