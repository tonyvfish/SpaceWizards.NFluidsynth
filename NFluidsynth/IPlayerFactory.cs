namespace NFluidsynth
{
    public interface IPlayerFactory
    {
        IPlayer Create(ISynth synth);
    }
}

