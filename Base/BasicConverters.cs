﻿using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Untitled.ConfigDataBuilder.Base
{
    public sealed class BoolConverter : IConfigValueConverter<bool>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Parse(string value) => System.Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, bool value)
            => writer.Write(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool ReadFrom(BinaryReader reader)
            => reader.ReadBoolean();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(bool value)
            => value.ToString();

        public bool IsScalar => true;
    }

    public sealed class Int16Converter : IConfigValueConverter<short>
    {
        public short Parse(string value)
        {
            return value.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                ? System.Convert.ToInt16(value, 16)
                : short.Parse(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, short value)
            => writer.Write(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short ReadFrom(BinaryReader reader)
            => reader.ReadInt16();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(short value)
            => value.ToString();

        public bool IsScalar => true;
    }

    public sealed class UInt16Converter : IConfigValueConverter<ushort>
    {
        public ushort Parse(string value)
        {
            return value.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                ? System.Convert.ToUInt16(value, 16)
                : ushort.Parse(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, ushort value)
            => writer.Write(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort ReadFrom(BinaryReader reader)
            => reader.ReadUInt16();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(ushort value)
            => value.ToString();

        public bool IsScalar => true;
    }

    public sealed class Int32Converter : IConfigValueConverter<int>
    {
        public int Parse(string value)
        {
            return value.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                ? System.Convert.ToInt32(value, 16)
                : int.Parse(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, int value)
            => writer.Write(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int ReadFrom(BinaryReader reader)
            => reader.ReadInt32();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(int value)
            => value.ToString();

        public bool IsScalar => true;
    }

    public sealed class UInt32Converter : IConfigValueConverter<uint>
    {
        public uint Parse(string value)
        {
            return value.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                ? System.Convert.ToUInt32(value, 16)
                : uint.Parse(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, uint value)
            => writer.Write(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint ReadFrom(BinaryReader reader)
            => reader.ReadUInt32();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(uint value)
            => value.ToString();

        public bool IsScalar => true;
    }

    public sealed class Int64Converter : IConfigValueConverter<long>
    {
        public long Parse(string value)
        {
            return value.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                ? System.Convert.ToInt64(value, 16)
                : long.Parse(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, long value)
            => writer.Write(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long ReadFrom(BinaryReader reader)
            => reader.ReadInt64();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(long value)
            => value.ToString();

        public bool IsScalar => true;
    }

    public sealed class UInt64Converter : IConfigValueConverter<ulong>
    {
        public ulong Parse(string value)
        {
            return value.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                ? System.Convert.ToUInt64(value, 16)
                : ulong.Parse(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, ulong value)
            => writer.Write(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong ReadFrom(BinaryReader reader)
            => reader.ReadUInt64();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(ulong value)
            => value.ToString();

        public bool IsScalar => true;
    }

    public sealed class SingleConverter : IConfigValueConverter<float>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float Parse(string value)
            => float.Parse(value, CultureInfo.InvariantCulture);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, float value)
            => writer.Write(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float ReadFrom(BinaryReader reader)
            => reader.ReadSingle();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(float value)
            => value.ToString(CultureInfo.InvariantCulture);

        public bool IsScalar => true;
    }

    public sealed class DoubleConverter : IConfigValueConverter<double>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double Parse(string value)
            => double.Parse(value, CultureInfo.InvariantCulture);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, double value)
            => writer.Write(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double ReadFrom(BinaryReader reader)
            => reader.ReadDouble();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(double value)
            => value.ToString(CultureInfo.InvariantCulture);

        public bool IsScalar => true;
    }

    public sealed class Vector2Converter : IConfigValueConverter<Vector2>, IMultiSegConverter
    {
        public string Separator { get; set; }

        public Vector2 Parse(string value)
        {
            var segs = value.Split(new[] { Separator ?? "," }, StringSplitOptions.None);
            if (segs.Length != 2) {
                throw new InvalidDataException($"Cannot convert \"{value}\" to Vector2, segments count must be 2");
            }
            return new Vector2(float.Parse(segs[0]), float.Parse(segs[1]));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, Vector2 value)
        {
            writer.Write(value.x);
            writer.Write(value.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2 ReadFrom(BinaryReader reader)
        {
            var x = reader.ReadInt32();
            var y = reader.ReadInt32();
            return new Vector2(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(Vector2 value)
            => value.ToString();

        public bool IsScalar => false;
    }

    public sealed class Vector3Converter : IConfigValueConverter<Vector3>, IMultiSegConverter
    {
        public string Separator { get; set; }

        public Vector3 Parse(string value)
        {
            var segs = value.Split(new[] { Separator ?? "," }, StringSplitOptions.None);
            if (segs.Length != 3) {
                throw new InvalidDataException($"Cannot convert \"{value}\" to Vector3, segments count must be 3");
            }
            return new Vector3(float.Parse(segs[0]), float.Parse(segs[1]), float.Parse(segs[2]));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, Vector3 value)
        {
            writer.Write(value.x);
            writer.Write(value.y);
            writer.Write(value.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3 ReadFrom(BinaryReader reader)
        {
            var x = reader.ReadInt32();
            var y = reader.ReadInt32();
            var z = reader.ReadInt32();
            return new Vector3(x, y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(Vector3 value)
            => value.ToString();

        public bool IsScalar => false;
    }

    public sealed class Vector4Converter : IConfigValueConverter<Vector4>, IMultiSegConverter
    {
        public string Separator { get; set; }

        public Vector4 Parse(string value)
        {
            var segs = value.Split(new[] { Separator ?? "," }, StringSplitOptions.None);
            if (segs.Length != 4) {
                throw new InvalidDataException($"Cannot convert \"{value}\" to Vector4, segments count must be 4");
            }
            return new Vector4(float.Parse(segs[0]), float.Parse(segs[1]), float.Parse(segs[2]), float.Parse(segs[3]));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, Vector4 value)
        {
            writer.Write(value.x);
            writer.Write(value.y);
            writer.Write(value.z);
            writer.Write(value.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4 ReadFrom(BinaryReader reader)
        {
            var x = reader.ReadInt32();
            var y = reader.ReadInt32();
            var z = reader.ReadInt32();
            var w = reader.ReadInt32();
            return new Vector4(x, y, z, w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(Vector4 value)
            => value.ToString();

        public bool IsScalar => false;
    }

    public sealed class ColorConverter : IConfigValueConverter<Color>, IMultiSegConverter
    {
        public string Separator { get; set; }

        public Color Parse(string value)
        {
            var segs = value.Split(new[] { Separator ?? "," }, StringSplitOptions.None);
            if (segs.Length != 4) {
                throw new InvalidDataException($"Cannot convert \"{value}\" to Color, segments count must be 4 (r, g, b, a)");
            }
            return new Color(float.Parse(segs[0]), float.Parse(segs[1]), float.Parse(segs[2]), float.Parse(segs[3]));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, Color value)
        {
            writer.Write(value.r);
            writer.Write(value.g);
            writer.Write(value.b);
            writer.Write(value.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Color ReadFrom(BinaryReader reader)
        {
            var r = reader.ReadSingle();
            var g = reader.ReadSingle();
            var b = reader.ReadSingle();
            var a = reader.ReadSingle();
            return new Color(r, g, b, a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(Color value)
            => value.ToString();

        public bool IsScalar => false;
    }

    public sealed class Color32Converter : IConfigValueConverter<Color32>, IMultiSegConverter
    {
        public string Separator { get; set; }

        public Color32 Parse(string value)
        {
            var segs = value.Split(new[] { Separator ?? "," }, StringSplitOptions.None);
            if (segs.Length != 4) {
                throw new InvalidDataException(
                    $"Cannot convert \"{value}\" to Color32, segments count must be 4 (r, g, b, a)");
            }
            return new Color32(byte.Parse(segs[0]), byte.Parse(segs[1]), byte.Parse(segs[2]), byte.Parse(segs[3]));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteTo(BinaryWriter writer, Color32 value)
        {
            writer.Write(value.r);
            writer.Write(value.g);
            writer.Write(value.b);
            writer.Write(value.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Color32 ReadFrom(BinaryReader reader)
        {
            var r = reader.ReadByte();
            var g = reader.ReadByte();
            var b = reader.ReadByte();
            var a = reader.ReadByte();
            return new Color32(r, g, b, a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(Color32 value)
            => value.ToString();

        public bool IsScalar => false;
    }

    public sealed class StringConverter : IConfigValueConverter<string>
    {
        public string Parse(string value)
            => value;

        public void WriteTo(BinaryWriter writer, string value)
        {
            if (value != null) {
                writer.Write(true);
                writer.Write(value);
            }
            else {
                writer.Write(false);
            }
        }

        public string ReadFrom(BinaryReader reader)
            => reader.ReadBoolean() ? reader.ReadString() : null;

        public string ToString(string value)
            => value;

        public bool IsScalar => true;
    }
}
