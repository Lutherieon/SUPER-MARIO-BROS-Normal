//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor;
//using UnityEngine;
//using UnityEngine.UI;


//namespace Mario.Health
//{
//    public class HeartsHealthVisual : MonoBehaviour
//    {
//        public static HeartsHealthVisual instance;

//        [SerializeField] private Sprite heart0Sprite;
//        [SerializeField] private Sprite heart1Sprite;
//        [SerializeField] private Sprite heart2Sprite;
//        [SerializeField] private Sprite heart3Sprite;
//        [SerializeField] private Sprite heart4Sprite;
//        private List<HeartImage> heartImageList;
//        private void Awake()
//        {
//            heartImageList = new List<HeartImage>();  
//            instance = this;    
//        }
//        private void Start()
//        {
//            CreateHeartImage(new Vector2(110, -50));
//            CreateHeartImage(new Vector2(150, -50));
//            CreateHeartImage(new Vector2(190, -50));


//        }
//        private Image CreateHeartImage(Vector2 anchoredPosition)
//        {
//            //creating game object 
//            GameObject heartGameObject = new GameObject("Heart", typeof(Image));
//            //Set as child of this transform
//            heartGameObject.transform.SetParent(transform);
//            heartGameObject.transform.localPosition = Vector3.zero;

//            //Locate and Size Heart
//            heartGameObject.GetComponent<RectTransform>().anchoredPosition = anchoredPosition;
//            heartGameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(25, 25);
//            //Set heart sprite
//            Image heartImageUI = heartGameObject.GetComponent<Image>();
//            heartImageUI.sprite = heart0Sprite;

//            HeartImage heartImage = new HeartImage(heartImageUI);
//            heartImageList.Add(heartImage);
//            return heartImageUI;

//        }




//        // Represent a single hearth 
//        public class HeartImage()
//        {
//            private Image heartImage;
//            public HeartImage(Image hearthImage)
//            {
//                this.heartImage = hearthImage;
//            }


//        }


//    }

//}
