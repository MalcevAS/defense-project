using UnityEngine;
using UnityEngine.UIElements;


public class Adskfh : MonoBehaviour
{
    Transform _transform;
    public float speed = 200;
    MeshRenderer _meshRenderer;
    public GameObject gameobject;
    /*bool findExists(int[] array, int element)
    {
        bool res = false;
        foreach (int i in array) 
        {
            if (i == element)
            {
                
                return true;
            } 

        }
        return false;
    
    }

    void reverseArray(int[] array)
    {
       /* for(int i = 0; i < Mathf.Floor(array.Length / 2); i++)
        {
            int alb = array[i];
            array[i] = array[array.Length - 1-i];
            array[array.Length - 1 - i] = alb;
        }
        
    
    
    
    }
    */





    /*void findParms(int a, int b, int c)
    {

        int S = a * b;
        Debug.Log($"Площадь равна {S}");

        int P = (a + b) * 2;
        Debug.Log($"Периметр равен {P}");

        int V = a * b * c;
        Debug.Log($"Объём равен {V}");

    }
    // int GetSquare(string a, string b)
    //{
    //return a * b;
    //}
    int GetMasive(int[] arg)
    {
       return int  ;
    }
    */
    void Start()
    {
        gameobject.SetActive(false);
        
        
        
        _transform = GetComponent<Transform>();
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.enabled = false;
        /*int[] m1 = new int[5] { 1, 2, 3, 4, 5 };
        bool b = true;
        //Debug.Log(b ? "Верно" : "Неверно");
        //Debug.Log(findExists(m1, 3)? "Элемент присутствует" : "Элемент отсутствует");

        ArrayList list = new ArrayList(new int[] { 1, 2, 3 });
        list.Add(7);
        list.Add(23);
        list.Add(228);
        list.Add(777);
        list.Sort();
        list.Reverse();
        //Debug.Log(list.Contains(777)); // вай брат можна любой числа проверат
        list.Reverse();
        int[] arr = new int[list.Count];
        list.CopyTo(arr);
        foreach (int i in arr)
        {
            Debug.Log(i);
        }
        */




        //Debug.Log(m1);
        //foreach(int i in m1)
        //{
        //Debug.Log(i);
        //}
        /*for(int i = 0; i <= 10; i++)
        {
        Debug.Log(i);

        }
         int i = 0;
         while (i < 20);
         {
         Debug.Log(i);
         i++;
         }
        int i = 0
         do
        {
        Debug.Log(i);
        i++;
        }
        while (i < 20);

        int[] i = {0, 1, 2, 3 };

         foreach (int k in i) ;
         {
         Debug.Log(k);
         }
        */
        //int[] alabay = new int[6] { 1, 2, 3, 4, 5, 6 };
        /*
         int[] alabay2 = new int[6];
          nt[] alabay3 = new int[alabay.Length + alabay2.Length];
          Debug.Log(alabay.Length);
          Debug.Log(alabay[alabay.Length-1]);
          for (int i = 0; i < alabay.Length; i++) 
         {
         Debug.Log(alabay[i]);
          alabay3[i] = alabay[i];
          }
         for (int i = alabay.Length; i < alabay2.Length+alabay2.Length; i++)
          {
         alabay3[i] = alabay2[i-alabay.Length];
          }

          if (10>5)
          {
          Debug.Log("Больше");
         } else {
         else if(){


         }   

              Debug.Log("Меньше");
         }

         int[][]
         name=new int [5][3]
         name[2][1]
         int arr= {{0,1,2}{2,3,4}{4,5,6}}

     }
         */
        /*
         int sum = 1;
         for(int i=0;i < alabay.Length; i++)
         {
             sum *= alabay[i];
         }
         Debug.Log(sum);

        int a = 0;
        int t = 1;
        for (int i = 0; i < 5; i++)
        {
            a = t;
            while (i == 0)
            {
                a = 0;
                Debug.Log(a);
                Debug.Log(t);

            }
            t = a + t;
            Debug.Log(t);
        }

            findParms(5, 7, 3);

        }
          */






        void Update()
        {
            //Debug.Log(_transform.position.y);//вместо rotation так же можно rotation и scale а вместо yможно x и z
           // _transform.position = new Vector3(0, 0, 0) * Time.deltaTime * speed;
            
        }


        /* void Awake()
         {
        
         }

        private void FixedUpdate() 
        {
        
        }
        
        private void LateUpdate() через опред время
         {
         
         }       
         */
}
}


  
