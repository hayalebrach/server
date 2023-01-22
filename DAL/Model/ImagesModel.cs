
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class ImagesModel
    {
        public Pool Post(int poolId, string imageName)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Pool pool = db.Pools.FirstOrDefault(p => p.Id == poolId);
                if (pool != null)
                {
                    pool.Pic = imageName;
                    db.SaveChanges();
                }

                return pool;

            }
        }
    }
