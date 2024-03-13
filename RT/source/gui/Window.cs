using System.Diagnostics;

namespace UI
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
            saveButton.Enabled = false;

            thread.Value = 3 * Environment.ProcessorCount;
            threadNumber.Text = thread.Value.ToString();
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            image.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void threadCount_Scroll(object sender, EventArgs e)
        {
            threadNumber.Text = thread.Value.ToString();
        }

        private void sppCount_Scroll(object sender, EventArgs e)
        {
            sppNumber.Text = spp.Value.ToString();
        }

        private void depth_Scroll(object sender, EventArgs e)
        {
            maxDepthNumber.Text = maxDepth.Value.ToString();
        }

        private void renderButton_Click(object sender, EventArgs e)
        {
            // Weryfikacja rozmiaru obrazu
            if (size.Value % 4 != 0)
                size.Value = (int)size.Value + 2 & ~3;

            Stopwatch sw = new();
            RayTracing rt = new((int)size.Value, spp.Value, maxDepth.Value);

            // Pomiar czasu raz wykonanie algorytmu
            sw.Start();
            var bmpData = rt.Render(thread.Value);
            sw.Stop();

            // Zapis czasu wykonania
            var time = sw.Elapsed;
            var elapsedTime = $"{time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds / 10:00}";
            timeList.Items.Add($"Czas: {elapsedTime}, Wątki: {thread.Value}");

            // Tworzenie i prezentacja mapy bitowej
            var bmp = new Bmp((int)size.Value, bmpData);
            var bmpStream = new MemoryStream(bmp.ImageData);
            image.Image = Image.FromStream(bmpStream);
            saveButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }
    }
}