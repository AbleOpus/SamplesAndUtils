using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using AopBenchmark.Properties;

namespace AopBenchmark
{
    public partial class MainForm : Form
    {
        private readonly Stopwatch stopwatch = new Stopwatch();

        public MainForm()
        {
            InitializeComponent();
            numberBoxLoops.Value = Settings.Default.Iterations;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.Iterations = numberBoxLoops.Value;
            Settings.Default.Save();
            base.OnClosing(e);
        }

        private void buttonBenchmark_Click(object sender, EventArgs e)
        {
            long time1;
            long time2;

            // alternate
            stopwatch.Start();
            BenchmarkCode1();
            stopwatch.Stop();
            time1 = stopwatch.ElapsedTicks;
            stopwatch.Reset();

            stopwatch.Start();
            BenchmarkCode2();
            stopwatch.Stop();
            time2 = stopwatch.ElapsedTicks;
            stopwatch.Reset();

            stopwatch.Start();
            BenchmarkCode1();
            stopwatch.Stop();
            time1 += stopwatch.ElapsedTicks;
            stopwatch.Reset();

            stopwatch.Start();
            BenchmarkCode2();
            stopwatch.Stop();
            time2 += stopwatch.ElapsedTicks;
            stopwatch.Reset();

            stopwatch.Start();
            BenchmarkCode1();
            stopwatch.Stop();
            time1 += stopwatch.ElapsedTicks;
            stopwatch.Reset();

            stopwatch.Start();
            BenchmarkCode2();
            stopwatch.Stop();
            time2 += stopwatch.ElapsedTicks;
            stopwatch.Reset();

            stopwatch.Start();
            BenchmarkCode1();
            stopwatch.Stop();
            time1 += stopwatch.ElapsedTicks;
            stopwatch.Reset();

            stopwatch.Start();
            BenchmarkCode2();
            stopwatch.Stop();
            time2 += stopwatch.ElapsedTicks;
            stopwatch.Reset();


            stopwatch.Start();
            BenchmarkCode1();
            stopwatch.Stop();
            time1 += stopwatch.ElapsedTicks;
            stopwatch.Reset();

            stopwatch.Start();
            BenchmarkCode2();
            stopwatch.Stop();
            time2 += stopwatch.ElapsedTicks;
            stopwatch.Reset();

            stopwatch.Start();
            BenchmarkCode1();
            stopwatch.Stop();
            time1 += stopwatch.ElapsedTicks;
            stopwatch.Reset();

            stopwatch.Start();
            BenchmarkCode2();
            stopwatch.Stop();
            time2 += stopwatch.ElapsedTicks;
            stopwatch.Reset();

            labelTime1.Text = time1.ToString();
            labelTime2.Text = time2.ToString();

            double percent = Math.Round(((double)time1 / time2), 3);
            labelRatio.Text = labelRatio.Tag + percent.ToString();

            double totalTime = ((double)time1 + time2) / Stopwatch.Frequency;
            totalTime = Math.Round(totalTime, 2);
            labelTotalTime.Text = labelTotalTime.Tag + totalTime.ToString();
        }

        private void BenchmarkCode1()
        {
            List<Vertex> vertexes = new List<Vertex>();

            for (int i = 0; i < numberBoxLoops.Value; i++)
            {
                vertexes.Add(new Vertex(i, i, i));
            }

            Vertex[] VS = vertexes.ToArray();

            for (int i = 0; i < VS.Length; i++)
            {
                VS[i].X = i + 1;
                VS[i].Y = i + 1;
                VS[i].Z = i + 1;
            }
        }

        private void BenchmarkCode2()
        {
            List<VertexStruct> vertexes = new List<VertexStruct>();

            for (int i = 0; i < numberBoxLoops.Value; i++)
            {
                vertexes.Add(new VertexStruct(i, i, i));
            }

            VertexStruct[] VS = vertexes.ToArray();

            for (int i = 0; i < VS.Length; i++)
            {
                VS[i].X = i + 1;
                VS[i].Y = i + 1;
                VS[i].Z = i + 1;
            }
        }
    }
}
