using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParametersHandsOn
{
    class NamedParameter
    {
        public void GetCohortDetails(string Name, int GencCount, string Mode, string Track, string CurrModule)
        {
            Console.WriteLine("It is {0} with {1} GenCs undergoing training for {2} thru {3}. The current module of training is {4}", Name, GencCount, Track, Mode, CurrModule);
        }
        static void Main(string[] args)
        {
            NamedParameter details = new NamedParameter();
            details.GetCohortDetails("ADM20DF003", 21, "OBL", "DotNet", "Advance C#");
            details.GetCohortDetails("DotNet", 21, "OBL", "ADM20DF003", "Advance C#");
            details.GetCohortDetails(Track: "DotNet", Mode: "OBL", Name: "ADM20DF003", CurrModule: "Advance C#", GencCount: 21);
            Console.ReadKey();
        }
    }
}