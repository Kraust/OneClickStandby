// One Click Standby Mode
// Requested by PCH on 2015-11-10

using System;
using System.Runtime.InteropServices;

namespace OneClickStandby
{
  class Program
  {
    [DllImport("Powrprof.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
    public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

    static void Main(string[] args)
    {
      Console.WriteLine("Entering Standby Mode...");
      SetSuspendState(false, true, true);
    }
  }
}
