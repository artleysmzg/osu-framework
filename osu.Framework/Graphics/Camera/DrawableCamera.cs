#nullable disable

using System.Collections.Generic;
using osuTK;
using osuTK.Graphics;
using System;
using System.Runtime.InteropServices;
using osu.Framework.Graphics.Shaders.Types;

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Colour;
using osu.Framework.Graphics.Primitives;
using osu.Framework.Graphics.Rendering;
using osu.Framework.Graphics.Shaders;
using osu.Framework.Utils;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Layout;

namespace osu.Framework.Graphics
{
    public partial class DrawableCamera : BufferedContainer<Drawable>
    {
        public DrawableCamera(RenderBufferFormat[] formats = null, bool pixelSnapping = false, bool cachedFrameBuffer = false)
            : base(formats, pixelSnapping, cachedFrameBuffer)
        {
        }

        public Vector2 Scroll = new Vector2(0, 0);
        public float Zoom
        {
            get => Scale.X;
            set => Scale = new Vector2(value);
        }

    }
}