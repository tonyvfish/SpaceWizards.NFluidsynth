namespace NFluidsynth
{
    public class SynthFactory : ISynthFactory
    {
        public ISynth Create(ISettings settings)
        {
            return new Synth(settings);
        }
    }
}