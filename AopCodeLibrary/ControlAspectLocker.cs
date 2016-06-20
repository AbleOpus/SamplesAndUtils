using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AboCodeLibrary
{
    /// <summary>
    /// Holds an array of controls and whether or not the controls should
    /// have a constrained aspect ratio.
    /// </summary>
    public class ControlAspectLocker
    {
        /// <summary>
        /// Associates the controls to be locked with their own lock states.
        /// </summary>
        private class LockedControl
        {
            private double aspectConstraint;

            private bool lockAspectRatio;
            /// <summary>
            /// Gets or sets whether or not to lock the aspect ratio.
            /// </summary>
            public bool LockAspectRatio
            {
                get { return lockAspectRatio; }
                set
                {
                    aspectConstraint = (double)Control.Height / Control.Width;
                    lockAspectRatio = value;
                }
            }

            public Control Control { get; }

            public LockedControl(Control control)
            {
                Control = control;
                Control.Resize += control_Resize;
            }

            private void control_Resize(object sender, EventArgs e)
            {
                if (lockAspectRatio)
                {
                    Control.Height = (int)(Control.Width * aspectConstraint + 0.5);
                }
            }
        }

        private readonly List<LockedControl> lockedControls = new List<LockedControl>();

        /// <summary>
        /// Accept a control collection as this is what Controls yields.
        /// </summary>
        public ControlAspectLocker(IEnumerable controls)
        {
            // Add the controls to the locked list.
            foreach (Control control in controls)
            {
                lockedControls.Add(new LockedControl(control));
            }
        }

        /// <summary>
        /// Locks the aspect ratio by setting a value to represent the constraint ratio.
        /// Also set lockAspectRatio for the resize event.
        /// </summary>
        public void LockAllControls()
        {
            foreach (LockedControl control in lockedControls)
            {
                control.LockAspectRatio = true;
            }
        }

        /// <summary>
        /// Unlocks the aspect ratio so that it can be resized in a free form fashion.
        /// </summary>
        public void UnlockAllControls()
        {
            foreach (LockedControl control in lockedControls)
            {
                control.LockAspectRatio = false;
            }
        }

        /// <summary>
        /// Sets all locked controls to be fully anchored (to all sides of its parent).
        /// </summary>
        public void FullAnchorControls()
        {
            foreach (LockedControl control in lockedControls)
            {
                control.Control.Anchor = AnchorStyles.Bottom | AnchorStyles.Left
                    | AnchorStyles.Right | AnchorStyles.Top;
            }
        }

        /// <summary>
        /// Sets all controls to not anchor, indirectly disabling the sizing constrain.
        /// </summary>
        public void UnAnchorControls()
        {
            foreach (LockedControl control in lockedControls)
            {
                control.Control.Anchor = AnchorStyles.None;
            }
        }

        /// <summary>
        /// Sets all controls to be anchored to the top and left of its parent.
        /// </summary>
        public void DefaultAnchorControls()
        {
            foreach (LockedControl control in lockedControls)
            {
                control.Control.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }
        }
    }
}
