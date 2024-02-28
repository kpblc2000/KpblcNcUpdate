using Teigha.Runtime;

namespace KpblcNcUpdate.NCadCommands
{
    public static class AboutCmd
    {
        [CommandMethod("kpblc-about")]
        public static void KpblcAboutCommand()
        {
            System.Windows.Forms.MessageBox.Show("About Command");
        }
    }
}
