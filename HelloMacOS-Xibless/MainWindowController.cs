using AppKit;
using CoreGraphics;

namespace HelloMacOSXibless
{
	public class MainWindowController : NSWindowController
	{
		public MainWindowController () : base ()
		{
			
			// Construct the window from code here
			CGRect contentRect = new(0, 0, 1000, 500);
			base.Window = new MainWindow(contentRect, (NSWindowStyle.Titled | NSWindowStyle.Closable | NSWindowStyle.Miniaturizable | NSWindowStyle.Resizable), NSBackingStore.Buffered, false);

			// Simulate Awaking from Nib
			Window.AwakeFromNib ();
		}

        public new MainWindow Window => (MainWindow)base.Window;
    }
}