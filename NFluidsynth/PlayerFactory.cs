namespace NFluidsynth
{
    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer Create(ISynth synth)
        {
            return new Player(synth);
        }
    }
}