using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STT
{
    interface IShared
    {
        Task<string> MicrophoneInput(e_language curLanguage);
    }

}
