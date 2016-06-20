using MorseCodeRain.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MorseCodeRain.Sprites;

namespace MorseCodeRain
{
    public partial class MainForm : RenderForm
    {
        private readonly GameSoundPlayer soundPlayer = new GameSoundPlayer();
        private readonly HotkeyManager hkManager = new HotkeyManager();
        private readonly List<CodeSprite> codeSprites = new List<CodeSprite>();
        private readonly ScoreSprite scoreSprite = new ScoreSprite();
        private readonly FadeFromBlackSprite fadeSprite = new FadeFromBlackSprite();
        private readonly PauseSprite pauseSprite = new PauseSprite();
        private readonly WaveSprite waveSprite1 = new WaveSprite();
        private readonly WaveSprite waveSprite2 = new WaveSprite();
        private int lastWidth, secondsElapsed;

        /// <summary>
        /// The spawn frequency of the code in seconds.
        /// </summary>
        private const int MORSE_SPAWN_FREQ = 3;

        public bool Paused { get; set; }

        /// <summary>
        /// Gets or sets whether the game is in full-screen.
        /// </summary>
        private bool IsFullScreen
        {
            get
            {
                return FormBorderStyle == FormBorderStyle.None;
            }
            set
            {
                if (value)
                {
                    Cursor.Hide();
                    TopMost = true;
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                }
                else
                {
                    Cursor.Show();
                    TopMost = false;
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            InitHkManager();
            LoadSettingsAndDefaults();
            InitWaves();
            ScaleGraphics();
        }

        private void InitWaves()
        {
            // Large distant wave
            waveSprite1.RightToLeft = true;
            waveSprite1.WaveBasePercent = 0.15f;
            waveSprite1.WaveColor = Color.FromArgb(0, 120, 180);
            waveSprite1.ArcCount = 12;
            // Small close wave
            waveSprite2.WaveBasePercent = 0.08f;
            waveSprite2.WaveColor = Color.FromArgb(0, 140, 190);
            waveSprite2.ArcCount = 12;
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            Paused = true;
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            Paused = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.showFPS = ShowDebugInfo;
            Settings.Default.StartupFullScreen = IsFullScreen;
            Settings.Default.Save();
            base.OnClosing(e);
        }

        protected override void Render(Graphics graphics)
        {
            int frameRate = Paused ? 0 : FrameRate;
            waveSprite1.Draw(graphics, ClientSize, frameRate);
            UpdateCodeSprites(graphics);
            waveSprite2.Draw(graphics, ClientSize, frameRate);
            fadeSprite.Draw(graphics, ClientSize, frameRate);
            scoreSprite.Draw(graphics, ClientSize, frameRate);
            if (Paused) pauseSprite.Draw(graphics, ClientSize, frameRate);
            base.Render(graphics);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ScaleGraphics();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (hkManager.ProcessKeyArgs(e) || e.Control || Paused)
                return;

            MorseCode code = MorseCodeManager.GetMoreCode(e.KeyCode);
            bool isAnswer = false;

            foreach (CodeSprite sprite in codeSprites)
            {
                if (!sprite.AnsweredCorrectly && sprite.MorseCode.Equals(code))
                {
                    sprite.AnsweredCorrectly = true;
                    sprite.ForeColor = Color.GreenYellow;
                    isAnswer = true;
                    scoreSprite.Score++;
                    soundPlayer.PlayCorrect();
                }
            }

            if (!isAnswer)
            {
                scoreSprite.Score--;
                soundPlayer.PlayFail();
            }
        }

        protected override void OnSecondElapsed()
        {
            base.OnSecondElapsed();
            DebugCaption = "FPS: " + FrameRate;

            if (++secondsElapsed == MORSE_SPAWN_FREQ)
            {
                CodeSprite codeSprite = new CodeSprite(ClientSize);
                codeSprites.Add(codeSprite);
                DebugCaption = codeSprite.MorseCode.Key.ToString();
                secondsElapsed = 0;
            }
        }

        private void LoadSettingsAndDefaults()
        {
          //  MaxFramesPerSecond = Settings.Default.MaxFPS;
            IsFullScreen = Settings.Default.StartupFullScreen;
            ShowDebugInfo = Settings.Default.showFPS;
        }

        /// <summary>
        /// Scales the sprite graphics in relation to the size of the Client Area
        /// </summary>
        private void ScaleGraphics()
        {
            // Code sprites are only scaled to the width of the client area
            if (!lastWidth.Equals(ClientSize.Width))
            {
                foreach (CodeSprite sprite in codeSprites)
                    sprite.UpdateFontScale(ClientSize.Width);

                lastWidth = ClientSize.Width;
            }

            fadeSprite?.AdjustScale(ClientSize);
            pauseSprite.AdjustScale(ClientSize);
            waveSprite1.AdjustScale(ClientSize);
            waveSprite2.AdjustScale(ClientSize);
            scoreSprite.AdjustScale(ClientSize);
        }

        private void InitHkManager()
        {
            hkManager.AddHotkey("Exit", Keys.Escape, () =>
            {
                if (IsFullScreen)
                    IsFullScreen = !IsFullScreen;
                else
                    Close();
            });
            hkManager.AddHotkey("FullScreen", Keys.F11, () => IsFullScreen = !IsFullScreen);
            hkManager.AddHotkey("Pause", Keys.Pause, () => Paused = !Paused);
            hkManager.AddHotkey("Toggle FPS", Keys.T | Keys.Control, () => ShowDebugInfo = !ShowDebugInfo);
        }

        private void UpdateCodeSprites(Graphics graphics)
        {
            for (int i = 0; i < codeSprites.Count; i++)
            {
                // Remove code sprites outside the bounds of the form and subtract from score.
                if (codeSprites[i].YPercent > 1f - waveSprite2.WaveBasePercent)
                {
                    if (!codeSprites[i].AnsweredCorrectly)
                    {
                        scoreSprite.Score--;
                        soundPlayer.PlayRandomDrip();
                    }

                    codeSprites[i].Dispose();
                    codeSprites.RemoveAt(i);
                    i--;
                    continue;
                }

                codeSprites[i].Draw(graphics, ClientSize, FrameRate);
            }
        }
    }
}
