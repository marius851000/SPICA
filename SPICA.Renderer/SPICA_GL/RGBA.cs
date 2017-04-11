﻿using OpenTK.Graphics;

using SPICA.Math3D;
using SPICA.PICA.Commands;

using System.Numerics;

namespace SPICA.Renderer.SPICA_GL
{
    static class RGBAExtensions
    {
        public static Color4 ToColor4(this RGBA Color)
        {
            return new Color4(Color.R, Color.G, Color.B, Color.A);
        }

        public static Color4 ToColor4(this PICATexEnvColor Color)
        {
            return new Color4(Color.R, Color.G, Color.B, Color.A);
        }

        public static Color4 ToColor4(this Vector4 Color)
        {
            return new Color4(Color.X, Color.Y, Color.Z, Color.W);
        }
    }
}
