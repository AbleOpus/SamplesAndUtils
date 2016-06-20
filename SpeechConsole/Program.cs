using System;
using System.Speech.Recognition;

namespace SpeechConsole
{
    class Program
    {
        private static readonly SpeechRecognitionEngine speechRecog = new SpeechRecognitionEngine();

        static void Main(string[] args)
        {
            Console.WriteLine("Loading grammar...");
            Choices choices = new Choices();
            // Add some numbers to say.
            for (var i = 0; i <= 100; i++)
                choices.Add(i.ToString());
            // Add commands to exit the program.
            choices.Add("close", "exit");
            var GB = new GrammarBuilder(choices);
            speechRecog.LoadGrammar(new Grammar(GB));
            Console.WriteLine("Grammar Loaded!");

            // Set input stream to that of the default recording device.
            speechRecog.SetInputToDefaultAudioDevice();

            // Listen for commands continuously until an exit command is heard.
            Console.WriteLine("Listening...");
            while (true)
            {
                RecognitionResult result = speechRecog.Recognize();
                int confidence = (int)(result.Confidence * 100.0f + 0.5f);
                Console.WriteLine($@"Text: {result.Text}, Confidence: {confidence}%");

                if (result.Text.Equals("close", StringComparison.OrdinalIgnoreCase) ||
                    result.Text.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
        }
    }
}
