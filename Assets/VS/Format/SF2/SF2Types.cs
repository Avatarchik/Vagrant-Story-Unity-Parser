﻿using System.Runtime.InteropServices;

namespace VS.Format
{
    // SF2 v2.1 spec page 16
    public sealed class SF2VersionTag
    {
        public const uint Size = 4;

        public readonly ushort Major;
        public readonly ushort Minor;

        public SF2VersionTag(ushort major, ushort minor)
        {
            Major = major; Minor = minor;
        }

        public override string ToString() => $"v{Major}.{Minor}";
    }

    // SF2 spec v2.1 page 19
    // Two bytes that can handle either two 8-bit values or a single 16-bit value
    [StructLayout(LayoutKind.Explicit)]
    public struct SF2GeneratorAmount
    {
        [FieldOffset(0)] public byte LowByte;
        [FieldOffset(1)] public byte HighByte;
        [FieldOffset(0)] public short Amount;
        [FieldOffset(0)] public ushort UAmount;

        public override string ToString() => $"BLo = {LowByte}, BHi = {HighByte}, Sh = {Amount}, U = {UAmount}";
    }

    // SF2 v2.1 spec page 20
    public enum SF2SampleLink : ushort
    {
        MonoSample = 1,
        RightSample = 2,
        LeftSample = 4,
        LinkedSample = 8,
        RomMonoSample = 0x8001,
        RomRightSample = 0x8002,
        RomLeftSample = 0x8004,
        RomLinkedSample = 0x8008
    }

    // SF2 v2.1 spec page 38
    public enum SF2Generator : ushort
    {
        StartAddrsOffset = 0,
        EndAddrsOffset = 1,
        StartloopAddrsOffset = 2,
        EndloopAddrsOffset = 3,
        StartAddrsCoarseOffset = 4,
        ModLfoToPitch = 5,
        VibLfoToPitch = 6,
        ModEnvToPitch = 7,
        InitialFilterFc = 8,
        InitialFilterQ = 9,
        ModLfoToFilterFc = 10,
        ModEnvToFilterFc = 11,
        EndAddrsCoarseOffset = 12,
        ModLfoToVolume = 13,
        ChorusEffectsSend = 15,
        ReverbEffectsSend = 16,
        Pan = 17,
        DelayModLFO = 21,
        FreqModLFO = 22,
        DelayVibLFO = 23,
        FreqVibLFO = 24,
        DelayModEnv = 25,
        AttackModEnv = 26,
        HoldModEnv = 27,
        DecayModEnv = 28,
        SustainModEnv = 29,
        ReleaseModEnv = 30,
        KeynumToModEnvHold = 31,
        KeynumToModEnvDecay = 32,
        DelayVolEnv = 33,
        AttackVolEnv = 34,
        HoldVolEnv = 35,
        DecayVolEnv = 36,
        SustainVolEnv = 37,
        ReleaseVolEnv = 38,
        KeynumToVolEnvHold = 39,
        KeynumToVolEnvDecay = 40,
        Instrument = 41,
        KeyRange = 43,
        VelRange = 44,
        StartloopAddrsCoarseOffset = 45,
        Keynum = 46,
        Velocity = 47,
        InitialAttenuation = 48,
        EndloopAddrsCoarseOffset = 50,
        CoarseTune = 51,
        FineTune = 52,
        SampleID = 53,
        SampleModes = 54,
        ScaleTuning = 56,
        ExclusiveClass = 57,
        OverridingRootKey = 58,
        EndOper = 60
    }

    // Modulator's internal enumeration class
    // SF2 v2.1 spec page 50
    public enum SF2Modulator : ushort
    {
        None = 0,
        NoteOnVelocity = 1,
        NoteOnKey = 2,
        PolyPressure = 10,
        ChnPressure = 13,
        PitchWheel = 14,
        PitchWheelSensivity = 16
    }

    // SF2 v2.1 spec page 52
    public enum SF2Transform : ushort
    {
        Linear = 0,
        Concave = 1,
        Convex = 2
    }
}
