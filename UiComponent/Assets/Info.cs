using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{

    /*
    The Audio Mixer:

    De Unity Audio Mixer maakt het mogelijk om verschillende audio bestanden te mixen, effecten aan je geluid toe te voegen, 
    en je geluid aftestellen aan je game.


    Hoe werkt het:

    Je stuurt de output van een van jouw audio bestanden naar een group van de audio mixer. In de audio mixer geef je aan welke effecten je mee wil
    geven aan dat bestand. Dat signaal word dan door gelezen in je project en word afgespeeld. 
    Dit signaal can je sturen naar andere groepen in elke andere Audio Mixers in je scene waardoor je een ketting reactie van geluiden kan maken.
    Hiermee kan je Snapshots en andere effecten er aan toevoegen.


    Snapshots:

    Je kan een Snapshot maken van all je parameters van een groep. dit kan je dan geven aan een andere groep. Als je een lijst van Snapshots
    maakt kan je geluiden vloeiend in elkaar over laten gaan.


    Ducking: 

    Met ducking laat je effecten van bepaalde groepen veranderen door gebeurtenissen in de Scene. Als er focus op een gebeurtenis moet zijn laat je 
    daar het geluid harder klinken en maak je de rest zachter.


    Vieuws:

    Met Views kan je verschillende groepen niet of wel laten zien. 
    Als er eentje niets doet dan kan je die onzichtbaar maken in de Audio Mixers Window, maar zodra die weer geluid moet geven word het weer zichtbaar.
    Zo kan je het gelijdelijk in elkaar laten overlopen.

    */
}