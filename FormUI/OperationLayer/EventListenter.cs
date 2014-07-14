using System;
using System.Collections;

namespace FormUI.OperationLayer
{
    public class EventListenter : ArrayList
    {
        public delegate void PortIsOpen(object sender, EventArgs e);

        public event PortIsOpen IsOpen;

        public void OnChange(EventArgs e)
        {
            if (IsOpen != null)
            {
                IsOpen(this, e);
            }
        }
    }
}