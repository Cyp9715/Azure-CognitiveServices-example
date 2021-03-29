using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using STT.Code;

namespace STT
{
    interface IShared
    {
        Task<string> MicrophoneInput(e_language curLanguage);
    }


    public class Azure : L_Azure, IShared
    {
        private static SpeechConfig speechConfig;

        public void sttInit(string keyValue, string regionValue)
        {
            speechConfig = SpeechConfig.FromSubscription(keyValue, regionValue);
        }

        public async Task<string> MicrophoneInput(e_language curLanguage)
        {
            if (speechConfig != null)
            {
                switch (curLanguage)
                {
                    case e_language.English:
                        speechConfig.SpeechRecognitionLanguage = English_UnitedState;
                        break;
                    case e_language.Korean:
                        speechConfig.SpeechRecognitionLanguage = Korean_Korea;
                        break;
                }

                AudioConfig audioConfig = AudioConfig.FromDefaultMicrophoneInput();
                SpeechRecognizer recognizer = new SpeechRecognizer(speechConfig, audioConfig);
                SpeechRecognitionResult result = await recognizer.RecognizeOnceAsync();

                return result.Text;
            }
            return "";
        }
    }

    public class Google
    { 
    
    }

    public class Naver
    { 
    
    }
}
