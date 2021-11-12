using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Utilitys
{
    interface IInput
    {
        int GetInt();
        string GetString();
        string GetRndRegNr();
        bool GetTrueOrFalse();
        int GetRandomNumber(int min, int max);

    }
}
