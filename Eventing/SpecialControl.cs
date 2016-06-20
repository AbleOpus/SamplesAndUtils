using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Eventing
{
    class SpecialControl : Control
    {
        // Keep track of last x pos to contrast with current x pos.
        private int lastXPos;
        // Create an event from the defined event delegate below
        // This is what will be "hooked" by the mainform.
        public event MovedLeftEventHandler MoveLeft;

        public SpecialControl()
        {
            // Make it visible.
            this.BackColor = Color.Red;
            // Set the lastpos as current pos at startup.
            // Avoiding any initial unwanted behavior.
            lastXPos = Location.X;
        }

        // Use the Move event in conjunction with our own.
        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);

            // If this control has moved left.
            if (lastXPos > Location.X)
            {
                int moveAmount = lastXPos - Location.X;
                // Construct event args which are defined below.
                MovedLeftEventArgs eventArgs = new MovedLeftEventArgs(moveAmount);
                // Raise event and pass in our event args.
                // Event args will be available to any object that has
                // registered to the MoveLeft event.
                OnMoveLeft(eventArgs);
            }

            // When were done calculating, save the last x position to contrast
            // with the current position the next time the mouse move event is raised.
            lastXPos = Location.X;
        }

        // This is the method defined for the MoveLeft event. Mark this event as private
        // if you will never override it. Otherwise mark it as protected virtual.

        /// <summary>
        /// Raises the <see cref="MoveLeft"/> event.
        /// </summary>
        protected virtual void OnMoveLeft(MovedLeftEventArgs e)
        {
            // Check to see if the event is handled anywhere (in simple terms).
            // This is where you send data to event handlers.
            // Send the object related to the event as first argument (in my case this control).
            // Send in e which is the event args passed in from onMouseMove with the moveAmountData.
            MoveLeft?.Invoke(this, e);
        }
    }

    // Define the delegate here, that can handle the MovedLeftEventArgs
    // You may be able to use a predefined eventArg derived type for what your doing
    // but here we will define our own.
    delegate void MovedLeftEventHandler(object sender, MovedLeftEventArgs e);

    // Define our own event args type. Typically these types expose read only properties
    // and the values are set through the constructor. In this example I only need the move amount.

    /// <summary>
    /// Provides event arguments for a <see cref="SpecialControl.MoveLeft"/> event.
    /// </summary>
    class MovedLeftEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the amount moved.
        /// </summary>
        public int MoveAmount { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MovedLeftEventArgs"/> class
        /// with the specified argument.
        /// </summary>
        /// <param name="moveAmount">The amount moved.</param>
        public MovedLeftEventArgs(int moveAmount)
        {
            MoveAmount = moveAmount;
        }
    }
}
