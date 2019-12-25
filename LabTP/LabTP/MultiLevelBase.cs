
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP
{
    public class MultiLevelBase
    {
        List<Base<IAntiaircraftGun>> baseStages;
        private const int countPlaces = 20;
        private  int pictureWigth;
        private  int pictureWidth;
        private  int pictureHeight;

        public MultiLevelBase(int countStages, int pictureWidth,int pictureHeight)
        {
            baseStages = new List<Base<IAntiaircraftGun>>();
            for (int i=0;i<countStages;++i)
            {
                baseStages.Add(new Base<IAntiaircraftGun>(countPlaces, pictureWidth, pictureHeight));
            }
        }
        
        public Base<IAntiaircraftGun> this [int ind]
        {
            get
            {
                if(ind > -1 && ind< baseStages.Count)
                {
                    return baseStages[ind];
                }
                return null;
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter streamWriter = new StreamWriter(File.OpenWrite(filename)))
            {
                streamWriter.WriteLine($"CountLevels:{baseStages.Count}");
                foreach (var level in baseStages)
                {

                    streamWriter.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        try
                        {
                            var gun = level[i];
                            if (gun != null)
                            {

                                if (gun.GetType().Name == "Gun")
                                {
                                    streamWriter.WriteLine($"{i}:Gun:" + gun);
                                }
                                if (gun.GetType().Name == "AntiaircraftGun")
                                {
                                    streamWriter.WriteLine($"{i}:AntiaircraftGun:" + gun);
                                }
                            }
                        }
                        finally { }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException(); ;
            }
            string bufferTextFromFile = "";
            using (StreamReader reader = new StreamReader(File.OpenRead(filename)))
            {
                bufferTextFromFile = reader.ReadLine();
                if (bufferTextFromFile.Split(':')[0] == "CountLevels")
                {
                    int countLevel = Convert.ToInt32(bufferTextFromFile.Split(':')[1]);
                    if (baseStages != null)
                        baseStages.Clear();
                    baseStages = new List<Base<IAntiaircraftGun>>(countLevel);
                }
                else
                    return false;
                int count = -1;
                while (!reader.EndOfStream)
                {
                    bufferTextFromFile = reader.ReadLine();
                    IAntiaircraftGun gun = null;
                    if (bufferTextFromFile == "Level")
                    {
                        count++;
                        baseStages.Add(new Base<IAntiaircraftGun>(countPlaces, pictureWigth, pictureHeight));
                        continue;
                    }
                    if (bufferTextFromFile.Split(':')[1] == "Gun")
                    {
                        gun = new Gun(bufferTextFromFile.Split(':')[2]);
                        baseStages[count][Convert.ToInt32(bufferTextFromFile.Split(':')[0])] = gun;
                    }
                    if (bufferTextFromFile.Split(':')[1] == "AntiaircraftGun")
                    {
                        gun = new AntiaircraftGun(bufferTextFromFile.Split(':')[2]);
                        baseStages[count][Convert.ToInt32(bufferTextFromFile.Split(':')[0])] = gun;
                    }
                }
            }
            return true;
        }
        public void Sort()
        {
            baseStages.Sort();
        }
    }    
}
