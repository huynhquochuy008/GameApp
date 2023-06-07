using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    internal class ModelComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x == null)
                return (y == null) ? 0 : 1;

            if (y == null)
                return -1;

            RankModel model1 = x as RankModel;
            RankModel model2 = y as RankModel;

            // Uncomment this to sort by Name 
            // return( (new CaseInsensitiveComparer()).Compare( p1.Name, p2.Name) );

            return (model1.getScore() - model2.getScore());
        }
    }
}
