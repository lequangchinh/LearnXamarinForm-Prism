using Android.Speech.Tts;
using DemoDependencyService.Droid;
using Xamarin.Forms;
using System.Diagnostics;
using Android.Runtime;

[assembly: Dependency(typeof(TextToSpeech_Android))]
namespace DemoDependencyService.Droid
{
    public class TextToSpeech_Android : Java.Lang.Object, ViewModels.ITextToSpeech, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

        public void OnInit([GeneratedEnum] OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                Debug.WriteLine("speaker init");
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
            else
            {
                Debug.WriteLine("was quiet");
            }
        }

        public void Speak(string text)
        {
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(MainActivity.Instance, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
                Debug.WriteLine("spoke " + toSpeak);
            }
        }
    }

    
}