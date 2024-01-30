using System;
using Microsoft.Xna.Framework;
using Rectangle = Microsoft.Xna.Framework.Rectangle;

namespace MonoGame.Extended.Tests
{
    public class MockGameWindow : GameWindow
    {
        public override bool AllowUserResizing { get; set; }
        public override Rectangle ClientBounds { get; }
        public override DisplayOrientation CurrentOrientation { get; }
        public override IntPtr Handle { get; }
        public override string ScreenDeviceName { get; }

        public MockGameWindow()
        {
        }

        protected override void SetSupportedOrientations(DisplayOrientation orientations)
        {
        }

        protected override void SetTitle(string title)
        {
        }

#if __MonoCS__
        public override Icon Icon { get; set; }
#endif
    }
}
