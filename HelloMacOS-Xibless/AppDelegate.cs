using AppKit;
using Foundation;

namespace HelloMacOSXibless
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        private MainWindowController mainWindowController;

        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            mainWindowController = new MainWindowController();
            mainWindowController.Window.MakeKeyAndOrderFront(this);
        }
    }
}
