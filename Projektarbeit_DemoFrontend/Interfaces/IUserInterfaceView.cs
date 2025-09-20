using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit_DemoFrontend.Interfaces
{
    interface IUserInterfaceView
    {
        void Print(string message, params object[] args);
        void PrintList(string message, List<string> list);
        void PrintTable(string message, string[] headingLabel, List<string[]> list);
        int GetSelection(List<string> options, string message);
    }
}
