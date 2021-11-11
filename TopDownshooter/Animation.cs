using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace TopDownshooter
{
    public enum AnimationStates
    {
        up, left, right, down, dead
    }
    class Animation
    {
        public static Dictionary<string, AnimationStates> StringToState =
            new Dictionary<string, AnimationStates>() 
            {
                { "up", AnimationStates.up },
                { "left", AnimationStates.left },
                { "right", AnimationStates.right },
                { "down", AnimationStates.down },
                { "dead", AnimationStates.dead },
            };

        public static string Path = Directory.GetCurrentDirectory() + "\\Images\\";

        Dictionary<AnimationStates, List<Image>> SpritesPacks = new Dictionary<AnimationStates, List<Image>>();

        public AnimationStates currentState = AnimationStates.up;
        public AnimationStates CurrentState
        {
            set
            {
                if (currentState != value)
                    index = 0;
                currentState = value;

            }
        }
        int index = 0;
        public int AnimationInterval = 20;
        DateTime lastChange = DateTime.Now;
        public int Index
        {
            get => index;
            set
            {
                if (DateTime.Now - lastChange > new TimeSpan(0, 0, 0, 0, AnimationInterval))
                {
                    lastChange = DateTime.Now;
                    index = value;
                    index %= SpritesPacks[currentState].Count;
                }
            }
        }

        public void LoadSprites(string path, AnimationStates state)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles();
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
