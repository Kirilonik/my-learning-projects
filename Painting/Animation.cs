using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Painting
{
    public enum AnimationStates
    {
        idle, run, walk
    }
    public class Animation
    {
        public static Dictionary<string, AnimationStates> StringToState =
            new Dictionary<string, AnimationStates>()
            {
                {"idle", AnimationStates.idle },
                {"run", AnimationStates.run },
                {"walk", AnimationStates.walk }
            };
        public static string Path = Directory.GetCurrentDirectory() + "\\assets\\sprites";


        Dictionary<AnimationStates, List<Image>> SpritesPacks =
            new Dictionary<AnimationStates, List<Image>>();

        public AnimationStates currentState = AnimationStates.idle; // состояние актуальное 
        public AnimationStates CurrentState
        {
            set
            {
                if(currentState != value)
                    index = 0;
                currentState = value;
                
            }
        }

        int index = 0; // num of frame
        public int AnimationInterval = 150;
        DateTime lastChange = DateTime.Now;
        public int Index {
            get => index;
            set 
            {
                if(DateTime.Now - lastChange > new TimeSpan(0, 0, 0, 0, AnimationInterval))
                {
                    lastChange = DateTime.Now;
                    index = value;
                    index %= SpritesPacks[currentState].Count;
                }
            }
        }

        public void LoadSprites(string path, AnimationStates state)
        {
            DirectoryInfo direcctoryInfo = new DirectoryInfo(path);
            FileInfo[] files = direcctoryInfo.GetFiles();

            if (!SpritesPacks.ContainsKey(state))
            {
                SpritesPacks.Add(state, new List<Image>());
                foreach (var file in files)
                {
                    SpritesPacks[state].Add(Image.FromFile(file.FullName));
                }
            }
        }

        public Image GetImage()
        {
            return SpritesPacks[currentState][Index++];
        }
    }
}