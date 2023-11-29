using NFluidsynth.Native;

namespace NFluidsynth
{
    public partial class Settings : FluidsynthObject, ISettings
    {
        public Settings()
            : base(LibFluidsynth.new_fluid_settings())
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                LibFluidsynth.delete_fluid_settings(Handle);
            }

            base.Dispose(disposing);
        }

        public ISettingEntry this[string name]
        {
            get
            {
                ThrowIfDisposed();
                return new SettingEntry(this, name);
            }
        }
    }
}