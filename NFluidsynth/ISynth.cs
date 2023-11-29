using System;

namespace NFluidsynth
{
    public interface ISynth
    {
        void Dispose();
        ISettings Settings { get; }
        int FontCount { get; }
        double ReverbRoomSize { get; }
        double ReverbDamp { get; }
        double ReverbLevel { get; }
        double ReverbWidth { get; }
        int NumberOfChorusVoices { get; }
        double ChorusLevel { get; }
        double ChorusSpeedHz { get; }
        double ChorusDepthMS { get; }
        FluidChorusMod ChorusType { get; }
        int MidiChannelCount { get; }
        int AudioChannelCount { get; }
        int AudioGroupCount { get; }
        int EffectChannelCount { get; }
        float Gain { get; set; }
        int Polyphony { get; set; }
        int ActiveVoiceCount { get; }
        int InternalBufferSize { get; }
        double CpuLoad { get; }
        bool Disposed { get; }

        /// <summary>
        ///     Handle to the native Fluidsynth C object.
        /// </summary>
        IntPtr Handle { get; }

        void NoteOn(int channel, int key, int vel);
        void NoteOff(int channel, int key);
        void CC(int channel, int num, int val);
        int GetCC(int channel, int num);
        unsafe bool Sysex (byte [] input, int inputOffset, int inputLength, byte [] output, int outputOffset, int outputLength, bool dryRun = false);
        bool Sysex(IntPtr input, int inputLength, IntPtr output, int outputLength, bool dryRun = false);
        void PitchBend(int channel, int val);
        int GetPitchBend(int channel);
        void PitchWheelSens(int channel, int val);
        int GetPitchWheelSens(int channel);
        void ProgramChange(int channel, int program);
        void ChannelPressure(int channel, int val);
        void KeyPressure(int channel, int key, int val);
        void BankSelect(int channel, uint bank);
        void SoundFontSelect(int channel, uint soundFontId);
        void ProgramSelect(int channel, uint soundFontId, uint bank, uint preset);
        void ProgramSelectBySoundFontName(int channel, string soundFontName, uint bank, uint preset);
        void GetProgram(int channel, out int soundFontId, out int bank, out int preset);
        void UnsetProgram(int channel);
        void ProgramReset();
        void SystemReset();
        uint LoadSoundFont(string filename, bool resetPresets);
        void ReloadSoundFont(uint id);
        void UnloadSoundFont(uint id, bool resetPresets);
        void AddSoundFont(SoundFont soundFont);
        void RemoveSoundFont(SoundFont soundFont);
        SoundFont GetSoundFont(uint index);
        SoundFont GetSoundFontById(uint id);
        SoundFont GetSoundFontByName(string name);
        void SetBankOffset(int soundFontId, int offset);
        void GetBankOffset(int soundFontId);
        void SetReverb(double roomSize, double damping, double width, double level);
        void SetReverbOn(bool enabled);
        void SetChorus(int numVoices, double level, double speed, double depthMS, FluidChorusMod type);
        void SetChorusOn(bool enabled);
        void SetChannelRate(float sampleRate);
        void SetInterpolationMethod(int channel, FluidInterpolation interpolationMethod);
        void SetGenerator(int channel, int param, float value);
        float GetGenerator(int channel, int param);
        unsafe void ActivateKeyTuning (int bank, int prog, string name, double [] pitch, int pitchOffset, int pitchLength, bool apply);
        void ActivateKeyTuning(int bank, int prog, string name, IntPtr pitch, int pitchLength, bool apply);
        unsafe void ActivateOctaveTuning (int bank, int prog, string name, double [] pitch, int pitchOffset, int pitchLength, bool apply);
        void ActivateOctaveTuning(int bank, int prog, string name, IntPtr pitch, int pitchLength, bool apply);

        unsafe void TuneNotes (int bank, int prog, int [] keys, int keysOffset, int keysLength, double [] pitch, int pitchOffset, int pitchLength,
            bool apply);

        void TuneNotes(int bank, int prog, IntPtr keys, int keysLength, IntPtr pitch, int pitchLength, bool apply);
        void ActivateTuning(int channel, int bank, int prog, bool apply);
        void DeactivateTuning(int channel, bool apply);
        void TuningIterationStart();
        bool TuningIterationNext(out int bank, out int prog);
        unsafe double[] TuningDump(int bank, int prog, out string name);

        unsafe void WriteSample16 (int count, ushort [] leftOut, int leftOffset, int leftOutLength, int leftIncrement,
            ushort [] rightOut, int rightOffset, int rightOutLength, int rightIncrement);

        void WriteSample16(int count, IntPtr leftOut, int leftOffset, int leftOutLength, int leftIncrement,
            IntPtr rightOut, int rightOffset, int rightOutLength, int rightIncrement);

        unsafe void WriteSampleFloat(int count, float [] leftOut, int leftOffset, int leftOutLength, int leftIncrement,
            float [] rightOut, int rightOffset, int rightOutLength, int rightIncrement);

        void WriteSampleFloat(int count, IntPtr leftOut, int leftOffset, int leftOutLength, int leftIncrement,
            IntPtr rightOut, int rightOffset, int rightOutLength, int rightIncrement);

        unsafe void Process(int length, int nFx, float** fx, int nOut, float** @out);
        void AddSoundFontLoader(SoundFontLoader loader);
        Voice AllocateVoice(IntPtr sample, int channel, int key, int vel);
        void StartVoice(Voice voice);
        unsafe bool GetVoiceList(Voice[] voices, int voiceId);
        int CallDefaultHandler(IMidiEvent midiEvent);
        int AllNotesOff(int channel);
        bool Equals(object obj);
        int GetHashCode();
    }
}