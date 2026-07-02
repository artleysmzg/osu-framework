#nullable disable

using osuTK;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Rendering;

namespace osu.Framework.Graphics.Camera
{
    public partial class DrawableCamera : BufferedContainer<Drawable>
    {
        public DrawableCamera(RenderBufferFormat[] formats = null, bool pixelSnapping = false, bool cachedFrameBuffer = false)
            : base(formats, pixelSnapping, cachedFrameBuffer)
        {
        }

        public Vector2 Scroll = new Vector2(0, 0);
        public Vector2 TargetOffset = new Vector2(0, 0);

    }
}