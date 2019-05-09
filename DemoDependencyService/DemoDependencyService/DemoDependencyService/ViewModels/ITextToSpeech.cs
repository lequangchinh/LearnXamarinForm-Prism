using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDependencyService.ViewModels
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
