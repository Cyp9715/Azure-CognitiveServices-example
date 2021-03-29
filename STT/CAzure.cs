using System;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using STT.Code;

namespace STT
{
    public class CAzure : IShared
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
                        speechConfig.SpeechRecognitionLanguage = Language_Azure.English_UnitedState;
                        break;
                    case e_language.Korean:
                        speechConfig.SpeechRecognitionLanguage = Language_Azure.Korean_Korea;
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
}
