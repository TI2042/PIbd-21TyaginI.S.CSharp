using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP
{
    public class MultiLevelBase
    {
        List<Base<IAntiaircraftGun>> baseStages;
        private const int countPlaces = 20;

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
    }  
}