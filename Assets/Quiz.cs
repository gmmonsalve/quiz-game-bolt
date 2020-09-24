using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
    // Start is called before the first frame update
   public  List<Question> preguntas = new List<Question>();
   int i = -2;
   string question;
   
   
    void Start()
    {
         Debug.Log("Sí estoy aquí jaja");   
        
         //Debug.Log(preguntas[0]);
        
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setQuestions(){
         preguntas.Add(new Question("5+8=0",false));
         preguntas.Add(new Question("5+8=13",true));
         preguntas.Add(new Question("4+3=10",false));
         preguntas.Add(new Question("6+4=5",false));
         preguntas.Add(new Question("11+12=23",true));
         preguntas.Add(new Question("100+5=105",true));

    }

    public string getQuestion(){
        
         if( i == -2){

            setQuestions(); 
            i++;         
            return " Inicio ";

         } else {

            i++;
            return preguntas[i].getFact();
      
                }         
   }

   

}
