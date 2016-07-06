using System.Windows.Forms;

namespace ColorsDesktop
{
    class LogHandler
    {
        private MainWindow _mw;
        private delegate void SetTextDelegate(string text);

        public LogHandler(MainWindow mw)
        {
            _mw = mw;
        }

        private void setText(string text)
        {
            _mw.textBoxLog.Text += text + "\r\n";
        }

        public void AddNewLine(string line)
        {
            _mw.textBoxLog.Invoke(new SetTextDelegate(setText), new string[] {line});
        }
    }
}
