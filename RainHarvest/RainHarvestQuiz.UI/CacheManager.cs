using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainHarvestQuiz.UI
{
    public class CacheManager
    {
        public static Dictionary<int, Tuple<string,List<string>, string>> Questionaries = new Dictionary<int, Tuple<string,List<string>, string>>
        {
            { 1,
                Tuple.Create<string,List<string>,string>
                    ("Do you know how much water that you use every day goes out as waste?"
                    ,new List<string> { "50%","80%","25%","5%" },
                    "80%" ) },
            { 2,
                Tuple.Create<string,List<string>,string>
                    ("What will be the drop in your freshwater demand if you treat and reuse all your wastewater?",
                    new List<string> { "20%","70%","40%","0%" },
                    "40%" ) },
            { 3,
                Tuple.Create<string,List<string>,string>(
                    "Can you guess how much of its total budget HMWSSB spends every year in laying pipelines to carry your house sewage to " +
                       "treatment plants?",
                    new List<string> { "15%","10%","2%","14%" },
                    "15%" ) },
            { 4,
                Tuple.Create<string,List<string>,string>(
                    "How much treated sewage is reused in Hyderabad?",
                    new List<string> { "50%","25%","10%","1%" },
                    "10%" ) }
        };
            
    }
}
