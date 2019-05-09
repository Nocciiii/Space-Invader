using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Threading;

namespace ViewModel
{
    public class VMMainWindow
    {

        private void schuss()
        {
            Schuss neuerSchuss = new Schuss();
            Thread s = new Thread(new ParameterizedThreadStart(neuerSchuss.feuer));
            s.Start(lockObject);
        }
    }
}
