
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
        public int eggCount;
        public Text eggCountText;
        
        
        public static Inventory instance;
        
        private void Awake()  
        {
            if(instance != null)
            {Debug.LogWarning("Two scripts in scene");
            return;}
            instance = this;
            
        }  
        public void AddEgg()
        {
            eggCount += 1;
            eggCountText.text = eggCount.ToString();
        }
}
