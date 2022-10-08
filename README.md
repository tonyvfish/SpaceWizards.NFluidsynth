# NFluidsynth (Space Wizards Edition)
![Build & Test](https://github.com/space-wizards/SpaceWizards.NFluidsynth/workflows/Build%20&%20Test/badge.svg) [![NuGet link](https://img.shields.io/nuget/v/SpaceWizards.NFluidsynth)](https://www.nuget.org/packages/SpaceWizards.NFluidsynth)

NFluidsynth is a C# binding for [libfluidsynth](https://github.com/Fluidsynth/fluidsynth/).

It is a P/Invoke wrapper, therefore you need native libfluidsynth.so / libfluidsynth.dylib / (lib)fluidsynth.dll.
NFluidsynth builds and packages don't come up with those native libraries, so you are supposed to prepare them by yourself (at least for now).

The target API is fluidsynth 2.0.x. The API mappings may not be complete (contributions are welcome).

Used mainly in [RobustToolbox](https://github.com/space-wizards/RobustToolbox) for MIDI input and playback support.
