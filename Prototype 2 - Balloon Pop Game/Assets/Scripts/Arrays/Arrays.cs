using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] friendNames = {"Bob", "Jessica", "Jody", "Arthur", "Randall", "Todd", "Becky"};
    //                             { 0, 1, 2 ,3 ,4 ,5 ,6}
    public int[] numbers ={23, 46, 77,10, 42, 98,63,81};

    public string[] CarDestroyed = {"Car 1 ", "Car 2 ", "Car 3"};
    
    public int[] Car ={10, 199, 222};

    public string[] Storage = {"Item 1", "Item 2", "Item 3", "Item 4"};

    public int[] StorageItems ={2, 7, 4, 1};

    public string[] PlayerCount = {"50", "100", "1200", "100000"};

    public int[] PlayersOnline ={111, 112, 113, 114};

    public string[] Laps = {"Lap1", "Lap2", "Lap3"};

    public int[] Race ={ 121, 122, 123};

    public string[] Round= { "Round 1", "Round 2", "Round 3"};

    public int[] Match= { 131, 132, 133};

    public string[] Quest= {"Quest 1", "Quest 2"};

    public int[] Mission={ 141, 142, 143};

    public string[] Run = {"Run Stamina"};

    public int[] RunStamina={144};

    public string[] Dig= { "Digggers Speed 1", "Digggers Speed 2"};

    public int[] Digging={ 155};

    public string[] Indurence= {"HitPoints Taken One Thousand", "HitPoints Taken Two Thousand"};

    public int[] Damage={ 1000, 2000};
    

    
   
   

    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("Former friend " + friendNames[0]);
        Debug.Log(friendNames[3]+ " Says Hi as he walks to class");
        friendNames[0] = "Veronica";
         Debug.Log("New friend " + friendNames[0]);
         */

         /*
         Debug.Log("Car has been destroyed needs reparies " + CarDestroyed[1]);
         Debug.Log(CarDestroyed [0]+ "Car is In perfect Conditon.");
         CarDestroyed[1] = "Car has been reparied";
         Debug.Log(" Car has been reparied" + CarDestroyed [0]);
         */
         
         /*
         Debug.Log("Item has been removed from your storage " + Storage[1]);
         Debug.Log(Storage [0]+ "New Item has been added to your storage.");
         Storage[3] = "Storage Full";
         Debug.Log(" Storage Full" + Storage [0]);
         */

         /*
         Debug.Log("Players online 69 " + PlayerCount[1]);
         Debug.Log(PlayerCount [0]+ " Players Offline");
         PlayerCount[3] = "Player Left";
         Debug.Log("Player Left " + PlayerCount [0]);
         */


         /*
         Debug.Log("Laps Remaining " + Laps[0]);
         Debug.Log(Laps[3]+ " Last Lap ");
         Laps[0] = "3rd Lap";
         Debug.Log("3rd Lap " + Laps[0]);
         */
   
         /*
         Debug.Log("First Match" + Round[0]);
         Debug.Log(Round[3]+ " Fianl Fight ");
         Round[0] = "DeathMatch";
         Debug.Log("DeathMatch " + Round[0]);
         */

         /*
         Debug.Log("Tutorial" + Quest[0]);
         Debug.Log(Quest[3]+ " End of Tutorial ");
         Quest[0] = "Complete";
         Debug.Log("Complete " + Quest[0]);
         */

         /*
         Debug.Log("How to Run " + Run[0]);
         Debug.Log(Run[3]+ " Sprinting");
         Run[0] = "How to use less stamina";
         Debug.Log("How to use less stamina " + Run[0]);
         */

         /*
         Debug.Log("How to Dig" + Dig[0]);
         Debug.Log(Dig[3]+ " Efficence Of Digging ");
         Dig[0] = "End Of Digging";
         Debug.Log("End Of Digging" + Dig[0]);
         */
         
         /*
         Debug.Log("Damage Taken 100" + Indurence[0]);
         Debug.Log(Indurence[3]+ " Enemy Missed ");
         Indurence[0] = "Flame Damage 1000";
         Debug.Log("Flame Damage 1000 " + Indurence[0]);
         */






         foreach (int Damage in Damage)
         foreach(int Digging in Digging)
         foreach(int RunStamina in RunStamina)
         foreach(int Mission in Mission)
         foreach(int Match in Match)
         foreach(int Race in Race)
         foreach(int PlayersOnline in PlayersOnline)
         foreach(int StorageItems in StorageItems)
         foreach(int Car in Car)
         foreach(int numbers in numbers)
         {
            print (Indurence);
             print(Digging);
             print(numbers);
             print(Car);
             print(StorageItems);
             print(PlayersOnline);
             print(Race);
             print(Match);
             print(Mission);
             print(RunStamina);

         }
         

         
    
    }

    
}
